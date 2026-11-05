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
    public partial class frmTimKiemHoaDonNhap : Form
    {
        classdatabase1 db = new classdatabase1();
        public frmTimKiemHoaDonNhap()
        {
            InitializeComponent();
            this.Load += frmTimKiemHoaDonNhap_Load;
            btnTimKiem.Click += btnTimKiem_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnThoat.Click += btnThoat_Click;
        }
        string Q(string s)
        {
            return s.Trim().Replace("'", "''");
        }
        private void frmTimKiemHoaDonNhap_Load(object sender, EventArgs e)
        {
            dgvHoaDonNhap.Columns.Clear();
            dgvHoaDonNhap.AutoGenerateColumns = true;

            cboTimTheo.Items.Clear();
            cboTimTheo.Items.Add("Mã hóa đơn");
            cboTimTheo.Items.Add("Nhà cung cấp");
            cboTimTheo.Items.Add("Tên nhân viên");

            cboTimTheo.SelectedIndex = 0;

            dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Today;

            HienThiHoaDon();
        }
        void HienThiHoaDon()
        {
            string sql = @"
                SELECT
                    hd.MaHD AS [Mã hóa đơn],
                    hd.NgayLap AS [Ngày nhập],
                    hd.MaNCC AS [Mã nhà cung cấp],
                    hd.MaNV AS [Mã nhân viên]
                FROM HoaDon hd
                ORDER BY hd.NgayLap DESC";

            DataTable dt = db.LayDuLieu(sql);
            dgvHoaDonNhap.DataSource = dt;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày!");
                return;
            }

            string tuKhoa = Q(txtTuKhoa.Text);
            string dieuKien = "";

            if (cboTimTheo.SelectedIndex == 0)
            {
                dieuKien = "AND hd.MaHD LIKE N'%" + tuKhoa + "%'";
            }
            else if (cboTimTheo.SelectedIndex == 1)
            {
                dieuKien = "AND (hd.MaNCC LIKE N'%" + tuKhoa +
                           "%' OR ncc.TenNCC LIKE N'%" + tuKhoa + "%')";
            }
            else if (cboTimTheo.SelectedIndex == 2)
            {
                dieuKien = "AND nv.HoTen LIKE N'%" + tuKhoa + "%'";
            }

            string sql = @"
                SELECT
                    hd.MaHD AS [Mã hóa đơn],
                    hd.NgayLap AS [Ngày nhập],
                    hd.MaNCC AS [Mã nhà cung cấp],
                    hd.MaNV AS [Mã nhân viên]
                FROM HoaDon hd
                LEFT JOIN NhaCungCap ncc
                    ON hd.MaNCC = ncc.MaNCC
                LEFT JOIN NhanVien nv
                    ON hd.MaNV = nv.MaNV
                WHERE hd.NgayLap >= '" +
                dtpTuNgay.Value.ToString("yyyy-MM-dd") +
                @"'
                AND hd.NgayLap < DATEADD(DAY, 1, '" +
                dtpDenNgay.Value.ToString("yyyy-MM-dd") +
                "')" + dieuKien + @"
                ORDER BY hd.NgayLap DESC";

            DataTable dt = db.LayDuLieu(sql);
            dgvHoaDonNhap.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn phù hợp!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();

            cboTimTheo.SelectedIndex = 0;

            dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Today;

            HienThiHoaDon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
