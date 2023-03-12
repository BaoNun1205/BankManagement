namespace DOAN_Nhom4
{
    public partial class FrmNguoidung : Form
    {
        public NguoiDung nguoiDung;
        public FrmNguoidung()
        {
            InitializeComponent();
        }

        public FrmNguoidung(NguoiDung nguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
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
            lblTenTK.Text = nguoiDung.TenTK.ToString();

        }
        private void btnChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(nguoiDung);
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }
        private void picBoxChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(nguoiDung);
            this.Hide();
            frmchuyentien.ShowDialog();
            this.Close();
        }

        private void lblChuyentien_Click(object sender, EventArgs e)
        {
            FrmChuyentien frmchuyentien = new FrmChuyentien(nguoiDung);
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
            FrmHienThiThongTinCaNhan frmHienThiThongTinCaNhan = new FrmHienThiThongTinCaNhan(nguoiDung);
            this.Hide();
            frmHienThiThongTinCaNhan.ShowDialog();
            this.Close();
        }

        private void picBTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmHienThiThongTinCaNhan frmHienThiThongTinCaNhan = new FrmHienThiThongTinCaNhan(nguoiDung);
            this.Hide();
            frmHienThiThongTinCaNhan.ShowDialog();
            this.Close();
        }

        private void picBoxLsgd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(nguoiDung);
            this.Hide();
            frmtietkiem.ShowDialog();
            this.Close();
        }

        private void picBoxTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(nguoiDung);
            this.Hide();
            frmtietkiem.ShowDialog();
            this.Close();
        }

        private void lblTietkiem_Click(object sender, EventArgs e)
        {
            FrmTietkiem frmtietkiem = new FrmTietkiem(nguoiDung);
            this.Hide();
            frmtietkiem.ShowDialog();
            this.Close();
        }
    }
}