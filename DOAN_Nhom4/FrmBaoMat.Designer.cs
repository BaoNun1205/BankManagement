namespace DOAN_Nhom4
{
    partial class FrmBaoMat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoMat));
            this.pb_baomat = new System.Windows.Forms.PictureBox();
            this.lbl_tenDN = new System.Windows.Forms.Label();
            this.lbl_matKhau = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cb_hienthipass = new System.Windows.Forms.CheckBox();
            this.btn_doimatkhau = new CustomButton.VBButton();
            this.btn_dangxuat = new CustomButton.VBButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_baomat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_baomat
            // 
            this.pb_baomat.Image = ((System.Drawing.Image)(resources.GetObject("pb_baomat.Image")));
            this.pb_baomat.Location = new System.Drawing.Point(1, 2);
            this.pb_baomat.Name = "pb_baomat";
            this.pb_baomat.Size = new System.Drawing.Size(809, 487);
            this.pb_baomat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_baomat.TabIndex = 0;
            this.pb_baomat.TabStop = false;
            // 
            // lbl_tenDN
            // 
            this.lbl_tenDN.AutoSize = true;
            this.lbl_tenDN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tenDN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_tenDN.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tenDN.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_tenDN.Location = new System.Drawing.Point(53, 148);
            this.lbl_tenDN.Name = "lbl_tenDN";
            this.lbl_tenDN.Size = new System.Drawing.Size(184, 34);
            this.lbl_tenDN.TabIndex = 1;
            this.lbl_tenDN.Text = "Tên đăng nhập";
            this.lbl_tenDN.UseCompatibleTextRendering = true;
            // 
            // lbl_matKhau
            // 
            this.lbl_matKhau.AutoSize = true;
            this.lbl_matKhau.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_matKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_matKhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_matKhau.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_matKhau.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_matKhau.Location = new System.Drawing.Point(53, 238);
            this.lbl_matKhau.Name = "lbl_matKhau";
            this.lbl_matKhau.Size = new System.Drawing.Size(124, 30);
            this.lbl_matKhau.TabIndex = 2;
            this.lbl_matKhau.Text = "Mật khẩu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 27);
            this.textBox2.TabIndex = 4;
            // 
            // cb_hienthipass
            // 
            this.cb_hienthipass.AutoSize = true;
            this.cb_hienthipass.BackColor = System.Drawing.SystemColors.MenuText;
            this.cb_hienthipass.Font = new System.Drawing.Font("Franklin Gothic Book", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_hienthipass.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_hienthipass.Location = new System.Drawing.Point(322, 295);
            this.cb_hienthipass.Name = "cb_hienthipass";
            this.cb_hienthipass.Size = new System.Drawing.Size(176, 25);
            this.cb_hienthipass.TabIndex = 5;
            this.cb_hienthipass.Text = "Hiển thị mật khẩu";
            this.cb_hienthipass.UseVisualStyleBackColor = false;
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_doimatkhau.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btn_doimatkhau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_doimatkhau.BorderRadius = 20;
            this.btn_doimatkhau.BorderSize = 0;
            this.btn_doimatkhau.FlatAppearance.BorderSize = 0;
            this.btn_doimatkhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doimatkhau.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_doimatkhau.ForeColor = System.Drawing.Color.Black;
            this.btn_doimatkhau.Location = new System.Drawing.Point(595, 242);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(128, 33);
            this.btn_doimatkhau.TabIndex = 6;
            this.btn_doimatkhau.Text = "Đổi mật khẩu ";
            this.btn_doimatkhau.TextColor = System.Drawing.Color.Black;
            this.btn_doimatkhau.UseVisualStyleBackColor = false;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.Crimson;
            this.btn_dangxuat.BackgroundColor = System.Drawing.Color.Crimson;
            this.btn_dangxuat.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btn_dangxuat.BorderRadius = 30;
            this.btn_dangxuat.BorderSize = 0;
            this.btn_dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangxuat.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dangxuat.ForeColor = System.Drawing.Color.Black;
            this.btn_dangxuat.Location = new System.Drawing.Point(322, 372);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(166, 66);
            this.btn_dangxuat.TabIndex = 7;
            this.btn_dangxuat.Text = " Đăng xuất";
            this.btn_dangxuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.TextColor = System.Drawing.Color.Black;
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(421, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBaoMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 486);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_dangxuat);
            this.Controls.Add(this.btn_doimatkhau);
            this.Controls.Add(this.cb_hienthipass);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_matKhau);
            this.Controls.Add(this.lbl_tenDN);
            this.Controls.Add(this.pb_baomat);
            this.Name = "FrmBaoMat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBaoMat";
            this.Load += new System.EventHandler(this.FrmBaoMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_baomat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_baomat;
        private Label lbl_tenDN;
        private Label lbl_matKhau;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox cb_hienthipass;
        private CustomButton.VBButton btn_doimatkhau;
        private CustomButton.VBButton btn_dangxuat;
        private PictureBox pictureBox1;
    }
}