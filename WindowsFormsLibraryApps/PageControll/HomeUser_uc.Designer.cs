namespace WindowsFormsLibraryApps.PageControll
{
    partial class HomeUser_uc
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
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.qtypengembalianUser = new System.Windows.Forms.Label();
            this.totalbukuLabel = new System.Windows.Forms.Label();
            this.totaluserPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.totaluserLabel = new System.Windows.Forms.Label();
            this.qtypeminjamanUser = new System.Windows.Forms.Label();
            this.NamaUser = new System.Windows.Forms.Label();
            this.guna2GradientPanel2.SuspendLayout();
            this.totaluserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.AutoSize = true;
            this.guna2GradientPanel2.BorderRadius = 20;
            this.guna2GradientPanel2.Controls.Add(this.qtypengembalianUser);
            this.guna2GradientPanel2.Controls.Add(this.totalbukuLabel);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(599, 189);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(534, 209);
            this.guna2GradientPanel2.TabIndex = 8;
            // 
            // qtypengembalianUser
            // 
            this.qtypengembalianUser.AutoSize = true;
            this.qtypengembalianUser.BackColor = System.Drawing.Color.Transparent;
            this.qtypengembalianUser.Font = new System.Drawing.Font("Poppins SemiBold", 26F, System.Drawing.FontStyle.Bold);
            this.qtypengembalianUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qtypengembalianUser.Location = new System.Drawing.Point(427, 100);
            this.qtypengembalianUser.Name = "qtypengembalianUser";
            this.qtypengembalianUser.Size = new System.Drawing.Size(73, 92);
            this.qtypengembalianUser.TabIndex = 8;
            this.qtypengembalianUser.Text = "0";
            this.qtypengembalianUser.Click += new System.EventHandler(this.qtypengembalianUser_Click);
            // 
            // totalbukuLabel
            // 
            this.totalbukuLabel.AutoSize = true;
            this.totalbukuLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalbukuLabel.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.totalbukuLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalbukuLabel.Location = new System.Drawing.Point(12, 31);
            this.totalbukuLabel.Name = "totalbukuLabel";
            this.totalbukuLabel.Size = new System.Drawing.Size(507, 53);
            this.totalbukuLabel.TabIndex = 5;
            this.totalbukuLabel.Text = "Buku yang belum dikembalikan";
            this.totalbukuLabel.Click += new System.EventHandler(this.totalbukuLabel_Click);
            // 
            // totaluserPanel
            // 
            this.totaluserPanel.AutoSize = true;
            this.totaluserPanel.BorderRadius = 20;
            this.totaluserPanel.Controls.Add(this.totaluserLabel);
            this.totaluserPanel.Controls.Add(this.qtypeminjamanUser);
            this.totaluserPanel.FillColor = System.Drawing.Color.SeaGreen;
            this.totaluserPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totaluserPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.totaluserPanel.Location = new System.Drawing.Point(42, 189);
            this.totaluserPanel.Name = "totaluserPanel";
            this.totaluserPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totaluserPanel.Size = new System.Drawing.Size(503, 209);
            this.totaluserPanel.TabIndex = 6;
            // 
            // totaluserLabel
            // 
            this.totaluserLabel.AutoSize = true;
            this.totaluserLabel.BackColor = System.Drawing.Color.Transparent;
            this.totaluserLabel.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.totaluserLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totaluserLabel.Location = new System.Drawing.Point(19, 31);
            this.totaluserLabel.Name = "totaluserLabel";
            this.totaluserLabel.Size = new System.Drawing.Size(354, 53);
            this.totaluserLabel.TabIndex = 6;
            this.totaluserLabel.Text = "Total peminjamanmu";
            // 
            // qtypeminjamanUser
            // 
            this.qtypeminjamanUser.AutoSize = true;
            this.qtypeminjamanUser.BackColor = System.Drawing.Color.Transparent;
            this.qtypeminjamanUser.Font = new System.Drawing.Font("Poppins SemiBold", 26F, System.Drawing.FontStyle.Bold);
            this.qtypeminjamanUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qtypeminjamanUser.Location = new System.Drawing.Point(409, 100);
            this.qtypeminjamanUser.Name = "qtypeminjamanUser";
            this.qtypeminjamanUser.Size = new System.Drawing.Size(73, 92);
            this.qtypeminjamanUser.TabIndex = 9;
            this.qtypeminjamanUser.Text = "0";
            this.qtypeminjamanUser.Click += new System.EventHandler(this.qtypeminjamanUser_Click);
            // 
            // NamaUser
            // 
            this.NamaUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NamaUser.AutoSize = true;
            this.NamaUser.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaUser.ForeColor = System.Drawing.Color.SeaGreen;
            this.NamaUser.Location = new System.Drawing.Point(49, 77);
            this.NamaUser.Name = "NamaUser";
            this.NamaUser.Size = new System.Drawing.Size(0, 70);
            this.NamaUser.TabIndex = 5;
            this.NamaUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeUser_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.totaluserPanel);
            this.Controls.Add(this.NamaUser);
            this.Name = "HomeUser_uc";
            this.Size = new System.Drawing.Size(1174, 671);
            this.Load += new System.EventHandler(this.HomeUser_uc_Load);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.totaluserPanel.ResumeLayout(false);
            this.totaluserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private System.Windows.Forms.Label qtypengembalianUser;
        private System.Windows.Forms.Label totalbukuLabel;
        private Guna.UI2.WinForms.Guna2GradientPanel totaluserPanel;
        private System.Windows.Forms.Label totaluserLabel;
        private System.Windows.Forms.Label qtypeminjamanUser;
        private System.Windows.Forms.Label NamaUser;
    }
}
