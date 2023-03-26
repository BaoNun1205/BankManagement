namespace DOAN_Nhom4
{
    partial class FrmChuyentien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChuyentien));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new CustomButton.VBButton();
            this.btnTieptuc = new CustomButton.VBButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTenNH = new System.Windows.Forms.ComboBox();
            this.txtLoiNhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlChuyentien = new System.Windows.Forms.Panel();
            this.lblTenTKhoan = new System.Windows.Forms.Label();
            this.lblSoDuString = new System.Windows.Forms.Label();
            this.lblSoDu = new System.Windows.Forms.Label();
            this.lblTenTK = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTrangchu = new CustomButton.VBButton();
            this.btnCaidat = new CustomButton.VBButton();
            this.btnHotro = new CustomButton.VBButton();
            this.btnTienich = new CustomButton.VBButton();
            this.btnTietkiem = new CustomButton.VBButton();
            this.btnChuyentien = new CustomButton.VBButton();
            this.btnTaikhoan = new CustomButton.VBButton();
            this.pnlChuyentien.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(14, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 43);
            this.label1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHuy.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnHuy.BorderRadius = 0;
            this.btnHuy.BorderSize = 3;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnHuy.Location = new System.Drawing.Point(137, 960);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(198, 105);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.DarkCyan;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTieptuc
            // 
            this.btnTieptuc.BackColor = System.Drawing.Color.Transparent;
            this.btnTieptuc.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTieptuc.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnTieptuc.BorderRadius = 0;
            this.btnTieptuc.BorderSize = 3;
            this.btnTieptuc.FlatAppearance.BorderSize = 0;
            this.btnTieptuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTieptuc.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTieptuc.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnTieptuc.Location = new System.Drawing.Point(592, 960);
            this.btnTieptuc.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTieptuc.Name = "btnTieptuc";
            this.btnTieptuc.Size = new System.Drawing.Size(198, 105);
            this.btnTieptuc.TabIndex = 23;
            this.btnTieptuc.Text = "Tiếp tục";
            this.btnTieptuc.TextColor = System.Drawing.Color.DarkCyan;
            this.btnTieptuc.UseVisualStyleBackColor = false;
            this.btnTieptuc.Click += new System.EventHandler(this.btnTieptuc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(55, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên ngân hàng";
            // 
            // cbTenNH
            // 
            this.cbTenNH.BackColor = System.Drawing.Color.White;
            this.cbTenNH.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTenNH.ForeColor = System.Drawing.Color.Black;
            this.cbTenNH.FormattingEnabled = true;
            this.cbTenNH.Items.AddRange(new object[] {
            "HHB",
            "ACB",
            "Agribank",
            "BIDV",
            "Đông Á Bank",
            "Eximbank",
            "HDBank",
            "MBBank",
            "OCB",
            "Sacombank",
            "SHB",
            "TPBank",
            "Vietcombank",
            "VietinBank",
            "VietCapital Bank"});
            this.cbTenNH.Location = new System.Drawing.Point(489, 44);
            this.cbTenNH.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbTenNH.Name = "cbTenNH";
            this.cbTenNH.Size = new System.Drawing.Size(404, 62);
            this.cbTenNH.TabIndex = 2;
            this.cbTenNH.TextChanged += new System.EventHandler(this.cbTenNH_TextChanged);
            // 
            // txtLoiNhan
            // 
            this.txtLoiNhan.BackColor = System.Drawing.Color.White;
            this.txtLoiNhan.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLoiNhan.ForeColor = System.Drawing.Color.Black;
            this.txtLoiNhan.Location = new System.Drawing.Point(379, 587);
            this.txtLoiNhan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtLoiNhan.Multiline = true;
            this.txtLoiNhan.Name = "txtLoiNhan";
            this.txtLoiNhan.Size = new System.Drawing.Size(514, 313);
            this.txtLoiNhan.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(55, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 48);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(55, 587);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lời nhắn (nếu có)";
            // 
            // txtSTK
            // 
            this.txtSTK.BackColor = System.Drawing.Color.White;
            this.txtSTK.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSTK.ForeColor = System.Drawing.Color.Black;
            this.txtSTK.Location = new System.Drawing.Point(489, 187);
            this.txtSTK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSTK.Multiline = true;
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(404, 68);
            this.txtSTK.TabIndex = 6;
            this.txtSTK.TextChanged += new System.EventHandler(this.txtSTK_TextChanged);
            // 
            // txtSoTien
            // 
            this.txtSoTien.BackColor = System.Drawing.Color.White;
            this.txtSoTien.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoTien.ForeColor = System.Drawing.Color.Black;
            this.txtSoTien.Location = new System.Drawing.Point(489, 365);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSoTien.Multiline = true;
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(404, 68);
            this.txtSoTien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(55, 383);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 48);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số tiền";
            // 
            // pnlChuyentien
            // 
            this.pnlChuyentien.BackColor = System.Drawing.Color.White;
            this.pnlChuyentien.Controls.Add(this.lblTenTKhoan);
            this.pnlChuyentien.Controls.Add(this.lblSoDuString);
            this.pnlChuyentien.Controls.Add(this.lblSoDu);
            this.pnlChuyentien.Controls.Add(this.lblTenTK);
            this.pnlChuyentien.Controls.Add(this.btnHuy);
            this.pnlChuyentien.Controls.Add(this.txtSoTien);
            this.pnlChuyentien.Controls.Add(this.txtSTK);
            this.pnlChuyentien.Controls.Add(this.btnTieptuc);
            this.pnlChuyentien.Controls.Add(this.label2);
            this.pnlChuyentien.Controls.Add(this.cbTenNH);
            this.pnlChuyentien.Controls.Add(this.txtLoiNhan);
            this.pnlChuyentien.Controls.Add(this.label3);
            this.pnlChuyentien.Controls.Add(this.label4);
            this.pnlChuyentien.Controls.Add(this.label5);
            this.pnlChuyentien.Location = new System.Drawing.Point(719, 37);
            this.pnlChuyentien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlChuyentien.Name = "pnlChuyentien";
            this.pnlChuyentien.Size = new System.Drawing.Size(931, 1129);
            this.pnlChuyentien.TabIndex = 11;
            // 
            // lblTenTKhoan
            // 
            this.lblTenTKhoan.AutoSize = true;
            this.lblTenTKhoan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenTKhoan.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblTenTKhoan.Location = new System.Drawing.Point(489, 271);
            this.lblTenTKhoan.Name = "lblTenTKhoan";
            this.lblTenTKhoan.Size = new System.Drawing.Size(30, 41);
            this.lblTenTKhoan.TabIndex = 28;
            this.lblTenTKhoan.Text = "-";
            // 
            // lblSoDuString
            // 
            this.lblSoDuString.AutoSize = true;
            this.lblSoDuString.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoDuString.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSoDuString.Location = new System.Drawing.Point(489, 464);
            this.lblSoDuString.Name = "lblSoDuString";
            this.lblSoDuString.Size = new System.Drawing.Size(111, 41);
            this.lblSoDuString.TabIndex = 27;
            this.lblSoDuString.Text = "Số dư: ";
            // 
            // lblSoDu
            // 
            this.lblSoDu.AutoSize = true;
            this.lblSoDu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoDu.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblSoDu.Location = new System.Drawing.Point(610, 464);
            this.lblSoDu.Name = "lblSoDu";
            this.lblSoDu.Size = new System.Drawing.Size(38, 41);
            this.lblSoDu.TabIndex = 26;
            this.lblSoDu.Text = " -";
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTenTK.Location = new System.Drawing.Point(279, 152);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(13, 20);
            this.lblTenTK.TabIndex = 25;
            this.lblTenTK.Text = " ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.btnTrangchu);
            this.panel2.Controls.Add(this.btnCaidat);
            this.panel2.Controls.Add(this.btnHotro);
            this.panel2.Controls.Add(this.btnTienich);
            this.panel2.Controls.Add(this.btnTietkiem);
            this.panel2.Controls.Add(this.btnChuyentien);
            this.panel2.Controls.Add(this.btnTaikhoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 981);
            this.panel2.TabIndex = 58;
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTrangchu.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnTrangchu.BorderColor = System.Drawing.Color.Transparent;
            this.btnTrangchu.BorderRadius = 0;
            this.btnTrangchu.BorderSize = 2;
            this.btnTrangchu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangchu.FlatAppearance.BorderSize = 0;
            this.btnTrangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangchu.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTrangchu.ForeColor = System.Drawing.Color.White;
            this.btnTrangchu.Image = global::DOAN_Nhom4.Properties.Resources.home1;
            this.btnTrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangchu.Location = new System.Drawing.Point(2, 1);
            this.btnTrangchu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnTrangchu.Size = new System.Drawing.Size(376, 147);
            this.btnTrangchu.TabIndex = 42;
            this.btnTrangchu.Text = "       Trang chủ";
            this.btnTrangchu.TextColor = System.Drawing.Color.White;
            this.btnTrangchu.UseVisualStyleBackColor = false;
            this.btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
            // 
            // btnCaidat
            // 
            this.btnCaidat.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCaidat.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnCaidat.BorderColor = System.Drawing.Color.Transparent;
            this.btnCaidat.BorderRadius = 0;
            this.btnCaidat.BorderSize = 2;
            this.btnCaidat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaidat.FlatAppearance.BorderSize = 0;
            this.btnCaidat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaidat.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCaidat.ForeColor = System.Drawing.Color.White;
            this.btnCaidat.Image = global::DOAN_Nhom4.Properties.Resources.settings2;
            this.btnCaidat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaidat.Location = new System.Drawing.Point(0, 1228);
            this.btnCaidat.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCaidat.Name = "btnCaidat";
            this.btnCaidat.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnCaidat.Size = new System.Drawing.Size(378, 137);
            this.btnCaidat.TabIndex = 41;
            this.btnCaidat.Text = " Cài đặt";
            this.btnCaidat.TextColor = System.Drawing.Color.White;
            this.btnCaidat.UseVisualStyleBackColor = false;
            // 
            // btnHotro
            // 
            this.btnHotro.BackColor = System.Drawing.Color.DarkCyan;
            this.btnHotro.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnHotro.BorderColor = System.Drawing.Color.Transparent;
            this.btnHotro.BorderRadius = 0;
            this.btnHotro.BorderSize = 2;
            this.btnHotro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotro.FlatAppearance.BorderSize = 0;
            this.btnHotro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotro.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHotro.ForeColor = System.Drawing.Color.White;
            this.btnHotro.Image = global::DOAN_Nhom4.Properties.Resources.customer_support1;
            this.btnHotro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotro.Location = new System.Drawing.Point(2, 739);
            this.btnHotro.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnHotro.Name = "btnHotro";
            this.btnHotro.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnHotro.Size = new System.Drawing.Size(374, 137);
            this.btnHotro.TabIndex = 39;
            this.btnHotro.Text = " Hỗ trợ";
            this.btnHotro.TextColor = System.Drawing.Color.White;
            this.btnHotro.UseVisualStyleBackColor = false;
            // 
            // btnTienich
            // 
            this.btnTienich.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTienich.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnTienich.BorderColor = System.Drawing.Color.Transparent;
            this.btnTienich.BorderRadius = 0;
            this.btnTienich.BorderSize = 2;
            this.btnTienich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTienich.FlatAppearance.BorderSize = 0;
            this.btnTienich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienich.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTienich.ForeColor = System.Drawing.Color.White;
            this.btnTienich.Image = global::DOAN_Nhom4.Properties.Resources.payments1;
            this.btnTienich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTienich.Location = new System.Drawing.Point(2, 599);
            this.btnTienich.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTienich.Name = "btnTienich";
            this.btnTienich.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnTienich.Size = new System.Drawing.Size(374, 137);
            this.btnTienich.TabIndex = 37;
            this.btnTienich.Text = "   Tiện ích";
            this.btnTienich.TextColor = System.Drawing.Color.White;
            this.btnTienich.UseVisualStyleBackColor = false;
            // 
            // btnTietkiem
            // 
            this.btnTietkiem.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTietkiem.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnTietkiem.BorderColor = System.Drawing.Color.Transparent;
            this.btnTietkiem.BorderRadius = 0;
            this.btnTietkiem.BorderSize = 2;
            this.btnTietkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTietkiem.FlatAppearance.BorderSize = 0;
            this.btnTietkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTietkiem.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTietkiem.ForeColor = System.Drawing.Color.White;
            this.btnTietkiem.Image = global::DOAN_Nhom4.Properties.Resources.piggy_bank1;
            this.btnTietkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTietkiem.Location = new System.Drawing.Point(2, 449);
            this.btnTietkiem.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTietkiem.Name = "btnTietkiem";
            this.btnTietkiem.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnTietkiem.Size = new System.Drawing.Size(374, 147);
            this.btnTietkiem.TabIndex = 35;
            this.btnTietkiem.Text = "     Tiết kiệm";
            this.btnTietkiem.TextColor = System.Drawing.Color.White;
            this.btnTietkiem.UseVisualStyleBackColor = false;
            this.btnTietkiem.Click += new System.EventHandler(this.btnTietkiem_Click);
            // 
            // btnChuyentien
            // 
            this.btnChuyentien.BackColor = System.Drawing.Color.DarkCyan;
            this.btnChuyentien.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnChuyentien.BorderColor = System.Drawing.Color.Transparent;
            this.btnChuyentien.BorderRadius = 0;
            this.btnChuyentien.BorderSize = 2;
            this.btnChuyentien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuyentien.FlatAppearance.BorderSize = 0;
            this.btnChuyentien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyentien.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChuyentien.ForeColor = System.Drawing.Color.White;
            this.btnChuyentien.Image = global::DOAN_Nhom4.Properties.Resources.transfer;
            this.btnChuyentien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyentien.Location = new System.Drawing.Point(2, 300);
            this.btnChuyentien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnChuyentien.Name = "btnChuyentien";
            this.btnChuyentien.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnChuyentien.Size = new System.Drawing.Size(376, 147);
            this.btnChuyentien.TabIndex = 33;
            this.btnChuyentien.Text = "         Chuyển tiền";
            this.btnChuyentien.TextColor = System.Drawing.Color.White;
            this.btnChuyentien.UseVisualStyleBackColor = false;
            // 
            // btnTaikhoan
            // 
            this.btnTaikhoan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnTaikhoan.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.btnTaikhoan.BorderColor = System.Drawing.Color.Transparent;
            this.btnTaikhoan.BorderRadius = 0;
            this.btnTaikhoan.BorderSize = 2;
            this.btnTaikhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaikhoan.FlatAppearance.BorderSize = 0;
            this.btnTaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaikhoan.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTaikhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaikhoan.Image = global::DOAN_Nhom4.Properties.Resources.user5;
            this.btnTaikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaikhoan.Location = new System.Drawing.Point(2, 151);
            this.btnTaikhoan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTaikhoan.Name = "btnTaikhoan";
            this.btnTaikhoan.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnTaikhoan.Size = new System.Drawing.Size(376, 147);
            this.btnTaikhoan.TabIndex = 31;
            this.btnTaikhoan.Text = "      Tài khoản";
            this.btnTaikhoan.TextColor = System.Drawing.Color.White;
            this.btnTaikhoan.UseVisualStyleBackColor = false;
            this.btnTaikhoan.Click += new System.EventHandler(this.btnTaikhoan_Click);
            // 
            // FrmChuyentien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1909, 981);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChuyentien);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChuyentien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển tiền";
            this.Load += new System.EventHandler(this.FrmChuyentien_Load);
            this.pnlChuyentien.ResumeLayout(false);
            this.pnlChuyentien.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbTenNH;
        private TextBox txtLoiNhan;
        private Label label3;
        private Label label4;
        private TextBox txtSTK;
        private Label label5;
        private TextBox txtSoTien;
        private CustomButton.VBButton btnHuy;
        private CustomButton.VBButton btnTieptuc;
        private Panel pnlChuyentien;
        private Label lblTenTK;
        private Label lblSoDu;
        private Label lblSoDuString;
        private Panel panel2;
        private CustomButton.VBButton btnTrangchu;
        private CustomButton.VBButton btnCaidat;
        private CustomButton.VBButton btnHotro;
        private CustomButton.VBButton btnTienich;
        private CustomButton.VBButton btnTietkiem;
        private CustomButton.VBButton btnChuyentien;
        private CustomButton.VBButton btnTaikhoan;
        private Label lblTenTKhoan;
    }
}