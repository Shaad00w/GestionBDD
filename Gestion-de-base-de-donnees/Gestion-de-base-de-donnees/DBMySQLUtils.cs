using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_de_base_de_donnees
{
    class DBMySQLUtils
    {
        /// <summary>
        /// methode qui permet de donner les informations souhaitées
        /// </summary>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <param name="databBase"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static MySqlConnection GetDBConnection(string host, int port, string databBase, string username, string password)
        {
            ///connection string
            string logString = "Server =" + host + ";Database=" + databBase + ";port=" + port + ";User id=" + username + " ;password=" + password;

            MySqlConnection login = new MySqlConnection(logString);

            return login;
        }
    }
}
