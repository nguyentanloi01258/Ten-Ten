using System;
using System.Collections.Generic;
using System.Text;
using Project40.DataLayer.DatabaseType;
using Project40.DataLayer.Entity;
using ProjectLogin;

namespace Project40.DataLayer.Dao
{
    public class UserDao
    {
        DataBaseTK data;

        public UserDao(string path)
        {
            data = new DataBaseTK(path);
        }
        public bool KiemTraDN(string taiKhoan, string matKhau)
        {
            bool result = false;
            List<User> users = data.ReadListUser();
            foreach (User item in users)
            {
                if (item.TaiKhoan.Equals(taiKhoan) && item.MatKhau.Equals(matKhau))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        
        public List<User> GetListUsers()
        {
            return data.ReadListUser();
        }
        public bool CapNhatDuLieu(List<User> users)
        {
            return data.WriteUsertoFile(users);
        }
    }
}
