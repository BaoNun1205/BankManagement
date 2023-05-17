using System.Windows.Forms.DataVisualization.Charting;

namespace DOAN_Nhom4
{
    partial class FrmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblHienThiNgay = new System.Windows.Forms.Label();
            this.btnTienVao = new System.Windows.Forms.Button();
            this.btnTienRa = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // ThongKe
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.Size = 3F;
            chartArea1.AxisX.Title = "Ngày";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorTickMark.LineWidth = 0;
            chartArea1.AxisY.Title = "VNĐ";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chartArea1.Name = "ChartArea1";
            this.ThongKe.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend2.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend2";
            legend3.Font = new System.Drawing.Font("Myriad Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend3";
            this.ThongKe.Legends.Add(legend1);
            this.ThongKe.Legends.Add(legend2);
            this.ThongKe.Legends.Add(legend3);
            this.ThongKe.Location = new System.Drawing.Point(12, 196);
            this.ThongKe.Name = "ThongKe";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            series1.Legend = "Legend1";
            series1.Name = "TienNhan";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            series2.Legend = "Legend2";
            series2.Name = "TienGui";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            series3.Legend = "Legend3";
            series3.Name = "TienTong";
            this.ThongKe.Series.Add(series1);
            this.ThongKe.Series.Add(series2);
            this.ThongKe.Series.Add(series3);
            this.ThongKe.Size = new System.Drawing.Size(1103, 512);
            this.ThongKe.TabIndex = 0;
            this.ThongKe.Text = "chart1";
            title1.Font = new System.Drawing.Font("Myriad Pro", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            title1.Name = "title";
            title1.Text = "THỐNG KÊ";
            this.ThongKe.Titles.Add(title1);
            // 
            // lblHienThiNgay
            // 
            this.lblHienThiNgay.AutoSize = true;
            this.lblHienThiNgay.Font = new System.Drawing.Font("Myriad Pro SemiExt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHienThiNgay.ForeColor = System.Drawing.Color.Black;
            this.lblHienThiNgay.Location = new System.Drawing.Point(109, 168);
            this.lblHienThiNgay.Name = "lblHienThiNgay";
            this.lblHienThiNgay.Size = new System.Drawing.Size(19, 25);
            this.lblHienThiNgay.TabIndex = 1;
            this.lblHienThiNgay.Text = "-";
            // 
            // btnTienVao
            // 
            this.btnTienVao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            this.btnTienVao.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTienVao.ForeColor = System.Drawing.Color.White;
            this.btnTienVao.Location = new System.Drawing.Point(600, 91);
            this.btnTienVao.Name = "btnTienVao";
            this.btnTienVao.Size = new System.Drawing.Size(137, 47);
            this.btnTienVao.TabIndex = 2;
            this.btnTienVao.Text = "Tiền Vào";
            this.btnTienVao.UseVisualStyleBackColor = false;
            this.btnTienVao.Click += new System.EventHandler(this.btnTienVao_Click);
            // 
            // btnTienRa
            // 
            this.btnTienRa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            this.btnTienRa.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTienRa.ForeColor = System.Drawing.Color.White;
            this.btnTienRa.Location = new System.Drawing.Point(780, 91);
            this.btnTienRa.Name = "btnTienRa";
            this.btnTienRa.Size = new System.Drawing.Size(137, 47);
            this.btnTienRa.TabIndex = 3;
            this.btnTienRa.Text = "Tiền Ra";
            this.btnTienRa.UseVisualStyleBackColor = false;
            this.btnTienRa.Click += new System.EventHandler(this.btnTienRa_Click);
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            this.btnTong.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTong.ForeColor = System.Drawing.Color.White;
            this.btnTong.Location = new System.Drawing.Point(960, 91);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(137, 47);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 720);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnTienRa);
            this.Controls.Add(this.btnTienVao);
            this.Controls.Add(this.lblHienThiNgay);
            this.Controls.Add(this.ThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chart ThongKe;
        private Label lblHienThiNgay;
        private Button btnTienVao;
        private Button btnTienRa;
        private Button btnTong;
    }
}