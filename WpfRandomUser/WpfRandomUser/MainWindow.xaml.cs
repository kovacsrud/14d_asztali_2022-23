using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace WpfRandomUser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Users users;
        public MainWindow()
        {
            InitializeComponent();
            comboUserNumber.Items.Add(5);
            comboUserNumber.Items.Add(10);
            comboUserNumber.Items.Add(20);
            comboUserNumber.Items.Add(50);
            comboUserNumber.SelectedIndex = 0;
        }

        public Users GetUsers(int db)
        {
            JObject userJson = JObject.Parse(new WebClient().DownloadString($"https://randomuser.me/api/?results={db}"));
            Users result = userJson.ToObject<Users>();
            return result;
        }

        private void buttonLetolt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                users = GetUsers((int)comboUserNumber.SelectedItem);
                datagridUsers.DataContext = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }

        private void buttonNyomtat_Click(object sender, RoutedEventArgs e)
        {
            if (users != null)
            {
                PrintView printView = new PrintView(users);
                printView.ShowDialog();
            } else
            {
                MessageBox.Show("Először kérjen le adatokat!");
            }
            
        }
    }
}
