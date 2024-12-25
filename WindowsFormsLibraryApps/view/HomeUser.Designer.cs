namespace WindowsFormsLibraryApps.controller
{
    partial class HomeUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.buttonOutUser = new Guna.UI2.WinForms.Guna2Button();
            this.navbarHistoriUser = new Guna.UI2.WinForms.Guna2Button();
            this.navbarHomeUser = new Guna.UI2.WinForms.Guna2Button();
            this.navbarBukuUser = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHomeAdmin = new System.Windows.Forms.Label();
            this.panelNavbar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.SeaGreen;
            this.panelNavbar.Controls.Add(this.buttonOutUser);
            this.panelNavbar.Controls.Add(this.navbarHistoriUser);
            this.panelNavbar.Controls.Add(this.navbarHomeUser);
            this.panelNavbar.Controls.Add(this.navbarBukuUser);
            this.panelNavbar.Controls.Add(this.buttonLogout);
            this.panelNavbar.Location = new System.Drawing.Point(1, -1);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1177, 79);
            this.panelNavbar.TabIndex = 7;
            // 
            // buttonOutUser
            // 
            this.buttonOutUser.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonOutUser.BorderRadius = 10;
            this.buttonOutUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.buttonOutUser.CheckedState.BorderColor = System.Drawing.SystemColors.Info;
            this.buttonOutUser.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.buttonOutUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonOutUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonOutUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonOutUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonOutUser.FillColor = System.Drawing.SystemColors.Info;
            this.buttonOutUser.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOutUser.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonOutUser.HoverState.CustomBorderColor = System.Drawing.Color.SeaGreen;
            this.buttonOutUser.Location = new System.Drawing.Point(1022, 18);
            this.buttonOutUser.Name = "buttonOutUser";
            this.buttonOutUser.Size = new System.Drawing.Size(143, 45);
            this.buttonOutUser.TabIndex = 5;
            this.buttonOutUser.Text = "keluar";
            this.buttonOutUser.Click += new System.EventHandler(this.buttonOutUser_Click);
            // 
            // navbarHistoriUser
            // 
            this.navbarHistoriUser.BackColor = System.Drawing.Color.SeaGreen;
            this.navbarHistoriUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.navbarHistoriUser.CheckedState.BorderColor = System.Drawing.SystemColors.Info;
            this.navbarHistoriUser.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.navbarHistoriUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.navbarHistoriUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.navbarHistoriUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.navbarHistoriUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.navbarHistoriUser.FillColor = System.Drawing.Color.SeaGreen;
            this.navbarHistoriUser.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navbarHistoriUser.ForeColor = System.Drawing.Color.White;
            this.navbarHistoriUser.HoverState.CustomBorderColor = System.Drawing.SystemColors.Info;
            this.navbarHistoriUser.Location = new System.Drawing.Point(422, 3);
            this.navbarHistoriUser.Name = "navbarHistoriUser";
            this.navbarHistoriUser.Size = new System.Drawing.Size(154, 76);
            this.navbarHistoriUser.TabIndex = 4;
            this.navbarHistoriUser.Text = "Histori";
            this.navbarHistoriUser.Click += new System.EventHandler(this.navbarHistoriUser_Click);
            // 
            // navbarHomeUser
            // 
            this.navbarHomeUser.BackColor = System.Drawing.Color.SeaGreen;
            this.navbarHomeUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.navbarHomeUser.CheckedState.BorderColor = System.Drawing.SystemColors.Info;
            this.navbarHomeUser.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.navbarHomeUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.navbarHomeUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.navbarHomeUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.navbarHomeUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.navbarHomeUser.FillColor = System.Drawing.Color.SeaGreen;
            this.navbarHomeUser.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navbarHomeUser.ForeColor = System.Drawing.Color.White;
            this.navbarHomeUser.HoverState.CustomBorderColor = System.Drawing.SystemColors.Info;
            this.navbarHomeUser.Location = new System.Drawing.Point(0, 0);
            this.navbarHomeUser.Name = "navbarHomeUser";
            this.navbarHomeUser.Size = new System.Drawing.Size(200, 76);
            this.navbarHomeUser.TabIndex = 1;
            this.navbarHomeUser.Text = "Home";
            this.navbarHomeUser.Click += new System.EventHandler(this.navbarHomeUser_Click);
            // 
            // navbarBukuUser
            // 
            this.navbarBukuUser.BackColor = System.Drawing.Color.SeaGreen;
            this.navbarBukuUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.navbarBukuUser.CheckedState.BorderColor = System.Drawing.SystemColors.Info;
            this.navbarBukuUser.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.navbarBukuUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.navbarBukuUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.navbarBukuUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.navbarBukuUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.navbarBukuUser.FillColor = System.Drawing.Color.SeaGreen;
            this.navbarBukuUser.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navbarBukuUser.ForeColor = System.Drawing.Color.White;
            this.navbarBukuUser.HoverState.CustomBorderColor = System.Drawing.SystemColors.Info;
            this.navbarBukuUser.Location = new System.Drawing.Point(205, 1);
            this.navbarBukuUser.Name = "navbarBukuUser";
            this.navbarBukuUser.Size = new System.Drawing.Size(211, 73);
            this.navbarBukuUser.TabIndex = 2;
            this.navbarBukuUser.Text = "Buku";
            this.navbarBukuUser.Click += new System.EventHandler(this.navbarBukuUser_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.Info;
            this.buttonLogout.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonLogout.Location = new System.Drawing.Point(1364, 22);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(87, 35);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "keluar";
            this.buttonLogout.UseVisualStyleBackColor = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.labelHomeAdmin);
            this.panelContainer.Location = new System.Drawing.Point(1, 79);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1174, 671);
            this.panelContainer.TabIndex = 8;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(148, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ini adalah welcome page yang hanya akan muncul saat anda pertama kali masuk ke ap" +
    "likasi.\r\n tekan tab navbar sesuai halaman yang ingin kamu tuju !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHomeAdmin
            // 
            this.labelHomeAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHomeAdmin.AutoSize = true;
            this.labelHomeAdmin.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeAdmin.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelHomeAdmin.Location = new System.Drawing.Point(416, 263);
            this.labelHomeAdmin.Name = "labelHomeAdmin";
            this.labelHomeAdmin.Size = new System.Drawing.Size(342, 70);
            this.labelHomeAdmin.TabIndex = 4;
            this.labelHomeAdmin.Text = "WELCOME USER";
            this.labelHomeAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.panelContainer);
            this.Name = "HomeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeUser";
            this.Load += new System.EventHandler(this.HomeUser_Load);
            this.panelNavbar.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavbar;
        private Guna.UI2.WinForms.Guna2Button buttonOutUser;
        private Guna.UI2.WinForms.Guna2Button navbarHistoriUser;
        private Guna.UI2.WinForms.Guna2Button navbarHomeUser;
        private Guna.UI2.WinForms.Guna2Button navbarBukuUser;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHomeAdmin;
    }
}