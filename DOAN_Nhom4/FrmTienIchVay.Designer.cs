namespace DOAN_Nhom4
{
    partial class FrmTienIchVay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTienIchVay));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_DangKy = new CustomButton.VBButton();
            this.btn_XemKhoanVay = new CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1139, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_DangKy.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btn_DangKy.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_DangKy.BorderRadius = 60;
            this.btn_DangKy.BorderSize = 0;
            this.btn_DangKy.FlatAppearance.BorderSize = 0;
            this.btn_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DangKy.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DangKy.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_DangKy.Location = new System.Drawing.Point(329, 177);
            this.btn_DangKy.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(368, 142);
            this.btn_DangKy.TabIndex = 1;
            this.btn_DangKy.Text = "Đăng Ký Khoản Vay";
            this.btn_DangKy.TextColor = System.Drawing.SystemColors.Window;
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_XemKhoanVay
            // 
            this.btn_XemKhoanVay.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_XemKhoanVay.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.btn_XemKhoanVay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_XemKhoanVay.BorderRadius = 60;
            this.btn_XemKhoanVay.BorderSize = 0;
            this.btn_XemKhoanVay.FlatAppearance.BorderSize = 0;
            this.btn_XemKhoanVay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XemKhoanVay.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XemKhoanVay.ForeColor = System.Drawing.Color.White;
            this.btn_XemKhoanVay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemKhoanVay.Location = new System.Drawing.Point(329, 384);
            this.btn_XemKhoanVay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XemKhoanVay.Name = "btn_XemKhoanVay";
            this.btn_XemKhoanVay.Size = new System.Drawing.Size(368, 135);
            this.btn_XemKhoanVay.TabIndex = 2;
            this.btn_XemKhoanVay.Text = "Xem Thông Tin Khoản Vay";
            this.btn_XemKhoanVay.TextColor = System.Drawing.Color.White;
            this.btn_XemKhoanVay.UseVisualStyleBackColor = false;
            this.btn_XemKhoanVay.Click += new System.EventHandler(this.btn_XemKhoanVay_Click);
            // 
            // FrmTienIchVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 720);
            this.Controls.Add(this.btn_XemKhoanVay);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTienIchVay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTienIchVay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private CustomButton.VBButton btn_DangKy;
        private CustomButton.VBButton btn_XemKhoanVay;
    }
}