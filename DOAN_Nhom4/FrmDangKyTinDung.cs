using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmDangKyTinDung : Form
    {
        private NguoiDung kh;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        ThongTinTinDungDAO tttdDAO = new ThongTinTinDungDAO();
        DBConnection db = new DBConnection();
        Image[] images = new Image[]
        {
            Properties.Resources.hhb_visa_Flexi,
            Properties.Resources.hhb_visa_platinum_cashback,
            Properties.Resources.hhb_visa_infinite,
        };
        public FrmDangKyTinDung()
        {
            InitializeComponent();
        }

        public FrmDangKyTinDung(NguoiDung kh, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.kh = kh;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void cb_LoaiThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] hanMuc = {"10.000.000 - 80.000.000 VND", "80.000.000 VND - ... VND ", "300.000.000 VND - ... VND "};
            int selectedIndex = cbLoaiThe.SelectedIndex;
            if (selectedIndex >= 0)
            {
                ptbTheTinDung.Image = images[selectedIndex];
                lblThongTinTIen.Text = hanMuc[selectedIndex];
            }
            else
            {
                ptbTheTinDung.Image = null;
            }
        }

        private void lbllLoaiThe_Click(object sender, EventArgs e)
        {
            FrmThongTinTheHHBVisaFlexi frmThongTinTheHHBVisaFlexi = new FrmThongTinTheHHBVisaFlexi(kh, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmThongTinTheHHBVisaFlexi, pnlNguoiDung);
        }

        private void ptbQuayLai_Click(object sender, EventArgs e)
        {
            FrmTienIchTinDung frmTienIchTinDung = new FrmTienIchTinDung(kh, tknh, pnlNguoiDung);
            DOAN_Nhom4.ClassAddForm.addForm(frmTienIchTinDung, pnlNguoiDung);
        }

        private void FrmDangKyTinDung_Load(object sender, EventArgs e)
        {
            txt_HoTen.Text = kh.tenTK;
            txt_CCCD.Text = kh.cccd;
            txt_SDT.Text = kh.Sdt;
            txt_Email.Text = kh.Email;
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            if (IsNull(sender, e) == true)
            {
                if (cb_DongY.Checked == true)
                {
                    double lai = laiSuat();
                    ThongTinTinDung ttTinDung = new ThongTinTinDung(txtSoTaiKhoan.Text, txt_HoTen.Text, txt_CCCD.Text, txt_DiaChi.Text, txt_SDT.Text, txt_Email.Text, cb_NgheNghiep.Text, cb_ThuNhap.Text,
                                                                    cbLoaiThe.Text, dtpNgayMoThe.Value.AddMonths(1), dtpNgayMoThe.Value.AddMonths(1).Subtract(new TimeSpan(15, 0, 0, 0)), int.Parse(txtHanMuc.Text), lai, 0, 0, dtpNgayMoThe.Value, 0, 0);
                    tttdDAO.Them(ttTinDung);
                    MessageBox.Show("Xác nhận thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmTienIch frmTienIch = new FrmTienIch(kh, tknh, pnlNguoiDung);
                    DOAN_Nhom4.ClassAddForm.addForm(frmTienIch, pnlNguoiDung);
                }
                else
                {
                    MessageBox.Show("Bạn chưa đồng ý với điều khoản điều kiện của chúng tôi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Phải nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private double laiSuat()
        {
            int giaTri = cbLoaiThe.SelectedIndex;
            if (giaTri == 1)
            {
                return 18;
            }
            else if (giaTri == 2)
            {
                return 16.5;
            }
            else
            {
                return 16.5;
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

        public bool IsNull(object sender, EventArgs e)
        {
            if (txt_HoTen.Text != null && txt_CCCD.Text != null && txt_DiaChi.Text != null && txt_SDT.Text != null && db.IsPhone(txt_SDT.Text) == true && txt_Email.Text != null && db.IsEmail(txt_Email.Text) == true && cb_NgheNghiep.Text != "" && cb_ThuNhap.Text != "" && txtSoTaiKhoan.Text != "" && cbLoaiThe.Text != "" && txtHanMuc.Text != "")
            {
                return true;
            }
            return false;
        }
    }
}
