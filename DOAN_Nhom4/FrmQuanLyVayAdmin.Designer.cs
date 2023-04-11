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
            this.gv_Vay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Vay_CellClick);
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
            this.btn_QuayLai.Location = new System.Drawing.Point(99, 486);
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
        private DataGridView gv_Vay;
        private CustomButton.VBButton btn_QuayLai;
        private TextBox txt_SoTKVay;
        private Label label1;
    }
}