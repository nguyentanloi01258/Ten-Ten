using Project40.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT114.DataLayer.Entity
{
   public class SinhVien : IComparable
    {
        //field
        private int mSSV;
        private string hovaTen;
        private string goiTinh;
        private string ngaySinh;
        private string diaChi;
        private int sdt;
        private string khoa;
        private string lop;

        public int MSSV { get => mSSV; set => mSSV = value; }
        public string HovaTen { get => hovaTen; set => hovaTen = value; }
        public string GioiTinh { get => goiTinh; set => goiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int Sdt { get => sdt; set => sdt = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string Lop { get => lop; set => lop = value; }
        //Properties
        public int CompareTo(object obj)
        {
            if (obj is User)
            {
                return ((User)obj).ID.CompareTo(MSSV);
            }
            return -1;
        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", MSSV, HovaTen, GioiTinh, NgaySinh, DiaChi, Sdt,Khoa,Lop);
        }

        public override bool Equals(object obj)
        {
            if (obj is User)
            {
                return ((User)obj).ID.ToString().Equals(MSSV.ToString());
            }
            return false;
        }

    }
}
