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

namespace Dashboard.Views
{
    public partial class DangKy : Form
    {
        private bool CheckAdmin;
        private Connect cn;
        public DangKy()
        {
            InitializeComponent();
            cn = new Connect();
            lbQuyen.Visible = false;
            cbQuyen.Visible = false;
        }
        public DangKy(bool admin)
        {
            InitializeComponent();
            lbQuyen.Visible = true;
            cbQuyen.Visible = true;
            cn = new Connect();
        }
        private void DangKy_Load(object sender, EventArgs e)
        {

            cbQuyen.Items.Add(Role.admin);
            cbQuyen.Items.Add(Role.quanlykho);
            cbQuyen.Items.Add(Role.nhanvien);
            cbQuyen.Items.Add(Role.khachhang);
            cbQuyen.SelectedIndex = 3;
            cbGioiTinh.SelectedIndex = 0;
            datePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Create();
        }

        private void Create()
        {
            string ten, ngaysinh, sdt, quequan, username, password, quyen;
            bool active = true;
            bool gioitinh;
            ten = txtTen.Text;
            ngaysinh = datePicker.Value.ToString();
            gioitinh = cbGioiTinh.SelectedItem.ToString() == "Nam" ? true : false;
            sdt = txtPhone.Text;
            quequan = txtDiaChi.Text;
            username = txtUser.Text;
            password = HamChung.EncodePassword(txtPassword.Text);
            quyen = cbQuyen.SelectedItem.ToString();
            //NHAN VIEN
            if (!CheckUsername("users", username))
            {
                MessageBox.Show("Tài khoản đã tồn tại trong hệ thống!", "Thông báo!");
            }
            else
            {
                string sql = "Insert into users (ten,ngaysinh,sdt,gioitinh,quequan,username,passwordHash,active,quyen) values('" + ten +
                  "','" + ngaysinh + "','" + sdt + "','" + gioitinh + "','" + quequan + "','" + username + "','" + password + "','" + active + "','" + quyen + "')";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Create();
        }
    }
}
