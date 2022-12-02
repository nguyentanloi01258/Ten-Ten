using Project40.DataLayer.Dao;
using Project40.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLogin.BLLLayer
{
    public class BLLUser
    {
        UserDao userDao;
        public BLLUser(string path)
        {
            userDao = new UserDao(path);
        }
        public bool KiemTraDN(string taiKhoan,string matKhau)
        {
            return userDao.KiemTraDN(taiKhoan, matKhau);
        }
        public List<User> GetListUsers()
        {
            return userDao.GetListUsers();
        }
        public bool CapNhatDuLieu(List<User> users)
        {
            return userDao.CapNhatDuLieu(users);
        }
        public bool KTTrungNhau(string a)
        {
            foreach (User item in clsMain.users)
            {
                if (item.HoVaTen.Equals(a) || item.TaiKhoan.Equals(a))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
