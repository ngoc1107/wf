using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_wf
{
    public partial class frmQuanLyNhaCungCap : Form
    {
        public frmQuanLyNhaCungCap()
        {
            InitializeComponent();
        }
        classdatabase1 db = new classdatabase1();
        bool dangThem = false;
        void LoadData()
        {
            DataTable dt = db.LayDuLieu("SELECT * FROM NhaCungCap");
            dgvNCC.DataSource = dt;
           
        }

        void XoaTrang()
        {
            txtMaNCC.Clear(); txtTenNCC.Clear(); txtNguoiLienHe.Clear();
            txtSoDienThoai.Clear(); txtEmail.Clear(); txtDiaChi.Clear(); txtGhiChu.Clear();
        }

        void BatNhap(bool bat)
        {
            txtTenNCC.Enabled = bat; txtNguoiLienHe.Enabled = bat;
            txtSoDienThoai.Enabled = bat; txtEmail.Enabled = bat;
            txtDiaChi.Enabled = bat; txtGhiChu.Enabled = bat;
            txtMaNCC.Enabled = bat && dangThem;   // chỉ cho nhập mã khi thêm mới
            btnLuu.Enabled = bat; btnHuy.Enabled = bat;
            btnThem.Enabled = !bat; btnSua.Enabled = !bat; btnXoa.Enabled = !bat;
        }

        void ChayLenh(string sql, params SqlParameter[] ps)
        {
            using (SqlConnection conn = new SqlConnection(db.constr))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(ps);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvNCC.Columns["MaNCC"].HeaderText = "Mã NCC";
            dgvNCC.Columns["TenNCC"].HeaderText = "Tên nhà cung cấp";
            dgvNCC.Columns["NguoiLienHe"].HeaderText = "Người liên hệ";
            dgvNCC.Columns["SoDienThoai"].HeaderText = "Điện thoại";
            dgvNCC.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvNCC.ReadOnly = true;
            dgvNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BatNhap(false);
        }

        private void s_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow r = dgvNCC.Rows[e.RowIndex];
            txtMaNCC.Text = r.Cells["MaNCC"].Value.ToString();
            txtTenNCC.Text = r.Cells["TenNCC"].Value.ToString();
            txtNguoiLienHe.Text = r.Cells["NguoiLienHe"].Value.ToString();
            txtSoDienThoai.Text = r.Cells["SoDienThoai"].Value.ToString();
            txtEmail.Text = r.Cells["Email"].Value.ToString();
            txtDiaChi.Text = r.Cells["DiaChi"].Value.ToString();
            txtGhiChu.Text = r.Cells["GhiChu"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            dangThem = true;
            XoaTrang();
            BatNhap(true);
            txtMaNCC.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Hãy chọn một nhà cung cấp trong bảng!");
                return;
            }
            dangThem = false;
            BatNhap(true);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Hãy chọn một nhà cung cấp để xóa!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ChayLenh("DELETE FROM NhaCungCap WHERE MaNCC = @ma",
                    new SqlParameter("@ma", txtMaNCC.Text));
                LoadData();
                XoaTrang();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text.Trim() == "" || txtTenNCC.Text.Trim() == "")
            {
                MessageBox.Show("Mã và tên nhà cung cấp không được để trống!");
                return;
            }

            string sql;
            if (dangThem)
                sql = "INSERT INTO NhaCungCap VALUES (@ma, @ten, @lh, @sdt, @email, @dc, @gc)";
            else
                sql = @"UPDATE NhaCungCap SET TenNCC=@ten, NguoiLienHe=@lh, SoDienThoai=@sdt,
                Email=@email, DiaChi=@dc, GhiChu=@gc WHERE MaNCC=@ma";

            try
            {
                ChayLenh(sql,
                    new SqlParameter("@ma", txtMaNCC.Text.Trim()),
                    new SqlParameter("@ten", txtTenNCC.Text),
                    new SqlParameter("@lh", txtNguoiLienHe.Text),
                    new SqlParameter("@sdt", txtSoDienThoai.Text),
                    new SqlParameter("@email", txtEmail.Text),
                    new SqlParameter("@dc", txtDiaChi.Text),
                    new SqlParameter("@gc", txtGhiChu.Text));

                MessageBox.Show("Lưu thành công!");
                dangThem = false;
                BatNhap(false);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);   // vd: trùng mã NCC
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            dangThem = false;
            XoaTrang();
            BatNhap(false);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
