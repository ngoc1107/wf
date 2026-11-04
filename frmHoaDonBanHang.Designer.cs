namespace btl_wf
{
    partial class frmhoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhoadon));
            this.label1 = new System.Windows.Forms.Label();
            this.grbhoadon = new System.Windows.Forms.GroupBox();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpchitiet = new System.Windows.Forms.GroupBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.nudVAT = new System.Windows.Forms.NumericUpDown();
            this.txtTongThanhToan = new System.Windows.Forms.TextBox();
            this.txtTienThue = new System.Windows.Forms.TextBox();
            this.txtTienHang = new System.Windows.Forms.TextBox();
            this.cboThanhToan = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cboSach = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grbhoadon.SuspendLayout();
            this.grpchitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(592, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbhoadon
            // 
            this.grbhoadon.Controls.Add(this.cboKhachHang);
            this.grbhoadon.Controls.Add(this.dtpNgayLap);
            this.grbhoadon.Controls.Add(this.txtDiaChi);
            this.grbhoadon.Controls.Add(this.txtSDT);
            this.grbhoadon.Controls.Add(this.txtNhanVien);
            this.grbhoadon.Controls.Add(this.txtMaHD);
            this.grbhoadon.Controls.Add(this.label7);
            this.grbhoadon.Controls.Add(this.label6);
            this.grbhoadon.Controls.Add(this.label5);
            this.grbhoadon.Controls.Add(this.label4);
            this.grbhoadon.Controls.Add(this.label3);
            this.grbhoadon.Controls.Add(this.label2);
            this.grbhoadon.Location = new System.Drawing.Point(12, 97);
            this.grbhoadon.Name = "grbhoadon";
            this.grbhoadon.Size = new System.Drawing.Size(1589, 255);
            this.grbhoadon.TabIndex = 1;
            this.grbhoadon.TabStop = false;
            this.grbhoadon.Text = "Thông tin hóa đơn";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(1113, 40);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(311, 33);
            this.cboKhachHang.TabIndex = 12;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(277, 113);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(266, 31);
            this.dtpNgayLap.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(1113, 177);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(311, 31);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(1113, 107);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(311, 31);
            this.txtSDT.TabIndex = 8;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(277, 165);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(266, 31);
            this.txtNhanVien.TabIndex = 7;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(277, 51);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(266, 31);
            this.txtMaHD.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(911, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(911, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(911, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // grpchitiet
            // 
            this.grpchitiet.Controls.Add(this.nudSoLuong);
            this.grpchitiet.Controls.Add(this.nudVAT);
            this.grpchitiet.Controls.Add(this.txtTongThanhToan);
            this.grpchitiet.Controls.Add(this.txtTienThue);
            this.grpchitiet.Controls.Add(this.txtTienHang);
            this.grpchitiet.Controls.Add(this.cboThanhToan);
            this.grpchitiet.Controls.Add(this.txtGhiChu);
            this.grpchitiet.Controls.Add(this.txtDonGia);
            this.grpchitiet.Controls.Add(this.cboSach);
            this.grpchitiet.Controls.Add(this.label16);
            this.grpchitiet.Controls.Add(this.label15);
            this.grpchitiet.Controls.Add(this.label14);
            this.grpchitiet.Controls.Add(this.label13);
            this.grpchitiet.Controls.Add(this.label12);
            this.grpchitiet.Controls.Add(this.label11);
            this.grpchitiet.Controls.Add(this.dgvChiTiet);
            this.grpchitiet.Controls.Add(this.btnThemSach);
            this.grpchitiet.Controls.Add(this.label10);
            this.grpchitiet.Controls.Add(this.label9);
            this.grpchitiet.Controls.Add(this.label8);
            this.grpchitiet.Location = new System.Drawing.Point(12, 358);
            this.grpchitiet.Name = "grpchitiet";
            this.grpchitiet.Size = new System.Drawing.Size(1589, 506);
            this.grpchitiet.TabIndex = 13;
            this.grpchitiet.TabStop = false;
            this.grpchitiet.Text = "Chi tiết hóa đơn";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(699, 33);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(120, 31);
            this.nudSoLuong.TabIndex = 19;
            // 
            // nudVAT
            // 
            this.nudVAT.Location = new System.Drawing.Point(1218, 351);
            this.nudVAT.Name = "nudVAT";
            this.nudVAT.Size = new System.Drawing.Size(215, 31);
            this.nudVAT.TabIndex = 18;
            // 
            // txtTongThanhToan
            // 
            this.txtTongThanhToan.Location = new System.Drawing.Point(1218, 451);
            this.txtTongThanhToan.Name = "txtTongThanhToan";
            this.txtTongThanhToan.Size = new System.Drawing.Size(215, 31);
            this.txtTongThanhToan.TabIndex = 17;
            // 
            // txtTienThue
            // 
            this.txtTienThue.Location = new System.Drawing.Point(1218, 399);
            this.txtTienThue.Name = "txtTienThue";
            this.txtTienThue.Size = new System.Drawing.Size(215, 31);
            this.txtTienThue.TabIndex = 16;
            // 
            // txtTienHang
            // 
            this.txtTienHang.Location = new System.Drawing.Point(1218, 300);
            this.txtTienHang.Name = "txtTienHang";
            this.txtTienHang.Size = new System.Drawing.Size(215, 31);
            this.txtTienHang.TabIndex = 15;
            // 
            // cboThanhToan
            // 
            this.cboThanhToan.FormattingEnabled = true;
            this.cboThanhToan.Location = new System.Drawing.Point(163, 416);
            this.cboThanhToan.Name = "cboThanhToan";
            this.cboThanhToan.Size = new System.Drawing.Size(121, 33);
            this.cboThanhToan.TabIndex = 14;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(163, 300);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(510, 107);
            this.txtGhiChu.TabIndex = 13;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(1134, 36);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(159, 31);
            this.txtDonGia.TabIndex = 12;
            // 
            // cboSach
            // 
            this.cboSach.FormattingEnabled = true;
            this.cboSach.Location = new System.Drawing.Point(123, 34);
            this.cboSach.Name = "cboSach";
            this.cboSach.Size = new System.Drawing.Size(174, 33);
            this.cboSach.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1046, 454);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "Tổng thanh toán:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1046, 405);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "Tiền thuế:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1046, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "Thuế VAT (%) :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1046, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tiền hàng:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 25);
            this.label12.TabIndex = 6;
            this.label12.Text = "Thanh toán :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ghi chú:";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(6, 78);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 82;
            this.dgvChiTiet.RowTemplate.Height = 33;
            this.dgvChiTiet.Size = new System.Drawing.Size(1567, 211);
            this.dgvChiTiet.TabIndex = 4;
            // 
            // btnThemSach
            // 
            this.btnThemSach.AutoSize = true;
            this.btnThemSach.Location = new System.Drawing.Point(1366, 34);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(128, 35);
            this.btnThemSach.TabIndex = 3;
            this.btnThemSach.Text = "Thêm sách";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1013, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Đơn giá:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(530, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sách:";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.AutoSize = true;
            this.btnTaoMoi.Location = new System.Drawing.Point(101, 870);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(99, 35);
            this.btnTaoMoi.TabIndex = 14;
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(386, 870);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 40);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu hóa đơn";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnIn
            // 
            this.btnIn.AutoSize = true;
            this.btnIn.Location = new System.Drawing.Point(702, 870);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(123, 35);
            this.btnIn.TabIndex = 16;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AutoSize = true;
            this.btnHuy.Location = new System.Drawing.Point(1030, 870);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 35);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDong
            // 
            this.btnDong.AutoSize = true;
            this.btnDong.Location = new System.Drawing.Point(1315, 870);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 35);
            this.btnDong.TabIndex = 18;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 1086);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.grpchitiet);
            this.Controls.Add(this.grbhoadon);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmhoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÓA ĐƠN BÁN HÀNG";
            this.Load += new System.EventHandler(this.frmhoadon_Load);
            this.grbhoadon.ResumeLayout(false);
            this.grbhoadon.PerformLayout();
            this.grpchitiet.ResumeLayout(false);
            this.grpchitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbhoadon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.GroupBox grpchitiet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtTongThanhToan;
        private System.Windows.Forms.TextBox txtTienThue;
        private System.Windows.Forms.TextBox txtTienHang;
        private System.Windows.Forms.ComboBox cboThanhToan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.ComboBox cboSach;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.NumericUpDown nudVAT;
    }
}