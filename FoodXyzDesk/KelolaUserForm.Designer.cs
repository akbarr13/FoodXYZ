﻿namespace FoodXyzDesk
{
    partial class KelolaUserForm
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
            this.userList = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.searchForm = new System.Windows.Forms.TextBox();
            this.tipeUserBox = new System.Windows.Forms.ComboBox();
            this.passwordForm = new System.Windows.Forms.TextBox();
            this.teleponForm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.usernameForm = new System.Windows.Forms.TextBox();
            this.namaForm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.alamatForm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userList.Location = new System.Drawing.Point(237, 347);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(550, 187);
            this.userList.TabIndex = 42;
            this.userList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userList_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Cari";
            // 
            // searchForm
            // 
            this.searchForm.Location = new System.Drawing.Point(246, 321);
            this.searchForm.Name = "searchForm";
            this.searchForm.Size = new System.Drawing.Size(204, 20);
            this.searchForm.TabIndex = 40;
            this.searchForm.TextChanged += new System.EventHandler(this.searchForm_TextChanged);
            // 
            // tipeUserBox
            // 
            this.tipeUserBox.FormattingEnabled = true;
            this.tipeUserBox.Items.AddRange(new object[] {
            "Gudang",
            "Kasir"});
            this.tipeUserBox.Location = new System.Drawing.Point(25, 28);
            this.tipeUserBox.Name = "tipeUserBox";
            this.tipeUserBox.Size = new System.Drawing.Size(213, 21);
            this.tipeUserBox.TabIndex = 39;
            // 
            // passwordForm
            // 
            this.passwordForm.Location = new System.Drawing.Point(343, 122);
            this.passwordForm.Name = "passwordForm";
            this.passwordForm.Size = new System.Drawing.Size(213, 20);
            this.passwordForm.TabIndex = 34;
            // 
            // teleponForm
            // 
            this.teleponForm.Location = new System.Drawing.Point(25, 122);
            this.teleponForm.Name = "teleponForm";
            this.teleponForm.Size = new System.Drawing.Size(213, 20);
            this.teleponForm.TabIndex = 35;
            this.teleponForm.TextChanged += new System.EventHandler(this.teleponForm_TextChanged);
            this.teleponForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.teleponForm_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Password";
            // 
            // usernameForm
            // 
            this.usernameForm.Location = new System.Drawing.Point(343, 72);
            this.usernameForm.Name = "usernameForm";
            this.usernameForm.Size = new System.Drawing.Size(213, 20);
            this.usernameForm.TabIndex = 36;
            // 
            // namaForm
            // 
            this.namaForm.Location = new System.Drawing.Point(25, 72);
            this.namaForm.Name = "namaForm";
            this.namaForm.Size = new System.Drawing.Size(213, 20);
            this.namaForm.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Username";
            // 
            // alamatForm
            // 
            this.alamatForm.Location = new System.Drawing.Point(343, 29);
            this.alamatForm.Name = "alamatForm";
            this.alamatForm.Size = new System.Drawing.Size(213, 20);
            this.alamatForm.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Alamat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Teleon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tipe User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 46);
            this.label3.TabIndex = 27;
            this.label3.Text = "Kelola User";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(43, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 54);
            this.button3.TabIndex = 25;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 54);
            this.button2.TabIndex = 24;
            this.button2.Text = "Kelola Laporan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(555, 245);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 54);
            this.button6.TabIndex = 23;
            this.button6.Text = "Hapus";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(408, 245);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 54);
            this.button5.TabIndex = 22;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 54);
            this.button4.TabIndex = 21;
            this.button4.Text = "Tambah";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 54);
            this.button1.TabIndex = 26;
            this.button1.Text = "Kelola User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "Admin";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.passwordForm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tipeUserBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.alamatForm);
            this.panel1.Controls.Add(this.teleponForm);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.namaForm);
            this.panel1.Controls.Add(this.usernameForm);
            this.panel1.Location = new System.Drawing.Point(228, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 165);
            this.panel1.TabIndex = 43;
            // 
            // KelolaUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 607);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.searchForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "KelolaUserForm";
            this.Text = "KelolaUserForm";
            this.Load += new System.EventHandler(this.KelolaUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox searchForm;
        private System.Windows.Forms.ComboBox tipeUserBox;
        private System.Windows.Forms.TextBox passwordForm;
        private System.Windows.Forms.TextBox teleponForm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox usernameForm;
        private System.Windows.Forms.TextBox namaForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox alamatForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}