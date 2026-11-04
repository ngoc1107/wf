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
    public partial class frmquanlydanhmuc : Form
    {
        classdatabase1 db = new classdatabase1();
        string cheDo = "";   // "them" | "sua" | ""

        public frmquanlydanhmuc()
        {
            InitializeComponent();
        }

        // Chống lỗi khi người dùng gõ dấu '
        string Q(string s)
        {
            return s.Trim().Replace("'", "''");
        }

        // ================= LOAD =================
        private void frmquanlydanhmuc_Load(object sender, EventArgs e)
        {
            LoadData();
            KhoaNhap(true);
            HienThiDong();
        }

        void LoadData()
        {
            DataTable dt = db.LayDuLieu(
                @"SELECT MaDM  AS [Mã danh mục],
                         TenDM AS [Tên danh mục],
                         MoTa  AS [Mô tả]
                  FROM DanhMuc
                  ORDER BY MaDM");
            dgvDanhMuc.DataSource = dt;
           
        }

        // true = đang xem (khóa ô nhập), false = đang thêm/sửa (mở ô nhập)
        void KhoaNhap(bool khoa)
        {
            txttendanhmuc.Enabled = txtmota.Enabled = !khoa;
            btnluu.Enabled = btnhuy.Enabled = !khoa;
            btnthem.Enabled = btnsua.Enabled = btnxoa.Enabled = khoa;
            dgvDanhMuc.Enabled = khoa;
        }

        void HienThiDong()
        {
            if (dgvDanhMuc.CurrentRow == null)
            {
                txtmadanhmuc.Clear();
                txttendanhmuc.Clear();
                txtmota.Clear();
                return;
            }
            txtmadanhmuc.Text = dgvDanhMuc.CurrentRow.Cells[0].Value.ToString();
            txttendanhmuc.Text = dgvDanhMuc.CurrentRow.Cells[1].Value.ToString();
            txtmota.Text = dgvDanhMuc.CurrentRow.Cells[2].Value.ToString();
        }

        // Sau khi lưu thì chọn lại đúng dòng vừa thêm/sửa
        void ChonDong(string ma)
        {
            foreach (DataGridViewRow r in dgvDanhMuc.Rows)
            {
                if (r.Cells[0].Value.ToString() == ma)
                {
                    dgvDanhMuc.CurrentCell = r.Cells[0];
                    break;
                }
            }
        }

        // ================= SỰ KIỆN =================
        private void dgvDanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            if (cheDo == "") HienThiDong();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            cheDo = "them";
            DataTable dt = db.LayDuLieu(
                "SELECT ISNULL(MAX(CAST(SUBSTRING(MaDM,3,10) AS INT)),0)+1 FROM DanhMuc");
            txtmadanhmuc.Text = "DM" + Convert.ToInt32(dt.Rows[0][0]).ToString("000");
            txttendanhmuc.Clear();
            txtmota.Clear();
            KhoaNhap(false);
            txttendanhmuc.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow == null)
            {
                MessageBox.Show("Chọn danh mục cần sửa!");
                return;
            }
            cheDo = "sua";
            KhoaNhap(false);
            txttendanhmuc.Focus();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow == null)
            {
                MessageBox.Show("Chọn danh mục cần xóa!");
                return;
            }
            if (MessageBox.Show("Xóa danh mục " + txttendanhmuc.Text + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                db.ThucThi("DELETE FROM DanhMuc WHERE MaDM = N'" + Q(txtmadanhmuc.Text) + "'");
                LoadData();
                HienThiDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được (danh mục đang được dùng?):\n" + ex.Message);
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txttendanhmuc.Text.Trim() == "")
            {
                MessageBox.Show("Nhập tên danh mục!");
                txttendanhmuc.Focus();
                return;
            }

            // Kiểm tra trùng tên (bỏ qua chính dòng đang sửa)
            DataTable kt = db.LayDuLieu(
                "SELECT * FROM DanhMuc WHERE TenDM = N'" + Q(txttendanhmuc.Text) +
                "' AND MaDM <> N'" + Q(txtmadanhmuc.Text) + "'");
            if (kt.Rows.Count > 0)
            {
                MessageBox.Show("Tên danh mục đã tồn tại!");
                txttendanhmuc.Focus();
                return;
            }

            try
            {
                if (cheDo == "them")
                {
                    db.ThucThi("INSERT INTO DanhMuc VALUES(N'" + Q(txtmadanhmuc.Text) +
                               "', N'" + Q(txttendanhmuc.Text) +
                               "', N'" + Q(txtmota.Text) + "')");
                }
                else if (cheDo == "sua")
                {
                    db.ThucThi("UPDATE DanhMuc SET TenDM = N'" + Q(txttendanhmuc.Text) +
                               "', MoTa = N'" + Q(txtmota.Text) +
                               "' WHERE MaDM = N'" + Q(txtmadanhmuc.Text) + "'");
                }

                string ma = txtmadanhmuc.Text;
                cheDo = "";
                KhoaNhap(true);
                LoadData();
                ChonDong(ma);
                HienThiDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lưu được:\n" + ex.Message);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            cheDo = "";
            KhoaNhap(true);
            HienThiDong();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
