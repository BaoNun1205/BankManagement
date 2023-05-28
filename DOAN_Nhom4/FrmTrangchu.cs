using DOAN_Nhom4.Entities;

namespace DOAN_Nhom4
{
    public partial class FrmTrangchu : Form
    {
        public FrmTrangchu()
        {
            InitializeComponent();
        }

        private void FrmTrangchu_Load(object sender, EventArgs e)
        {          
            timer1.Start();

            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();

            int x = (this.Size.Width - lblTime.Width) / 2;
            int y = (this.Size.Height - lblTime.Height) / 2;

            int x2 = (this.Size.Width - lblDate.Width) / 2;
            int y2 = (this.Size.Height - lblDate.Height) / 2;


            lblTime.Location = new Point(x, y + lblTime.Height);
            lblDate.Location = new Point(x2, y2 + 2*lblTime.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}