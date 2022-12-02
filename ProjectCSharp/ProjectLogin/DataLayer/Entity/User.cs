using System;
using System.Collections.Generic;
using System.Text;

namespace Project40.DataLayer.Entity
{
    public class User : IComparable
    {
        private int iD;
        private string taiKhoan, matKhau, hoVaTen;
        private bool nhoMatKhau;

        public int ID { get { return iD; } set { iD = value; } }
        public string TaiKhoan { get { return taiKhoan; } set => taiKhoan = value; }
        public string MatKhau { get { return matKhau; } set => matKhau = value; }
        public string HoVaTen { get { return hoVaTen; } set => hoVaTen = value; }
        public bool NhoMatKhau { get { return nhoMatKhau; } set => nhoMatKhau = value; }

        public int CompareTo(object obj)
        {
            if (obj is User)
            {
                return ((User)obj).ID.CompareTo(ID);
            }
            return -1;
        }
        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", ID, TaiKhoan, MatKhau, HoVaTen, NhoMatKhau.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj is User)
            {
                return ((User)obj).ID.ToString().Equals(ID.ToString());
            }
            return false;
        }

    }

}
