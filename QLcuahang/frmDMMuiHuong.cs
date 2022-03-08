using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLcuahang.Class;
namespace QLcuahang
{
    public partial class frmDMMuiHuong : Form
    {
        DataTable tblcl;
        public frmDMMuiHuong()
        {
            InitializeComponent();
        }

        private void frmDMMuiHuong_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT MaMuiHuong, TenMuiHuong FROM tblMuiHuong";
            tblcl = Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvMuiHuong.DataSource = tblcl; //Nguồn dữ liệu            
            dgvMuiHuong.Columns[0].HeaderText = "Mã Mùi Hương";
            dgvMuiHuong.Columns[1].HeaderText = "Tên Mùi Hương";
            dgvMuiHuong.Columns[0].Width = 100;
            dgvMuiHuong.Columns[1].Width = 300;
            dgvMuiHuong.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvMuiHuong.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
            this.dgvMuiHuong.DefaultCellStyle.ForeColor = Color.White;
            this.dgvMuiHuong.DefaultCellStyle.BackColor = Color.Black;
        }

        private void dgvMuiHuong_Click (object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMuiHuong.Focus();
                return;
            }
            if (tblcl.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaMuiHuong.Text = dgvMuiHuong.CurrentRow.Cells["MaMuiHuong"].Value.ToString();
            txtTenMuiHuong.Text = dgvMuiHuong.CurrentRow.Cells["TenMuiHuong"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMaMuiHuong.Enabled = true; //cho phép nhập mới
            txtMaMuiHuong.Focus();
        }

        private void ResetValue()
        {
            txtMaMuiHuong.Text = "";
            txtTenMuiHuong.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtMaMuiHuong.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMuiHuong.Focus();
                return;
            }
            if (txtTenMuiHuong.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenMuiHuong.Focus();
                return;
            }
            sql = "Select MaMuiHuong From tblMuiHuong where MaMuiHuong=N'" + txtMaMuiHuong.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMuiHuong.Focus();
                return;
            }

            sql = "INSERT INTO tblMuiHuong VALUES(N'" +
                txtMaMuiHuong.Text + "',N'" + txtTenMuiHuong.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaMuiHuong.Enabled = false;
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblcl.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaMuiHuong.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblMuiHuong WHERE MaMuiHuong=N'" + txtMaMuiHuong.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblcl.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaMuiHuong.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenMuiHuong.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblMuiHuong SET TenMuiHuong=N'" +txtTenMuiHuong.Text.ToString() +"' WHERE MaMuiHuong=N'" + txtMaMuiHuong.Text + "'";
           
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnBoqua.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaMuiHuong.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
