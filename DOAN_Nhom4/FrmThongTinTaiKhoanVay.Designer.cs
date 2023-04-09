namespace DOAN_Nhom4
{
    partial class FrmThongTinTaiKhoanVay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongTinTaiKhoanVay));
            this.txt_NgayDenHan = new System.Windows.Forms.DateTimePicker();
            this.btn_HuyBo = new CustomButton.VBButton();
            this.btn_ThanhToan = new CustomButton.VBButton();
            this.txt_PhiTraCham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SoTienHangThang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_LaiSuat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DuNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_TaiKhoanVay = new CustomButton.VBButton();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.SuspendLayout();
            // 
            // txt_NgayDenHan
            // 
            this.txt_NgayDenHan.CalendarFont = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NgayDenHan.CustomFormat = "MM/dd/yyyy";
            this.txt_NgayDenHan.Enabled = false;
            this.txt_NgayDenHan.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NgayDenHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_NgayDenHan.Location = new System.Drawing.Point(562, 168);
            this.txt_NgayDenHan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NgayDenHan.Name = "txt_NgayDenHan";
            this.txt_NgayDenHan.Size = new System.Drawing.Size(285, 27);
            this.txt_NgayDenHan.TabIndex = 87;
            // 
            // btn_HuyBo
            // 
            this.btn_HuyBo.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_HuyBo.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.btn_HuyBo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_HuyBo.BorderRadius = 20;
            this.btn_HuyBo.BorderSize = 0;
            this.btn_HuyBo.FlatAppearance.BorderSize = 0;
            this.btn_HuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HuyBo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HuyBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_HuyBo.Location = new System.Drawing.Point(395, 448);
            this.btn_HuyBo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_HuyBo.Name = "btn_HuyBo";
            this.btn_HuyBo.Size = new System.Drawing.Size(215, 47);
            this.btn_HuyBo.TabIndex = 86;
            this.btn_HuyBo.Text = "Hủy Bỏ";
            this.btn_HuyBo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_HuyBo.UseVisualStyleBackColor = false;
            this.btn_HuyBo.Click += new System.EventHandler(this.btn_HuyBo_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_ThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_ThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThanhToan.BorderRadius = 20;
            this.btn_ThanhToan.BorderSize = 0;
            this.btn_ThanhToan.FlatAppearance.BorderSize = 0;
            this.btn_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThanhToan.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_ThanhToan.Location = new System.Drawing.Point(631, 448);
            this.btn_ThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(215, 47);
            this.btn_ThanhToan.TabIndex = 85;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.TextColor = System.Drawing.SystemColors.Window;
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // txt_PhiTraCham
            // 
            this.txt_PhiTraCham.BackColor = System.Drawing.SystemColors.Window;
            this.txt_PhiTraCham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PhiTraCham.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_PhiTraCham.Location = new System.Drawing.Point(562, 397);
            this.txt_PhiTraCham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PhiTraCham.Name = "txt_PhiTraCham";
            this.txt_PhiTraCham.ReadOnly = true;
            this.txt_PhiTraCham.Size = new System.Drawing.Size(284, 22);
            this.txt_PhiTraCham.TabIndex = 84;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(319, 401);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 83;
            this.label4.Text = "Phí trả chậm";
            // 
            // txt_SoTienHangThang
            // 
            this.txt_SoTienHangThang.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SoTienHangThang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SoTienHangThang.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SoTienHangThang.Location = new System.Drawing.Point(562, 339);
            this.txt_SoTienHangThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SoTienHangThang.Name = "txt_SoTienHangThang";
            this.txt_SoTienHangThang.ReadOnly = true;
            this.txt_SoTienHangThang.Size = new System.Drawing.Size(284, 22);
            this.txt_SoTienHangThang.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(318, 344);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "Số tiền phải trả tháng này";
            // 
            // txt_LaiSuat
            // 
            this.txt_LaiSuat.BackColor = System.Drawing.SystemColors.Window;
            this.txt_LaiSuat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LaiSuat.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_LaiSuat.Location = new System.Drawing.Point(562, 278);
            this.txt_LaiSuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LaiSuat.Name = "txt_LaiSuat";
            this.txt_LaiSuat.ReadOnly = true;
            this.txt_LaiSuat.Size = new System.Drawing.Size(284, 22);
            this.txt_LaiSuat.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(319, 282);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Lãi suất vay";
            // 
            // txt_DuNo
            // 
            this.txt_DuNo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DuNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DuNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DuNo.Location = new System.Drawing.Point(562, 220);
            this.txt_DuNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DuNo.Name = "txt_DuNo";
            this.txt_DuNo.ReadOnly = true;
            this.txt_DuNo.Size = new System.Drawing.Size(284, 22);
            this.txt_DuNo.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(319, 225);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Dư nợ hiện tại";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(318, 172);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 76;
            this.label11.Text = "Ngày đến hạn";
            // 
            // btn_TaiKhoanVay
            // 
            this.btn_TaiKhoanVay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_TaiKhoanVay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_TaiKhoanVay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TaiKhoanVay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TaiKhoanVay.BorderRadius = 30;
            this.btn_TaiKhoanVay.BorderSize = 0;
            this.btn_TaiKhoanVay.FlatAppearance.BorderSize = 0;
            this.btn_TaiKhoanVay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TaiKhoanVay.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TaiKhoanVay.ForeColor = System.Drawing.Color.White;
            this.btn_TaiKhoanVay.Image = ((System.Drawing.Image)(resources.GetObject("btn_TaiKhoanVay.Image")));
            this.btn_TaiKhoanVay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TaiKhoanVay.Location = new System.Drawing.Point(214, 46);
            this.btn_TaiKhoanVay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TaiKhoanVay.Name = "btn_TaiKhoanVay";
            this.btn_TaiKhoanVay.Size = new System.Drawing.Size(425, 94);
            this.btn_TaiKhoanVay.TabIndex = 75;
            this.btn_TaiKhoanVay.Text = "Tài Khoản Vay";
            this.btn_TaiKhoanVay.TextColor = System.Drawing.Color.White;
            this.btn_TaiKhoanVay.UseVisualStyleBackColor = false;
            // 
            // FrmThongTinTaiKhoanVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(981, 505);
            this.Controls.Add(this.txt_NgayDenHan);
            this.Controls.Add(this.btn_HuyBo);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.txt_PhiTraCham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SoTienHangThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_LaiSuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DuNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_TaiKhoanVay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmThongTinTaiKhoanVay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongTinTaiKhoanVay";
            this.Load += new System.EventHandler(this.FrmThongTinTaiKhoanVay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker txt_NgayDenHan;
        private CustomButton.VBButton btn_HuyBo;
        private CustomButton.VBButton btn_ThanhToan;
        private TextBox txt_PhiTraCham;
        private Label label4;
        private TextBox txt_SoTienHangThang;
        private Label label3;
        private TextBox txt_LaiSuat;
        private Label label2;
        private TextBox txt_DuNo;
        private Label label1;
        private Label label11;
        private CustomButton.VBButton btn_TaiKhoanVay;
        private PageSetupDialog pageSetupDialog1;
    }
}