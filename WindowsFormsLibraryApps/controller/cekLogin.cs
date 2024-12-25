using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace WindowsFormsLibraryApps.controller
{
    internal class cekLogin
    {
        koneksi koneksi = new koneksi();

        public bool PeriksaLogin(string username, string password)
        {
            try
            {
                koneksi.openConnection();
                MySqlDataReader reader = koneksi.reader("SELECT * FROM user WHERE username='" + username + "' AND password='" + password + "'");
                if (reader.Read())
                {
                    koneksi.closeConnection();
                    return true;
                }
                else
                {
                    koneksi.closeConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal");
            }
            return false;
        }

        public string PeriksaRole_1002(string username, string password)
        {
            try
            {
                koneksi.openConnection();
                MySqlDataReader reader = koneksi.reader("SELECT role FROM user WHERE username='" + username + "' AND password='" + password + "'");

                if (reader.Read())
                {
                    string role = reader["role"].ToString();
                    koneksi.closeConnection();
                    return role; 
                }
                else
                {
                    koneksi.closeConnection();
                    return null; 
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal");
                koneksi.closeConnection();
                return null; 
            }
        }
    }
}