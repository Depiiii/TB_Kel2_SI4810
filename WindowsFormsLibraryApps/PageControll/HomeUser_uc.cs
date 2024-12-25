using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsLibraryApps.controller;
using WindowsFormsLibraryApps.view;

namespace WindowsFormsLibraryApps.PageControll
{
    public partial class HomeUser_uc : UserControl
    {
        koneksi koneksi = new koneksi();
        public HomeUser_uc()
        {
            InitializeComponent();
        }

        private void HomeUser_uc_Load(object sender, EventArgs e)
        {
            NamaUser.Text = $"Selamat Datang, {FormLoginUser.LoggedIn}!";

            try
            {
                int totalPeminjaman_1002 = GetTotalPeminjaman(FormLoginUser.LoggedIn);
                int bukuBelumDikembalikan_1002 = GetBukuBelumDikembalikan(FormLoginUser.LoggedIn);

                qtypeminjamanUser.Text = totalPeminjaman_1002.ToString();
                qtypengembalianUser.Text = bukuBelumDikembalikan_1002.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetTotalPeminjaman(string username)
        {
            int total_1002 = 0;

            string query_1002 = @"SELECT COUNT(DISTINCT pb.id_peminjaman_buku) FROM peminjaman_buku pb JOIN user u ON pb.id_user = u.id_user WHERE u.username = @username";

            koneksi.openConnection();
            using (MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon))
            {
                cmd.Parameters.AddWithValue("@username", username);
                total_1002 = Convert.ToInt32(cmd.ExecuteScalar());
            }
            koneksi.closeConnection();

            return total_1002;
        }

        private int GetBukuBelumDikembalikan(string username)
        {
            int total_1002 = 0;

            string query_1002 = @" SELECT COUNT(pb.id_peminjaman_buku) FROM peminjaman_buku pb JOIN user u ON pb.id_user = u.id_user WHERE u.username = @username AND pb.status = 'Dipinjam'";

            koneksi.openConnection();
            using (MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon))
            {
                cmd.Parameters.AddWithValue("@username", username);
                total_1002 = Convert.ToInt32(cmd.ExecuteScalar());
            }
            koneksi.closeConnection();

            return total_1002;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void qtypeminjamanUser_Click(object sender, EventArgs e)
        {

        }

        private void qtypengembalianUser_Click(object sender, EventArgs e)
        {

        }

        private void totalbukuLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
