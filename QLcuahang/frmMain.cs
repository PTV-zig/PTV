using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLcuahang.Class;
namespace QLcuahang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();

        }



        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanvien frm = new frmDMNhanvien(); //Khởi tạo đối tượng
            frm.MdiParent = this; //Hiển thị
            frm.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang(); //Khởi tạo đối tượng
            frm.MdiParent = this; //Hiển thị
            frm.Show();
        }

        private void btnMuiHuong_Click(object sender, EventArgs e)
        {
            frmDMMuiHuong frm = new frmDMMuiHuong(); //Khởi tạo đối tượng
            frm.MdiParent = this; //Hiển thị
            frm.Show();
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            frmDMHang frm = new frmDMHang(); //Khởi tạo đối tượng
            frm.MdiParent = this; //Hiển thị
            frm.Show();
        }

        private void btnHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan(); //Khởi tạo đối tượng
            frm.MdiParent = this; //Hiển thị
            frm.Show();
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            frmGioiThieu frm = new frmGioiThieu(); //Khởi tạo đối tượng
            frm.MdiParent = this; //Hiển thị
            frm.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimHDBan frm = new frmTimHDBan(); //Khởi tạo đối tượng
            frm.MdiParent = this; //Hiển thị
            frm.Show();
        }

        
    }
}
