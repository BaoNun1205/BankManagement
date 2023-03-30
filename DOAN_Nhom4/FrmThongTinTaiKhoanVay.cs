using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_Nhom4
{
    public partial class FrmThongTinTaiKhoanVay : Form
    {
        private ThongTinNguoiDungVay ttNgDung;
        private Panel pnlNguoiDung;
        public FrmThongTinTaiKhoanVay()
        {
            InitializeComponent();
        }
        public FrmThongTinTaiKhoanVay(ThongTinNguoiDungVay ttNgDung, Panel pnlNguoiDung)
        {
            InitializeComponent();
            this.ttNgDung = ttNgDung;
            this.pnlNguoiDung = pnlNguoiDung;
        }
    }
}
