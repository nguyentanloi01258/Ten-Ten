using ProjectLogin.BLLLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectLogin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //public string ThongTin = string.Empty;
        BLLUser bd;

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(clsMain.pathUser);
            txtTaiKhoan.Text = "user1";
            txtMatKhau.Text = "123456";
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát khỏi trang","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }    
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    if(KiemTraDN(txtTaiKhoan.Text,txtMatKhau.Text))
                    {
                        trangThaiDongForm = true;
                        clsMain.taiKhoan = txtTaiKhoan.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác\nXin Vui lòng kiểm tra lại", "Thông Báo",              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTaiKhoan.ResetText();
                        txtMatKhau.Text = string.Empty;
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu\nXin Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản\nXin Vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }
        }

        private bool KiemTraDN(string taiKhoan, string matKhau)
        {
            return bd.KiemTraDN(taiKhoan, matKhau);
        }
        bool trangThaiDongForm = false;
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trangThaiDongForm == true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
