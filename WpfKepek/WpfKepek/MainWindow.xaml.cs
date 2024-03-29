﻿using Microsoft.Win32;
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

namespace WpfKepek
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

        private void buttonBetolt_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Jpg fájlok(*.jpg)|*.jpg|Png fájlok(*.png)|*.png|Minden fájl(*.*)|*.*";
            dialog.Multiselect = true;
            try
            {
                if (dialog.ShowDialog()==true)
                {
                    //imageKep.Source = new BitmapImage(new Uri(dialog.FileName));
                    for (int i = 0; i < dialog.FileNames.Length; i++)
                    {
                        
                        var image = new Image();
                        var bitmap = new BitmapImage(new Uri(dialog.FileNames[i]));
                        image.Source = bitmap;
                        wrapImages.Children.Add(image);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
    }
}
