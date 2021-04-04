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

namespace Dashboard.Views.QuanLy
{
    public partial class QLDonHang : Form
    {
        private readonly Connect cn;
        private string trangthai = "";
        private bool isKhachHang;
        public QLDonHang()
        {
            InitializeComponent();
            cn = new Connect();
            isKhachHang = false;

        }
        public QLDonHang(bool IsKhachHang)
        {
            InitializeComponent();
            cn = new Connect();
            isKhachHang = true;
            panel4.Visible = false;

        }
        private void QLDonHang_Load(object sender, EventArgs e)
        {
            cbSearchTT.Items.Add("Lọc trạng thái");
            cbSearchTT.Items.Add(TrangThai.ChoDuyet);
            cbSearchTT.Items.Add(TrangThai.GiaoHang);
            cbSearchTT.Items.Add(TrangThai.HoanThanh);
            cbSearchTT.SelectedIndex = 0;
            trangthai = "";
            if (isKhachHang)
            {
                GetHoaDonKH();
            }
            else
                GetHoaDon();

            panel1.Visible = false;
        }

        private void GetHoaDon()
        {
            string sql = "select row_number() over(order by h.trangthai) as 'STT', h.id as 'Mã', u.ten as 'Tên KH'," +
                " h.ngaygiaohang as 'Ngày GH', u.sdt as 'SDT',h.trangthai as 'Trạng thái', h.ghichu as 'Ghi chú', h.tongtien as 'Tổng tiền' " +
                " from hoadon h join users u on h.khachhangid = u.id where ('" + trangthai + "' = '' or h.trangthai = N'" + trangthai + "')";
            var data = cn.getDataTable(sql);
            if (data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 50;
            }
        }
        private void GetHoaDonKH()
        {
            string sql = "select row_number() over(order by h.trangthai) as 'STT', h.id as 'Mã', u.ten as 'Tên KH'," +
                " h.ngaygiaohang as 'Ngày GH', u.sdt as 'SDT',h.trangthai as 'Trạng thái', h.ghichu as 'Ghi chú', h.tongtien as 'Tổng tiền' " +
                " from hoadon h join users u on h.khachhangid = u.id where h.khachhangId = " + ThongTin.idUser + " and ('" + trangthai + "' = '' or h.trangthai = N'" + trangthai + "')";
            var data = cn.getDataTable(sql);
            if (data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 50;
            }
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

        private void btnChiTiet_Click_1(object sender, EventArgs e)
        {

        }
        Panel p = new Panel();
        private void btnChiTiet_Click_2(object sender, EventArgs e)
        {
            p = panel3;
            panel1.Visible = true;
            panel3.Visible = false;
            openChildForm(new DonHang(Int32.Parse(txtMaHD.Text)));
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(p);
            panel1.Visible = false;
        }

        private void XacNhan()
        {
            try
            {
                int id = Int32.Parse(txtMaHD.Text);
                cn.ExecuteNonQuery("UPDATE HOADON SET nhanvienId = " + ThongTin.idUser + ", ngaygiaohang = '" + pickNgayGiao.Value.ToString() + "',trangthai = N'" + TrangThai.GiaoHang + "' where id =" + id);
                GetHoaDon();
                MessageBox.Show("Thao tác thành công");

            }
            catch (Exception)
            {

                MessageBox.Show("Thao tác không thành công");
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            XacNhan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtMaHD.Text);
                cn.ExecuteNonQuery("UPDATE HOADON SET nhanvienId = " + ThongTin.idUser + ", ngayhoanthanh = '" + DateTime.Now.ToString() + "',trangthai = N'" + TrangThai.HoanThanh + "' where id =" + id);
                GetHoaDon();
                MessageBox.Show("Đã hoàn thành đơn thành công");

            }
            catch (Exception)
            {

                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void cbSearchTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearchTT.SelectedIndex != 0)
            {
                trangthai = cbSearchTT.SelectedItem.ToString();
            }
            else
            {
                trangthai = "";
            }
            GetHoaDon();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtMaHD.Text);
                cn.ExecuteNonQuery("UPDATE HOADON SET nhanvienId = " + ThongTin.idUser + ",trangthai = N'" + TrangThai.DaHuy + "' where id =" + id);
                GetHoaDon();
                MessageBox.Show("Hủy đơn thành công");

            }
            catch (Exception)
            {

                MessageBox.Show("Thao tác không thành công");
            }
        }
    }
}
