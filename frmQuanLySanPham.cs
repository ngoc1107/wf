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
    public partial class frmQuanLySanPham : Form
    {
        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            XoaTrang();
            txtmasach.Enabled = true;
            cheDo = "";
        }
        classdatabase1 db = new classdatabase1();
        private void Chucnang_Load(object sender, EventArgs e)
        {
            dgvsach.DataSource = db.LayDuLieu("SELECT * from Sach");
        }

        string cheDo = "";
        void LoadBang()
        {
            dgvsach.DataSource = db.LayDuLieu("SELECT * FROM Sach");
           
        }

        void XoaTrang()
        {
            txtmasach.Text = "";
            txttensach.Text = "";
            txttacgia.Text = "";
            txttheloai.Text = "";
            txtNXB.Text = "";
            numnamxuatban.Value = 2020;
            numgianhap.Value = 0;
            numgiaban.Value = 0;
            numton.Value = 0;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            cheDo = "them";
            XoaTrang();
            txtmasach.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text == "")
            {
                MessageBox.Show("Hãy bấm chọn 1 dòng trong bảng trước!");
                return;
            }
            cheDo = "sua";
            txtmasach.Enabled = false;   // không cho sửa mã sách
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text == "")
            {
                MessageBox.Show("Hãy bấm chọn 1 dòng trong bảng trước!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.ThucThi("DELETE FROM Sach WHERE MaSach = N'" + txtmasach.Text + "'");
                LoadBang();
                XoaTrang();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (cheDo == "")
            {
                MessageBox.Show("Hãy bấm Thêm hoặc Sửa trước!");
                return;
            }

            if (cheDo == "them")
            {
                string sql = "INSERT INTO Sach VALUES (N'" + txtmasach.Text + "', N'" + txttensach.Text + "', N'" + txttacgia.Text + "', N'" + txttheloai.Text + "', N'" + txtNXB.Text + "', " + numnamxuatban.Value + ", " + numgianhap.Value + ", " + numgiaban.Value + ", " + numton.Value + ")";
                db.ThucThi(sql);
            }
            else if (cheDo == "sua")
            {
                string sql = "UPDATE Sach SET TenSach = N'" + txttensach.Text + "', TacGia = N'" + txttacgia.Text + "', TheLoai = N'" + txttheloai.Text + "', NhaXuatBan = N'" + txtNXB.Text + "', NamXuatBan = " + numnamxuatban.Value + ", GiaNhap = " + numgianhap.Value + ", GiaBan = " + numgiaban.Value + ", SoLuongTon = " + numton.Value + " WHERE MaSach = N'" + txtmasach.Text + "'";
                db.ThucThi(sql);
            }

            LoadBang();
            XoaTrang();
            txtmasach.Enabled = true;
            cheDo = "";
            MessageBox.Show("Đã lưu!");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
