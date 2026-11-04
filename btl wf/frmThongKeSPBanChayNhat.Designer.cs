namespace giaodien
{
    partial class frmThongKeSPBanChayNhat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeSPBanChayNhat));
            this.label1 = new System.Windows.Forms.Label();
            this.grpDieuKien = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cboTop = new System.Windows.Forms.ComboBox();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.dgvBanChay = new System.Windows.Forms.DataGridView();
            this.grpDieuKien.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(107, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ SẢN PHẨM BÁN CHẠY NHẤT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDieuKien
            // 
            this.grpDieuKien.Controls.Add(this.btnThoat);
            this.grpDieuKien.Controls.Add(this.btnXuatExcel);
            this.grpDieuKien.Controls.Add(this.btnLamMoi);
            this.grpDieuKien.Controls.Add(this.btnThongKe);
            this.grpDieuKien.Controls.Add(this.cboTop);
            this.grpDieuKien.Controls.Add(this.dtpDenNgay);
            this.grpDieuKien.Controls.Add(this.dtpTuNgay);
            this.grpDieuKien.Controls.Add(this.label4);
            this.grpDieuKien.Controls.Add(this.label3);
            this.grpDieuKien.Controls.Add(this.label2);
            this.grpDieuKien.Location = new System.Drawing.Point(41, 88);
            this.grpDieuKien.Name = "grpDieuKien";
            this.grpDieuKien.Size = new System.Drawing.Size(898, 163);
            this.grpDieuKien.TabIndex = 1;
            this.grpDieuKien.TabStop = false;
            this.grpDieuKien.Text = "Điều kiện thống kê";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(699, 105);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 42);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(471, 105);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(94, 42);
            this.btnXuatExcel.TabIndex = 8;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(256, 105);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 42);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(46, 105);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(94, 42);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // cboTop
            // 
            this.cboTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTop.FormattingEnabled = true;
            this.cboTop.Items.AddRange(new object[] {
            "Top 5",
            "Top 10",
            "top 20"});
            this.cboTop.Location = new System.Drawing.Point(173, 69);
            this.cboTop.Name = "cboTop";
            this.cboTop.Size = new System.Drawing.Size(121, 24);
            this.cboTop.TabIndex = 5;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(471, 35);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpDenNgay.TabIndex = 4;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(126, 31);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTuNgay.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Top sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ ngày:";
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.dgvBanChay);
            this.grpKetQua.Location = new System.Drawing.Point(41, 270);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(898, 271);
            this.grpKetQua.TabIndex = 2;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "Kết quả thống kê";
            // 
            // dgvBanChay
            // 
            this.dgvBanChay.AllowUserToAddRows = false;
            this.dgvBanChay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanChay.BackgroundColor = System.Drawing.Color.White;
            this.dgvBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanChay.Location = new System.Drawing.Point(31, 22);
            this.dgvBanChay.MultiSelect = false;
            this.dgvBanChay.Name = "dgvBanChay";
            this.dgvBanChay.ReadOnly = true;
            this.dgvBanChay.RowHeadersWidth = 51;
            this.dgvBanChay.RowTemplate.Height = 24;
            this.dgvBanChay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBanChay.Size = new System.Drawing.Size(849, 243);
            this.dgvBanChay.TabIndex = 0;
            // 
            // frmThongKeSPBanChayNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.grpDieuKien);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKeSPBanChayNhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê Sản Phẩm bán chạy nhất";
            this.grpDieuKien.ResumeLayout(false);
            this.grpDieuKien.PerformLayout();
            this.grpKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanChay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDieuKien;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.ComboBox cboTop;
        private System.Windows.Forms.DataGridView dgvBanChay;
    }
}