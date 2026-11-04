using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl_wf
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();

        }
        public static class PhienDangNhap
        {
            public static bool DaDangNhap { get; set; } = false;
            public static string TenDangNhap { get; set; } = "";

            public static void DangXuat()
            {
                DaDangNhap = false;
                TenDangNhap = "";
            }
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chứcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doanhThuTheoNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void fmtrangchu_Load(object sender, EventArgs e)
        {
            // ----- Menu Hệ thống -----
            mnuCauHinh.Click += (s, ev) => new frmQuanLyCauHinh().ShowDialog();
            mnuNguoiDung.Click += (s, ev) => new frmquanlynguoidung().ShowDialog();
            mnuDoiMK.Click += (s, ev) => new frmdoimk().ShowDialog();

            mnuDangNhap.Click += (s, ev) =>
            {
                if (PhienDangNhap.DaDangNhap)
                {
                    // Đang đăng nhập rồi thì bấm vào = đăng xuất
                    if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PhienDangNhap.DangXuat();
                        CapNhatTrangThaiMenu();
                    }
                }
                else
                {
                    MoFormDangNhap();
                }
            };

            this.FormClosing += fmtrangchu_FormClosing;

            // Mới vào: khóa hết, rồi bắt đăng nhập luôn
            CapNhatTrangThaiMenu();
            MoFormDangNhap();
        }
        private void MoFormDangNhap()
        {
            using (var f = new frmdangnhap())
            {
                if (f.ShowDialog() == DialogResult.OK)
                    CapNhatTrangThaiMenu();
            }
        }

        // Khóa / mở khóa chức năng theo trạng thái đăng nhập
        private void CapNhatTrangThaiMenu()
        {
            bool dn = PhienDangNhap.DaDangNhap;

            // Các menu cấp 1 (Báo cáo, Hóa đơn, Nhân viên, ...) -> chỉ mở khi đã đăng nhập
            foreach (ToolStripItem item in menuStrip1.Items)
                item.Enabled = dn;

            // Riêng menu Hệ thống luôn bật, nhưng bên trong chỉ cho Đăng nhập + Thoát
            Hethong.Enabled = true;
            foreach (ToolStripItem con in Hethong.DropDownItems)
            {
                bool luonChoPhep = (con == mnuDangNhap || con == thoátToolStripMenuItem);
                con.Enabled = dn || luonChoPhep;
            }

            // Toolbar
            toolStrip1.Enabled = dn;

            // Đổi chữ nút đăng nhập/đăng xuất cho dễ hiểu
            mnuDangNhap.Text = dn ? "Đăng xuất" : "Đăng nhập";
            this.Text = dn ? "Trang chủ - " + PhienDangNhap.TenDangNhap : "Trang chủ";
        }
        // Bấm Thoát, Alt+F4 hoặc dấu X đều hiện hộp xác nhận này
        private void fmtrangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing) return;

            DialogResult kq = MessageBox.Show(
                "Bạn có muốn thoát chương trình không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (kq == DialogResult.Yes)
                Application.Exit();
            else
                e.Cancel = true;
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnlChaoMung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblKhauHieu_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
