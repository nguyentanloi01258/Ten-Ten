using ProjectLogin.DataLayer;
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
    }
}
