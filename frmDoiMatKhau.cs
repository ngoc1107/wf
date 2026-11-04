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
    public partial class frmdoimk : Form
    {
        public frmdoimk()
        {
            InitializeComponent();
        }
        classdatabase1 db = new classdatabase1();
        public static string TenDNHienTai = "";
        string Q(string s)
        {
            return s.Replace("'", "''");
        }

        private void frmdoimk_Load(object sender, EventArgs e)
        {
            txtmkhientai.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool an = !checkBox1.Checked;
            txtmkhientai.UseSystemPasswordChar = an;
            txtmkmoi.UseSystemPasswordChar = an;
            txtnhaplai.UseSystemPasswordChar = an;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" tên đăng nhập = [" + txtten.Text + "]");

            if (txtmkmoi.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải từ 6 ký tự!");
                return;
            }
            if (txtmkmoi.Text != txtnhaplai.Text)
            {
                MessageBox.Show("Nhập lại không khớp!");
                return;
            }

            DataTable dt = db.LayDuLieu(
                "SELECT * FROM NguoiDung WHERE TenDN = N'" + txtten.Text.Trim() +
                "' AND MatKhau = N'" + txtmkhientai.Text + "'");
            MessageBox.Show("tìm thấy " + dt.Rows.Count + " dòng khớp");

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!");
                return;
            }

            db.ThucThi("UPDATE NguoiDung SET MatKhau = N'" + txtmkmoi.Text +
                       "' WHERE TenDN = N'" + txtten.Text.Trim() + "'");
            MessageBox.Show(" đã ghi xong");
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
