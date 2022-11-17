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
    public partial class FrmThemTaiKhoan : Form
    {
        public FrmThemTaiKhoan()
        {
            InitializeComponent();
        }
        public User user;
        public bool isAdd = false;
        BLLUser bd;

        private void FrmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(clsMain.pathUser);
            txtID.Text = GetID().ToString();
            txtID.Enabled = false;//cho nìn nhưg ko cho thao tác
            txtHoVaTen.Focus();
            
        }

        private int GetID() // lấy id lớn nhất
        {
            int max = 0;
            foreach(User item in clsMain.users)
            {
                if(item.ID>=max)
                {
                    max = item.ID;
                }
            }
            return max + 1;
        }
        
        private void BtnThemTK_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtHoVaTen.Text))
            {
                if(bd.KTTrungNhau(txtHoVaTen.Text.ToString()))
                {
                    if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
                    {
                        if (bd.KTTrungNhau(txtTaiKhoan.Text.ToString()))
                        {
                            if (txtMatKhau.Text.Length < 8)
                            {
                                MessageBox.Show("Mật khẩu phải dài từ 8 kí tự trở lên\nGợi ý: nên có kí tự(*,#,$,...), chữ hoa(A,B,C,...) và số(0,1,2...) để đảm bảo mật khẩu mạnh.", "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(txtMatKhau.Text))
                                {
                                    if (!string.IsNullOrEmpty(txtNhapLaiMatKhau.Text))
                                    {
                                        if (txtMatKhau.Text == txtNhapLaiMatKhau.Text)
                                        {
                                            user = new User()
                                            {
                                                ID = Convert.ToInt32(txtID.Text),
                                                HoVaTen = txtHoVaTen.Text,
                                                TaiKhoan = txtTaiKhoan.Text,
                                                MatKhau = txtMatKhau.Text,
                                                NhoMatKhau = ckNhoMatKhau.Checked
                                            };

                                            clsMain.users.Add(user);
                                            clsMain.CapNhatData(clsMain.pathUser, clsMain.users);
                                            MessageBox.Show("Thêm tài khoản mới thành công", "Trạng thái", MessageBoxButtons.OK);
                                            this.Close();


                                        }
                                        else
                                        {
                                            MessageBox.Show("Mật khẩu không không khớp\nVui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            txtMatKhau.ResetText();
                                            txtNhapLaiMatKhau.ResetText();
                                            txtMatKhau.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nhập lại mật khẩu vẫn chưa nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtNhapLaiMatKhau.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtMatKhau.Focus();
                                }
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản này đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                        }  
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Họ và Tên này đã tồn tại, vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK);
                }                
            }
            else
            {
                MessageBox.Show("Chưa nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoVaTen.Focus();
            }
        }
    }
}
