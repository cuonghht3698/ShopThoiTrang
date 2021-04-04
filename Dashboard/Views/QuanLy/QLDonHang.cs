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
    public partial class QLDonHang : Form
    {
        private readonly Connect cn;
        public QLDonHang()
        {
            InitializeComponent();
            cn = new Connect();
        }

        private void QLDonHang_Load(object sender, EventArgs e)
        {
            GetHoaDon();
        }

        private void GetHoaDon()
        {
            string sql = "select row_number() over(order by h.ngaydat desc) as 'STT', h.id as 'Mã', u.ten as 'Tên KH'," +
                " h.ngaydat as 'Ngày đặt', u.sdt as 'SDT',h.trangthai as 'Trạng thái', h.ghichu as 'Ghi chú', h.tongtien as 'Tổng tiền' " +
                " from hoadon h join users u on h.khachhangid = u.id";
            var data = cn.getDataTable(sql);
            dataGridView1.DataSource = data;
        }
    }
}
