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
    public partial class frmdangnhap : Form
    {

        public frmdangnhap()
        {
            InitializeComponent();
        }
        classdatabase1 db = new classdatabase1();


        string Q(string s) { return s.Trim().Replace("'", "''"); }


        private void frmdangnhap_Load(object sender, EventArgs e)
        {
            txtmk.UseSystemPasswordChar = true;
            chkhienmk.Checked = false;
        }

        private void chkhienmk_CheckedChanged(object sender, EventArgs e)
        {
            txtmk.UseSystemPasswordChar = !chkhienmk.Checked;
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (txtten.Text.Trim() == "")
            {
                MessageBox.Show("Nhập tên đăng nhập!");
                txtten.Focus();
                return;
            }
            if (txtmk.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu!");
                txtmk.Focus();
                return;
            }

            DataTable dt = db.LayDuLieu(
                "SELECT * FROM NguoiDung WHERE TenDN = N'" + Q(txtten.Text) +
                "' AND MatKhau = N'" + Q(txtmk.Text) + "'");

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Đăng nhập thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmk.Clear();
                txtmk.Focus();
                return;
            }

            if (dt.Rows[0]["TrangThai"].ToString() == "Đã khóa")
            {
                MessageBox.Show("Tài khoản đã bị khóa, liên hệ quản trị viên!");
                return;
            }

            Chucnang f = new Chucnang();
            this.Hide();
            f.ShowDialog();

            txtmk.Clear();
            this.Show();
            txtten.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
