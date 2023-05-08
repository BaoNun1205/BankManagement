namespace DOAN_Nhom4
{
    public partial class FrmTrangchu : Form
    {
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        private Panel pnlNguoidung;
        private TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        public FrmTrangchu()
        {
            InitializeComponent();
        }

        public FrmTrangchu(NguoiDung kh, TaiKhoanNganHang tknh)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
        }

        public FrmTrangchu(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoidung)
        {
            tknh = tknhDAO.LayTaiKhoanNganHang("SoTK", kh.SoTK, "TenNH", kh.TenNH);
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoidung = pnlNguoidung;
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