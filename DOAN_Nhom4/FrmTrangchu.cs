namespace DOAN_Nhom4
{
    public partial class FrmTrangchu : Form
    {
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        private Panel pnlNguoidung;
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
        }

        private void lblXemLsgd_Click(object sender, EventArgs e)
        {
            FrmLichSuGiaoDich frmLichSuGiaoDich = new FrmLichSuGiaoDich(kh);
            DOAN_Nhom4.ClassAddForm.addForm(frmLichSuGiaoDich, pnlNguoidung);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}