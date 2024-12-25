namespace WindowsFormsLibraryApps.PageControll
{
    partial class BukuUser_uc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grupboxDetailBuku = new System.Windows.Forms.GroupBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.kategoriBox = new System.Windows.Forms.ComboBox();
            this.gambarBox = new System.Windows.Forms.PictureBox();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.judulBox = new System.Windows.Forms.TextBox();
            this.Penulis = new System.Windows.Forms.Label();
            this.penerbitBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Judul = new System.Windows.Forms.Label();
            this.Penerbit = new System.Windows.Forms.Label();
            this.pengarangBox = new System.Windows.Forms.TextBox();
            this.searchBoxx = new System.Windows.Forms.TextBox();
            this.SearchbukuButton = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grupboxDetailBuku.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gambarBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grupboxDetailBuku
            // 
            this.grupboxDetailBuku.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupboxDetailBuku.Controls.Add(this.guna2Button1);
            this.grupboxDetailBuku.Controls.Add(this.kategoriBox);
            this.grupboxDetailBuku.Controls.Add(this.gambarBox);
            this.grupboxDetailBuku.Controls.Add(this.resetButton);
            this.grupboxDetailBuku.Controls.Add(this.judulBox);
            this.grupboxDetailBuku.Controls.Add(this.Penulis);
            this.grupboxDetailBuku.Controls.Add(this.penerbitBox);
            this.grupboxDetailBuku.Controls.Add(this.label2);
            this.grupboxDetailBuku.Controls.Add(this.Judul);
            this.grupboxDetailBuku.Controls.Add(this.Penerbit);
            this.grupboxDetailBuku.Controls.Add(this.pengarangBox);
            this.grupboxDetailBuku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grupboxDetailBuku.Font = new System.Drawing.Font("Poppins", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupboxDetailBuku.ForeColor = System.Drawing.Color.SeaGreen;
            this.grupboxDetailBuku.Location = new System.Drawing.Point(22, 381);
            this.grupboxDetailBuku.Name = "grupboxDetailBuku";
            this.grupboxDetailBuku.Size = new System.Drawing.Size(1130, 278);
            this.grupboxDetailBuku.TabIndex = 31;
            this.grupboxDetailBuku.TabStop = false;
            this.grupboxDetailBuku.Text = "Detail Buku";
            this.grupboxDetailBuku.Enter += new System.EventHandler(this.GrupBoxSetBuku_Enter);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DarkGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Location = new System.Drawing.Point(957, 191);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(119, 45);
            this.guna2Button1.TabIndex = 32;
            this.guna2Button1.Text = "pinjam";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // kategoriBox
            // 
            this.kategoriBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kategoriBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.kategoriBox.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.kategoriBox.FormattingEnabled = true;
            this.kategoriBox.Location = new System.Drawing.Point(351, 71);
            this.kategoriBox.Name = "kategoriBox";
            this.kategoriBox.Size = new System.Drawing.Size(268, 36);
            this.kategoriBox.TabIndex = 9;
            this.kategoriBox.SelectedIndexChanged += new System.EventHandler(this.kategoriBox_SelectedIndexChanged);
            // 
            // gambarBox
            // 
            this.gambarBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gambarBox.Location = new System.Drawing.Point(24, 73);
            this.gambarBox.Name = "gambarBox";
            this.gambarBox.Size = new System.Drawing.Size(138, 191);
            this.gambarBox.TabIndex = 3;
            this.gambarBox.TabStop = false;
            this.gambarBox.Click += new System.EventHandler(this.gambarBox_Click);
            // 
            // resetButton
            // 
            this.resetButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.resetButton.BorderRadius = 10;
            this.resetButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetButton.FillColor = System.Drawing.Color.SeaGreen;
            this.resetButton.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.resetButton.Location = new System.Drawing.Point(822, 191);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(119, 45);
            this.resetButton.TabIndex = 29;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // judulBox
            // 
            this.judulBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.judulBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.judulBox.Location = new System.Drawing.Point(351, 123);
            this.judulBox.Name = "judulBox";
            this.judulBox.ReadOnly = true;
            this.judulBox.Size = new System.Drawing.Size(268, 34);
            this.judulBox.TabIndex = 10;
            this.judulBox.TextChanged += new System.EventHandler(this.judulBox_TextChanged);
            // 
            // Penulis
            // 
            this.Penulis.AutoSize = true;
            this.Penulis.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penulis.ForeColor = System.Drawing.Color.SeaGreen;
            this.Penulis.Location = new System.Drawing.Point(655, 73);
            this.Penulis.Name = "Penulis";
            this.Penulis.Size = new System.Drawing.Size(135, 31);
            this.Penulis.TabIndex = 8;
            this.Penulis.Text = "Pengarang :";
            // 
            // penerbitBox
            // 
            this.penerbitBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.penerbitBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penerbitBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.penerbitBox.Location = new System.Drawing.Point(808, 126);
            this.penerbitBox.Name = "penerbitBox";
            this.penerbitBox.ReadOnly = true;
            this.penerbitBox.Size = new System.Drawing.Size(268, 34);
            this.penerbitBox.TabIndex = 12;
            this.penerbitBox.TextChanged += new System.EventHandler(this.penerbitBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(198, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kategori :";
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.ForeColor = System.Drawing.Color.SeaGreen;
            this.Judul.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Judul.Location = new System.Drawing.Point(198, 126);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(81, 31);
            this.Judul.TabIndex = 5;
            this.Judul.Text = "Judul :";
            this.Judul.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Penerbit
            // 
            this.Penerbit.AutoSize = true;
            this.Penerbit.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penerbit.ForeColor = System.Drawing.Color.SeaGreen;
            this.Penerbit.Location = new System.Drawing.Point(655, 130);
            this.Penerbit.Name = "Penerbit";
            this.Penerbit.Size = new System.Drawing.Size(109, 31);
            this.Penerbit.TabIndex = 7;
            this.Penerbit.Text = "Penerbit :";
            // 
            // pengarangBox
            // 
            this.pengarangBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pengarangBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengarangBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pengarangBox.Location = new System.Drawing.Point(808, 73);
            this.pengarangBox.Name = "pengarangBox";
            this.pengarangBox.ReadOnly = true;
            this.pengarangBox.Size = new System.Drawing.Size(268, 34);
            this.pengarangBox.TabIndex = 11;
            this.pengarangBox.TextChanged += new System.EventHandler(this.pengarangBox_TextChanged);
            // 
            // searchBoxx
            // 
            this.searchBoxx.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxx.Location = new System.Drawing.Point(487, 64);
            this.searchBoxx.Name = "searchBoxx";
            this.searchBoxx.Size = new System.Drawing.Size(466, 34);
            this.searchBoxx.TabIndex = 29;
            this.searchBoxx.TextChanged += new System.EventHandler(this.searchBoxx_TextChanged);
            // 
            // SearchbukuButton
            // 
            this.SearchbukuButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SearchbukuButton.BorderRadius = 10;
            this.SearchbukuButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchbukuButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchbukuButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchbukuButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchbukuButton.FillColor = System.Drawing.Color.SeaGreen;
            this.SearchbukuButton.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchbukuButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchbukuButton.Location = new System.Drawing.Point(969, 64);
            this.SearchbukuButton.Name = "SearchbukuButton";
            this.SearchbukuButton.Size = new System.Drawing.Size(131, 41);
            this.SearchbukuButton.TabIndex = 29;
            this.SearchbukuButton.Text = "Cari";
            this.SearchbukuButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.guna2DataGridView1);
            this.groupBox1.Controls.Add(this.SearchbukuButton);
            this.groupBox1.Controls.Add(this.searchBoxx);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(22, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1130, 343);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Buku";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 39);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToOrderColumns = true;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 35;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = true;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(24, 111);
            this.guna2DataGridView1.MultiSelect = false;
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.RowTemplate.ReadOnly = true;
            this.guna2DataGridView1.ShowCellToolTips = false;
            this.guna2DataGridView1.ShowEditingIcon = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1076, 226);
            this.guna2DataGridView1.TabIndex = 34;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.SeaGreen;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick_1);
            // 
            // BukuUser_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupboxDetailBuku);
            this.Name = "BukuUser_uc";
            this.Size = new System.Drawing.Size(1174, 671);
            this.Load += new System.EventHandler(this.BukuUser_uc_Load);
            this.grupboxDetailBuku.ResumeLayout(false);
            this.grupboxDetailBuku.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gambarBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grupboxDetailBuku;
        private Guna.UI2.WinForms.Guna2Button resetButton;
        private System.Windows.Forms.ComboBox kategoriBox;
        private System.Windows.Forms.TextBox penerbitBox;
        private System.Windows.Forms.TextBox pengarangBox;
        private System.Windows.Forms.Label Penulis;
        private System.Windows.Forms.PictureBox gambarBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox judulBox;
        private System.Windows.Forms.Label Penerbit;
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.TextBox searchBoxx;
        private Guna.UI2.WinForms.Guna2Button SearchbukuButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
