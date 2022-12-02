using Project40.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro03_20CT114.DataLayer.Entity
{
   public class Lop : IComparable
    {

        //field
        private int iD;
        private string tenLop;
        private string khoa;

        public int ID { get => iD; set => iD = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        //Properties

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
            return string.Format("{0},{1},{2}", ID, TenLop, Khoa);
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
