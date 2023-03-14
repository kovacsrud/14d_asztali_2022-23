using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfMagyarVarosok.Models;

namespace WpfMagyarVarosok
{
    /// <summary>
    /// Interaction logic for TelepulesMod.xaml
    /// </summary>
    public partial class TelepulesMod : Window
    {
        Telepulesek selectedTelepules;
        MainWindow mainWindow;
        public TelepulesMod(Telepulesek telepules,MainWindow mainwindow)
        {
            InitializeComponent();
            selectedTelepules = telepules;
            mainWindow = mainwindow;
            DataContext = mainWindow.contextAdapter;
            textboxIrszam.Text = selectedTelepules.Irszam.ToString();
            textboxNev.Text = selectedTelepules.Nev;
            comboboxMegye.SelectedValue = selectedTelepules.Megyekod;
            textboxLat.Text = selectedTelepules.Lat.ToString();
            textboxLong.Text = selectedTelepules.Long.ToString();
            textboxKshkod.Text = selectedTelepules.Kshkod;
            comboboxJogallas.SelectedValue = selectedTelepules.Jogallas;
            textboxTerulet.Text = selectedTelepules.Terulet.ToString();
            textboxNepesseg.Text = selectedTelepules.Nepesseg.ToString();
            textboxLakasok.Text = selectedTelepules.Lakasok.ToString();
        }

        private void buttonModosit_Click(object sender, RoutedEventArgs e)
        {
            var valasz = MessageBox.Show("Biztosan módosítja?", "Adatmódosítás", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (valasz==MessageBoxResult.OK)
            {
                try
                {
                    selectedTelepules.Irszam = Convert.ToInt32(textboxIrszam.Text);
                    selectedTelepules.Nev= textboxNev.Text;
                    selectedTelepules.Megyekod= comboboxMegye.SelectedValue.ToString();
                    selectedTelepules.Lat = Convert.ToDouble(textboxLat.Text);
                    selectedTelepules.Long = Convert.ToDouble(textboxLong.Text);
                    selectedTelepules.Kshkod= textboxKshkod.Text;
                    selectedTelepules.Jogallas= Convert.ToInt32(comboboxJogallas.SelectedValue);
                    selectedTelepules.Terulet = Convert.ToInt32(textboxTerulet.Text);
                    selectedTelepules.Nepesseg = Convert.ToInt32(textboxNepesseg.Text);
                    selectedTelepules.Lakasok = Convert.ToInt32(textboxLakasok.Text);

                    var muvelet = mainWindow.contextAdapter.context.SaveChanges();
                    mainWindow.datagridTelepulesek.Items.Refresh();
                    if (muvelet>0)
                    {
                        MessageBox.Show("A módosítás mentve", "Mentés", MessageBoxButton.OK, MessageBoxImage.Information);
                        
                    } else
                    {
                        MessageBox.Show("Nem történt módosítás", "Mentés", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
 


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);                    
                }
            }
        }
    }
}
