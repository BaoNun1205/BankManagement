namespace DOAN_Nhom4
{
    partial class FrmChuyenTienNoi
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
            this.lblStk = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.txtStk = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtLoiNhan = new System.Windows.Forms.TextBox();
            this.btnChuyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStk
            // 
            this.lblStk.AutoSize = true;
            this.lblStk.Location = new System.Drawing.Point(56, 138);
            this.lblStk.Name = "lblStk";
            this.lblStk.Size = new System.Drawing.Size(74, 15);
            this.lblStk.TabIndex = 0;
            this.lblStk.Text = "Số Tài Khoản";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Location = new System.Drawing.Point(56, 222);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(77, 15);
            this.lblSoTien.TabIndex = 1;
            this.lblSoTien.Text = "Số Tiền(VNĐ)";
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.AutoSize = true;
            this.lblNoiDung.Location = new System.Drawing.Point(56, 329);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(55, 15);
            this.lblNoiDung.TabIndex = 2;
            this.lblNoiDung.Text = "Lời Nhắn";
            // 
            // txtStk
            // 
            this.txtStk.Location = new System.Drawing.Point(181, 114);
            this.txtStk.Multiline = true;
            this.txtStk.Name = "txtStk";
            this.txtStk.Size = new System.Drawing.Size(221, 39);
            this.txtStk.TabIndex = 3;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(181, 214);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(249, 23);
            this.txtSoTien.TabIndex = 4;
            // 
            // txtLoiNhan
            // 
            this.txtLoiNhan.Location = new System.Drawing.Point(181, 329);
            this.txtLoiNhan.Multiline = true;
            this.txtLoiNhan.Name = "txtLoiNhan";
            this.txtLoiNhan.Size = new System.Drawing.Size(279, 148);
            this.txtLoiNhan.TabIndex = 5;
            this.txtLoiNhan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(158, 505);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(318, 55);
            this.btnChuyen.TabIndex = 6;
            this.btnChuyen.Text = "Chuyển";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // FrmChuyenTienNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 591);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.txtLoiNhan);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtStk);
            this.Controls.Add(this.lblNoiDung);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.lblStk);
            this.Name = "FrmChuyenTienNoi";
            this.Text = "ChuyenTienNoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStk;
        private Label lblSoTien;
        private Label lblNoiDung;
        private TextBox txtStk;
        private TextBox txtSoTien;
        private TextBox txtLoiNhan;
        private Button btnChuyen;
    }
}