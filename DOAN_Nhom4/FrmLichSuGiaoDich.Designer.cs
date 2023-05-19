namespace DOAN_Nhom4
{
    partial class FrmLichSuGiaoDich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThongke = new CustomButton.VBButton();
            this.GvTongGui = new System.Windows.Forms.DataGridView();
            this.GvTongNhan = new System.Windows.Forms.DataGridView();
            this.GvLSGD = new System.Windows.Forms.DataGridView();
            this.btnTienRa = new CustomButton.VBButton();
            this.btnTienVao = new CustomButton.VBButton();
            this.btnToanBo = new CustomButton.VBButton();
            this.btnXuatExcel = new CustomButton.VBButton();
            this.cmNgay = new System.Windows.Forms.ComboBox();
            this.vbButton1 = new CustomButton.VBButton();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvTongGui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvTongNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvLSGD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Controls.Add(this.GvTongGui);
            this.panel1.Controls.Add(this.GvTongNhan);
            this.panel1.Controls.Add(this.GvLSGD);
            this.panel1.Controls.Add(this.btnTienRa);
            this.panel1.Controls.Add(this.btnTienVao);
            this.panel1.Controls.Add(this.btnToanBo);
            this.panel1.Controls.Add(this.btnXuatExcel);
            this.panel1.Controls.Add(this.cmNgay);
            this.panel1.Controls.Add(this.vbButton1);
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Location = new System.Drawing.Point(33, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 656);
            this.panel1.TabIndex = 1;
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnThongke.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnThongke.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThongke.BorderRadius = 0;
            this.btnThongke.BorderSize = 0;
            this.btnThongke.FlatAppearance.BorderSize = 0;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.Location = new System.Drawing.Point(541, 136);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(532, 38);
            this.btnThongke.TabIndex = 61;
            this.btnThongke.Text = "Thống kê chi tiết";
            this.btnThongke.TextColor = System.Drawing.Color.White;
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            this.btnThongke.MouseEnter += new System.EventHandler(this.btnThongke_MouseEnter);
            this.btnThongke.MouseLeave += new System.EventHandler(this.btnThongke_MouseLeave);
            // 
            // GvTongGui
            // 
            this.GvTongGui.AllowUserToAddRows = false;
            this.GvTongGui.AllowUserToResizeRows = false;
            this.GvTongGui.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvTongGui.BackgroundColor = System.Drawing.Color.White;
            this.GvTongGui.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GvTongGui.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GvTongGui.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvTongGui.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.GvTongGui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvTongGui.DefaultCellStyle = dataGridViewCellStyle8;
            this.GvTongGui.EnableHeadersVisualStyles = false;
            this.GvTongGui.GridColor = System.Drawing.Color.LightSlateGray;
            this.GvTongGui.Location = new System.Drawing.Point(3, 454);
            this.GvTongGui.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GvTongGui.Name = "GvTongGui";
            this.GvTongGui.RowHeadersVisible = false;
            this.GvTongGui.RowHeadersWidth = 82;
            this.GvTongGui.RowTemplate.Height = 40;
            this.GvTongGui.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvTongGui.Size = new System.Drawing.Size(1070, 201);
            this.GvTongGui.TabIndex = 59;
            // 
            // GvTongNhan
            // 
            this.GvTongNhan.AllowUserToAddRows = false;
            this.GvTongNhan.AllowUserToResizeRows = false;
            this.GvTongNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvTongNhan.BackgroundColor = System.Drawing.Color.White;
            this.GvTongNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GvTongNhan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GvTongNhan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvTongNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.GvTongNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvTongNhan.DefaultCellStyle = dataGridViewCellStyle10;
            this.GvTongNhan.EnableHeadersVisualStyles = false;
            this.GvTongNhan.GridColor = System.Drawing.Color.LightSlateGray;
            this.GvTongNhan.Location = new System.Drawing.Point(2, 251);
            this.GvTongNhan.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GvTongNhan.Name = "GvTongNhan";
            this.GvTongNhan.RowHeadersVisible = false;
            this.GvTongNhan.RowHeadersWidth = 82;
            this.GvTongNhan.RowTemplate.Height = 40;
            this.GvTongNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvTongNhan.Size = new System.Drawing.Size(1070, 201);
            this.GvTongNhan.TabIndex = 58;
            // 
            // GvLSGD
            // 
            this.GvLSGD.AllowUserToAddRows = false;
            this.GvLSGD.AllowUserToResizeRows = false;
            this.GvLSGD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GvLSGD.BackgroundColor = System.Drawing.Color.White;
            this.GvLSGD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GvLSGD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GvLSGD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(23)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvLSGD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.GvLSGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvLSGD.DefaultCellStyle = dataGridViewCellStyle12;
            this.GvLSGD.EnableHeadersVisualStyles = false;
            this.GvLSGD.GridColor = System.Drawing.Color.LightSlateGray;
            this.GvLSGD.Location = new System.Drawing.Point(3, 251);
            this.GvLSGD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GvLSGD.Name = "GvLSGD";
            this.GvLSGD.RowHeadersVisible = false;
            this.GvLSGD.RowHeadersWidth = 51;
            this.GvLSGD.RowTemplate.Height = 40;
            this.GvLSGD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvLSGD.Size = new System.Drawing.Size(1070, 403);
            this.GvLSGD.TabIndex = 39;
            // 
            // btnTienRa
            // 
            this.btnTienRa.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTienRa.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnTienRa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTienRa.BorderRadius = 0;
            this.btnTienRa.BorderSize = 0;
            this.btnTienRa.FlatAppearance.BorderSize = 0;
            this.btnTienRa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienRa.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTienRa.ForeColor = System.Drawing.Color.White;
            this.btnTienRa.Location = new System.Drawing.Point(362, 192);
            this.btnTienRa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTienRa.Name = "btnTienRa";
            this.btnTienRa.Size = new System.Drawing.Size(352, 36);
            this.btnTienRa.TabIndex = 35;
            this.btnTienRa.Text = "Tiền ra";
            this.btnTienRa.TextColor = System.Drawing.Color.White;
            this.btnTienRa.UseVisualStyleBackColor = false;
            this.btnTienRa.Click += new System.EventHandler(this.btnTienRa_Click);
            this.btnTienRa.MouseEnter += new System.EventHandler(this.btnTienRa_MouseEnter);
            this.btnTienRa.MouseLeave += new System.EventHandler(this.btnTienRa_MouseLeave);
            // 
            // btnTienVao
            // 
            this.btnTienVao.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTienVao.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnTienVao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTienVao.BorderRadius = 0;
            this.btnTienVao.BorderSize = 0;
            this.btnTienVao.FlatAppearance.BorderSize = 0;
            this.btnTienVao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTienVao.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTienVao.ForeColor = System.Drawing.Color.White;
            this.btnTienVao.Location = new System.Drawing.Point(720, 192);
            this.btnTienVao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTienVao.Name = "btnTienVao";
            this.btnTienVao.Size = new System.Drawing.Size(353, 36);
            this.btnTienVao.TabIndex = 34;
            this.btnTienVao.Text = "Tiền vào";
            this.btnTienVao.TextColor = System.Drawing.Color.White;
            this.btnTienVao.UseVisualStyleBackColor = false;
            this.btnTienVao.Click += new System.EventHandler(this.btnTienVao_Click);
            this.btnTienVao.MouseEnter += new System.EventHandler(this.btnTienVao_MouseEnter);
            this.btnTienVao.MouseLeave += new System.EventHandler(this.btnTienVao_MouseLeave);
            // 
            // btnToanBo
            // 
            this.btnToanBo.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnToanBo.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnToanBo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnToanBo.BorderRadius = 0;
            this.btnToanBo.BorderSize = 0;
            this.btnToanBo.FlatAppearance.BorderSize = 0;
            this.btnToanBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToanBo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnToanBo.ForeColor = System.Drawing.Color.White;
            this.btnToanBo.Location = new System.Drawing.Point(3, 192);
            this.btnToanBo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToanBo.Name = "btnToanBo";
            this.btnToanBo.Size = new System.Drawing.Size(353, 36);
            this.btnToanBo.TabIndex = 33;
            this.btnToanBo.Text = "Toàn bộ";
            this.btnToanBo.TextColor = System.Drawing.Color.White;
            this.btnToanBo.UseVisualStyleBackColor = false;
            this.btnToanBo.Click += new System.EventHandler(this.btnToanBo_Click);
            this.btnToanBo.MouseEnter += new System.EventHandler(this.btnToanBo_MouseEnter);
            this.btnToanBo.MouseLeave += new System.EventHandler(this.btn_ToanBo_MouseLeave);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnXuatExcel.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.btnXuatExcel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXuatExcel.BorderRadius = 0;
            this.btnXuatExcel.BorderSize = 0;
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(3, 136);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(532, 38);
            this.btnXuatExcel.TabIndex = 31;
            this.btnXuatExcel.Text = "Xuất excel";
            this.btnXuatExcel.TextColor = System.Drawing.Color.White;
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            this.btnXuatExcel.MouseEnter += new System.EventHandler(this.btnXuatExcel_MouseEnter);
            this.btnXuatExcel.MouseLeave += new System.EventHandler(this.btnXuatExcel_MouseLeave);
            // 
            // cmNgay
            // 
            this.cmNgay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmNgay.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.cmNgay.FormattingEnabled = true;
            this.cmNgay.Items.AddRange(new object[] {
            "1 ngày gần đây nhất",
            "3 ngày gần đây nhất",
            "7 ngày gần đây nhất",
            "30 ngày gần đây nhất",
            "100 ngày gần đây nhất"});
            this.cmNgay.Location = new System.Drawing.Point(485, 71);
            this.cmNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmNgay.Name = "cmNgay";
            this.cmNgay.Size = new System.Drawing.Size(514, 36);
            this.cmNgay.TabIndex = 30;
            // 
            // vbButton1
            // 
            this.vbButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.vbButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(115)))), ((int)(((byte)(165)))));
            this.vbButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vbButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.vbButton1.BorderRadius = 0;
            this.vbButton1.BorderSize = 0;
            this.vbButton1.FlatAppearance.BorderSize = 0;
            this.vbButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vbButton1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vbButton1.ForeColor = System.Drawing.Color.White;
            this.vbButton1.Location = new System.Drawing.Point(3, 60);
            this.vbButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vbButton1.Name = "vbButton1";
            this.vbButton1.Size = new System.Drawing.Size(1070, 59);
            this.vbButton1.TabIndex = 29;
            this.vbButton1.Text = "        Thời gian giao dịch";
            this.vbButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vbButton1.TextColor = System.Drawing.Color.White;
            this.vbButton1.UseVisualStyleBackColor = false;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTieuDe.Location = new System.Drawing.Point(3, 15);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(331, 29);
            this.lblTieuDe.TabIndex = 28;
            this.lblTieuDe.Text = "Lịch sử giao dịch tài khoản";
            // 
            // FrmLichSuGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLichSuGiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lịch sử giao dịch";
            this.Load += new System.EventHandler(this.FrmLichSuGiaoDich_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GvTongGui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvTongNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvLSGD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView GvLSGD;
        private CustomButton.VBButton btnTienRa;
        private CustomButton.VBButton btnTienVao;
        private CustomButton.VBButton btnToanBo;
        private ComboBox cmNgay;
        private CustomButton.VBButton vbButton1;
        private Label lblTieuDe;
        private DataGridView GvTongGui;
        private DataGridView GvTongNhan;
        private CustomButton.VBButton btnThongke;
        private CustomButton.VBButton btnXuatExcel;
    }
}