using ProjectLogin.BLLLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project40.DataLayer.Entity;
using Pro03_20CT114.DataLayer.Entity;

namespace ProjectLogin
{
    public class clsMain
    {
        public static string taiKhoan = string.Empty;
        public static string matKhau = string.Empty;
        public static string pathUser = string.Format(@"{0}\DanhSachUsers.txt", Application.StartupPath);
        public static string pathSinhVien = string.Format(@"{0}\DanhSachSinhVien.txt", Application.StartupPath);
        public static string pathLop = string.Format(@"{0}\DanhSachLop.txt", Application.StartupPath);
        public static List<User> users = null;
        public static List<SinhVien> sinhViens= null;
        public static List<Lop> lops = null;

        public static void CapNhatData(string path, List<User> users)
        {
            BLLUser bd = new BLLUser(path);
            bd.CapNhatDuLieu(clsMain.users);
        }
        public static void CapNhatDataSinhVien(string path, List<SinhVien> sinhViens)
        {
            BLLSinhVien bd = new BLLSinhVien(path);
            bd.CapNhatDuLieuSV(clsMain.sinhViens);
        }
        public static void CapNhatDataLop(string path, List<Lop> lops)
        {
            BLLLop bd = new BLLLop(path);
            bd.CapNhatDuLieuLop(clsMain.lops);
        }
    }
   
}
