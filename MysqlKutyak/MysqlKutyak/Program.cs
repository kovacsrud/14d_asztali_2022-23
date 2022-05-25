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
            //DbInsert(conn, "Újkutya");
            //DbUpdate(conn, "Bubuka", 305);
            //DbDelete(conn,305);
            string sql = "SELECT nev,kutyanev,eletkor,utolsoell FROM kutyak,kutyanevek,kutyafajtak  WHERE kutyak.fajtaid=kutyafajtak.id and kutyak.nevid=kutyanevek.id;";
            DbRead(conn,sql);

            Console.ReadKey();
        }

        private static void DbDelete(MySqlConnection conn,int id)
        {
            try
            {
                //var id = 305;
                conn.Open();
                MySqlCommand command = new MySqlCommand("", conn);
                command.CommandText = "delete from kutyanevek where id=?id";
                command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                var sorok = command.ExecuteNonQuery();
                Console.WriteLine($"{sorok} rekord törölve!");
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DbUpdate(MySqlConnection conn,string ujKutyanev,int id)
        {
            try
            {
               // var ujKutyanev = "Bubuka";
               // var id = 304;
                conn.Open();
                MySqlCommand command = new MySqlCommand("", conn);
                command.CommandText = "update kutyanevek set kutyanev=?ujKutyanev where id=?id";
                command.Parameters.Add("?ujKutyanev", MySqlDbType.String).Value = ujKutyanev;
                command.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                var sorok = command.ExecuteNonQuery();
                Console.WriteLine($"{sorok} rekord módosítva!");
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DbInsert(MySqlConnection conn,string ujKutyanev)
        {
            try
            {
                //string ujKutyanev = "Bubucika";
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
        }

        private static void DbRead(MySqlConnection conn,string sql)
        {
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand("", conn);
                command.CommandText = sql;
                MySqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    Console.Write($"{rdr["nev"]},{rdr["kutyanev"]},{rdr["eletkor"]},{rdr["utolsoell"]}\n");
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
