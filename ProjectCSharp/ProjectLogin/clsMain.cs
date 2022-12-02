using ProjectLogin.BLLLayer;
using ProjectLogin.DataLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLogin
{
    public class clsMain
    {
        public static string taiKhoan = string.Empty;
        public static string matKhau = string.Empty;
        public static string pathUser = string.Format(@"{0}\DanhSachUsers.txt", Application.StartupPath);
        public static List<User> users = null;

        public static void CapNhatData(string path, List<User> users)
        {
            BLLUser bd = new BLLUser(path);
            bd.CapNhatDuLieu(clsMain.users);
        }
    }
   
}
