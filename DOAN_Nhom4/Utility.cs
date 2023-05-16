using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DOAN_Nhom4.FrmTietkiem;

namespace DOAN_Nhom4
{
    public static class Utility
    {
        static public void addForm(Form form, Panel pnlNguoidung)
        {
            pnlNguoidung.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            int x = (pnlNguoidung.Width - form.Width) / 2;
            int y = (pnlNguoidung.Height - form.Height) / 2;
            form.Location = new Point(x, y);
            pnlNguoidung.Controls.Add(form);
            pnlNguoidung.Tag = form;
            form.Show();
        }

        static public void addUserControl(UserControl userControl, Panel pnlDichvu)
        {
            pnlDichvu.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            int x = (pnlDichvu.Width - userControl.Width) / 2;
            int y = (pnlDichvu.Height - userControl.Height) / 2;
            userControl.Location = new Point(x, y);
            pnlDichvu.Controls.Add(userControl);
            pnlDichvu.Tag = userControl;
        }


        public static string NoiDungLoaiSoTietKiem(this LoaiSoTietKiem gt)
        {
            switch (gt)
            {
                case LoaiSoTietKiem.Loai1:
                    return "Tự đóng khi đến hạn";
                case LoaiSoTietKiem.Loai2:
                    return "Tự chuyển tiền lãi sang tiền gốc khi đến hạn";
                case LoaiSoTietKiem.Loai3:
                    return "Tiếp tục được gửi với lãi suất như cũ khi đến hạn";
                default:
                    return "";
            }
        }

        public static string ThongTinNguoiNhanTien(this NguoiDung ngDung)
        {
            return $"{ngDung.TenNH} - {ngDung.TenTK} - {ngDung.SoTK}";
        }
    }
}
