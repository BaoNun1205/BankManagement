namespace DOAN_Nhom4
{
    partial class FrmThongKeAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gvQLGD = new System.Windows.Forms.DataGridView();
            this.ThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChuyenTien = new System.Windows.Forms.Button();
            this.btnTinDung = new System.Windows.Forms.Button();
            this.btnTietKiem = new System.Windows.Forms.Button();
            this.btnVienThong = new System.Windows.Forms.Button();
            this.btnVay = new System.Windows.Forms.Button();
            this.lblSoLuongTaiKhoan = new System.Windows.Forms.Label();
            this.lblHienThiSoLuongTaiKhoang = new System.Windows.Forms.Label();
            this.lblTinDung = new System.Windows.Forms.Label();
            this.lblHienThiTinDung = new System.Windows.Forms.Label();
            this.lblTietKiem = new System.Windows.Forms.Label();
            this.lblHienThiTietKiem = new System.Windows.Forms.Label();
            this.lblVay = new System.Windows.Forms.Label();
            this.lblHienThiVay = new System.Windows.Forms.Label();
            this.lblNoXau = new System.Windows.Forms.Label();
            this.lblHienThiNoXau = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_QuayLai = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKe)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuayLai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.pb_QuayLai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1645, 107);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(731, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ";
            // 
            // gvQLGD
            // 
            this.gvQLGD.AllowUserToAddRows = false;
            this.gvQLGD.AllowUserToResizeRows = false;
            this.gvQLGD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvQLGD.BackgroundColor = System.Drawing.Color.White;
            this.gvQLGD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvQLGD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvQLGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvQLGD.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvQLGD.EnableHeadersVisualStyles = false;
            this.gvQLGD.GridColor = System.Drawing.Color.LightSlateGray;
            this.gvQLGD.Location = new System.Drawing.Point(30, 473);
            this.gvQLGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvQLGD.Name = "gvQLGD";
            this.gvQLGD.RowHeadersVisible = false;
            this.gvQLGD.RowHeadersWidth = 51;
            this.gvQLGD.RowTemplate.Height = 40;
            this.gvQLGD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvQLGD.Size = new System.Drawing.Size(1585, 337);
            this.gvQLGD.TabIndex = 22;
            // 
            // ThongKe
            // 
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.Size = 3F;
            chartArea1.AxisX.Title = "Ngày";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorTickMark.LineWidth = 0;
            chartArea1.AxisY.Title = "VNĐ";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chartArea1.Name = "ChartArea1";
            this.ThongKe.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend2";
            legend3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend3";
            legend4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend4";
            legend5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend5";
            this.ThongKe.Legends.Add(legend1);
            this.ThongKe.Legends.Add(legend2);
            this.ThongKe.Legends.Add(legend3);
            this.ThongKe.Legends.Add(legend4);
            this.ThongKe.Legends.Add(legend5);
            this.ThongKe.Location = new System.Drawing.Point(502, 111);
            this.ThongKe.Name = "ThongKe";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            series1.Legend = "Legend1";
            series1.Name = "ChuyenTien";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            series2.Legend = "Legend2";
            series2.Name = "VienThong";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            series3.Legend = "Legend3";
            series3.Name = "TinDung";
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series4.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            series4.Legend = "Legend4";
            series4.Name = "TietKiem";
            series5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series5.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            series5.Legend = "Legend5";
            series5.Name = "Vay";
            this.ThongKe.Series.Add(series1);
            this.ThongKe.Series.Add(series2);
            this.ThongKe.Series.Add(series3);
            this.ThongKe.Series.Add(series4);
            this.ThongKe.Series.Add(series5);
            this.ThongKe.Size = new System.Drawing.Size(947, 357);
            this.ThongKe.TabIndex = 23;
            this.ThongKe.Text = "chart1";
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btnChuyenTien.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChuyenTien.ForeColor = System.Drawing.Color.White;
            this.btnChuyenTien.Location = new System.Drawing.Point(1455, 130);
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.Size = new System.Drawing.Size(160, 60);
            this.btnChuyenTien.TabIndex = 3;
            this.btnChuyenTien.Text = "Chuyển Tiền";
            this.btnChuyenTien.UseVisualStyleBackColor = false;
            this.btnChuyenTien.Click += new System.EventHandler(this.btnChuyenTien_Click);
            // 
            // btnTinDung
            // 
            this.btnTinDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btnTinDung.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTinDung.ForeColor = System.Drawing.Color.White;
            this.btnTinDung.Location = new System.Drawing.Point(1455, 262);
            this.btnTinDung.Name = "btnTinDung";
            this.btnTinDung.Size = new System.Drawing.Size(160, 60);
            this.btnTinDung.TabIndex = 4;
            this.btnTinDung.Text = "Tín Dụng";
            this.btnTinDung.UseVisualStyleBackColor = false;
            this.btnTinDung.Click += new System.EventHandler(this.btnTinDung_Click);
            // 
            // btnTietKiem
            // 
            this.btnTietKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btnTietKiem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTietKiem.ForeColor = System.Drawing.Color.White;
            this.btnTietKiem.Location = new System.Drawing.Point(1455, 196);
            this.btnTietKiem.Name = "btnTietKiem";
            this.btnTietKiem.Size = new System.Drawing.Size(160, 60);
            this.btnTietKiem.TabIndex = 24;
            this.btnTietKiem.Text = "Tiết Kiệm";
            this.btnTietKiem.UseVisualStyleBackColor = false;
            this.btnTietKiem.Click += new System.EventHandler(this.btnTietKiem_Click);
            // 
            // btnVienThong
            // 
            this.btnVienThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btnVienThong.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVienThong.ForeColor = System.Drawing.Color.White;
            this.btnVienThong.Location = new System.Drawing.Point(1455, 328);
            this.btnVienThong.Name = "btnVienThong";
            this.btnVienThong.Size = new System.Drawing.Size(160, 60);
            this.btnVienThong.TabIndex = 25;
            this.btnVienThong.Text = "Viễn Thông";
            this.btnVienThong.UseVisualStyleBackColor = false;
            this.btnVienThong.Click += new System.EventHandler(this.btnVienThong_Click);
            // 
            // btnVay
            // 
            this.btnVay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.btnVay.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVay.ForeColor = System.Drawing.Color.White;
            this.btnVay.Location = new System.Drawing.Point(1455, 394);
            this.btnVay.Name = "btnVay";
            this.btnVay.Size = new System.Drawing.Size(160, 60);
            this.btnVay.TabIndex = 26;
            this.btnVay.Text = "Vay";
            this.btnVay.UseVisualStyleBackColor = false;
            this.btnVay.Click += new System.EventHandler(this.btnVay_Click);
            // 
            // lblSoLuongTaiKhoan
            // 
            this.lblSoLuongTaiKhoan.AutoSize = true;
            this.lblSoLuongTaiKhoan.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoLuongTaiKhoan.Location = new System.Drawing.Point(21, 33);
            this.lblSoLuongTaiKhoan.Name = "lblSoLuongTaiKhoan";
            this.lblSoLuongTaiKhoan.Size = new System.Drawing.Size(282, 25);
            this.lblSoLuongTaiKhoan.TabIndex = 27;
            this.lblSoLuongTaiKhoan.Text = "Số Tài Khoản đang tồn tại";
            // 
            // lblHienThiSoLuongTaiKhoang
            // 
            this.lblHienThiSoLuongTaiKhoang.AutoSize = true;
            this.lblHienThiSoLuongTaiKhoang.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHienThiSoLuongTaiKhoang.Location = new System.Drawing.Point(354, 33);
            this.lblHienThiSoLuongTaiKhoang.Name = "lblHienThiSoLuongTaiKhoang";
            this.lblHienThiSoLuongTaiKhoang.Size = new System.Drawing.Size(21, 25);
            this.lblHienThiSoLuongTaiKhoang.TabIndex = 28;
            this.lblHienThiSoLuongTaiKhoang.Text = "-";
            // 
            // lblTinDung
            // 
            this.lblTinDung.AutoSize = true;
            this.lblTinDung.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTinDung.Location = new System.Drawing.Point(21, 92);
            this.lblTinDung.Name = "lblTinDung";
            this.lblTinDung.Size = new System.Drawing.Size(236, 25);
            this.lblTinDung.TabIndex = 29;
            this.lblTinDung.Text = "Số lượng thẻ tín dụng";
            // 
            // lblHienThiTinDung
            // 
            this.lblHienThiTinDung.AutoSize = true;
            this.lblHienThiTinDung.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHienThiTinDung.Location = new System.Drawing.Point(354, 92);
            this.lblHienThiTinDung.Name = "lblHienThiTinDung";
            this.lblHienThiTinDung.Size = new System.Drawing.Size(21, 25);
            this.lblHienThiTinDung.TabIndex = 30;
            this.lblHienThiTinDung.Text = "-";
            // 
            // lblTietKiem
            // 
            this.lblTietKiem.AutoSize = true;
            this.lblTietKiem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTietKiem.Location = new System.Drawing.Point(21, 149);
            this.lblTietKiem.Name = "lblTietKiem";
            this.lblTietKiem.Size = new System.Drawing.Size(233, 25);
            this.lblTietKiem.TabIndex = 31;
            this.lblTietKiem.Text = "Số lượng sổ tiết kiệm";
            // 
            // lblHienThiTietKiem
            // 
            this.lblHienThiTietKiem.AutoSize = true;
            this.lblHienThiTietKiem.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHienThiTietKiem.Location = new System.Drawing.Point(354, 149);
            this.lblHienThiTietKiem.Name = "lblHienThiTietKiem";
            this.lblHienThiTietKiem.Size = new System.Drawing.Size(21, 25);
            this.lblHienThiTietKiem.TabIndex = 32;
            this.lblHienThiTietKiem.Text = "-";
            // 
            // lblVay
            // 
            this.lblVay.AutoSize = true;
            this.lblVay.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVay.Location = new System.Drawing.Point(21, 206);
            this.lblVay.Name = "lblVay";
            this.lblVay.Size = new System.Drawing.Size(250, 25);
            this.lblVay.TabIndex = 33;
            this.lblVay.Text = "Số lượng hợp đồng vay";
            // 
            // lblHienThiVay
            // 
            this.lblHienThiVay.AutoSize = true;
            this.lblHienThiVay.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHienThiVay.Location = new System.Drawing.Point(354, 206);
            this.lblHienThiVay.Name = "lblHienThiVay";
            this.lblHienThiVay.Size = new System.Drawing.Size(21, 25);
            this.lblHienThiVay.TabIndex = 34;
            this.lblHienThiVay.Text = "-";
            // 
            // lblNoXau
            // 
            this.lblNoXau.AutoSize = true;
            this.lblNoXau.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNoXau.Location = new System.Drawing.Point(21, 263);
            this.lblNoXau.Name = "lblNoXau";
            this.lblNoXau.Size = new System.Drawing.Size(181, 25);
            this.lblNoXau.TabIndex = 35;
            this.lblNoXau.Text = "Số lượng nợ xấu";
            // 
            // lblHienThiNoXau
            // 
            this.lblHienThiNoXau.AutoSize = true;
            this.lblHienThiNoXau.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHienThiNoXau.Location = new System.Drawing.Point(354, 263);
            this.lblHienThiNoXau.Name = "lblHienThiNoXau";
            this.lblHienThiNoXau.Size = new System.Drawing.Size(21, 25);
            this.lblHienThiNoXau.TabIndex = 36;
            this.lblHienThiNoXau.Text = "-";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSoLuongTaiKhoan);
            this.panel2.Controls.Add(this.lblHienThiNoXau);
            this.panel2.Controls.Add(this.lblHienThiSoLuongTaiKhoang);
            this.panel2.Controls.Add(this.lblNoXau);
            this.panel2.Controls.Add(this.lblTinDung);
            this.panel2.Controls.Add(this.lblHienThiVay);
            this.panel2.Controls.Add(this.lblHienThiTinDung);
            this.panel2.Controls.Add(this.lblVay);
            this.panel2.Controls.Add(this.lblTietKiem);
            this.panel2.Controls.Add(this.lblHienThiTietKiem);
            this.panel2.Location = new System.Drawing.Point(30, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 324);
            this.panel2.TabIndex = 37;
            // 
            // pb_QuayLai
            // 
            this.pb_QuayLai.Image = global::DOAN_Nhom4.Properties.Resources.left_arrow4;
            this.pb_QuayLai.Location = new System.Drawing.Point(3, 2);
            this.pb_QuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_QuayLai.Name = "pb_QuayLai";
            this.pb_QuayLai.Size = new System.Drawing.Size(35, 34);
            this.pb_QuayLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_QuayLai.TabIndex = 26;
            this.pb_QuayLai.TabStop = false;
            this.pb_QuayLai.Click += new System.EventHandler(this.pb_QuayLai_Click);
            // 
            // FrmThongKeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1645, 834);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVay);
            this.Controls.Add(this.btnVienThong);
            this.Controls.Add(this.btnTietKiem);
            this.Controls.Add(this.btnTinDung);
            this.Controls.Add(this.btnChuyenTien);
            this.Controls.Add(this.ThongKe);
            this.Controls.Add(this.gvQLGD);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmThongKeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.FrmThongKeAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuayLai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView gvQLGD;
        private System.Windows.Forms.DataVisualization.Charting.Chart ThongKe;
        private Button btnChuyenTien;
        private Button btnTinDung;
        private Button btnTietKiem;
        private Button btnVienThong;
        private Button btnVay;
        private Label lblSoLuongTaiKhoan;
        private Label lblHienThiSoLuongTaiKhoang;
        private Label lblTinDung;
        private Label lblHienThiTinDung;
        private Label lblTietKiem;
        private Label lblHienThiTietKiem;
        private Label lblVay;
        private Label lblHienThiVay;
        private Label lblNoXau;
        private Label lblHienThiNoXau;
        private Panel panel2;
        private PictureBox pb_QuayLai;
    }
}