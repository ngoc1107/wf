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
    public partial class frmBaoCaoSanPhamBanChay : Form
    {
        classdatabase1 db = new classdatabase1();
        public frmBaoCaoSanPhamBanChay()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSanPhamBanChay_Load(object sender, EventArgs e)
        {
            
            try
            {
                string sql = @"
            SELECT
                s.MaSach,
                s.TenSach,
                s.MaDM,
                SUM(ct.SoLuong) AS TongSoLuongBan
            FROM Sach s
            INNER JOIN ChiTietHoaDonXuat ct
                ON s.MaSach = ct.MaSach
            INNER JOIN HoaDonXuat hd
                ON ct.MaHDX = hd.MaHDX
            GROUP BY
                s.MaSach,
                s.TenSach,
                s.MaDM
            ORDER BY
                TongSoLuongBan DESC";

                DataTable dt = db.LayDuLieu(sql);

                crpSPbanchay rpt = new crpSPbanchay();

                rpt.SetDataSource(dt);

                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị báo cáo: " + ex.Message);
            }
        
    }
    }
}
