namespace giaodien
{
    partial class frmDoanhThuTheoThang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThuTheoThang));
            this.label1 = new System.Windows.Forms.Label();
            this.grpDieuKien = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbKetQua = new System.Windows.Forms.GroupBox();
            this.dgvDoangThuThang = new System.Windows.Forms.DataGridView();
            this.grpDieuKien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            this.grbKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoangThuThang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(159, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU THEO THÁNG";
            // 
            // grpDieuKien
            // 
            this.grpDieuKien.Controls.Add(this.btnThongKe);
            this.grpDieuKien.Controls.Add(this.btnXuatExcel);
            this.grpDieuKien.Controls.Add(this.btnLamMoi);
            this.grpDieuKien.Controls.Add(this.btnThoat);
            this.grpDieuKien.Controls.Add(this.nudNam);
            this.grpDieuKien.Controls.Add(this.cboThang);
            this.grpDieuKien.Controls.Add(this.label3);
            this.grpDieuKien.Controls.Add(this.label2);
            this.grpDieuKien.Location = new System.Drawing.Point(58, 110);
            this.grpDieuKien.Name = "grpDieuKien";
            this.grpDieuKien.Size = new System.Drawing.Size(873, 144);
            this.grpDieuKien.TabIndex = 1;
            this.grpDieuKien.TabStop = false;
            this.grpDieuKien.Text = "Điều kiện";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(76, 98);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(102, 40);
            this.btnThongKe.TabIndex = 7;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(480, 98);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(102, 40);
            this.btnXuatExcel.TabIndex = 6;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(251, 98);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(102, 40);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(677, 98);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(153, 59);
            this.nudNam.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(120, 22);
            this.nudNam.TabIndex = 3;
            this.nudNam.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
            this.cboThang.Location = new System.Drawing.Point(153, 22);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(327, 24);
            this.cboThang.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn tháng:";
            // 
            // grbKetQua
            // 
            this.grbKetQua.Controls.Add(this.dgvDoangThuThang);
            this.grbKetQua.Location = new System.Drawing.Point(58, 260);
            this.grbKetQua.Name = "grbKetQua";
            this.grbKetQua.Size = new System.Drawing.Size(873, 281);
            this.grbKetQua.TabIndex = 2;
            this.grbKetQua.TabStop = false;
            this.grbKetQua.Text = "Doanh thu theo tháng";
            // 
            // dgvDoangThuThang
            // 
            this.dgvDoangThuThang.AllowUserToAddRows = false;
            this.dgvDoangThuThang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoangThuThang.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoangThuThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoangThuThang.Location = new System.Drawing.Point(16, 39);
            this.dgvDoangThuThang.MultiSelect = false;
            this.dgvDoangThuThang.Name = "dgvDoangThuThang";
            this.dgvDoangThuThang.ReadOnly = true;
            this.dgvDoangThuThang.RowHeadersVisible = false;
            this.dgvDoangThuThang.RowHeadersWidth = 51;
            this.dgvDoangThuThang.RowTemplate.Height = 24;
            this.dgvDoangThuThang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoangThuThang.Size = new System.Drawing.Size(841, 225);
            this.dgvDoangThuThang.TabIndex = 0;
            // 
            // frmDoanhThuTheoThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.grbKetQua);
            this.Controls.Add(this.grpDieuKien);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoanhThuTheoThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu theo tháng";
            this.grpDieuKien.ResumeLayout(false);
            this.grpDieuKien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            this.grbKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoangThuThang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDieuKien;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbKetQua;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDoangThuThang;
    }
}