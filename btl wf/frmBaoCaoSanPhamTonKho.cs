using btl_wf;
using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmBaoCaoSanPhamTonKho : Form
    {
        classdatabase1 db = new classdatabase1();
        public frmBaoCaoSanPhamTonKho()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSanPhamTonKho_Load(object sender, EventArgs e)
        {
            string sql = @"
                SELECT
                    s.MaSach,
                    s.TenSach,
                    dm.TenDM,
                    ISNULL(nhap.TongNhap, 0)
                    - ISNULL(xuat.TongXuat, 0) AS SoLuongTonKho
                FROM Sach s
                LEFT JOIN DanhMuc dm
                    ON s.MaDM = dm.MaDM
                LEFT JOIN
                (
                    SELECT MaSach, SUM(SoLuong) AS TongNhap
                    FROM ChiTietHoaDon
                    GROUP BY MaSach
                ) nhap ON s.MaSach = nhap.MaSach
                LEFT JOIN
                (
                    SELECT MaSach, SUM(SoLuong) AS TongXuat
                    FROM ChiTietHoaDonXuat
                    GROUP BY MaSach
                ) xuat ON s.MaSach = xuat.MaSach
                ORDER BY s.MaSach";

            DataTable dt = db.LayDuLieu(sql);

            rptBaoCaoTonKho rpt = new rptBaoCaoTonKho();

            rpt.SetDataSource(dt);

            crystalReportViewer1.ReportSource = rpt;

            crystalReportViewer1.Refresh();
        }
    }
}
