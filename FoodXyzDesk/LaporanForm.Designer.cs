namespace FoodXyzDesk
{
    partial class LaporanForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.soldList = new System.Windows.Forms.DataGridView();
            this.soldChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.generateChart = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.soldList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 46);
            this.label3.TabIndex = 27;
            this.label3.Text = "Laporan Penjualan";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 54);
            this.button3.TabIndex = 25;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 54);
            this.button2.TabIndex = 24;
            this.button2.Text = "Kelola Laporan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 54);
            this.button1.TabIndex = 26;
            this.button1.Text = "Kelola User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tanggal Akhir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tanggal Awal";
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(241, 112);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateFrom.TabIndex = 32;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(460, 112);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTo.TabIndex = 32;
            // 
            // soldList
            // 
            this.soldList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soldList.Location = new System.Drawing.Point(241, 167);
            this.soldList.Name = "soldList";
            this.soldList.Size = new System.Drawing.Size(518, 190);
            this.soldList.TabIndex = 33;
            // 
            // soldChart
            // 
            chartArea1.Name = "ChartArea1";
            this.soldChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.soldChart.Legends.Add(legend1);
            this.soldChart.Location = new System.Drawing.Point(241, 363);
            this.soldChart.Name = "soldChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.soldChart.Series.Add(series1);
            this.soldChart.Size = new System.Drawing.Size(442, 177);
            this.soldChart.TabIndex = 34;
            this.soldChart.Text = "chart1";
            // 
            // generateChart
            // 
            this.generateChart.Location = new System.Drawing.Point(614, 419);
            this.generateChart.Name = "generateChart";
            this.generateChart.Size = new System.Drawing.Size(122, 55);
            this.generateChart.TabIndex = 35;
            this.generateChart.Text = "Generate";
            this.generateChart.UseVisualStyleBackColor = true;
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(676, 92);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(122, 55);
            this.filterBtn.TabIndex = 35;
            this.filterBtn.Text = "filterBtn";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // LaporanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 539);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.generateChart);
            this.Controls.Add(this.soldChart);
            this.Controls.Add(this.soldList);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "LaporanForm";
            this.Text = "LaporanForm";
            this.Load += new System.EventHandler(this.LaporanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soldList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DataGridView soldList;
        private System.Windows.Forms.DataVisualization.Charting.Chart soldChart;
        private System.Windows.Forms.Button generateChart;
        private System.Windows.Forms.Button filterBtn;
    }
}