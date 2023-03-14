using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WpfMagyarVarosok.Models;

namespace WpfMagyarVarosok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //magyar_telepulesekContext telepulesekContext;
        ContextAdapter contextAdapter;
        public MainWindow()
        {
            InitializeComponent();
            contextAdapter = new ContextAdapter();
            datagridTelepulesek.MouseDoubleClick += Grid_Click;
            
           
            

            DataContext = contextAdapter;
        }

        private void DbUpdate()
        {
            var muvelet = contextAdapter.context.SaveChanges();
            if (muvelet>0)
            {
                MessageBox.Show("Adatok mentve");
            } else
            {
                MessageBox.Show("Nincs változás!");
            }
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            DbUpdate();
        }

        private void Grid_Click(object sender,RoutedEventArgs e)
        {
            var selectedTelepules = datagridTelepulesek.SelectedItem as Telepulesek;
            TelepulesMod telepulesMod = new TelepulesMod(selectedTelepules,this);
            telepulesMod.ShowDialog();

            Debug.WriteLine(selectedTelepules.Nev);
        }
    }
}
