using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectLogin
{
    public partial class Frm_TinhHoaDon : Form
    {
        public Frm_TinhHoaDon()
        {
            InitializeComponent();
        }
        List<HoaDon> products;
        List<HoaDon> hoaDon;
        private void Frm_TinhHoaDon_Load(object sender, EventArgs e)
        {
            products = new List<HoaDon>()
            {
                new HoaDon(){ProductName="Cafe Phin Sữa Đá",Price=39000},
                new HoaDon("Cafe Phin Đen Đá",29000),
                new HoaDon("Bạc Xỉu",29000),
                new HoaDon("Trà Sen Vàng",40000),
                new HoaDon("Trà Thạch Đào",45000),
                new HoaDon("Bánh Chuối",29000),
                new HoaDon("Phô Mai Chanh Dây",29000),
                new HoaDon("Freeze Trà Xanh",55000),
                new HoaDon("Cappuchino",45000)
            };
            hoaDon = new List<HoaDon>();
            LoadMenu(products);
        }
        

        private void LoadMenu(List<HoaDon> products)
        {
            lblMenu.Items.Clear();
            lblMenu.DataSource = products;

            lblMenu.DisplayMember = "Display";
            lblMenu.ValueMember = "ProductName";

            lblMenu.SelectedIndex = 0;
        }

        private void lbMenu_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(lbMenu.SelectedValue.ToString());
        }
        private HoaDon ChonSanPham(string productName)
        {
            foreach (HoaDon item in products)
            {
                if (item.ProductName == productName)
                    return item;
            }
            return null;
        }
      
        double tongThanhTien = 0;
        double thue = 0;
        private void LoadHoaDon(List<HoaDon> hoaDon)
        {
            //Xóa datasource và items trên listBox
            lblHoaDon.DataSource = null;
            lblHoaDon.Items.Clear();
            //gán lại Datasource và thuộc tính Displaymember cho listBox.
            lblHoaDon.DataSource = hoaDon;
            lblHoaDon.DisplayMember = "Display";
            //Tính tổng thành tiền của hóa đơn
            TinhTien(ref tongThanhTien, hoaDon);
        }

        private void TinhTien(ref double tongThanhTien, List<HoaDon> hoaDon)
        {
            tongThanhTien = 0;
         
            foreach (HoaDon item in hoaDon)
            {
                tongThanhTien += item.Price;
            }
           
            lblSoTien.Text = string.Format("Số tiền: {0:#,###} VND", tongThanhTien);
            lblThue.Text= string.Format("Thuế VAT (8%): {0:#,###} VND", tongThanhTien*0.08);
            lblTong.Text= string.Format("Tổng: {0:#,###} VND", tongThanhTien * 0.08+tongThanhTien);
        }

        private void btnThucHienLai_Click(object sender, EventArgs e)
        {
            Huy();

        }

        private void Huy()
        {
            lblHoaDon.DataSource = null;
            lblHoaDon.Items.Clear();
            tongThanhTien = 0;
            lblSoTien.Text = string.Format("Số tiền: {0:#,###0} VND", tongThanhTien);
            lblThue.Text = string.Format("Thuế VAT (8%): {0:#,###0} VND", tongThanhTien);
            lblTong.Text = string.Format("Tổng: {0:#,###0} VND", tongThanhTien);
        }

        private void btnChon_Click_1(object sender, EventArgs e)
        {

            if (lblMenu.SelectedIndex >= 0)
            {
                hoaDon.Add(ChonSanPham(lblMenu.SelectedValue.ToString()));
            }
            LoadHoaDon(hoaDon);
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            if (lblHoaDon.SelectedIndex >= 0)
            {
                hoaDon.RemoveAt(lblHoaDon.SelectedIndex);
                LoadHoaDon(hoaDon);
            }
        }

        private void btnChonHet_Click_1(object sender, EventArgs e)
        {
            hoaDon = products;
            LoadHoaDon(hoaDon);
        }

        private void btnHuyHet_Click(object sender, EventArgs e)
        {
            Huy();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnThucHienLai_Click_1(object sender, EventArgs e)
        {
            Huy();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
