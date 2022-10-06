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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            HienThiFrmLogin();
        }
        private void HienThiFrmLogin()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            lblThoiGian.Text = DateTime.Now.ToString();
            tmrGioHeThong.Start();
            lblThongTinNguoiDN.Text = string.Format("Người dùng {0},{1}", clsMain.taiKhoan, " đang truy cập vào hệ thống. ");
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Chương trình sẽ được thoát\nBạn hãy xác nhận","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }    
            
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            HienThiFrmLogin();
        }
        private void tmrGioHeThong_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString();
        }
    }
}
