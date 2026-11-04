using btl_wf;
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

namespace giaodien
{
    
    public partial class frmTimKiemSach : Form
    {
        string connectString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySachWF;Integrated Security=True;";
        public frmTimKiemSach()
        {
            InitializeComponent();
            cboTieuChi.Items.Clear();
            cboTieuChi.Items.Add("Tên sách");
            cboTieuChi.Items.Add("Mã sách");
            cboTieuChi.Items.Add("Giá bán");

            cboTieuChi.SelectedIndex = 0;

            this.Load += frmTimKiemSach_Load;
            btnTimKiem.Click += btnTimKiem_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnThoat.Click += btnThoat_Click;
        }

        private void frmTimKiemSach_Load(object sender, EventArgs e)
        {
            LoadDanhSachSach();
        }
        // Lấy toàn bộ danh sách sách
        private void LoadDanhSachSach()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    string sql = @"SELECT MaSach, TenSach, TheLoai, TacGia, GiaBan FROM Sach";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvKetQua.AutoGenerateColumns = false;
                    dgvKetQua.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sách: " + ex.Message);
            }
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

            try
            {
                using (SqlConnection conn = new SqlConnection(connectString))
                {
                    string sql = "";
                    if (cboTieuChi.Text == "Mã sách")
                    {
                        sql = "SELECT * FROM Sach WHERE MaSach LIKE @TuKhoa";
                    }
                    else if (cboTieuChi.Text == "Tên sách")
                    {
                        sql = "SELECT * FROM Sach WHERE TenSach LIKE @TuKhoa";
                    }
                    else if (cboTieuChi.Text == "Giá bán")
                    {
                        sql = "SELECT * FROM Sach WHERE CONVERT(NVARCHAR(30), GiaBan) LIKE @TuKhoa";
                    }
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvKetQua.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy sách phù hợp!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTuKhoa.Clear();
            cboTieuChi.SelectedIndex = 0;
            LoadDanhSachSach();
            txtTuKhoa.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
