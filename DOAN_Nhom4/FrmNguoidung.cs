namespace DOAN_Nhom4
{
    public partial class FrmNguoidung : Form
    {
        public FrmNguoidung()
        {
            InitializeComponent();
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmNguoidung_Load(object sender, EventArgs e)
        {
            lblXinchao.Parent = pictureBox1;
            lblXinchao.BackColor = Color.Transparent;
            pictureBox6.Parent = pictureBox1;
            pictureBox6.BackColor = Color.Transparent;
        }
    }
}