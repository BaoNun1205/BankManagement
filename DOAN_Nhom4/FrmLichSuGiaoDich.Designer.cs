namespace DOAN_Nhom4
{
    partial class FrmLichSuGiaoDich
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GvTongGui = new System.Windows.Forms.DataGridView();
            this.GvTongNhan = new System.Windows.Forms.DataGridView();
            this.GvLSGD = new System.Windows.Forms.DataGridView();
            this.btn_TienRa = new CustomButton.VBButton();
            this.btn_TienVao = new CustomButton.VBButton();
            this.btn_ToanBo = new CustomButton.VBButton();
            this.vbButton3 = new CustomButton.VBButton();
            this.btn_XuatExcel = new CustomButton.VBButton();
            this.cmNgay = new System.Windows.Forms.ComboBox();
            this.vbButton1 = new CustomButton.VBButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvTongGui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvTongNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvLSGD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GvTongGui);
            this.panel1.Controls.Add(this.GvTongNhan);
            this.panel1.Controls.Add(this.GvLSGD);
            this.panel1.Controls.Add(this.btn_TienRa);
            this.panel1.Controls.Add(this.btn_TienVao);
            this.panel1.Controls.Add(this.btn_ToanBo);
            this.panel1.Controls.Add(this.vbButton3);
            this.panel1.Controls.Add(this.btn_XuatExcel);
            this.panel1.Controls.Add(this.cmNgay);
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 634);
            this.panel1.TabIndex = 1;
            // 
            // GvTongGui
            // 
            this.GvTongGui.BackgroundColor = System.Drawing.Color.White;
            this.GvTongGui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvTongGui.Location = new System.Drawing.Point(189, 441);
            this.GvTongGui.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GvTongGui.Name = "GvTongGui";
            this.GvTongGui.RowHeadersWidth = 82;
            this.GvTongGui.RowTemplate.Height = 41;
            this.GvTongGui.Size = new System.Drawing.Size(711, 191);
            this.GvTongGui.TabIndex = 59;
            // 
            // GvTongNhan
            // 
            this.GvTongNhan.BackgroundColor = System.Drawing.Color.White;
            this.GvTongNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvTongNhan.Location = new System.Drawing.Point(189, 260);
            this.GvTongNhan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GvTongNhan.Name = "GvTongNhan";
            this.GvTongNhan.RowHeadersWidth = 82;
            this.GvTongNhan.RowTemplate.Height = 41;
            this.GvTongNhan.Size = new System.Drawing.Size(711, 179);
            this.GvTongNhan.TabIndex = 58;
            // 
            // GvLSGD
            // 
            this.GvLSGD.BackgroundColor = System.Drawing.Color.White;
            this.GvLSGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvLSGD.Location = new System.Drawing.Point(189, 260);
            this.GvLSGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GvLSGD.Name = "GvLSGD";
            this.GvLSGD.RowHeadersWidth = 51;
            this.GvLSGD.RowTemplate.Height = 29;
            this.GvLSGD.Size = new System.Drawing.Size(711, 372);
            this.GvLSGD.TabIndex = 39;
            // 
            // btn_TienRa
            // 
            this.btn_TienRa.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_TienRa.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btn_TienRa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TienRa.BorderRadius = 0;
            this.btn_TienRa.BorderSize = 0;
            this.btn_TienRa.FlatAppearance.BorderSize = 0;
            this.btn_TienRa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TienRa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TienRa.ForeColor = System.Drawing.Color.White;
            this.btn_TienRa.Location = new System.Drawing.Point(426, 202);
            this.btn_TienRa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TienRa.Name = "btn_TienRa";
            this.btn_TienRa.Size = new System.Drawing.Size(237, 36);
            this.btn_TienRa.TabIndex = 35;
            this.btn_TienRa.Text = "Tiền ra";
            this.btn_TienRa.TextColor = System.Drawing.Color.White;
            this.btn_TienRa.UseVisualStyleBackColor = false;
            this.btn_TienRa.Click += new System.EventHandler(this.btn_TienRa_Click);
            // 
            // btn_TienVao
            // 
            this.btn_TienVao.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_TienVao.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btn_TienVao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TienVao.BorderRadius = 0;
            this.btn_TienVao.BorderSize = 0;
            this.btn_TienVao.FlatAppearance.BorderSize = 0;
            this.btn_TienVao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TienVao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TienVao.ForeColor = System.Drawing.Color.White;
            this.btn_TienVao.Location = new System.Drawing.Point(663, 202);
            this.btn_TienVao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TienVao.Name = "btn_TienVao";
            this.btn_TienVao.Size = new System.Drawing.Size(237, 36);
            this.btn_TienVao.TabIndex = 34;
            this.btn_TienVao.Text = "Tiền vào";
            this.btn_TienVao.TextColor = System.Drawing.Color.White;
            this.btn_TienVao.UseVisualStyleBackColor = false;
            this.btn_TienVao.Click += new System.EventHandler(this.btn_TienVao_Click);
            // 
            // btn_ToanBo
            // 
            this.btn_ToanBo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_ToanBo.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btn_ToanBo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ToanBo.BorderRadius = 0;
            this.btn_ToanBo.BorderSize = 0;
            this.btn_ToanBo.FlatAppearance.BorderSize = 0;
            this.btn_ToanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ToanBo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ToanBo.ForeColor = System.Drawing.Color.White;
            this.btn_ToanBo.Location = new System.Drawing.Point(189, 202);
            this.btn_ToanBo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ToanBo.Name = "btn_ToanBo";
            this.btn_ToanBo.Size = new System.Drawing.Size(237, 36);
            this.btn_ToanBo.TabIndex = 33;
            this.btn_ToanBo.Text = "Toàn bộ";
            this.btn_ToanBo.TextColor = System.Drawing.Color.White;
            this.btn_ToanBo.UseVisualStyleBackColor = false;
            this.btn_ToanBo.Click += new System.EventHandler(this.btn_ToanBo_Click);
            // 
            // vbButton3
            // 
            this.vbButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.vbButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.vbButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton3.BorderRadius = 20;
            this.vbButton3.BorderSize = 0;
            this.vbButton3.FlatAppearance.BorderSize = 0;
            this.vbButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vbButton3.ForeColor = System.Drawing.Color.White;
            this.vbButton3.Location = new System.Drawing.Point(596, 144);
            this.vbButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbButton3.Name = "vbButton3";
            this.vbButton3.Size = new System.Drawing.Size(304, 38);
            this.vbButton3.TabIndex = 32;
            this.vbButton3.Text = "Tìm kiếm ";
            this.vbButton3.TextColor = System.Drawing.Color.White;
            this.vbButton3.UseVisualStyleBackColor = false;
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_XuatExcel.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btn_XuatExcel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_XuatExcel.BorderRadius = 20;
            this.btn_XuatExcel.BorderSize = 0;
            this.btn_XuatExcel.FlatAppearance.BorderSize = 0;
            this.btn_XuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XuatExcel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XuatExcel.ForeColor = System.Drawing.Color.White;
            this.btn_XuatExcel.Location = new System.Drawing.Point(189, 144);
            this.btn_XuatExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(303, 38);
            this.btn_XuatExcel.TabIndex = 31;
            this.btn_XuatExcel.Text = "Xuất excel";
            this.btn_XuatExcel.TextColor = System.Drawing.Color.White;
            this.btn_XuatExcel.UseVisualStyleBackColor = false;
            this.btn_XuatExcel.Click += new System.EventHandler(this.vbButton2_Click);
            // 
            // cmNgay
            // 
            this.cmNgay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmNgay.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.cmNgay.FormattingEnabled = true;
            this.cmNgay.Items.AddRange(new object[] {
            "1 ngày gần đây nhất",
            "3 ngày gần đây nhất",
            "7 ngày gần đây nhất",
            "30 ngày gần đây nhất",
            "100 ngày gần đây nhất"});
            this.cmNgay.Location = new System.Drawing.Point(426, 84);
            this.cmNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmNgay.Name = "cmNgay";
            this.cmNgay.Size = new System.Drawing.Size(429, 36);
            this.cmNgay.TabIndex = 30;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.CadetBlue;
            this.vbButton1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.vbButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 20;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vbButton1.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vbButton1.ForeColor = System.Drawing.Color.Black;
            this.vbButton1.Location = new System.Drawing.Point(189, 71);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(711, 59);
            this.vbButton1.TabIndex = 29;
            this.vbButton1.Text = "            Thời gian";
            this.vbButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vbButton1.TextColor = System.Drawing.Color.Black;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(192, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Lịch sử giao dịch tài khoản";
            // 
            // FrmLichSuGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLichSuGiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lịch sử giao dịch";
            this.Load += new System.EventHandler(this.FrmLichSuGiaoDich_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvTongGui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvTongNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvLSGD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView GvLSGD;
        private CustomButton.VBButton btn_TienRa;
        private CustomButton.VBButton btn_TienVao;
        private CustomButton.VBButton btn_ToanBo;
        private CustomButton.VBButton vbButton3;
        private CustomButton.VBButton btn_XuatExcel;
        private ComboBox cmNgay;
        private CustomButton.VBButton vbButton1;
        private Label label1;
        private DataGridView GvTongGui;
        private DataGridView GvTongNhan;
    }
}