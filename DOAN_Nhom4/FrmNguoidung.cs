namespace DOAN_Nhom4
{
    public partial class FrmNguoidung : Form
    {
        public KhachHang khDangNhap { get; set; }
        public FrmNguoidung()
        {
            InitializeComponent();
        }
        private void FrmNguoidung_Load(object sender, EventArgs e)
        {
            lblXinchao.Parent = picBoxNguoidung;
            lblXinchao.BackColor = Color.Transparent;

            pnlTKhoan.Parent = picBoxNguoidung;
            pnlTKhoan.BackColor = Color.Transparent;

            pnlCĐat.Parent = picBoxNguoidung;
            pnlCĐat.BackColor = Color.Transparent;
            
            lblTenTK.Parent = picBoxNguoidung;
            lblTenTK.BackColor = Color.Transparent;
            lblTenTK.Text = khDangNhap.TenTK.ToString();
        }

        private KhachHang LayKhachHang()
        {
            KhachHang khNguoiDung = new KhachHang(khDangNhap.SoTK, khDangNhap.TenTK, khDangNhap.TenDN, khDangNhap.Pass, khDangNhap.NgaySinh, khDangNhap.Cccd, khDangNhap.Sdt, khDangNhap.SoDu);
            return khNguoiDung;
        }
        private void btnChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien();
            frmchuyentien.khNguoiDung = LayKhachHang();
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void picBoxChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien();
            frmchuyentien.khNguoiDung = LayKhachHang();
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void lblChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien();
            frmchuyentien.khNguoiDung = LayKhachHang();
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

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

        private void lblTaiKhoang_Click(object sender, EventArgs e)
        {
            FrmHienThiThongTinCaNhan frmHienThiThongTinCaNhan = new FrmHienThiThongTinCaNhan();
            frmHienThiThongTinCaNhan.khNguoiDung = LayKhachHang();
            this.Hide();
            frmHienThiThongTinCaNhan.ShowDialog();
            this.Close();
        }

        
    }
}