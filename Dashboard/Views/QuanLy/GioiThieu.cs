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
    public partial class GioiThieu : Form
    {
        private readonly Connect cn;
        public GioiThieu()
        {
            InitializeComponent();
            cn = new Connect();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void getBaoCao()
        {
            var data = cn.getDataTable("EXEC bao_cao '20210101'");
            lbSLNgay.Text = data.Rows[0][0].ToString();
            lbSLTuan.Text = data.Rows[0][2].ToString();
            lbSLThang.Text = data.Rows[0][4].ToString();
            lbSLQuy.Text = data.Rows[0][6].ToString();
            lbSLNam.Text = data.Rows[0][8].ToString();

            lbTongNgay.Text = data.Rows[0][1].ToString() + " đồng";
            lbTongTuan.Text = data.Rows[0][3].ToString() + " đồng";
            lbTongThang.Text = data.Rows[0][5].ToString() + " đồng";
            lbTongQuy.Text = data.Rows[0][7].ToString() + " đồng";
            lbTongNam.Text = data.Rows[0][9].ToString() + " đồng";
            label5.Text = data.Rows[0][9].ToString() + " Đồng";
            //String.Format("{0:#,##0.##}", giaKm) + " đ";




        }

        private void GioiThieu_Load(object sender, EventArgs e)
        {
            getBaoCao();
        }
    }
}
