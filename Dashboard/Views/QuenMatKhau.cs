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
    public partial class QuenMatKhau : Form
    {
        private readonly Connect cn;
        public QuenMatKhau()
        {
            InitializeComponent();
            cn = new Connect();
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void DoiMatKhau()
        {
            string sdt, username, pass1, pass2;
            sdt = txtEmail.Text;
            username = txtUsername.Text;
            pass1 = txtPass1.Text;
            pass2 = txtPass2.Text;
            if (pass1.Length < 6 || pass2.Length < 6 || pass1 != pass2)
            {
                lbSuccess.Text = "Mật khẩu không hợp lệ!";
            }
            else
            {
                //check user name

                var data = cn.getDataTable("select * from users where username = '" + username + "' and sdt = '" + sdt + "'");
                if (data.Rows.Count < 1)
                {
                    MessageBox.Show("Thông tin không đúng!", "Thông báo");
                    return;
                }

                string password = HamChung.EncodePassword(pass1);
                cn.ExecuteNonQuery("UPDATE users set passwordHash = '" + password + "' where sdt = '" + sdt + "' and username = '" + username + "'");
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                Login d = new Login();
                d.Show();
                this.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoiMatKhau();
        }
    }
}
