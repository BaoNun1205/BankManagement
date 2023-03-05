namespace DOAN_Nhom4
{
    partial class FrmAdmin
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
            this.lblSoTK = new System.Windows.Forms.Label();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.lblTenDN = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txt_soTK = new System.Windows.Forms.TextBox();
            this.txt_tenTK = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.gvQLKH = new System.Windows.Forms.DataGridView();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_tenDN = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lblSoDu = new System.Windows.Forms.Label();
            this.txt_SoDu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(268, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // lblSoTK
            // 
            this.lblSoTK.AutoSize = true;
            this.lblSoTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoTK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSoTK.Location = new System.Drawing.Point(25, 67);
            this.lblSoTK.Name = "lblSoTK";
            this.lblSoTK.Size = new System.Drawing.Size(75, 15);
            this.lblSoTK.TabIndex = 1;
            this.lblSoTK.Text = "Số tài khoản";
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenTK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTenTK.Location = new System.Drawing.Point(25, 111);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(81, 15);
            this.lblTenTK.TabIndex = 2;
            this.lblTenTK.Text = "Tên tài khoản";
            // 
            // lblTenDN
            // 
            this.lblTenDN.AutoSize = true;
            this.lblTenDN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenDN.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTenDN.Location = new System.Drawing.Point(25, 148);
            this.lblTenDN.Name = "lblTenDN";
            this.lblTenDN.Size = new System.Drawing.Size(88, 15);
            this.lblTenDN.TabIndex = 3;
            this.lblTenDN.Text = "Tên đăng nhập";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblMK.Location = new System.Drawing.Point(25, 184);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(59, 15);
            this.lblMK.TabIndex = 4;
            this.lblMK.Text = "Mật khẩu";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNgaySinh.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNgaySinh.Location = new System.Drawing.Point(459, 111);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(60, 15);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.CustomFormat = "MM/dd/yyyy";
            this.txt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_NgaySinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_NgaySinh.Location = new System.Drawing.Point(559, 107);
            this.txt_NgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(224, 23);
            this.txt_NgaySinh.TabIndex = 6;
            this.txt_NgaySinh.Value = new System.DateTime(2023, 3, 2, 12, 30, 31, 0);
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCCCD.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCCCD.Location = new System.Drawing.Point(459, 148);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(37, 15);
            this.lblCCCD.TabIndex = 7;
            this.lblCCCD.Text = "CCCD";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSDT.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSDT.Location = new System.Drawing.Point(459, 184);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(80, 15);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // txt_soTK
            // 
            this.txt_soTK.BackColor = System.Drawing.SystemColors.Window;
            this.txt_soTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_soTK.Location = new System.Drawing.Point(143, 59);
            this.txt_soTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soTK.Name = "txt_soTK";
            this.txt_soTK.Size = new System.Drawing.Size(223, 23);
            this.txt_soTK.TabIndex = 9;
            // 
            // txt_tenTK
            // 
            this.txt_tenTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenTK.Location = new System.Drawing.Point(143, 106);
            this.txt_tenTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenTK.Name = "txt_tenTK";
            this.txt_tenTK.Size = new System.Drawing.Size(223, 23);
            this.txt_tenTK.TabIndex = 10;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_them.Location = new System.Drawing.Point(88, 452);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(95, 30);
            this.btn_them.TabIndex = 15;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_xoa.Location = new System.Drawing.Point(353, 452);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(95, 30);
            this.btn_xoa.TabIndex = 16;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // gvQLKH
            // 
            this.gvQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvQLKH.Location = new System.Drawing.Point(25, 232);
            this.gvQLKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvQLKH.Name = "gvQLKH";
            this.gvQLKH.RowHeadersWidth = 51;
            this.gvQLKH.RowTemplate.Height = 29;
            this.gvQLKH.Size = new System.Drawing.Size(757, 201);
            this.gvQLKH.TabIndex = 18;
            this.gvQLKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvQLKH_CellClick);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_sua.Location = new System.Drawing.Point(619, 452);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(95, 30);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_tenDN
            // 
            this.txt_tenDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenDN.Location = new System.Drawing.Point(143, 142);
            this.txt_tenDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenDN.Name = "txt_tenDN";
            this.txt_tenDN.Size = new System.Drawing.Size(223, 23);
            this.txt_tenDN.TabIndex = 20;
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Location = new System.Drawing.Point(143, 179);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(223, 23);
            this.txt_Password.TabIndex = 21;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CCCD.Location = new System.Drawing.Point(559, 142);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(223, 23);
            this.txt_CCCD.TabIndex = 22;
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Location = new System.Drawing.Point(559, 179);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(223, 23);
            this.txt_SDT.TabIndex = 23;
            // 
            // lblSoDu
            // 
            this.lblSoDu.AutoSize = true;
            this.lblSoDu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSoDu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSoDu.Location = new System.Drawing.Point(459, 67);
            this.lblSoDu.Name = "lblSoDu";
            this.lblSoDu.Size = new System.Drawing.Size(39, 15);
            this.lblSoDu.TabIndex = 24;
            this.lblSoDu.Text = "Số dư";
            // 
            // txt_SoDu
            // 
            this.txt_SoDu.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SoDu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoDu.Location = new System.Drawing.Point(559, 59);
            this.txt_SoDu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SoDu.Name = "txt_SoDu";
            this.txt_SoDu.Size = new System.Drawing.Size(223, 23);
            this.txt_SoDu.TabIndex = 25;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 497);
            this.Controls.Add(this.txt_SoDu);
            this.Controls.Add(this.lblSoDu);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_CCCD);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_tenDN);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.gvQLKH);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tenTK);
            this.Controls.Add(this.txt_soTK);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblCCCD);
            this.Controls.Add(this.txt_NgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblTenDN);
            this.Controls.Add(this.lblTenTK);
            this.Controls.Add(this.lblSoTK);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvQLKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblSoTK;
        private Label lblTenTK;
        private Label lblTenDN;
        private Label lblMK;
        private Label lblNgaySinh;
        private DateTimePicker txt_NgaySinh;
        private Label lblCCCD;
        private Label lblSDT;
        private TextBox txt_soTK;
        private TextBox txt_tenTK;
        private Button btn_them;
        private Button btn_xoa;
        private DataGridView gvQLKH;
        private Button btn_sua;
        private TextBox txt_tenDN;
        private TextBox txt_Password;
        private TextBox txt_CCCD;
        private TextBox txt_SDT;
        private Label lblSoDu;
        private TextBox txt_SoDu;
    }
}