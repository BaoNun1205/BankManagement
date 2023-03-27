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
            lblTenTK.Text = kh.TenTK.ToString();
        }

        private void picBoxLsgd_Click(object sender, EventArgs e)
        {
            FrmLichSuGiaoDich frmlsgd = new FrmLichSuGiaoDich(kh, gd, tknh);
            this.Hide();
            frmlsgd.ShowDialog();
            this.Close();
        }
        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            FrmHienThiThongTinCaNhan frmHienThiThongTinCaNhan = new FrmHienThiThongTinCaNhan(kh, tknh);
            this.Hide();
            frmHienThiThongTinCaNhan.ShowDialog();
            this.Close();
        }

        private void btnChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(kh, tknh);
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void btnTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh);
            this.Hide();
            frmtietkiem.ShowDialog();
            this.Close();
        }

        private void btnTienich_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmTienIch frmTienIch = new FrmTienIch(kh);
            frmTienIch.ShowDialog();
            this.Close();
        }
    }
}