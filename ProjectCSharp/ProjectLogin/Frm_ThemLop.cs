using Pro03_20CT114.DataLayer.Entity;
using Project40.DataLayer.Entity;
using ProjectLogin;
using ProjectLogin.BLLLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project40
{
    public partial class Frm_ThemLop : Form
    {
        public Frm_ThemLop()
        {
            InitializeComponent();
        }
        public Lop lop;
        BLLLop bd;
       
        private void Frm_ThemLop_Load(object sender, EventArgs e)
        {
            bd = new BLLLop(clsMain.pathLop);
            txtID.Text = GetID().ToString();
            txtID.Enabled = false;//cho nìn nhưg ko cho thao tác
            txtTenLop.Focus();
        }

        private object GetID()
        {
            int max = 0;
            foreach (Lop item in clsMain.lops)
            {
                if (item.ID >= max)
                {
                    max = item.ID;
                }
            }
            return max + 1;
        }
            private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                if (!string.IsNullOrEmpty(txtTenLop.Text))
                {
                    if (!string.IsNullOrEmpty(txtKhoa.Text))
                    {

                        lop = new Lop()
                        {
                            ID = Convert.ToInt32(txtID.Text),
                            TenLop = txtTenLop.Text,
                            Khoa = txtKhoa.Text
                        };
                        clsMain.lops.Add(lop);
                        clsMain.CapNhatDataLop(clsMain.pathLop, clsMain.lops);
                        MessageBox.Show("Cập nhật thành công", "Trạng thái", MessageBoxButtons.OK);
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtKhoa.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenLop.Focus();
                }
            }
            else
            {
                MessageBox.Show("ID bị bỏ trống, xui lòng nhập ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy thay đổi", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
