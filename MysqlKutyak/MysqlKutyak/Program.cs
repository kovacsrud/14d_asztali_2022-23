using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MysqlKutyak
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=kutyak;port=3306");

            try
            {
                string ujKutyanev = "Bubucika";
                conn.Open();
                MySqlCommand command = new MySqlCommand("", conn);
                command.CommandText = "insert into kutyanevek (kutyanev) values(?ujkutyanev)";
                command.Parameters.Add("?ujkutyanev", MySqlDbType.String).Value = ujKutyanev;
                var sorok = command.ExecuteNonQuery();
                Console.WriteLine($"{sorok} sor beillesztve.");
                conn.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            DbRead(conn);

            Console.ReadKey();
        }

        private static void DbRead(MySqlConnection conn)
        {
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand("", conn);
                command.CommandText = "select * from kutyanevek";
                MySqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    Console.Write($"{rdr["id"]},{rdr["kutyanev"]}\n");
                }
                conn.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
