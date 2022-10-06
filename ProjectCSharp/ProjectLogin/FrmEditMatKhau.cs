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
    public partial class FrmEditMatKhau : Form
    {
        public FrmEditMatKhau()
        {
            InitializeComponent();
        }
        BLLUser bd;
        private void FrmEditMatKhau_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(clsMain.pathUser);
            clsMain.users = bd.GetListUsers();// lấy thông tin người dùng
            LoadUser();
        }
        //Cho hiển thị danh sach user vào bảng chọn cbbDanhSachUser
        private void LoadUser()
        {
            cbbDanhSachUser.DataSource = clsMain.users;// combobox sổ xuống
            cbbDanhSachUser.DisplayMember = "TaiKhoan";
            cbbDanhSachUser.ValueMember = "ID";
            cbbDanhSachUser.SelectedIndex = -1;
            cbbDanhSachUser.Text = "---Chọn tài khoản---";
        }
        //Gắn chức năng cho nút reset mậ khẩu
        private void LblResetMatKhau_Click(object sender, EventArgs e)
        {
            if (cbbDanhSachUser.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần reset mật khẩu", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (clsMain.taiKhoan.Equals("admin"))
                {
                    if (cbbDanhSachUser.SelectedIndex > -1)
                    {
                        CapNhatMatKhau(cbbDanhSachUser.SelectedValue.ToString(), "tenten@123", true);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền làm điều này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
            
        }
        //tao ham cap nhat mat khau cho nuts reset va nut xac nhan
        private void CapNhatMatKhau(string iD,string matKhau,bool isID)
        {
            foreach(User item in clsMain.users)
            {
                if (isID)
                {
                    if (item.ID.ToString().Equals(iD))
                    {
                        item.MatKhau = matKhau;
                        break;
                    }
                }
                else
                {
                    if (item.TaiKhoan.ToString().Equals(iD))
                    {
                        item.MatKhau = matKhau;
                        break;
                    }
                }
            }
            clsMain.CapNhatData(clsMain.pathUser, clsMain.users);
            MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }
        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            if (clsMain.matKhau.ToString().Equals(txtMatKhauCu.Text.ToString()))
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text))
            {
                if (txtMatKhau.Text.Length < 8)
                {
                    MessageBox.Show("Mật khẩu phải dài từ 8 kí tự trở lên\nGợi ý: nên có kí tự(*,#,$,...), chữ hoa(A,B,C,...) và số(0,1,2...) để đảm bảo mật khẩu mạnh.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtNhapLaiMatKhau.Text))
                    {
                        
                            if (txtMatKhau.Text.Equals(txtNhapLaiMatKhau.Text))
                            {
                                if (txtMatKhau.Text.Equals(txtMatKhauCu.Text))
                                {
                                    MessageBox.Show("Mật khẩu mới phải khác với mật khẩu hiện tại. vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    CapNhatMatKhau(clsMain.taiKhoan, txtMatKhau.Text, false);
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu không trùng nhau. vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK);
                                txtMatKhau.ResetText();
                                txtNhapLaiMatKhau.ResetText();
                                txtMatKhau.Focus();
                            }

                    }
                    else
                    {
                        MessageBox.Show("Không được để trống", "Thông báo", MessageBoxButtons.OK);
                        txtNhapLaiMatKhau.Focus();
                    }
                }                
            }
            else
            {
                MessageBox.Show("Chưa nhập mật khẩu","Thông báo",MessageBoxButtons.OK);
                txtMatKhau.Focus();
            }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác. vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK);
                txtMatKhauCu.Focus();
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát cửa sổ đổi mật khẩu","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void PbEye_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                pbHEye.BringToFront();
                txtMatKhau.PasswordChar = '*';
                txtMatKhauCu.PasswordChar = '*';
                txtNhapLaiMatKhau.PasswordChar = '*';
            }
        }

        private void PbHEye_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                pbEye.BringToFront();
                txtMatKhau.PasswordChar = '\0';
                txtMatKhauCu.PasswordChar = '\0';
                txtNhapLaiMatKhau.PasswordChar = '\0';
            }
        }
    }
}
