namespace DOAN_Nhom4
{
    partial class FrmChuyentien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChuyentien));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new CustomButton.VBButton();
            this.btnTieptuc = new CustomButton.VBButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTenNH = new System.Windows.Forms.ComboBox();
            this.txtLoiNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlChuyentien = new System.Windows.Forms.Panel();
            this.lblTenTKhoan = new System.Windows.Forms.Label();
            this.lblSoDuString = new System.Windows.Forms.Label();
            this.lblSoDu = new System.Windows.Forms.Label();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.pnlChuyentien.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(12, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnHuy.BorderRadius = 0;
            this.btnHuy.BorderSize = 3;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnHuy.Location = new System.Drawing.Point(244, 544);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(156, 58);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTieptuc
            // 
            this.btnTieptuc.BackColor = System.Drawing.Color.Transparent;
            this.btnTieptuc.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTieptuc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnTieptuc.BorderRadius = 0;
            this.btnTieptuc.BorderSize = 3;
            this.btnTieptuc.FlatAppearance.BorderSize = 0;
            this.btnTieptuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTieptuc.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTieptuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnTieptuc.Location = new System.Drawing.Point(597, 544);
            this.btnTieptuc.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTieptuc.Name = "btnTieptuc";
            this.btnTieptuc.Size = new System.Drawing.Size(156, 58);
            this.btnTieptuc.TabIndex = 23;
            this.btnTieptuc.Text = "Tiếp tục";
            this.btnTieptuc.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnTieptuc.UseVisualStyleBackColor = false;
            this.btnTieptuc.Click += new System.EventHandler(this.btnTieptuc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.label2.Location = new System.Drawing.Point(48, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên ngân hàng";
            // 
            // cbTenNH
            // 
            this.cbTenNH.BackColor = System.Drawing.Color.White;
            this.cbTenNH.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTenNH.ForeColor = System.Drawing.Color.Black;
            this.cbTenNH.FormattingEnabled = true;
            this.cbTenNH.Items.AddRange(new object[] {
            "HHB",
            "ACB",
            "Agribank",
            "BIDV",
            "Đông Á Bank",
            "Eximbank",
            "HDBank",
            "MBBank",
            "OCB",
            "Sacombank",
            "SHB",
            "TPBank",
            "Vietcombank",
            "VietinBank",
            "VietCapital Bank"});
            this.cbTenNH.Location = new System.Drawing.Point(549, 33);
            this.cbTenNH.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbTenNH.Name = "cbTenNH";
            this.cbTenNH.Size = new System.Drawing.Size(354, 40);
            this.cbTenNH.TabIndex = 2;
            this.cbTenNH.TextChanged += new System.EventHandler(this.cbTenNH_TextChanged);
            // 
            // txtLoiNhan
            // 
            this.txtLoiNhan.BackColor = System.Drawing.Color.White;
            this.txtLoiNhan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLoiNhan.ForeColor = System.Drawing.Color.Black;
            this.txtLoiNhan.Location = new System.Drawing.Point(453, 358);
            this.txtLoiNhan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtLoiNhan.Multiline = true;
            this.txtLoiNhan.Name = "txtLoiNhan";
            this.txtLoiNhan.Size = new System.Drawing.Size(450, 145);
            this.txtLoiNhan.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.label3.Location = new System.Drawing.Point(48, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.label4.Location = new System.Drawing.Point(48, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lời nhắn (nếu có)";
            // 
            // txtSTK
            // 
            this.txtSTK.BackColor = System.Drawing.Color.White;
            this.txtSTK.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSTK.ForeColor = System.Drawing.Color.Black;
            this.txtSTK.Location = new System.Drawing.Point(549, 109);
            this.txtSTK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSTK.Multiline = true;
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(354, 40);
            this.txtSTK.TabIndex = 6;
            this.txtSTK.TextChanged += new System.EventHandler(this.txtSTK_TextChanged);
            // 
            // txtSoTien
            // 
            this.txtSoTien.BackColor = System.Drawing.Color.White;
            this.txtSoTien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoTien.ForeColor = System.Drawing.Color.Black;
            this.txtSoTien.Location = new System.Drawing.Point(549, 237);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSoTien.Multiline = true;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(354, 40);
            this.txtSoTien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.label5.Location = new System.Drawing.Point(48, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số tiền";
            // 
            // pnlChuyentien
            // 
            this.pnlChuyentien.BackColor = System.Drawing.Color.White;
            this.pnlChuyentien.Controls.Add(this.lblTenTKhoan);
            this.pnlChuyentien.Controls.Add(this.lblSoDuString);
            this.pnlChuyentien.Controls.Add(this.lblSoDu);
            this.pnlChuyentien.Controls.Add(this.lblTenTK);
            this.pnlChuyentien.Controls.Add(this.btnHuy);
            this.pnlChuyentien.Controls.Add(this.txtSoTien);
            this.pnlChuyentien.Controls.Add(this.txtSTK);
            this.pnlChuyentien.Controls.Add(this.btnTieptuc);
            this.pnlChuyentien.Controls.Add(this.label2);
            this.pnlChuyentien.Controls.Add(this.cbTenNH);
            this.pnlChuyentien.Controls.Add(this.txtLoiNhan);
            this.pnlChuyentien.Controls.Add(this.label3);
            this.pnlChuyentien.Controls.Add(this.label4);
            this.pnlChuyentien.Controls.Add(this.label5);
            this.pnlChuyentien.Location = new System.Drawing.Point(93, 52);
            this.pnlChuyentien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlChuyentien.Name = "pnlChuyentien";
            this.pnlChuyentien.Size = new System.Drawing.Size(961, 620);
            this.pnlChuyentien.TabIndex = 11;
            // 
            // lblTenTKhoan
            // 
            this.lblTenTKhoan.AutoSize = true;
            this.lblTenTKhoan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenTKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.lblTenTKhoan.Location = new System.Drawing.Point(549, 165);
            this.lblTenTKhoan.Name = "lblTenTKhoan";
            this.lblTenTKhoan.Size = new System.Drawing.Size(20, 25);
            this.lblTenTKhoan.TabIndex = 28;
            this.lblTenTKhoan.Text = "-";
            // 
            // lblSoDuString
            // 
            this.lblSoDuString.AutoSize = true;
            this.lblSoDuString.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoDuString.ForeColor = System.Drawing.Color.Red;
            this.lblSoDuString.Location = new System.Drawing.Point(549, 295);
            this.lblSoDuString.Name = "lblSoDuString";
            this.lblSoDuString.Size = new System.Drawing.Size(88, 32);
            this.lblSoDuString.TabIndex = 27;
            this.lblSoDuString.Text = "Số dư: ";
            // 
            // lblSoDu
            // 
            this.lblSoDu.AutoSize = true;
            this.lblSoDu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoDu.ForeColor = System.Drawing.Color.Red;
            this.lblSoDu.Location = new System.Drawing.Point(643, 295);
            this.lblSoDu.Name = "lblSoDu";
            this.lblSoDu.Size = new System.Drawing.Size(31, 32);
            this.lblSoDu.TabIndex = 26;
            this.lblSoDu.Text = " -";
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTenTK.Location = new System.Drawing.Point(244, 114);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(10, 15);
            this.lblTenTK.TabIndex = 25;
            this.lblTenTK.Text = " ";
            // 
            // FrmChuyentien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1139, 720);
            this.Controls.Add(this.pnlChuyentien);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChuyentien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển tiền";
            this.Load += new System.EventHandler(this.FrmChuyentien_Load);
            this.pnlChuyentien.ResumeLayout(false);
            this.pnlChuyentien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbTenNH;
        private TextBox txtLoiNhan;
        private Label label3;
        private Label label4;
        private TextBox txtSTK;
        private Label label5;
        private TextBox txtSoTien;
        private CustomButton.VBButton btnHuy;
        private CustomButton.VBButton btnTieptuc;
        private Panel pnlChuyentien;
        private Label lblTenTK;
        private Label lblSoDu;
        private Label lblSoDuString;
        private Label lblTenTKhoan;
    }
}