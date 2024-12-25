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

namespace WindowsFormsLibraryApps.PageControll
{
    public partial class HistoriAdmin_uc : UserControl
    {
        koneksi koneksi = new koneksi();
        public HistoriAdmin_uc()
        {
            InitializeComponent();
            LoadKategoriToComboBox();
            LoadHistori();
        }
        private void LoadHistori()
        {
            try
            {
                koneksi.openConnection();
                filterDate.Value = DateTime.Now;
                string query_1002 = @"SELECT     
                                    ROW_NUMBER() OVER (ORDER BY pb.id_peminjaman_buku) AS No,pb.id_peminjaman_buku AS 'ID Peminjaman',
                                    b.nama_buku AS 'Nama Buku',
                                    b.kategori AS 'Kategori',
                                    u.nama_user AS 'Nama User',
                                    pb.tanggal_pinjam AS 'Tanggal Pinjam',
                                    pg.tanggal_pengembalian AS 'Tanggal Pengembalian',
                                    pg.denda AS 'Denda'
                                FROM peminjaman_buku pb
                                JOIN buku b ON pb.id_buku = b.id_buku
                                JOIN user u ON pb.id_user = u.id_user
                                LEFT JOIN pengembalian_buku pg ON pb.id_peminjaman_buku = pg.id_peminjaman_buku
                                WHERE pb.status = 'Kembali';";

                MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                guna2DataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat histori: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query_1002 = "SHOW COLUMNS FROM buku LIKE 'kategori';";
                MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon);
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

                string query_1002 = @"SELECT     
                    ROW_NUMBER() OVER (ORDER BY pb.id_peminjaman_buku) AS No,
                    pb.id_peminjaman_buku AS 'ID Peminjaman',
                    b.nama_buku AS 'Nama Buku',
                    b.kategori AS 'Kategori',
                    u.nama_user AS 'Nama User',
                    pb.tanggal_pinjam AS 'Tanggal Pinjam',
                    pg.tanggal_pengembalian AS 'Tanggal Pengembalian',
                    pg.denda AS 'Denda'
                FROM peminjaman_buku pb
                JOIN buku b ON pb.id_buku = b.id_buku
                JOIN user u ON pb.id_user = u.id_user
                LEFT JOIN pengembalian_buku pg ON pb.id_peminjaman_buku = pg.id_peminjaman_buku";

                List<string> filters = new List<string>();
                filters.Add("pb.status = 'Kembali'"); 

                if (comboBox1.SelectedIndex != -1)
                {
                    filters.Add("b.kategori = @kategori");
                }

                if (filterDate.Value != DateTime.MinValue)
                {
                    filters.Add("pb.tanggal_pinjam = @tanggalPinjam");
                }

                if (!string.IsNullOrEmpty(searchBoxx.Text))
                {
                    filters.Add("(b.nama_buku LIKE @search OR u.nama_user LIKE @search)");
                }

                if (filters.Count > 0)
                {
                    query_1002 += " WHERE " + string.Join(" AND ", filters);
                }

                MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon);

                if (comboBox1.SelectedIndex != -1)
                {
                    cmd.Parameters.AddWithValue("@kategori", comboBox1.SelectedItem.ToString());
                }
                if (filterDate.Value != DateTime.MinValue)
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
        

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int selectedID = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["ID Peminjaman"].Value);

                    DetailHistoriAdmin detailHistori = new DetailHistoriAdmin(selectedID);

                    Form parentForm = this.FindForm();

                    if (parentForm != null)
                    {
                        Panel panelContainer = parentForm.Controls["panelContainer"] as Panel; 

                        if (panelContainer != null)
                        {
                            panelContainer.Controls.Clear();  
                            panelContainer.Controls.Add(detailHistori);  
                        }
                        else
                        {
                            MessageBox.Show("Panel container tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Form induk tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memilih baris: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            try
            {
                searchBoxx.Clear();
                comboBox1.ResetText();
                filterDate.Value = DateTime.Now;
                LoadHistori();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mereset data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SearchistoriButton_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void searchBoxx_TextChanged(object sender, EventArgs e)
        {

        }

        private void filterDate_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void DetailButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2DataGridView1.SelectedRows.Count > 0)
                {
                    int selectedID_1002 = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells["ID Peminjaman"].Value);
                    DetailHistoriAdmin detailHistori = new DetailHistoriAdmin(selectedID_1002);


                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        Panel panelContainer = parentForm.Controls["panelContainer"] as Panel;

                        if (panelContainer != null)
                        {
                            panelContainer.Controls.Clear();  
                            panelContainer.Controls.Add(detailHistori); 
                        }
                        else
                        {
                            MessageBox.Show("Panel container tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Form induk tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Silakan pilih data dari tabel untuk melihat detail.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat membuka detail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HistoriAdmin_uc_Load(object sender, EventArgs e)
        {

        }

        private void historiBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
