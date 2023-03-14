namespace DOAN_Nhom4
{
    partial class FrmBaomat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaomat));
            this.pn_baomat = new System.Windows.Forms.Panel();
            this.pb_QuayLai = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.pb_dangxuat = new System.Windows.Forms.PictureBox();
            this.btn_dangxuat = new CustomButton.VBButton();
            this.btn_doimatkhau = new CustomButton.VBButton();
            this.cb_hienthipass = new System.Windows.Forms.CheckBox();
            this.lbl_matKhau = new System.Windows.Forms.Label();
            this.lbl_tenDN = new System.Windows.Forms.Label();
            this.pn_baomat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuayLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dangxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_baomat
            // 
            this.pn_baomat.BackColor = System.Drawing.Color.White;
            this.pn_baomat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_baomat.Controls.Add(this.pb_QuayLai);
            this.pn_baomat.Controls.Add(this.label1);
            this.pn_baomat.Controls.Add(this.txtMatkhau);
            this.pn_baomat.Controls.Add(this.txtTenDN);
            this.pn_baomat.Controls.Add(this.pb_dangxuat);
            this.pn_baomat.Controls.Add(this.btn_dangxuat);
            this.pn_baomat.Controls.Add(this.btn_doimatkhau);
            this.pn_baomat.Controls.Add(this.cb_hienthipass);
            this.pn_baomat.Controls.Add(this.lbl_matKhau);
            this.pn_baomat.Controls.Add(this.lbl_tenDN);
            this.pn_baomat.ForeColor = System.Drawing.Color.DodgerBlue;
            this.pn_baomat.Location = new System.Drawing.Point(0, 0);
            this.pn_baomat.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pn_baomat.Name = "pn_baomat";
            this.pn_baomat.Size = new System.Drawing.Size(1005, 689);
            this.pn_baomat.TabIndex = 2;
            this.pn_baomat.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_baomat_Paint);
            // 
            // pb_QuayLai
            // 
            this.pb_QuayLai.BackColor = System.Drawing.Color.White;
            this.pb_QuayLai.Image = ((System.Drawing.Image)(resources.GetObject("pb_QuayLai.Image")));
            this.pb_QuayLai.Location = new System.Drawing.Point(14, 12);
            this.pb_QuayLai.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pb_QuayLai.Name = "pb_QuayLai";
            this.pb_QuayLai.Size = new System.Drawing.Size(52, 53);
            this.pb_QuayLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_QuayLai.TabIndex = 29;
            this.pb_QuayLai.TabStop = false;
            this.pb_QuayLai.Click += new System.EventHandler(this.pb_QuayLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(299, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "BẢO MẬT TÀI KHOẢN";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BackColor = System.Drawing.Color.White;
            this.txtMatkhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatkhau.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMatkhau.ForeColor = System.Drawing.Color.Gray;
            this.txtMatkhau.Location = new System.Drawing.Point(344, 309);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.ReadOnly = true;
            this.txtMatkhau.Size = new System.Drawing.Size(325, 36);
            this.txtMatkhau.TabIndex = 26;
            this.txtMatkhau.UseSystemPasswordChar = true;
            // 
            // txtTenDN
            // 
            this.txtTenDN.BackColor = System.Drawing.Color.White;
            this.txtTenDN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDN.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenDN.ForeColor = System.Drawing.Color.Gray;
            this.txtTenDN.Location = new System.Drawing.Point(344, 164);
            this.txtTenDN.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.ReadOnly = true;
            this.txtTenDN.Size = new System.Drawing.Size(325, 36);
            this.txtTenDN.TabIndex = 25;
            // 
            // pb_dangxuat
            // 
            this.pb_dangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.pb_dangxuat.Image = ((System.Drawing.Image)(resources.GetObject("pb_dangxuat.Image")));
            this.pb_dangxuat.Location = new System.Drawing.Point(507, 535);
            this.pb_dangxuat.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pb_dangxuat.Name = "pb_dangxuat";
            this.pb_dangxuat.Size = new System.Drawing.Size(74, 81);
            this.pb_dangxuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_dangxuat.TabIndex = 24;
            this.pb_dangxuat.TabStop = false;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_dangxuat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_dangxuat.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_dangxuat.BorderRadius = 30;
            this.btn_dangxuat.BorderSize = 0;
            this.btn_dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dangxuat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dangxuat.ForeColor = System.Drawing.Color.White;
            this.btn_dangxuat.Location = new System.Drawing.Point(344, 529);
            this.btn_dangxuat.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(269, 107);
            this.btn_dangxuat.TabIndex = 23;
            this.btn_dangxuat.Text = " Đăng xuất";
            this.btn_dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.TextColor = System.Drawing.Color.White;
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.BackColor = System.Drawing.Color.White;
            this.btn_doimatkhau.BackgroundColor = System.Drawing.Color.White;
            this.btn_doimatkhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_doimatkhau.BorderRadius = 20;
            this.btn_doimatkhau.BorderSize = 3;
            this.btn_doimatkhau.FlatAppearance.BorderSize = 0;
            this.btn_doimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doimatkhau.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_doimatkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_doimatkhau.Location = new System.Drawing.Point(722, 299);
            this.btn_doimatkhau.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(256, 68);
            this.btn_doimatkhau.TabIndex = 22;
            this.btn_doimatkhau.Text = "Đổi mật khẩu ";
            this.btn_doimatkhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_doimatkhau.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.btn_doimatkhau.UseVisualStyleBackColor = false;
            this.btn_doimatkhau.Click += new System.EventHandler(this.btn_doimatkhau_Click);
            // 
            // cb_hienthipass
            // 
            this.cb_hienthipass.AutoSize = true;
            this.cb_hienthipass.BackColor = System.Drawing.Color.White;
            this.cb_hienthipass.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_hienthipass.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cb_hienthipass.Location = new System.Drawing.Point(343, 366);
            this.cb_hienthipass.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cb_hienthipass.Name = "cb_hienthipass";
            this.cb_hienthipass.Size = new System.Drawing.Size(270, 36);
            this.cb_hienthipass.TabIndex = 21;
            this.cb_hienthipass.Text = "Hiển thị mật khẩu";
            this.cb_hienthipass.UseVisualStyleBackColor = false;
            this.cb_hienthipass.CheckedChanged += new System.EventHandler(this.cb_hienthipass_CheckedChanged);
            // 
            // lbl_matKhau
            // 
            this.lbl_matKhau.AutoSize = true;
            this.lbl_matKhau.BackColor = System.Drawing.Color.White;
            this.lbl_matKhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_matKhau.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_matKhau.ForeColor = System.Drawing.Color.Gray;
            this.lbl_matKhau.Location = new System.Drawing.Point(24, 309);
            this.lbl_matKhau.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_matKhau.Name = "lbl_matKhau";
            this.lbl_matKhau.Size = new System.Drawing.Size(165, 39);
            this.lbl_matKhau.TabIndex = 20;
            this.lbl_matKhau.Text = "Mật khẩu";
            // 
            // lbl_tenDN
            // 
            this.lbl_tenDN.AutoSize = true;
            this.lbl_tenDN.BackColor = System.Drawing.Color.White;
            this.lbl_tenDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_tenDN.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tenDN.ForeColor = System.Drawing.Color.Gray;
            this.lbl_tenDN.Location = new System.Drawing.Point(24, 164);
            this.lbl_tenDN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_tenDN.Name = "lbl_tenDN";
            this.lbl_tenDN.Size = new System.Drawing.Size(256, 46);
            this.lbl_tenDN.TabIndex = 19;
            this.lbl_tenDN.Text = "Tên đăng nhập";
            this.lbl_tenDN.UseCompatibleTextRendering = true;
            // 
            // FrmBaomat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 687);
            this.Controls.Add(this.pn_baomat);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmBaomat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBaomat";
            this.pn_baomat.ResumeLayout(false);
            this.pn_baomat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuayLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dangxuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pn_baomat;
        private PictureBox pb_QuayLai;
        private Label label1;
        private TextBox txtMatkhau;
        private TextBox txtTenDN;
        private PictureBox pb_dangxuat;
        private CustomButton.VBButton btn_dangxuat;
        private CustomButton.VBButton btn_doimatkhau;
        private CheckBox cb_hienthipass;
        private Label lbl_matKhau;
        private Label lbl_tenDN;
    }
}