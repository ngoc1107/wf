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
    public partial class frmTimKiemHoadonXuat : Form
    {
        classdatabase1 db = new classdatabase1();
        public frmTimKiemHoadonXuat()
        {
            InitializeComponent();
            // Gắn sự kiện cho các nút
            this.Load += frmTimKiemHoadonXuat_Load;
            btnTimKiem.Click += btnTimKiem_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnThoat.Click += btnThoat_Click;
        }

        private void frmTimKiemHoadonXuat_Load(object sender, EventArgs e)
        {
            cboTimTheo.Items.Clear();
            cboTimTheo.Items.Add("Mã hóa đơn");
            cboTimTheo.Items.Add("Tên khách hàng");
            cboTimTheo.Items.Add("Mã nhân viên");

            cboTimTheo.SelectedIndex = 0;

            dtpTuNgay.Value = new DateTime(2000, 1, 1);
            dtpDenNgay.Value = DateTime.Today;

            dgvHoaDonXuat.AutoGenerateColumns = true;
            dgvHoaDonXuat.AllowUserToAddRows = false;
            dgvHoaDonXuat.ReadOnly = true;
            dgvHoaDonXuat.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            TimKiemHoaDon();
        }
        private void TimKiemHoaDon()
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày!");
                return;
            }

            string tuKhoa = txtTuKhoa.Text.Trim();
            tuKhoa = tuKhoa.Replace("'", "''");

            string sql = @"
                SELECT
                    hd.MaHDX,
                    hd.NgayXuat,
                    hd.MaKH,
                    hd.MaNV,
                    hd.TongTien
                FROM HoaDonXuat hd
                INNER JOIN KhachHang kh
                    ON hd.MaKH = kh.MaKH
                INNER JOIN NhanVien nv
                    ON hd.MaNV = nv.MaNV
                WHERE
                    hd.NgayXuat >= '" + dtpTuNgay.Value.ToString("yyyyMMdd") + @"'
                    AND hd.NgayXuat < DATEADD(DAY, 1, '" +
                    dtpDenNgay.Value.ToString("yyyyMMdd") + "')";

            // Tìm theo mã hóa đơn
            if (cboTimTheo.Text == "Mã hóa đơn" && tuKhoa != "")
            {
                sql += " AND hd.MaHDX LIKE N'%" + tuKhoa + "%'";
            }

            // Tìm theo tên khách hàng
            else if (cboTimTheo.Text == "Tên khách hàng" && tuKhoa != "")
            {
                sql += " AND kh.TenKH LIKE N'%" + tuKhoa + "%'";
            }

            // Tìm theo mã nhân viên
            else if (cboTimTheo.Text == "Mã nhân viên" && tuKhoa != "")
            {
                sql += " AND hd.MaNV LIKE N'%" + tuKhoa + "%'";
            }

            sql += " ORDER BY hd.NgayXuat DESC";

            try
            {
                DataTable dt = db.LayDuLieu(sql);

                dgvHoaDonXuat.DataSource = null;
                dgvHoaDonXuat.Columns.Clear();
                dgvHoaDonXuat.DataSource = dt;

                // Đặt tên hiển thị cho các cột
                dgvHoaDonXuat.Columns["MaHDX"].HeaderText = "Mã hóa đơn";
                dgvHoaDonXuat.Columns["NgayXuat"].HeaderText = "Ngày xuất";
                dgvHoaDonXuat.Columns["MaKH"].HeaderText = "Mã khách hàng";
                dgvHoaDonXuat.Columns["MaNV"].HeaderText = "Mã nhân viên";
                dgvHoaDonXuat.Columns["TongTien"].HeaderText = "Tổng tiền";

                dgvHoaDonXuat.Columns["NgayXuat"].DefaultCellStyle.Format =
                    "dd/MM/yyyy";

                dgvHoaDonXuat.Columns["TongTien"].DefaultCellStyle.Format =
                    "N0";

                dgvHoaDonXuat.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm hóa đơn: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemHoaDon();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            cboTimTheo.SelectedIndex = 0;

            dtpTuNgay.Value = new DateTime(2000, 1, 1);
            dtpDenNgay.Value = DateTime.Today;

            TimKiemHoaDon();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
