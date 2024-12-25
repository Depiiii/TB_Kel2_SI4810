using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsLibraryApps.controller;
using WindowsFormsLibraryApps.view;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsLibraryApps.PageControll
{
    public partial class BukuUser_uc : UserControl
    {
        koneksi koneksi = new koneksi();

        public BukuUser_uc()
        {
            InitializeComponent();
            LoadBooks();
            LoadKategoriToComboBox();

        }
        private bool isBookSelected = false;
        private void LoadBooks()
        {
            try
            {
                string query_1002 = "SELECT id_buku, nama_buku, kategori, pengarang, penerbit, foto FROM buku";
                MySqlCommand cmd_1002 = new MySqlCommand(query_1002, koneksi.kon);

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd_1002);
                adapter.Fill(dt);

                guna2DataGridView1.DataSource = dt;
                guna2DataGridView1.Columns["id_buku"].HeaderText = "ID";
                guna2DataGridView1.Columns["kategori"].HeaderText = "Kategori";
                guna2DataGridView1.Columns["nama_buku"].HeaderText = "Judul";
                guna2DataGridView1.Columns["pengarang"].HeaderText = "Pengarang";
                guna2DataGridView1.Columns["penerbit"].HeaderText = "Penerbit";
                guna2DataGridView1.Columns["foto"].HeaderText = "Gambar";
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error saat memuat buku: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadKategoriToComboBox()
        {
            try
            {
                koneksi.openConnection();
                string query = "SHOW COLUMNS FROM buku LIKE 'kategori';";
                MySqlCommand cmd = new MySqlCommand(query, koneksi.kon);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string enumDefinition = reader["Type"].ToString();
                    string[] kategoriValues = enumDefinition
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
                MessageBox.Show("Terjadi kesalahan saat memuat kategori: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplyFilters()
        {
            try
            {
                koneksi.openConnection();

                string query_1002 = "SELECT id_buku, nama_buku, kategori, pengarang, penerbit, foto FROM buku WHERE 1 = 1";

                if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() != "")
                {
                    query_1002 += " AND kategori = @kategori";

                }

                if (!string.IsNullOrEmpty(searchBoxx.Text))
                {
                    query_1002 += " AND nama_buku LIKE @nama_buku";
                }

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter_1002 = new MySqlDataAdapter(query_1002, koneksi.kon);

                if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString() != "")
                {
                    adapter_1002.SelectCommand.Parameters.AddWithValue("@kategori", comboBox1.SelectedItem.ToString());
                }

                if (!string.IsNullOrEmpty(searchBoxx.Text))
                {
                    adapter_1002.SelectCommand.Parameters.AddWithValue("@nama_buku", "%" + searchBoxx.Text + "%");
                }

                adapter_1002.Fill(dt);
                guna2DataGridView1.DataSource = dt;

                koneksi.closeConnection();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Data tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                MySqlCommand cmd_1002 = new MySqlCommand(query_1002, koneksi.kon);
                cmd_1002.Parameters.AddWithValue("@username", username_1002);

                MySqlDataReader reader = cmd_1002.ExecuteReader();
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

        private void GrupBoxSetBuku_Enter(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }


        private void kategoriBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void judulBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pengarangBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void penerbitBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            gambarBox.Image = null;
            LoadBooks();
            searchBoxx.Clear();
            judulBox.Clear();
            //kategoriBox.SelectedIndex = -1;
            pengarangBox.Clear();
            penerbitBox.Clear();
            kategoriBox.ResetText();
            comboBox1.ResetText();


        }

        private void gambarBox_Click(object sender, EventArgs e)
        {
            if (gambarBox.Image != null)
            {
                Form gambarForm = new Form();
                PictureBox pictureBox = new PictureBox
                {
                    Image = gambarBox.Image,
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                gambarForm.Controls.Add(pictureBox);
                gambarForm.Text = "Lihat Gambar Buku";
                gambarForm.WindowState = FormWindowState.Maximized;
                gambarForm.Show();
            }
            else
            {
                MessageBox.Show("Gambar tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BukuUser_uc_Load(object sender, EventArgs e)
        {

        }

       
        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isBookSelected = true;
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
                judulBox.Text = row.Cells["nama_buku"].Value.ToString();
                kategoriBox.Text = row.Cells["kategori"].Value.ToString();
                pengarangBox.Text = row.Cells["pengarang"].Value.ToString();
                penerbitBox.Text = row.Cells["penerbit"].Value.ToString();
                string imagePath = row.Cells["foto"].Value.ToString();
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    gambarBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    gambarBox.Image = null;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchBoxx_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int idUser_1002 = GetUserIdByLoggedInUsername();
            if (!isBookSelected)
            {
                MessageBox.Show("Silakan pilih buku terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (idUser_1002 == -1) return;
            try
            {

                if (guna2DataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Silakan pilih buku yang ingin dipinjam.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                int idBuku_1002 = Convert.ToInt32(selectedRow.Cells["id_buku"].Value);
                DateTime tanggalPinjam_1002 = DateTime.Today;
                DateTime tanggalKembali_1002 = tanggalPinjam_1002.AddDays(7);

                string insertQuery_1002 = "INSERT INTO peminjaman_buku (id_user, id_buku, tanggal_pinjam, tanggal_kembali, status) " + "VALUES (@id_user, @id_buku, @tanggal_pinjam, @tanggal_kembali, 'Dipinjam')";
                MySqlCommand cmd = new MySqlCommand(insertQuery_1002, koneksi.kon);
                cmd.Parameters.AddWithValue("@id_user", idUser_1002);
                cmd.Parameters.AddWithValue("@id_buku", idBuku_1002);
                cmd.Parameters.AddWithValue("@tanggal_pinjam", tanggalPinjam_1002);
                cmd.Parameters.AddWithValue("@tanggal_kembali", tanggalKembali_1002);

                koneksi.kon.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Buku berhasil dipinjam!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetButton_Click(sender, e);
                LoadBooks();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat meminjam buku: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                koneksi.kon.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat filter: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
