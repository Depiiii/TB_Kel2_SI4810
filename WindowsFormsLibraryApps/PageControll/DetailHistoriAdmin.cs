using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsLibraryApps.controller;

namespace WindowsFormsLibraryApps.PageControll
{
    public partial class DetailHistoriAdmin : UserControl
    {
        private int idPeminjaman;
        koneksi koneksi = new koneksi();
        public DetailHistoriAdmin(int idPeminjaman)
        {
            InitializeComponent();
            this.idPeminjaman = idPeminjaman;
            LoadDetailTransaksi();
        }
        private void LoadDetailTransaksi()
        {

            try
            {
                koneksi.openConnection();
                string query_1002 = @"SELECT 
                                    b.nama_buku AS 'Nama Buku',
                                    b.kategori AS 'Kategori',
                                    b.pengarang AS 'Pengarang',
                                    b.penerbit AS 'Penerbit',b.foto AS foto,u.username AS 'username',
                                    u.nama_user AS 'Nama Peminjam',
                                    u.gender AS 'Gender',
                                    u.email AS 'Email',
                                    pb.tanggal_pinjam AS 'Tanggal Pinjam',pb.status AS 'status',
                                    pb.tanggal_kembali AS 'Tanggal Kembali',
                                    pg.tanggal_pengembalian AS 'Tanggal Dikembalikan',
                                    pg.denda AS 'Denda'
                                FROM peminjaman_buku pb
                                JOIN buku b ON pb.id_buku = b.id_buku
                                JOIN user u ON pb.id_user = u.id_user
                                LEFT JOIN pengembalian_buku pg ON pb.id_peminjaman_buku = pg.id_peminjaman_buku
                                WHERE pb.id_peminjaman_buku = @idPeminjaman";

                MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon);
                cmd.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    NamaBukuBox.Text = reader["Nama Buku"].ToString();
                    KategoriBox.Text = reader["Kategori"].ToString();
                    PengarangBox2.Text = reader["Pengarang"].ToString();
                    UsernameBox.Text = reader["username"].ToString();
                    PenerbitBox1.Text = reader["Penerbit"].ToString();
                    NamaPeminjamBox.Text = reader["Nama Peminjam"].ToString();
                    GenderBox.Text = reader["Gender"].ToString();
                    EmailBox.Text = reader["Email"].ToString();
                    TGLPinjamBox.Text = reader["Tanggal Pinjam"].ToString();
                    StatusBox.Text = reader["status"].ToString();
                    TGLKembaliBox.Text = reader["Tanggal Kembali"].ToString();
                    TGLDikembalikanBox.Text = reader["Tanggal Dikembalikan"].ToString();
                    DendaBox.Text = reader["Denda"].ToString();
                    string imagePath_1002 = reader["foto"].ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat detail transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.closeConnection();
            }
        }
        private void gambarBox_Click(object sender, EventArgs e)
        {
            if (gambarBox.Image != null)
            {
                Form gambarForm_1002 = new Form();
                PictureBox pictureBox_1002 = new PictureBox
                {
                    Image = gambarBox.Image,
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                gambarForm_1002.Controls.Add(pictureBox_1002);
                gambarForm_1002.Text = "Lihat Gambar Buku";
                gambarForm_1002.WindowState = FormWindowState.Maximized;
                gambarForm_1002.Show();
            }
            else
            {
                MessageBox.Show("Gambar tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NamaBukuBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KategoriBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PengarangBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PenerbitBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NamaPeminjamBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmailBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UsernameBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TGLPinjamBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TGLKembaliBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TGLDikembalikanBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StatusBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DendaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kembaliButton_Click(object sender, EventArgs e)
        {
            try
            {
                HistoriAdmin_uc historiAdmin_1002 = new HistoriAdmin_uc();

                Form parentForm = this.FindForm();

                if (parentForm != null)
                {
                    Panel panelContainer = parentForm.Controls["panelContainer"] as Panel;

                    if (panelContainer != null)
                    {
                        panelContainer.Controls.Clear();  
                        panelContainer.Controls.Add(historiAdmin_1002);
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
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat kembali ke histori: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void detailHistori_Enter(object sender, EventArgs e)
        {

        }

        private void DetailHistoriAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
