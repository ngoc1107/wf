namespace btl_wf
{
    partial class frmquanlydanhmuc
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpthongtinsach = new System.Windows.Forms.GroupBox();
            this.btndong = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txttendanhmuc = new System.Windows.Forms.TextBox();
            this.txtmadanhmuc = new System.Windows.Forms.TextBox();
            this.lblmota = new System.Windows.Forms.Label();
            this.lbltendanhmuc = new System.Windows.Forms.Label();
            this.lblmadanhmuc = new System.Windows.Forms.Label();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.grpthongtinsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(334, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DANH MỤC";
            // 
            // grpthongtinsach
            // 
            this.grpthongtinsach.Controls.Add(this.btndong);
            this.grpthongtinsach.Controls.Add(this.btnluu);
            this.grpthongtinsach.Controls.Add(this.btnhuy);
            this.grpthongtinsach.Controls.Add(this.btnxoa);
            this.grpthongtinsach.Controls.Add(this.btnsua);
            this.grpthongtinsach.Controls.Add(this.btnthem);
            this.grpthongtinsach.Controls.Add(this.txtmota);
            this.grpthongtinsach.Controls.Add(this.txttendanhmuc);
            this.grpthongtinsach.Controls.Add(this.txtmadanhmuc);
            this.grpthongtinsach.Controls.Add(this.lblmota);
            this.grpthongtinsach.Controls.Add(this.lbltendanhmuc);
            this.grpthongtinsach.Controls.Add(this.lblmadanhmuc);
            this.grpthongtinsach.Location = new System.Drawing.Point(12, 142);
            this.grpthongtinsach.Name = "grpthongtinsach";
            this.grpthongtinsach.Size = new System.Drawing.Size(1173, 298);
            this.grpthongtinsach.TabIndex = 1;
            this.grpthongtinsach.TabStop = false;
            this.grpthongtinsach.Text = "Thông tin danh mục";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(883, 247);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(94, 35);
            this.btndong.TabIndex = 14;
            this.btndong.Text = "Đóng ";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // btnluu
            // 
            this.btnluu.AutoSize = true;
            this.btnluu.Location = new System.Drawing.Point(716, 247);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(98, 35);
            this.btnluu.TabIndex = 13;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(565, 247);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(94, 35);
            this.btnhuy.TabIndex = 12;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(404, 247);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(94, 35);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.AutoSize = true;
            this.btnsua.Location = new System.Drawing.Point(262, 247);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(94, 35);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.AutoSize = true;
            this.btnthem.Location = new System.Drawing.Point(112, 247);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(94, 35);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(276, 140);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtmota.Size = new System.Drawing.Size(812, 78);
            this.txtmota.TabIndex = 5;
            // 
            // txttendanhmuc
            // 
            this.txttendanhmuc.Location = new System.Drawing.Point(276, 99);
            this.txttendanhmuc.Name = "txttendanhmuc";
            this.txttendanhmuc.Size = new System.Drawing.Size(100, 31);
            this.txttendanhmuc.TabIndex = 4;
            // 
            // txtmadanhmuc
            // 
            this.txtmadanhmuc.Location = new System.Drawing.Point(276, 45);
            this.txtmadanhmuc.Name = "txtmadanhmuc";
            this.txtmadanhmuc.Size = new System.Drawing.Size(100, 31);
            this.txtmadanhmuc.TabIndex = 3;
            // 
            // lblmota
            // 
            this.lblmota.AutoSize = true;
            this.lblmota.Location = new System.Drawing.Point(77, 161);
            this.lblmota.Name = "lblmota";
            this.lblmota.Size = new System.Drawing.Size(72, 25);
            this.lblmota.TabIndex = 2;
            this.lblmota.Text = "Mô tả:";
            // 
            // lbltendanhmuc
            // 
            this.lbltendanhmuc.AutoSize = true;
            this.lbltendanhmuc.Location = new System.Drawing.Point(75, 105);
            this.lbltendanhmuc.Name = "lbltendanhmuc";
            this.lbltendanhmuc.Size = new System.Drawing.Size(155, 25);
            this.lbltendanhmuc.TabIndex = 1;
            this.lbltendanhmuc.Text = "Tên danh mục:";
            // 
            // lblmadanhmuc
            // 
            this.lblmadanhmuc.AutoSize = true;
            this.lblmadanhmuc.Location = new System.Drawing.Point(75, 54);
            this.lblmadanhmuc.Name = "lblmadanhmuc";
            this.lblmadanhmuc.Size = new System.Drawing.Size(148, 25);
            this.lblmadanhmuc.TabIndex = 0;
            this.lblmadanhmuc.Text = "Mã danh mục:";
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Location = new System.Drawing.Point(45, 472);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersWidth = 82;
            this.dgvDanhMuc.RowTemplate.Height = 33;
            this.dgvDanhMuc.Size = new System.Drawing.Size(1055, 240);
            this.dgvDanhMuc.TabIndex = 2;
            this.dgvDanhMuc.SelectionChanged += new System.EventHandler(this.dgvDanhMuc_SelectionChanged);
            // 
            // frmquanlydanhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 823);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.grpthongtinsach);
            this.Controls.Add(this.label1);
            this.Name = "frmquanlydanhmuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmquanlydanhmuc_Load);
            this.grpthongtinsach.ResumeLayout(false);
            this.grpthongtinsach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpthongtinsach;
        private System.Windows.Forms.Label lbltendanhmuc;
        private System.Windows.Forms.Label lblmadanhmuc;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txttendanhmuc;
        private System.Windows.Forms.TextBox txtmadanhmuc;
        private System.Windows.Forms.Label lblmota;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
    }
}