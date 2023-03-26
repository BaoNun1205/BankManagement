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
    public partial class FrmVay : Form
    {
        public FrmVay()
        {
            InitializeComponent();
        }

        private void FrmVay_Load(object sender, EventArgs e)
        {
            string[] danhxung = {"Ông", "Bà"};
            string[] nghe = { "Chọn"};
            string[] thunhap = {"Chọn" ,"<= 3 triệu đồng", ">= 3-5 triệu đồng", ">= 5-10 triệu đồng", ">= 10-20 triệu đồng", ">= 20 triệu đồng" };
            cb_DanhXung.DataSource = danhxung;
            cb_NgheNghiep.DataSource = nghe;
            cb_ThuNhap.DataSource = thunhap;
        }
    }
}
