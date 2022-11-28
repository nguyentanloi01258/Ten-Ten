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
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }
        private void Frm_main_Load(object sender, EventArgs e)
        {
            pnlHeThong.Height = 204;
            pnlChucNang.Height = 50;
            LoadFormDangNhap();
          
        }
        public void LoadFormDangNhap()
        {
            FrmLogin frmLogin =new FrmLogin();
            frmLogin.ShowDialog();
            lblTrangThai.Text = string.Format("Hệ thống được đăng nhập bởi: {0}", clsMain.taiKhoan);
            
        }
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            if (pnlHeThong.Height == 204)
            {
                pnlHeThong.Height = 50;
            }
            else
            {
                pnlHeThong.Height = 204;
                pnlChucNang.Height = 50;
              
            }
        }
        private void btnChucNang_Click(object sender, EventArgs e)
        {
            if (pnlChucNang.Height == 103)
            {
                pnlChucNang.Height = 50;
            }
            else
            {
                pnlChucNang.Height = 103;
                pnlHeThong.Height = 50;

            }
        }
        private void btnQuanLiTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmQuanLiTaiKhoan frmQuanLiTaiKhoan = new FrmQuanLiTaiKhoan();
            frmQuanLiTaiKhoan.ShowDialog();
            Dock = DockStyle.Fill;//dinh dạng phần còn lại màn hình
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FrmEditMatKhau frmEditMatKhau=new FrmEditMatKhau();
            frmEditMatKhau.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất khỏi phiên này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoadFormDangNhap();
            }
        }

        private void btnTinhBill_Click(object sender, EventArgs e)
        {
            Frm_TinhHoaDon frm_TinhHoaDon = new Frm_TinhHoaDon();
            frm_TinhHoaDon.ShowDialog();
        }
    }
}
