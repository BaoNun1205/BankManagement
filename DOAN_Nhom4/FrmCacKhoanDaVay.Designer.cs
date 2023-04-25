namespace DOAN_Nhom4
{
    partial class FrmCacKhoanDaVay
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoTKVay = new System.Windows.Forms.TextBox();
            this.btn_QuayLai = new CustomButton.VBButton();
            this.gv_TungVay = new System.Windows.Forms.DataGridView();
            this.btn_Xoa = new CustomButton.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.gv_TungVay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(21, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tài khoản vay";
            // 
            // txt_SoTKVay
            // 
            this.txt_SoTKVay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoTKVay.Location = new System.Drawing.Point(135, 216);
            this.txt_SoTKVay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SoTKVay.Name = "txt_SoTKVay";
            this.txt_SoTKVay.Size = new System.Drawing.Size(111, 23);
            this.txt_SoTKVay.TabIndex = 39;
            this.txt_SoTKVay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btn_QuayLai.Location = new System.Drawing.Point(71, 308);
            this.btn_QuayLai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(176, 45);
            this.btn_QuayLai.TabIndex = 38;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.TextColor = System.Drawing.Color.White;
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.btn_QuayLai_Click);
            // 
            // gv_TungVay
            // 
            this.gv_TungVay.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gv_TungVay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_TungVay.Location = new System.Drawing.Point(302, 52);
            this.gv_TungVay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gv_TungVay.Name = "gv_TungVay";
            this.gv_TungVay.RowHeadersWidth = 51;
            this.gv_TungVay.RowTemplate.Height = 29;
            this.gv_TungVay.Size = new System.Drawing.Size(822, 537);
            this.gv_TungVay.TabIndex = 37;
            this.gv_TungVay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_TungVay_CellClick);
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
            this.btn_Xoa.Location = new System.Drawing.Point(71, 165);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(176, 45);
            this.btn_Xoa.TabIndex = 36;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // FrmCacKhoanDaVay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1183, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SoTKVay);
            this.Controls.Add(this.btn_QuayLai);
            this.Controls.Add(this.gv_TungVay);
            this.Controls.Add(this.btn_Xoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCacKhoanDaVay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCacKhoanDaVay";
            this.Load += new System.EventHandler(this.FrmCacKhoanDaVay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_TungVay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_SoTKVay;
        private CustomButton.VBButton btn_QuayLai;
        private DataGridView gv_TungVay;
        private CustomButton.VBButton btn_Xoa;
    }
}