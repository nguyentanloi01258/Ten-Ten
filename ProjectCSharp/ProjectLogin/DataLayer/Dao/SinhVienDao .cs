using System;
using System.Collections.Generic;
using System.Text;
using Pro03_20CT114.DataLayer.DatabaseType;
using Pro03_20CT114.DataLayer.Entity;
using Project40.DataLayer.DatabaseType;
using Project40.DataLayer.Entity;

namespace Project40.DataLayer.Dao
{
    public class SinhVienDao
    {
        DatabaseSinhVien data;

        public SinhVienDao(string path)
        {
            data = new DatabaseSinhVien(path);
        } 
        public List<SinhVien> GetListSinhViens()
        {
            return data.ReadListSinhVien();
        }
        public bool CapNhatDuLieuSV(List<SinhVien> sinhViens)
        {
            return data.WriteSinhVientoFile(sinhViens);
        }
    }
}
