using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MedicLabStudyApplication
{
    class UserInDatabaseChecker
    {
        public bool check(string login, string password)
        {
            string connStr = "server=liza.umcs.lublin.pl;user=krudzki;database=krudzki;password=kwiecien0404;SslMode=none";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            string sql = "SELECT username, password FROM members;";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader[0].ToString() == login)
                {
                    if (reader[1].ToString() == password)
                    {
                        Console.WriteLine("Successful");
                        return true;
                    }
                }
            }
            reader.Close();
            conn.Close();
            Console.WriteLine("Wrong login or password");
            return false;
        }




    }
}
