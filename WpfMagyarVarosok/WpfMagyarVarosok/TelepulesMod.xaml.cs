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
    }
}
