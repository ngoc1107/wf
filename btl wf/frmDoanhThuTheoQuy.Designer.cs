namespace giaodien
{
    partial class frmDoanhThuTheoQuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThuTheoQuy));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDieuKien = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.cboQuy = new System.Windows.Forms.ComboBox();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.dgvDoanhThuTheoQuy = new System.Windows.Forms.DataGridView();
            this.grpDieuKien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            this.grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuTheoQuy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(162, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU THEO QUÝ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn quý:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn năm:";
            // 
            // grpDieuKien
            // 
            this.grpDieuKien.Controls.Add(this.btnThoat);
            this.grpDieuKien.Controls.Add(this.btnXuatExcel);
            this.grpDieuKien.Controls.Add(this.btnLamMoi);
            this.grpDieuKien.Controls.Add(this.btnThongKe);
            this.grpDieuKien.Controls.Add(this.nudNam);
            this.grpDieuKien.Controls.Add(this.cboQuy);
            this.grpDieuKien.Controls.Add(this.label3);
            this.grpDieuKien.Controls.Add(this.label2);
            this.grpDieuKien.Location = new System.Drawing.Point(38, 93);
            this.grpDieuKien.Name = "grpDieuKien";
            this.grpDieuKien.Size = new System.Drawing.Size(882, 156);
            this.grpDieuKien.TabIndex = 3;
            this.grpDieuKien.TabStop = false;
            this.grpDieuKien.Text = "Điều kiện";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(711, 109);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 41);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(517, 109);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(95, 41);
            this.btnXuatExcel.TabIndex = 7;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(302, 109);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 41);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(87, 109);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(95, 41);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(182, 72);
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
            this.nudNam.TabIndex = 4;
            this.nudNam.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            // 
            // cboQuy
            // 
            this.cboQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuy.FormattingEnabled = true;
            this.cboQuy.Items.AddRange(new object[] {
            "Quý 1",
            "Quý 2",
            "Quý 3",
            "Quý 4"});
            this.cboQuy.Location = new System.Drawing.Point(182, 33);
            this.cboQuy.Name = "cboQuy";
            this.cboQuy.Size = new System.Drawing.Size(469, 24);
            this.cboQuy.TabIndex = 3;
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.dgvDoanhThuTheoQuy);
            this.grpKetQua.Location = new System.Drawing.Point(38, 283);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(882, 258);
            this.grpKetQua.TabIndex = 4;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "Doanh thu theo quý:";
            // 
            // dgvDoanhThuTheoQuy
            // 
            this.dgvDoanhThuTheoQuy.AllowUserToAddRows = false;
            this.dgvDoanhThuTheoQuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThuTheoQuy.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThuTheoQuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThuTheoQuy.Location = new System.Drawing.Point(7, 38);
            this.dgvDoanhThuTheoQuy.MultiSelect = false;
            this.dgvDoanhThuTheoQuy.Name = "dgvDoanhThuTheoQuy";
            this.dgvDoanhThuTheoQuy.ReadOnly = true;
            this.dgvDoanhThuTheoQuy.RowHeadersVisible = false;
            this.dgvDoanhThuTheoQuy.RowHeadersWidth = 51;
            this.dgvDoanhThuTheoQuy.RowTemplate.Height = 24;
            this.dgvDoanhThuTheoQuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThuTheoQuy.Size = new System.Drawing.Size(869, 214);
            this.dgvDoanhThuTheoQuy.TabIndex = 0;
            // 
            // frmDoanhThuTheoQuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.grpDieuKien);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoanhThuTheoQuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu theo quý";
            this.grpDieuKien.ResumeLayout(false);
            this.grpDieuKien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            this.grpKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuTheoQuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDieuKien;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.ComboBox cboQuy;
        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dgvDoanhThuTheoQuy;
    }
}