using ProjectLogin.BLLLayer;
using ProjectLogin.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectLogin
{
    public partial class FrmEditTaiKhoan : Form
    {
        public FrmEditTaiKhoan()
        {
            InitializeComponent();
        }
        public User user;
        BLLUser bd;
        private void FrmEditTaiKhoan_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(clsMain.pathUser);         
            txtID.Text = user.ID.ToString();txtID.Enabled = false;
            txtHoVaTen.Text = user.HoVaTen;
            txtTaiKhoan.Text = user.TaiKhoan;
            txtMatKhau.Text = user.MatKhau;
            txtMatKhau.Enabled = false;
            ckNhoMatKhau.Checked = user.NhoMatKhau;
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text))
            {
                if (!string.IsNullOrEmpty(txtHoVaTen.Text))
                {
                    if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
                    {

                        user = new User()
                        {
                            ID = Convert.ToInt32(txtID.Text),
                            HoVaTen = txtHoVaTen.Text,
                            TaiKhoan = txtTaiKhoan.Text,
                            MatKhau = txtMatKhau.Text,
                            NhoMatKhau = ckNhoMatKhau.Checked
                        };
                        foreach (User item in clsMain.users)
                        {
                            if (item.ID == user.ID)
                            {
                                item.ID = user.ID;
                                item.HoVaTen = user.HoVaTen;
                                item.TaiKhoan = user.TaiKhoan;
                                item.MatKhau = user.MatKhau;
                                item.NhoMatKhau = user.NhoMatKhau;
                            }
                        }      
                        clsMain.CapNhatData(clsMain.pathUser, clsMain.users);
                        MessageBox.Show("Cập nhật thành công", "Trạng thái", MessageBoxButtons.OK);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHoVaTen.Focus();
                }
            }
            else
            {
                MessageBox.Show("ID bị bỏ trống, xui lòng nhập ID", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn hủy thay đổi","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

       /* private void PbHEye_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                pbHEye.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void PbEye_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                pbEye.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }*/
    }
}
