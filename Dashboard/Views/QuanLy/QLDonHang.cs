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
                " h.ngaygiaohang as 'Ngày GH', u.sdt as 'SDT',h.trangthai as 'Trạng thái', h.ghichu as 'Ghi chú', h.tongtien as 'Tổng tiền' " +
                " from hoadon h join users u on h.khachhangid = u.id";
            var data = cn.getDataTable(sql);
            dataGridView1.DataSource = data;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 50;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtMaHD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTen.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string NgayGiao = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSdt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTrangThai.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtMoTa.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTong.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                if (String.IsNullOrEmpty(NgayGiao))
                {
                    pickNgayGiao.Visible = false;
                }
                else
                {
                    pickNgayGiao.Visible = true;
                    pickNgayGiao.Value = DateTime.Parse(NgayGiao);
                }
                btnChiTiet.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pickNgayGiao.Visible = !pickNgayGiao.Visible;
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }
    }
}
