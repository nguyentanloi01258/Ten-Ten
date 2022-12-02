using Pro03_20CT114.DataLayer.Entity;
using Project40.DataLayer.Dao;
using Project40.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLogin.BLLLayer
{
    public class BLLLop
    {
        LopDao lopDao;
        public BLLLop(string path)
        {
            lopDao = new LopDao(path);
        }
        
        public List<Lop> GetListLop()
        {
            return lopDao.GetListLop();
        }
        public bool CapNhatDuLieuLop(List<Lop> lops)
        {
            return lopDao.CapNhatDuLieuLop(lops);
        }
        public bool KTTrungNhau(string a)
        {
            foreach (Lop item in clsMain.lops)
            {
                if (item.TenLop.Equals(a) || item.TenLop.Equals(a))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
