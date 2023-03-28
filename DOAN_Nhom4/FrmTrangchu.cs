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
            ptbLoGo.Image = Properties.Resources.z4156388208487_6cfd569e12217b8073a7fbfcc22c322f;
        }

        private void lblXemLsgd_Click(object sender, EventArgs e)
        {
            FrmLichSuGiaoDich frmLichSuGiaoDich = new FrmLichSuGiaoDich(kh);
            DOAN_Nhom4.ClassAddForm.addForm(frmLichSuGiaoDich, pnlNguoidung);
        }
    }
}