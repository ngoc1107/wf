namespace btl_wf
{
    partial class frmquanlynguoidung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmquanlynguoidung));
            this.lbltieude = new System.Windows.Forms.Label();
            this.grpThongtin = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.cbotrangthai = new System.Windows.Forms.ComboBox();
            this.cbovaitro = new System.Windows.Forms.ComboBox();
            this.btnhuy = new System.Windows.Forms.Button();
            this.lbltrangthai = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.lblvaitro = new System.Windows.Forms.Label();
            this.lbltendangnhap = new System.Windows.Forms.Label();
            this.btnsua = new System.Windows.Forms.Button();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.btndatlaimk = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.txtmanguoidung = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblmanguoidung = new System.Windows.Forms.Label();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.grpThongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltieude
            // 
            this.lbltieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbltieude.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltieude.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbltieude.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltieude.Location = new System.Drawing.Point(0, 0);
            this.lbltieude.Name = "lbltieude";
            this.lbltieude.Size = new System.Drawing.Size(1150, 49);
            this.lbltieude.TabIndex = 0;
            this.lbltieude.Text = "QUẢN LÝ NGƯỜI DÙNG";
            this.lbltieude.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbltieude.Click += new System.EventHandler(this.lbltieude_Click);
            // 
            // grpThongtin
            // 
            this.grpThongtin.Controls.Add(this.btnxoa);
            this.grpThongtin.Controls.Add(this.cbotrangthai);
            this.grpThongtin.Controls.Add(this.cbovaitro);
            this.grpThongtin.Controls.Add(this.btnhuy);
            this.grpThongtin.Controls.Add(this.lbltrangthai);
            this.grpThongtin.Controls.Add(this.btnthem);
            this.grpThongtin.Controls.Add(this.lblvaitro);
            this.grpThongtin.Controls.Add(this.lbltendangnhap);
            this.grpThongtin.Controls.Add(this.btnsua);
            this.grpThongtin.Controls.Add(this.txttendangnhap);
            this.grpThongtin.Controls.Add(this.txthoten);
            this.grpThongtin.Controls.Add(this.btndatlaimk);
            this.grpThongtin.Controls.Add(this.btndong);
            this.grpThongtin.Controls.Add(this.txtmanguoidung);
            this.grpThongtin.Controls.Add(this.lblhoten);
            this.grpThongtin.Controls.Add(this.lblmanguoidung);
            this.grpThongtin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpThongtin.Location = new System.Drawing.Point(12, 102);
            this.grpThongtin.Name = "grpThongtin";
            this.grpThongtin.Size = new System.Drawing.Size(1063, 258);
            this.grpThongtin.TabIndex = 1;
            this.grpThongtin.TabStop = false;
            this.grpThongtin.Text = "Thông tin người dùng";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(133, 196);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(94, 35);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // cbotrangthai
            // 
            this.cbotrangthai.FormattingEnabled = true;
            this.cbotrangthai.Location = new System.Drawing.Point(784, 122);
            this.cbotrangthai.Name = "cbotrangthai";
            this.cbotrangthai.Size = new System.Drawing.Size(121, 33);
            this.cbotrangthai.TabIndex = 9;
            // 
            // cbovaitro
            // 
            this.cbovaitro.FormattingEnabled = true;
            this.cbovaitro.Location = new System.Drawing.Point(784, 79);
            this.cbovaitro.Name = "cbovaitro";
            this.cbovaitro.Size = new System.Drawing.Size(121, 33);
            this.cbovaitro.TabIndex = 8;
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(233, 196);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(94, 35);
            this.btnhuy.TabIndex = 5;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            // 
            // lbltrangthai
            // 
            this.lbltrangthai.AutoSize = true;
            this.lbltrangthai.Location = new System.Drawing.Point(558, 122);
            this.lbltrangthai.Name = "lbltrangthai";
            this.lbltrangthai.Size = new System.Drawing.Size(115, 25);
            this.lbltrangthai.TabIndex = 7;
            this.lbltrangthai.Text = "Trạng thái:";
            // 
            // btnthem
            // 
            this.btnthem.AutoSize = true;
            this.btnthem.Location = new System.Drawing.Point(333, 196);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(94, 35);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lblvaitro
            // 
            this.lblvaitro.AutoSize = true;
            this.lblvaitro.Location = new System.Drawing.Point(558, 82);
            this.lblvaitro.Name = "lblvaitro";
            this.lblvaitro.Size = new System.Drawing.Size(80, 25);
            this.lblvaitro.TabIndex = 6;
            this.lblvaitro.Text = "Vai trò:";
            // 
            // lbltendangnhap
            // 
            this.lbltendangnhap.AutoSize = true;
            this.lbltendangnhap.Location = new System.Drawing.Point(558, 37);
            this.lbltendangnhap.Name = "lbltendangnhap";
            this.lbltendangnhap.Size = new System.Drawing.Size(163, 25);
            this.lbltendangnhap.TabIndex = 5;
            this.lbltendangnhap.Text = "Tên đăng nhập:";
            // 
            // btnsua
            // 
            this.btnsua.AutoSize = true;
            this.btnsua.Location = new System.Drawing.Point(433, 196);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(94, 35);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(784, 34);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(121, 31);
            this.txttendangnhap.TabIndex = 4;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(264, 83);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(163, 31);
            this.txthoten.TabIndex = 3;
            // 
            // btndatlaimk
            // 
            this.btndatlaimk.AutoSize = true;
            this.btndatlaimk.Location = new System.Drawing.Point(533, 196);
            this.btndatlaimk.Name = "btndatlaimk";
            this.btndatlaimk.Size = new System.Drawing.Size(177, 35);
            this.btndatlaimk.TabIndex = 6;
            this.btndatlaimk.Text = "Đặt lại mật khẩu";
            this.btndatlaimk.UseVisualStyleBackColor = true;
            this.btndatlaimk.Click += new System.EventHandler(this.btndatlaimk_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(716, 196);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(94, 35);
            this.btndong.TabIndex = 7;
            this.btndong.Text = "Đóng ";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // txtmanguoidung
            // 
            this.txtmanguoidung.Location = new System.Drawing.Point(264, 37);
            this.txtmanguoidung.Name = "txtmanguoidung";
            this.txtmanguoidung.Size = new System.Drawing.Size(163, 31);
            this.txtmanguoidung.TabIndex = 2;
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(33, 89);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(81, 25);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "Họ tên:";
            // 
            // lblmanguoidung
            // 
            this.lblmanguoidung.AutoSize = true;
            this.lblmanguoidung.Location = new System.Drawing.Point(28, 41);
            this.lblmanguoidung.Name = "lblmanguoidung";
            this.lblmanguoidung.Size = new System.Drawing.Size(161, 25);
            this.lblmanguoidung.TabIndex = 0;
            this.lblmanguoidung.Text = "Mã người dùng:";
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvdanhsach.Location = new System.Drawing.Point(0, 386);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.RowHeadersWidth = 82;
            this.dgvdanhsach.RowTemplate.Height = 33;
            this.dgvdanhsach.Size = new System.Drawing.Size(1150, 302);
            this.dgvdanhsach.TabIndex = 8;
            this.dgvdanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_CellContentClick);
            this.dgvdanhsach.SelectionChanged += new System.EventHandler(this.dgvdanhsach_SelectionChanged);
            // 
            // frmquanlynguoidung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 688);
            this.Controls.Add(this.dgvdanhsach);
            this.Controls.Add(this.grpThongtin);
            this.Controls.Add(this.lbltieude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmquanlynguoidung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.frmquanlynguoidung_Load);
            this.grpThongtin.ResumeLayout(false);
            this.grpThongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltieude;
        private System.Windows.Forms.GroupBox grpThongtin;
        private System.Windows.Forms.Label lblmanguoidung;
        private System.Windows.Forms.ComboBox cbotrangthai;
        private System.Windows.Forms.ComboBox cbovaitro;
        private System.Windows.Forms.Label lbltrangthai;
        private System.Windows.Forms.Label lblvaitro;
        private System.Windows.Forms.Label lbltendangnhap;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmanguoidung;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Button btndatlaimk;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
    }
}