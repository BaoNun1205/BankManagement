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
            this.btnThanhToanToanBo = new CustomButton.VBButton();
            this.txtNgayDenHan = new System.Windows.Forms.DateTimePicker();
            this.btnHuyBo = new CustomButton.VBButton();
            this.btnThanhToan = new CustomButton.VBButton();
            this.txtPhiTraCham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTienHangThang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLaiSuat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_TaiKhoanVay = new CustomButton.VBButton();
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
            this.panel1.Controls.Add(this.btnThanhToanToanBo);
            this.panel1.Controls.Add(this.txtNgayDenHan);
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.txtPhiTraCham);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSoTienHangThang);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLaiSuat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDuNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn_TaiKhoanVay);
            this.panel1.Location = new System.Drawing.Point(67, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 743);
            this.panel1.TabIndex = 119;
            // 
            // btnThanhToanToanBo
            // 
            this.btnThanhToanToanBo.BackColor = System.Drawing.Color.White;
            this.btnThanhToanToanBo.BackgroundColor = System.Drawing.Color.White;
            this.btnThanhToanToanBo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThanhToanToanBo.BorderRadius = 0;
            this.btnThanhToanToanBo.BorderSize = 5;
            this.btnThanhToanToanBo.FlatAppearance.BorderSize = 0;
            this.btnThanhToanToanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToanToanBo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToanToanBo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThanhToanToanBo.Location = new System.Drawing.Point(867, 104);
            this.btnThanhToanToanBo.Name = "btnThanhToanToanBo";
            this.btnThanhToanToanBo.Size = new System.Drawing.Size(246, 63);
            this.btnThanhToanToanBo.TabIndex = 120;
            this.btnThanhToanToanBo.Text = "Thanh Toán Toàn Bộ";
            this.btnThanhToanToanBo.TextColor = System.Drawing.SystemColors.Highlight;
            this.btnThanhToanToanBo.UseVisualStyleBackColor = false;
            this.btnThanhToanToanBo.Click += new System.EventHandler(this.btn_ThanhToanToanBo_Click);
            // 
            // txtNgayDenHan
            // 
            this.txtNgayDenHan.CalendarFont = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNgayDenHan.CustomFormat = "MM/dd/yyyy";
            this.txtNgayDenHan.Enabled = false;
            this.txtNgayDenHan.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNgayDenHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayDenHan.Location = new System.Drawing.Point(621, 235);
            this.txtNgayDenHan.Name = "txtNgayDenHan";
            this.txtNgayDenHan.Size = new System.Drawing.Size(325, 32);
            this.txtNgayDenHan.TabIndex = 100;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHuyBo.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.btnHuyBo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuyBo.BorderRadius = 20;
            this.btnHuyBo.BorderSize = 0;
            this.btnHuyBo.FlatAppearance.BorderSize = 0;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuyBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnHuyBo.Location = new System.Drawing.Point(430, 608);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(246, 63);
            this.btnHuyBo.TabIndex = 99;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btn_HuyBo_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnThanhToan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThanhToan.BorderRadius = 20;
            this.btnThanhToan.BorderSize = 0;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToan.ForeColor = System.Drawing.SystemColors.Window;
            this.btnThanhToan.Location = new System.Drawing.Point(699, 608);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(246, 63);
            this.btnThanhToan.TabIndex = 98;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextColor = System.Drawing.SystemColors.Window;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // txtPhiTraCham
            // 
            this.txtPhiTraCham.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhiTraCham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhiTraCham.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhiTraCham.Location = new System.Drawing.Point(621, 540);
            this.txtPhiTraCham.Name = "txtPhiTraCham";
            this.txtPhiTraCham.ReadOnly = true;
            this.txtPhiTraCham.Size = new System.Drawing.Size(325, 27);
            this.txtPhiTraCham.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(343, 545);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 96;
            this.label4.Text = "Phí trả chậm";
            // 
            // txtSoTienHangThang
            // 
            this.txtSoTienHangThang.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoTienHangThang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTienHangThang.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoTienHangThang.Location = new System.Drawing.Point(621, 463);
            this.txtSoTienHangThang.Name = "txtSoTienHangThang";
            this.txtSoTienHangThang.ReadOnly = true;
            this.txtSoTienHangThang.Size = new System.Drawing.Size(325, 27);
            this.txtSoTienHangThang.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(342, 469);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(256, 24);
            this.label3.TabIndex = 94;
            this.label3.Text = "Số tiền phải trả tháng này";
            // 
            // txtLaiSuat
            // 
            this.txtLaiSuat.BackColor = System.Drawing.SystemColors.Window;
            this.txtLaiSuat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLaiSuat.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLaiSuat.Location = new System.Drawing.Point(621, 381);
            this.txtLaiSuat.Name = "txtLaiSuat";
            this.txtLaiSuat.ReadOnly = true;
            this.txtLaiSuat.Size = new System.Drawing.Size(325, 27);
            this.txtLaiSuat.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(343, 387);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 92;
            this.label2.Text = "Lãi suất vay";
            // 
            // txtDuNo
            // 
            this.txtDuNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuNo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDuNo.Location = new System.Drawing.Point(621, 304);
            this.txtDuNo.Name = "txtDuNo";
            this.txtDuNo.ReadOnly = true;
            this.txtDuNo.Size = new System.Drawing.Size(325, 27);
            this.txtDuNo.TabIndex = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(343, 311);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 90;
            this.label1.Text = "Dư nợ hiện tại";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(342, 240);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(140, 24);
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
        private DateTimePicker txtNgayDenHan;
        private CustomButton.VBButton btnHuyBo;
        private CustomButton.VBButton btnThanhToan;
        private TextBox txtPhiTraCham;
        private Label label4;
        private TextBox txtSoTienHangThang;
        private Label label3;
        private TextBox txtLaiSuat;
        private Label label2;
        private TextBox txtDuNo;
        private Label label1;
        private Label label11;
        private CustomButton.VBButton btn_TaiKhoanVay;
        private CustomButton.VBButton btnThanhToanToanBo;
    }
}