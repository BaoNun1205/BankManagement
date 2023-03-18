using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace DOAN_Nhom4
{
    public partial class NapTien : UserControl
    {
        public NapTien()
        {
            InitializeComponent();
        }
        TaiKhoanNganHangDAO tknhDAO = new TaiKhoanNganHangDAO();
        LichSuGiaoDichDAO lsgdDAO = new LichSuGiaoDichDAO();
        private void btn_NapTien_Click(object sender, EventArgs e)
        {
            TaiKhoanNganHang tkNap = new TaiKhoanNganHang(txt_SoTK.Text);
            BigInteger SoTien = BigInteger.Parse(txt_SoTK.Text);
            tknhDAO.NapTien(tkNap, SoTien);
            MessageBox.Show("Nạp tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_SoTK.Text = "";
            txt_SoTien.Text = "";
            txt_CCCD.Text = "";
            txt_SDT.Text = "";
        }
    }
}
