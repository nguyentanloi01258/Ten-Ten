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
    public partial class Frm_EditThongTinSinhVien : Form
    {
        public Frm_EditThongTinSinhVien()
        {
            InitializeComponent();
        }
        public SinhVien sinhvien;
        BLLSinhVien bd;
        BLLLop b1;

        private void Frm_EditThongTinSinhVien_Load(object sender, EventArgs e)
        {
            bd = new BLLSinhVien(clsMain.pathSinhVien);
            txtMSSV.Text = sinhvien.MSSV.ToString(); txtMSSV.Enabled = false;
            txtHoVaTen.Text = sinhvien.HovaTen;
            cbbGioiTinh.Text = sinhvien.GioiTinh;
            txtNgaySinh.Text = sinhvien.NgaySinh;
            txtDiaChi.Text = sinhvien.DiaChi;
            txtSDT.Text = sinhvien.Sdt.ToString();
            txtKhoa.Text = sinhvien.Khoa;
            cbbDanhSachLop.Text = sinhvien.Lop;

            LoadDSGioiTinh();
            LoadDanhSachLop();
        }
        private void LoadDSGioiTinh()
        {
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            cbbGioiTinh.Items.Add("Khác");
            cbbGioiTinh.SelectedIndex = -1;
        }
        private void LoadDanhSachLop()
        {
            b1 = new BLLLop(clsMain.pathLop);
            clsMain.lops = b1.GetListLop();
            cbbDanhSachLop.DataSource = clsMain.lops;// combobox sổ xuống
            cbbDanhSachLop.DisplayMember = "TenLop";
            cbbDanhSachLop.ValueMember = "ID";
            cbbDanhSachLop.SelectedIndex = -1;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
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
                                    foreach (SinhVien item in clsMain.sinhViens)
                                    {
                                        if (item.MSSV == sinhvien.MSSV)
                                        {
                                            item.MSSV = sinhvien.MSSV;
                                            item.HovaTen = sinhvien.HovaTen;
                                            item.GioiTinh = sinhvien.GioiTinh;
                                            item.NgaySinh = sinhvien.NgaySinh;
                                            item.DiaChi = sinhvien.DiaChi;
                                            item.Sdt = sinhvien.Sdt;
                                            item.Khoa = sinhvien.Khoa;
                                            item.Lop = sinhvien.Lop;
                                        }
                                    }
                                    clsMain.CapNhatDataSinhVien(clsMain.pathSinhVien, clsMain.sinhViens);
                                    MessageBox.Show("Cập nhật thành công", "Trạng thái", MessageBoxButtons.OK);
                                    this.Close();
                                    //
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
            if (MessageBox.Show("Bạn có chắc muốn hủy thay đổi", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
