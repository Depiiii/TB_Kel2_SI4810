namespace WindowsFormsLibraryApps.PageControll
{
    partial class HomeAdmin_uc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.totaluserPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.totaluserLabel = new System.Windows.Forms.Label();
            this.qtyuserLabel = new System.Windows.Forms.Label();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.qtybukuLabel = new System.Windows.Forms.Label();
            this.totalbukuLabel = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.qtypinjamLabel = new System.Windows.Forms.Label();
            this.totalpinjamLabel = new System.Windows.Forms.Label();
            this.NamaAdmin = new System.Windows.Forms.Label();
            this.totaluserPanel.SuspendLayout();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // totaluserPanel
            // 
            this.totaluserPanel.AutoSize = true;
            this.totaluserPanel.BorderRadius = 20;
            this.totaluserPanel.Controls.Add(this.totaluserLabel);
            this.totaluserPanel.Controls.Add(this.qtyuserLabel);
            this.totaluserPanel.FillColor = System.Drawing.Color.SeaGreen;
            this.totaluserPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totaluserPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.totaluserPanel.Location = new System.Drawing.Point(28, 231);
            this.totaluserPanel.Name = "totaluserPanel";
            this.totaluserPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totaluserPanel.Size = new System.Drawing.Size(338, 209);
            this.totaluserPanel.TabIndex = 0;
            this.totaluserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.totaluserPanel_Paint);
            // 
            // totaluserLabel
            // 
            this.totaluserLabel.AutoSize = true;
            this.totaluserLabel.BackColor = System.Drawing.Color.Transparent;
            this.totaluserLabel.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaluserLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totaluserLabel.Location = new System.Drawing.Point(15, 18);
            this.totaluserLabel.Name = "totaluserLabel";
            this.totaluserLabel.Size = new System.Drawing.Size(185, 56);
            this.totaluserLabel.TabIndex = 6;
            this.totaluserLabel.Text = "Total User";
            this.totaluserLabel.Click += new System.EventHandler(this.totaluserLabel_Click);
            // 
            // qtyuserLabel
            // 
            this.qtyuserLabel.AutoSize = true;
            this.qtyuserLabel.BackColor = System.Drawing.Color.Transparent;
            this.qtyuserLabel.Font = new System.Drawing.Font("Poppins SemiBold", 26F, System.Drawing.FontStyle.Bold);
            this.qtyuserLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qtyuserLabel.Location = new System.Drawing.Point(259, 117);
            this.qtyuserLabel.Name = "qtyuserLabel";
            this.qtyuserLabel.Size = new System.Drawing.Size(73, 92);
            this.qtyuserLabel.TabIndex = 9;
            this.qtyuserLabel.Text = "0";
            this.qtyuserLabel.Click += new System.EventHandler(this.qtyuserLabel_Click);
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.AutoSize = true;
            this.guna2GradientPanel2.BorderRadius = 20;
            this.guna2GradientPanel2.Controls.Add(this.qtybukuLabel);
            this.guna2GradientPanel2.Controls.Add(this.totalbukuLabel);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(808, 231);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(338, 209);
            this.guna2GradientPanel2.TabIndex = 4;
            this.guna2GradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel2_Paint);
            // 
            // qtybukuLabel
            // 
            this.qtybukuLabel.AutoSize = true;
            this.qtybukuLabel.BackColor = System.Drawing.Color.Transparent;
            this.qtybukuLabel.Font = new System.Drawing.Font("Poppins SemiBold", 26F, System.Drawing.FontStyle.Bold);
            this.qtybukuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qtybukuLabel.Location = new System.Drawing.Point(256, 117);
            this.qtybukuLabel.Name = "qtybukuLabel";
            this.qtybukuLabel.Size = new System.Drawing.Size(73, 92);
            this.qtybukuLabel.TabIndex = 8;
            this.qtybukuLabel.Text = "0";
            this.qtybukuLabel.Click += new System.EventHandler(this.qtybukuLabel_Click);
            // 
            // totalbukuLabel
            // 
            this.totalbukuLabel.AutoSize = true;
            this.totalbukuLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalbukuLabel.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbukuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalbukuLabel.Location = new System.Drawing.Point(20, 21);
            this.totalbukuLabel.Name = "totalbukuLabel";
            this.totalbukuLabel.Size = new System.Drawing.Size(195, 56);
            this.totalbukuLabel.TabIndex = 5;
            this.totalbukuLabel.Text = "Total Buku";
            this.totalbukuLabel.Click += new System.EventHandler(this.totalbukuLabel_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.AutoSize = true;
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.qtypinjamLabel);
            this.guna2GradientPanel1.Controls.Add(this.totalpinjamLabel);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(425, 231);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(338, 209);
            this.guna2GradientPanel1.TabIndex = 3;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // qtypinjamLabel
            // 
            this.qtypinjamLabel.AutoSize = true;
            this.qtypinjamLabel.BackColor = System.Drawing.Color.Transparent;
            this.qtypinjamLabel.Font = new System.Drawing.Font("Poppins SemiBold", 26F, System.Drawing.FontStyle.Bold);
            this.qtypinjamLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qtypinjamLabel.Location = new System.Drawing.Point(262, 117);
            this.qtypinjamLabel.Name = "qtypinjamLabel";
            this.qtypinjamLabel.Size = new System.Drawing.Size(73, 92);
            this.qtypinjamLabel.TabIndex = 7;
            this.qtypinjamLabel.Text = "0";
            this.qtypinjamLabel.Click += new System.EventHandler(this.qtypinjamLabel_Click);
            // 
            // totalpinjamLabel
            // 
            this.totalpinjamLabel.AutoSize = true;
            this.totalpinjamLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalpinjamLabel.Font = new System.Drawing.Font("Poppins SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpinjamLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalpinjamLabel.Location = new System.Drawing.Point(21, 21);
            this.totalpinjamLabel.Name = "totalpinjamLabel";
            this.totalpinjamLabel.Size = new System.Drawing.Size(227, 56);
            this.totalpinjamLabel.TabIndex = 3;
            this.totalpinjamLabel.Text = "Total Pinjam";
            this.totalpinjamLabel.Click += new System.EventHandler(this.totalpinjamLabel_Click);
            // 
            // NamaAdmin
            // 
            this.NamaAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NamaAdmin.AutoSize = true;
            this.NamaAdmin.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaAdmin.ForeColor = System.Drawing.Color.SeaGreen;
            this.NamaAdmin.Location = new System.Drawing.Point(49, 79);
            this.NamaAdmin.Name = "NamaAdmin";
            this.NamaAdmin.Size = new System.Drawing.Size(0, 70);
            this.NamaAdmin.TabIndex = 6;
            this.NamaAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeAdmin_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NamaAdmin);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.totaluserPanel);
            this.Name = "HomeAdmin_uc";
            this.Size = new System.Drawing.Size(1174, 671);
            this.Load += new System.EventHandler(this.HomeAdmin_uc_Load);
            this.totaluserPanel.ResumeLayout(false);
            this.totaluserPanel.PerformLayout();
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel totaluserPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label totalpinjamLabel;
        private System.Windows.Forms.Label totalbukuLabel;
        private System.Windows.Forms.Label totaluserLabel;
        private System.Windows.Forms.Label qtyuserLabel;
        private System.Windows.Forms.Label qtybukuLabel;
        private System.Windows.Forms.Label qtypinjamLabel;
        private System.Windows.Forms.Label NamaAdmin;
    }
}
