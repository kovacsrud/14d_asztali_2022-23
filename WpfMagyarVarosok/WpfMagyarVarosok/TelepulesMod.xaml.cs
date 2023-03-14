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
        }
    }
}
