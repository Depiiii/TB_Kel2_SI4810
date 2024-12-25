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
namespace WindowsFormsLibraryApps.view
{
    public partial class FormLoginUser : Form
    {
        cekLogin Login = new cekLogin();
        public FormLoginUser()
        {
            InitializeComponent();
        }
        public static string LoggedIn;
        private void button1_Click(object sender, EventArgs e)
        {
            FormLoginAdmin formLoginA_1002 = new FormLoginAdmin();
            formLoginA_1002.Show();
            Visible = false;
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonKlikLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Password / Username tidak boleh kosong", "Gagal Masuk");
            }
            else
            {
                string username = textBoxUsername.Text;
                string password = textBoxPassword.Text;

                string role = Login.PeriksaRole_1002(username, password);

                if (role == "pengunjung") // Jika role user
                {
                    LoggedIn = username;
                    MessageBox.Show("LOGIN BERHASIL sebagai Pengunjung!", "Berhasil");
                     HomeUser homeUser_1002 = new HomeUser(this);
                    homeUser_1002.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Periksa kembali password dan username Anda, atau Anda bukan user", "Gagal Masuk");
                }
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLoginUser_Load(object sender, EventArgs e)
        {

        }
    }
    }

