using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DOAN_Nhom4.Entities;

namespace DOAN_Nhom4
{
    public partial class FrmVay : Form
    {
        KiemTraThongTin db = new KiemTraThongTin();
        public KhachHang nguoiDung;
        public TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        ThongTinNguoiDungVayDAO ttNgDungDAO = new ThongTinNguoiDungVayDAO();
        public FrmVay()
        {
            InitializeComponent();
        }
        public FrmVay(KhachHang nguoiDung, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
        }
        private void FrmVay_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void txt_DiaChiLienLac_Click(object sender, EventArgs e)
        {
            if (txtDiaChiLienLac.Text == "Địa chỉ khác")
            {
                txtDiaChiLienLac.Text = "";
                txtDiaChiLienLac.ForeColor = Color.Black;
            }
        }

        private void txt_DiaChiLienLac_Leave(object sender, EventArgs e)
        {
            if (txtDiaChiLienLac.Text == "")
            {
                txtDiaChiLienLac.Text = "Địa chỉ khác";
                txtDiaChiLienLac.ForeColor = Color.Silver;
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string s;
            if (cbDiaChiLienLac.Checked == true)
            {
                s = "Dang ky Online";
            }
            else
                s = txtDiaChiLienLac.Text;
            if (IsNull(sender, e) == true)
            {
                if (cbDongY.Checked == true)
                {
                    if (decimal.Parse(txtSoTienVay.Text) > 0 && decimal.Parse(txtSoTienVay.Text) % 1000 == 0)
                    {
                        if (int.Parse(txtThoiGianVay.Text) >= 6 && int.Parse(txtThoiGianVay.Text) <= 60)
                        {
                            KhachHangVay tmp = ttNgDungDAO.TKValid(nguoiDung);
                            if (tmp == null)
                            {
                                string txt_LoaiKhoanVay = "";
                                if (rbTheChap.Checked)
                                {
                                    txt_LoaiKhoanVay = rbTheChap.Text;
                                }
                                if (rbTinChap.Checked)
                                {
                                    txt_LoaiKhoanVay = rbTinChap.Text;
                                    cbSPVay.Text = "TIEU DUNG KHONG CO TAI SAN DAM BAO";
                                    txtTaiSan.Text = "Trong";
                                    txtGiaTriTaiSan.Text = "0";
                                }
                                KhachHangVay ttNgDung = new KhachHangVay()
                                {
                                    TenNh = "HHB",
                                    LoaiKhoanVay = txt_LoaiKhoanVay,
                                    SoTkvay = nguoiDung.SoTk,
                                    DanhXung = cbDanhXung.Text,
                                    HoTen = nguoiDung.TenKh,
                                    Cccd = nguoiDung.Cccd,
                                    DiaChi = txtDiaChi.Text,
                                    Sdt = nguoiDung.Sdt,
                                    Email = nguoiDung.Email,
                                    NgheNghiep = cbNgheNghiep.Text,
                                    ThuNhap = cbThuNhap.Text,
                                    Spvay = cbSPVay.Text,
                                    SoTienVay = decimal.Parse(txtSoTienVay.Text),
                                    ThoiGianVay = int.Parse(txtThoiGianVay.Text),
                                    TaiSanTheChap = txtTaiSan.Text,
                                    GiaTriTaiSan = decimal.Parse(txtGiaTriTaiSan.Text),
                                    ChiNhanhVay = s,
                                    NgayVay = txtNgayVay.Value,
                                    LaiSuat = "0",
                                    SoTienHangThang = 0,
                                    TongSoTienPhaiTra = 0,
                                    PhiTraCham = 0
                                };
                                FrmXacNhanThongTinNguoiDungVay xacnhan = new FrmXacNhanThongTinNguoiDungVay(nguoiDung, tknh, ttNgDung, pnlNguoiDung);
                                Utility.addForm(xacnhan, pnlNguoiDung);
                            }
                            else
                                MessageBox.Show("Bạn đang có 1 khoản vay khác !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("Thời gian vay chưa hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Số tiền nhập vào chưa hợp lệ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Bạn chưa đồng ý với điều khoản điều kiện của chúng tôi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Phải nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pbQuaylai_Click(object sender, EventArgs e)
        {
            FrmTienIchVay frmtienIchVay = new FrmTienIchVay(nguoiDung, tknh, pnlNguoiDung);
            Utility.addForm(frmtienIchVay, pnlNguoiDung);
        }

        private void cb_DiaChiLienLac_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbDiaChiLienLac.Checked == true)
            {
                txtDiaChiLienLac.ReadOnly = true;
            }
            else if (cbDiaChiLienLac.Checked == false)
            {
                txtDiaChiLienLac.ReadOnly = false;
                if (txtDiaChiLienLac.Text == null)
                {
                    cbDiaChiLienLac.Enabled = false;
                }
                else
                    cbDiaChiLienLac.Enabled = true;
            }
        }

        private void llbl_DieuKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Khởi tạo đường dẫn của trình duyệt web mặc định trên máy tính
            string browserPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Google\\Chrome\\Application\\chrome.exe";
            // Nếu không tìm thấy trình duyệt Chrome, có thể sử dụng trình duyệt mặc định khác như Microsoft Edge
            if (!File.Exists(browserPath))
            {
                browserPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Microsoft\\Edge\\Application\\msedge.exe";
            }
            // Tạo đối tượng ProcessStartInfo để khởi động trình duyệt web với đường dẫn liên kết được chuyền vào
            ProcessStartInfo psi = new ProcessStartInfo(browserPath);
            psi.Arguments = "https://drive.google.com/file/d/1gRKFDUcnpDgO02YW1CQytsyrTVaftXwg/view?usp=share_link";
            psi.UseShellExecute = true;
            // Khởi động trình duyệt web với đường dẫn liên kết được chuyền vào
            Process.Start(psi);
        }

        private void rb_TinChap_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTinChap.Checked)
            {
                cbSPVay.Enabled = false;
                txtTaiSan.Enabled = false;
                txtGiaTriTaiSan.Enabled = false;
            }
        }

        private void rb_TheChap_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTheChap.Checked)
            {
                cbSPVay.Enabled = true;
                txtTaiSan.Enabled = true;
                txtGiaTriTaiSan.Enabled = true;
            }
        }

