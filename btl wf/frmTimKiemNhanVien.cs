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
using btl_wf;

namespace giaodien
{
    public partial class frmTimKiemNhanVien : Form
    {
        classdatabase1 db = new classdatabase1();
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }

        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Columns.Clear();
            dgvNhanVien.AutoGenerateColumns = true;

            cboTimTheo.Items.Clear();
            cboTimTheo.Items.Add("Mã nhân viên");
            cboTimTheo.Items.Add("Tên nhân viên");
            cboTimTheo.Items.Add("Giới tính");
            cboTimTheo.Items.Add("Số điện thoại");

            cboTimTheo.SelectedIndex = 0;

            HienThiNhanVien();

            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.MultiSelect = false;
        }
        private void HienThiNhanVien()
        {
            string sql =
                "SELECT MaNV AS [Mã nhân viên], " +
                "TenNV AS [Tên nhân viên], " +
                "GioiTinh AS [Giới tính], " +
                "NgaySinh AS [Ngày sinh], " +
                "SDT AS [Số điện thoại], " +
                "DiaChi AS [Địa chỉ] " +
                "FROM NhanVien";

            dgvNhanVien.DataSource = db.LayDuLieu(sql);
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

            string sql = "";
            string tuKhoaSQL = tuKhoa.Replace("'", "''");

            if (cboTimTheo.SelectedIndex == 0)
            {
                sql = "SELECT MaNV AS [Mã nhân viên], " +
                      "TenNV AS [Tên nhân viên], " +
                      "GioiTinh AS [Giới tính], " +
                      "NgaySinh AS [Ngày sinh], " +
                      "SDT AS [Số điện thoại], " +
                      "DiaChi AS [Địa chỉ] " +
                      "FROM NhanVien " +
                      "WHERE MaNV LIKE N'%" + tuKhoaSQL + "%'";
            }
            else if (cboTimTheo.SelectedIndex == 1)
            {
                sql = "SELECT MaNV AS [Mã nhân viên], " +
                      "TenNV AS [Tên nhân viên], " +
                      "GioiTinh AS [Giới tính], " +
                      "NgaySinh AS [Ngày sinh], " +
                      "SDT AS [Số điện thoại], " +
                      "DiaChi AS [Địa chỉ] " +
                      "FROM NhanVien " +
                      "WHERE TenNV LIKE N'%" + tuKhoaSQL + "%'";
            }
            else if (cboTimTheo.SelectedIndex == 2)
            {
                sql = "SELECT MaNV AS [Mã nhân viên], " +
                      "TenNV AS [Tên nhân viên], " +
                      "GioiTinh AS [Giới tính], " +
                      "NgaySinh AS [Ngày sinh], " +
                      "SDT AS [Số điện thoại], " +
                      "DiaChi AS [Địa chỉ] " +
                      "FROM NhanVien " +
                      "WHERE GioiTinh LIKE N'%" + tuKhoaSQL + "%'";
            }
            else
            {
                sql = "SELECT MaNV AS [Mã nhân viên], " +
                      "TenNV AS [Tên nhân viên], " +
                      "GioiTinh AS [Giới tính], " +
                      "NgaySinh AS [Ngày sinh], " +
                      "SDT AS [Số điện thoại], " +
                      "DiaChi AS [Địa chỉ] " +
                      "FROM NhanVien " +
                      "WHERE SDT LIKE N'%" + tuKhoaSQL + "%'";
            }

            DataTable dt = db.LayDuLieu(sql);
            dgvNhanVien.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên phù hợp!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            cboTimTheo.SelectedIndex = 0;
            HienThiNhanVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
