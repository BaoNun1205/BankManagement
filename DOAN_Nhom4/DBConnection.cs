using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System.IO;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using DOAN_Nhom4.Entities;

namespace DOAN_Nhom4
{
    internal class DBConnection
    {
        public DBConnection() { }
        public bool IsEmail(string email)
        {
            string strRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(email);
        }
        public bool IsPhone(string numberphone)
        {
            string strRegex = @"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$";
            Regex regex = new Regex(strRegex);
            return regex.IsMatch(numberphone);
        }      
    }
}
