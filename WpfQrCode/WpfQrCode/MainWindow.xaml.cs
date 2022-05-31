using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Microsoft.Win32;

namespace WpfQrCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonCoding_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                QRCodeEncoder encoder = new QRCodeEncoder();
                Bitmap qrBitmap=encoder.Encode(textboxQrSzoveg.Text,Encoding.UTF8);
                qrBitmap.Save("qr.png");
                using (MemoryStream ms = new MemoryStream())
                {
                    qrBitmap.Save(ms, ImageFormat.Png);
                    ms.Position = 0;
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = ms;
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.EndInit();
                    imageQRcode.Source = bitmapImage;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".png fájlok|*.png";
            if (dialog.ShowDialog()==true)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(dialog.FileName));
                imageQRDecode.Source = bitmapImage;

                QRCodeDecoder decoder = new QRCodeDecoder();
                
                using (MemoryStream ms=new MemoryStream())
                {
                    BitmapEncoder bitmapEncoder = new PngBitmapEncoder();
                    bitmapEncoder.Frames.Add(BitmapFrame.Create(bitmapImage));
                    bitmapEncoder.Save(ms);
                    Bitmap dekodolni = new Bitmap(ms);
                    textboxQrDecodeSzoveg.Text = decoder.Decode(new QRCodeBitmapImage(dekodolni));
                }
            }
        }
    }
}
