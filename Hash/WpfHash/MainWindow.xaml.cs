using Hash;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace WpfHash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HashMaker makeHash;
        string hash;
        string fajl;
        public MainWindow()
        {
            InitializeComponent();
            makeHash = new HashMaker();
            comboAlgoritmus.Items.Add(HashType.MD5);
            comboAlgoritmus.Items.Add(HashType.SHA1);
            comboAlgoritmus.Items.Add(HashType.SHA256);
            comboAlgoritmus.Items.Add(HashType.SHA384);
            comboAlgoritmus.Items.Add(HashType.SHA512);
            comboAlgoritmus.SelectedIndex = 0;
            hash = "";
            fajl = "";
        }

        private void textboxSzoveg_TextChanged(object sender, TextChangedEventArgs e)
        {
            buttonTalloz.IsEnabled = false;
            if (textboxSzoveg.Text.Length == 0) {
                buttonTalloz.IsEnabled = true;
            }
        }

        private void buttonMakeHash_Click(object sender, RoutedEventArgs e)
        {
            if (fajl.Length>0)
            {
                hash = makeHash.CreateHash((HashType)comboAlgoritmus.SelectedItem, fajl);
            } else
            {
                hash = makeHash.CreateHash((HashType)comboAlgoritmus.SelectedItem, textboxSzoveg.Text);
            }

            if (textboxHash.Text.Length>0)
            {
                if (hash==textboxHash.Text)
                {
                    MessageBox.Show("A hash rendben!");
                   

                } else
                {
                    MessageBox.Show("Hibás hash!");
                  
                }
            }

            textboxHash.Text = hash;
            fajl = "";
        }

        private void buttonTalloz_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog()==true)
            {
                fajl = dialog.FileName;
            }
        }

        private void checkHash_Checked(object sender, RoutedEventArgs e)
        {
            textboxHash.IsReadOnly = false;
        }

        private void checkHash_Unchecked(object sender, RoutedEventArgs e)
        {
            textboxHash.IsReadOnly = true;
        }
    }
}
