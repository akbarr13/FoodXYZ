﻿namespace FoodXyzDesk.ucAdmin
{
    partial class ucKelolaUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namaForm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teleponForm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.alamatForm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tipeUserBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelola User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipe User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama";
            // 
            // namaForm
            // 
            this.namaForm.Location = new System.Drawing.Point(19, 163);
            this.namaForm.Name = "namaForm";
            this.namaForm.Size = new System.Drawing.Size(213, 20);
            this.namaForm.TabIndex = 4;
            this.namaForm.Text = "admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telepon";
            // 
            // teleponForm
            // 
            this.teleponForm.Location = new System.Drawing.Point(19, 213);
            this.teleponForm.Name = "teleponForm";
            this.teleponForm.Size = new System.Drawing.Size(213, 20);
            this.teleponForm.TabIndex = 4;
            this.teleponForm.Text = "admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alamat";
            // 
            // alamatForm
            // 
            this.alamatForm.Location = new System.Drawing.Point(337, 120);
            this.alamatForm.Name = "alamatForm";
            this.alamatForm.Size = new System.Drawing.Size(213, 20);
            this.alamatForm.TabIndex = 4;
            this.alamatForm.Text = "admin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Username";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(337, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(213, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "admin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(337, 213);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(213, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "admin";
            // 
            // tipeUserBox
            // 
            this.tipeUserBox.FormattingEnabled = true;
            this.tipeUserBox.Items.AddRange(new object[] {
            "Gudang",
            "Kasir",
            "Admin"});
            this.tipeUserBox.Location = new System.Drawing.Point(19, 119);
            this.tipeUserBox.Name = "tipeUserBox";
            this.tipeUserBox.Size = new System.Drawing.Size(213, 21);
            this.tipeUserBox.TabIndex = 5;
            // 
            // ucKelolaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tipeUserBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.teleponForm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.namaForm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alamatForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucKelolaUser";
            this.Size = new System.Drawing.Size(620, 502);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namaForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teleponForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox alamatForm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox tipeUserBox;
    }
}