        private void HienThi()
        {
            txtHoTen.Text = nguoiDung.TenKh;
            txtCCCD.Text = nguoiDung.Cccd;
            txtSDT.Text = nguoiDung.Sdt;
            txtEmail.Text = nguoiDung.Email;
        }

        public bool IsNull(object sender, EventArgs e)
        {
            if (rbTinChap.Checked)
            {
                if (txtHoTen.Text != null && txtCCCD.Text != null && txtDiaChi.Text != null && txtSDT.Text != null && db.IsPhone(txtSDT.Text) == true && txtEmail.Text != null && db.IsEmail(txtEmail.Text) == true && cbNgheNghiep.Text != "Chọn" && cbThuNhap.Text != "Chọn" && txtSoTienVay.Text != null && txtThoiGianVay.Text != null && (cbDiaChiLienLac.Checked == true || txtDiaChiLienLac.Text != null))
                {
                    return true;
                }
            }
            if(rbTheChap.Checked)
            {
                if (txtHoTen.Text != null && txtCCCD.Text != null && txtDiaChi.Text != null && txtSDT.Text != null && db.IsPhone(txtSDT.Text) == true && txtEmail.Text != null && db.IsEmail(txtEmail.Text) == true && cbNgheNghiep.Text != "Chọn" && cbThuNhap.Text != "Chọn" && cbSPVay.Text != "Chọn" && txtSoTienVay.Text != null && txtThoiGianVay.Text != null && txtTaiSan.Text != null && txtGiaTriTaiSan.Text != null && (cbDiaChiLienLac.Checked == true || txtDiaChiLienLac.Text != null))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
