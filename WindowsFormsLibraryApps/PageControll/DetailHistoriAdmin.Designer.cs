namespace WindowsFormsLibraryApps.PageControll
{
    partial class DetailHistoriAdmin
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
            this.detailHistori = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DendaBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TGLDikembalikanBox = new System.Windows.Forms.TextBox();
            this.Penerbit = new System.Windows.Forms.Label();
            this.TGLPinjamBox = new System.Windows.Forms.TextBox();
            this.TGLKembaliBox = new System.Windows.Forms.TextBox();
            this.Penulis = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NamaPeminjamBox = new System.Windows.Forms.ComboBox();
            this.UsernameBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gambarBox = new System.Windows.Forms.PictureBox();
            this.PengarangBox2 = new System.Windows.Forms.ComboBox();
            this.labelNamaBuku = new System.Windows.Forms.Label();
            this.NamaBukuBox = new System.Windows.Forms.ComboBox();
            this.PenerbitBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KategoriBox = new System.Windows.Forms.ComboBox();
            this.kembaliButton = new Guna.UI2.WinForms.Guna2Button();
            this.detailHistori.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gambarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // detailHistori
            // 
            this.detailHistori.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detailHistori.Controls.Add(this.groupBox3);
            this.detailHistori.Controls.Add(this.groupBox2);
            this.detailHistori.Controls.Add(this.groupBox1);
            this.detailHistori.Controls.Add(this.kembaliButton);
            this.detailHistori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detailHistori.Font = new System.Drawing.Font("Poppins", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailHistori.ForeColor = System.Drawing.Color.SeaGreen;
            this.detailHistori.Location = new System.Drawing.Point(19, 27);
            this.detailHistori.Name = "detailHistori";
            this.detailHistori.Size = new System.Drawing.Size(1130, 610);
            this.detailHistori.TabIndex = 36;
            this.detailHistori.TabStop = false;
            this.detailHistori.Text = "Detail data histori";
            this.detailHistori.Enter += new System.EventHandler(this.detailHistori_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.StatusBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.DendaBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TGLDikembalikanBox);
            this.groupBox3.Controls.Add(this.Penerbit);
            this.groupBox3.Controls.Add(this.TGLPinjamBox);
            this.groupBox3.Controls.Add(this.TGLKembaliBox);
            this.groupBox3.Controls.Add(this.Penulis);
            this.groupBox3.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(807, 198);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data peminjaman";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(459, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = "status :";
            // 
            // StatusBox
            // 
            this.StatusBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StatusBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StatusBox.Location = new System.Drawing.Point(554, 39);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(211, 34);
            this.StatusBox.TabIndex = 18;
            this.StatusBox.TextChanged += new System.EventHandler(this.StatusBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(455, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "denda :";
            // 
            // DendaBox
            // 
            this.DendaBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DendaBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DendaBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DendaBox.Location = new System.Drawing.Point(554, 92);
            this.DendaBox.Name = "DendaBox";
            this.DendaBox.ReadOnly = true;
            this.DendaBox.Size = new System.Drawing.Size(211, 34);
            this.DendaBox.TabIndex = 16;
            this.DendaBox.TextChanged += new System.EventHandler(this.DendaBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(6, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "tgl dikembalikan :";
            // 
            // TGLDikembalikanBox
            // 
            this.TGLDikembalikanBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TGLDikembalikanBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TGLDikembalikanBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TGLDikembalikanBox.Location = new System.Drawing.Point(210, 147);
            this.TGLDikembalikanBox.Name = "TGLDikembalikanBox";
            this.TGLDikembalikanBox.ReadOnly = true;
            this.TGLDikembalikanBox.Size = new System.Drawing.Size(232, 34);
            this.TGLDikembalikanBox.TabIndex = 14;
            this.TGLDikembalikanBox.TextChanged += new System.EventHandler(this.TGLDikembalikanBox_TextChanged);
            // 
            // Penerbit
            // 
            this.Penerbit.AutoSize = true;
            this.Penerbit.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penerbit.ForeColor = System.Drawing.Color.SeaGreen;
            this.Penerbit.Location = new System.Drawing.Point(5, 92);
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
            this.TGLPinjamBox.Location = new System.Drawing.Point(209, 39);
            this.TGLPinjamBox.Name = "TGLPinjamBox";
            this.TGLPinjamBox.ReadOnly = true;
            this.TGLPinjamBox.Size = new System.Drawing.Size(233, 34);
            this.TGLPinjamBox.TabIndex = 11;
            this.TGLPinjamBox.TextChanged += new System.EventHandler(this.TGLPinjamBox_TextChanged);
            // 
            // TGLKembaliBox
            // 
            this.TGLKembaliBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TGLKembaliBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TGLKembaliBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TGLKembaliBox.Location = new System.Drawing.Point(209, 92);
            this.TGLKembaliBox.Name = "TGLKembaliBox";
            this.TGLKembaliBox.ReadOnly = true;
            this.TGLKembaliBox.Size = new System.Drawing.Size(233, 34);
            this.TGLKembaliBox.TabIndex = 12;
            this.TGLKembaliBox.TextChanged += new System.EventHandler(this.TGLKembaliBox_TextChanged);
            // 
            // Penulis
            // 
            this.Penulis.AutoSize = true;
            this.Penulis.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penulis.ForeColor = System.Drawing.Color.SeaGreen;
            this.Penulis.Location = new System.Drawing.Point(5, 39);
            this.Penulis.Name = "Penulis";
            this.Penulis.Size = new System.Drawing.Size(129, 31);
            this.Penulis.TabIndex = 8;
            this.Penulis.Text = "tgl pinjam :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.EmailBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.NamaPeminjamBox);
            this.groupBox2.Controls.Add(this.UsernameBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.GenderBox);
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(662, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 269);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data peminjam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(14, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 31);
            this.label4.TabIndex = 39;
            this.label4.Text = "email :";
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EmailBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.EmailBox.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmailBox.FormattingEnabled = true;
            this.EmailBox.Location = new System.Drawing.Point(155, 154);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(250, 36);
            this.EmailBox.TabIndex = 38;
            this.EmailBox.SelectedIndexChanged += new System.EventHandler(this.EmailBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(14, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nama :";
            // 
            // NamaPeminjamBox
            // 
            this.NamaPeminjamBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NamaPeminjamBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.NamaPeminjamBox.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaPeminjamBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NamaPeminjamBox.FormattingEnabled = true;
            this.NamaPeminjamBox.Location = new System.Drawing.Point(155, 56);
            this.NamaPeminjamBox.Name = "NamaPeminjamBox";
            this.NamaPeminjamBox.Size = new System.Drawing.Size(250, 36);
            this.NamaPeminjamBox.TabIndex = 9;
            this.NamaPeminjamBox.SelectedIndexChanged += new System.EventHandler(this.NamaPeminjamBox_SelectedIndexChanged);
            // 
            // UsernameBox
            // 
            this.UsernameBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UsernameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.UsernameBox.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UsernameBox.FormattingEnabled = true;
            this.UsernameBox.Location = new System.Drawing.Point(155, 207);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(250, 36);
            this.UsernameBox.TabIndex = 36;
            this.UsernameBox.SelectedIndexChanged += new System.EventHandler(this.UsernameBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(14, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 31);
            this.label6.TabIndex = 34;
            this.label6.Text = "gender :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(14, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 31);
            this.label7.TabIndex = 37;
            this.label7.Text = "username :";
            // 
            // GenderBox
            // 
            this.GenderBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.GenderBox.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Location = new System.Drawing.Point(155, 103);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(250, 36);
            this.GenderBox.TabIndex = 33;
            this.GenderBox.SelectedIndexChanged += new System.EventHandler(this.GenderBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gambarBox);
            this.groupBox1.Controls.Add(this.PengarangBox2);
            this.groupBox1.Controls.Add(this.labelNamaBuku);
            this.groupBox1.Controls.Add(this.NamaBukuBox);
            this.groupBox1.Controls.Add(this.PenerbitBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.KategoriBox);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 269);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(216, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 31);
            this.label3.TabIndex = 39;
            this.label3.Text = "pengarang :";
            // 
            // gambarBox
            // 
            this.gambarBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gambarBox.Location = new System.Drawing.Point(32, 52);
            this.gambarBox.Name = "gambarBox";
            this.gambarBox.Size = new System.Drawing.Size(138, 191);
            this.gambarBox.TabIndex = 35;
            this.gambarBox.TabStop = false;
            this.gambarBox.Click += new System.EventHandler(this.gambarBox_Click);
            // 
            // PengarangBox2
            // 
            this.PengarangBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PengarangBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.PengarangBox2.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PengarangBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PengarangBox2.FormattingEnabled = true;
            this.PengarangBox2.Location = new System.Drawing.Point(363, 154);
            this.PengarangBox2.Name = "PengarangBox2";
            this.PengarangBox2.Size = new System.Drawing.Size(250, 36);
            this.PengarangBox2.TabIndex = 38;
            this.PengarangBox2.SelectedIndexChanged += new System.EventHandler(this.PengarangBox2_SelectedIndexChanged);
            // 
            // labelNamaBuku
            // 
            this.labelNamaBuku.AutoSize = true;
            this.labelNamaBuku.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBuku.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelNamaBuku.Location = new System.Drawing.Point(216, 57);
            this.labelNamaBuku.Name = "labelNamaBuku";
            this.labelNamaBuku.Size = new System.Drawing.Size(141, 31);
            this.labelNamaBuku.TabIndex = 25;
            this.labelNamaBuku.Text = "Nama buku :";
            // 
            // NamaBukuBox
            // 
            this.NamaBukuBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NamaBukuBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.NamaBukuBox.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaBukuBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NamaBukuBox.FormattingEnabled = true;
            this.NamaBukuBox.Location = new System.Drawing.Point(363, 56);
            this.NamaBukuBox.Name = "NamaBukuBox";
            this.NamaBukuBox.Size = new System.Drawing.Size(250, 36);
            this.NamaBukuBox.TabIndex = 9;
            this.NamaBukuBox.SelectedIndexChanged += new System.EventHandler(this.NamaBukuBox_SelectedIndexChanged);
            // 
            // PenerbitBox1
            // 
            this.PenerbitBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PenerbitBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.PenerbitBox1.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenerbitBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PenerbitBox1.FormattingEnabled = true;
            this.PenerbitBox1.Location = new System.Drawing.Point(363, 211);
            this.PenerbitBox1.Name = "PenerbitBox1";
            this.PenerbitBox1.Size = new System.Drawing.Size(250, 36);
            this.PenerbitBox1.TabIndex = 36;
            this.PenerbitBox1.SelectedIndexChanged += new System.EventHandler(this.PenerbitBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(216, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "kategori :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(216, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 37;
            this.label2.Text = "penerbit :";
            // 
            // KategoriBox
            // 
            this.KategoriBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KategoriBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.KategoriBox.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KategoriBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.KategoriBox.FormattingEnabled = true;
            this.KategoriBox.Location = new System.Drawing.Point(363, 105);
            this.KategoriBox.Name = "KategoriBox";
            this.KategoriBox.Size = new System.Drawing.Size(250, 36);
            this.KategoriBox.TabIndex = 33;
            this.KategoriBox.SelectedIndexChanged += new System.EventHandler(this.KategoriBox_SelectedIndexChanged);
            // 
            // kembaliButton
            // 
            this.kembaliButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.kembaliButton.BorderRadius = 10;
            this.kembaliButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kembaliButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kembaliButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kembaliButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kembaliButton.FillColor = System.Drawing.Color.DarkGreen;
            this.kembaliButton.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kembaliButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.kembaliButton.Location = new System.Drawing.Point(913, 521);
            this.kembaliButton.Name = "kembaliButton";
            this.kembaliButton.Size = new System.Drawing.Size(196, 52);
            this.kembaliButton.TabIndex = 32;
            this.kembaliButton.Text = "kembali";
            this.kembaliButton.Click += new System.EventHandler(this.kembaliButton_Click);
            // 
            // DetailHistoriAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detailHistori);
            this.Name = "DetailHistoriAdmin";
            this.Size = new System.Drawing.Size(1174, 671);
            this.Load += new System.EventHandler(this.DetailHistoriAdmin_Load);
            this.detailHistori.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gambarBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox detailHistori;
        private System.Windows.Forms.ComboBox KategoriBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button kembaliButton;
        private System.Windows.Forms.ComboBox NamaBukuBox;
        private System.Windows.Forms.Label Penulis;
        private System.Windows.Forms.TextBox TGLKembaliBox;
        private System.Windows.Forms.Label labelNamaBuku;
        private System.Windows.Forms.Label Penerbit;
        private System.Windows.Forms.TextBox TGLPinjamBox;
        private System.Windows.Forms.PictureBox gambarBox;
        private System.Windows.Forms.ComboBox PengarangBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PenerbitBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EmailBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NamaPeminjamBox;
        private System.Windows.Forms.ComboBox UsernameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DendaBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TGLDikembalikanBox;
    }
}
