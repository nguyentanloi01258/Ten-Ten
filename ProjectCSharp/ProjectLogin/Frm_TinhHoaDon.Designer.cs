namespace ProjectLogin
{
    partial class Frm_TinhHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenu = new System.Windows.Forms.ListBox();
            this.lblHoaDon = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChonHet = new System.Windows.Forms.Button();
            this.btnHuyHet = new System.Windows.Forms.Button();
            this.gbThanhTien = new System.Windows.Forms.GroupBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblThue = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.btnThucHienLai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbThanhTien.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.FormattingEnabled = true;
            this.lblMenu.ItemHeight = 20;
            this.lblMenu.Location = new System.Drawing.Point(0, 59);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(270, 484);
            this.lblMenu.TabIndex = 0;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.FormattingEnabled = true;
            this.lblHoaDon.ItemHeight = 20;
            this.lblHoaDon.Location = new System.Drawing.Point(351, 59);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(270, 484);
            this.lblHoaDon.TabIndex = 1;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChon.Location = new System.Drawing.Point(276, 147);
            this.btnChon.Margin = new System.Windows.Forms.Padding(0);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(69, 60);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = ">";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.Location = new System.Drawing.Point(276, 228);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(0);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(69, 60);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "<";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnChonHet
            // 
            this.btnChonHet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChonHet.Location = new System.Drawing.Point(276, 307);
            this.btnChonHet.Margin = new System.Windows.Forms.Padding(0);
            this.btnChonHet.Name = "btnChonHet";
            this.btnChonHet.Size = new System.Drawing.Size(69, 60);
            this.btnChonHet.TabIndex = 4;
            this.btnChonHet.Text = ">>";
            this.btnChonHet.UseVisualStyleBackColor = true;
            this.btnChonHet.Click += new System.EventHandler(this.btnChonHet_Click_1);
            // 
            // btnHuyHet
            // 
            this.btnHuyHet.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHuyHet.Location = new System.Drawing.Point(276, 387);
            this.btnHuyHet.Margin = new System.Windows.Forms.Padding(0);
            this.btnHuyHet.Name = "btnHuyHet";
            this.btnHuyHet.Size = new System.Drawing.Size(69, 60);
            this.btnHuyHet.TabIndex = 5;
            this.btnHuyHet.Text = "<<";
            this.btnHuyHet.UseVisualStyleBackColor = true;
            this.btnHuyHet.Click += new System.EventHandler(this.btnHuyHet_Click);
            // 
            // gbThanhTien
            // 
            this.gbThanhTien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbThanhTien.Controls.Add(this.lblTong);
            this.gbThanhTien.Controls.Add(this.lblThue);
            this.gbThanhTien.Controls.Add(this.lblSoTien);
            this.gbThanhTien.Location = new System.Drawing.Point(627, 53);
            this.gbThanhTien.Name = "gbThanhTien";
            this.gbThanhTien.Size = new System.Drawing.Size(355, 243);
            this.gbThanhTien.TabIndex = 6;
            this.gbThanhTien.TabStop = false;
            this.gbThanhTien.Text = "Bill Thanh Toán";
            // 
            // lblTong
            // 
            this.lblTong.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTong.Location = new System.Drawing.Point(9, 174);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(340, 41);
            this.lblTong.TabIndex = 1;
            this.lblTong.Text = "Tổng:";
            // 
            // lblThue
            // 
            this.lblThue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThue.Location = new System.Drawing.Point(9, 102);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(346, 41);
            this.lblThue.TabIndex = 0;
            this.lblThue.Text = "Thuế VAT (8%):";
            // 
            // lblSoTien
            // 
            this.lblSoTien.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoTien.Location = new System.Drawing.Point(9, 41);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(340, 41);
            this.lblSoTien.TabIndex = 0;
            this.lblSoTien.Text = "Số tiền:";
            // 
            // btnThucHienLai
            // 
            this.btnThucHienLai.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThucHienLai.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThucHienLai.ForeColor = System.Drawing.Color.White;
            this.btnThucHienLai.Location = new System.Drawing.Point(627, 335);
            this.btnThucHienLai.Name = "btnThucHienLai";
            this.btnThucHienLai.Size = new System.Drawing.Size(355, 60);
            this.btnThucHienLai.TabIndex = 11;
            this.btnThucHienLai.Text = "Thực hiện lại";
            this.btnThucHienLai.UseVisualStyleBackColor = false;
            this.btnThucHienLai.Click += new System.EventHandler(this.btnThucHienLai_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 53);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(890, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tính Bill Quán Cafe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(890, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 53);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Frm_TinhHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 543);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThucHienLai);
            this.Controls.Add(this.gbThanhTien);
            this.Controls.Add(this.btnHuyHet);
            this.Controls.Add(this.btnChonHet);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lblMenu);
            this.Name = "Frm_TinhHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_TinhHoaDon_Load);
            this.gbThanhTien.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lblMenu;
        private System.Windows.Forms.ListBox lblHoaDon;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnChonHet;
        private System.Windows.Forms.Button btnHuyHet;
        private System.Windows.Forms.GroupBox gbThanhTien;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Button btnThucHienLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}