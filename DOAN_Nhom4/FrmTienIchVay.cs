using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmTienIchVay : Form
    {
        private NguoiDung nguoiDung;
        private TaiKhoanNganHang tknh;
        private Panel pnlNguoiDung;
        ThongTinNguoiDungVayDAO ttNgDungDAO = new ThongTinNguoiDungVayDAO();
        KHNoXauDAO KHNoXauDAO = new KHNoXauDAO();
        public FrmTienIchVay()
        {
            InitializeComponent();
        }
        public FrmTienIchVay(NguoiDung nguoiDung, TaiKhoanNganHang tknh, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.nguoiDung = nguoiDung;
            this.tknh = tknh;
            this.pnlNguoiDung = pnlNguoiDung;
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            KHNoXau kh = KHNoXauDAO.IsNull(tknh);
            ThongTinNguoiDungVay ttNgDung = ttNgDungDAO.TKValid(tknh.SoTK);
            if (kh == null)
            {
                if (ttNgDung == null)
                {
                    FrmVay frmVay = new FrmVay(nguoiDung, tknh, pnlNguoiDung);
                    DOAN_Nhom4.ClassAddForm.addForm(frmVay, pnlNguoiDung);
                }
                else
                    MessageBox.Show("Bạn đang có khoản vay!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime startDate = kh.NgayNo;
                DateTime endDate = DateTime.Now;
                TimeSpan span = endDate - startDate;
                double totalDays = span.TotalDays;
                if (totalDays > 1825)
                {
                    KHNoXauDAO.Xoa(kh);
                    FrmVay frmVay = new FrmVay(nguoiDung, tknh, pnlNguoiDung);
                    DOAN_Nhom4.ClassAddForm.addForm(frmVay, pnlNguoiDung);
                }
                else
                    MessageBox.Show("Bạn đang có nợ xấu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_XemKhoanVay_Click(object sender, EventArgs e)
        {
            ThongTinNguoiDungVay ttNgDung = ttNgDungDAO.TKValid(nguoiDung.SoTK);           
            if (ttNgDung != null)
            {
                DateTime startDate = ttNgDung.NgayDenHan;
                DateTime endDate = DateTime.Now;
                TimeSpan span = endDate - startDate;
                double totalDays = span.TotalDays;
                if (totalDays > 90) 
                {
                    KHNoXau kh = new KHNoXau();
                    kh.SoTK = tknh.SoTK;
                    kh.TenTK = nguoiDung.tenTK;
                    kh.Cccd = nguoiDung.Cccd;
                    kh.NgayNo = DateTime.Now;
                    if(KHNoXauDAO.IsNull(tknh) == null)
                        KHNoXauDAO.Them(kh);
                    ttNgDungDAO.Xoa(ttNgDung);
                    MessageBox.Show("Bạn trở thành nợ xấu vì không thanh toán khoản vay quá 90 ngày", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FrmTienIch frmtienich = new FrmTienIch(nguoiDung, tknh, pnlNguoiDung);
                    DOAN_Nhom4.ClassAddForm.addForm(frmtienich, pnlNguoiDung);
                }
                else
                {
                    FrmThongTinTaiKhoanVay frmThongTinTaiKhoanVay = new FrmThongTinTaiKhoanVay(nguoiDung, tknh, ttNgDung, pnlNguoiDung);
                    DOAN_Nhom4.ClassAddForm.addForm(frmThongTinTaiKhoanVay, pnlNguoiDung);
                }     
            }
            else
                MessageBox.Show("Bạn không có khoản vay nào!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
