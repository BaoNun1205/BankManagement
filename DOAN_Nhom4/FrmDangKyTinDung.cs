using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
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

        private BigInteger hanMucToiThieu = 0;
        private BigInteger hanMucToiDa = 0;
        private double laiSuat = 0;
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

        private void FrmDangKyTinDung_Load(object sender, EventArgs e)
        {
            txt_HoTen.Text = kh.tenTK;
            txt_CCCD.Text = kh.cccd;
            txt_SDT.Text = kh.Sdt;
            txt_Email.Text = kh.Email;
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            ThongTinTinDung td = tttdDAO.LayThongTinTinDung("SoTKTinDung", txtSoTaiKhoan.Text);
            if (td == null)
            {
                if (IsNull(sender, e) == true)
                {
                    if (cb_DongY.Checked == true)
                    {
                        if (Int64.Parse(txtHanMuc.Text) >= hanMucToiThieu && Int64.Parse(txtHanMuc.Text) <= hanMucToiDa)
                        {
                            ThongTinTinDung ttTinDung = new ThongTinTinDung(txtSoTaiKhoan.Text, txt_HoTen.Text, txt_CCCD.Text, txt_DiaChi.Text, txt_SDT.Text, txt_Email.Text, cb_NgheNghiep.Text, cb_ThuNhap.Text,
                                                                            cbLoaiThe.Text, dtpNgayMoThe.Value.AddMonths(1), dtpNgayMoThe.Value.AddMonths(1).Subtract(new TimeSpan(15, 0, 0, 0)), int.Parse(txtHanMuc.Text), laiSuat, 0, 0, dtpNgayMoThe.Value, 0, 0);
                            tttdDAO.Them(ttTinDung);
                            MessageBox.Show("Xác nhận thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmTienIch frmTienIch = new FrmTienIch(kh, tknh, pnlNguoiDung);
                            Utility.addForm(frmTienIch, pnlNguoiDung);
                        }
                        else
                        {
                            MessageBox.Show("Hạn mức của thẻ không phù hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa đồng ý với điều khoản điều kiện của chúng tôi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Phải nhập đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Số tài khoản đã tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void lbllLoaiThe_Click(object sender, EventArgs e)
        {
            FrmThongTinTheHHBVisaFlexi frmThongTinTheHHBVisaFlexi = new FrmThongTinTheHHBVisaFlexi(kh, tknh, pnlNguoiDung);
            Utility.addForm(frmThongTinTheHHBVisaFlexi, pnlNguoiDung);
        }

        private void ptbQuayLai_Click(object sender, EventArgs e)
        {
            FrmTienIchTinDung frmTienIchTinDung = new FrmTienIchTinDung(kh, tknh, pnlNguoiDung);
            Utility.addForm(frmTienIchTinDung, pnlNguoiDung);
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

        private void cb_LoaiThe_SelectedIndexChanged(object sender, EventArgs e)
        {
            BigInteger[] hanMuc = { 10000000, 80000000, 80000000, 10000000000, 300000000, 10000000000 };
            double[] lai = { 18, 16.5, 16.5 };
            int selectedIndex = cbLoaiThe.SelectedIndex;
            if (selectedIndex >= 0)
            {
                ptbTheTinDung.Image = images[selectedIndex];
                lblThongTinTIen.Text = hanMuc[selectedIndex * 1 + selectedIndex].ToString("N0") + " VNĐ" + " - " + hanMuc[selectedIndex * 1 + 1 + selectedIndex].ToString("N0") + " VNĐ";
                hanMucToiThieu = hanMuc[selectedIndex * 1 + selectedIndex];
                hanMucToiDa = hanMuc[selectedIndex * 1 + 1 + selectedIndex];
                laiSuat = lai[selectedIndex];
            }
            else
            {
                ptbTheTinDung.Image = null;
            }
        }

        public bool IsNull(object sender, EventArgs e)
        {
            if (txt_DiaChi.Text != ""  && cb_NgheNghiep.Text != "" && cb_ThuNhap.Text != "" && txtSoTaiKhoan.Text != "" && cbLoaiThe.Text != "" && txtHanMuc.Text != "")
            {
                return true;
            }
            return false;
        }
    }
}
