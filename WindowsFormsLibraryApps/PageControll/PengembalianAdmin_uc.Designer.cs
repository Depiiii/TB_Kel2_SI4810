namespace WindowsFormsLibraryApps.PageControll
{
    partial class PengembalianAdmin_uc
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
            this.ListPengembalianBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.filterDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchpengembalianButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchBoxx = new System.Windows.Forms.TextBox();
            this.detailPeminjamanBox = new System.Windows.Forms.GroupBox();
            this.KategoriBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DikembalikanButton = new Guna.UI2.WinForms.Guna2Button();
            this.NamaBukuBox = new System.Windows.Forms.ComboBox();
            this.NamaPeminjamBox = new System.Windows.Forms.TextBox();
            this.Penulis = new System.Windows.Forms.Label();
            this.TGLKembaliBox = new System.Windows.Forms.TextBox();
            this.labelNamaBuku = new System.Windows.Forms.Label();
            this.Judul = new System.Windows.Forms.Label();
            this.Penerbit = new System.Windows.Forms.Label();
            this.TGLPinjamBox = new System.Windows.Forms.TextBox();
            this.ListPengembalianBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.detailPeminjamanBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListPengembalianBox
            // 
            this.ListPengembalianBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListPengembalianBox.Controls.Add(this.comboBox1);
            this.ListPengembalianBox.Controls.Add(this.resetButton);
            this.ListPengembalianBox.Controls.Add(this.filterDate);
            this.ListPengembalianBox.Controls.Add(this.guna2DataGridView1);
            this.ListPengembalianBox.Controls.Add(this.SearchpengembalianButton);
            this.ListPengembalianBox.Controls.Add(this.searchBoxx);
            this.ListPengembalianBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ListPengembalianBox.Font = new System.Drawing.Font("Poppins", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListPengembalianBox.ForeColor = System.Drawing.Color.SeaGreen;
            this.ListPengembalianBox.Location = new System.Drawing.Point(22, 25);
            this.ListPengembalianBox.Name = "ListPengembalianBox";
            this.ListPengembalianBox.Size = new System.Drawing.Size(1130, 346);
            this.ListPengembalianBox.TabIndex = 34;
            this.ListPengembalianBox.TabStop = false;
            this.ListPengembalianBox.Text = "List buku dipinjam";
            this.ListPengembalianBox.Enter += new System.EventHandler(this.ListPengembalianBox_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(491, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 39);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.resetButton.Location = new System.Drawing.Point(24, 74);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(131, 41);
            this.resetButton.TabIndex = 37;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // filterDate
            // 
            this.filterDate.Checked = true;
            this.filterDate.FillColor = System.Drawing.Color.White;
            this.filterDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.filterDate.Location = new System.Drawing.Point(161, 77);
            this.filterDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.filterDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.filterDate.Name = "filterDate";
            this.filterDate.Size = new System.Drawing.Size(324, 36);
            this.filterDate.TabIndex = 36;
            this.filterDate.Value = new System.DateTime(2024, 12, 20, 5, 6, 31, 392);
            this.filterDate.ValueChanged += new System.EventHandler(this.filterDate_ValueChanged);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToOrderColumns = true;
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
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
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
            this.guna2DataGridView1.Location = new System.Drawing.Point(15, 129);
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
            this.guna2DataGridView1.RowHeadersWidth = 100;
            this.guna2DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.RowTemplate.ReadOnly = true;
            this.guna2DataGridView1.ShowCellToolTips = false;
            this.guna2DataGridView1.ShowEditingIcon = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1100, 197);
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
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
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
            // SearchpengembalianButton
            // 
            this.SearchpengembalianButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SearchpengembalianButton.BorderRadius = 10;
            this.SearchpengembalianButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchpengembalianButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchpengembalianButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchpengembalianButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchpengembalianButton.FillColor = System.Drawing.Color.SeaGreen;
            this.SearchpengembalianButton.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchpengembalianButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchpengembalianButton.Location = new System.Drawing.Point(984, 74);
            this.SearchpengembalianButton.Name = "SearchpengembalianButton";
            this.SearchpengembalianButton.Size = new System.Drawing.Size(131, 41);
            this.SearchpengembalianButton.TabIndex = 29;
            this.SearchpengembalianButton.Text = "Cari";
            this.SearchpengembalianButton.Click += new System.EventHandler(this.SearchistoriButton_Click);
            // 
            // searchBoxx
            // 
            this.searchBoxx.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxx.Location = new System.Drawing.Point(740, 81);
            this.searchBoxx.Name = "searchBoxx";
            this.searchBoxx.Size = new System.Drawing.Size(238, 34);
            this.searchBoxx.TabIndex = 29;
            this.searchBoxx.TextChanged += new System.EventHandler(this.searchBoxx_TextChanged);
            // 
            // detailPeminjamanBox
            // 
            this.detailPeminjamanBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detailPeminjamanBox.Controls.Add(this.KategoriBox);
            this.detailPeminjamanBox.Controls.Add(this.label1);
            this.detailPeminjamanBox.Controls.Add(this.DikembalikanButton);
            this.detailPeminjamanBox.Controls.Add(this.NamaBukuBox);
            this.detailPeminjamanBox.Controls.Add(this.NamaPeminjamBox);
            this.detailPeminjamanBox.Controls.Add(this.Penulis);
            this.detailPeminjamanBox.Controls.Add(this.TGLKembaliBox);
            this.detailPeminjamanBox.Controls.Add(this.labelNamaBuku);
            this.detailPeminjamanBox.Controls.Add(this.Judul);
            this.detailPeminjamanBox.Controls.Add(this.Penerbit);
            this.detailPeminjamanBox.Controls.Add(this.TGLPinjamBox);
            this.detailPeminjamanBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detailPeminjamanBox.Font = new System.Drawing.Font("Poppins", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailPeminjamanBox.ForeColor = System.Drawing.Color.SeaGreen;
            this.detailPeminjamanBox.Location = new System.Drawing.Point(22, 377);
            this.detailPeminjamanBox.Name = "detailPeminjamanBox";
            this.detailPeminjamanBox.Size = new System.Drawing.Size(1130, 266);
            this.detailPeminjamanBox.TabIndex = 35;
            this.detailPeminjamanBox.TabStop = false;
            this.detailPeminjamanBox.Text = "Pilihan Peminjaman";
            // 
            // KategoriBox
            // 
            this.KategoriBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KategoriBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.KategoriBox.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KategoriBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.KategoriBox.FormattingEnabled = true;
            this.KategoriBox.Location = new System.Drawing.Point(251, 140);
            this.KategoriBox.Name = "KategoriBox";
            this.KategoriBox.Size = new System.Drawing.Size(250, 36);
            this.KategoriBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(24, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "kategori :";
            // 
            // DikembalikanButton
            // 
            this.DikembalikanButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DikembalikanButton.BorderRadius = 10;
            this.DikembalikanButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DikembalikanButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DikembalikanButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DikembalikanButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DikembalikanButton.FillColor = System.Drawing.Color.DarkGreen;
            this.DikembalikanButton.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DikembalikanButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DikembalikanButton.Location = new System.Drawing.Point(906, 204);
            this.DikembalikanButton.Name = "DikembalikanButton";
            this.DikembalikanButton.Size = new System.Drawing.Size(196, 45);
            this.DikembalikanButton.TabIndex = 32;
            this.DikembalikanButton.Text = "dikembalikan";
            this.DikembalikanButton.Click += new System.EventHandler(this.DikembalikanButton_Click);
            // 
            // NamaBukuBox
            // 
            this.NamaBukuBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NamaBukuBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.NamaBukuBox.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaBukuBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NamaBukuBox.FormattingEnabled = true;
            this.NamaBukuBox.Location = new System.Drawing.Point(251, 90);
            this.NamaBukuBox.Name = "NamaBukuBox";
            this.NamaBukuBox.Size = new System.Drawing.Size(250, 36);
            this.NamaBukuBox.TabIndex = 9;
            this.NamaBukuBox.SelectedIndexChanged += new System.EventHandler(this.NamaBukuBox_SelectedIndexChanged);
            // 
            // NamaPeminjamBox
            // 
            this.NamaPeminjamBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NamaPeminjamBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaPeminjamBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NamaPeminjamBox.Location = new System.Drawing.Point(251, 191);
            this.NamaPeminjamBox.Name = "NamaPeminjamBox";
            this.NamaPeminjamBox.ReadOnly = true;
            this.NamaPeminjamBox.Size = new System.Drawing.Size(250, 34);
            this.NamaPeminjamBox.TabIndex = 10;
            // 
            // Penulis
            // 
            this.Penulis.AutoSize = true;
            this.Penulis.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penulis.ForeColor = System.Drawing.Color.SeaGreen;
            this.Penulis.Location = new System.Drawing.Point(614, 90);
            this.Penulis.Name = "Penulis";
            this.Penulis.Size = new System.Drawing.Size(129, 31);
            this.Penulis.TabIndex = 8;
            this.Penulis.Text = "tgl pinjam :";
            // 
            // TGLKembaliBox
            // 
            this.TGLKembaliBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TGLKembaliBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TGLKembaliBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TGLKembaliBox.Location = new System.Drawing.Point(834, 140);
            this.TGLKembaliBox.Name = "TGLKembaliBox";
            this.TGLKembaliBox.ReadOnly = true;
            this.TGLKembaliBox.Size = new System.Drawing.Size(268, 34);
            this.TGLKembaliBox.TabIndex = 12;
            // 
            // labelNamaBuku
            // 
            this.labelNamaBuku.AutoSize = true;
            this.labelNamaBuku.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBuku.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelNamaBuku.Location = new System.Drawing.Point(24, 93);
            this.labelNamaBuku.Name = "labelNamaBuku";
            this.labelNamaBuku.Size = new System.Drawing.Size(141, 31);
            this.labelNamaBuku.TabIndex = 25;
            this.labelNamaBuku.Text = "Nama buku :";
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.ForeColor = System.Drawing.Color.SeaGreen;
            this.Judul.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Judul.Location = new System.Drawing.Point(24, 194);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(194, 31);
            this.Judul.TabIndex = 5;
            this.Judul.Text = "Nama peminjam :";
            this.Judul.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Penerbit
            // 
            this.Penerbit.AutoSize = true;
            this.Penerbit.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penerbit.ForeColor = System.Drawing.Color.SeaGreen;
            this.Penerbit.Location = new System.Drawing.Point(614, 143);
            this.Penerbit.Name = "Penerbit";
            this.Penerbit.Size = new System.Drawing.Size(203, 31);
            this.Penerbit.TabIndex = 7;
            this.Penerbit.Text = "tgl harus kembali :";
            // 
            // TGLPinjamBox
            // 
            this.TGLPinjamBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TGLPinjamBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TGLPinjamBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TGLPinjamBox.Location = new System.Drawing.Point(834, 87);
            this.TGLPinjamBox.Name = "TGLPinjamBox";
            this.TGLPinjamBox.ReadOnly = true;
            this.TGLPinjamBox.Size = new System.Drawing.Size(268, 34);
            this.TGLPinjamBox.TabIndex = 11;
            // 
            // PengembalianAdmin_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detailPeminjamanBox);
            this.Controls.Add(this.ListPengembalianBox);
            this.Name = "PengembalianAdmin_uc";
            this.Size = new System.Drawing.Size(1174, 671);
            this.ListPengembalianBox.ResumeLayout(false);
            this.ListPengembalianBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.detailPeminjamanBox.ResumeLayout(false);
            this.detailPeminjamanBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ListPengembalianBox;
        private Guna.UI2.WinForms.Guna2Button resetButton;
        private Guna.UI2.WinForms.Guna2DateTimePicker filterDate;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button SearchpengembalianButton;
        private System.Windows.Forms.TextBox searchBoxx;
        private System.Windows.Forms.GroupBox detailPeminjamanBox;
        private Guna.UI2.WinForms.Guna2Button DikembalikanButton;
        private System.Windows.Forms.ComboBox NamaBukuBox;
        private System.Windows.Forms.TextBox NamaPeminjamBox;
        private System.Windows.Forms.Label Penulis;
        private System.Windows.Forms.TextBox TGLKembaliBox;
        private System.Windows.Forms.Label labelNamaBuku;
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.Label Penerbit;
        private System.Windows.Forms.TextBox TGLPinjamBox;
        private System.Windows.Forms.ComboBox KategoriBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
