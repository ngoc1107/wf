using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_wf
{
    public partial class frmhoadon : Form
    {
        private const string ConnStr =
           @"Server=localhost\SQLEXPRESS;Database=QuanLySachWF;Integrated Security=True;TrustServerCertificate=True;";

        private readonly DataTable dtChiTiet = new DataTable();
        private readonly CultureInfo vi = new CultureInfo("vi-VN");

        private string maNV;          // mã nhân viên đang lập hóa đơn
        private bool dangLoad;        // chặn event khi đang đổ dữ liệu vào combobox
        private bool daLuu;           // hóa đơn hiện tại đã lưu chưa
        private decimal donGiaHienTai;
        private decimal tienHang, tienThue, tongTien;

        public frmhoadon() : this(null) { }

        // Truyền MaNV của người đăng nhập vào đây. Nếu null thì lấy nhân viên đầu tiên trong bảng.
        public frmhoadon(string maNhanVien)
        {
            InitializeComponent();
            maNV = maNhanVien;
            Load += frmhoadon_Load;
        }

       

        private void frmhoadon_Load(object sender, EventArgs e)
        {
            try
            {
                CauHinhGiaoDien();
                GanSuKien();
                LoadNhanVien();
                KhoiTaoHoaDonMoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CauHinhGiaoDien()
        {
            // Bảng chi tiết (lưới)
            dtChiTiet.Columns.Add("MaSach", typeof(string));
            dtChiTiet.Columns.Add("TenSach", typeof(string));
            dtChiTiet.Columns.Add("SoLuong", typeof(int));
            dtChiTiet.Columns.Add("DonGia", typeof(decimal));
            dtChiTiet.Columns.Add("ThanhTien", typeof(decimal));

            dgvChiTiet.AutoGenerateColumns = true;
            dgvChiTiet.DataSource = dtChiTiet;
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AllowUserToDeleteRows = false;
            dgvChiTiet.MultiSelect = false;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvChiTiet.Columns["MaSach"].HeaderText = "Mã sách";
            dgvChiTiet.Columns["TenSach"].HeaderText = "Tên sách";
            dgvChiTiet.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvChiTiet.Columns["DonGia"].HeaderText = "Đơn giá (đ)";
            dgvChiTiet.Columns["ThanhTien"].HeaderText = "Thành tiền (đ)";

            dgvChiTiet.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (string c in new[] { "DonGia", "ThanhTien" })
            {
                dgvChiTiet.Columns[c].DefaultCellStyle.Format = "N0";
                dgvChiTiet.Columns[c].DefaultCellStyle.FormatProvider = vi;
                dgvChiTiet.Columns[c].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";

            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThanhToan.DropDownStyle = ComboBoxStyle.DropDownList;

            nudSoLuong.Minimum = 1;
            nudSoLuong.Maximum = 10000;
            nudSoLuong.Value = 1;
            nudVAT.Minimum = 0;
            nudVAT.Maximum = 100;
            nudVAT.Value = 0;

            foreach (TextBox t in new[] { txtMaHD, txtNhanVien, txtSDT, txtDiaChi,
                                          txtDonGia, txtTienHang, txtTienThue, txtTongThanhToan })
                t.ReadOnly = true;

            txtGhiChu.Multiline = true;

            if (cboThanhToan.Items.Count == 0)
                cboThanhToan.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "Thẻ" });
        }
        private void GanSuKien()
        {
            cboKhachHang.SelectedIndexChanged += (s, e) => HienThiKhachHang();
            cboSach.SelectedIndexChanged += (s, e) => HienThiDonGia();
            nudVAT.ValueChanged += (s, e) => TinhTien();

            btnThemSach.Click += btnThemSach_Click;
            
            btnTaoMoi.Click += btnTaoMoi_Click;
            btnLuu.Click += btnLuu_Click;
            btnIn.Click += btnIn_Click;
            btnHuy.Click += btnHuy_Click;
            btnDong.Click += btnDong_Click;
        }
        private DataTable LayBang(string sql)
        {
            var dt = new DataTable();
            using (var conn = new SqlConnection(ConnStr))
            using (var da = new SqlDataAdapter(sql, conn))
            {
                da.Fill(dt);
            }
            return dt;
        }
        private void LoadNhanVien()
        {
            DataTable dt;
            if (string.IsNullOrEmpty(maNV))
            {
                dt = LayBang("SELECT TOP 1 MaNV, HoTen FROM NhanVien ORDER BY MaNV");
            }
            else
            {
                using (var conn = new SqlConnection(ConnStr))
                using (var da = new SqlDataAdapter("SELECT MaNV, HoTen FROM NhanVien WHERE MaNV = @ma", conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@ma", maNV);
                    dt = new DataTable();
                    da.Fill(dt);
                }
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên. Hãy thêm dữ liệu vào bảng NhanVien.",
                    "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            maNV = dt.Rows[0]["MaNV"].ToString();
            txtNhanVien.Text = dt.Rows[0]["HoTen"].ToString();
        }
        private void LoadKhachHang()
        {
            dangLoad = true;
            cboKhachHang.DataSource = LayBang("SELECT MaKH, TenKH, SDT, DiaChi FROM KhachHang ORDER BY TenKH");
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
            cboKhachHang.SelectedIndex = -1;   // -1 = khách lẻ (không chọn khách)
            dangLoad = false;
            HienThiKhachHang();
        }
        private void LoadSach()
        {
            dangLoad = true;
            cboSach.DataSource = LayBang("SELECT MaSach, TenSach, GiaBan, SoLuongTon FROM Sach ORDER BY TenSach");
            cboSach.DisplayMember = "TenSach";
            cboSach.ValueMember = "MaSach";
            dangLoad = false;
            HienThiDonGia();
        }
        private string SinhMaHD()
        {
            using (var conn = new SqlConnection(ConnStr))
            using (var cmd = new SqlCommand("sp_SinhMaHD", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var p = cmd.Parameters.Add("@MaHD", SqlDbType.NVarChar, 10);
                p.Direction = ParameterDirection.Output;
                conn.Open();
                cmd.ExecuteNonQuery();
                return p.Value.ToString();
            }

        }
        private void HienThiKhachHang()
        {
            if (dangLoad) return;
            var drv = cboKhachHang.SelectedItem as DataRowView;
            txtSDT.Text = drv == null ? "" : drv["SDT"].ToString();
            txtDiaChi.Text = drv == null ? "" : drv["DiaChi"].ToString();
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
          
        
            if (daLuu)
            {
                MessageBox.Show("Hóa đơn đã lưu. Bấm \"Tạo mới\" để lập hóa đơn khác.");
                return;
            }

            var drv = cboSach.SelectedItem as DataRowView;
            if (drv == null)
            {
                MessageBox.Show("Vui lòng chọn sách.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ma = drv["MaSach"].ToString();
            string ten = drv["TenSach"].ToString();
            int ton = Convert.ToInt32(drv["SoLuongTon"]);
            decimal gia = Convert.ToDecimal(drv["GiaBan"]);
            int sl = (int)nudSoLuong.Value;

            // Tìm xem sách này đã có trong lưới chưa
            DataRow dong = null;
            foreach (DataRow r in dtChiTiet.Rows)
            {
                if (r["MaSach"].ToString() == ma) { dong = r; break; }
            }

            int daCo = dong == null ? 0 : (int)dong["SoLuong"];
            if (daCo + sl > ton)
            {
                MessageBox.Show("Không đủ hàng trong kho.\nTồn kho: " + ton + "\nĐã thêm vào hóa đơn: " + daCo,
                    "Vượt tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dong == null)
            {
                dtChiTiet.Rows.Add(ma, ten, sl, gia, sl * gia);
            }
            else
            {
                dong["SoLuong"] = daCo + sl;                 // trùng sách thì cộng dồn
                dong["ThanhTien"] = (daCo + sl) * gia;
            }

            nudSoLuong.Value = 1;
            TinhTien();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            if (!XacNhanBoHoaDon()) return;
            KhoiTaoHoaDonMoi();
        }
        private bool XacNhanBoHoaDon()
        {
            if (daLuu || dtChiTiet.Rows.Count == 0) return true;
            return MessageBox.Show("Hóa đơn chưa được lưu. Bạn có chắc muốn bỏ?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        private void KhoiTaoHoaDonMoi()
        {
            daLuu = false;
            dtChiTiet.Clear();
            dtpNgayLap.Value = DateTime.Today;
            txtGhiChu.Clear();
            cboThanhToan.SelectedIndex = 0;
            nudVAT.Value = 0;
            nudSoLuong.Value = 1;

            LoadKhachHang();
            LoadSach();            // load lại để cập nhật tồn kho mới nhất
            txtMaHD.Text = SinhMaHD();
            TinhTien();

            btnLuu.Enabled = true;
            btnIn.Enabled = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (daLuu)
            {
                MessageBox.Show("Hóa đơn này đã được lưu.");
                return;
            }
            if (dtChiTiet.Rows.Count == 0)
            {
                MessageBox.Show("Hóa đơn chưa có sách nào.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Chưa xác định được nhân viên lập hóa đơn.", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = new SqlConnection(ConnStr))
                {
                    conn.Open();
                    using (SqlTransaction tran = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Lưu header
                            const string sqlHD =
                                @"INSERT INTO HoaDon (MaHD, NgayLap, MaNV, MaKH, GhiChu, ThanhToan,
                                                      TienHang, ThueVAT, TienThue, TongTien)
                                  VALUES (@MaHD, @NgayLap, @MaNV, @MaKH, @GhiChu, @ThanhToan,
                                          @TienHang, @ThueVAT, @TienThue, @TongTien)";
                            using (var cmd = new SqlCommand(sqlHD, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                                cmd.Parameters.AddWithValue("@NgayLap", dtpNgayLap.Value.Date);
                                cmd.Parameters.AddWithValue("@MaNV", maNV);
                                cmd.Parameters.AddWithValue("@MaKH",
                                    cboKhachHang.SelectedValue == null ? (object)DBNull.Value : cboKhachHang.SelectedValue);
                                cmd.Parameters.AddWithValue("@GhiChu",
                                    string.IsNullOrWhiteSpace(txtGhiChu.Text) ? (object)DBNull.Value : txtGhiChu.Text.Trim());
                                cmd.Parameters.AddWithValue("@ThanhToan", cboThanhToan.Text);
                                cmd.Parameters.AddWithValue("@TienHang", tienHang);
                                cmd.Parameters.AddWithValue("@ThueVAT", nudVAT.Value);
                                cmd.Parameters.AddWithValue("@TienThue", tienThue);
                                cmd.Parameters.AddWithValue("@TongTien", tongTien);
                                cmd.ExecuteNonQuery();
                            }

                            // 2. Lưu từng dòng chi tiết + trừ tồn kho
                            foreach (DataRow r in dtChiTiet.Rows)
                            {
                                string maSach = r["MaSach"].ToString(); int sl = (int)r["SoLuong"];

                                // Trừ kho, chỉ trừ được khi còn đủ hàng
                                using (var cmdTon = new SqlCommand(
                                    "UPDATE Sach SET SoLuongTon = SoLuongTon - @sl WHERE MaSach = @ma AND SoLuongTon >= @sl",
                                    conn, tran))
                                {
                                    cmdTon.Parameters.AddWithValue("@sl", sl);
                                    cmdTon.Parameters.AddWithValue("@ma", maSach);
                                    if (cmdTon.ExecuteNonQuery() == 0)
                                        throw new InvalidOperationException(
                                            "Sách \"" + r["TenSach"] + "\" không đủ tồn kho.");
                                }

                                using (var cmdCT = new SqlCommand(
                                    @"INSERT INTO ChiTietHoaDon (MaHD, MaSach, SoLuong, DonGia, ThanhTien)
                                      VALUES (@MaHD, @MaSach, @SoLuong, @DonGia, @ThanhTien)", conn, tran))
                                {
                                    cmdCT.Parameters.AddWithValue("@MaHD", txtMaHD.Text);
                                    cmdCT.Parameters.AddWithValue("@MaSach", maSach);
                                    cmdCT.Parameters.AddWithValue("@SoLuong", sl);
                                    cmdCT.Parameters.AddWithValue("@DonGia", (decimal)r["DonGia"]);
                                    cmdCT.Parameters.AddWithValue("@ThanhTien", (decimal)r["ThanhTien"]);
                                    cmdCT.ExecuteNonQuery();
                                }
                            }

                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();   // lỗi ở đâu cũng hoàn tác hết
                            throw;
                        }
                    }
                }

                daLuu = true;
                btnLuu.Enabled = false;
                btnIn.Enabled = true;
                MessageBox.Show("Lưu hóa đơn " + txtMaHD.Text + " thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)   // trùng khóa chính
                {
                    txtMaHD.Text = SinhMaHD();
                    MessageBox.Show("Mã hóa đơn bị trùng, đã tạo mã mới (" + txtMaHD.Text + "). Bấm Lưu lại.",
                        "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Lỗi SQL: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lưu được hóa đơn: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (!XacNhanBoHoaDon()) return;
            KhoiTaoHoaDonMoi();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dtChiTiet.Rows.Count == 0) return;

            var pd = new PrintDocument();
            pd.PrintPage += InHoaDon_PrintPage;
            using (var dlg = new PrintPreviewDialog())
            {
                dlg.Document = pd;
                dlg.Width = 900;
                dlg.Height = 700;
                dlg.ShowDialog();
            }
        }

        private void HienThiDonGia()
        {
            if (dangLoad) return;
            var drv = cboSach.SelectedItem as DataRowView;
            donGiaHienTai = drv == null ? 0 : Convert.ToDecimal(drv["GiaBan"]);
            txtDonGia.Text = donGiaHienTai.ToString("N0", vi);
        }
        private void TinhTien()
        {
            tienHang = 0;
            foreach (DataRow r in dtChiTiet.Rows)
                tienHang += (decimal)r["ThanhTien"];
            tienThue = Math.Round(tienHang * nudVAT.Value / 100m, 0, MidpointRounding.AwayFromZero);
            tongTien = tienHang + tienThue;

            txtTienHang.Text = tienHang.ToString("N0", vi) + " đ";
            txtTienThue.Text = tienThue.ToString("N0", vi) + " đ";
            txtTongThanhToan.Text = tongTien.ToString("N0", vi) + " đ";
        }
        private void InHoaDon_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float left = 50;
            float width = e.PageBounds.Width - 100;
            float y = 50;

            using (var fTitle = new Font("Arial", 18, FontStyle.Bold))
            using (var fBold = new Font("Arial", 11, FontStyle.Bold))
            using (var fText = new Font("Arial", 11))
            using (var center = new StringFormat { Alignment = StringAlignment.Center })
            using (var far = new StringFormat { Alignment = StringAlignment.Far })
            using (var cat = new StringFormat { Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap })
            {
                g.DrawString("HÓA ĐƠN BÁN SÁCH", fTitle, Brushes.Black, new RectangleF(left, y, width, 35), center);
                y += 55;

                g.DrawString("Mã hóa đơn: " + txtMaHD.Text, fText, Brushes.Black, left, y);
                g.DrawString("Ngày lập: " + dtpNgayLap.Value.ToString("dd/MM/yyyy"), fText, Brushes.Black, left + width / 2, y);
                y += 24;
                g.DrawString("Nhân viên: " + txtNhanVien.Text, fText, Brushes.Black, left, y);
                g.DrawString("Thanh toán: " + cboThanhToan.Text, fText, Brushes.Black, left + width / 2, y);
                y += 24;
                string khach = string.IsNullOrEmpty(cboKhachHang.Text) ? "Khách lẻ" : cboKhachHang.Text;
                g.DrawString("Khách hàng: " + khach, fText, Brushes.Black, left, y);
                g.DrawString("SĐT: " + txtSDT.Text, fText, Brushes.Black, left + width / 2, y);
                y += 24;
                g.DrawString("Địa chỉ: " + txtDiaChi.Text, fText, Brushes.Black, left, y);
                y += 35;

                float cTen = width * 0.42f, cSL = width * 0.12f, cGia = width * 0.22f, cTT = width * 0.24f;
                float xTen = left, xSL = xTen + cTen, xGia = xSL + cSL, xTT = xGia + cGia;

                g.DrawLine(Pens.Black, left, y, left + width, y);
                y += 4;
                g.DrawString("Tên sách", fBold, Brushes.Black, new RectangleF(xTen, y, cTen, 22), cat);
                g.DrawString("SL", fBold, Brushes.Black, new RectangleF(xSL, y, cSL, 22), center);
                g.DrawString("Đơn giá", fBold, Brushes.Black, new RectangleF(xGia, y, cGia, 22), far);
                g.DrawString("Thành tiền", fBold, Brushes.Black, new RectangleF(xTT, y, cTT, 22), far);
                y += 26;
                g.DrawLine(Pens.Black, left, y, left + width, y);
                y += 6;

                foreach (DataRow r in dtChiTiet.Rows)
                {
                    g.DrawString(r["TenSach"].ToString(), fText, Brushes.Black, new RectangleF(xTen, y, cTen - 5, 22), cat);
                    g.DrawString(r["SoLuong"].ToString(), fText, Brushes.Black, new RectangleF(xSL, y, cSL, 22), center);
                    g.DrawString(((decimal)r["DonGia"]).ToString("N0", vi), fText, Brushes.Black, new RectangleF(xGia, y, cGia, 22), far);
                    g.DrawString(((decimal)r["ThanhTien"]).ToString("N0", vi), fText, Brushes.Black, new RectangleF(xTT, y, cTT, 22), far);
                    y += 24;
                }

                g.DrawLine(Pens.Black, left, y, left + width, y);
                y += 10; g.DrawString("Tiền hàng:", fText, Brushes.Black, new RectangleF(xGia - 60, y, cGia + 60, 22), far);
                g.DrawString(tienHang.ToString("N0", vi) + " đ", fText, Brushes.Black, new RectangleF(xTT, y, cTT, 22), far);
                y += 24;
                g.DrawString("Thuế VAT (" + nudVAT.Value.ToString("0.##") + "%):", fText, Brushes.Black, new RectangleF(xGia - 60, y, cGia + 60, 22), far);
                g.DrawString(tienThue.ToString("N0", vi) + " đ", fText, Brushes.Black, new RectangleF(xTT, y, cTT, 22), far);
                y += 26;
                g.DrawString("TỔNG THANH TOÁN:", fBold, Brushes.Black, new RectangleF(xGia - 100, y, cGia + 100, 22), far);
                g.DrawString(tongTien.ToString("N0", vi) + " đ", fBold, Brushes.Black, new RectangleF(xTT, y, cTT, 22), far);
                y += 40;

                if (!string.IsNullOrWhiteSpace(txtGhiChu.Text))
                    g.DrawString("Ghi chú: " + txtGhiChu.Text, fText, Brushes.Black, left, y);

                y += 50;
                g.DrawString("Cảm ơn quý khách!", fText, Brushes.Black, new RectangleF(left, y, width, 22), center);
            }

            e.HasMorePages = false;
        }

    }
}

