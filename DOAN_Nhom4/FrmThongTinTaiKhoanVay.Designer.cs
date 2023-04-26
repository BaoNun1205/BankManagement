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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pBQuaylai = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btn_ThanhToanToanBo = new CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBQuaylai)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBQuaylai
            // 
            this.pBQuaylai.Image = global::DOAN_Nhom4.Properties.Resources.left_arrow3;
            this.pBQuaylai.Location = new System.Drawing.Point(14, 16);
            this.pBQuaylai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBQuaylai.Name = "pBQuaylai";
            this.pBQuaylai.Size = new System.Drawing.Size(45, 45);
            this.pBQuaylai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBQuaylai.TabIndex = 118;
            this.pBQuaylai.TabStop = false;
            this.pBQuaylai.Click += new System.EventHandler(this.pBQuaylai_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ThanhToanToanBo);
            this.panel1.Controls.Add(this.txt_NgayDenHan);
            this.panel1.Controls.Add(this.btn_HuyBo);
            this.panel1.Controls.Add(this.btn_ThanhToan);
            this.panel1.Controls.Add(this.txt_PhiTraCham);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_SoTienHangThang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_LaiSuat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_DuNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn_TaiKhoanVay);
            this.panel1.Location = new System.Drawing.Point(67, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 743);
            this.panel1.TabIndex = 119;
            // 
            // txt_NgayDenHan
            // 
            this.txt_NgayDenHan.CalendarFont = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NgayDenHan.CustomFormat = "MM/dd/yyyy";
            this.txt_NgayDenHan.Enabled = false;
            this.txt_NgayDenHan.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NgayDenHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_NgayDenHan.Location = new System.Drawing.Point(621, 235);
            this.txt_NgayDenHan.Name = "txt_NgayDenHan";
            this.txt_NgayDenHan.Size = new System.Drawing.Size(325, 32);
            this.txt_NgayDenHan.TabIndex = 100;
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
            this.btn_HuyBo.Location = new System.Drawing.Point(430, 608);
            this.btn_HuyBo.Name = "btn_HuyBo";
            this.btn_HuyBo.Size = new System.Drawing.Size(246, 63);
            this.btn_HuyBo.TabIndex = 99;
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
            this.btn_ThanhToan.Location = new System.Drawing.Point(699, 608);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(246, 63);
            this.btn_ThanhToan.TabIndex = 98;
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
            this.txt_PhiTraCham.Location = new System.Drawing.Point(621, 540);
            this.txt_PhiTraCham.Name = "txt_PhiTraCham";
            this.txt_PhiTraCham.ReadOnly = true;
            this.txt_PhiTraCham.Size = new System.Drawing.Size(325, 27);
            this.txt_PhiTraCham.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(343, 545);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 96;
            this.label4.Text = "Phí trả chậm";
            // 
            // txt_SoTienHangThang
            // 
            this.txt_SoTienHangThang.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SoTienHangThang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SoTienHangThang.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SoTienHangThang.Location = new System.Drawing.Point(621, 463);
            this.txt_SoTienHangThang.Name = "txt_SoTienHangThang";
            this.txt_SoTienHangThang.ReadOnly = true;
            this.txt_SoTienHangThang.Size = new System.Drawing.Size(325, 27);
            this.txt_SoTienHangThang.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(342, 469);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(197, 19);
            this.label3.TabIndex = 94;
            this.label3.Text = "Số tiền phải trả tháng này";
            // 
            // txt_LaiSuat
            // 
            this.txt_LaiSuat.BackColor = System.Drawing.SystemColors.Window;
            this.txt_LaiSuat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_LaiSuat.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_LaiSuat.Location = new System.Drawing.Point(621, 381);
            this.txt_LaiSuat.Name = "txt_LaiSuat";
            this.txt_LaiSuat.ReadOnly = true;
            this.txt_LaiSuat.Size = new System.Drawing.Size(325, 27);
            this.txt_LaiSuat.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(343, 387);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 92;
            this.label2.Text = "Lãi suất vay";
            // 
            // txt_DuNo
            // 
            this.txt_DuNo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_DuNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DuNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DuNo.Location = new System.Drawing.Point(621, 304);
            this.txt_DuNo.Name = "txt_DuNo";
            this.txt_DuNo.ReadOnly = true;
            this.txt_DuNo.Size = new System.Drawing.Size(325, 27);
            this.txt_DuNo.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(343, 311);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 90;
            this.label1.Text = "Dư nợ hiện tại";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(342, 240);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(112, 19);
            this.label11.TabIndex = 89;
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
            this.btn_TaiKhoanVay.Location = new System.Drawing.Point(223, 72);
            this.btn_TaiKhoanVay.Name = "btn_TaiKhoanVay";
            this.btn_TaiKhoanVay.Size = new System.Drawing.Size(486, 125);
            this.btn_TaiKhoanVay.TabIndex = 88;
            this.btn_TaiKhoanVay.Text = "Tài Khoản Vay";
            this.btn_TaiKhoanVay.TextColor = System.Drawing.Color.White;
            this.btn_TaiKhoanVay.UseVisualStyleBackColor = false;
            // 
            // btn_ThanhToanToanBo
            // 
            this.btn_ThanhToanToanBo.BackColor = System.Drawing.Color.White;
            this.btn_ThanhToanToanBo.BackgroundColor = System.Drawing.Color.White;
            this.btn_ThanhToanToanBo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_ThanhToanToanBo.BorderRadius = 0;
            this.btn_ThanhToanToanBo.BorderSize = 5;
            this.btn_ThanhToanToanBo.FlatAppearance.BorderSize = 0;
            this.btn_ThanhToanToanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThanhToanToanBo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ThanhToanToanBo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_ThanhToanToanBo.Location = new System.Drawing.Point(867, 104);
            this.btn_ThanhToanToanBo.Name = "btn_ThanhToanToanBo";
            this.btn_ThanhToanToanBo.Size = new System.Drawing.Size(246, 63);
            this.btn_ThanhToanToanBo.TabIndex = 120;
            this.btn_ThanhToanToanBo.Text = "Thanh Toán Toàn Bộ";
            this.btn_ThanhToanToanBo.TextColor = System.Drawing.SystemColors.Highlight;
            this.btn_ThanhToanToanBo.UseVisualStyleBackColor = false;
            this.btn_ThanhToanToanBo.Click += new System.EventHandler(this.btn_ThanhToanToanBo_Click);
            // 
            // FrmThongTinTaiKhoanVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1302, 960);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBQuaylai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongTinTaiKhoanVay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongTinTaiKhoanVay";
            this.Load += new System.EventHandler(this.FrmThongTinTaiKhoanVay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBQuaylai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PageSetupDialog pageSetupDialog1;
        private PictureBox pBQuaylai;
        private Panel panel1;
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
        private CustomButton.VBButton btn_ThanhToanToanBo;
    }
}