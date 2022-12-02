using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLogin.SinhVien
{
    public class SinhVien
    {
        private long maSSV;
        private string hoVaTen;
        private string gioiTinh;
        private string ngaysinh;
        private string diachi;
        private string khoa;
        private string lop;
        //private int tinhtrang;
        //private int diem;

        public long MaSSV { get => maSSV; set => maSSV = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string Lop { get => lop; set => lop = value; }

        public SinhVien() { }

        public SinhVien(long maSSV, string ten, string hoVaTen, string gioitinh,string ngaysinh, string diachi,string khoa,string lop )
        {
            this.MaSSV = maSSV;
            this.HoVaTen = ten;
            this.GioiTinh = gioitinh;
            this.Ngaysinh = ngaysinh;
            this.Diachi = diachi;
            this.Khoa = khoa;
            this.Lop = lop;
        }

    }
}
