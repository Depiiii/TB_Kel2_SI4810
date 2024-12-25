namespace WindowsFormsLibraryApps
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLoad = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Poppins", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.Info;
            this.labelWelcome.Location = new System.Drawing.Point(395, 280);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(769, 184);
            this.labelWelcome.TabIndex = 3;
            this.labelWelcome.Text = "Selamat datang \r\ndi perpustakaan buah batu";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsLibraryApps.Properties.Resources._740ed1a91c457dd9d9b7941f6ffa81dc__modern_library_home_library_design;
            this.pictureBox2.Location = new System.Drawing.Point(-3, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 0);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 752);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelLoad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 716);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 29);
            this.panel1.TabIndex = 7;
            // 
            // panelLoad
            // 
            this.panelLoad.BackColor = System.Drawing.SystemColors.Info;
            this.panelLoad.Location = new System.Drawing.Point(0, 0);
            this.panelLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(48, 31);
            this.panelLoad.TabIndex = 8;
            this.panelLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLoad_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1178, 745);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLoad;
    }
}

