using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsLibraryApps.PageControll;
using WindowsFormsLibraryApps.view;

namespace WindowsFormsLibraryApps.controller
{
    public partial class HomeUser : Form
    {
        FormLoginUser formLoginU;
        public HomeUser(FormLoginUser formLoginUser)
        {
            formLoginU = formLoginUser;
            InitializeComponent();
        }
        private void addPageControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navbarPeminjamanUser_Click(object sender, EventArgs e)
        {
        }

        private void navbarHomeUser_Click(object sender, EventArgs e)
        {
            HomeUser_uc homeUser_Uc_1002 = new HomeUser_uc();
            addPageControl(homeUser_Uc_1002);
        }

        private void navbarBukuUser_Click(object sender, EventArgs e)
        {
            BukuUser_uc historiUser_Uc_1002 = new BukuUser_uc();
            addPageControl(historiUser_Uc_1002);
        }

        private void navbarHistoriUser_Click(object sender, EventArgs e)
        {
            HistoriUser_uc historiUser_Uc_1002 = new HistoriUser_uc();
            addPageControl(historiUser_Uc_1002);
        }

        private void buttonOutUser_Click(object sender, EventArgs e)
        {
            DialogResult result_1002 = MessageBox.Show("yakin mau keluar aplikasi?", "confirm", MessageBoxButtons.YesNoCancel);
            if (result_1002 == DialogResult.Yes)
            {
                MessageBox.Show("berhasil keluar");
                this.Close();
                formLoginU.Show();
            }
            else if (result_1002 == DialogResult.No)
            {
                MessageBox.Show("gagal keluar");
            }

        }

        private void HomeUser_Load(object sender, EventArgs e)
        {

        }

        private void labelHomeUser_Click(object sender, EventArgs e)
        {

        }
    }

}
