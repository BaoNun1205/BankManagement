namespace DOAN_Nhom4
{
    partial class FrmAdminDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminDichVu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_QuayLai = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ChuyenTien = new CustomButton.VBButton();
            this.btn_RutTien = new CustomButton.VBButton();
            this.btn_NapTien = new CustomButton.VBButton();
            this.pnlDichvu = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuayLai)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(165, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 95);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(241, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 44);
            this.label1.TabIndex = 24;
            this.label1.Text = "DỊCH VỤ NGÂN HÀNG";
            // 
            // pb_QuayLai
            // 
            this.pb_QuayLai.Image = global::DOAN_Nhom4.Properties.Resources.left_arrow4;
            this.pb_QuayLai.Location = new System.Drawing.Point(3, 2);
            this.pb_QuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_QuayLai.Name = "pb_QuayLai";
            this.pb_QuayLai.Size = new System.Drawing.Size(35, 34);
            this.pb_QuayLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_QuayLai.TabIndex = 25;
            this.pb_QuayLai.TabStop = false;
            this.pb_QuayLai.Click += new System.EventHandler(this.pb_QuayLai_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pb_QuayLai);
            this.panel2.Controls.Add(this.btn_ChuyenTien);
            this.panel2.Controls.Add(this.btn_RutTien);
            this.panel2.Controls.Add(this.btn_NapTien);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 711);
            this.panel2.TabIndex = 33;
            // 
            // btn_ChuyenTien
            // 
            this.btn_ChuyenTien.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ChuyenTien.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_ChuyenTien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ChuyenTien.BorderRadius = 0;
            this.btn_ChuyenTien.BorderSize = 0;
            this.btn_ChuyenTien.FlatAppearance.BorderSize = 0;
            this.btn_ChuyenTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChuyenTien.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ChuyenTien.ForeColor = System.Drawing.Color.White;
            this.btn_ChuyenTien.Location = new System.Drawing.Point(0, 524);
            this.btn_ChuyenTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChuyenTien.Name = "btn_ChuyenTien";
            this.btn_ChuyenTien.Size = new System.Drawing.Size(168, 129);
            this.btn_ChuyenTien.TabIndex = 43;
            this.btn_ChuyenTien.Text = "Chuyển Tiền";
            this.btn_ChuyenTien.TextColor = System.Drawing.Color.White;
            this.btn_ChuyenTien.UseVisualStyleBackColor = false;
            this.btn_ChuyenTien.Click += new System.EventHandler(this.btn_ChuyenTien_Click);
            // 
            // btn_RutTien
            // 
            this.btn_RutTien.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_RutTien.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_RutTien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_RutTien.BorderRadius = 0;
            this.btn_RutTien.BorderSize = 0;
            this.btn_RutTien.FlatAppearance.BorderSize = 0;
            this.btn_RutTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RutTien.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_RutTien.ForeColor = System.Drawing.Color.White;
            this.btn_RutTien.Location = new System.Drawing.Point(0, 311);
            this.btn_RutTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RutTien.Name = "btn_RutTien";
            this.btn_RutTien.Size = new System.Drawing.Size(168, 129);
            this.btn_RutTien.TabIndex = 42;
            this.btn_RutTien.Text = "Rút Tiền";
            this.btn_RutTien.TextColor = System.Drawing.Color.White;
            this.btn_RutTien.UseVisualStyleBackColor = false;
            this.btn_RutTien.Click += new System.EventHandler(this.btn_RutTien_Click);
            // 
            // btn_NapTien
            // 
            this.btn_NapTien.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_NapTien.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_NapTien.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_NapTien.BorderRadius = 0;
            this.btn_NapTien.BorderSize = 0;
            this.btn_NapTien.FlatAppearance.BorderSize = 0;
            this.btn_NapTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NapTien.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_NapTien.ForeColor = System.Drawing.Color.White;
            this.btn_NapTien.Location = new System.Drawing.Point(0, 95);
            this.btn_NapTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NapTien.Name = "btn_NapTien";
            this.btn_NapTien.Size = new System.Drawing.Size(168, 129);
            this.btn_NapTien.TabIndex = 41;
            this.btn_NapTien.Text = "Nạp Tiền";
            this.btn_NapTien.TextColor = System.Drawing.Color.White;
            this.btn_NapTien.UseVisualStyleBackColor = false;
            this.btn_NapTien.Click += new System.EventHandler(this.btn_NapTien_Click);
            // 
            // pnlDichvu
            // 
            this.pnlDichvu.Location = new System.Drawing.Point(168, 95);
            this.pnlDichvu.Name = "pnlDichvu";
            this.pnlDichvu.Size = new System.Drawing.Size(960, 616);
            this.pnlDichvu.TabIndex = 34;
            // 
            // FrmAdminDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1128, 710);
            this.Controls.Add(this.pnlDichvu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Dịch Vụ";
            this.Load += new System.EventHandler(this.FrmAdminDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_QuayLai)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private CustomButton.VBButton btn_ChuyenTien;
        private CustomButton.VBButton btn_RutTien;
        private PictureBox pb_QuayLai;
        private Panel pnlDichvu;
        private CustomButton.VBButton btn_NapTien;
    }
}