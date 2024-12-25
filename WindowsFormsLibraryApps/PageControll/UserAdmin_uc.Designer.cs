namespace WindowsFormsLibraryApps.PageControll
{
    partial class UserAdmin_uc
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.tambahButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchBoxx = new System.Windows.Forms.TextBox();
            this.SearchButton = new Guna.UI2.WinForms.Guna2Button();
            this.namauserBox = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.namaUser = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.email = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.passwordBoxx = new System.Windows.Forms.TextBox();
            this.role = new System.Windows.Forms.Label();
            this.roleBoxx = new System.Windows.Forms.ComboBox();
            this.setboxUser1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.setboxUser1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.BorderRadius = 10;
            this.updateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButton.FillColor = System.Drawing.Color.SeaGreen;
            this.updateButton.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.updateButton.Location = new System.Drawing.Point(167, 512);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(118, 58);
            this.updateButton.TabIndex = 42;
            this.updateButton.Text = "Update";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // tambahButton
            // 
            this.tambahButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tambahButton.BorderRadius = 10;
            this.tambahButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tambahButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tambahButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tambahButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tambahButton.FillColor = System.Drawing.Color.SeaGreen;
            this.tambahButton.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tambahButton.Location = new System.Drawing.Point(22, 512);
            this.tambahButton.Name = "tambahButton";
            this.tambahButton.Size = new System.Drawing.Size(133, 58);
            this.tambahButton.TabIndex = 43;
            this.tambahButton.Text = "Tambah";
            this.tambahButton.Click += new System.EventHandler(this.tambahButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BorderRadius = 10;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.SeaGreen;
            this.deleteButton.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.Location = new System.Drawing.Point(295, 512);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 58);
            this.deleteButton.TabIndex = 44;
            this.deleteButton.Text = "Hapus";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.resetButton.Location = new System.Drawing.Point(294, 47);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(118, 49);
            this.resetButton.TabIndex = 51;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // searchBoxx
            // 
            this.searchBoxx.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxx.Location = new System.Drawing.Point(265, 66);
            this.searchBoxx.Name = "searchBoxx";
            this.searchBoxx.Size = new System.Drawing.Size(228, 34);
            this.searchBoxx.TabIndex = 53;
            this.searchBoxx.TextChanged += new System.EventHandler(this.searchBoxx_TextChanged);
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
            this.SearchButton.Location = new System.Drawing.Point(512, 60);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(106, 40);
            this.SearchButton.TabIndex = 52;
            this.SearchButton.Text = "Cari";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // namauserBox
            // 
            this.namauserBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.namauserBox.Location = new System.Drawing.Point(182, 119);
            this.namauserBox.Name = "namauserBox";
            this.namauserBox.Size = new System.Drawing.Size(230, 34);
            this.namauserBox.TabIndex = 35;
            this.namauserBox.TextChanged += new System.EventHandler(this.namauserBox_TextChanged);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.SeaGreen;
            this.gender.Location = new System.Drawing.Point(28, 179);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(98, 31);
            this.gender.TabIndex = 33;
            this.gender.Text = "Gender :";
            // 
            // namaUser
            // 
            this.namaUser.AutoSize = true;
            this.namaUser.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaUser.ForeColor = System.Drawing.Color.SeaGreen;
            this.namaUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.namaUser.Location = new System.Drawing.Point(28, 117);
            this.namaUser.Name = "namaUser";
            this.namaUser.Size = new System.Drawing.Size(129, 31);
            this.namaUser.TabIndex = 31;
            this.namaUser.Text = "Nama User:";
            this.namaUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // genderBox
            // 
            this.genderBox.BackColor = System.Drawing.SystemColors.Info;
            this.genderBox.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderBox.ForeColor = System.Drawing.Color.SeaGreen;
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(182, 174);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(230, 36);
            this.genderBox.TabIndex = 45;
            this.genderBox.SelectedIndexChanged += new System.EventHandler(this.genderBox_SelectedIndexChanged);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.SeaGreen;
            this.email.Location = new System.Drawing.Point(28, 249);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(80, 31);
            this.email.TabIndex = 51;
            this.email.Text = "Email :";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.emailBox.Location = new System.Drawing.Point(182, 249);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(230, 34);
            this.emailBox.TabIndex = 52;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.SeaGreen;
            this.username.Location = new System.Drawing.Point(28, 314);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(127, 31);
            this.username.TabIndex = 53;
            this.username.Text = "Username :";
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.usernameBox.Location = new System.Drawing.Point(182, 314);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(230, 34);
            this.usernameBox.TabIndex = 54;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.SeaGreen;
            this.password.Location = new System.Drawing.Point(28, 379);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(121, 31);
            this.password.TabIndex = 55;
            this.password.Text = "Password :";
            // 
            // passwordBoxx
            // 
            this.passwordBoxx.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.passwordBoxx.Location = new System.Drawing.Point(182, 379);
            this.passwordBoxx.Name = "passwordBoxx";
            this.passwordBoxx.Size = new System.Drawing.Size(230, 34);
            this.passwordBoxx.TabIndex = 56;
            this.passwordBoxx.TextChanged += new System.EventHandler(this.passwordBoxx_TextChanged);
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role.ForeColor = System.Drawing.Color.SeaGreen;
            this.role.Location = new System.Drawing.Point(28, 448);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(67, 31);
            this.role.TabIndex = 57;
            this.role.Text = "Role :";
            // 
            // roleBoxx
            // 
            this.roleBoxx.BackColor = System.Drawing.SystemColors.Info;
            this.roleBoxx.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleBoxx.ForeColor = System.Drawing.Color.SeaGreen;
            this.roleBoxx.FormattingEnabled = true;
            this.roleBoxx.Location = new System.Drawing.Point(182, 443);
            this.roleBoxx.Name = "roleBoxx";
            this.roleBoxx.Size = new System.Drawing.Size(230, 36);
            this.roleBoxx.TabIndex = 58;
            this.roleBoxx.SelectedIndexChanged += new System.EventHandler(this.roleBoxx_SelectedIndexChanged);
            // 
            // setboxUser1
            // 
            this.setboxUser1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.setboxUser1.Controls.Add(this.resetButton);
            this.setboxUser1.Controls.Add(this.roleBoxx);
            this.setboxUser1.Controls.Add(this.role);
            this.setboxUser1.Controls.Add(this.passwordBoxx);
            this.setboxUser1.Controls.Add(this.updateButton);
            this.setboxUser1.Controls.Add(this.deleteButton);
            this.setboxUser1.Controls.Add(this.password);
            this.setboxUser1.Controls.Add(this.tambahButton);
            this.setboxUser1.Controls.Add(this.usernameBox);
            this.setboxUser1.Controls.Add(this.username);
            this.setboxUser1.Controls.Add(this.emailBox);
            this.setboxUser1.Controls.Add(this.email);
            this.setboxUser1.Controls.Add(this.genderBox);
            this.setboxUser1.Controls.Add(this.namaUser);
            this.setboxUser1.Controls.Add(this.gender);
            this.setboxUser1.Controls.Add(this.namauserBox);
            this.setboxUser1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setboxUser1.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setboxUser1.ForeColor = System.Drawing.Color.SeaGreen;
            this.setboxUser1.Location = new System.Drawing.Point(39, 35);
            this.setboxUser1.Name = "setboxUser1";
            this.setboxUser1.Size = new System.Drawing.Size(437, 601);
            this.setboxUser1.TabIndex = 54;
            this.setboxUser1.TabStop = false;
            this.setboxUser1.Text = "ATUR USER";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.roleBox);
            this.groupBox1.Controls.Add(this.guna2DataGridView1);
            this.groupBox1.Controls.Add(this.searchBoxx);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(494, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 601);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATA USER";
            // 
            // roleBox
            // 
            this.roleBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Location = new System.Drawing.Point(15, 66);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(243, 39);
            this.roleBox.TabIndex = 55;
            this.roleBox.SelectedIndexChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
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
            this.guna2DataGridView1.Location = new System.Drawing.Point(15, 117);
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
            this.guna2DataGridView1.Size = new System.Drawing.Size(603, 453);
            this.guna2DataGridView1.TabIndex = 54;
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
            // UserAdmin_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.setboxUser1);
            this.Name = "UserAdmin_uc";
            this.Size = new System.Drawing.Size(1174, 671);
            this.Load += new System.EventHandler(this.UserAdmin_uc_Load);
            this.setboxUser1.ResumeLayout(false);
            this.setboxUser1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button tambahButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button resetButton;
        private System.Windows.Forms.TextBox searchBoxx;
        private Guna.UI2.WinForms.Guna2Button SearchButton;
        private System.Windows.Forms.TextBox namauserBox;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label namaUser;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordBoxx;
        private System.Windows.Forms.Label role;
        private System.Windows.Forms.ComboBox roleBoxx;
        private System.Windows.Forms.GroupBox setboxUser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.ComboBox roleBox;
    }
}
