using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;

namespace Osztasteszt
{
    public class Tests
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string WpfProgramId = @"D:\rud\kodtarak\13d_asztali_2022\WpfOsztas\WpfOsztas\bin\debug\WpfOsztas.exe";
        private const string WpfProgramPath = @"D:\rud\kodtarak\13d_asztali_2022\WpfOsztas\WpfOsztas\bin\debug";

        protected static WindowsDriver<WindowsElement> driver;



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

        [Test]
        [TestCase(15,5,3)]
        [TestCase(25,5,5)]
        [TestCase(12.678,8.577,1.47813921)]
        public void Test1(double a,double b,double elvart)
        {

            var ertek_a = driver.FindElementByAccessibilityId("ertek_a");
            ertek_a.Clear();
            var ertek_b=driver.FindElementByAccessibilityId("ertek_b");
            ertek_b.Clear();
            ertek_a.SendKeys(a.ToString());
            ertek_b.SendKeys(b.ToString());
            driver.FindElementByAccessibilityId("buttonOsztas").Click();
            var eredmeny = driver.FindElementByAccessibilityId("eredmeny");

            Assert.AreEqual(elvart,Convert.ToDouble(eredmeny.Text),0.0005);
        }

        [OneTimeTearDown]
        public void Endtest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}