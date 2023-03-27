namespace DOAN_Nhom4
{
    partial class FrmThongTinTheHBBVisaInfinite
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
            this.ptbThongTin = new System.Windows.Forms.PictureBox();
            this.ptbTheTinDung = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbQuayLai = new System.Windows.Forms.PictureBox();
            this.lblTheTinDung = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTheTinDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuayLai)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbThongTin
            // 
            this.ptbThongTin.Image = global::DOAN_Nhom4.Properties.Resources.thong_tin_hhb_visa_infinite;
            this.ptbThongTin.Location = new System.Drawing.Point(462, 73);
            this.ptbThongTin.Name = "ptbThongTin";
            this.ptbThongTin.Size = new System.Drawing.Size(649, 595);
            this.ptbThongTin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbThongTin.TabIndex = 81;
            this.ptbThongTin.TabStop = false;
            // 
            // ptbTheTinDung
            // 
            this.ptbTheTinDung.Image = global::DOAN_Nhom4.Properties.Resources.hhb_visa_infinite;
            this.ptbTheTinDung.Location = new System.Drawing.Point(12, 73);
            this.ptbTheTinDung.Name = "ptbTheTinDung";
            this.ptbTheTinDung.Size = new System.Drawing.Size(425, 237);
            this.ptbTheTinDung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTheTinDung.TabIndex = 80;
            this.ptbTheTinDung.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(1, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 5);
            this.panel1.TabIndex = 79;
            // 
            // ptbQuayLai
            // 
            this.ptbQuayLai.Image = global::DOAN_Nhom4.Properties.Resources.left_arrow1;
            this.ptbQuayLai.Location = new System.Drawing.Point(1, 1);
            this.ptbQuayLai.Name = "ptbQuayLai";
            this.ptbQuayLai.Size = new System.Drawing.Size(41, 45);
            this.ptbQuayLai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbQuayLai.TabIndex = 78;
            this.ptbQuayLai.TabStop = false;
            // 
            // lblTheTinDung
            // 
            this.lblTheTinDung.AutoSize = true;
            this.lblTheTinDung.BackColor = System.Drawing.Color.White;
            this.lblTheTinDung.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTheTinDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.lblTheTinDung.Location = new System.Drawing.Point(396, 2);
            this.lblTheTinDung.Name = "lblTheTinDung";
            this.lblTheTinDung.Size = new System.Drawing.Size(340, 44);
            this.lblTheTinDung.TabIndex = 77;
            this.lblTheTinDung.Text = "HHB VISA INFINITE";
            this.lblTheTinDung.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTheTinDung.Click += new System.EventHandler(this.lblTheTinDung_Click);
            // 
            // FrmThongTinTheHBBVisaInfinite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 681);
            this.Controls.Add(this.ptbThongTin);
            this.Controls.Add(this.ptbTheTinDung);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptbQuayLai);
            this.Controls.Add(this.lblTheTinDung);
            this.Name = "FrmThongTinTheHBBVisaInfinite";
            this.Text = "FrmThongTinTheHBBVisaInfinite";
            ((System.ComponentModel.ISupportInitialize)(this.ptbThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTheTinDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuayLai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ptbThongTin;
        private PictureBox ptbTheTinDung;
        private Panel panel1;
        private PictureBox ptbQuayLai;
        private Label lblTheTinDung;
    }
}