namespace DOAN_Nhom4
{
    public partial class FrmTrangchu : Form
    {
        public NguoiDung kh;
        public TaiKhoangNganHang tknh;
        public GiaoDichChuyenTien gd;
        public FrmTrangchu()
        {
            InitializeComponent();
        }

        public FrmTrangchu(NguoiDung kh, TaiKhoangNganHang tknh)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
        }

        public FrmTrangchu(NguoiDung kh, TaiKhoangNganHang tknh, GiaoDichChuyenTien gd)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.gd = gd;
        }

        private void FrmTrangchu_Load(object sender, EventArgs e)
        {
            lblXinchao.Parent = picBoxNguoidung;
            lblXinchao.BackColor = Color.Transparent;

            pnlTKhoan.Parent = picBoxNguoidung;
            pnlTKhoan.BackColor = Color.Transparent;

            pnlCĐat.Parent = picBoxNguoidung;
            pnlCĐat.BackColor = Color.Transparent;

            lblTenTK.Parent = picBoxNguoidung;
            lblTenTK.BackColor = Color.Transparent;
            lblTenTK.Text = kh.TenTK.ToString();
        }
        private void btnChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(kh, tknh);
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }
        private void picBoxChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(kh, tknh);
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void lblChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(kh, tknh);
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        //Nut chuyen tien
        private void btnChuyentien_MouseMove(object sender, MouseEventArgs e)
        {
            btnChuyentien.BorderColor = Color.Aqua;
        }

        private void btnChuyentien_MouseLeave(object sender, EventArgs e)
        {
            btnChuyentien.BorderColor = Color.Transparent;
        }

        private void picBoxChuyentien_MouseMove(object sender, MouseEventArgs e)
        {
            btnChuyentien.BorderColor = Color.Aqua;
        }

        private void lblChuyentien_MouseMove(object sender, MouseEventArgs e)
        {
            btnChuyentien.BorderColor = Color.Aqua;
        }

        // Nut tien ich

        private void btnTienich_MouseMove(object sender, MouseEventArgs e)
        {
            btnTienich.BorderColor = Color.Aqua;
        }

        private void btnTienich_MouseLeave(object sender, EventArgs e)
        {
            btnTienich.BorderColor = Color.Transparent;
        }

        private void picBoxTienich_MouseMove(object sender, MouseEventArgs e)
        {
            btnTienich.BorderColor = Color.Aqua;
        }

        private void lblTienich_MouseMove(object sender, MouseEventArgs e)
        {
            btnTienich.BorderColor = Color.Aqua;
        }

        // Nut tiet kiem
        private void btnTietkiem_MouseMove(object sender, MouseEventArgs e)
        {
            btnTietkiem.BorderColor = Color.LightSalmon;
        }

        private void btnTietkiem_MouseLeave(object sender, EventArgs e)
        {
            btnTietkiem.BorderColor = Color.Transparent;
        }

        private void picBoxTietkiem_MouseMove(object sender, MouseEventArgs e)
        {
            btnTietkiem.BorderColor = Color.LightSalmon;
        }

        private void lblTietkiem_MouseMove(object sender, MouseEventArgs e)
        {
            btnTietkiem.BorderColor = Color.LightSalmon;
        }

        // Nut ho tro
        private void btnHotro_MouseMove(object sender, MouseEventArgs e)
        {
            btnHotro.BorderColor = Color.LightSalmon;
        }

        private void btnHotro_MouseLeave(object sender, EventArgs e)
        {
            btnHotro.BorderColor = Color.Transparent;
        }

        private void picBoxHotro_MouseMove(object sender, MouseEventArgs e)
        {
            btnHotro.BorderColor = Color.LightSalmon;
        }

        private void lblHotro_Move(object sender, EventArgs e)
        {
            btnHotro.BorderColor = Color.LightSalmon;
        }

        private void btnHotro_Click(object sender, EventArgs e)
        {

        }

        private void lblTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmHienThiThongTinCaNhan frmHienThiThongTinCaNhan = new FrmHienThiThongTinCaNhan(kh, tknh);
            this.Hide();
            frmHienThiThongTinCaNhan.ShowDialog();
            this.Close();
        }

        private void picBTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmHienThiThongTinCaNhan frmHienThiThongTinCaNhan = new FrmHienThiThongTinCaNhan(kh, tknh);
            this.Hide();
            frmHienThiThongTinCaNhan.ShowDialog();
            this.Close();
        }

        private void picBoxLsgd_Click(object sender, EventArgs e)
        {
            FrmLichSuGiaoDich frmlsgd = new FrmLichSuGiaoDich(kh, gd, tknh);
            this.Hide();
            frmlsgd.ShowDialog();
            this.Close();
        }

        private void btnTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh);
            this.Hide();
            frmtietkiem.ShowDialog();
            this.Close();
        }

        private void picBoxTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh);
            this.Hide();
            frmtietkiem.ShowDialog();
            this.Close();
        }

        private void lblTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh);
            this.Hide();
            frmtietkiem.ShowDialog();
            this.Close();
        }

        private void picBoxFrmTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(kh, tknh);
            this.Hide();
            frmtietkiem.ShowDialog();
            this.Close();
        }
    }
}