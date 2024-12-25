using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using WindowsFormsLibraryApps.PageControll;

namespace WindowsFormsLibraryApps.view
{
    public partial class HomeAdmin : Form
    {
        FormLoginAdmin formLoginA;
        public HomeAdmin(FormLoginAdmin formLoginAdmin)
        {
            formLoginA = formLoginAdmin;
            InitializeComponent();
        }

        public HomeAdmin(FormLoginAdmin formLoginA, IContainer components, Guna2Button navbarHome, Guna2Button navbarBuku, Guna2Button navbarUser, Guna2Button navbarHistori, Button buttonLogout, Panel panelNavbar, Panel panelContainer, Guna2Button buttonOut, Label labelHomeAdmin, Label namaAdmin) : this(formLoginA)
        {
            this.components = components;
            this.navbarHome = navbarHome;
            this.navbarBuku = navbarBuku;
            this.navbarUser = navbarUser;
            this.navbarHistori = navbarHistori;
            this.buttonLogout = buttonLogout;
            this.panelNavbar = panelNavbar;
            this.panelContainer = panelContainer;
            this.buttonOut = buttonOut;
            this.labelHomeAdmin = labelHomeAdmin;
        }

        private void addPageControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void navbarHome_Click(object sender, EventArgs e)
        {
            HomeAdmin_uc homeAdmin_Uc_1002 = new HomeAdmin_uc();
            addPageControl(homeAdmin_Uc_1002);
        }

        private void navbarBuku_Click(object sender, EventArgs e)
        {
            BukuAdmin_uc buku_1002 = new BukuAdmin_uc();
            addPageControl(buku_1002);
        }

        private void navbarUser_Click(object sender, EventArgs e)
        {
            UserAdmin_uc user_1002 = new UserAdmin_uc();
            addPageControl(user_1002);
        }

        private void navbarHistori_Click(object sender, EventArgs e)
        {
            HistoriAdmin_uc histori_1002 = new HistoriAdmin_uc();
            addPageControl(histori_1002);
        }

        private void panelNavbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            DialogResult result_1002 = MessageBox.Show("yakin mau keluar aplikasi?", "confirm", MessageBoxButtons.YesNoCancel);
            if(result_1002 == DialogResult.Yes)
            {
                MessageBox.Show("berhasil keluar");
                this.Close();
                formLoginA.Show();
            }
            else if(result_1002 == DialogResult.No)
            {
                MessageBox.Show("gagal keluar");
            }
           
            
            
        }

        private void labelHomeAdmin_Click(object sender, EventArgs e)
        {

        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {

        }

        private void navbarPengembalian_Click(object sender, EventArgs e)
        {
            PengembalianAdmin_uc pengembalianAdmin_uc = new PengembalianAdmin_uc();
            addPageControl(pengembalianAdmin_uc);
        }
    }
}
