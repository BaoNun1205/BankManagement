using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_Nhom4
{
    public class ClassAddForm
    {
        static public void addForm(Form form, Panel pnlNguoidung)
        {
            pnlNguoidung.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlNguoidung.Controls.Add(form);
            pnlNguoidung.Tag = form;
            form.Show();
        }
    }
}
