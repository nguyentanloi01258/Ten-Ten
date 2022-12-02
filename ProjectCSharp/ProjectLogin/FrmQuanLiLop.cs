using Pro03_20CT114.DataLayer.Entity;
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
    public partial class FrmQuanLiLop : Form
    {
        public FrmQuanLiLop()
        {
            InitializeComponent();
        }
        BLLLop bd;
        Lop lopsx = null;
        private void FrmQuanLiLop_Load(object sender, EventArgs e)
        {
            bd = new BLLLop(clsMain.pathLop);
            clsMain.lops = bd.GetListLop();
            HienThiDanhSachLop();
        }

        private void HienThiDanhSachLop()
        {
            var bindingList = new BindingList<Lop>(clsMain.lops);
            var bindingSource = new BindingSource(bindingList, null);
            dgvLop.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Frm_ThemLop frm_ThemLop=new Frm_ThemLop();
            frm_ThemLop.ShowDialog();
            HienThiDanhSachLop();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lopsx != null)
            {
                Frm_SuaThongTinLop frm_SuaThong = new Frm_SuaThongTinLop();
                frm_SuaThong.lop = lopsx;
                frm_SuaThong.ShowDialog();
                HienThiDanhSachLop();
                lopsx = null;
            }
            else
            {
                MessageBox.Show("Chưa chọn user cần sửa\nVui lòng chọn user", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa tài khoản này!!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (lopsx != null)
                {
                    XoaLop(lopsx.ID);
                }
                else
                {
                    MessageBox.Show("Chưa chọn user", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void XoaLop(int iD)
        {
            foreach (Lop item in clsMain.lops.ToList())
            {
                if (item.ID == iD)
                {
                    clsMain.lops.Remove(lopsx);
                    HienThiDanhSachLop();
                    lopsx = null;
                    break;
                }

            }
            clsMain.CapNhatDataLop(clsMain.pathLop, clsMain.lops);
            MessageBox.Show("Xóa thành công", "Trạng thái", MessageBoxButtons.OK);
        }
        public List<Lop> ChonLop(int iD)// chọn để sửa hoặc xoá
        {
            List<Lop> result = clsMain.lops.FindAll(delegate (Lop lop)
            {
                return lop.ID == iD;
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

        private void dgvLop_Click(object sender, EventArgs e)
        {
            if (dgvLop.Rows.Count > 0)
            {
                lopsx = new Lop()
                {
                    ID = Convert.ToInt32(dgvLop.CurrentRow.Cells["colID"].Value.ToString()),
                    TenLop = dgvLop.CurrentRow.Cells["colTenLop"].Value.ToString(),
                    Khoa = dgvLop.CurrentRow.Cells["colKhoa"].Value.ToString()

                };
            }
        }
    }
}
