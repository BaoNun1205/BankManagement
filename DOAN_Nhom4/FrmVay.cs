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

namespace DOAN_Nhom4
{
    public partial class FrmVay : Form
    {
        DBConnection db = new DBConnection();
        public NguoiDung nguoiDung;
        public TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        ThongTinNguoiDungVayDAO ttNgDungDAO = new ThongTinNguoiDungVayDAO();
        public FrmVay()
        {
            InitializeComponent();
        }
        public FrmVay(NguoiDung nguoiDung, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
        }
        private void FrmVay_Load(object sender, EventArgs e)
        {
            string[] danhxung = { "Ong", "Ba" };
            string[] nghe = {"Chọn", "NONG NGHIEP VA HOAT DONG DV CO LIEN QUAN", "LAM NGHIEP VA HOAT DONG DV CO LIEN QUAN",
                            "KHAI THAC, NUOI TRONG THUY SAN", "CAC NGANH KHAI THAC", "SAN XUAT CHE BIEN THUC PHAM",
                            "SAN XUAT DO UONG", "SAN XUAT SAN PHAM THUOC LA","DET","SAN XUAT TRANG PHUC","LAM NOI THAT",
                            "SAN XUAT XE","BUON BAN NHO LE","BUON BAN O TO","SUA CHUA CAC LOAI MAY MOC","SAN XUAT GIUONG, TU, BAN GHE",
                            "KHAI THAC, XU LI, CUNG CAP NUOC","THU GOM, XU LY, TAI CHE RAC THAI", "LAO CONG","GIAO VIEN","HOC SINH, SINH VIEN",
                            "CAN BO NHA NUOC","KIEN TRUC SU","NHA THAU","VAN TAI HANG KHONG", "VAN TAI DUONG THUY", "VAN TAI DUONG BO","DICH VU AN UONG",
                            "LAP TRINH VIEN", "VIEN THONG","CAC NGANH DICH VU KHAC","HOAT DONG Y TE", "CONG NHAN","NHA BAO", "KIEM TOAN KE TOAN",
                            "BAC SI, Y, DUOC SI", "NGHE NONG", "NGHE KHAC"};
            string[] thunhap = { "Chọn", "<= 3 trieu dong", ">= 3-5 trieu dong", ">= 5-10 trieu dong", ">= 10-20 trieu dong", ">= 20 trieu dong" };
            string[] spvay = { "Chọn", "NHU CAU NHA O", "SAN XUAT KINH DOANH", "MUA O TO", "TIEU DUNG KHONG CO TAI SAN BAO DAM", "TIEU DUNG DAM BAO BANG BAT DONG SAN", "CHO VAY KHAC" };
            cb_DanhXung.DataSource = danhxung;
            cb_NgheNghiep.DataSource = nghe;
            cb_ThuNhap.DataSource = thunhap;
            cb_SPVay.DataSource = spvay;
            txt_HoTen.Text = nguoiDung.TenTK;
            txt_CCCD.Text = nguoiDung.Cccd;
            txt_SDT.Text = nguoiDung.Sdt;
            txt_Email.Text = nguoiDung.Email;
        }

        private void txt_DiaChiLienLac_Click(object sender, EventArgs e)
        {
            if (txt_DiaChiLienLac.Text == "Địa chỉ khác")
            {
                txt_DiaChiLienLac.Text = "";
                txt_DiaChiLienLac.ForeColor = Color.Black;
            }
        }

        private void txt_DiaChiLienLac_Leave(object sender, EventArgs e)
        {
            if (txt_DiaChiLienLac.Text == "")
            {
                txt_DiaChiLienLac.Text = "Địa chỉ khác";
                txt_DiaChiLienLac.ForeColor = Color.Silver;
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string s;
            if (cb_DiaChiLienLac.Checked == true)
            {
                s = "Dang ky Online";
            }
            else
                s = txt_DiaChiLienLac.Text;
            if (IsNull(sender, e) == true)
            {
                if (cb_DongY.Checked == true)
                {
                    if (BigInteger.Parse(txt_SoTienVay.Text) > 0 && BigInteger.Parse(txt_SoTienVay.Text) % 1000 == 0)
                    {
                        if (int.Parse(txt_ThoiGianVay.Text) >= 6 && int.Parse(txt_ThoiGianVay.Text) <= 60)
                        {
                            ThongTinNguoiDungVay tmp = ttNgDungDAO.TKValid(nguoiDung.SoTK);
                            if (tmp == null)
                            {
                                ThongTinNguoiDungVay ttNgDung = new ThongTinNguoiDungVay(nguoiDung.SoTK, cb_DanhXung.Text, nguoiDung.TenTK, nguoiDung.Cccd, txt_DiaChi.Text, nguoiDung.Sdt, nguoiDung.Email, cb_NgheNghiep.Text, cb_ThuNhap.Text, cb_SPVay.Text, BigInteger.Parse(txt_SoTienVay.Text), int.Parse(txt_ThoiGianVay.Text), s, txt_NgayVay.Value);
                                FrmXacNhanThongTinNguoiDungVay xacnhan = new FrmXacNhanThongTinNguoiDungVay(nguoiDung, tknh, ttNgDung, pnlNguoiDung);
                                DOAN_Nhom4.ClassAddForm.addForm(xacnhan, pnlNguoiDung);
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
        public bool IsNull(object sender, EventArgs e)
        {
            if (txt_HoTen.Text != null && txt_CCCD.Text != null && txt_DiaChi.Text != null && txt_SDT.Text != null && db.IsPhone(txt_SDT.Text) == true && txt_Email.Text != null && db.IsEmail(txt_Email.Text) == true && cb_NgheNghiep.Text != "Chọn" && cb_ThuNhap.Text != "Chọn" && cb_SPVay.Text != "Chọn" && txt_SoTienVay.Text != null && txt_ThoiGianVay.Text != null && (cb_DiaChiLienLac.Checked == true || txt_DiaChiLienLac.Text != null))
            {
                return true;
            }
            return false;
        }

        private void cb_DiaChiLienLac_MouseClick(object sender, MouseEventArgs e)
        {
            if (cb_DiaChiLienLac.Checked == true)
            {
                txt_DiaChiLienLac.ReadOnly = true;
            }
            else if (cb_DiaChiLienLac.Checked == false)
            {
                txt_DiaChiLienLac.ReadOnly = false;
                if (txt_DiaChiLienLac.Text == null)
                {
                    cb_DiaChiLienLac.Enabled = false;
                }
                else
                    cb_DiaChiLienLac.Enabled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

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
    }
}
