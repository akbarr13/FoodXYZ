namespace FoodXyzDesk
{
    partial class KasirForm
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
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPick = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totalForm = new System.Windows.Forms.TextBox();
            this.qtyForm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hargaForm = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.editBtn = new System.Windows.Forms.Button();
            this.tambahBtn = new System.Windows.Forms.Button();
            this.keranjang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.bayarForm = new System.Windows.Forms.TextBox();
            this.hargaLabel = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.kembalianLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 439);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 54);
            this.button3.TabIndex = 55;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 46);
            this.label3.TabIndex = 52;
            this.label3.Text = "Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 46);
            this.label2.TabIndex = 53;
            this.label2.Text = "Kelola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 46);
            this.label1.TabIndex = 54;
            this.label1.Text = "Kasir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 46);
            this.label4.TabIndex = 54;
            this.label4.Text = "Form Transaksi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuPick);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.totalForm);
            this.panel1.Controls.Add(this.qtyForm);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.hargaForm);
            this.panel1.Location = new System.Drawing.Point(244, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 119);
            this.panel1.TabIndex = 56;
            // 
            // menuPick
            // 
            this.menuPick.FormattingEnabled = true;
            this.menuPick.Location = new System.Drawing.Point(25, 28);
            this.menuPick.Name = "menuPick";
            this.menuPick.Size = new System.Drawing.Size(213, 21);
            this.menuPick.TabIndex = 40;
            this.menuPick.SelectedIndexChanged += new System.EventHandler(this.menuPick_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Pilih menu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Harga Satuan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Quantitas";
            // 
            // totalForm
            // 
            this.totalForm.Enabled = false;
            this.totalForm.Location = new System.Drawing.Point(343, 72);
            this.totalForm.Name = "totalForm";
            this.totalForm.Size = new System.Drawing.Size(213, 20);
            this.totalForm.TabIndex = 38;
            // 
            // qtyForm
            // 
            this.qtyForm.Location = new System.Drawing.Point(343, 29);
            this.qtyForm.Name = "qtyForm";
            this.qtyForm.Size = new System.Drawing.Size(213, 20);
            this.qtyForm.TabIndex = 38;
            this.qtyForm.TextChanged += new System.EventHandler(this.qtyForm_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Total Harga";
            // 
            // hargaForm
            // 
            this.hargaForm.Enabled = false;
            this.hargaForm.Location = new System.Drawing.Point(25, 72);
            this.hargaForm.Name = "hargaForm";
            this.hargaForm.Size = new System.Drawing.Size(213, 20);
            this.hargaForm.TabIndex = 37;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(645, 34);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(211, 46);
            this.usernameLabel.TabIndex = 57;
            this.usernameLabel.Text = "Username";
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(719, 218);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(130, 54);
            this.editBtn.TabIndex = 59;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // tambahBtn
            // 
            this.tambahBtn.Location = new System.Drawing.Point(583, 218);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(130, 54);
            this.tambahBtn.TabIndex = 58;
            this.tambahBtn.Text = "Tambah";
            this.tambahBtn.UseVisualStyleBackColor = true;
            this.tambahBtn.Click += new System.EventHandler(this.tambahBtn_Click);
            // 
            // keranjang
            // 
            this.keranjang.AllowUserToAddRows = false;
            this.keranjang.AllowUserToDeleteRows = false;
            this.keranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7});
            this.keranjang.Location = new System.Drawing.Point(250, 306);
            this.keranjang.Name = "keranjang";
            this.keranjang.ReadOnly = true;
            this.keranjang.Size = new System.Drawing.Size(645, 187);
            this.keranjang.TabIndex = 60;
            this.keranjang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.keranjang_CellContentClick);
            this.keranjang.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.keranjang_ColumnAdded);
            this.keranjang.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.keranjang_RowsAdded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Transaksi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kode Barang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nama Barang";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Harga Satuan";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Kuantitas";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Subtotal";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Keranjang";
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(583, 597);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(130, 54);
            this.printBtn.TabIndex = 58;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // simpanBtn
            // 
            this.simpanBtn.Location = new System.Drawing.Point(719, 597);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(130, 54);
            this.simpanBtn.TabIndex = 59;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 531);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Total Harga : ";
            // 
            // bayarForm
            // 
            this.bayarForm.Location = new System.Drawing.Point(246, 547);
            this.bayarForm.Name = "bayarForm";
            this.bayarForm.Size = new System.Drawing.Size(204, 20);
            this.bayarForm.TabIndex = 61;
            // 
            // hargaLabel
            // 
            this.hargaLabel.AutoSize = true;
            this.hargaLabel.Location = new System.Drawing.Point(378, 531);
            this.hargaLabel.Name = "hargaLabel";
            this.hargaLabel.Size = new System.Drawing.Size(60, 13);
            this.hargaLabel.TabIndex = 62;
            this.hargaLabel.Text = "hargaLabel";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(250, 573);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 33);
            this.button6.TabIndex = 58;
            this.button6.Text = "Bayar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 618);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Kembalian :";
            // 
            // kembalianLabel
            // 
            this.kembalianLabel.AutoSize = true;
            this.kembalianLabel.Location = new System.Drawing.Point(378, 618);
            this.kembalianLabel.Name = "kembalianLabel";
            this.kembalianLabel.Size = new System.Drawing.Size(0, 13);
            this.kembalianLabel.TabIndex = 62;
            // 
            // KasirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 745);
            this.Controls.Add(this.kembalianLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hargaLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bayarForm);
            this.Controls.Add(this.keranjang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.tambahBtn);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "KasirForm";
            this.Text = "KasirForm";
            this.Load += new System.EventHandler(this.KasirForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox menuPick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalForm;
        private System.Windows.Forms.TextBox qtyForm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hargaForm;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button tambahBtn;
        private System.Windows.Forms.DataGridView keranjang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bayarForm;
        private System.Windows.Forms.Label hargaLabel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label kembalianLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}