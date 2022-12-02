using Pro03_20CT114.DataLayer.Entity;
using Project40.DataLayer.Dao;
using Project40.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLogin.BLLLayer
{
    public class BLLSinhVien
    {
        SinhVienDao sinhvienDao;
        public BLLSinhVien(string path)
        {
            sinhvienDao = new SinhVienDao(path);
        }
        
        public List<SinhVien> GetSinhViens() 
        {
            return sinhvienDao.GetListSinhViens();
        }
        public bool CapNhatDuLieuSV(List<SinhVien> sinhViens)
        {
            return sinhvienDao.CapNhatDuLieuSV(sinhViens);
        }
        public bool KTTrungNhau(string a)
        {
            foreach (SinhVien item in clsMain.sinhViens)
            {
                if (item.HovaTen.Equals(a) || item.HovaTen.Equals(a))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
