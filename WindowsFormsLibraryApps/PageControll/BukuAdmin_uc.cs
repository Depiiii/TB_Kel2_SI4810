using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsLibraryApps.controller;
using MySql.Data.MySqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsLibraryApps.PageControll
{
    public partial class BukuAdmin_uc : UserControl
    {
        private string selectedImagePath = null;
        koneksi koneksi = new koneksi();

        public BukuAdmin_uc()
        {
            InitializeComponent();
            loadData();
            LoadKategoriToComboBox();
        }
        public void loadData()
        {

            try
            {
                koneksi.openConnection();
                string query_1002 = "SELECT id_buku, nama_buku, kategori, pengarang, penerbit, foto FROM buku";
                DataTable dt = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter(query_1002, koneksi.kon);
                adapter.Fill(dt);

                guna2DataGridView1.DataSource = dt;

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

                    kategoriBox.Items.Clear();
                    kategoriBox.Items.AddRange(kategoriValues);
                }

                guna2DataGridView1.Columns["id_buku"].HeaderText = "ID";
                guna2DataGridView1.Columns["kategori"].HeaderText = "Kategori";
                guna2DataGridView1.Columns["nama_buku"].HeaderText = "Judul";
                guna2DataGridView1.Columns["pengarang"].HeaderText = "Pengarang";
                guna2DataGridView1.Columns["penerbit"].HeaderText = "Penerbit";
                guna2DataGridView1.Columns["foto"].HeaderText = "Gambar";

                kategoriReader.Close();

                koneksi.closeConnection();
                searchBoxx.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    filterkategoriBox.Items.Clear();
                    filterkategoriBox.Items.AddRange(kategoriValues);
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

                if (filterkategoriBox.SelectedItem != null && filterkategoriBox.SelectedItem.ToString() != "")
                {
                    query_1002 += " AND kategori = @kategori";
                }

                if (!string.IsNullOrEmpty(searchBoxx.Text))
                {
                    query_1002 += " AND nama_buku LIKE @nama_buku";
                }

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query_1002, koneksi.kon);

                if (filterkategoriBox.SelectedItem != null && filterkategoriBox.SelectedItem.ToString() != "")
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@kategori", filterkategoriBox.SelectedItem.ToString());
                }

                if (!string.IsNullOrEmpty(searchBoxx.Text))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@nama_buku", "%" + searchBoxx.Text + "%");
                }

                adapter.Fill(dt);
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

        private void resetButton_Click_1(object sender, EventArgs e)
        {

            searchBoxx.Clear();
            kategoriBox.SelectedIndex = -1;
            judulBox.Clear();
            pengarangBox.Clear();
            penerbitBox.Clear();
            gambarBox.Image = null;
            filterkategoriBox.ResetText();
            loadData();
        }
        private void BukuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void labelBukuAdmin_Click(object sender, EventArgs e)
        {

        }

        private void Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (kategoriBox.SelectedItem != null)
            {
                string selectedKategori_1002 = kategoriBox.SelectedItem.ToString();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
           
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            ApplyFilters();
            try
            {
                koneksi.openConnection();
                string query_1002 = "SELECT id_buku, nama_buku, kategori, pengarang, penerbit, foto FROM buku WHERE nama_buku LIKE @nama_buku";

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query_1002, koneksi.kon);
                adapter.SelectCommand.Parameters.AddWithValue("@nama_buku", "%" + searchBoxx.Text + "%");

                adapter.Fill(dt);
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
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];


                kategoriBox.Text = row.Cells["kategori"].Value.ToString();
                judulBox.Text = row.Cells["nama_buku"].Value.ToString();
                pengarangBox.Text = row.Cells["pengarang"].Value.ToString();
                penerbitBox.Text = row.Cells["penerbit"].Value.ToString();


                string imagePath_1002 = row.Cells["foto"].Value.ToString();
                if (!string.IsNullOrEmpty(imagePath_1002) && File.Exists(imagePath_1002))
                {
                    gambarBox.Image = Image.FromFile(imagePath_1002);
                }
                else
                {
                    gambarBox.Image = null;
                }

            }
        }

        private void addBooks_importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_1002 = new OpenFileDialog();
            openFileDialog_1002.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog_1002.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog_1002.FileName))
                {
                    gambarBox.Image = Image.FromFile(openFileDialog_1002.FileName);
                    selectedImagePath = openFileDialog_1002.FileName;  
                }
                else
                {
                    MessageBox.Show("File gambar tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(kategoriBox.Text))
                {
                    MessageBox.Show("Kategori tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(judulBox.Text))
                {
                    MessageBox.Show("Judul buku tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(pengarangBox.Text))
                {
                    MessageBox.Show("Pengarang tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(penerbitBox.Text))
                {
                    MessageBox.Show("Penerbit tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (gambarBox.Image == null || string.IsNullOrEmpty(selectedImagePath))
                {
                    MessageBox.Show("Gambar buku tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string kategori_1002 = kategoriBox.SelectedItem.ToString();
                string judul_1002 = judulBox.Text;
                string pengarang_1002 = pengarangBox.Text;
                string penerbit_1002 = penerbitBox.Text;

                string folderPath_1002 = Path.Combine(Application.StartupPath, "Resources", "Images");
                if (!Directory.Exists(folderPath_1002))
                {
                    Directory.CreateDirectory(folderPath_1002);
                }


                string uniqueFileName_1002 = Guid.NewGuid().ToString() + ".jpg";
                string imagePath_1002 = Path.Combine(folderPath_1002, uniqueFileName_1002);

                File.Copy(selectedImagePath, imagePath_1002, true);


                string query_1002 = "INSERT INTO buku (nama_buku, kategori, pengarang, penerbit, foto) VALUES (@nama_buku, @kategori, @pengarang, @penerbit, @foto)";


                koneksi.openConnection();
                MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon);
                cmd.Parameters.AddWithValue("@nama_buku", judul_1002);
                cmd.Parameters.AddWithValue("@kategori", kategori_1002);
                cmd.Parameters.AddWithValue("@pengarang", pengarang_1002);
                cmd.Parameters.AddWithValue("@penerbit", penerbit_1002);
                cmd.Parameters.AddWithValue("@foto", imagePath_1002);

                cmd.ExecuteNonQuery();


                koneksi.closeConnection();


                MessageBox.Show("Buku berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                resetButton_Click_1(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void gambarBox_Click(object sender, EventArgs e)
        {
            if (gambarBox.Image != null)
            {

                Form gambarForm_1002 = new Form();
                PictureBox pictureBox = new PictureBox
                {
                    Image = gambarBox.Image,
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                gambarForm_1002.Controls.Add(pictureBox);
                gambarForm_1002.Text = "Lihat Gambar Buku";
                gambarForm_1002.WindowState = FormWindowState.Maximized;
                gambarForm_1002.Show();
            }
            else
            {
                MessageBox.Show("Gambar tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }

                if (guna2DataGridView1.SelectedRows.Count > 0)
                {

                    int selectedRowIndex_1002 = guna2DataGridView1.SelectedRows[0].Index;
                    int bukuId_1002 = Convert.ToInt32(guna2DataGridView1.Rows[selectedRowIndex_1002].Cells["id_buku"].Value);


                    string query_1002 = "DELETE FROM buku WHERE id_buku = @id_buku";


                    koneksi.openConnection();
                    MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon);
                    cmd.Parameters.AddWithValue("@id_buku", bukuId_1002);

                    cmd.ExecuteNonQuery();


                    koneksi.closeConnection();


                    MessageBox.Show("Buku berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resetButton_Click_1(sender, e);

                    loadData();
                }
                else
                {
                    MessageBox.Show("Silakan pilih buku yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(kategoriBox.Text))
                {
                    MessageBox.Show("Kategori tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(judulBox.Text))
                {
                    MessageBox.Show("Judul buku tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(pengarangBox.Text))
                {
                    MessageBox.Show("Pengarang tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(penerbitBox.Text))
                {
                    MessageBox.Show("Penerbit tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (guna2DataGridView1.SelectedRows.Count > 0)
                {
                    int idBuku_1002 = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["id_buku"].Value);

                    string query_1002 = "UPDATE buku SET kategori = @kategori, nama_buku = @judul, pengarang = @pengarang, penerbit = @penerbit WHERE id_buku = @id_buku";

                    koneksi.openConnection();
                    MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon);
                    cmd.Parameters.AddWithValue("@kategori", kategoriBox.Text);
                    cmd.Parameters.AddWithValue("@judul", judulBox.Text);
                    cmd.Parameters.AddWithValue("@pengarang", pengarangBox.Text);
                    cmd.Parameters.AddWithValue("@penerbit", penerbitBox.Text);
                    cmd.Parameters.AddWithValue("@id_buku", idBuku_1002);
                    cmd.ExecuteNonQuery();


                    if (!string.IsNullOrEmpty(selectedImagePath))
                    {

                        string folderPath_1002 = Path.Combine(Application.StartupPath, "Resources", "Images");
                        if (!Directory.Exists(folderPath_1002))
                        {
                            Directory.CreateDirectory(folderPath_1002);
                        }

                        string imageFileName_1002 = judulBox.Text + "" + idBuku_1002.ToString() + "" + Guid.NewGuid().ToString() + ".jpg";
                        string imagePath_1002 = Path.Combine(folderPath_1002, imageFileName_1002);

                        try
                        {
                            File.Copy(selectedImagePath, imagePath_1002, true);

                            string queryFoto_1002 = "UPDATE buku SET foto = @foto WHERE id_buku = @id_buku";
                            MySqlCommand cmdFoto = new MySqlCommand(queryFoto_1002, koneksi.kon);
                            cmdFoto.Parameters.AddWithValue("@foto", imagePath_1002);
                            cmdFoto.Parameters.AddWithValue("@id_buku", idBuku_1002);
                            cmdFoto.ExecuteNonQuery();
                        }
                        catch (IOException ioEx)
                        {
                            MessageBox.Show($"Error saat menyalin gambar: {ioEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    koneksi.closeConnection();
                    MessageBox.Show("Data buku berhasil diupdate.");
                    resetButton_Click_1(sender, e);
                }
                else
                {
                    MessageBox.Show("Pilih baris yang akan diupdate.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void filterkategoriBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void searchBoxx_TextChanged(object sender, EventArgs e)
        {

        }

        private void judulBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
    }


