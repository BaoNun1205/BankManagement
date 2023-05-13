namespace DOAN_Nhom4
{
    partial class FrmThongKeTien
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.ThongKe = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFrom.Location = new System.Drawing.Point(169, 87);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(68, 30);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "label1";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTo.Location = new System.Drawing.Point(519, 87);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(68, 30);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "label1";
            // 
            // ThongKe
            // 
            this.ThongKe.Location = new System.Drawing.Point(169, 188);
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Size = new System.Drawing.Size(823, 406);
            this.ThongKe.TabIndex = 3;
            this.ThongKe.Text = "cartesianChart1";
            // 
            // FrmThongKeTien
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 720);
            this.Controls.Add(this.ThongKe);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongKeTien";
            this.Text = "FrmThongKeTien";
            this.Load += new System.EventHandler(this.FrmThongKeTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblFrom;
        private Label lblTo;
        private LiveCharts.WinForms.CartesianChart ThongKe;
    }
}