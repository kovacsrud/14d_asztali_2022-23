using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace Osztasteszt
{
    public class Tests
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string WpfProgramId = @"D:\rud\kodtarak\13d_asztali_2022\WpfOsztas\WpfOsztas\bin\debug\WpfOsztas.exe";
        private const string WpfProgramPath = @"D:\rud\kodtarak\13d_asztali_2022\WpfOsztas\WpfOsztas\bin\debug\";

        protected static WindowsDriver<WindowsElement> driver;
        protected static ExtentReports extReport;
        protected static ExtentTest extTest;



        [OneTimeSetUp]
        public static void Setup()
        {
            if (driver==null)
            {
                var appiumOptions = new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", WpfProgramId);
                appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
                driver=new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl),appiumOptions);
            }
        }

        [OneTimeSetUp]
        public static void ReportSetup()
        {
            extReport = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"D:\rud\kodtarak\13d_asztali_2022\WpfOsztas\WpfOsztas\bin\debug\report.html");
            extReport.AddSystemInfo("Osztás teszt","Osztás automatizált teszt");
            extReport.AddSystemInfo("Tesztelõ", "Ubul");
            extReport.AttachReporter(htmlReporter);
            htmlReporter.Config.DocumentTitle = "HTML teszt riport";
            htmlReporter.Config.ReportName = "Osztás teszt";
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;


        }

        
        [Test]
        [TestCase(15,5,5)]
        [TestCase(25,5,5)]
        [TestCase(12.678,8.577,1.47813921)]
        public void Test1(double a,double b,double elvart)
        {
            extTest = extReport.CreateTest("Osztás teszt");

            var ertek_a = driver.FindElementByAccessibilityId("ertek_a");
            ertek_a.Clear();
            var ertek_b=driver.FindElementByAccessibilityId("ertek_b");
            ertek_b.Clear();
            ertek_a.SendKeys(a.ToString());
            ertek_b.SendKeys(b.ToString());
            driver.FindElementByAccessibilityId("buttonOsztas").Click();
            var eredmeny = driver.FindElementByAccessibilityId("eredmeny");

            Assert.AreEqual(elvart,Convert.ToDouble(eredmeny.Text),0.0005);
            extTest.Log(Status.Pass, "Osztás teszt rendben");
        }

        [TearDown]
        public static void CloseReport()
        {
            var a = TestContext.CurrentContext.Test.Arguments.GetValue(0);
            var b= TestContext.CurrentContext.Test.Arguments.GetValue(1);
            var elvart = TestContext.CurrentContext.Test.Arguments.GetValue(2);

            var filename = "error_"+a + "_" + b + "_" + elvart + ".png";
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktrace = TestContext.CurrentContext.Result.StackTrace;
            var errormsg = TestContext.CurrentContext.Result.Message;

            if (status==TestStatus.Failed)
            {
                ITakesScreenshot shot = (ITakesScreenshot)driver;
                Screenshot screenshot = shot.GetScreenshot();
                screenshot.SaveAsFile(WpfProgramPath+filename,ScreenshotImageFormat.Png);
                extTest.Log(Status.Fail, stacktrace + errormsg);
                extTest.Log(Status.Fail, "Képernyõ:");
                extTest.AddScreenCaptureFromPath(filename);
            }
        }

        [OneTimeTearDown]
        public void Endtest()
        {
            driver.Close();
            driver.Quit();
            extReport.Flush();
        }
    }
}