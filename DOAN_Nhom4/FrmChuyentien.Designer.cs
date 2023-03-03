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
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxQuaylai = new System.Windows.Forms.PictureBox();
            this.pnlChuyentien = new System.Windows.Forms.Panel();
            this.btnTieptuc = new CustomButton.VBButton();
            this.btnHuy = new CustomButton.VBButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picBoxChuyentien = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuaylai)).BeginInit();
            this.pnlChuyentien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChuyentien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(22, 627);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 69);
            this.label1.TabIndex = 0;
            // 
            // picBoxQuaylai
            // 
            this.picBoxQuaylai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxQuaylai.Image = global::DOAN_Nhom4.Properties.Resources.left_arrow;
            this.picBoxQuaylai.Location = new System.Drawing.Point(34, 22);
            this.picBoxQuaylai.Name = "picBoxQuaylai";
            this.picBoxQuaylai.Size = new System.Drawing.Size(102, 109);
            this.picBoxQuaylai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxQuaylai.TabIndex = 10;
            this.picBoxQuaylai.TabStop = false;
            this.picBoxQuaylai.Click += new System.EventHandler(this.picBoxQuaylai_Click);
            // 
            // pnlChuyentien
            // 
            this.pnlChuyentien.BackColor = System.Drawing.Color.DimGray;
            this.pnlChuyentien.Controls.Add(this.btnTieptuc);
            this.pnlChuyentien.Controls.Add(this.btnHuy);
            this.pnlChuyentien.Controls.Add(this.label2);
            this.pnlChuyentien.Controls.Add(this.comboBox1);
            this.pnlChuyentien.Controls.Add(this.textBox3);
            this.pnlChuyentien.Controls.Add(this.label3);
            this.pnlChuyentien.Controls.Add(this.label4);
            this.pnlChuyentien.Controls.Add(this.textBox1);
            this.pnlChuyentien.Controls.Add(this.textBox2);
            this.pnlChuyentien.Controls.Add(this.label5);
            this.pnlChuyentien.Location = new System.Drawing.Point(97, 168);
            this.pnlChuyentien.Name = "pnlChuyentien";
            this.pnlChuyentien.Size = new System.Drawing.Size(814, 770);
            this.pnlChuyentien.TabIndex = 9;
            // 
            // btnTieptuc
            // 
            this.btnTieptuc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTieptuc.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.btnTieptuc.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTieptuc.BorderRadius = 40;
            this.btnTieptuc.BorderSize = 0;
            this.btnTieptuc.FlatAppearance.BorderSize = 0;
            this.btnTieptuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTieptuc.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTieptuc.ForeColor = System.Drawing.Color.White;
            this.btnTieptuc.Location = new System.Drawing.Point(452, 584);
            this.btnTieptuc.Name = "btnTieptuc";
            this.btnTieptuc.Size = new System.Drawing.Size(248, 80);
            this.btnTieptuc.TabIndex = 13;
            this.btnTieptuc.Text = "Tiếp tục";
            this.btnTieptuc.TextColor = System.Drawing.Color.White;
            this.btnTieptuc.UseVisualStyleBackColor = false;
            this.btnTieptuc.Click += new System.EventHandler(this.btnTieptuc_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHuy.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.btnHuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuy.BorderRadius = 40;
            this.btnHuy.BorderSize = 0;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(74, 584);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(248, 80);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.White;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên ngân hàng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nội bộ HHB Bank",
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
            this.comboBox1.Location = new System.Drawing.Point(425, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 40);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(425, 376);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(307, 146);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 45);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lời nhắn (nếu có)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(425, 165);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 45);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(425, 271);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 45);
            this.textBox2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số tiền";
            // 
            // picBoxChuyentien
            // 
            this.picBoxChuyentien.Image = global::DOAN_Nhom4.Properties.Resources.pexels_johannes_plenio_1632788;
            this.picBoxChuyentien.Location = new System.Drawing.Point(-3, 0);
            this.picBoxChuyentien.Name = "picBoxChuyentien";
            this.picBoxChuyentien.Size = new System.Drawing.Size(1012, 1014);
            this.picBoxChuyentien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxChuyentien.TabIndex = 8;
            this.picBoxChuyentien.TabStop = false;
            // 
            // FrmChuyentien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 997);
            this.Controls.Add(this.picBoxQuaylai);
            this.Controls.Add(this.pnlChuyentien);
            this.Controls.Add(this.picBoxChuyentien);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FrmChuyentien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChuyentien";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQuaylai)).EndInit();
            this.pnlChuyentien.ResumeLayout(false);
            this.pnlChuyentien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxChuyentien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox picBoxQuaylai;
        private Panel pnlChuyentien;
        private CustomButton.VBButton btnTieptuc;
        private CustomButton.VBButton btnHuy;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private PictureBox picBoxChuyentien;
    }
}