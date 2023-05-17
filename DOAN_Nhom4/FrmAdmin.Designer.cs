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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SoTK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenTK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SoDu = new System.Windows.Forms.TextBox();
            this.gvQLKH = new System.Windows.Forms.DataGridView();
            this.txt_NgayDangKyThe = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.btn_Them = new CustomButton.VBButton();
            this.btn_Xoa = new CustomButton.VBButton();
            this.btn_Sua = new CustomButton.VBButton();
            this.btn_Refersh = new CustomButton.VBButton();
            this.btn_DV = new CustomButton.VBButton();
            this.btn_DangXuat = new CustomButton.VBButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1645, 107);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(532, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ NGÂN HÀNG";
            // 
            // txt_TenDN
            // 
            this.txt_TenDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenDN.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenDN.ForeColor = System.Drawing.Color.Black;
            this.txt_TenDN.Location = new System.Drawing.Point(36, 156);
            this.txt_TenDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenDN.Name = "txt_TenDN";
            this.txt_TenDN.Size = new System.Drawing.Size(256, 29);
            this.txt_TenDN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Đăng Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(36, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mật Khẩu";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MatKhau.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MatKhau.ForeColor = System.Drawing.Color.Black;
            this.txt_MatKhau.Location = new System.Drawing.Point(36, 216);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(256, 29);
            this.txt_MatKhau.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(36, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số Tài Khoản";
            // 
            // txt_SoTK
            // 
            this.txt_SoTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoTK.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SoTK.ForeColor = System.Drawing.Color.Black;
            this.txt_SoTK.Location = new System.Drawing.Point(36, 275);
            this.txt_SoTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SoTK.Name = "txt_SoTK";
            this.txt_SoTK.Size = new System.Drawing.Size(256, 29);
            this.txt_SoTK.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(35, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên Tài Khoản";
            // 
            // txt_TenTK
            // 
            this.txt_TenTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenTK.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenTK.ForeColor = System.Drawing.Color.Black;
            this.txt_TenTK.Location = new System.Drawing.Point(36, 334);
            this.txt_TenTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenTK.Name = "txt_TenTK";
            this.txt_TenTK.Size = new System.Drawing.Size(256, 29);
            this.txt_TenTK.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(37, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Căn Cước Công Dân";
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CCCD.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CCCD.ForeColor = System.Drawing.Color.Black;
            this.txt_CCCD.Location = new System.Drawing.Point(37, 461);
            this.txt_CCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(255, 29);
            this.txt_CCCD.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(37, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Số Điện Thoại";
            // 
            // txt_SDT
            // 
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SDT.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SDT.ForeColor = System.Drawing.Color.Black;
            this.txt_SDT.Location = new System.Drawing.Point(37, 526);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(255, 29);
            this.txt_SDT.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(37, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ngày Sinh";
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.CustomFormat = "MM/dd/yyyy";
            this.txt_NgaySinh.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_NgaySinh.Location = new System.Drawing.Point(37, 397);
            this.txt_NgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(255, 29);
            this.txt_NgaySinh.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(37, 625);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Số Dư";
            // 
            // txt_SoDu
            // 
            this.txt_SoDu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SoDu.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SoDu.ForeColor = System.Drawing.Color.Black;
            this.txt_SoDu.Location = new System.Drawing.Point(37, 647);
            this.txt_SoDu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SoDu.Name = "txt_SoDu";
            this.txt_SoDu.Size = new System.Drawing.Size(255, 29);
            this.txt_SoDu.TabIndex = 19;
            // 
            // gvQLKH
            // 
            this.gvQLKH.AllowUserToAddRows = false;
            this.gvQLKH.AllowUserToResizeRows = false;
            this.gvQLKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvQLKH.BackgroundColor = System.Drawing.Color.White;
            this.gvQLKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvQLKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvQLKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvQLKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvQLKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvQLKH.EnableHeadersVisualStyles = false;
            this.gvQLKH.GridColor = System.Drawing.Color.LightSlateGray;
            this.gvQLKH.Location = new System.Drawing.Point(329, 156);
            this.gvQLKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvQLKH.Name = "gvQLKH";
            this.gvQLKH.RowHeadersVisible = false;
            this.gvQLKH.RowHeadersWidth = 51;
            this.gvQLKH.RowTemplate.Height = 40;
            this.gvQLKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvQLKH.Size = new System.Drawing.Size(1279, 584);
            this.gvQLKH.TabIndex = 21;
            this.gvQLKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvQLKH_CellClick);
            // 
            // txt_NgayDangKyThe
            // 
            this.txt_NgayDangKyThe.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NgayDangKyThe.CustomFormat = "MM/dd/yyyy";
            this.txt_NgayDangKyThe.Enabled = false;
            this.txt_NgayDangKyThe.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NgayDangKyThe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_NgayDangKyThe.Location = new System.Drawing.Point(37, 711);
            this.txt_NgayDangKyThe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NgayDangKyThe.Name = "txt_NgayDangKyThe";
            this.txt_NgayDangKyThe.Size = new System.Drawing.Size(255, 29);
            this.txt_NgayDangKyThe.TabIndex = 23;
            this.txt_NgayDangKyThe.Value = new System.DateTime(2023, 4, 11, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(37, 690);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ngày Đăng Ký Thẻ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.SteelBlue;
            this.label12.Location = new System.Drawing.Point(37, 562);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 22);
            this.label12.TabIndex = 25;
            this.label12.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Email.ForeColor = System.Drawing.Color.Black;
            this.txt_Email.Location = new System.Drawing.Point(37, 585);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(255, 29);
            this.txt_Email.TabIndex = 24;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Them.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_Them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Them.BorderRadius = 0;
            this.btn_Them.BorderSize = 0;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(329, 761);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(127, 45);
            this.btn_Them.TabIndex = 26;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Xoa.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_Xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Xoa.BorderRadius = 0;
            this.btn_Xoa.BorderSize = 0;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(462, 761);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(127, 45);
            this.btn_Xoa.TabIndex = 27;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Sua.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_Sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Sua.BorderRadius = 0;
            this.btn_Sua.BorderSize = 0;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(595, 761);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(127, 45);
            this.btn_Sua.TabIndex = 28;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextColor = System.Drawing.Color.White;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Refersh
            // 
            this.btn_Refersh.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Refersh.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.btn_Refersh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Refersh.BorderRadius = 0;
            this.btn_Refersh.BorderSize = 0;
            this.btn_Refersh.FlatAppearance.BorderSize = 0;
            this.btn_Refersh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refersh.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Refersh.ForeColor = System.Drawing.Color.White;
            this.btn_Refersh.Location = new System.Drawing.Point(728, 761);
            this.btn_Refersh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refersh.Name = "btn_Refersh";
            this.btn_Refersh.Size = new System.Drawing.Size(127, 45);
            this.btn_Refersh.TabIndex = 31;
            this.btn_Refersh.Text = "Làm mới";
            this.btn_Refersh.TextColor = System.Drawing.Color.White;
            this.btn_Refersh.UseVisualStyleBackColor = false;
            this.btn_Refersh.Click += new System.EventHandler(this.btn_Refersh_Click);
            // 
            // btn_DV
            // 
            this.btn_DV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_DV.BorderRadius = 0;
            this.btn_DV.BorderSize = 0;
            this.btn_DV.FlatAppearance.BorderSize = 0;
            this.btn_DV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DV.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_DV.Location = new System.Drawing.Point(1388, 761);
            this.btn_DV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DV.Name = "btn_DV";
            this.btn_DV.Size = new System.Drawing.Size(220, 45);
            this.btn_DV.TabIndex = 32;
            this.btn_DV.Text = "Dịch Vụ";
            this.btn_DV.TextColor = System.Drawing.SystemColors.Highlight;
            this.btn_DV.UseVisualStyleBackColor = false;
            this.btn_DV.Click += new System.EventHandler(this.btn_DV_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DangXuat.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.btn_DangXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_DangXuat.BorderRadius = 0;
            this.btn_DangXuat.BorderSize = 0;
            this.btn_DangXuat.FlatAppearance.BorderSize = 0;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DangXuat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_DangXuat.Location = new System.Drawing.Point(1514, 761);
            this.btn_DangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(220, 45);
            this.btn_DangXuat.TabIndex = 33;
            this.btn_DangXuat.Text = "Đăng xuất";
            this.btn_DangXuat.TextColor = System.Drawing.SystemColors.Highlight;
            this.btn_DangXuat.UseVisualStyleBackColor = false;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1645, 834);
            this.Controls.Add(this.btn_DV);
            this.Controls.Add(this.btn_Refersh);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_NgayDangKyThe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gvQLKH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_SoDu);
            this.Controls.Add(this.txt_NgaySinh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CCCD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TenTK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_SoTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenDN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvQLKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txt_TenDN;
        private Label label3;
        private Label label4;
        private TextBox txt_MatKhau;
        private Label label5;
        private TextBox txt_SoTK;
        private Label label6;
        private TextBox txt_TenTK;
        private Label label7;
        private TextBox txt_CCCD;
        private Label label8;
        private TextBox txt_SDT;
        private Label label9;
        private DateTimePicker txt_NgaySinh;
        private Label label10;
        private TextBox txt_SoDu;
        private DataGridView gvQLKH;
        private DateTimePicker txt_NgayDangKyThe;
        private Label label11;
        private Label label12;
        private TextBox txt_Email;
        private CustomButton.VBButton btn_Them;
        private CustomButton.VBButton btn_Xoa;
        private CustomButton.VBButton btn_Sua;
        private CustomButton.VBButton btn_Refersh;
        private CustomButton.VBButton btn_DV;
        private CustomButton.VBButton btn_DangXuat;
    }
}