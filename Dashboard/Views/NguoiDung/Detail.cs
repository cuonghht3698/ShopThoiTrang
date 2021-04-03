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

namespace Dashboard.Views.NguoiDung
{
    public partial class Detail : Form
    {
        private readonly Connect cn;
        private int Id = 0;
        public Detail(int id)
        {
            InitializeComponent();
            cn = new Connect();
            Id = id;
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            cbSize.SelectedIndex = 0;
            GetSanPham();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        public void GetSanPham()
        {
            var data = cn.getDataTable("select s.id,s.ten,s.dongia,s.anh,s.mota,l.ten from sanpham s left join loaisanpham l on s.LoaiSanPhamId = l.id where s.id = " + Id);
            lbGia.Text = data.Rows[0][2].ToString() + " Đồng";
            lbTenSP.Text = data.Rows[0][1].ToString();
            lbLoaiSP.Text = data.Rows[0][5].ToString();
            lbChiTiet.Text = data.Rows[0][4].ToString();
            picAnh.Image = HamChung.GetImageFromString(data.Rows[0][3].ToString());


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (panel1.Width < 700)
            {
                panel1.Width += 10;
                panel2.Width += 10;

            }
            else
                timer1.Stop();

        }
    }
}
