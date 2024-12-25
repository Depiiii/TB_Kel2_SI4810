﻿namespace WindowsFormsLibraryApps
{
    partial class FormLoginAdmin
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.GroupLogin = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonKlikLogin = new System.Windows.Forms.Button();
            this.GroupLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelLogin.Location = new System.Drawing.Point(297, 145);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(585, 70);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login Admin Perpustakaan";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.labelUserLogin.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserLogin.ForeColor = System.Drawing.SystemColors.Info;
            this.labelUserLogin.Location = new System.Drawing.Point(33, 66);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(118, 36);
            this.labelUserLogin.TabIndex = 1;
            this.labelUserLogin.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(34, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxUsername.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxUsername.Location = new System.Drawing.Point(30, 105);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(440, 26);
            this.textBoxUsername.TabIndex = 3;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.textBoxPassword.Location = new System.Drawing.Point(29, 200);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(8);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(440, 26);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // GroupLogin
            // 
            this.GroupLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.GroupLogin.Controls.Add(this.button1);
            this.GroupLogin.Controls.Add(this.label1);
            this.GroupLogin.Controls.Add(this.textBoxPassword);
            this.GroupLogin.Controls.Add(this.labelUserLogin);
            this.GroupLogin.Controls.Add(this.textBoxUsername);
            this.GroupLogin.Location = new System.Drawing.Point(334, 256);
            this.GroupLogin.Name = "GroupLogin";
            this.GroupLogin.Size = new System.Drawing.Size(510, 272);
            this.GroupLogin.TabIndex = 5;
            this.GroupLogin.TabStop = false;
            this.GroupLogin.Text = " ";
            this.GroupLogin.Enter += new System.EventHandler(this.GroupLogin_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(291, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Saya pengunjung";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonKlikLogin
            // 
            this.buttonKlikLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonKlikLogin.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKlikLogin.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonKlikLogin.Location = new System.Drawing.Point(516, 560);
            this.buttonKlikLogin.Name = "buttonKlikLogin";
            this.buttonKlikLogin.Size = new System.Drawing.Size(146, 39);
            this.buttonKlikLogin.TabIndex = 6;
            this.buttonKlikLogin.Text = "Login";
            this.buttonKlikLogin.UseVisualStyleBackColor = false;
            this.buttonKlikLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.buttonKlikLogin);
            this.Controls.Add(this.GroupLogin);
            this.Controls.Add(this.labelLogin);
            this.Name = "FormLoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLoginAdmin_Load);
            this.GroupLogin.ResumeLayout(false);
            this.GroupLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox GroupLogin;
        private System.Windows.Forms.Button buttonKlikLogin;
        private System.Windows.Forms.Button button1;
    }
}