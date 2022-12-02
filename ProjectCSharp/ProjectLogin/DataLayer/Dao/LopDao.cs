using System;
using System.Collections.Generic;
using System.Text;
using Pro03_20CT114.DataLayer.Entity;
using Project40.DataLayer.DatabaseType;
using Project40.DataLayer.Entity;

namespace Project40.DataLayer.Dao
{
    public class LopDao
    {
        DataBaseLop data;

        public LopDao(string path)
        {
            data = new DataBaseLop(path);
        }
       
        public List<Lop> GetListLop()
        {
            return data.ReadListLop();
        }
        public bool CapNhatDuLieuLop(List<Lop> lops)
        {
            return data.WriteLoptoFile(lops);
        }
    }
}
