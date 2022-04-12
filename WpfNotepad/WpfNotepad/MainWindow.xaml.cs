using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace WpfNotepad
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

        private void Megnyitas_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog()==true)
            {
                try
                {
                    textboxSzoveg.Text = File.ReadAllText(dialog.FileName, Encoding.Default);
                    this.Title = dialog.FileName;
                    //this.Title = dialog.FileName.Split('\\').Last();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                    
                }
                
            }
        }

        private void MentesMaskent_Click(object sender, RoutedEventArgs e)
        {
            MentesMaskent();

        }

        private void MentesMaskent()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == true)
            {
                try
                {
                    File.WriteAllText(dialog.FileName, textboxSzoveg.Text, Encoding.Default);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Mentes_Click(object sender, RoutedEventArgs e)
        {
            if (this.Title!="Notepad")
            {
                try
                {
                    File.WriteAllText(this.Title, textboxSzoveg.Text, Encoding.Default);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MentesMaskent();
            }
        }

        private void Kilepes_Click(object sender,RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
