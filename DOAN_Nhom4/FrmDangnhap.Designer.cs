namespace DOAN_Nhom4
{
    partial class FrmDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangnhap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cb_showpass = new System.Windows.Forms.CheckBox();
            this.lblXoa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangnhap = new CustomButton.VBButton();
            this.btnThoat = new CustomButton.VBButton();
            this.btnDangky = new CustomButton.VBButton();
            this.rdb_Admin = new System.Windows.Forms.RadioButton();
            this.rdb_NguoiDung = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DOAN_Nhom4.Properties.Resources.z4156388208487_6cfd569e12217b8073a7fbfcc22c322f;
            this.pictureBox1.Location = new System.Drawing.Point(93, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DOAN_Nhom4.Properties.Resources.user3;
            this.pictureBox2.Location = new System.Drawing.Point(35, 184);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DOAN_Nhom4.Properties.Resources.padlock1;
            this.pictureBox3.Location = new System.Drawing.Point(35, 270);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(35, 226);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 1);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(35, 312);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 1);
            this.panel3.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Malgun Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtUserName.Location = new System.Drawing.Point(85, 184);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(300, 38);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Malgun Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPass.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtPass.Location = new System.Drawing.Point(85, 270);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(300, 38);
            this.txtPass.TabIndex = 6;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // cb_showpass
            // 
            this.cb_showpass.AutoSize = true;
            this.cb_showpass.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_showpass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cb_showpass.Location = new System.Drawing.Point(35, 358);
            this.cb_showpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_showpass.Name = "cb_showpass";
            this.cb_showpass.Size = new System.Drawing.Size(151, 19);
            this.cb_showpass.TabIndex = 11;
            this.cb_showpass.Text = "Hiển thị mật khẩu";
            this.cb_showpass.UseVisualStyleBackColor = true;
            this.cb_showpass.CheckedChanged += new System.EventHandler(this.cb_showpass_CheckedChanged);
            // 
            // lblXoa
            // 
            this.lblXoa.AutoSize = true;
            this.lblXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblXoa.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblXoa.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblXoa.Location = new System.Drawing.Point(342, 358);
            this.lblXoa.Name = "lblXoa";
            this.lblXoa.Size = new System.Drawing.Size(42, 19);
            this.lblXoa.TabIndex = 17;
            this.lblXoa.Text = "Xóa";
            this.lblXoa.Click += new System.EventHandler(this.lblXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(123, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "HHB BANK";
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangnhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangnhap.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDangnhap.BorderRadius = 0;
            this.btnDangnhap.BorderSize = 3;
            this.btnDangnhap.FlatAppearance.BorderSize = 0;
            this.btnDangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangnhap.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDangnhap.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDangnhap.Location = new System.Drawing.Point(218, 390);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(167, 38);
            this.btnDangnhap.TabIndex = 23;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnDangnhap.UseVisualStyleBackColor = false;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.BorderRadius = 0;
            this.btnThoat.BorderSize = 3;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.Location = new System.Drawing.Point(35, 443);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(350, 38);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangky
            // 
            this.btnDangky.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangky.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangky.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDangky.BorderRadius = 0;
            this.btnDangky.BorderSize = 3;
            this.btnDangky.FlatAppearance.BorderSize = 0;
            this.btnDangky.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangky.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDangky.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnDangky.Location = new System.Drawing.Point(35, 390);
            this.btnDangky.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(167, 38);
            this.btnDangky.TabIndex = 26;
            this.btnDangky.Text = "Đăng ký";
            this.btnDangky.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnDangky.UseVisualStyleBackColor = false;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // rdb_Admin
            // 
            this.rdb_Admin.AutoSize = true;
            this.rdb_Admin.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_Admin.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdb_Admin.Location = new System.Drawing.Point(85, 325);
            this.rdb_Admin.Name = "rdb_Admin";
            this.rdb_Admin.Size = new System.Drawing.Size(71, 20);
            this.rdb_Admin.TabIndex = 27;
            this.rdb_Admin.TabStop = true;
            this.rdb_Admin.Text = "Admin";
            this.rdb_Admin.UseVisualStyleBackColor = true;
            // 
            // rdb_NguoiDung
            // 
            this.rdb_NguoiDung.AutoSize = true;
            this.rdb_NguoiDung.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdb_NguoiDung.ForeColor = System.Drawing.Color.DodgerBlue;
            this.rdb_NguoiDung.Location = new System.Drawing.Point(246, 325);
            this.rdb_NguoiDung.Name = "rdb_NguoiDung";
            this.rdb_NguoiDung.Size = new System.Drawing.Size(107, 20);
            this.rdb_NguoiDung.TabIndex = 28;
            this.rdb_NguoiDung.TabStop = true;
            this.rdb_NguoiDung.Text = "Người Dùng";
            this.rdb_NguoiDung.UseVisualStyleBackColor = true;
            // 
            // FrmDangnhap
            // 
            this.AcceptButton = this.btnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(423, 497);
            this.Controls.Add(this.rdb_NguoiDung);
            this.Controls.Add(this.rdb_Admin);
            this.Controls.Add(this.btnDangky);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblXoa);
            this.Controls.Add(this.cb_showpass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.FrmDangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtUserName;
        private TextBox txtPass;
        private CheckBox cb_showpass;
        private Label lblXoa;
        private Label label1;
        private CustomButton.VBButton btnDangnhap;
        private CustomButton.VBButton btnThoat;
        private CustomButton.VBButton btnDangky;
        private RadioButton rdb_Admin;
        private RadioButton rdb_NguoiDung;
    }
}