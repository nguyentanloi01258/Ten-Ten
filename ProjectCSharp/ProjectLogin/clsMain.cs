using ProjectLogin.DataLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProjectLogin
{
    public class clsMain
    {
        public static string taiKhoan = string.Empty;
        public static string pathUser = string.Format(@"{0}\DanhSachUsers.txt", Application.StartupPath);
        public static List<User> users = null;
    }
}
