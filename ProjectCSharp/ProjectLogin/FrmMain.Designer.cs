
namespace ProjectLogin
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmr_main_GHT = new System.Windows.Forms.Timer(this.components);
            this.lbl_main_GioHeThong = new System.Windows.Forms.Label();
            this.btn_main_X = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_main_HeTong = new System.Windows.Forms.Label();
            this.tabPage_main_QLTK = new System.Windows.Forms.TabPage();
            this.pnl_main_Container = new System.Windows.Forms.Panel();
            this.tabPagE_main_DoiMK = new System.Windows.Forms.TabPage();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_main_XLNN = new System.Windows.Forms.TabPage();
            this.tabPage_main_MaTran = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_main_TacVu = new System.Windows.Forms.Panel();
            this.btn_main_1 = new System.Windows.Forms.Button();
            this.btn_main_MaTran = new System.Windows.Forms.Button();
            this.btn_main_XLNgNg = new System.Windows.Forms.Button();
            this.btn_main_TacVu = new System.Windows.Forms.Button();
            this.btn_main_TaiKhoan = new System.Windows.Forms.Button();
            this.btn_main_DangXuat = new System.Windows.Forms.Button();
            this.btn_main_DoiMK = new System.Windows.Forms.Button();
            this.pnl_main_HeThong = new System.Windows.Forms.Panel();
            this.btn_main_Thoat = new System.Windows.Forms.Button();
            this.btn_main_HeThong = new System.Windows.Forms.Button();
            this.pnl_main_Left = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripStatusLabel_NhomTenTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_Nhom = new System.Windows.Forms.StatusStrip();
            this.panel2.SuspendLayout();
            this.tabPage_main_QLTK.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.pnl_main_TacVu.SuspendLayout();
            this.pnl_main_HeThong.SuspendLayout();
            this.pnl_main_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip_Nhom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr_main_GHT
            // 
            this.tmr_main_GHT.Interval = 1000;
            this.tmr_main_GHT.Tick += new System.EventHandler(this.tmrGioHeThong_Tick);
            // 
            // lbl_main_GioHeThong
            // 
            this.lbl_main_GioHeThong.AutoSize = true;
            this.lbl_main_GioHeThong.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_main_GioHeThong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_main_GioHeThong.ForeColor = System.Drawing.Color.White;
            this.lbl_main_GioHeThong.Location = new System.Drawing.Point(766, 0);
            this.lbl_main_GioHeThong.Name = "lbl_main_GioHeThong";
            this.lbl_main_GioHeThong.Size = new System.Drawing.Size(124, 28);
            this.lbl_main_GioHeThong.TabIndex = 2;
            this.lbl_main_GioHeThong.Text = "16-11-2022";
            // 
            // btn_main_X
            // 
            this.btn_main_X.BackColor = System.Drawing.Color.Maroon;
            this.btn_main_X.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_main_X.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_main_X.ForeColor = System.Drawing.Color.White;
            this.btn_main_X.Location = new System.Drawing.Point(890, 0);
            this.btn_main_X.Name = "btn_main_X";
            this.btn_main_X.Size = new System.Drawing.Size(75, 55);
            this.btn_main_X.TabIndex = 1;
            this.btn_main_X.Text = "X";
            this.btn_main_X.UseVisualStyleBackColor = false;
            this.btn_main_X.Click += new System.EventHandler(this.bit_main_X_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.panel2.Controls.Add(this.lbl_main_GioHeThong);
            this.panel2.Controls.Add(this.btn_main_X);
            this.panel2.Controls.Add(this.lbl_main_HeTong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 55);
            this.panel2.TabIndex = 0;
            // 
            // lbl_main_HeTong
            // 
            this.lbl_main_HeTong.AutoSize = true;
            this.lbl_main_HeTong.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_main_HeTong.ForeColor = System.Drawing.Color.White;
            this.lbl_main_HeTong.Location = new System.Drawing.Point(236, 1);
            this.lbl_main_HeTong.Name = "lbl_main_HeTong";
            this.lbl_main_HeTong.Size = new System.Drawing.Size(469, 45);
            this.lbl_main_HeTong.TabIndex = 0;
            this.lbl_main_HeTong.Text = "Hệ thống quản lí người dùng";
            // 
            // tabPage_main_QLTK
            // 
            this.tabPage_main_QLTK.Controls.Add(this.pnl_main_Container);
            this.tabPage_main_QLTK.Location = new System.Drawing.Point(4, 40);
            this.tabPage_main_QLTK.Name = "tabPage_main_QLTK";
            this.tabPage_main_QLTK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_main_QLTK.Size = new System.Drawing.Size(962, 550);
            this.tabPage_main_QLTK.TabIndex = 0;
            this.tabPage_main_QLTK.Text = "Tài Khoản";
            this.tabPage_main_QLTK.UseVisualStyleBackColor = true;
            // 
            // pnl_main_Container
            // 
            this.pnl_main_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main_Container.Location = new System.Drawing.Point(3, 3);
            this.pnl_main_Container.Name = "pnl_main_Container";
            this.pnl_main_Container.Size = new System.Drawing.Size(956, 544);
            this.pnl_main_Container.TabIndex = 0;
            // 
            // tabPagE_main_DoiMK
            // 
            this.tabPagE_main_DoiMK.Location = new System.Drawing.Point(4, 40);
            this.tabPagE_main_DoiMK.Name = "tabPagE_main_DoiMK";
            this.tabPagE_main_DoiMK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagE_main_DoiMK.Size = new System.Drawing.Size(962, 550);
            this.tabPagE_main_DoiMK.TabIndex = 1;
            this.tabPagE_main_DoiMK.Text = "Đổi MK";
            this.tabPagE_main_DoiMK.UseVisualStyleBackColor = true;
            this.tabPagE_main_DoiMK.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_main_QLTK);
            this.tabControl_main.Controls.Add(this.tabPagE_main_DoiMK);
            this.tabControl_main.Controls.Add(this.tabPage_main_XLNN);
            this.tabControl_main.Controls.Add(this.tabPage_main_MaTran);
            this.tabControl_main.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl_main.Location = new System.Drawing.Point(3, 61);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(970, 594);
            this.tabControl_main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_main.TabIndex = 1;
            // 
            // tabPage_main_XLNN
            // 
            this.tabPage_main_XLNN.Location = new System.Drawing.Point(4, 40);
            this.tabPage_main_XLNN.Name = "tabPage_main_XLNN";
            this.tabPage_main_XLNN.Size = new System.Drawing.Size(962, 550);
            this.tabPage_main_XLNN.TabIndex = 2;
            this.tabPage_main_XLNN.Text = "Xử lý NN";
            this.tabPage_main_XLNN.UseVisualStyleBackColor = true;
            // 
            // tabPage_main_MaTran
            // 
            this.tabPage_main_MaTran.Location = new System.Drawing.Point(4, 40);
            this.tabPage_main_MaTran.Name = "tabPage_main_MaTran";
            this.tabPage_main_MaTran.Size = new System.Drawing.Size(962, 550);
            this.tabPage_main_MaTran.TabIndex = 3;
            this.tabPage_main_MaTran.Text = "Ma Trận";
            this.tabPage_main_MaTran.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 55);
            this.panel1.TabIndex = 0;
            // 
            // pnl_main_TacVu
            // 
            this.pnl_main_TacVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.pnl_main_TacVu.Controls.Add(this.btn_main_1);
            this.pnl_main_TacVu.Controls.Add(this.btn_main_MaTran);
            this.pnl_main_TacVu.Controls.Add(this.btn_main_XLNgNg);
            this.pnl_main_TacVu.Controls.Add(this.btn_main_TacVu);
            this.pnl_main_TacVu.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_main_TacVu.Location = new System.Drawing.Point(3, 288);
            this.pnl_main_TacVu.Name = "pnl_main_TacVu";
            this.pnl_main_TacVu.Size = new System.Drawing.Size(303, 218);
            this.pnl_main_TacVu.TabIndex = 3;
            // 
            // btn_main_1
            // 
            this.btn_main_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_main_1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_main_1.ForeColor = System.Drawing.Color.Black;
            this.btn_main_1.Location = new System.Drawing.Point(5, 165);
            this.btn_main_1.Name = "btn_main_1";
            this.btn_main_1.Size = new System.Drawing.Size(295, 48);
            this.btn_main_1.TabIndex = 3;
            this.btn_main_1.Text = "Xóa user";
            this.btn_main_1.UseVisualStyleBackColor = false;
            // 
            // btn_main_MaTran
            // 
            this.btn_main_MaTran.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_main_MaTran.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_main_MaTran.ForeColor = System.Drawing.Color.Black;
            this.btn_main_MaTran.Location = new System.Drawing.Point(5, 111);
            this.btn_main_MaTran.Name = "btn_main_MaTran";
            this.btn_main_MaTran.Size = new System.Drawing.Size(295, 48);
            this.btn_main_MaTran.TabIndex = 2;
            this.btn_main_MaTran.Text = "Ma Trận";
            this.btn_main_MaTran.UseVisualStyleBackColor = false;
            this.btn_main_MaTran.Click += new System.EventHandler(this.btn_main_MaTran_Click);
            // 
            // btn_main_XLNgNg
            // 
            this.btn_main_XLNgNg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_main_XLNgNg.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_main_XLNgNg.ForeColor = System.Drawing.Color.Black;
            this.btn_main_XLNgNg.Location = new System.Drawing.Point(5, 57);
            this.btn_main_XLNgNg.Name = "btn_main_XLNgNg";
            this.btn_main_XLNgNg.Size = new System.Drawing.Size(295, 48);
            this.btn_main_XLNgNg.TabIndex = 1;
            this.btn_main_XLNgNg.Text = "Xử lý ngôn ngữ";
            this.btn_main_XLNgNg.UseVisualStyleBackColor = false;
            this.btn_main_XLNgNg.Click += new System.EventHandler(this.btn_main_XLNgNg_Click);
            // 
            // btn_main_TacVu
            // 
            this.btn_main_TacVu.BackColor = System.Drawing.Color.Indigo;
            this.btn_main_TacVu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_main_TacVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_TacVu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_main_TacVu.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_main_TacVu.Location = new System.Drawing.Point(3, 3);
            this.btn_main_TacVu.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btn_main_TacVu.Name = "btn_main_TacVu";
            this.btn_main_TacVu.Size = new System.Drawing.Size(295, 48);
            this.btn_main_TacVu.TabIndex = 0;
            this.btn_main_TacVu.Text = "&Tác vụ";
            this.btn_main_TacVu.UseVisualStyleBackColor = false;
            this.btn_main_TacVu.Click += new System.EventHandler(this.btn_main_TacVu_Click);
            // 
            // btn_main_TaiKhoan
            // 
            this.btn_main_TaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_main_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_main_TaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.btn_main_TaiKhoan.Location = new System.Drawing.Point(5, 57);
            this.btn_main_TaiKhoan.Name = "btn_main_TaiKhoan";
            this.btn_main_TaiKhoan.Size = new System.Drawing.Size(295, 48);
            this.btn_main_TaiKhoan.TabIndex = 1;
            this.btn_main_TaiKhoan.Text = "Quản lý tài khoản";
            this.btn_main_TaiKhoan.UseVisualStyleBackColor = false;
            this.btn_main_TaiKhoan.Click += new System.EventHandler(this.btn_main_TaiKhoan_Click);
            // 
            // btn_main_DangXuat
            // 
            this.btn_main_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_main_DangXuat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_main_DangXuat.ForeColor = System.Drawing.Color.Black;
            this.btn_main_DangXuat.Location = new System.Drawing.Point(5, 165);
            this.btn_main_DangXuat.Name = "btn_main_DangXuat";
            this.btn_main_DangXuat.Size = new System.Drawing.Size(295, 48);
            this.btn_main_DangXuat.TabIndex = 3;
            this.btn_main_DangXuat.Text = "Đăng xuất";
            this.btn_main_DangXuat.UseVisualStyleBackColor = false;
            this.btn_main_DangXuat.Click += new System.EventHandler(this.btn_main_DangXuat_Click);
            // 
            // btn_main_DoiMK
            // 
            this.btn_main_DoiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_main_DoiMK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_main_DoiMK.ForeColor = System.Drawing.Color.Black;
            this.btn_main_DoiMK.Location = new System.Drawing.Point(5, 111);
            this.btn_main_DoiMK.Name = "btn_main_DoiMK";
            this.btn_main_DoiMK.Size = new System.Drawing.Size(295, 48);
            this.btn_main_DoiMK.TabIndex = 2;
            this.btn_main_DoiMK.Text = "Đổi mật khẩu";
            this.btn_main_DoiMK.UseVisualStyleBackColor = false;
            this.btn_main_DoiMK.Click += new System.EventHandler(this.btn_main_DoiMK_Click);
            // 
            // pnl_main_HeThong
            // 
            this.pnl_main_HeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.pnl_main_HeThong.Controls.Add(this.btn_main_Thoat);
            this.pnl_main_HeThong.Controls.Add(this.btn_main_DangXuat);
            this.pnl_main_HeThong.Controls.Add(this.btn_main_DoiMK);
            this.pnl_main_HeThong.Controls.Add(this.btn_main_TaiKhoan);
            this.pnl_main_HeThong.Controls.Add(this.btn_main_HeThong);
            this.pnl_main_HeThong.Location = new System.Drawing.Point(3, 1);
            this.pnl_main_HeThong.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.pnl_main_HeThong.Name = "pnl_main_HeThong";
            this.pnl_main_HeThong.Size = new System.Drawing.Size(303, 272);
            this.pnl_main_HeThong.TabIndex = 2;
            // 
            // btn_main_Thoat
            // 
            this.btn_main_Thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(115)))), ((int)(((byte)(255)))));
            this.btn_main_Thoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_main_Thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_main_Thoat.Location = new System.Drawing.Point(6, 217);
            this.btn_main_Thoat.Name = "btn_main_Thoat";
            this.btn_main_Thoat.Size = new System.Drawing.Size(295, 48);
            this.btn_main_Thoat.TabIndex = 4;
            this.btn_main_Thoat.Text = "Thoát";
            this.btn_main_Thoat.UseVisualStyleBackColor = false;
            this.btn_main_Thoat.Click += new System.EventHandler(this.btn_main_Thoat_Click);
            // 
            // btn_main_HeThong
            // 
            this.btn_main_HeThong.BackColor = System.Drawing.Color.Indigo;
            this.btn_main_HeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main_HeThong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_main_HeThong.ForeColor = System.Drawing.Color.GhostWhite;
            this.btn_main_HeThong.Location = new System.Drawing.Point(3, 3);
            this.btn_main_HeThong.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btn_main_HeThong.Name = "btn_main_HeThong";
            this.btn_main_HeThong.Size = new System.Drawing.Size(295, 48);
            this.btn_main_HeThong.TabIndex = 0;
            this.btn_main_HeThong.Text = "&Hệ  Thống";
            this.btn_main_HeThong.UseVisualStyleBackColor = false;
            this.btn_main_HeThong.Click += new System.EventHandler(this.btn_main_HeThong_Click);
            // 
            // pnl_main_Left
            // 
            this.pnl_main_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(108)))), ((int)(((byte)(232)))));
            this.pnl_main_Left.Controls.Add(this.pnl_main_TacVu);
            this.pnl_main_Left.Controls.Add(this.pnl_main_HeThong);
            this.pnl_main_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main_Left.Location = new System.Drawing.Point(0, 55);
            this.pnl_main_Left.Name = "pnl_main_Left";
            this.pnl_main_Left.Size = new System.Drawing.Size(307, 595);
            this.pnl_main_Left.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnl_main_Left);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl_main);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1276, 650);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 3;
            // 
            // toolStripStatusLabel_NhomTenTen
            // 
            this.toolStripStatusLabel_NhomTenTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripStatusLabel_NhomTenTen.ForeColor = System.Drawing.Color.LavenderBlush;
            this.toolStripStatusLabel_NhomTenTen.Name = "toolStripStatusLabel_NhomTenTen";
            this.toolStripStatusLabel_NhomTenTen.Size = new System.Drawing.Size(150, 28);
            this.toolStripStatusLabel_NhomTenTen.Text = "Nhóm Ten-Ten";
            // 
            // statusStrip_Nhom
            // 
            this.statusStrip_Nhom.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip_Nhom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_Nhom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_NhomTenTen});
            this.statusStrip_Nhom.Location = new System.Drawing.Point(0, 650);
            this.statusStrip_Nhom.Name = "statusStrip_Nhom";
            this.statusStrip_Nhom.Size = new System.Drawing.Size(1276, 34);
            this.statusStrip_Nhom.TabIndex = 2;
            this.statusStrip_Nhom.Text = "statusStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1276, 684);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip_Nhom);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMain";
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage_main_QLTK.ResumeLayout(false);
            this.tabControl_main.ResumeLayout(false);
            this.pnl_main_TacVu.ResumeLayout(false);
            this.pnl_main_HeThong.ResumeLayout(false);
            this.pnl_main_Left.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip_Nhom.ResumeLayout(false);
            this.statusStrip_Nhom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr_main_GHT;
        private System.Windows.Forms.Label lbl_main_GioHeThong;
        private System.Windows.Forms.Button btn_main_X;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_main_HeTong;
        private System.Windows.Forms.TabPage tabPage_main_QLTK;
        private System.Windows.Forms.Panel pnl_main_Container;
        private System.Windows.Forms.TabPage tabPagE_main_DoiMK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_main_TacVu;
        private System.Windows.Forms.Button btn_main_1;
        private System.Windows.Forms.Button btn_main_MaTran;
        private System.Windows.Forms.Button btn_main_XLNgNg;
        private System.Windows.Forms.Button btn_main_TacVu;
        private System.Windows.Forms.Button btn_main_TaiKhoan;
        private System.Windows.Forms.Button btn_main_DangXuat;
        private System.Windows.Forms.Button btn_main_DoiMK;
        private System.Windows.Forms.Panel pnl_main_HeThong;
        private System.Windows.Forms.Button btn_main_HeThong;
        private System.Windows.Forms.Panel pnl_main_Left;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_NhomTenTen;
        private System.Windows.Forms.StatusStrip statusStrip_Nhom;
        private System.Windows.Forms.Button btn_main_Thoat;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_main_XLNN;
        private System.Windows.Forms.TabPage tabPage_main_MaTran;
    }
}

