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
    public partial class frmNhanVien : Form
    {

        classdatabase1 db = new classdatabase1();
        string cheDo = "";   // "them" | "sua" | "" (đang xem)



        public frmNhanVien()
        {
            InitializeComponent();
        }

        string Q(string s)
        {
            return s.Trim().Replace("'", "''");
        }

        private void gbQuanLyNhanVien_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Mã tự sinh nên không cho gõ
            txtMa.ReadOnly = true;

            // Ngày sinh
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.MaxDate = DateTime.Today;

            // Giới tính
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");

            // Lưới: chọn cả dòng, bỏ dòng trống cuối, vừa khít chiều ngang
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadData();
            KhoaNhap(true);
        }

        void LoadData()
        {
            try
            {
                dgv.DataSource = db.LayDuLieu("SELECT * FROM NhanVien ORDER BY MaNV");

                dgv.Columns["MaNV"].HeaderText = "Mã NV";
                dgv.Columns["HoTen"].HeaderText = "Họ tên";
                dgv.Columns["NgaySinh"].HeaderText = "Ngày sinh";
                dgv.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgv.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgv.Columns["SoDienThoai"].HeaderText = "Điện thoại";
                dgv.Columns["ChucVu"].HeaderText = "Chức vụ";
                dgv.Columns["DiaChi"].HeaderText = "Địa chỉ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
        void KhoaNhap(bool khoa)
        {
            txtTen.Enabled = txtSDT.Enabled = txtEmail.Enabled = !khoa;
            txtChucVu.Enabled = txtDiaChi.Enabled = !khoa;
            dtpNgaySinh.Enabled = cboGioiTinh.Enabled = !khoa;

            btnLuu.Enabled = btnHuy.Enabled = !khoa;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = khoa;
        }
        void HienThiDong()
        {
            if (dgv.CurrentRow == null) return;
            DataGridViewRow r = dgv.CurrentRow;

            txtMa.Text = Convert.ToString(r.Cells["MaNV"].Value);
            txtTen.Text = Convert.ToString(r.Cells["HoTen"].Value);
            if (r.Cells["NgaySinh"].Value != DBNull.Value)
                dtpNgaySinh.Value = Convert.ToDateTime(r.Cells["NgaySinh"].Value);
            cboGioiTinh.Text = Convert.ToString(r.Cells["GioiTinh"].Value);
            txtSDT.Text = Convert.ToString(r.Cells["SoDienThoai"].Value);
            txtEmail.Text = Convert.ToString(r.Cells["Email"].Value);
            txtChucVu.Text = Convert.ToString(r.Cells["ChucVu"].Value);
            txtDiaChi.Text = Convert.ToString(r.Cells["DiaChi"].Value);
        }

        // Sau khi lưu thì chọn lại đúng dòng vừa thêm/sửa
        void ChonDong(string ma)
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                if (Convert.ToString(r.Cells["MaNV"].Value) == ma)
                {
                    dgv.CurrentCell = r.Cells["MaNV"];
                    break;
                }
            }
        }




        private void btnThem_Click(object sender, EventArgs e)
        {
            cheDo = "them";

            object so = db.LayDuLieu(
                "SELECT ISNULL(MAX(CAST(SUBSTRING(MaNV,3,10) AS INT)),0)+1 FROM NhanVien").Rows[0][0];
            txtMa.Text = "NV" + Convert.ToInt32(so).ToString("000");

            txtTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtChucVu.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = DateTime.Today.AddYears(-18);
            cboGioiTinh.SelectedIndex = 0;

            KhoaNhap(false);
            txtTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Chọn nhân viên cần sửa!");
                return;
            }
            cheDo = "sua";
            KhoaNhap(false);
            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Chọn nhân viên cần xóa!");
                return;
            }
            if (MessageBox.Show("Xóa nhân viên " + txtTen.Text + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                db.ThucThi("DELETE FROM NhanVien WHERE MaNV = N'" + Q(txtMa.Text) + "'");
                LoadData();
                HienThiDong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được:\n" + ex.Message);
            }

        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            cheDo = "";
            KhoaNhap(true);
            HienThiDong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "" || txtChucVu.Text.Trim() == "")
            {
                MessageBox.Show("Nhập họ tên và chức vụ!");
                return;
            }
            if (cboGioiTinh.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn giới tính!");
                return;
            }

            // Kiểm tra từ 18 tuổi (xóa đoạn này nếu không cần)
            int tuoi = DateTime.Today.Year - dtpNgaySinh.Value.Year;
            if (dtpNgaySinh.Value.Date > DateTime.Today.AddYears(-tuoi)) tuoi--;
            if (tuoi < 18)
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!");
                return;
            }

            string ma = txtMa.Text;
            string ngay = dtpNgaySinh.Value.ToString("yyyy-MM-dd");

            try
            {
                if (cheDo == "them")
                {
                    db.ThucThi(
                        "INSERT INTO NhanVien(MaNV,HoTen,NgaySinh,GioiTinh,SoDienThoai,Email,ChucVu,DiaChi) VALUES(N'" + Q(ma) + "', N'" + Q(txtTen.Text) + "', '" + ngay + "', N'" + Q(cboGioiTinh.Text) +
                        "', N'" + Q(txtSDT.Text) + "', N'" + Q(txtEmail.Text) +
                        "', N'" + Q(txtChucVu.Text) + "', N'" + Q(txtDiaChi.Text) + "')");
                }
                else if (cheDo == "sua")
                {
                    db.ThucThi(
                        "UPDATE NhanVien SET HoTen = N'" + Q(txtTen.Text) +
                        "', NgaySinh = '" + ngay +
                        "', GioiTinh = N'" + Q(cboGioiTinh.Text) +
                        "', SoDienThoai = N'" + Q(txtSDT.Text) +
                        "', Email = N'" + Q(txtEmail.Text) +
                        "', ChucVu = N'" + Q(txtChucVu.Text) +
                        "', DiaChi = N'" + Q(txtDiaChi.Text) +
                        "' WHERE MaNV = N'" + Q(ma) + "'");
                }

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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (cheDo == " ") HienThiDong();
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
