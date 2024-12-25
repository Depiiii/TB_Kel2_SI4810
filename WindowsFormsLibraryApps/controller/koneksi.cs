using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsLibraryApps.controller
{
    internal class koneksi
    {
        string mysqlconn = "Server=localhost; Database=perpus; Uid=root; Pwd=;";
        public MySqlConnection kon;
        //static readonly string server = "127.0.0.1";
        //static readonly string user = "root";
        //static readonly string password = "";
        //static readonly string database = "perpus";
        //public static string connection_string = "server'" + server + "'; user'" + user + "';password'" + password + "'database'" + database + "'";
        //public MySqlConnection MySqlConnection = new MySqlConnection(connection_string);
        public koneksi()
        {
            kon = new MySqlConnection(mysqlconn);
        }
        public void openConnection()
        {
            kon = new MySqlConnection(mysqlconn);
            kon.Open();
        }
        public void closeConnection()
        {
            kon.Close();
        }
        public void ExecuteQuery(string query)
        {
            MySqlCommand Command = new MySqlCommand(query, kon);
            Command.ExecuteNonQuery();
        }
        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, mysqlconn);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object bebas = data.Tables[0];
            return bebas;

        }
        public MySqlDataReader reader(string query)
        {

            MySqlCommand cmd = new MySqlCommand(query, kon);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}

        //public bool connect_db()
        //{
        //    try
        //    {
        //        MySqlConnection.Open();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
//    }
//}