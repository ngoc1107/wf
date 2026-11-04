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
    public partial class frmquanlykhachhang : Form
    {
        public frmquanlykhachhang()
        {
            InitializeComponent();
        }
        string cs = new classdatabase1().constr;
        bool dangThem = false;

        private void frmquanlykhachhang_Load(object sender, EventArgs e)
        {
            LoadData();
            SetTrangThai(false);
        }
        DataTable LayBang(string sql)
        {
            using (var conn = new SqlConnection(cs))
            {
                var da = new SqlDataAdapter(sql, conn);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        void ChayLenh(string sql, params SqlParameter[] ps)
        {
            using (var conn = new SqlConnection(cs))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddRange(ps);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        void LoadData()
        {
            dgv.DataSource = LayBang("SELECT * FROM KhachHang");
        }

        void SetTrangThai(bool dangSua)
        {
            txtMa.ReadOnly = txtTen.ReadOnly = txtSDT.ReadOnly = !dangSua;
            txtEmail.ReadOnly = txtDiaChi.ReadOnly = txtGhiChu.ReadOnly = !dangSua;
            btnLuu.Enabled = btnHuy.Enabled = dangSua;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = !dangSua;
            dgv.Enabled = !dangSua;
        }

        void XoaTrang()
        {
            txtMa.Clear(); txtTen.Clear(); txtSDT.Clear();
            txtEmail.Clear(); txtDiaChi.Clear(); txtGhiChu.Clear();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var r = dgv.Rows[e.RowIndex];
            txtMa.Text = r.Cells["MaKH"].Value.ToString();
            txtTen.Text = r.Cells["TenKH"].Value.ToString();
            txtSDT.Text = r.Cells["SDT"].Value.ToString();
            txtEmail.Text = r.Cells["Email"].Value.ToString();
            txtDiaChi.Text = r.Cells["DiaChi"].Value.ToString();
            txtGhiChu.Text = r.Cells["GhiChu"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            dangThem = true;
            SetTrangThai(true);
            txtMa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Chọn khách hàng cần sửa!");
                return;
            }
            dangThem = false;
            SetTrangThai(true);
            txtMa.ReadOnly = true; // không cho sửa mã
            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Chọn khách hàng cần xóa!");
                return;
            }
            if (MessageBox.Show("Xóa khách hàng này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ChayLenh("DELETE FROM KhachHang WHERE MaKH=@ma",
                        new SqlParameter("@ma", txtMa.Text));
                    XoaTrang();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Trim() == "" || txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mã và tên khách hàng!");
                return;
            }
            string sql = dangThem
                ? "INSERT INTO KhachHang VALUES (@ma,@ten,@sdt,@email,@dc,@gc)"
                : "UPDATE KhachHang SET TenKH=@ten, SDT=@sdt, Email=@email, DiaChi=@dc, GhiChu=@gc WHERE MaKH=@ma";
            try
            {
                ChayLenh(sql,
                    new SqlParameter("@ma", txtMa.Text.Trim()),
                    new SqlParameter("@ten", txtTen.Text),
                    new SqlParameter("@sdt", txtSDT.Text),
                    new SqlParameter("@email", txtEmail.Text),
                    new SqlParameter("@dc", txtDiaChi.Text),
                    new SqlParameter("@gc", txtGhiChu.Text));
                LoadData();
                SetTrangThai(false);
                MessageBox.Show("Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XoaTrang();
            SetTrangThai(false);
        }
    }
}
