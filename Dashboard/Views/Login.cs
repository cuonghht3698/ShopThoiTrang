using Dashboard.Buniss;
using Dashboard.Views.NguoiDung;
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
    public partial class Login : Form
    {
        private Connect cn;
        public Login()
        {
            InitializeComponent();
            cn = new Connect();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginAdmin()
        {

            DataTable read = cn.getDataTable("SELECT * FROM users WHERE username = '" + txtUser.Text +
                "' and passwordHash = '" + HamChung.EncodePassword(txtPassword.Text) + "' and active = 'true'");
            if (read.Rows.Count > 0)
            {
                ThongTin.idUser = int.Parse(read.Rows[0][0].ToString());
                ThongTin.ten = read.Rows[0][1].ToString();
                ThongTin.ngaysinh = read.Rows[0][2].ToString();
                ThongTin.sdt = read.Rows[0][3].ToString();
                ThongTin.quequan = read.Rows[0][5].ToString();
                ThongTin.username = read.Rows[0][6].ToString();
                ThongTin.quyen = read.Rows[0][9].ToString();
                if (ThongTin.quyen != Role.khachhang)
                {
                    this.Hide();
                    Main fMain = new Main();
                    fMain.ShowDialog();
                }
                else
                {
                    this.Hide();
                    FormMain ff = new FormMain();
                    ff.ShowDialog();
                }
                this.Hide();
                

            }
            else
            {
                lbLoginFailed.Text = "Tài khoản hoặc mật khẩu không đúng !";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            LoginAdmin();
        }

        private void LinkTaoTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUser.Text = "admin";
            txtPassword.Text = "admin";
            LoginAdmin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUser.Text = "phat";
            txtPassword.Text = "phat";
            LoginAdmin();
        }
    }
}
