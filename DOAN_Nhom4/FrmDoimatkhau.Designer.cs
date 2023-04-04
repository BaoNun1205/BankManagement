namespace DOAN_Nhom4
{
    partial class FrmDoimatkhau
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
            this.picBoxQuaylai = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_XacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.txt_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.txt_MatKhauCu = new System.Windows.Forms.TextBox();
            this.btn_DoiMatKhau = new CustomButton.VBButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuaylai)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxQuaylai
            // 
            this.picBoxQuaylai.BackColor = System.Drawing.Color.White;
            this.picBoxQuaylai.Image = global::DOAN_Nhom4.Properties.Resources.left_arrow1;
            this.picBoxQuaylai.Location = new System.Drawing.Point(11, 10);
            this.picBoxQuaylai.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.picBoxQuaylai.Name = "picBoxQuaylai";
            this.picBoxQuaylai.Size = new System.Drawing.Size(49, 41);
            this.picBoxQuaylai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxQuaylai.TabIndex = 57;
            this.picBoxQuaylai.TabStop = false;
            this.picBoxQuaylai.Click += new System.EventHandler(this.picBoxQuaylai_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.txt_XacNhanMatKhau);
            this.panel4.Controls.Add(this.txt_MatKhauMoi);
            this.panel4.Controls.Add(this.txt_MatKhauCu);
            this.panel4.Controls.Add(this.btn_DoiMatKhau);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(291, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 720);
            this.panel4.TabIndex = 58;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // txt_XacNhanMatKhau
            // 
            this.txt_XacNhanMatKhau.BackColor = System.Drawing.Color.White;
            this.txt_XacNhanMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_XacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_XacNhanMatKhau.ForeColor = System.Drawing.Color.Gray;
            this.txt_XacNhanMatKhau.Location = new System.Drawing.Point(209, 457);
            this.txt_XacNhanMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_XacNhanMatKhau.Name = "txt_XacNhanMatKhau";
            this.txt_XacNhanMatKhau.Size = new System.Drawing.Size(285, 32);
            this.txt_XacNhanMatKhau.TabIndex = 32;
            this.txt_XacNhanMatKhau.Text = "Xác nhận mật khẩu";
            this.txt_XacNhanMatKhau.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_XacNhanMatKhau_MouseClick);
            // 
            // txt_MatKhauMoi
            // 
            this.txt_MatKhauMoi.BackColor = System.Drawing.Color.White;
            this.txt_MatKhauMoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MatKhauMoi.ForeColor = System.Drawing.Color.Gray;
            this.txt_MatKhauMoi.Location = new System.Drawing.Point(209, 360);
            this.txt_MatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            this.txt_MatKhauMoi.Size = new System.Drawing.Size(285, 32);
            this.txt_MatKhauMoi.TabIndex = 31;
            this.txt_MatKhauMoi.Text = "Mật khẩu mới";
            this.txt_MatKhauMoi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MatKhauMoi_MouseClick);
            // 
            // txt_MatKhauCu
            // 
            this.txt_MatKhauCu.BackColor = System.Drawing.Color.White;
            this.txt_MatKhauCu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_MatKhauCu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MatKhauCu.ForeColor = System.Drawing.Color.Gray;
            this.txt_MatKhauCu.Location = new System.Drawing.Point(209, 258);
            this.txt_MatKhauCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatKhauCu.Name = "txt_MatKhauCu";
            this.txt_MatKhauCu.Size = new System.Drawing.Size(285, 32);
            this.txt_MatKhauCu.TabIndex = 30;
            this.txt_MatKhauCu.Text = "Mật khẩu cũ";
            this.txt_MatKhauCu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_MatKhauCu_MouseClick);
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_DoiMatKhau.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_DoiMatKhau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_DoiMatKhau.BorderRadius = 20;
            this.btn_DoiMatKhau.BorderSize = 0;
            this.btn_DoiMatKhau.FlatAppearance.BorderSize = 0;
            this.btn_DoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoiMatKhau.Font = new System.Drawing.Font("Sitka Small", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DoiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btn_DoiMatKhau.Location = new System.Drawing.Point(152, 567);
            this.btn_DoiMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.Size = new System.Drawing.Size(315, 73);
            this.btn_DoiMatKhau.TabIndex = 29;
            this.btn_DoiMatKhau.Text = "Đổi mật khẩu ";
            this.btn_DoiMatKhau.TextColor = System.Drawing.Color.White;
            this.btn_DoiMatKhau.UseVisualStyleBackColor = false;
            this.btn_DoiMatKhau.Click += new System.EventHandler(this.btn_DoiMatKhau_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.panel3.Location = new System.Drawing.Point(137, 493);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 1);
            this.panel3.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.panel2.Location = new System.Drawing.Point(137, 396);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 1);
            this.panel2.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.panel1.Location = new System.Drawing.Point(136, 294);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 1);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DOAN_Nhom4.Properties.Resources.baomat;
            this.pictureBox3.Location = new System.Drawing.Point(136, 444);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DOAN_Nhom4.Properties.Resources.baomat;
            this.pictureBox2.Location = new System.Drawing.Point(136, 347);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DOAN_Nhom4.Properties.Resources.baomat;
            this.pictureBox1.Location = new System.Drawing.Point(136, 245);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.label1.Location = new System.Drawing.Point(84, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 68);
            this.label1.TabIndex = 22;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // FrmDoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 720);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.picBoxQuaylai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FrmDoimatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmDoimatkhau";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuaylai)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox picBoxQuaylai;
        private Panel panel4;
        private TextBox txt_XacNhanMatKhau;
        private TextBox txt_MatKhauMoi;
        private TextBox txt_MatKhauCu;
        private CustomButton.VBButton btn_DoiMatKhau;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
    }
}