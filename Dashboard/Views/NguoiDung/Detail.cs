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
        private int IdHoaDon = 0;
        private int giaban = 0;

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
            CheckHoaDon();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThemGioHang();
        }

        public void GetSanPham()
        {
            var data = cn.getDataTable("select s.id,s.ten,s.dongia,s.anh,s.mota,l.ten from sanpham s left join loaisanpham l on s.LoaiSanPhamId = l.id where s.id = " + Id);
            lbGia.Text = data.Rows[0][2].ToString() + " Đồng";
            giaban = Int32.Parse(data.Rows[0][2].ToString());
            lbTenSP.Text = data.Rows[0][1].ToString();
            lbLoaiSP.Text = data.Rows[0][5].ToString();
            lbChiTiet.Text = data.Rows[0][4].ToString();
            picAnh.Image = HamChung.GetImageFromString(data.Rows[0][3].ToString());


        }
        private void CheckHoaDon()
        {
            var data = cn.getDataTable("select top 1 id from hoadon where khachhangId =" + ThongTin.idUser + " and trangthai =N'" + TrangThai.TaoPhieu + "'");
            if (data.Rows.Count > 0)
            {
                IdHoaDon = Int32.Parse(data.Rows[0][0].ToString());
            }
            else
            {
                // khong co hoa dong nao
                cn.ExecuteNonQuery("insert into hoadon (khachhangId, nhanvienId,ngaydat,ngaygiaohang,noigiaohang,sdt,trangthai,ngayhoanthanh,ghichu,tongtien) values("
                    + ThongTin.idUser + ",NULL,NULL,NULL,'','',N'" + TrangThai.TaoPhieu + "',NULL,'',0)");
                CheckHoaDon();
            }
        }

        private void ThemGioHang()
        {
            try
            {
                int soluong = Int32.Parse(txtSoLuong.Text);
                cn.ExecuteNonQuery("insert into chitiethoadon (hoadonId,sanphamId,dongia,soluong,size) values(" 
                    + IdHoaDon + "," + Id + "," + giaban + "," + soluong + ",'" + cbSize.SelectedItem.ToString()+"')");
                MessageBox.Show("Thêm vào giỏ hàng thành công!", "Thông báo!");
            }
            catch (Exception)
            {

                
            }
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

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
