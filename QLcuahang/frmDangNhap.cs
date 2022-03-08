using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLcuahang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "1111";
            if (user.Equals(txtDangNhap.Text) && pass.Equals(txtMatKhau.Text))
            {
                
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng, vui lòng nhập lại");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
