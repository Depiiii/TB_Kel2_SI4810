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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsLibraryApps.PageControll
{
    public partial class PengembalianAdmin_uc : UserControl
    {

        koneksi koneksi = new koneksi();
        private int selectedPeminjamanId;
        public PengembalianAdmin_uc()
        {
            InitializeComponent();
            LoadKategoriToComboBox(); 
            LoadPengembalian();
        }
        private void LoadPengembalian()
        {
            try
            {
                koneksi.openConnection();
                filterDate.Value = DateTime.Now;
                string queryTabel_1002 = @"SELECT 
                    ROW_NUMBER() OVER (ORDER BY pb.id_peminjaman_buku) AS No,
                    pb.id_peminjaman_buku AS 'ID Peminjaman',
                    u.nama_user AS 'Nama User',
                    b.nama_buku AS 'Nama Buku',
                    b.kategori AS 'kategori',
                    pb.tanggal_pinjam AS 'Tanggal Pinjam',
                    pb.tanggal_kembali AS 'Tanggal Kembali',
                    pb.status AS 'Status'
                FROM peminjaman_buku pb
                JOIN buku b ON pb.id_buku = b.id_buku
                JOIN user u ON pb.id_user = u.id_user
                LEFT JOIN pengembalian_buku pg ON pb.id_peminjaman_buku = pg.id_peminjaman_buku
                WHERE pb.status = 'Dipinjam';";

                MySqlCommand cmd = new MySqlCommand(queryTabel_1002, koneksi.kon);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                guna2DataGridView1.DataSource = dt; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat pengembalian: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.closeConnection();
            }
        }
        private void LoadKategoriToComboBox()
        {
            try
            {
                koneksi.openConnection();
                string queryKategori_1002 = "SHOW COLUMNS FROM buku LIKE 'kategori';";
                MySqlCommand cmd = new MySqlCommand(queryKategori_1002, koneksi.kon);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string enumDefinition_1002 = reader["Type"].ToString();
                    string[] kategoriValues = enumDefinition_1002
                        .Replace("enum(", "")
                        .Replace(")", "")
                    .Replace("'", "")
                    .Split(',');

                    comboBox1.Items.Clear();
                    comboBox1.Items.AddRange(kategoriValues);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat kategori: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.closeConnection();
            }
        }
        private void ApplyFilters()
        {
            try
            {
                koneksi.openConnection();

                List<string> filters = new List<string>();
                string query = @"SELECT 
                                    ROW_NUMBER() OVER (ORDER BY pb.id_peminjaman_buku) AS No,pb.id_peminjaman_buku AS 'ID Peminjaman',
                                    u.nama_user AS 'Nama User',
                                    pb.tanggal_pinjam AS 'Tanggal Pinjam',b.kategori AS 'kategori',
                                    pb.tanggal_kembali AS 'Tanggal Kembali',
                                    pb.status AS 'Status',
                                    b.nama_buku AS 'Nama Buku'
                                FROM peminjaman_buku pb
                                JOIN buku b ON pb.id_buku = b.id_buku
                                JOIN user u ON pb.id_user = u.id_user
                                LEFT JOIN pengembalian_buku pg ON pb.id_peminjaman_buku = pg.id_peminjaman_buku
                                WHERE pb.status = 'Dipinjam'";

                if (comboBox1.SelectedIndex != -1)
                {
                    filters.Add("b.kategori = @kategori");
                }

                if (filterDate.Value.Date != DateTime.MinValue.Date)
                {
                    filters.Add("pb.tanggal_pinjam = @tanggalPinjam");
                }

                if (!string.IsNullOrEmpty(searchBoxx.Text))
                {
                    filters.Add("(b.nama_buku LIKE @search OR u.nama_user LIKE @search)");
                }

                if (filters.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", filters);
                }

                MySqlCommand cmd = new MySqlCommand(query, koneksi.kon);

                if (comboBox1.SelectedIndex != -1)
                {
                    cmd.Parameters.AddWithValue("@kategori", comboBox1.SelectedItem.ToString());
                }
                if (filterDate.Value.Date != DateTime.MinValue.Date)
                {
                    cmd.Parameters.AddWithValue("@tanggalPinjam", filterDate.Value.Date);
                }
                if (!string.IsNullOrEmpty(searchBoxx.Text))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchBoxx.Text + "%");
                }

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                guna2DataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat menerapkan filter: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.closeConnection();
            }
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            searchBoxx.Clear(); 
            comboBox1.ResetText();
            filterDate.Value = DateTime.Now; 
            LoadPengembalian(); 
        }

        private void filterDate_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void SearchistoriButton_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                NamaPeminjamBox.Text = row.Cells["Nama User"].Value.ToString();
                NamaBukuBox.Text = row.Cells["Nama Buku"].Value.ToString();
                KategoriBox.Text = row.Cells["Kategori"].Value.ToString();
                TGLPinjamBox.Text = row.Cells["Tanggal Pinjam"].Value.ToString();
                TGLKembaliBox.Text = row.Cells["Tanggal Kembali"].Value.ToString();
                selectedPeminjamanId = Convert.ToInt32(row.Cells["ID Peminjaman"].Value);
            }
        }

        private void DikembalikanButton_Click(object sender, EventArgs e)
        {
            if (selectedPeminjamanId == 0)
            {
                MessageBox.Show("Pilih baris untuk mengembalikan buku.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime tanggalHaruskembali_1002 = Convert.ToDateTime(TGLKembaliBox.Text);
            DateTime tanggalKembali_1002 = DateTime.Now;

            int keterlambatan = (tanggalKembali_1002 - tanggalHaruskembali_1002).Days;
            int denda_1002 = 0;

            if (keterlambatan > 0)
            {
                denda_1002 = keterlambatan * 7000;
            }

            try
            {
                koneksi.openConnection();

                // Validasi apakah selectedPeminjamanId masih ada di tabel peminjaman_buku
                string validasiQuery_1002 = "SELECT COUNT(*) FROM peminjaman_buku WHERE id_peminjaman_buku = @peminjamanId;";
                MySqlCommand validasiCmd = new MySqlCommand(validasiQuery_1002, koneksi.kon);
                validasiCmd.Parameters.AddWithValue("@peminjamanId", selectedPeminjamanId);
                int countID_1002 = Convert.ToInt32(validasiCmd.ExecuteScalar());

                if (countID_1002 == 0)
                {
                    MessageBox.Show("ID peminjaman tidak valid atau tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Jika validasi lolos, masukkan data ke tabel pengembalian_buku
                string queryPegembalian_1002 = @"INSERT INTO pengembalian_buku (id_peminjaman_buku, tanggal_pengembalian, denda) 
                         VALUES (@peminjamanId, @tanggalKembali, @denda);
                         UPDATE peminjaman_buku 
                         SET status = 'Kembali' 
                         WHERE id_peminjaman_buku = @peminjamanId";

                MySqlCommand cmd = new MySqlCommand(queryPegembalian_1002, koneksi.kon);
                cmd.Parameters.AddWithValue("@peminjamanId", selectedPeminjamanId);
                cmd.Parameters.AddWithValue("@tanggalKembali", tanggalKembali_1002);
                cmd.Parameters.AddWithValue("@denda", denda_1002);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Buku berhasil dikembalikan. Denda: Rp " + denda_1002, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPengembalian();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengembalikan buku: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.closeConnection();
            }
        }

        private void searchBoxx_TextChanged(object sender, EventArgs e) 
        {
            ApplyFilters();
        }

        private void NamaBukuBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ListPengembalianBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
