using System;

using MySql.Data.MySqlClient;

namespace MySqlTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = "51.15.118.65"; // Имя хоста
            string database = "testdb"; // Имя базы данных
            string user = "root"; // Имя пользователя
            Console.Write("Enter database password: ");
            string password = Console.ReadLine(); // Пароль пользователя

            //string connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password;
            //MySqlConnection mysql_connection = new MySqlConnection(connect);

            //mysql_connection.Open();

            //MySqlCommand mysql_query = mysql_connection.CreateCommand();
            //mysql_query.CommandText = "SELECT sas FROM kek;";

            //MySqlDataReader mysql_result;
            //mysql_result = mysql_query.ExecuteReader();
            //while (mysql_result.Read())
            //{
            //    Console.WriteLine("{0}", mysql_result.GetString(0));
            //}

            //Console.ReadLine();

            MySqlConnection connection = new MySqlConnection($"Server={host};" +
                                                             $"Database={database};" +
                                                             $"Uid={user};" +
                                                             $"Pwd={password}");

            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "select * from shrektable";

            var reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine(reader.GetString(0) + "\t\t" + reader.GetString(1) + "\t\t" + reader.GetString(2));

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
