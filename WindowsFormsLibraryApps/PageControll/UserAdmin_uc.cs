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

namespace WindowsFormsLibraryApps.PageControll
{
    public partial class UserAdmin_uc : UserControl
    {
        koneksi koneksi = new koneksi();
        public UserAdmin_uc()
        {
            InitializeComponent();
            loadData();
            LoadRoleToComboBox();
        }
        private int selectedUserId = 0;
        private void labelHomeAdmin_Click(object sender, EventArgs e)
        {

        }

        public void loadData()
        {
            try
            {
                koneksi.openConnection();
                string query_1002 = "SELECT id_user, nama_user, gender, email, username, password, role FROM user";
                DataTable dt = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter(query_1002, koneksi.kon);
                adapter.Fill(dt);

                guna2DataGridView1.DataSource = dt;

                guna2DataGridView1.Columns["id_user"].HeaderText = "ID";
                guna2DataGridView1.Columns["nama_user"].HeaderText = "Nama";
                guna2DataGridView1.Columns["gender"].HeaderText = "Gender";
                guna2DataGridView1.Columns["email"].HeaderText = "Email";
                guna2DataGridView1.Columns["username"].HeaderText = "Username";
                guna2DataGridView1.Columns["password"].HeaderText = "Password";
                guna2DataGridView1.Columns["role"].HeaderText = "Role";

                string genderQuery_1002 = "SHOW COLUMNS FROM user LIKE 'gender'";
                MySqlCommand genderCmd = new MySqlCommand(genderQuery_1002, koneksi.kon);
                MySqlDataReader genderReader = genderCmd.ExecuteReader();
                if (genderReader.Read())
                {
                    string enumDefinition = genderReader["Type"].ToString();
                    string[] genderValues = enumDefinition
                        .Replace("enum(", "")
                        .Replace(")", "")
                        .Replace("'", "")
                        .Split(',');

                    genderBox.Items.Clear();
                    genderBox.Items.AddRange(genderValues);
                }
                genderReader.Close();

                string roleQuery_1002 = "SHOW COLUMNS FROM user LIKE 'role'";
                MySqlCommand roleCmd = new MySqlCommand(roleQuery_1002, koneksi.kon);
                MySqlDataReader roleReader = roleCmd.ExecuteReader();
                if (roleReader.Read())
                {
                    string enumDefinition_1002 = roleReader["Type"].ToString();
                    string[] roleValues = enumDefinition_1002
                        .Replace("enum(", "")
                        .Replace(")", "")
                        .Replace("'", "")
                        .Split(',');

                    roleBoxx.Items.Clear();
                    roleBoxx.Items.AddRange(roleValues);
                }
                roleReader.Close();

                koneksi.closeConnection();
                searchBoxx.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ApplyFilters()
        {
            try
            {
                koneksi.openConnection();
                StringBuilder queryBuilder = new StringBuilder("SELECT id_user, nama_user, gender, email, username, password, role FROM user WHERE 1=1");

                if (!string.IsNullOrWhiteSpace(searchBoxx.Text))
                {
                    queryBuilder.Append(" AND nama_user LIKE @nama_user");
                }

                if (roleBox.SelectedIndex >= 0)
                {
                    queryBuilder.Append(" AND role = @role");
                }

                DataTable dt = new DataTable();
                MySqlCommand command = new MySqlCommand(queryBuilder.ToString(), koneksi.kon);

                if (!string.IsNullOrWhiteSpace(searchBoxx.Text))
                {
                    command.Parameters.AddWithValue("@nama_user", "%" + searchBoxx.Text + "%");
                }

                if (roleBox.SelectedIndex >= 0)
                {
                    command.Parameters.AddWithValue("@role", roleBox.SelectedItem.ToString());
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
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
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadRoleToComboBox()
        {
            try
            {
                koneksi.openConnection();
                string query = "SHOW COLUMNS FROM user LIKE 'role'";
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

                    roleBox.Items.Clear();
                    roleBox.Items.AddRange(kategoriValues);
                }
                koneksi.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat kategori: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UserAdmin_uc_Load(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Penerbit_Click(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void role_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void setboxUser1_Enter(object sender, EventArgs e)
        {

        }

        private void namaUser_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedUserId == 0)
                {
                    MessageBox.Show("Pilih data user terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "DELETE FROM user WHERE id_user = @id_user";
                koneksi.openConnection();
                MySqlCommand cmd = new MySqlCommand(query, koneksi.kon);
                cmd.Parameters.AddWithValue("@id_user", selectedUserId);

                cmd.ExecuteNonQuery();
                koneksi.closeConnection();

                MessageBox.Show("User berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetButton_Click(sender, e);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(namauserBox.Text))
                {
                    MessageBox.Show("Nama user tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(genderBox.Text))
                {
                    MessageBox.Show("Gender tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(emailBox.Text))
                {
                    MessageBox.Show("Email tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(usernameBox.Text))
                {
                    MessageBox.Show("Username tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(passwordBoxx.Text))
                {
                    MessageBox.Show("Password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(roleBoxx.Text))
                {
                    MessageBox.Show("Role tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (selectedUserId == 0)
                {
                    MessageBox.Show("Pilih data user terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query_1002 = "UPDATE user SET nama_user = @nama_user, gender = @gender, email = @email, username = @username, password = @password, role = @role WHERE id_user = @id_user";
                koneksi.openConnection();
                MySqlCommand cmd = new MySqlCommand(query_1002, koneksi.kon);
                cmd.Parameters.AddWithValue("@id_user", selectedUserId);
                cmd.Parameters.AddWithValue("@nama_user", namauserBox.Text);
                cmd.Parameters.AddWithValue("@gender", genderBox.Text);
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.Parameters.AddWithValue("@username", usernameBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordBoxx.Text);
                cmd.Parameters.AddWithValue("@role", roleBoxx.Text);

                cmd.ExecuteNonQuery();
                koneksi.closeConnection();

                MessageBox.Show("User berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetButton_Click(sender, e);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tambahButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(namauserBox.Text))
                {
                    MessageBox.Show("Nama user tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(genderBox.Text))
                {
                    MessageBox.Show("Gender tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(emailBox.Text))
                {
                    MessageBox.Show("Email tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(usernameBox.Text))
                {
                    MessageBox.Show("Username tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(passwordBoxx.Text))
                {
                    MessageBox.Show("Password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(roleBoxx.Text))
                {
                    MessageBox.Show("Role tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nama = namauserBox.Text;
                string gender = genderBox.SelectedItem.ToString();
                string email = emailBox.Text;
                string username = usernameBox.Text;
                string password = passwordBoxx.Text;
                string role = roleBoxx.SelectedItem.ToString();

                string query = "INSERT INTO user (nama_user, gender, email, username, password, role) VALUES (@nama_user, @gender, @email, @username, @password, @role)";

                koneksi.openConnection();
                MySqlCommand cmd = new MySqlCommand(query, koneksi.kon);
                cmd.Parameters.AddWithValue("@nama_user", nama);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password); 
                cmd.Parameters.AddWithValue("@role", role);

                cmd.ExecuteNonQuery();
                koneksi.closeConnection();

                MessageBox.Show("User berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                resetButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            try
            {
                searchBoxx.Clear();
                namauserBox.Clear();
                emailBox.Clear();
                usernameBox.Clear();
                passwordBoxx.Clear();
                genderBox.SelectedIndex = -1;
                roleBoxx.SelectedIndex = -1;
                roleBox.ResetText();

                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBoxx_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.openConnection();
                string query = "SELECT id_user, nama_user, gender, email, username, password, role FROM user WHERE nama_user LIKE @nama_user";

                DataTable dt = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, koneksi.kon);
                adapter.SelectCommand.Parameters.AddWithValue("@nama_user", "%" + searchBoxx.Text + "%");

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

        private void namauserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                    namauserBox.Text = row.Cells["nama_user"].Value.ToString();
                    genderBox.Text = row.Cells["gender"].Value.ToString();
                    emailBox.Text = row.Cells["email"].Value.ToString();
                    usernameBox.Text = row.Cells["username"].Value.ToString();
                    passwordBoxx.Text = row.Cells["password"].Value.ToString();
                    roleBoxx.Text = row.Cells["role"].Value.ToString();

                    selectedUserId = Convert.ToInt32(row.Cells["id_user"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void roleBoxx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void passwordBoxx_TextChanged(object sender, EventArgs e)
        {

        }

        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void genderBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
