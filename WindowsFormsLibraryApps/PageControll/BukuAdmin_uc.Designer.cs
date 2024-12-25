using System;

namespace WindowsFormsLibraryApps.PageControll
{
    partial class BukuAdmin_uc
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
            this.gambarBox = new System.Windows.Forms.PictureBox();
            this.Judul = new System.Windows.Forms.Label();
            this.Penerbit = new System.Windows.Forms.Label();
            this.Penulis = new System.Windows.Forms.Label();
            this.kategoriBox = new System.Windows.Forms.ComboBox();
            this.judulBox = new System.Windows.Forms.TextBox();
            this.pengarangBox = new System.Windows.Forms.TextBox();
            this.penerbitBox = new System.Windows.Forms.TextBox();
            this.addBooks_importBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.GrupBoxSetBuku = new System.Windows.Forms.GroupBox();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filterkategoriBox = new System.Windows.Forms.ComboBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchBoxx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gambarBox)).BeginInit();
            this.GrupBoxSetBuku.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gambarBox
            // 
            this.gambarBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gambarBox.Location = new System.Drawing.Point(24, 81);
            this.gambarBox.Name = "gambarBox";
            this.gambarBox.Size = new System.Drawing.Size(138, 191);
            this.gambarBox.TabIndex = 3;
            this.gambarBox.TabStop = false;
            this.gambarBox.Click += new System.EventHandler(this.gambarBox_Click);
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.ForeColor = System.Drawing.Color.SeaGreen;
            this.Judul.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Judul.Location = new System.Drawing.Point(191, 132);
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
            this.Penerbit.Location = new System.Drawing.Point(191, 238);
            this.Penerbit.Name = "Penerbit";
            this.Penerbit.Size = new System.Drawing.Size(109, 31);
            this.Penerbit.TabIndex = 7;
            this.Penerbit.Text = "Penerbit :";
            // 
            // Penulis
            // 
            this.Penulis.AutoSize = true;
            this.Penulis.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penulis.ForeColor = System.Drawing.Color.SeaGreen;
            this.Penulis.Location = new System.Drawing.Point(191, 181);
            this.Penulis.Name = "Penulis";
            this.Penulis.Size = new System.Drawing.Size(135, 31);
            this.Penulis.TabIndex = 8;
            this.Penulis.Text = "Pengarang :";
            // 
            // kategoriBox
            // 
            this.kategoriBox.BackColor = System.Drawing.SystemColors.Info;
            this.kategoriBox.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriBox.ForeColor = System.Drawing.Color.SeaGreen;
            this.kategoriBox.FormattingEnabled = true;
            this.kategoriBox.Location = new System.Drawing.Point(344, 77);
            this.kategoriBox.Name = "kategoriBox";
            this.kategoriBox.Size = new System.Drawing.Size(268, 36);
            this.kategoriBox.TabIndex = 9;
            this.kategoriBox.SelectedIndexChanged += new System.EventHandler(this.Kategori_SelectedIndexChanged);
            // 
            // judulBox
            // 
            this.judulBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulBox.Location = new System.Drawing.Point(344, 129);
            this.judulBox.Name = "judulBox";
            this.judulBox.Size = new System.Drawing.Size(268, 34);
            this.judulBox.TabIndex = 10;
            this.judulBox.TextChanged += new System.EventHandler(this.judulBox_TextChanged_1);
            // 
            // pengarangBox
            // 
            this.pengarangBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengarangBox.Location = new System.Drawing.Point(344, 181);
            this.pengarangBox.Name = "pengarangBox";
            this.pengarangBox.Size = new System.Drawing.Size(268, 34);
            this.pengarangBox.TabIndex = 11;
            // 
            // penerbitBox
            // 
            this.penerbitBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penerbitBox.Location = new System.Drawing.Point(344, 234);
            this.penerbitBox.Name = "penerbitBox";
            this.penerbitBox.Size = new System.Drawing.Size(268, 34);
            this.penerbitBox.TabIndex = 12;
            // 
            // addBooks_importBtn
            // 
            this.addBooks_importBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(128)))), ((int)(((byte)(87)))));
            this.addBooks_importBtn.FlatAppearance.BorderSize = 0;
            this.addBooks_importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBooks_importBtn.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBooks_importBtn.ForeColor = System.Drawing.Color.White;
            this.addBooks_importBtn.Location = new System.Drawing.Point(24, 234);
            this.addBooks_importBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.addBooks_importBtn.Name = "addBooks_importBtn";
            this.addBooks_importBtn.Size = new System.Drawing.Size(138, 38);
            this.addBooks_importBtn.TabIndex = 24;
            this.addBooks_importBtn.Text = "Import";
            this.addBooks_importBtn.UseVisualStyleBackColor = false;
            this.addBooks_importBtn.Click += new System.EventHandler(this.addBooks_importBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(191, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kategori :";
            // 
            // GrupBoxSetBuku
            // 
            this.GrupBoxSetBuku.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrupBoxSetBuku.Controls.Add(this.resetButton);
            this.GrupBoxSetBuku.Controls.Add(this.kategoriBox);
            this.GrupBoxSetBuku.Controls.Add(this.addBooks_importBtn);
            this.GrupBoxSetBuku.Controls.Add(this.penerbitBox);
            this.GrupBoxSetBuku.Controls.Add(this.pengarangBox);
            this.GrupBoxSetBuku.Controls.Add(this.guna2Button3);
            this.GrupBoxSetBuku.Controls.Add(this.Penulis);
            this.GrupBoxSetBuku.Controls.Add(this.gambarBox);
            this.GrupBoxSetBuku.Controls.Add(this.label2);
            this.GrupBoxSetBuku.Controls.Add(this.guna2Button1);
            this.GrupBoxSetBuku.Controls.Add(this.judulBox);
            this.GrupBoxSetBuku.Controls.Add(this.guna2Button2);
            this.GrupBoxSetBuku.Controls.Add(this.Penerbit);
            this.GrupBoxSetBuku.Controls.Add(this.Judul);
            this.GrupBoxSetBuku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GrupBoxSetBuku.Font = new System.Drawing.Font("Poppins", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupBoxSetBuku.ForeColor = System.Drawing.Color.SeaGreen;
            this.GrupBoxSetBuku.Location = new System.Drawing.Point(32, 15);
            this.GrupBoxSetBuku.Name = "GrupBoxSetBuku";
            this.GrupBoxSetBuku.Size = new System.Drawing.Size(1103, 292);
            this.GrupBoxSetBuku.TabIndex = 29;
            this.GrupBoxSetBuku.TabStop = false;
            this.GrupBoxSetBuku.Text = "Atur Buku";
            this.GrupBoxSetBuku.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.resetButton.Location = new System.Drawing.Point(813, 62);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(253, 45);
            this.resetButton.TabIndex = 29;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click_1);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button3.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button3.Location = new System.Drawing.Point(813, 164);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(253, 45);
            this.guna2Button3.TabIndex = 28;
            this.guna2Button3.Text = "Hapus";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.Location = new System.Drawing.Point(813, 215);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(253, 45);
            this.guna2Button1.TabIndex = 26;
            this.guna2Button1.Text = "Update";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2Button2.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button2.Location = new System.Drawing.Point(813, 113);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(253, 45);
            this.guna2Button2.TabIndex = 27;
            this.guna2Button2.Text = "Tambah";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.filterkategoriBox);
            this.groupBox1.Controls.Add(this.guna2DataGridView1);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.searchBoxx);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(32, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 339);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Buku";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // filterkategoriBox
            // 
            this.filterkategoriBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.filterkategoriBox.FormattingEnabled = true;
            this.filterkategoriBox.Location = new System.Drawing.Point(24, 71);
            this.filterkategoriBox.Name = "filterkategoriBox";
            this.filterkategoriBox.Size = new System.Drawing.Size(243, 39);
            this.filterkategoriBox.TabIndex = 39;
            this.filterkategoriBox.SelectedIndexChanged += new System.EventHandler(this.filterkategoriBox_SelectedIndexChanged);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToOrderColumns = true;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
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
            this.guna2DataGridView1.Location = new System.Drawing.Point(24, 129);
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
            this.guna2DataGridView1.Size = new System.Drawing.Size(1042, 193);
            this.guna2DataGridView1.TabIndex = 0;
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
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // SearchButton
            // 
            this.SearchButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SearchButton.BorderRadius = 10;
            this.SearchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchButton.FillColor = System.Drawing.Color.SeaGreen;
            this.SearchButton.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchButton.Location = new System.Drawing.Point(935, 71);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(131, 34);
            this.SearchButton.TabIndex = 29;
            this.SearchButton.Text = "Cari";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchBoxx
            // 
            this.searchBoxx.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxx.Location = new System.Drawing.Point(626, 71);
            this.searchBoxx.Name = "searchBoxx";
            this.searchBoxx.Size = new System.Drawing.Size(280, 34);
            this.searchBoxx.TabIndex = 29;
            this.searchBoxx.TextChanged += new System.EventHandler(this.searchBoxx_TextChanged);
            // 
            // BukuAdmin_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrupBoxSetBuku);
            this.Name = "BukuAdmin_uc";
            this.Size = new System.Drawing.Size(1174, 671);
            this.Load += new System.EventHandler(this.BukuAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gambarBox)).EndInit();
            this.GrupBoxSetBuku.ResumeLayout(false);
            this.GrupBoxSetBuku.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox gambarBox;
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.Label Penerbit;
        private System.Windows.Forms.Label Penulis;
        private System.Windows.Forms.ComboBox kategoriBox;
        private System.Windows.Forms.TextBox judulBox;
        private System.Windows.Forms.TextBox pengarangBox;
        private System.Windows.Forms.TextBox penerbitBox;
        private System.Windows.Forms.Button addBooks_importBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrupBoxSetBuku;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button SearchButton;
        private System.Windows.Forms.TextBox searchBoxx;
        private Guna.UI2.WinForms.Guna2Button resetButton;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.ComboBox filterkategoriBox;
        private readonly EventHandler judulBox_TextChanged;
    }
}
