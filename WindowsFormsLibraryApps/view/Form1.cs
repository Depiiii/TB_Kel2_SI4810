using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsLibraryApps.view;

namespace WindowsFormsLibraryApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelLoad.Width += 20;
            if (panelLoad.Width >= 1178)
            {
                timer1.Stop();
                FormLoginUser loginUser_1002 = new FormLoginUser();
                loginUser_1002.Show();
                Visible = false;
            }
        }

        private void panelLoad_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
