using ProjectLogin.BLLLayer;
using ProjectLogin.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLogin
{
    public partial class FrmQuanLiTaiKhoan : Form
    {
        public FrmQuanLiTaiKhoan()
        {
            InitializeComponent();
        }
        BLLUser bd1;
        User userxs = null;
        private void FrmQuanLiTaiKhoan_Load(object sender, EventArgs e)
        {
            bd1 = new BLLUser(clsMain.pathUser);
            clsMain.users = bd1.GetListUsers();
            HienThiDanhSachUsers();
        }
        private void HienThiDanhSachUsers()
        {
            var bindingList = new BindingList<User>(clsMain.users);
            var bindingSource = new BindingSource(bindingList, null);
            dgvUsers.DataSource = bindingSource;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Cửa sổ sẽ được đóng\nxin vui lòng xác nhận","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
            }
        }
        private void DgvUsers_Click(object sender, EventArgs e)
        {
            if(dgvUsers.Rows.Count>0)
            {
                userxs = new User()
                {
                    ID=Convert.ToInt32(dgvUsers.CurrentRow.Cells["colID"].Value.ToString()),
                    HoVaTen = dgvUsers.CurrentRow.Cells["colHoVaTen"].Value.ToString(),
                    TaiKhoan = dgvUsers.CurrentRow.Cells["colTaiKhoan"].Value.ToString(),
                    MatKhau = dgvUsers.CurrentRow.Cells["colMatKhau"].Value.ToString(),
                    NhoMatKhau = Convert.ToBoolean(dgvUsers.CurrentRow.Cells["colNhoMatKhau"].Value.ToString())
                };
            }
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa tài khoản này!!!","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (userxs != null)
                {
                    XoaUser(userxs.ID);
                }
                else
                {
                    MessageBox.Show("Chưa chọn user", "Thông báo", MessageBoxButtons.OK);
                }
            }
            
        }
        private void XoaUser(int iD)
        {
            //muon su dung ham ToList() thi phai add using System.Linq;
            foreach (User item in clsMain.users.ToList())
            {
                if(item.ID==iD)
                {
                    clsMain.users.Remove(userxs);
                    HienThiDanhSachUsers();
                    userxs = null;
                    break;
                }

            }
            clsMain.CapNhatData(clsMain.pathUser, clsMain.users);
            MessageBox.Show("Xóa thành công", "Trạng thái", MessageBoxButtons.OK);
        }
       /* private void XoaUser(string iD)
        {
            User user = ChonUser(Convert.ToInt32(iD))[0];
            clsMain.users.Remove(user);
            clsMain.CapNhatData(clsMain.pathUser, clsMain.users);
            HienThiDanhSachUsers();
        }*/
        public List<User> ChonUser(int iD)// chọn để sửa hoặc xoá
        {
            List<User> result = clsMain.users.FindAll(delegate (User user)
            {
                return user.ID == iD;
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

        private void BtnThem_Click(object sender, EventArgs e)
        {
            FrmThemTaiKhoan frmthemTaiKhoan = new FrmThemTaiKhoan();
            frmthemTaiKhoan.ShowDialog();
            HienThiDanhSachUsers();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (userxs != null)
            {
                FrmEditTaiKhoan frmEditTaiKhoan = new FrmEditTaiKhoan();
                frmEditTaiKhoan.user = userxs;
                frmEditTaiKhoan.ShowDialog();
                HienThiDanhSachUsers();
                userxs = null;
            }
            else
            {
                MessageBox.Show("Chưa chọn user cần sửa\nVui lòng chọn user", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
    }
}
