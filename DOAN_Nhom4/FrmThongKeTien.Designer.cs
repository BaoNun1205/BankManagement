namespace DOAN_Nhom4
{
    partial class FrmThongKeTien
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
            this.ThongKe = new LiveCharts.WinForms.CartesianChart();
            this.btnTongTienVao = new CustomButton.VBButton();
            this.btnTongTienRa = new CustomButton.VBButton();
            this.btnToanBo = new CustomButton.VBButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKhoangthoigian = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThongKe
            // 
            this.ThongKe.Location = new System.Drawing.Point(106, 208);
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Size = new System.Drawing.Size(929, 451);
            this.ThongKe.TabIndex = 3;
            this.ThongKe.Text = "cartesianChart1";
            // 
            // btnTongTienVao
            // 
            this.btnTongTienVao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnTongTienVao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnTongTienVao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTongTienVao.BorderRadius = 0;
            this.btnTongTienVao.BorderSize = 0;
            this.btnTongTienVao.FlatAppearance.BorderSize = 0;
            this.btnTongTienVao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongTienVao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTongTienVao.ForeColor = System.Drawing.Color.White;
            this.btnTongTienVao.Location = new System.Drawing.Point(135, 47);
            this.btnTongTienVao.Name = "btnTongTienVao";
            this.btnTongTienVao.Size = new System.Drawing.Size(138, 41);
            this.btnTongTienVao.TabIndex = 6;
            this.btnTongTienVao.Text = "Tổng tiền vào";
            this.btnTongTienVao.TextColor = System.Drawing.Color.White;
            this.btnTongTienVao.UseVisualStyleBackColor = false;
            this.btnTongTienVao.Click += new System.EventHandler(this.btnTongTienVao_Click);
            // 
            // btnTongTienRa
            // 
            this.btnTongTienRa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnTongTienRa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnTongTienRa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTongTienRa.BorderRadius = 0;
            this.btnTongTienRa.BorderSize = 0;
            this.btnTongTienRa.FlatAppearance.BorderSize = 0;
            this.btnTongTienRa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTongTienRa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTongTienRa.ForeColor = System.Drawing.Color.White;
            this.btnTongTienRa.Location = new System.Drawing.Point(279, 47);
            this.btnTongTienRa.Name = "btnTongTienRa";
            this.btnTongTienRa.Size = new System.Drawing.Size(138, 41);
            this.btnTongTienRa.TabIndex = 7;
            this.btnTongTienRa.Text = "Tổng tiền ra";
            this.btnTongTienRa.TextColor = System.Drawing.Color.White;
            this.btnTongTienRa.UseVisualStyleBackColor = false;
            this.btnTongTienRa.Click += new System.EventHandler(this.btnTongTienRa_Click);
            // 
            // btnToanBo
            // 
            this.btnToanBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnToanBo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnToanBo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnToanBo.BorderRadius = 0;
            this.btnToanBo.BorderSize = 0;
            this.btnToanBo.FlatAppearance.BorderSize = 0;
            this.btnToanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToanBo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnToanBo.ForeColor = System.Drawing.Color.White;
            this.btnToanBo.Location = new System.Drawing.Point(423, 47);
            this.btnToanBo.Name = "btnToanBo";
            this.btnToanBo.Size = new System.Drawing.Size(138, 41);
            this.btnToanBo.TabIndex = 8;
            this.btnToanBo.Text = "Toàn bộ";
            this.btnToanBo.TextColor = System.Drawing.Color.White;
            this.btnToanBo.UseVisualStyleBackColor = false;
            this.btnToanBo.Click += new System.EventHandler(this.btnToanBo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 ngày gần đây nhất",
            "3 ngày gần đây nhất",
            "7 ngày gần đây nhất",
            "30 ngày gần đây nhất",
            "100 ngày gần đây nhất"});
            this.comboBox1.Location = new System.Drawing.Point(7, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 27);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Thống kê theo thời gian";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.panel1.Location = new System.Drawing.Point(790, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 41);
            this.panel1.TabIndex = 10;
            // 
            // lblKhoangthoigian
            // 
            this.lblKhoangthoigian.AutoSize = true;
            this.lblKhoangthoigian.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKhoangthoigian.Location = new System.Drawing.Point(135, 175);
            this.lblKhoangthoigian.Name = "lblKhoangthoigian";
            this.lblKhoangthoigian.Size = new System.Drawing.Size(15, 19);
            this.lblKhoangthoigian.TabIndex = 11;
            this.lblKhoangthoigian.Text = "-";
            // 
            // FrmThongKeTien
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 720);
            this.Controls.Add(this.lblKhoangthoigian);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnToanBo);
            this.Controls.Add(this.btnTongTienRa);
            this.Controls.Add(this.btnTongTienVao);
            this.Controls.Add(this.ThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongKeTien";
            this.Text = "FrmThongKeTien";
            this.Load += new System.EventHandler(this.FrmThongKeTien_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LiveCharts.WinForms.CartesianChart ThongKe;
        private CustomButton.VBButton btnTongTienVao;
        private CustomButton.VBButton btnTongTienRa;
        private CustomButton.VBButton btnToanBo;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label lblKhoangthoigian;
    }
}