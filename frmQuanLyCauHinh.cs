using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_wf
{
    public partial class frmQuanLyCauHinh : Form
    {
        public frmQuanLyCauHinh()
        {
            InitializeComponent();
        }
        classdatabase1 db = new classdatabase1();
        Dictionary<string, string> cfg = new Dictionary<string, string>();
        string Get(string key)
        {
            return cfg.ContainsKey(key) ? cfg[key] : "";
        }

        decimal So(string s)
        {
            decimal kq;
            decimal.TryParse(s, out kq);
            return kq;
        }
        void LoadCauHinh()
        {
            DataTable dt = db.LayDuLieu("SELECT Ten, GiaTri FROM CauHinh");
            cfg.Clear();
            foreach (DataRow r in dt.Rows)
                cfg[r["Ten"].ToString()] = r["GiaTri"].ToString();

            // Tab Nhà sách
            txtTenNhaSach.Text = Get("TenNhaSach");
            txtDiaChi.Text = Get("DiaChi");
            txtSoDienThoai.Text = Get("SoDienThoai");
            textBox1.Text = Get("Email");

            // Tab Bán hàng
            nudVAT.Value = So(Get("VAT"));
            nudGiamGia.Value = So(Get("GiamGiaToiDa"));
            chkBanKhiHetHang.Checked = Get("BanKhiHetHang") == "1";
            chkCanhBao.Checked = Get("CanhBaoSapHet") == "1";
            nudTonKho.Value = So(Get("TonKhoToiThieu"));

            // Tab Sao lưu
            txtThuMucSaoLuu.Text = Get("ThuMucSaoLuu");
            chkSaoLuuTuDong.Checked = Get("SaoLuuTuDong") == "1";
            TimeSpan gio;
            if (!TimeSpan.TryParse(Get("GioSaoLuu"), out gio)) gio = TimeSpan.Zero;
            dtpThoiGianSaoLuu.Value = DateTime.Today + gio;

            // Tab Hóa đơn
            txtTienTo.Text = Get("TienToHoaDon");
            cboKhoGiay.Text = Get("KhoGiay");
            txtLoiCamOn.Text = Get("LoiCamOn");
            chkInHoaDon.Checked = Get("InHoaDon") == "1";
        }

        void LuuGiaTri(SqlConnection conn, string ten, string giaTri)
        {
            SqlCommand cmd = new SqlCommand("UPDATE CauHinh SET GiaTri = @v WHERE Ten = @t", conn);
            cmd.Parameters.AddWithValue("@v", giaTri);
            cmd.Parameters.AddWithValue("@t", ten);
            cmd.ExecuteNonQuery();
        }

        string Bit(bool b) { return b ? "1" : "0"; }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhoGiay.Items.AddRange(new object[] { "A4", "A5", "K80" });
            LoadCauHinh();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txttennhasach_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpbanhang_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nudvat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtTenNhaSach.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhà sách không được để trống!");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(db.constr))
                {
                    conn.Open();
                    LuuGiaTri(conn, "TenNhaSach", txtTenNhaSach.Text);
                    LuuGiaTri(conn, "DiaChi", txtDiaChi.Text);
                    LuuGiaTri(conn, "SoDienThoai", txtSoDienThoai.Text);
                    LuuGiaTri(conn, "Email", textBox1.Text);//Email
                    LuuGiaTri(conn, "VAT", nudVAT.Value.ToString());
                    LuuGiaTri(conn, "GiamGiaToiDa", nudGiamGia.Value.ToString());
                    LuuGiaTri(conn, "BanKhiHetHang", Bit(chkBanKhiHetHang.Checked));
                    LuuGiaTri(conn, "CanhBaoSapHet", Bit(chkCanhBao.Checked));
                    LuuGiaTri(conn, "TonKhoToiThieu", nudTonKho.Value.ToString());
                    LuuGiaTri(conn, "ThuMucSaoLuu", txtThuMucSaoLuu.Text);
                    LuuGiaTri(conn, "SaoLuuTuDong", Bit(chkSaoLuuTuDong.Checked));
                    LuuGiaTri(conn, "GioSaoLuu", dtpThoiGianSaoLuu.Value.ToString("HH:mm"));
                    LuuGiaTri(conn, "TienToHoaDon", txtTienTo.Text);
                    LuuGiaTri(conn, "KhoGiay", cboKhoGiay.Text);
                    LuuGiaTri(conn, "LoiCamOn", txtLoiCamOn.Text);
                    LuuGiaTri(conn, "InHoaDon", Bit(chkInHoaDon.Checked));
                }
                MessageBox.Show("Đã lưu cấu hình!");
                LoadCauHinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadCauHinh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nudVAT.Value = 10;
            nudGiamGia.Value = 20;
            chkBanKhiHetHang.Checked = false;
            chkCanhBao.Checked = true;
            nudTonKho.Value = 5;
            txtThuMucSaoLuu.Text = @"C:\Backup";
            chkSaoLuuTuDong.Checked = false;
            dtpThoiGianSaoLuu.Value = DateTime.Today;
            txtTienTo.Text = "HD";
            cboKhoGiay.Text = "A4";
            txtLoiCamOn.Text = "Cảm ơn quý khách!";
            chkInHoaDon.Checked = false;
            MessageBox.Show("Đã đặt lại mặc định. Bấm 'Lưu cấu hình' để áp dụng.");
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string thuMuc = txtThuMucSaoLuu.Text.Trim();
                if (thuMuc == "")
                {
                    MessageBox.Show("Hãy nhập thư mục sao lưu!");
                    return;
                }
                Directory.CreateDirectory(thuMuc);
                string file = Path.Combine(thuMuc,
                    "QuanLySachWF_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak");

                using (SqlConnection conn = new SqlConnection(db.constr))
                {
                    SqlCommand cmd = new SqlCommand("BACKUP DATABASE QuanLySachWF TO DISK = @file", conn);
                    cmd.Parameters.AddWithValue("@file", file);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Sao lưu thành công:\n" + file);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "File sao lưu (*.bak)|*.bak";
            if (ofd.ShowDialog() != DialogResult.OK) return;

            if (MessageBox.Show("Khôi phục sẽ GHI ĐÈ toàn bộ dữ liệu hiện tại. Tiếp tục?",
                "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                SqlConnection.ClearAllPools();
                string connMaster = db.constr.Replace("Database=QuanLySachWF", "Database=master");
                string sql = @"ALTER DATABASE QuanLySachWF SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                       RESTORE DATABASE QuanLySachWF FROM DISK = @file WITH REPLACE;ALTER DATABASE QuanLySachWF SET MULTI_USER;";
                using (SqlConnection conn = new SqlConnection(connMaster))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@file", ofd.FileName);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Khôi phục dữ liệu thành công!");
                LoadCauHinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
                        
         }
     }
}
