namespace DOAN_Nhom4
{
    partial class FrmTietkiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTietkiem));
            this.pnlTietkiem = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLoaiSTK = new System.Windows.Forms.ComboBox();
            this.lblTKTK = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSotien = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnXacnhan = new CustomButton.VBButton();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTongtienlai = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLaisuat = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtTenTKTK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn18thang = new CustomButton.VBButton();
            this.label13 = new System.Windows.Forms.Label();
            this.btn12thang = new CustomButton.VBButton();
            this.btn3thang = new CustomButton.VBButton();
            this.btn1thang = new CustomButton.VBButton();
            this.btn6thang = new CustomButton.VBButton();
            this.pnlTietkiem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTietkiem
            // 
            this.pnlTietkiem.BackColor = System.Drawing.Color.White;
            this.pnlTietkiem.Controls.Add(this.label2);
            this.pnlTietkiem.Controls.Add(this.cbLoaiSTK);
            this.pnlTietkiem.Controls.Add(this.lblTKTK);
            this.pnlTietkiem.Controls.Add(this.panel1);
            this.pnlTietkiem.Controls.Add(this.panel6);
            this.pnlTietkiem.Controls.Add(this.txtTenTKTK);
            this.pnlTietkiem.Controls.Add(this.label3);
            this.pnlTietkiem.Controls.Add(this.label1);
            this.pnlTietkiem.Controls.Add(this.panel2);
            this.pnlTietkiem.Controls.Add(this.btn18thang);
            this.pnlTietkiem.Controls.Add(this.label13);
            this.pnlTietkiem.Controls.Add(this.btn12thang);
            this.pnlTietkiem.Controls.Add(this.btn3thang);
            this.pnlTietkiem.Controls.Add(this.btn1thang);
            this.pnlTietkiem.Controls.Add(this.btn6thang);
            this.pnlTietkiem.Location = new System.Drawing.Point(35, 20);
            this.pnlTietkiem.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlTietkiem.Name = "pnlTietkiem";
            this.pnlTietkiem.Size = new System.Drawing.Size(1071, 690);
            this.pnlTietkiem.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.label2.Location = new System.Drawing.Point(568, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 67;
            this.label2.Text = "Chọn loại sổ tiết kiệm";
            // 
            // cbLoaiSTK
            // 
            this.cbLoaiSTK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLoaiSTK.FormattingEnabled = true;
            this.cbLoaiSTK.Items.AddRange(new object[] {
            "Tự đóng khi đến hạn",
            "Tự chuyển tiền lãi sang tiền gốc khi đến hạn",
            "Tiếp tục được gửi với lãi suất như cũ khi đến hạn"});
            this.cbLoaiSTK.Location = new System.Drawing.Point(734, 93);
            this.cbLoaiSTK.Name = "cbLoaiSTK";
            this.cbLoaiSTK.Size = new System.Drawing.Size(302, 29);
            this.cbLoaiSTK.TabIndex = 66;
            this.cbLoaiSTK.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSTK_SelectedIndexChanged);
            // 
            // lblTKTK
            // 
            this.lblTKTK.AutoSize = true;
            this.lblTKTK.BackColor = System.Drawing.Color.White;
            this.lblTKTK.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTKTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.lblTKTK.Location = new System.Drawing.Point(814, 16);
            this.lblTKTK.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTKTK.Name = "lblTKTK";
            this.lblTKTK.Size = new System.Drawing.Size(232, 30);
            this.lblTKTK.TabIndex = 60;
            this.lblTKTK.Text = "Xem tài khoản tiết kiệm";
            this.lblTKTK.Click += new System.EventHandler(this.lblTKTK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSotien);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(33, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 63);
            this.panel1.TabIndex = 57;
            // 
            // txtSotien
            // 
            this.txtSotien.BackColor = System.Drawing.Color.White;
            this.txtSotien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSotien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSotien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.txtSotien.Location = new System.Drawing.Point(5, 15);
            this.txtSotien.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSotien.Name = "txtSotien";
            this.txtSotien.Size = new System.Drawing.Size(305, 32);
            this.txtSotien.TabIndex = 9;
            this.txtSotien.Text = "Bạn muốn gửi bao nhiêu?";
            this.txtSotien.Enter += new System.EventHandler(this.txtSotien_Enter);
            this.txtSotien.Leave += new System.EventHandler(this.txtSotien_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DOAN_Nhom4.Properties.Resources.pencil;
            this.pictureBox1.Location = new System.Drawing.Point(443, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btnXacnhan);
            this.panel6.Controls.Add(this.lblTongtien);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.lblTongtienlai);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.lblLaisuat);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Location = new System.Drawing.Point(81, 242);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(901, 447);
            this.panel6.TabIndex = 61;
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnXacnhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btnXacnhan.BorderColor = System.Drawing.Color.Teal;
            this.btnXacnhan.BorderRadius = 20;
            this.btnXacnhan.BorderSize = 0;
            this.btnXacnhan.FlatAppearance.BorderSize = 0;
            this.btnXacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacnhan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXacnhan.ForeColor = System.Drawing.Color.White;
            this.btnXacnhan.Location = new System.Drawing.Point(362, 377);
            this.btnXacnhan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(138, 55);
            this.btnXacnhan.TabIndex = 75;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.TextColor = System.Drawing.Color.White;
            this.btnXacnhan.UseVisualStyleBackColor = false;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongtien.ForeColor = System.Drawing.Color.Black;
            this.lblTongtien.Location = new System.Drawing.Point(338, 270);
            this.lblTongtien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(109, 35);
            this.lblTongtien.TabIndex = 74;
            this.lblTongtien.Text = "         -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.label6.Location = new System.Drawing.Point(261, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 32);
            this.label6.TabIndex = 73;
            this.label6.Text = "Số dư dự kiến vào ngày tới hạn";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.panel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel7.Location = new System.Drawing.Point(87, 357);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(670, 1);
            this.panel7.TabIndex = 67;
            // 
            // lblTongtienlai
            // 
            this.lblTongtienlai.AutoSize = true;
            this.lblTongtienlai.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongtienlai.ForeColor = System.Drawing.Color.Black;
            this.lblTongtienlai.Location = new System.Drawing.Point(596, 95);
            this.lblTongtienlai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongtienlai.Name = "lblTongtienlai";
            this.lblTongtienlai.Size = new System.Drawing.Size(51, 29);
            this.lblTongtienlai.TabIndex = 72;
            this.lblTongtienlai.Text = "    -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.label10.Location = new System.Drawing.Point(516, 44);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(235, 32);
            this.label10.TabIndex = 71;
            this.label10.Text = "Tổng tiền lãi dự kiến";
            // 
            // lblLaisuat
            // 
            this.lblLaisuat.AutoSize = true;
            this.lblLaisuat.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLaisuat.ForeColor = System.Drawing.Color.Black;
            this.lblLaisuat.Location = new System.Drawing.Point(228, 95);
            this.lblLaisuat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLaisuat.Name = "lblLaisuat";
            this.lblLaisuat.Size = new System.Drawing.Size(37, 29);
            this.lblLaisuat.TabIndex = 70;
            this.lblLaisuat.Text = "  -";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.panel8.Location = new System.Drawing.Point(431, 44);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 99);
            this.panel8.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.label12.Location = new System.Drawing.Point(179, 44);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 32);
            this.label12.TabIndex = 68;
            this.label12.Text = "Lãi suất năm";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.panel9.ForeColor = System.Drawing.Color.Teal;
            this.panel9.Location = new System.Drawing.Point(87, 172);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(670, 1);
            this.panel9.TabIndex = 66;
            // 
            // txtTenTKTK
            // 
            this.txtTenTKTK.BackColor = System.Drawing.Color.White;
            this.txtTenTKTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTKTK.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTenTKTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.txtTenTKTK.Location = new System.Drawing.Point(196, 14);
            this.txtTenTKTK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtTenTKTK.Multiline = true;
            this.txtTenTKTK.Name = "txtTenTKTK";
            this.txtTenTKTK.Size = new System.Drawing.Size(311, 32);
            this.txtTenTKTK.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(34, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số tiền phải là tối thiểu và chia hết cho 100.000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đặt tên TKTK:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel2.Location = new System.Drawing.Point(33, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 1);
            this.panel2.TabIndex = 5;
            // 
            // btn18thang
            // 
            this.btn18thang.BackColor = System.Drawing.Color.Transparent;
            this.btn18thang.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn18thang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn18thang.BorderRadius = 20;
            this.btn18thang.BorderSize = 2;
            this.btn18thang.FlatAppearance.BorderSize = 0;
            this.btn18thang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn18thang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn18thang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn18thang.Location = new System.Drawing.Point(800, 182);
            this.btn18thang.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn18thang.Name = "btn18thang";
            this.btn18thang.Size = new System.Drawing.Size(70, 43);
            this.btn18thang.TabIndex = 65;
            this.btn18thang.Text = "18";
            this.btn18thang.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn18thang.UseVisualStyleBackColor = false;
            this.btn18thang.Click += new System.EventHandler(this.btn18thang_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.label13.Location = new System.Drawing.Point(33, 187);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(387, 32);
            this.label13.TabIndex = 60;
            this.label13.Text = "Bạn chọn kỳ hạn bao nhiêu tháng?";
            // 
            // btn12thang
            // 
            this.btn12thang.BackColor = System.Drawing.Color.Transparent;
            this.btn12thang.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn12thang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn12thang.BorderRadius = 20;
            this.btn12thang.BorderSize = 2;
            this.btn12thang.FlatAppearance.BorderSize = 0;
            this.btn12thang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn12thang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn12thang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn12thang.Location = new System.Drawing.Point(711, 182);
            this.btn12thang.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn12thang.Name = "btn12thang";
            this.btn12thang.Size = new System.Drawing.Size(70, 43);
            this.btn12thang.TabIndex = 64;
            this.btn12thang.Text = "12";
            this.btn12thang.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn12thang.UseVisualStyleBackColor = false;
            this.btn12thang.Click += new System.EventHandler(this.btn12thang_Click);
            // 
            // btn3thang
            // 
            this.btn3thang.BackColor = System.Drawing.Color.Transparent;
            this.btn3thang.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn3thang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn3thang.BorderRadius = 20;
            this.btn3thang.BorderSize = 2;
            this.btn3thang.FlatAppearance.BorderSize = 0;
            this.btn3thang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3thang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3thang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn3thang.Location = new System.Drawing.Point(530, 182);
            this.btn3thang.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn3thang.Name = "btn3thang";
            this.btn3thang.Size = new System.Drawing.Size(70, 43);
            this.btn3thang.TabIndex = 62;
            this.btn3thang.Text = "3";
            this.btn3thang.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn3thang.UseVisualStyleBackColor = false;
            this.btn3thang.Click += new System.EventHandler(this.btn3thang_Click);
            // 
            // btn1thang
            // 
            this.btn1thang.BackColor = System.Drawing.Color.Transparent;
            this.btn1thang.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn1thang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn1thang.BorderRadius = 20;
            this.btn1thang.BorderSize = 2;
            this.btn1thang.FlatAppearance.BorderSize = 0;
            this.btn1thang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1thang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1thang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn1thang.Location = new System.Drawing.Point(443, 182);
            this.btn1thang.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn1thang.Name = "btn1thang";
            this.btn1thang.Size = new System.Drawing.Size(70, 43);
            this.btn1thang.TabIndex = 61;
            this.btn1thang.Text = "1";
            this.btn1thang.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn1thang.UseVisualStyleBackColor = false;
            this.btn1thang.Click += new System.EventHandler(this.btn1thang_Click);
            // 
            // btn6thang
            // 
            this.btn6thang.BackColor = System.Drawing.Color.Transparent;
            this.btn6thang.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn6thang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn6thang.BorderRadius = 20;
            this.btn6thang.BorderSize = 2;
            this.btn6thang.FlatAppearance.BorderSize = 0;
            this.btn6thang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6thang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6thang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn6thang.Location = new System.Drawing.Point(621, 182);
            this.btn6thang.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn6thang.Name = "btn6thang";
            this.btn6thang.Size = new System.Drawing.Size(70, 43);
            this.btn6thang.TabIndex = 63;
            this.btn6thang.Text = "6";
            this.btn6thang.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(69)))), ((int)(((byte)(158)))));
            this.btn6thang.UseVisualStyleBackColor = false;
            this.btn6thang.Click += new System.EventHandler(this.btn6thang_Click);
            // 
            // FrmTietkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 720);
            this.Controls.Add(this.pnlTietkiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTietkiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tiết kiệm";
            this.Load += new System.EventHandler(this.FrmTietkiem_Load);
            this.pnlTietkiem.ResumeLayout(false);
            this.pnlTietkiem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlTietkiem;
        private Label lblTKTK;
        private TextBox txtTenTKTK;
        private Panel panel1;
        private TextBox txtSotien;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private Panel panel6;
        private CustomButton.VBButton btnXacnhan;
        private Label lblTongtien;
        private Label label6;
        private Panel panel7;
        private Label lblTongtienlai;
        private Label label10;
        private Label lblLaisuat;
        private Panel panel8;
        private Label label12;
        private Panel panel9;
        private CustomButton.VBButton btn18thang;
        private CustomButton.VBButton btn12thang;
        private CustomButton.VBButton btn6thang;
        private CustomButton.VBButton btn3thang;
        private CustomButton.VBButton btn1thang;
        private Label label13;
        private Label label2;
        private ComboBox cbLoaiSTK;
    }
}