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
            this.btn_DangKy = new CustomButton.VBButton();
            this.btn_XemKhoanVay = new CustomButton.VBButton();
            this.SuspendLayout();
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.White;
            this.btn_DangKy.BackgroundColor = System.Drawing.Color.White;
            this.btn_DangKy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_DangKy.BorderRadius = 20;
            this.btn_DangKy.BorderSize = 2;
            this.btn_DangKy.FlatAppearance.BorderSize = 0;
            this.btn_DangKy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_DangKy.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_DangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DangKy.Location = new System.Drawing.Point(377, 231);
            this.btn_DangKy.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(396, 98);
            this.btn_DangKy.TabIndex = 1;
            this.btn_DangKy.Text = "Đăng Ký Khoản Vay";
            this.btn_DangKy.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_DangKy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btn_XemKhoanVay
            // 
            this.btn_XemKhoanVay.BackColor = System.Drawing.Color.White;
            this.btn_XemKhoanVay.BackgroundColor = System.Drawing.Color.White;
            this.btn_XemKhoanVay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_XemKhoanVay.BorderRadius = 20;
            this.btn_XemKhoanVay.BorderSize = 2;
            this.btn_XemKhoanVay.FlatAppearance.BorderSize = 0;
            this.btn_XemKhoanVay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_XemKhoanVay.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_XemKhoanVay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_XemKhoanVay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XemKhoanVay.Location = new System.Drawing.Point(377, 382);
            this.btn_XemKhoanVay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XemKhoanVay.Name = "btn_XemKhoanVay";
            this.btn_XemKhoanVay.Size = new System.Drawing.Size(396, 94);
            this.btn_XemKhoanVay.TabIndex = 2;
            this.btn_XemKhoanVay.Text = "Xem Thông Tin Khoản Vay";
            this.btn_XemKhoanVay.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn_XemKhoanVay.UseVisualStyleBackColor = false;
            this.btn_XemKhoanVay.Click += new System.EventHandler(this.btn_XemKhoanVay_Click);
            // 
            // FrmTienIchVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 720);
            this.Controls.Add(this.btn_XemKhoanVay);
            this.Controls.Add(this.btn_DangKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTienIchVay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTienIchVay";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton.VBButton btn_DangKy;
        private CustomButton.VBButton btn_XemKhoanVay;
    }
}