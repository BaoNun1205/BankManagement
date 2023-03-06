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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtLoiNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picBoxChuyentien = new System.Windows.Forms.PictureBox();
            this.pnlChuyentien = new System.Windows.Forms.Panel();
            this.lblSoDuString = new System.Windows.Forms.Label();
            this.lblSoDu = new System.Windows.Forms.Label();
            this.lblTenTK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChuyentien)).BeginInit();
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
            this.btnHuy.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.BorderRadius = 0;
            this.btnHuy.BorderSize = 3;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(55, 303);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(129, 38);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTieptuc
            // 
            this.btnTieptuc.BackColor = System.Drawing.Color.Transparent;
            this.btnTieptuc.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTieptuc.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTieptuc.BorderRadius = 0;
            this.btnTieptuc.BorderSize = 3;
            this.btnTieptuc.FlatAppearance.BorderSize = 0;
            this.btnTieptuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTieptuc.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTieptuc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTieptuc.Location = new System.Drawing.Point(253, 303);
            this.btnTieptuc.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTieptuc.Name = "btnTieptuc";
            this.btnTieptuc.Size = new System.Drawing.Size(129, 38);
            this.btnTieptuc.TabIndex = 23;
            this.btnTieptuc.Text = "Tiếp tục";
            this.btnTieptuc.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTieptuc.UseVisualStyleBackColor = false;
            this.btnTieptuc.Click += new System.EventHandler(this.btnTieptuc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(31, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên ngân hàng";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nội bộ HHB Bank",
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
            this.comboBox1.Location = new System.Drawing.Point(239, 32);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // txtLoiNhan
            // 
            this.txtLoiNhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLoiNhan.ForeColor = System.Drawing.Color.Black;
            this.txtLoiNhan.Location = new System.Drawing.Point(239, 198);
            this.txtLoiNhan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtLoiNhan.Multiline = true;
            this.txtLoiNhan.Name = "txtLoiNhan";
            this.txtLoiNhan.Size = new System.Drawing.Size(167, 71);
            this.txtLoiNhan.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(31, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lời nhắn (nếu có)";
            // 
            // txtSTK
            // 
            this.txtSTK.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSTK.ForeColor = System.Drawing.Color.Black;
            this.txtSTK.Location = new System.Drawing.Point(239, 86);
            this.txtSTK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSTK.Multiline = true;
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(167, 23);
            this.txtSTK.TabIndex = 6;
            this.txtSTK.TextChanged += new System.EventHandler(this.txtSTK_TextChanged);
            // 
            // txtSoTien
            // 
            this.txtSoTien.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSoTien.ForeColor = System.Drawing.Color.Black;
            this.txtSoTien.Location = new System.Drawing.Point(239, 142);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSoTien.Multiline = true;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(167, 23);
            this.txtSoTien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(31, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số tiền";
            // 
            // picBoxChuyentien
            // 
            this.picBoxChuyentien.Image = ((System.Drawing.Image)(resources.GetObject("picBoxChuyentien.Image")));
            this.picBoxChuyentien.Location = new System.Drawing.Point(-2, 0);
            this.picBoxChuyentien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.picBoxChuyentien.Name = "picBoxChuyentien";
            this.picBoxChuyentien.Size = new System.Drawing.Size(556, 469);
            this.picBoxChuyentien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxChuyentien.TabIndex = 10;
            this.picBoxChuyentien.TabStop = false;
            // 
            // pnlChuyentien
            // 
            this.pnlChuyentien.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlChuyentien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChuyentien.Controls.Add(this.lblSoDuString);
            this.pnlChuyentien.Controls.Add(this.lblSoDu);
            this.pnlChuyentien.Controls.Add(this.lblTenTK);
            this.pnlChuyentien.Controls.Add(this.btnTieptuc);
            this.pnlChuyentien.Controls.Add(this.btnHuy);
            this.pnlChuyentien.Controls.Add(this.label2);
            this.pnlChuyentien.Controls.Add(this.comboBox1);
            this.pnlChuyentien.Controls.Add(this.txtLoiNhan);
            this.pnlChuyentien.Controls.Add(this.label3);
            this.pnlChuyentien.Controls.Add(this.label4);
            this.pnlChuyentien.Controls.Add(this.txtSTK);
            this.pnlChuyentien.Controls.Add(this.txtSoTien);
            this.pnlChuyentien.Controls.Add(this.label5);
            this.pnlChuyentien.Location = new System.Drawing.Point(54, 43);
            this.pnlChuyentien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlChuyentien.Name = "pnlChuyentien";
            this.pnlChuyentien.Size = new System.Drawing.Size(444, 386);
            this.pnlChuyentien.TabIndex = 11;
            this.pnlChuyentien.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChuyentien_Paint);
            // 
            // lblSoDuString
            // 
            this.lblSoDuString.AutoSize = true;
            this.lblSoDuString.Location = new System.Drawing.Point(244, 170);
            this.lblSoDuString.Name = "lblSoDuString";
            this.lblSoDuString.Size = new System.Drawing.Size(44, 15);
            this.lblSoDuString.TabIndex = 27;
            this.lblSoDuString.Text = "Số Dư: ";
            // 
            // lblSoDu
            // 
            this.lblSoDu.AutoSize = true;
            this.lblSoDu.Location = new System.Drawing.Point(292, 169);
            this.lblSoDu.Name = "lblSoDu";
            this.lblSoDu.Size = new System.Drawing.Size(10, 15);
            this.lblSoDu.TabIndex = 26;
            this.lblSoDu.Text = " ";
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Location = new System.Drawing.Point(243, 114);
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
            this.ClientSize = new System.Drawing.Size(551, 469);
            this.Controls.Add(this.pnlChuyentien);
            this.Controls.Add(this.picBoxChuyentien);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmChuyentien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển tiền";
            this.Load += new System.EventHandler(this.FrmChuyentien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChuyentien)).EndInit();
            this.pnlChuyentien.ResumeLayout(false);
            this.pnlChuyentien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox txtLoiNhan;
        private Label label3;
        private Label label4;
        private TextBox txtSTK;
        private Label label5;
        private TextBox txtSoTien;
        private CustomButton.VBButton btnHuy;
        private CustomButton.VBButton btnTieptuc;
        private PictureBox picBoxChuyentien;
        private Panel pnlChuyentien;
        private Label lblTenTK;
        private Label lblSoDu;
        private Label lblSoDuString;
    }
}