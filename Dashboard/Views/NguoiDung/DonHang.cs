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
    public partial class DonHang : Form
    {
        private readonly Connect cn;
        private int thanhtien = 0;
        private int IdHoaDong;
        private DataTable dataHoaDon;
        private int FindId = 0;
        private string TrangThaiHD;
        private string emailKh = "";
        private string noidungEmail = "";
        public DonHang()
        {
            InitializeComponent();
            cn = new Connect();
            //btnHuy.Visible = false;
            //btnTiepNhan.Visible = false;
        }
        public DonHang(int v)
        {
            InitializeComponent();
            cn = new Connect();
            FindId = v;
            btnDatHang.Visible = false;
            //btnMuaThem.Visible = false;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            //btnTiepNhan.Visible = true;
            txtGhiChu.ReadOnly = true;

        }

        private void DonHang_Load(object sender, EventArgs e)
        {
            getGioHang();
            txtDiaChi.Text = ThongTin.quequan;
            txtSDT.Text = ThongTin.sdt;
            if (ThongTin.quyen == "Khachhang" || ThongTin.quyen == "khachhang")
            {
                //btnTiepNhan.Visible = false;
                btnHuy.Text = "Huỷ đơn hàng";

            }
        }
        private DataTable TruyVan()
        {
            string trang = "";
            if (FindId == 0)
            {
                trang = TrangThai.TaoPhieu;
            }

            return cn.getDataTable("select s.ten,ct.dongia,ct.soluong,s.anh,ct.id,(ct.soluong * ct.dongia) as 'ThanhTien', h.id,h.trangthai,h.ghichu,u.email,ct.size from HoaDon h join users u on u.Id = h.khachhangId join ChiTietHoaDon ct on h.id = ct.hoadonId join  SanPham s on ct.sanphamId = s.id " +
                " where (" + FindId + " != 0 or h.khachhangId = " + ThongTin.idUser + ") and ('" + trang + "' = '' or h.trangthai = N'" + trang + "') and (" + FindId + " = 0 or h.id = " + FindId + ")");
        }
        private void getGioHang()
        {
            dataHoaDon = TruyVan();
            if (dataHoaDon.Rows.Count > 0)
            {
                panelEmpty.Visible = false;
                lbTrangThaiHD.Text = dataHoaDon.Rows[0][7].ToString();
                txtGhiChu.Text = dataHoaDon.Rows[0][8].ToString();
                emailKh = dataHoaDon.Rows[0][9].ToString();
                if (lbTrangThaiHD.Text == "Hủy")
                {
                    btnHuy.Visible = false;
                }
                IdHoaDong = Int32.Parse(dataHoaDon.Rows[0][6].ToString());
                panelParent.Controls.Clear();
                noidungEmail = "Đơn hàng của bạn đã được đặt hàng thành công <br />";
                foreach (DataRow item in dataHoaDon.Rows)
                {
                    thanhtien += Int32.Parse(item[5].ToString());
                    noidungEmail += "Đơn hàng : " + item[0].ToString() + " Số lương: " + item[2].ToString() + "<br />";
                    addRow(item);
                }
                noidungEmail += "Tổng hóa đơn: " + thanhtien + " đồng <br />";
                noidungEmail += "Cảm ơn bạn đã ủng hộ, chúng tôi sẽ giao hàng sớm nhất có thê! ^^";

                lbTongTien.Text = thanhtien.ToString();
                lbTongTienChu.Text = "( " + HamChung.ChuyenSo(thanhtien.ToString()) + " đồng )";

            }
            else
            {

                panelParent.Controls.Clear();
                panelParent.Controls.Add(panelEmpty);
                panelEmpty.Visible = true;

            }
        }
        private void UpdateTienChu()
        {
            var data = TruyVan();
            thanhtien = 0;
            foreach (DataRow item in data.Rows)
            {
                thanhtien += Int32.Parse(item[5].ToString());

            }
            lbTongTien.Text = thanhtien.ToString();
            lbTongTienChu.Text = "( " + HamChung.ChuyenSo(thanhtien.ToString()) + "đồng)";
        }
        private void addRow(DataRow item)
        {

            Panel panel = new Panel();
            Panel line = new Panel();

            PictureBox pictureBox = new PictureBox();
            Label lbTen = new Label();
            Label lbDonGia = new Label();
            Label lbThanhTienTitle = new Label();

            Label lbThanhTien = new Label();
            Button btnGiamSL = new Button();
            Button btnTangSL = new Button();
            Button btnDelete = new Button();
            TextBox txtsL = new TextBox();

            // panel 
            panel.BackColor = Color.FromArgb(24, 30, 54);
            panel.Dock = DockStyle.Top;
            panel.Font = label1.Font;
            panel.Size = new Size(658, 144);
            panelParent.Controls.Add(panel);

            // panel line
            line.Size = new Size(658, 12);
            line.Dock = DockStyle.Bottom;
            line.BackColor = Color.White;
           
            panel.Controls.Add(line);

            // btn xoa
            btnDelete.Text = "Xóa";
            if (FindId != 0)
                btnDelete.Enabled = false;
            btnDelete.Font = label1.Font;
            btnDelete.Location = new Point(9, 10);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Size = new Size(64, 116);
            btnDelete.Click += (object sender, EventArgs e) =>
            {
                Delete(Int32.Parse(item[4].ToString()));
            };
            panel.Controls.Add(btnDelete);
            // anh sach
            pictureBox.Size = new Size(115, 121);
            pictureBox.Location = new Point(79, 6);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = HamChung.GetImageFromString(item[3].ToString());
            panel.Controls.Add(pictureBox);

            // lb tên
            lbTen.Text = item[0].ToString();
            lbTen.Location = new Point(235, 24);
            lbTen.AutoSize = false;
            lbTen.Size = new Size(200, 40);
            lbTen.Font = label1.Font;
            lbTen.ForeColor = Color.White;
            panel.Controls.Add(lbTen);
            // lb dongia giá
            //lbDonGia.Font = new Font(Font.FontFamily, 12);
            lbDonGia.Text = (item[1].ToString() + " đồng");
            lbDonGia.Location = new Point(235, 87);
            lbDonGia.ForeColor = Color.White;
            panel.Controls.Add(lbDonGia);
            // btn giam
            btnGiamSL.Text = "-";
            btnGiamSL.Font = label1.Font;
            btnGiamSL.Size = new Size(33, 25);
            if (FindId != 0)
                btnGiamSL.Enabled = false;
            btnGiamSL.Location = new Point(491, 22);
            btnGiamSL.BackColor = Color.White;
            btnGiamSL.Click += (object sender, EventArgs e) =>
            {
                GiamSoSach(item[4].ToString(), Int32.Parse(item[4].ToString()), Int32.Parse(item[1].ToString()));
            };
            panel.Controls.Add(btnGiamSL);

            // txt số lượng
            txtsL.Text = item[2].ToString();
            txtsL.Name = "txt" + item[4].ToString();
            txtsL.Location = new Point(530, 22);
            txtsL.ForeColor = Color.Black;
            txtsL.Size = new Size(46, 25);
            if (FindId != 0)
                txtsL.ReadOnly = true;
            txtsL.TextAlign = HorizontalAlignment.Center;
            txtsL.Font = label1.Font;
            txtsL.TextChanged += (object sender, EventArgs e) =>
            {
                EditSL(item[4].ToString(), Int32.Parse(item[4].ToString()), Int32.Parse(item[1].ToString()));
            };
            panel.Controls.Add(txtsL);

            // btn tang
            btnTangSL.Text = "+";
            btnTangSL.Size = new Size(33, 25);
            btnTangSL.ForeColor = Color.Black;
            btnTangSL.Location = new Point(582, 22);
            btnTangSL.Font = label1.Font;
            if (FindId != 0)
                btnTangSL.Enabled = false;
            btnTangSL.BackColor = Color.White;
            btnTangSL.Click += (object sender, EventArgs e) =>
            {
                TangSlSach(item[4].ToString(), Int32.Parse(item[4].ToString()), Int32.Parse(item[1].ToString()));
            };
            panel.Controls.Add(btnTangSL);

            // lb thanh  tiền  tilte
            lbThanhTienTitle.Text = "Thành tiền";
            lbThanhTienTitle.Location = new Point(514, 59);
            lbThanhTienTitle.ForeColor = Color.White;
            lbThanhTienTitle.Font = label1.Font;
            panel.Controls.Add(lbThanhTienTitle);

            // lb thanh  tiền 
            lbThanhTien.Text = (Int32.Parse(item[1].ToString()) * Int32.Parse(item[2].ToString())).ToString();
            lbThanhTien.Name = "txttien" + Int32.Parse(item[4].ToString());
            lbThanhTien.Location = new Point(527, 90);
            lbThanhTien.Font = label1.Font;
            lbThanhTien.ForeColor = Color.White;
            panel.Controls.Add(lbThanhTien);


        }

        private void EditSL(string nameTxt, int id, int dg)
        {
            TextBox ctn = (TextBox)this.Controls.Find("txt" + nameTxt, true)[0];
            Label lb = (Label)this.Controls.Find("txttien" + nameTxt, true)[0];
            string n = ctn.Text;
            try
            {
                if (!String.IsNullOrEmpty(ctn.Text))
                {
                    int a = Int32.Parse(ctn.Text);
                    lb.Text = (a * dg).ToString();
                    updateSl(id, a);
                    UpdateTienChu();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập số");

            }



        }

        private void Delete(int id)
        {
            var confirmResult = MessageBox.Show("Bạn có muốn xóa ??",
                                    "Cảnh báo!!",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                cn.ExecuteNonQuery("DELETE chitiethoadon where id =" + id);
                getGioHang();
                UpdateTienChu();


            }
        }
        private void DatHang()
        {
                cn.ExecuteNonQuery("UPDATE HOADON SET ngaydat = '" + DateTime.Now+"',trangthai = N'"+TrangThai.ChoDuyet
                    +"',tongtien = "+thanhtien+", ghichu =N'"+txtGhiChu.Text+ "', sdt =N'" + txtSDT.Text 
                    + "' , noigiaohang =N'" + txtDiaChi.Text + "'   where id =" + IdHoaDong);
                getGioHang();
                UpdateTienChu();
            MessageBox.Show("Đặt hàng thành công");

        }
        private void updateSl(int id, int sl)
        {
            cn.ExecuteNonQuery("UPDATE chitiethoadon set soluong =" + sl + " where id =" + id);
        }

        private void TangSlSach(string nameTxt, int id, int dg)
        {
            try
            {
                TextBox ctn = (TextBox)this.Controls.Find("txt" + nameTxt, true)[0];
                Label lb = (Label)this.Controls.Find("txttien" + nameTxt, true)[0];
                int a = Int32.Parse(ctn.Text) + 1;
                ctn.Text = a.ToString();
                lb.Text = (a * dg).ToString();
                updateSl(id, a);
                UpdateTienChu();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void GiamSoSach(string nameTxt, int id, int dg)
        {
            TextBox ctn = (TextBox)this.Controls.Find("txt" + nameTxt, true)[0];
            Label lb = (Label)this.Controls.Find("txttien" + nameTxt, true)[0];
            if (Int32.Parse(ctn.Text) > 1)
            {
                int a = Int32.Parse(ctn.Text) - 1;
                ctn.Text = a.ToString();
                lb.Text = (a * dg).ToString();
                updateSl(id, a);
                UpdateTienChu();

            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            DatHang();
        }
    }
}
