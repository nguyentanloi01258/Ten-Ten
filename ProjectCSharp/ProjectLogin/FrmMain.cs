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
{//mã màu 167,108,232
    //SteelBlue
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            HienThiFrmLogin();
            pnl_main_HeThong.Height = 251;
            pnl_main_TacVu.Height = 45;
            tmr_main_GHT.Enabled = true;
            lbl_main_GioHeThong.Text = string.Format("{0}", DateTime.Now.ToString());
            tmr_main_GHT.Start();

        }
        private void HienThiFrmLogin()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            lbl_main_GioHeThong.Text = DateTime.Now.ToString();
            tmr_main_GHT.Start();
           // lblThongTinNguoiDN.Text = string.Format("Người dùng {0},{1}", clsMain.taiKhoan, " đang truy cập vào hệ thống. ");
        }
        private void tmrGioHeThong_Tick(object sender, EventArgs e)
        {
            lbl_main_GioHeThong.Text = string.Format("{0}", DateTime.Now.ToString());
        }

        private void btn_main_HeThong_Click(object sender, EventArgs e)
        {
            if (pnl_main_HeThong.Height == 280)//250,40
            {
                pnl_main_HeThong.Height = 50;
            }
            else
            {
                pnl_main_HeThong.Height = 280;
                pnl_main_TacVu.Height = 50;
            }
        }

        private void btn_main_TacVu_Click(object sender, EventArgs e)
        {
            if (pnl_main_TacVu.Height == 280)
            {
                pnl_main_TacVu.Height = 50;
            }
            else
            {
                pnl_main_TacVu.Height = 280;
                pnl_main_HeThong.Height = 50;
            }
        }

        private void btn_main_TaiKhoan_Click(object sender, EventArgs e)
        {
            FrmQuanLiTaiKhoan frmQuanLiTaiKhoan = new FrmQuanLiTaiKhoan();
            frmQuanLiTaiKhoan.ShowDialog();
        }

        private void btn_main_DoiMK_Click(object sender, EventArgs e)
        {
            FrmEditMatKhau frmEditMatKhau = new FrmEditMatKhau();
            frmEditMatKhau.ShowDialog();
        }

        private void btn_main_DangXuat_Click(object sender, EventArgs e)
        {
            HienThiFrmLogin();
        }

        private void btn_main_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chương trình sẽ được thoát \n Bạn hãy xác nhận", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
   
        private void btn_main_XLNgNg_Click(object sender, EventArgs e)
        {
            FrmXuLyNgonNgu frmXuLyNgonNgu = new FrmXuLyNgonNgu();
            frmXuLyNgonNgu.ShowDialog();
        }

        private void btn_main_MaTran_Click(object sender, EventArgs e)
        {
            Frm_Matran frm_Matran = new Frm_Matran();
            frm_Matran.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //thêm tabcontrol
            string title = "TabPage " + (tabControl_main.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl_main.TabPages.Add(myTabPage);
            //Xóa tabcontrol
            // xoa tab đã chọn
            tabControl_main.TabPages.Remove(tabControl1.SelectedTab);
            // xóa tất cả tab
            tabControl_main.TabPages.Clear();
        }

        private void bit_main_X_Click(object sender, EventArgs e)//btn
        {
            if (MessageBox.Show("Chương trình sẽ được thoát \n Bạn hãy xác nhận", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
