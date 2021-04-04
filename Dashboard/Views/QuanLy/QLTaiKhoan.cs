using Dashboard.Buniss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard.Views.QuanLy
{
    public partial class QLTaiKhoan : Form
    {
        private Connect cn;
        private string sSearch;
        private string sRole;
        private bool sTrangThai;
        public QLTaiKhoan()
        {
            InitializeComponent();
            cn = new Connect();
        }

        private void lbThongBao_Click(object sender, EventArgs e)
        {

        }

        private void QLTaiKhoan_Load(object sender, EventArgs e)
        {
            cbQuyen.Items.Add(Role.admin);
            cbQuyen.Items.Add(Role.quanlykho);
            cbQuyen.Items.Add(Role.nhanvien);
            cbQuyen.Items.Add(Role.khachhang);
            cbQuyen.SelectedIndex = 0;
            cbGioiTinh.SelectedIndex = 0;

            cbSearchChucVu.Items.Add("-- Lọc theo quyền");
            cbSearchChucVu.Items.Add(Role.admin);
            cbSearchChucVu.Items.Add(Role.quanlykho);
            cbSearchChucVu.Items.Add(Role.nhanvien);
            cbSearchChucVu.Items.Add(Role.khachhang);
            cbSearchChucVu.SelectedIndex = 0;
            cbTrangThai.SelectedIndex = 0;
            sTrangThai = true;
            checkActive.Checked = true;
            getDataNhanVien();
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }
        private void getDataNhanVien()
        {
            
            DataTable tb = cn.getDataTable("select id,ten,ngaysinh,sdt,gioitinh,quequan,username,active,quyen from users where id !=" 
                + ThongTin.idUser + " and active = '" + sTrangThai + "' and ('"+sRole+"' = '' or quyen = N'"+ sRole + "')");
            dataGridView1.DataSource = tb;
        }
        private void updateNhanVien()
        {
            string ten, sdt, quequan, username, quyen;
            int id;
            bool gioitinh, active;
            DateTime ngaysinh;
            id = int.Parse(txtMa.Text);
            ten = txtTen.Text;
            sdt = txtSdt.Text;
            quequan = txtQueQuan.Text;
            username = txtUsername.Text;
            quyen = cbQuyen.SelectedIndex != 0 ? cbQuyen.SelectedItem.ToString() : "";
            gioitinh = HamChung.NamNuToTrueFalse(cbGioiTinh.SelectedItem.ToString());
            active = checkActive.Checked;
            ngaysinh = dateTimePicker1.Value;
            string sql = "update users set ten = N'" + ten + "',ngaysinh = '" + ngaysinh + "',sdt = '" + sdt + "',gioitinh = '" + gioitinh + "'" +
                ",quequan = N'" + quequan + "',username = '" + username + "',active = '" + active + "',quyen =N'" + quyen + "' where id = " + id;
            try
            {
                cn.ExecuteNonQuery(sql);
                getDataNhanVien();
            }
            catch (Exception)
            {

                MessageBox.Show("Kiểm tra lại thông tin", "Thông báo!");
            }
        }

        private void Create()
        {
            string ten, sdt, quequan, username, quyen, password;
            int id;
            bool gioitinh, active;
            DateTime ngaysinh;
            ten = txtTen.Text;
            sdt = txtSdt.Text;
            quequan = txtQueQuan.Text;
            username = txtUsername.Text;
            quyen = cbQuyen.SelectedIndex != 0 ? cbQuyen.SelectedItem.ToString() : "";
            gioitinh = HamChung.NamNuToTrueFalse(cbGioiTinh.SelectedItem.ToString());
            active = checkActive.Checked;
            ngaysinh = dateTimePicker1.Value;
            password = HamChung.EncodePassword(txtPassword.Text);
            //NHAN VIEN
            if (!CheckUsername("users", username))
            {
                MessageBox.Show("Tài khoản đã tồn tại trong hệ thống!", "Thông báo!");
            }
            else
            {
                string sql = "Insert into users (ten,ngaysinh,sdt,gioitinh,quequan,username,passwordHash,active,quyen) values(N'" + ten +
                  "','" + ngaysinh + "','" + sdt + "','" + gioitinh + "',N'" + quequan + "','" + username + "','" + password + "','" + active + "',N'" + quyen + "')";
                cn.ExecuteNonQuery(sql);
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo");
            }
        }
        private bool CheckUsername(string table, string username)
        {
            string sql = "select * from " + table + " where username = '" + username + "'";
            var tb = cn.getDataTable(sql);
            if (tb.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            getDataNhanVien();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Create();
            getDataNhanVien();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkActive.Text = checkActive.Checked == true ? "Hoạt động" : "Khóa";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                var confirmResult = MessageBox.Show("Bạn có muốn xóa ??",
                                     "Cảnh báo!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());

                }

            }
            else if (e.RowIndex != -1)
            {
                txtMa.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                txtSdt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cbGioiTinh.SelectedItem = HamChung.TrueFalseToNamNu(Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()));
                txtQueQuan.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                //txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

                checkActive.Checked = Boolean.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
                cbQuyen.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void cbSearchChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            sRole = cbSearchChucVu.SelectedIndex == 0 ? "" : cbSearchChucVu.SelectedItem.ToString();
            getDataNhanVien();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            updateNhanVien();
            getDataNhanVien();
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            sTrangThai = cbTrangThai.SelectedIndex == 0 ? true : false;
            getDataNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }
    }
}
