namespace DOAN_Nhom4
{
    partial class FrmXacNhanGiaoDichVayToanBo
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
            this.btn_HuyBo = new CustomButton.VBButton();
            this.btn_XacNhan = new CustomButton.VBButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHienThiTong = new System.Windows.Forms.Label();
            this.lblHienThiTraCham = new System.Windows.Forms.Label();
            this.lblHienThiTKVay = new System.Windows.Forms.Label();
            this.lblHienThiTKNguon = new System.Windows.Forms.Label();
            this.txt_NgayGiaoDich = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHienThiNoGoc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_HuyBo.Location = new System.Drawing.Point(363, 663);
            this.btn_HuyBo.Name = "btn_HuyBo";
            this.btn_HuyBo.Size = new System.Drawing.Size(246, 63);
            this.btn_HuyBo.TabIndex = 105;
            this.btn_HuyBo.Text = "Hủy Bỏ";
            this.btn_HuyBo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_HuyBo.UseVisualStyleBackColor = false;
            this.btn_HuyBo.Click += new System.EventHandler(this.btn_HuyBo_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_XacNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_XacNhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_XacNhan.BorderRadius = 20;
            this.btn_XacNhan.BorderSize = 0;
            this.btn_XacNhan.FlatAppearance.BorderSize = 0;
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhan.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XacNhan.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_XacNhan.Location = new System.Drawing.Point(634, 663);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(246, 63);
            this.btn_XacNhan.TabIndex = 104;
            this.btn_XacNhan.Text = "Thanh Toán";
            this.btn_XacNhan.TextColor = System.Drawing.SystemColors.Window;
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblHienThiTong);
            this.panel1.Controls.Add(this.lblHienThiTraCham);
            this.panel1.Controls.Add(this.lblHienThiNoGoc);
            this.panel1.Controls.Add(this.lblHienThiTKVay);
            this.panel1.Controls.Add(this.lblHienThiTKNguon);
            this.panel1.Controls.Add(this.txt_NgayGiaoDich);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(224, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 530);
            this.panel1.TabIndex = 103;
            // 
            // lblHienThiTong
            // 
            this.lblHienThiTong.AutoSize = true;
            this.lblHienThiTong.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHienThiTong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHienThiTong.Location = new System.Drawing.Point(367, 377);
            this.lblHienThiTong.Name = "lblHienThiTong";
            this.lblHienThiTong.Size = new System.Drawing.Size(15, 23);
            this.lblHienThiTong.TabIndex = 121;
            this.lblHienThiTong.Text = "-";
            // 
            // lblHienThiTraCham
            // 
            this.lblHienThiTraCham.AutoSize = true;
            this.lblHienThiTraCham.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHienThiTraCham.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHienThiTraCham.Location = new System.Drawing.Point(367, 286);
            this.lblHienThiTraCham.Name = "lblHienThiTraCham";
            this.lblHienThiTraCham.Size = new System.Drawing.Size(15, 23);
            this.lblHienThiTraCham.TabIndex = 120;
            this.lblHienThiTraCham.Text = "-";
            // 
            // lblHienThiTKVay
            // 
            this.lblHienThiTKVay.AutoSize = true;
            this.lblHienThiTKVay.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHienThiTKVay.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHienThiTKVay.Location = new System.Drawing.Point(367, 119);
            this.lblHienThiTKVay.Name = "lblHienThiTKVay";
            this.lblHienThiTKVay.Size = new System.Drawing.Size(15, 23);
            this.lblHienThiTKVay.TabIndex = 117;
            this.lblHienThiTKVay.Text = "-";
            // 
            // lblHienThiTKNguon
            // 
            this.lblHienThiTKNguon.AutoSize = true;
            this.lblHienThiTKNguon.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHienThiTKNguon.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHienThiTKNguon.Location = new System.Drawing.Point(368, 37);
            this.lblHienThiTKNguon.Name = "lblHienThiTKNguon";
            this.lblHienThiTKNguon.Size = new System.Drawing.Size(15, 23);
            this.lblHienThiTKNguon.TabIndex = 116;
            this.lblHienThiTKNguon.Text = "-";
            // 
            // txt_NgayGiaoDich
            // 
            this.txt_NgayGiaoDich.CalendarFont = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NgayGiaoDich.CalendarForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_NgayGiaoDich.CalendarMonthBackground = System.Drawing.SystemColors.Desktop;
            this.txt_NgayGiaoDich.CalendarTitleBackColor = System.Drawing.SystemColors.Desktop;
            this.txt_NgayGiaoDich.CalendarTitleForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_NgayGiaoDich.CalendarTrailingForeColor = System.Drawing.SystemColors.Desktop;
            this.txt_NgayGiaoDich.CustomFormat = "MM/dd/yyyy";
            this.txt_NgayGiaoDich.Enabled = false;
            this.txt_NgayGiaoDich.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NgayGiaoDich.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_NgayGiaoDich.Location = new System.Drawing.Point(368, 469);
            this.txt_NgayGiaoDich.Name = "txt_NgayGiaoDich";
            this.txt_NgayGiaoDich.Size = new System.Drawing.Size(325, 32);
            this.txt_NgayGiaoDich.TabIndex = 114;
            this.txt_NgayGiaoDich.Value = new System.DateTime(2023, 4, 27, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(90, 123);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 113;
            this.label6.Text = "Tài khoản vay";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(91, 40);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(130, 19);
            this.label7.TabIndex = 112;
            this.label7.Text = "Tài khoản nguồn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(91, 480);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 109;
            this.label4.Text = "Ngày giao dịch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(91, 381);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 107;
            this.label3.Text = "Tổng số tiền thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(91, 290);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(157, 19);
            this.label2.TabIndex = 105;
            this.label2.Text = "Số tiền phí trả chậm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.label5.Location = new System.Drawing.Point(346, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(534, 58);
            this.label5.TabIndex = 102;
            this.label5.Text = "XÁC NHẬN GIAO DỊCH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(90, 203);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 102;
            this.label11.Text = "Số tiền đang nợ";
            // 
            // lblHienThiNoGoc
            // 
            this.lblHienThiNoGoc.AutoSize = true;
            this.lblHienThiNoGoc.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHienThiNoGoc.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblHienThiNoGoc.Location = new System.Drawing.Point(367, 199);
            this.lblHienThiNoGoc.Name = "lblHienThiNoGoc";
            this.lblHienThiNoGoc.Size = new System.Drawing.Size(15, 23);
            this.lblHienThiNoGoc.TabIndex = 118;
            this.lblHienThiNoGoc.Text = "-";
            // 
            // FrmXacNhanGiaoDichVayToanBo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1229, 764);
            this.Controls.Add(this.btn_HuyBo);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmXacNhanGiaoDichVayToanBo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmXacNhanGiaoDichVayToanBo";
            this.Load += new System.EventHandler(this.FrmXacNhanGiaoDichVayToanBo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton.VBButton btn_HuyBo;
        private CustomButton.VBButton btn_XacNhan;
        private Panel panel1;
        private Label lblHienThiTong;
        private Label lblHienThiTraCham;
        private Label lblHienThiNoGoc;
        private Label lblHienThiTKVay;
        private Label lblHienThiTKNguon;
        private DateTimePicker txt_NgayGiaoDich;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label11;
        private Label label5;
    }
}