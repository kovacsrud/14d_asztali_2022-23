﻿using System;
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

namespace WpfPanelek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gombok(200);
        }

        public void Gombok(int darab)
        {
            for (int i = 0; i < darab; i++)
            {
                Button gomb = new Button();
                gomb.Content = i + 1;
                gomb.Width = 40;
                gomb.Margin = new Thickness(2,5,5,6);
                panelGombok.Children.Add(gomb);
            }
        }
    }
}
