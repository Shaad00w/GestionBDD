using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_de_base_de_donnees
{
    class DBUtils
    {
        /// <summary>
        /// methode permettant de dire a l'application de se connecter
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection GetDBCOnnection()
        {
            string host = "localhost";
            int port = 3306;
            string dataBase = "mabdd";
            string username = "root";
            string password = "root";

            return DBMySQLUtils.GetDBConnection(host, port, dataBase, username, password);
        }
    }
}
