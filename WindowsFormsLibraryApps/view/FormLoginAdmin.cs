using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using WindowsFormsLibraryApps.controller;
using WindowsFormsLibraryApps.view;


namespace WindowsFormsLibraryApps
{
    public partial class FormLoginAdmin : Form
    {
        cekLogin Login = new cekLogin();
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        public static string LoggedIn;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Password / Username tidak boleh kosong", "Gagal Masuk");
            }
            else
            {
                string username_1002 = textBoxUsername.Text;
                string password_1002 = textBoxPassword.Text;

                string role = Login.PeriksaRole_1002(username_1002, password_1002); 

                if (role == "admin") 
                {
                    LoggedIn = username_1002;
                    MessageBox.Show("LOGIN BERHASIL sebagai Admin!", "Berhasil");
                    HomeAdmin homeAdmin = new HomeAdmin(this);
                    homeAdmin.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Periksa kembali password dan username Anda, atau Anda bukan admin", "Gagal Masuk");
                }
            }
        }

        private void GroupLogin_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormLoginUser formLoginUser_1002 = new FormLoginUser();
            formLoginUser_1002.Show();
            Visible = false;
        }

        private void FormLoginAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
