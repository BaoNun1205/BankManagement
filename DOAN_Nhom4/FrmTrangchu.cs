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
            ptbLoGo.Image = Properties.Resources.z4156388208487_6cfd569e12217b8073a7fbfcc22c322f;
        }
    }
}