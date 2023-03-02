namespace DOAN_Nhom4
{
    public partial class FrmNguoidung : Form
    {
        public FrmNguoidung()
        {
            InitializeComponent();

            lblXinchao.ForeColor = Color.Black;
            lblXinchao.AutoSize = true;

            // Set the transparency key to the same color as the backcolor
            this.TransparencyKey = Color.White;
            lblXinchao.BackColor = Color.White;

            // Add the label to the form
            this.Controls.Add(lblXinchao);
        }
    }
}