using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_wf
{
    public partial class frmquanlynguoidung : Form
    {
        classdatabase1 db = new classdatabase1();
        string cheDo = "";
        public frmquanlynguoidung()
        {
            InitializeComponent();
        }
        string Q(string s) { return s.Trim().Replace("'", "''"); }

        private void frmquanlynguoidung_Load(object sender, EventArgs e)
        {


            txtmanguoidung.ReadOnly = true;
            cbovaitro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotrangthai.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadCombo();
            LoadData();
        }
        void LoadCombo()
        {
            cbovaitro.Items.Clear();
            cbotrangthai.Items.Clear();
            foreach (DataRow r in db.LayDuLieu("SELECT TenVaiTro FROM VaiTro").Rows)
                cbovaitro.Items.Add(r[0].ToString());
            foreach (DataRow r in db.LayDuLieu("SELECT TenTrangThai FROM TrangThai").Rows)
                cbotrangthai.Items.Add(r[0].ToString());
        }

        void LoadData()
        {
            DataTable dt = db.LayDuLieu(
                @"SELECT Ma AS [Mã người dùng], HoTen AS [Họ tên],
                         TenDN AS [Tên đăng nhập], TenVaiTro AS [Vai trò],
                         TenTrangThai AS [Trạng thái]
                  FROM NguoiDung");
            dgvdanhsach.DataSource = dt;

        }
        bool HopLe()
        {
            if (txthoten.Text.Trim() == "" || txttendangnhap.Text.Trim() == "")
            {
                MessageBox.Show("Nhập đầy đủ họ tên và tên đăng nhập!");
                return false;
            }
            if (cbovaitro.SelectedIndex < 0 || cbotrangthai.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn vai trò và trạng thái!");
                return false;
            }
            return true;
        }
        void XoaTrang()
        {
            txtmanguoidung.Clear();
            txthoten.Clear();
            txttendangnhap.Clear();
            cbovaitro.SelectedIndex = -1;
            cbotrangthai.SelectedIndex = -1;
            txthoten.Focus();
        }


        private void dgvdanhsach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvdanhsach.CurrentRow == null) return;
            txtmanguoidung.Text = dgvdanhsach.CurrentRow.Cells[0].Value.ToString();
            txthoten.Text = dgvdanhsach.CurrentRow.Cells[1].Value.ToString();
            txttendangnhap.Text = dgvdanhsach.CurrentRow.Cells[2].Value.ToString();
            cbovaitro.Text = dgvdanhsach.CurrentRow.Cells[3].Value.ToString();
            cbotrangthai.Text = dgvdanhsach.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            cheDo = "them";
            DataTable dt = db.LayDuLieu(
                "SELECT ISNULL(MAX(CAST(SUBSTRING(Ma,3,10) AS INT)),0)+1 FROM NguoiDung");
            int so = Convert.ToInt32(dt.Rows[0][0]);
            txtmanguoidung.Text = "ND" + so.ToString("000");
            txthoten.Clear();
            txttendangnhap.Clear();
            cbovaitro.SelectedIndex = cbovaitro.Items.Count - 1;
            cbotrangthai.SelectedIndex = 0;

            txthoten.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmanguoidung.Text == "")
            {
                MessageBox.Show("Chọn người dùng cần sửa trong danh sách!");
                return;
            }
            if (!HopLe()) return;

            DataTable kt = db.LayDuLieu(
                "SELECT * FROM NguoiDung WHERE TenDN = N'" + Q(txttendangnhap.Text) +
                "' AND Ma <> N'" + Q(txtmanguoidung.Text) + "'");
            if (kt.Rows.Count > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }

            db.ThucThi("UPDATE NguoiDung SET HoTen = N'" + Q(txthoten.Text) +
                       "', TenDN = N'" + Q(txttendangnhap.Text) +
                       "', TenVaiTro = N'" + Q(cbovaitro.Text) +
                       "', TenTrangThai = N'" + Q(cbotrangthai.Text) +
                       "' WHERE Ma = N'" + Q(txtmanguoidung.Text) + "'");

            MessageBox.Show("Đã cập nhật.");
            LoadData();
        }

        private void dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmanguoidung.Text == "")
            {
                MessageBox.Show("Chọn người dùng cần xóa!");
                return;
            }
            if (MessageBox.Show("Xóa người dùng này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.ThucThi("DELETE FROM NguoiDung WHERE Ma = N'" + Q(txtmanguoidung.Text) + "'");
                LoadData();
                XoaTrang();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            XoaTrang();
        }

        private void btndatlaimk_Click(object sender, EventArgs e)
        {
            if (txtmanguoidung.Text == "")
            {
                MessageBox.Show("Chọn người dùng cần đặt lại mật khẩu!");
                return;
            }
            db.ThucThi("UPDATE NguoiDung SET MatKhau = '123456' WHERE Ma = N'" + Q(txtmanguoidung.Text) + "'");
            MessageBox.Show("Đã đặt lại mật khẩu về 123456");
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbltieude_Click(object sender, EventArgs e)
        {

        }
    }
}

