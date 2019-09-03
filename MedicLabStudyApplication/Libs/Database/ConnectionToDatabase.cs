using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicLabStudyApplication.Libs.Database
{
    class ConnectionToDatabase
    {
        public static MySqlConnection getNewConnection()
        {
            return new MySqlConnection("server=liza.umcs.lublin.pl;user=krudzki;database=krudzki;password=kwiecien0404;SslMode=none");
        }
    }
}
