using Project40.DataLayer.DatabaseType;
using Project40.DataLayer.Entity;
using ProjectLogin.BLLLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Project40.Properties;

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
        public User user;
        DataBaseTK data;
        List<User> users=null;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(clsMain.pathUser);// đừng dẫn 
            txtTaiKhoan.Focus();// tập trung con trỏ vào ô
            txtTaiKhoan.Text = Settings.Default.username;// lưu mật khẩu
            txtMatKhau.Text = Settings.Default.password;
            if (Settings.Default.username != "")
            {
                ckNhoMatKhau.Checked = true;
            }
            else ckNhoMatKhau.Checked = false;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi trang", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                        clsMain.matKhau= txtMatKhau.Text;
                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác\nXin Vui lòng kiểm tra lại", "Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        //bắt sự kiện cho nút Nhớ mật khẩu
        private void CkNhoMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNhoMatKhau.Checked)
            {
                if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
                {
                    Settings.Default.username = txtTaiKhoan.Text;
                    Settings.Default.password = txtMatKhau.Text;
                    Settings.Default.Save();//lưu lại 
                }
            }else
            {               
                    Settings.Default.Reset();//xoá và lưu cái mặc định
   
            }
        }

        private void PbEye_Click(object sender, EventArgs e)// mở mắt
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                pbHEye.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void PbHEye_Click(object sender, EventArgs e)// đóng mắt
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                pbEye.BringToFront();//nhảy ra sau
                txtMatKhau.PasswordChar = '\0';// click để thay đổi , /0 nhữg kí tự bình thường
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
