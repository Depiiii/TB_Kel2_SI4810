using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class HistoriUser_uc : UserControl
    {
        koneksi koneksi = new koneksi();
        public HistoriUser_uc()
        {
            InitializeComponent();
            LoadKategoriToComboBox();
            LoadHistoriUser();
        }
        private int GetUserIdByLoggedInUsername()
        {
            try
            {
                string username_1002 = FormLoginUser.LoggedIn;
                if (string.IsNullOrEmpty(username_1002))
                {
                    MessageBox.Show("Anda belum login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;
                }

                koneksi.openConnection();
                string query_1002 = "SELECT id_user FROM user WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon);
                cmd.Parameters.AddWithValue("@username", username_1002);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int idUser_1002 = Convert.ToInt32(reader["id_user"]);
                    koneksi.closeConnection();
                    return idUser_1002;
                }
                else
                {
                    koneksi.closeConnection();
                    MessageBox.Show("ID pengguna tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Gagal mengambil ID User: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                koneksi.closeConnection();
                return -1;
            }
        }

        private void LoadKategoriToComboBox()
        {
            try
            {
                koneksi.openConnection();
                string kategoriQuery_1002 = "SHOW COLUMNS FROM buku LIKE 'kategori'";
                MySqlCommand kategoriCmd_1002 = new MySqlCommand(kategoriQuery_1002, koneksi.kon);
                MySqlDataReader kategoriReader = kategoriCmd_1002.ExecuteReader();

                if (kategoriReader.Read())
                {
                    string enumDefinition_1002 = kategoriReader["Type"].ToString();
                    string[] kategoriValues = enumDefinition_1002
                        .Replace("enum(", "")
                        .Replace(")", "")
                        .Replace("'", "")
                        .Split(',');

                    comboBox1.Items.Clear();
                    comboBox1.Items.AddRange(kategoriValues);
                }
                koneksi.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat kategori: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                koneksi.closeConnection();
            }
        }

        private void LoadHistoriUser()
        {
            try
            {
                int idUser_1002 = GetUserIdByLoggedInUsername();
                if (idUser_1002 == -1) return;
                filterDate.Value = DateTime.Now;
                string query_1002 = @"SELECT 
                ROW_NUMBER() OVER (ORDER BY pb.id_peminjaman_buku) AS 'No.',
                b.nama_buku AS 'Nama Buku',b.kategori AS 'kategori',
                pb.tanggal_pinjam AS 'Tanggal Pinjam',
                pb.tanggal_kembali AS 'Tanggal Kembali',
                pb.status AS 'Status',
                IFNULL(nb.tanggal_pengembalian, '-') AS 'kembali pada',
                CASE 
                    WHEN nb.tanggal_pengembalian IS NOT NULL AND nb.tanggal_pengembalian > pb.tanggal_kembali 
                    THEN DATEDIFF(nb.tanggal_pengembalian, pb.tanggal_kembali) * 7000
                    ELSE 0
                END AS 'Denda'
            FROM peminjaman_buku pb
            LEFT JOIN pengembalian_buku nb ON pb.id_peminjaman_buku = nb.id_peminjaman_buku
            INNER JOIN buku b ON pb.id_buku = b.id_buku
            WHERE pb.id_user = @id_user";

                MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon);
                cmd.Parameters.AddWithValue("@id_user", idUser_1002);

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                guna2DataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memuat histori: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HistoriUser_uc_Load(object sender, EventArgs e)
        {

        }
        private void labelHistoriAdmin_Click(object sender, EventArgs e)
        {

        }


        private void SearchistoriButton_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void ApplyFilters()
        {
            try
            {
                int idUser_1002 = GetUserIdByLoggedInUsername();
                if (idUser_1002 == -1) return;

                List<string> filters = new List<string>();

                string query_1002 = @"
            SELECT 
                ROW_NUMBER() OVER (ORDER BY pb.id_peminjaman_buku) AS 'No.', 
                b.nama_buku AS 'Nama Buku', b.kategori AS 'kategori',
                pb.tanggal_pinjam AS 'Tanggal Pinjam', 
                pb.tanggal_kembali AS 'Tanggal Kembali', 
                pb.status AS 'Status', 
                IFNULL(hb.tanggal_pengembalian, '-') AS 'Tanggal Pengembalian', 
                IFNULL(hb.denda, 0) AS 'Denda'
            FROM peminjaman_buku pb 
            INNER JOIN buku b ON pb.id_buku = b.id_buku
            LEFT JOIN pengembalian_buku hb ON pb.id_peminjaman_buku = hb.id_peminjaman_buku 
            WHERE pb.id_user = @id_user";

                if (comboBox1.SelectedIndex != -1)
                {
                    filters.Add("b.kategori = @kategori");
                }

                if (filterDate.Value.Date != DateTime.Now.Date)
                {
                    filters.Add("pb.tanggal_pinjam = @tanggalPinjam");
                }

                if (!string.IsNullOrEmpty(searchBoxx.Text))
                {
                    filters.Add("b.nama_buku LIKE @search");
                }

                if (filters.Count > 0)
                {
                    query_1002 += " AND " + string.Join(" AND ", filters);
                }

                MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon);
                cmd.Parameters.AddWithValue("@id_user", idUser_1002);

                if (comboBox1.SelectedIndex != -1)
                {
                    cmd.Parameters.AddWithValue("@kategori", comboBox1.SelectedItem.ToString());
                }

                if (filterDate.Value.Date != DateTime.Now.Date)
                {
                    cmd.Parameters.AddWithValue("@tanggalPinjam", filterDate.Value.ToString("yyyy-MM-dd"));
                }

                if (!string.IsNullOrEmpty(searchBoxx.Text))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchBoxx.Text + "%");
                }

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                guna2DataGridView1.DataSource = dt;

                guna2DataGridView1.Columns["No."].HeaderText = "No.";
                guna2DataGridView1.Columns["Nama Buku"].HeaderText = "Nama Buku";
                guna2DataGridView1.Columns["kategori"].HeaderText = "Kategori";
                guna2DataGridView1.Columns["Tanggal Pinjam"].HeaderText = "Tanggal Pinjam";
                guna2DataGridView1.Columns["Tanggal Kembali"].HeaderText = "Tanggal Kembali";
                guna2DataGridView1.Columns["Status"].HeaderText = "Status";
                guna2DataGridView1.Columns["Tanggal Pengembalian"].HeaderText = "Kembali Pada";
                guna2DataGridView1.Columns["Denda"].HeaderText = "Denda (Rp)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat menerapkan filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchBoxx_TextChanged(object sender, EventArgs e)
        {

        }

        private void filterDate_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            searchBoxx.Clear();
            comboBox1.ResetText();
            filterDate.Value = DateTime.Now;
            LoadHistoriUser();


        }

        private void historiBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
