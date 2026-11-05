using btl_wf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodien
{
    public partial class frmTimKiemKhachHang : Form
    {
        classdatabase1 db = new classdatabase1();
        public frmTimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.Columns.Clear();
            dgvKhachHang.AutoGenerateColumns = true;

            cboTimTheo.Items.Clear();
            cboTimTheo.Items.Add("Mã khách hàng");
            cboTimTheo.Items.Add("Tên khách hàng");
            cboTimTheo.Items.Add("Giới tính");
            cboTimTheo.Items.Add("Số điện thoại");
            cboTimTheo.SelectedIndex = 0;
            HienThiKhachHang();
            dgvKhachHang.ReadOnly = true;
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.MultiSelect = false;
        }
        private void HienThiKhachHang()
        {
            string sql =
                "SELECT MaKH AS [Mã khách hàng], " +
                "TenKH AS [Tên khách hàng], " +
                "GioiTinh AS [Giới tính], " +
                "SDT AS [Số điện thoại] " +
                "FROM KhachHang";
            dgvKhachHang.DataSource = db.LayDuLieu(sql);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();

            if (tuKhoa == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!");
                txtTuKhoa.Focus();
                return;
            }

            string tuKhoaSQL = tuKhoa.Replace("'", "''");
            string sql = "";

            if (cboTimTheo.SelectedIndex == 0)
            {
                sql =
                    "SELECT MaKH AS [Mã khách hàng], " +
                    "TenKH AS [Tên khách hàng], " +
                    "GioiTinh AS [Giới tính], " +
                    "SDT AS [Số điện thoại] " +
                    "FROM KhachHang " +
                    "WHERE MaKH LIKE N'%" + tuKhoaSQL + "%'";
            }
            else if (cboTimTheo.SelectedIndex == 1)
            {
                sql =
                    "SELECT MaKH AS [Mã khách hàng], " +
                    "TenKH AS [Tên khách hàng], " +
                    "GioiTinh AS [Giới tính], " +
                    "SDT AS [Số điện thoại] " +
                    "FROM KhachHang " +
                    "WHERE TenKH LIKE N'%" + tuKhoaSQL + "%'";
            }
            else if (cboTimTheo.SelectedIndex == 2)
            {
                sql =
                    "SELECT MaKH AS [Mã khách hàng], " +
                    "TenKH AS [Tên khách hàng], " +
                    "GioiTinh AS [Giới tính], " +
                    "SDT AS [Số điện thoại] " +
                    "FROM KhachHang " +
                    "WHERE GioiTinh LIKE N'%" + tuKhoaSQL + "%'";
            }
            else
            {
                sql =
                    "SELECT MaKH AS [Mã khách hàng], " +
                    "TenKH AS [Tên khách hàng], " +
                    "GioiTinh AS [Giới tính], " +
                    "SDT AS [Số điện thoại] " +
                    "FROM KhachHang " +
                    "WHERE SDT LIKE N'%" + tuKhoaSQL + "%'";
            }

            DataTable dt = db.LayDuLieu(sql);
            dgvKhachHang.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng phù hợp!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            cboTimTheo.SelectedIndex = 0;
            HienThiKhachHang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
