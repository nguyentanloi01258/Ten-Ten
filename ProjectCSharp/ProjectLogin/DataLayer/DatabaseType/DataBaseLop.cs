using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Project40.DataLayer.Entity;
using Pro03_20CT114.DataLayer.Entity;

namespace Project40.DataLayer.DatabaseType
{
    public class DataBaseLop
    {
        private string path = string.Empty;
        public DataBaseLop(string path)
        {
            this.path = path;
        }
        //ham doc file tu text
        public List<Lop> ReadListLop()
        {
            List<Lop> lops = null;
            //cau truc doc file
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))//lỗi
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    string line = string.Empty;
                    Lop lop;
                    lops = new List<Lop>();
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            string[] vs = line.Split(',');
                            lop = new Lop()
                            {
                                ID = Convert.ToInt32(vs[0]),
                                TenLop = vs[1],
                                Khoa = vs[2]
                            };
                            lops.Add(lop);
                        }
                    }
                }
            }
            return lops;
        }
        //ham ghi vao file txt user
        public bool WriteLoptoFile(List<Lop> lops)
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
                    foreach (Lop item in lops)
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
