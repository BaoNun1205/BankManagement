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
            this.btnDangKy = new CustomButton.VBButton();
            this.btnXemKhoanVay = new CustomButton.VBButton();
            this.SuspendLayout();
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.White;
            this.btnDangKy.BackgroundColor = System.Drawing.Color.White;
            this.btnDangKy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnDangKy.BorderRadius = 20;
            this.btnDangKy.BorderSize = 2;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangKy.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangKy.Location = new System.Drawing.Point(431, 308);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(0);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(453, 131);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đăng Ký Khoản Vay";
            this.btnDangKy.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnDangKy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // btnXemKhoanVay
            // 
            this.btnXemKhoanVay.BackColor = System.Drawing.Color.White;
            this.btnXemKhoanVay.BackgroundColor = System.Drawing.Color.White;
            this.btnXemKhoanVay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnXemKhoanVay.BorderRadius = 20;
            this.btnXemKhoanVay.BorderSize = 2;
            this.btnXemKhoanVay.FlatAppearance.BorderSize = 0;
            this.btnXemKhoanVay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXemKhoanVay.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXemKhoanVay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnXemKhoanVay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemKhoanVay.Location = new System.Drawing.Point(431, 509);
            this.btnXemKhoanVay.Name = "btnXemKhoanVay";
            this.btnXemKhoanVay.Size = new System.Drawing.Size(453, 125);
            this.btnXemKhoanVay.TabIndex = 2;
            this.btnXemKhoanVay.Text = "Xem Thông Tin Khoản Vay";
            this.btnXemKhoanVay.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnXemKhoanVay.UseVisualStyleBackColor = false;
            this.btnXemKhoanVay.Click += new System.EventHandler(this.btn_XemKhoanVay_Click);
            // 
            // FrmTienIchVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 960);
            this.Controls.Add(this.btnXemKhoanVay);
            this.Controls.Add(this.btnDangKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTienIchVay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTienIchVay";
            this.ResumeLayout(false);

        }

        #endregion
        private CustomButton.VBButton btnDangKy;
        private CustomButton.VBButton btnXemKhoanVay;
    }
}