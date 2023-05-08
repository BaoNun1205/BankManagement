namespace DOAN_Nhom4
{
    partial class FrmTrangchu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangchu));
            this.label2 = new System.Windows.Forms.Label();
            this.ptbLoGo = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoGo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 13;
            // 
            // ptbLoGo
            // 
            this.ptbLoGo.Image = global::DOAN_Nhom4.Properties.Resources.z4156388208487_6cfd569e12217b8073a7fbfcc22c322f1;
            this.ptbLoGo.Location = new System.Drawing.Point(469, 197);
            this.ptbLoGo.Name = "ptbLoGo";
            this.ptbLoGo.Size = new System.Drawing.Size(195, 154);
            this.ptbLoGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLoGo.TabIndex = 14;
            this.ptbLoGo.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(428, 420);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(103, 37);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "lblDate";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(520, 386);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(105, 37);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "lblTime";
            // 
            // FrmTrangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 720);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.ptbLoGo);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTrangchu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FrmTrangchu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLoGo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private PictureBox ptbLoGo;
        private Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private Label lblTime;
    }
}