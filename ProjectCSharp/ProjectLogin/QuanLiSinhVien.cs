using Pro03_20CT111_QuaySo.Commons;
using Pro03_20CT114.DataLayer.Entity;
using Project40.DataLayer.Dao;
using Project40.DataLayer.Entity;
using ProjectLogin;
using ProjectLogin.BLLLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project40
{
    public partial class QuanLiSinhVien : Form
    {
        public QuanLiSinhVien()
        {
            InitializeComponent();
        }
        BLLSinhVien bd1;
        SinhVien sinhVienxs = null;
        private void QuanLiSinhVien_Load(object sender, EventArgs e)
        {
            bd1 = new BLLSinhVien(clsMain.pathSinhVien);
            clsMain.sinhViens = bd1.GetSinhViens();
            HienThiDanhSachSV();
        }

        private void HienThiDanhSachSV()
        {
            var bindingList = new BindingList<SinhVien>(clsMain.sinhViens);
            var bindingSource = new BindingSource(bindingList, null);
            dgvSinhVien.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_ThemSinhVien frm_ThemSinhVien=new Frm_ThemSinhVien();   
            frm_ThemSinhVien.ShowDialog();
            HienThiDanhSachSV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (sinhVienxs != null)
            {
                Frm_EditThongTinSinhVien frmEditThongTinSinhVien = new Frm_EditThongTinSinhVien();
                frmEditThongTinSinhVien.sinhvien = sinhVienxs;
                frmEditThongTinSinhVien.ShowDialog();
                HienThiDanhSachSV();
                sinhVienxs = null;
            }
            else
            {
                MessageBox.Show("Chưa chọn user cần sửa\nVui lòng chọn user", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvSinhVien_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.Rows.Count > 0)
            {
                sinhVienxs = new SinhVien()
                {
                    MSSV = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["colMSSV"].Value.ToString()),
                    HovaTen = dgvSinhVien.CurrentRow.Cells["colHoVaTen"].Value.ToString(),
                    GioiTinh = dgvSinhVien.CurrentRow.Cells["colGioiTinh"].Value.ToString(),
                    NgaySinh = dgvSinhVien.CurrentRow.Cells["colNgaySinh"].Value.ToString(),
                    DiaChi = dgvSinhVien.CurrentRow.Cells["colDiaChi"].Value.ToString(),
                    Sdt = Convert.ToInt32(dgvSinhVien.CurrentRow.Cells["colSDT"].Value.ToString()),
                    Khoa = dgvSinhVien.CurrentRow.Cells["colKhoa"].Value.ToString(),
                    Lop = dgvSinhVien.CurrentRow.Cells["colLop"].Value.ToString()
                };
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa tài khoản này!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (sinhVienxs != null)
                {
                    XoaSinhVien(sinhVienxs.MSSV);
                }
                else
                {
                    MessageBox.Show("Chưa chọn user", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
        private void XoaSinhVien(int mSSV)
        {
            //muon su dung ham ToList() thi phai add using System.Linq;
            foreach (SinhVien item in clsMain.sinhViens.ToList())
            {
                if (item.MSSV == mSSV)
                {
                    clsMain.sinhViens.Remove(item);
                    HienThiDanhSachSV();
                    sinhVienxs = null;
                    break;
                }

            }
            clsMain.CapNhatDataSinhVien(clsMain.pathSinhVien, clsMain.sinhViens);
            MessageBox.Show("Xóa thành công", "Trạng thái", MessageBoxButtons.OK);
           
        }
        public List<SinhVien> ChonSV(int mSSV)// chọn để sửa hoặc xoá
        {
            List<SinhVien> result = clsMain.sinhViens.FindAll(delegate (SinhVien sinhVien)
            {
                return sinhVien.MSSV == mSSV;
            });
            if (result.Count != 0)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cửa sổ sẽ được đóng\nxin vui lòng xác nhận", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //string value = txtSearch.Text;
            //List<SinhVien> list = new List<SinhVien>();
            //foreach (var item in clsMain.sinhViens)
            //{
            //    if (item.HovaTen.ToLower().Contains(value.ToLower()))
            //    {
            //        list.Add(item);
            //    }
            //    else if (item.MSSV.ToString().ToLower().Contains(value.ToLower()))
            //    {
            //        list.Add(item);
            //    }
            //    dgvSinhVien.Rows.Clear();
            //    int stt = 0;
            //    foreach (SinhVien i in list)
            //    {
            //        DataGridViewRow dataGridViewRow = (DataGridViewRow)dgvSinhVien.Rows[0].Clone();
            //        DataGridViewRow row = dataGridViewRow;
            //        stt++;
            //        row.Cells[0].Value = stt + "";
            //        row.Cells[1].Value = i.MSSV;
            //        row.Cells[2].Value = i.HovaTen;
            //        row.Cells[3].Value = i.GioiTinh;
            //        row.Cells[4].Value = i.NgaySinh;
            //        row.Cells[5].Value = i.DiaChi;
            //        row.Cells[6].Value = i.Sdt;
            //        row.Cells[7].Value = i.Khoa;
            //        row.Cells[8].Value = i.Lop;

            //        dgvSinhVien.Rows.Add(row);
            //    }


            //}

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {    
            long a = Convert.ToInt64(txtSearch.Text);
            int b = 0;
            dgvSinhVien.ClearSelection();
            foreach (SinhVien per in clsMain.sinhViens)
            {
                if (a == per.MSSV)
                {
                    dgvSinhVien.Rows[b].Selected = true;
                    dgvSinhVien.FirstDisplayedScrollingRowIndex = b;
                    b = 0;
                    return;
                }
                if (a == per.Sdt)
                {
                    dgvSinhVien.Rows[b].Selected = true;
                    dgvSinhVien.FirstDisplayedScrollingRowIndex = b;
                    b = 0;
                    return;
                }
                b++;
            }
        }

        private void btnXuatFileExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "xls";
            saveFileDialog.InitialDirectory = "D:\\";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportExcel.ExportExcelByInterop(saveFileDialog.FileName, dgvSinhVien, 1, "Arial", 16, 12);
            }
        }
    }
}
