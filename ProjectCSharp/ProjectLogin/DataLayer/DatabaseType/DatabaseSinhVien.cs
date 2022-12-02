using Pro03_20CT114.DataLayer.Entity;
using Project40.DataLayer.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLogin;


namespace Pro03_20CT114.DataLayer.DatabaseType
{
   public class DatabaseSinhVien
    {
        private string path = string.Empty;
        public DatabaseSinhVien(string path)
        {
            this.path = path;
        }
        //ham doc file tu text
        public List<SinhVien> ReadListSinhVien()
        {
            List<SinhVien> sinhViens = null;
            //cau truc doc file
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))//lỗi
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string line = string.Empty;
                    SinhVien sinhVien;
                    sinhViens = new List<SinhVien>();
                   
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] vs = line.Split(',');
                            sinhVien = new SinhVien()
                            {
                                MSSV = Convert.ToInt32(vs[0]),
                                HovaTen = vs[1],
                                GioiTinh = vs[2],
                                NgaySinh = vs[3],
                                DiaChi = vs[4],
                                Sdt = Convert.ToInt32(vs[5]),
                                Khoa = vs[6],
                                Lop = vs[7]
                            };
                            sinhViens.Add(sinhVien);
                        }
                    }
                }
            }
            return sinhViens;
        }
        //ham ghi vao file txt user
        public bool WriteSinhVientoFile(List<SinhVien> sinhViens)
        {
            bool result = false;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    foreach (SinhVien item in sinhViens)
                    {
                        streamWriter.WriteLine(item.ToString());
                    }
                    result = true;
                }
            }
            return result;
        }
    }

}

