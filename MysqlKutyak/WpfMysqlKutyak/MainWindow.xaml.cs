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
using MySql.Data.MySqlClient;

namespace WpfMysqlKutyak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=kutyak;port=3306");
        List<Kutyak> kutyak = new List<Kutyak>();
        public MainWindow()
        {
            InitializeComponent();
            conn.Open();
            string sql = "SELECT kutyak.id,nev,kutyanev,eletkor,utolsoell FROM kutyak,kutyanevek,kutyafajtak  WHERE kutyak.fajtaid=kutyafajtak.id and kutyak.nevid=kutyanevek.id;";
            MySqlCommand command = new MySqlCommand("", conn);
            command.CommandText = sql;
            MySqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                kutyak.Add(new Kutyak
                {
                    Id = Convert.ToInt32(rdr["id"]),
                    Eletkor = Convert.ToInt32(rdr["eletkor"]),
                    Utolsoell = rdr["utolsoell"].ToString()
                });
            }
            conn.Close();
            kutyaadatok.ItemsSource = kutyak;

        }
    }
}
