namespace FoodXyzDesk
{
    partial class GudangForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.satuanForm = new System.Windows.Forms.ComboBox();
            this.expiredDate = new System.Windows.Forms.DateTimePicker();
            this.hargaForm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kodeForm = new System.Windows.Forms.TextBox();
            this.jumlahForm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.namaForm = new System.Windows.Forms.TextBox();
            this.barangList = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.searchForm = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "Gudang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 46);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kelola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 46);
            this.label3.TabIndex = 21;
            this.label3.Text = "Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 46);
            this.label4.TabIndex = 21;
            this.label4.Text = "Kelola Barang";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.satuanForm);
            this.panel1.Controls.Add(this.expiredDate);
            this.panel1.Controls.Add(this.hargaForm);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.kodeForm);
            this.panel1.Controls.Add(this.jumlahForm);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.namaForm);
            this.panel1.Location = new System.Drawing.Point(228, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 165);
            this.panel1.TabIndex = 44;
            // 
            // satuanForm
            // 
            this.satuanForm.FormattingEnabled = true;
            this.satuanForm.Location = new System.Drawing.Point(343, 70);
            this.satuanForm.Name = "satuanForm";
            this.satuanForm.Size = new System.Drawing.Size(213, 21);
            this.satuanForm.TabIndex = 40;
            // 
            // expiredDate
            // 
            this.expiredDate.Location = new System.Drawing.Point(25, 123);
            this.expiredDate.Name = "expiredDate";
            this.expiredDate.Size = new System.Drawing.Size(213, 20);
            this.expiredDate.TabIndex = 39;
            // 
            // hargaForm
            // 
            this.hargaForm.Location = new System.Drawing.Point(343, 122);
            this.hargaForm.Name = "hargaForm";
            this.hargaForm.Size = new System.Drawing.Size(213, 20);
            this.hargaForm.TabIndex = 34;
            this.hargaForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jumlahForm_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Kode Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Nama Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Expired Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Jumlah Barang";
            // 
            // kodeForm
            // 
            this.kodeForm.Location = new System.Drawing.Point(25, 28);
            this.kodeForm.Name = "kodeForm";
            this.kodeForm.Size = new System.Drawing.Size(213, 20);
            this.kodeForm.TabIndex = 38;
            // 
            // jumlahForm
            // 
            this.jumlahForm.Location = new System.Drawing.Point(343, 29);
            this.jumlahForm.Name = "jumlahForm";
            this.jumlahForm.Size = new System.Drawing.Size(213, 20);
            this.jumlahForm.TabIndex = 38;
            this.jumlahForm.TextChanged += new System.EventHandler(this.jumlahForm_TextChanged);
            this.jumlahForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jumlahForm_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Satuan";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Harga Per Satuan";
            // 
            // namaForm
            // 
            this.namaForm.Location = new System.Drawing.Point(25, 72);
            this.namaForm.Name = "namaForm";
            this.namaForm.Size = new System.Drawing.Size(213, 20);
            this.namaForm.TabIndex = 37;
            // 
            // barangList
            // 
            this.barangList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barangList.Location = new System.Drawing.Point(219, 357);
            this.barangList.Name = "barangList";
            this.barangList.Size = new System.Drawing.Size(550, 187);
            this.barangList.TabIndex = 50;
            this.barangList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barangList_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(229, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Cari";
            // 
            // searchForm
            // 
            this.searchForm.Location = new System.Drawing.Point(228, 331);
            this.searchForm.Name = "searchForm";
            this.searchForm.Size = new System.Drawing.Size(204, 20);
            this.searchForm.TabIndex = 48;
            this.searchForm.TextChanged += new System.EventHandler(this.searchForm_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(537, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 54);
            this.button6.TabIndex = 47;
            this.button6.Text = "Hapus";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(390, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 54);
            this.button5.TabIndex = 46;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(228, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 54);
            this.button4.TabIndex = 45;
            this.button4.Text = "Tambah";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 54);
            this.button3.TabIndex = 51;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // GudangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 578);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.barangList);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.searchForm);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "GudangForm";
            this.Text = "GudangForm";
            this.Load += new System.EventHandler(this.GudangForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barangList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox hargaForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox jumlahForm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox namaForm;
        private System.Windows.Forms.DateTimePicker expiredDate;
        private System.Windows.Forms.TextBox kodeForm;
        private System.Windows.Forms.ComboBox satuanForm;
        private System.Windows.Forms.DataGridView barangList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox searchForm;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}