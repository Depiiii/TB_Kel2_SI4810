namespace WindowsFormsLibraryApps.PageControll
{
    partial class HistoriAdmin_uc
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.historiBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.resetButton = new Guna.UI2.WinForms.Guna2Button();
            this.filterDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchistoriButton = new Guna.UI2.WinForms.Guna2Button();
            this.searchBoxx = new System.Windows.Forms.TextBox();
            this.historiBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // historiBox
            // 
            this.historiBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.historiBox.Controls.Add(this.label5);
            this.historiBox.Controls.Add(this.comboBox1);
            this.historiBox.Controls.Add(this.resetButton);
            this.historiBox.Controls.Add(this.filterDate);
            this.historiBox.Controls.Add(this.guna2DataGridView1);
            this.historiBox.Controls.Add(this.SearchistoriButton);
            this.historiBox.Controls.Add(this.searchBoxx);
            this.historiBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.historiBox.Font = new System.Drawing.Font("Poppins", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historiBox.ForeColor = System.Drawing.Color.SeaGreen;
            this.historiBox.Location = new System.Drawing.Point(22, 25);
            this.historiBox.Name = "historiBox";
            this.historiBox.Size = new System.Drawing.Size(1130, 558);
            this.historiBox.TabIndex = 34;
            this.historiBox.TabStop = false;
            this.historiBox.Text = "Histori peminjaman Admin";
            this.historiBox.Enter += new System.EventHandler(this.historiBox_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(19, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 31);
            this.label5.TabIndex = 39;
            this.label5.Text = "klik pada salah data untuk melihat detailnya!";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(485, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 39);
            this.comboBox1.TabIndex = 38;
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
            this.resetButton.Location = new System.Drawing.Point(15, 126);
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
            this.filterDate.Location = new System.Drawing.Point(163, 126);
            this.filterDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.filterDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.filterDate.Name = "filterDate";
            this.filterDate.Size = new System.Drawing.Size(316, 36);
            this.filterDate.TabIndex = 36;
            this.filterDate.Value = new System.DateTime(2024, 12, 20, 5, 6, 31, 392);
            this.filterDate.ValueChanged += new System.EventHandler(this.filterDate_ValueChanged);
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
            this.guna2DataGridView1.ColumnHeadersHeight = 50;
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
            this.guna2DataGridView1.Location = new System.Drawing.Point(15, 183);
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
            this.guna2DataGridView1.Size = new System.Drawing.Size(1100, 353);
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
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 50;
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
            // SearchistoriButton
            // 
            this.SearchistoriButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SearchistoriButton.BorderRadius = 10;
            this.SearchistoriButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchistoriButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchistoriButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchistoriButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchistoriButton.FillColor = System.Drawing.Color.SeaGreen;
            this.SearchistoriButton.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchistoriButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchistoriButton.Location = new System.Drawing.Point(984, 121);
            this.SearchistoriButton.Name = "SearchistoriButton";
            this.SearchistoriButton.Size = new System.Drawing.Size(131, 41);
            this.SearchistoriButton.TabIndex = 29;
            this.SearchistoriButton.Text = "Cari";
            this.SearchistoriButton.Click += new System.EventHandler(this.SearchistoriButton_Click);
            // 
            // searchBoxx
            // 
            this.searchBoxx.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxx.Location = new System.Drawing.Point(737, 128);
            this.searchBoxx.Name = "searchBoxx";
            this.searchBoxx.Size = new System.Drawing.Size(241, 34);
            this.searchBoxx.TabIndex = 29;
            this.searchBoxx.TextChanged += new System.EventHandler(this.searchBoxx_TextChanged);
            // 
            // HistoriAdmin_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.historiBox);
            this.Name = "HistoriAdmin_uc";
            this.Size = new System.Drawing.Size(1174, 671);
            this.Load += new System.EventHandler(this.HistoriAdmin_uc_Load);
            this.historiBox.ResumeLayout(false);
            this.historiBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.GroupBox historiBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2Button resetButton;
        private Guna.UI2.WinForms.Guna2DateTimePicker filterDate;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button SearchistoriButton;
        private System.Windows.Forms.TextBox searchBoxx;
        private System.Windows.Forms.Label label5;
    }
}
