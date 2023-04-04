namespace DOAN_Nhom4
{
    partial class FrmQuanLyVayAdmin
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
            this.btn_Xoa = new CustomButton.VBButton();
            this.btn_TimKiem = new CustomButton.VBButton();
            this.rb_DangThanhToan = new System.Windows.Forms.RadioButton();
            this.rb_ThanhToanXong = new System.Windows.Forms.RadioButton();
            this.gv_Vay = new System.Windows.Forms.DataGridView();
            this.btn_QuayLai = new CustomButton.VBButton();
            this.txt_SoTKVay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Vay)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Teal;
            this.btn_Xoa.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_Xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Xoa.BorderRadius = 20;
            this.btn_Xoa.BorderSize = 0;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Xoa.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(99, 183);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(201, 60);
            this.btn_Xoa.TabIndex = 28;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.Teal;
            this.btn_TimKiem.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_TimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TimKiem.BorderRadius = 20;
            this.btn_TimKiem.BorderSize = 0;
            this.btn_TimKiem.FlatAppearance.BorderSize = 0;
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TimKiem.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_TimKiem.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem.Location = new System.Drawing.Point(99, 342);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(201, 60);
            this.btn_TimKiem.TabIndex = 29;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextColor = System.Drawing.Color.White;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // rb_DangThanhToan
            // 
            this.rb_DangThanhToan.AutoSize = true;
            this.rb_DangThanhToan.BackColor = System.Drawing.SystemColors.Window;
            this.rb_DangThanhToan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_DangThanhToan.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rb_DangThanhToan.Location = new System.Drawing.Point(99, 420);
            this.rb_DangThanhToan.Name = "rb_DangThanhToan";
            this.rb_DangThanhToan.Size = new System.Drawing.Size(240, 24);
            this.rb_DangThanhToan.TabIndex = 30;
            this.rb_DangThanhToan.TabStop = true;
            this.rb_DangThanhToan.Text = "Trong thời gian thanh toán";
            this.rb_DangThanhToan.UseVisualStyleBackColor = false;
            // 
            // rb_ThanhToanXong
            // 
            this.rb_ThanhToanXong.AutoSize = true;
            this.rb_ThanhToanXong.BackColor = System.Drawing.SystemColors.Window;
            this.rb_ThanhToanXong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_ThanhToanXong.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rb_ThanhToanXong.Location = new System.Drawing.Point(99, 459);
            this.rb_ThanhToanXong.Name = "rb_ThanhToanXong";
            this.rb_ThanhToanXong.Size = new System.Drawing.Size(185, 24);
            this.rb_ThanhToanXong.TabIndex = 31;
            this.rb_ThanhToanXong.TabStop = true;
            this.rb_ThanhToanXong.Text = "Đã thanh toán xong";
            this.rb_ThanhToanXong.UseVisualStyleBackColor = false;
            // 
            // gv_Vay
            // 
            this.gv_Vay.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gv_Vay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Vay.Location = new System.Drawing.Point(363, 32);
            this.gv_Vay.Name = "gv_Vay";
            this.gv_Vay.RowHeadersWidth = 51;
            this.gv_Vay.RowTemplate.Height = 29;
            this.gv_Vay.Size = new System.Drawing.Size(939, 716);
            this.gv_Vay.TabIndex = 32;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.Color.Teal;
            this.btn_QuayLai.BackgroundColor = System.Drawing.Color.Teal;
            this.btn_QuayLai.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_QuayLai.BorderRadius = 20;
            this.btn_QuayLai.BorderSize = 0;
            this.btn_QuayLai.FlatAppearance.BorderSize = 0;
            this.btn_QuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_QuayLai.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_QuayLai.ForeColor = System.Drawing.Color.White;
            this.btn_QuayLai.Location = new System.Drawing.Point(99, 544);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(201, 60);
            this.btn_QuayLai.TabIndex = 33;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.TextColor = System.Drawing.Color.White;
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // txt_SoTKVay
            // 
            this.txt_SoTKVay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoTKVay.Location = new System.Drawing.Point(173, 251);
            this.txt_SoTKVay.Name = "txt_SoTKVay";
            this.txt_SoTKVay.Size = new System.Drawing.Size(127, 27);
            this.txt_SoTKVay.TabIndex = 34;
            this.txt_SoTKVay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(42, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tài khoản vay";
            // 
            // FrmQuanLyVayAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1341, 760);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SoTKVay);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.gv_Vay);
            this.Controls.Add(this.rb_ThanhToanXong);
            this.Controls.Add(this.rb_DangThanhToan);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_Xoa);
            this.Name = "FrmQuanLyVayAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuanLyVayAdmin";
            this.Load += new System.EventHandler(this.FrmQuanLyVayAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Vay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton.VBButton btn_Xoa;
        private CustomButton.VBButton btn_TimKiem;
        private RadioButton rb_DangThanhToan;
        private RadioButton rb_ThanhToanXong;
        private DataGridView gv_Vay;
        private CustomButton.VBButton btn_QuayLai;
        private TextBox txt_SoTKVay;
        private Label label1;
    }
}