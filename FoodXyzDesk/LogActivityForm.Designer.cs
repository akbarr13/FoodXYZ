namespace FoodXyzDesk
{
    partial class LogActivityForm
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
            this.logList = new System.Windows.Forms.DataGridView();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userFormBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logList)).BeginInit();
            this.SuspendLayout();
            // 
            // logList
            // 
            this.logList.AllowUserToAddRows = false;
            this.logList.AllowUserToDeleteRows = false;
            this.logList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logList.Location = new System.Drawing.Point(250, 198);
            this.logList.Name = "logList";
            this.logList.ReadOnly = true;
            this.logList.Size = new System.Drawing.Size(518, 190);
            this.logList.TabIndex = 44;
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.CustomFormat = "dd/mm/yyyy";
            this.datePicker.Location = new System.Drawing.Point(250, 143);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tanggal Awal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 46);
            this.label3.TabIndex = 39;
            this.label3.Text = "Log Activity";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 54);
            this.button3.TabIndex = 37;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 54);
            this.button2.TabIndex = 36;
            this.button2.Text = "Kelola Laporan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // userFormBtn
            // 
            this.userFormBtn.Location = new System.Drawing.Point(41, 124);
            this.userFormBtn.Name = "userFormBtn";
            this.userFormBtn.Size = new System.Drawing.Size(130, 54);
            this.userFormBtn.TabIndex = 38;
            this.userFormBtn.Text = "Kelola User";
            this.userFormBtn.UseVisualStyleBackColor = true;
            this.userFormBtn.Click += new System.EventHandler(this.userFormBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 46);
            this.label1.TabIndex = 34;
            this.label1.Text = "Admin";
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(483, 124);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(130, 54);
            this.filterBtn.TabIndex = 36;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logList);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userFormBtn);
            this.Controls.Add(this.label1);
            this.Name = "LogActivityForm";
            this.Text = "LogActivityForm";
            this.Load += new System.EventHandler(this.LogActivityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView logList;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button userFormBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filterBtn;
    }
}