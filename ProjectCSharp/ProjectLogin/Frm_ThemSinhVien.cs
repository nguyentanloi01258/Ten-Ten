using Pro03_20CT114.DataLayer.Entity;
using Project40.DataLayer.Entity;
using ProjectLogin;
using ProjectLogin.BLLLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project40
{
    public partial class Frm_ThemSinhVien : Form
    {
        public Frm_ThemSinhVien()
        {
            InitializeComponent();
        }
        public SinhVien sinhvien;
        public bool isAdd = false;
        BLLSinhVien bd;
        BLLLop b1;
      
        
        private void Frm_ThemSinhVien_Load(object sender, EventArgs e)
        {
            bd = new BLLSinhVien(clsMain.pathSinhVien);
            txtMSSV.Text = GetMSSV().ToString();
            txtMSSV.Enabled = false;//cho nìn nhưg ko cho thao tác
            txtHoVaTen.Focus();
            
            LoadDanhSachLop();
            LoadDSGioiTinh();
        }

        private void LoadDSGioiTinh()
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.Items.Add("Khác");
            cbbGioiTinh.SelectedIndex = -1;
            cbbGioiTinh.Text = "---Chọn---";
        }
        private void LoadDanhSachLop()
        {
            b1 = new BLLLop(clsMain.pathLop);
            clsMain.lops = b1.GetListLop();
            cbbDanhSachLop.DataSource = clsMain.lops;// combobox sổ xuống
            cbbDanhSachLop.DisplayMember = "TenLop";
            cbbDanhSachLop.ValueMember = "ID";
            cbbDanhSachLop.SelectedIndex = -1;
            cbbDanhSachLop.Text = "---Chọn lớp---";
        }
        private int GetMSSV() // lấy id lớn nhất
        {
            int max = 0;
            foreach (SinhVien item in clsMain.sinhViens)
            {
                if (item.MSSV >= max)
                {
                    max = item.MSSV;
                }
            }
            return max + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoVaTen.Text))
            {
                if (!string.IsNullOrEmpty(cbbGioiTinh.Text))
                {
                    if (!string.IsNullOrEmpty(txtNgaySinh.Text))
                    {
                        if (!string.IsNullOrEmpty(txtDiaChi.Text))
                        {
                            if (!string.IsNullOrEmpty(txtSDT.Text))
                            {
                                if (!string.IsNullOrEmpty(txtKhoa.Text))
                                {
                                    
                                        sinhvien = new SinhVien()
                                        {
                                            MSSV = Convert.ToInt32(txtMSSV.Text),
                                            HovaTen = txtHoVaTen.Text,
                                            GioiTinh = cbbGioiTinh.Text,
                                            NgaySinh = txtNgaySinh.Text,
                                            DiaChi = txtDiaChi.Text,
                                            Sdt = Convert.ToInt32(txtSDT.Text),
                                            Khoa = txtKhoa.Text,
                                            Lop = cbbDanhSachLop.Text
                                        };

                                        clsMain.sinhViens.Add(sinhvien);
                                        clsMain.CapNhatDataSinhVien(clsMain.pathSinhVien, clsMain.sinhViens);
                                        MessageBox.Show("Thêm tài khoản mới thành công", "Trạng thái",              MessageBoxButtons.OK);
                                        this.Close(); 
                                }
                                else
                                {
                                    MessageBox.Show("Chưa nhập khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtKhoa.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtSDT.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtDiaChi.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNgaySinh.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn Giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbbGioiTinh.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoVaTen.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát tiến trình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
