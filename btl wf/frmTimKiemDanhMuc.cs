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
    public partial class frmTimKiemDanhMuc : Form
    {
        classdatabase1 db = new classdatabase1();
        public frmTimKiemDanhMuc()
        {
            InitializeComponent();
        }
        
        private void frmTimKiemDanhMuc_Load(object sender, EventArgs e)
        {
            dgvDanhMuc.AutoGenerateColumns = false;
            cboTimTheo.Items.Clear();
            cboTimTheo.Items.Add("Mã danh mục");
            cboTimTheo.Items.Add("Tên danh mục");
            cboTimTheo.SelectedIndex = 0;
            HienThiDanhMuc();
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void HienThiDanhMuc()
        {
            string sql = "SELECT MaDM AS [Mã danh mục], " + "TenDM AS [Tên danh mục] " + "FROM DanhMuc";
            dgvDanhMuc.DataSource = db.LayDuLieu(sql);
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

            if (cboTimTheo.SelectedIndex == 0)
            {
                sql = "SELECT MaDM AS [Mã danh mục], " +
              "TenDM AS [Tên danh mục] " +
              "FROM DanhMuc " +
              "WHERE MaDM LIKE N'%" +
              tuKhoa.Replace("'", "''") + "%'";
            }
            else
            {
                sql = "SELECT MaDM AS [Mã danh mục], " +
              "TenDM AS [Tên danh mục] " +
              "FROM DanhMuc " +
              "WHERE TenDM LIKE N'%" +
              tuKhoa.Replace("'", "''") + "%'";
            }
            DataTable dt = db.LayDuLieu(sql);
            dgvDanhMuc.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy danh mục phù hợp!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            cboTimTheo.SelectedIndex = 0;
            HienThiDanhMuc();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
