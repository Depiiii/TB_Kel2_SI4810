using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsLibraryApps.controller;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using WindowsFormsLibraryApps.view;

namespace WindowsFormsLibraryApps.PageControll
{
    public partial class HomeAdmin_uc : UserControl
    {
        koneksi koneksi = new koneksi();
        public HomeAdmin_uc()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            NamaAdmin.Text = $"Selamat Datang BOS ADMIN, {FormLoginAdmin.LoggedIn}!";

            try
            {
                koneksi.openConnection();
                string userQuery_1002 = "SELECT COUNT(*) FROM user";
                MySqlCommand userCmd = new MySqlCommand(userQuery_1002, koneksi.kon);
                int totalUser_1002 = Convert.ToInt32(userCmd.ExecuteScalar());
                qtyuserLabel.Text = totalUser_1002.ToString();

                string bukuQuery_1002 = "SELECT COUNT(*) FROM buku";
                MySqlCommand bukuCmd = new MySqlCommand(bukuQuery_1002, koneksi.kon);
                int totalBuku_1002 = Convert.ToInt32(bukuCmd.ExecuteScalar());
                qtybukuLabel.Text = totalBuku_1002.ToString();
                string pinjamQuery_1002 = "SELECT COUNT(*) FROM peminjaman_buku";
                MySqlCommand pinjamCmd = new MySqlCommand(pinjamQuery_1002, koneksi.kon);
                int totalPinjam_1002 = Convert.ToInt32(pinjamCmd.ExecuteScalar());
                qtypinjamLabel.Text = totalPinjam_1002.ToString();

                koneksi.closeConnection();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayAB()
        {

        }
        private void totalbukuLabel_Click(object sender, EventArgs e)
        {

        }

        private void HomeAdmin_uc_Load(object sender, EventArgs e)
        {

        }

        private void qtypinjamLabel_Click(object sender, EventArgs e)
        {

        }

        private void qtybukuLabel_Click(object sender, EventArgs e)
        {

        }

        private void qtyuserLabel_Click(object sender, EventArgs e)
        {
        }

        private void totaluserPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totaluserLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalpinjamLabel_Click(object sender, EventArgs e)
        {

        }
    }
}