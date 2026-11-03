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
    public partial class frmtrangchu : Form
    {
        public frmtrangchu()
        {
            InitializeComponent();

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
            mnuCauHinh.Click += (s, ev) => new Form1().ShowDialog();
            mnuNguoiDung.Click += (s, ev) => new frmquanlynguoidung().ShowDialog();
            mnuDangNhap.Click += (s, ev) => new frmdangnhap().ShowDialog();
            mnuDoiMK.Click += (s, ev) => new frmdoimk().ShowDialog();

            this.FormClosing += fmtrangchu_FormClosing;
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
    }
}
