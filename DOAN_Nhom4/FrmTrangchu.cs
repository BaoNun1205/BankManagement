namespace DOAN_Nhom4
{
    public partial class FrmTrangchu : Form
    {
        public NguoiDung kh;
        public TaiKhoanNganHang tknh;
        public GiaoDich gd;
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

        public FrmTrangchu(NguoiDung kh, TaiKhoanNganHang tknh, GiaoDich gd)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.gd = gd;
        }

        private void FrmTrangchu_Load(object sender, EventArgs e)
        {
            
        }

        private void picBoxLsgd_Click(object sender, EventArgs e)
        {
            FrmLichSuGiaoDich frmlsgd = new FrmLichSuGiaoDich(kh, gd, tknh);
            this.Hide();
            frmlsgd.ShowDialog();
            this.Close();
        }
    }
}