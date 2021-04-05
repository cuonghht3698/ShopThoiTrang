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
    public partial class ViewSanPham : Form
    {
        private readonly Connect cn;
        private string search = "";
        private int PageIndex = 1;
        private int PageSize = 10;
        private int SLoai = 0;


        public ViewSanPham()
        {
            InitializeComponent();
            cn = new Connect();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewSanPham_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            cbPageSize.SelectedIndex = 1;
            SLoai = 0;
            GetLoai();
            cbLoaiSanPham.SelectedIndex = 0;
            GetSanPham();
        }

        private void GetSanPham()
        {
            panelSP.Controls.Clear();
            w = 0;
            h = 20;
            count = 0;
            var data = cn.getDataTable("select s.id,s.ten,s.dongia,s.luotxem,s.anh  from sanpham s join loaisanpham l on s.loaisanphamid = l.id " +
                    "where ('" + search + "' = '' or s.ten like N'%" + search + "%') and (" + SLoai + " = 0 or l.id = " + SLoai + ")" + " ORDER BY s.ten OFFSET " + (PageIndex - 1) * PageSize + " ROWS FETCH NEXT " + PageSize + " ROWS ONLY");
            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    createDienThoai(item);
                }
            }
        }
        private int w = 0;
        private int h = 20;
        private int count = 0;
        private void createDienThoai(DataRow row)
        {
            int id = Int32.Parse(row[0].ToString());
            string ten = row[1].ToString();
            string gia = String.Format("{0:#,##0.##}", row[2].ToString()); 
            string view = row[3].ToString();
            string anh = row[4].ToString();



            Panel panel = new Panel();

            PictureBox pic = new PictureBox();
            Label Lten = new Label();
            Label Lgia = new Label();
            Label Lview = new Label();

            // location
            w = (panelMau.Width + 5) * count;

            if (panelSP.Width < w + 110)
            {
                w = 0;
                count = 0;
                h += panelMau.Height + 5;
            }
            count++;


            // panel
            panel.Dock = panelMau.Dock;
            panel.Size = panelMau.Size;
            panel.BorderStyle = panelMau.BorderStyle;
            panel.Cursor = panelMau.Cursor;
            panel.BackColor = panelMau.BackColor;
            panel.Cursor = Cursors.Hand;
            panel.Click += (object s, EventArgs e) =>
            {
                OpenChiTietSanPham(id);
            };
            panel.Location = new Point(20 + w, h);


            // anh sp
            pic.Location = picMau.Location;
            pic.Size = picMau.Size;
            pic.Image = String.IsNullOrEmpty(anh) ? null : HamChung.GetImageFromString(anh);
            pic.SizeMode = picMau.SizeMode;
            pic.Cursor = Cursors.Hand;
            pic.Click += (object s, EventArgs e) =>
            {
                OpenChiTietSanPham(id);
            };
            panel.Controls.Add(pic);
            // ten sp
            Lten.Location = lbTenMau.Location;
            Lten.Text = ten;
            Lten.ForeColor = lbTenMau.ForeColor;
            Lten.Font = lbTenMau.Font;
            Lten.AutoSize = lbTenMau.AutoSize;
            Lten.Size = lbTenMau.Size;
            Lten.Click += (object s, EventArgs e) =>
            {
                //OpenChiTietSanPham(id);
            };
            panel.Controls.Add(Lten);
            Lgia.Text = gia;
            Lgia.Location = lbGiaMau.Location;
            Lgia.Font = lbGiaMau.Font;
            Lgia.AutoSize = true;
            Lgia.ForeColor = lbGiaMau.ForeColor;
            
            Lgia.Click += (object s, EventArgs e) =>
            {
                //OpenChiTietSanPham(id);
            };
            panel.Controls.Add(Lgia);
            // gia gach giữa



            // VIEW COUNT
            Lview.Location = lbViewMau.Location;
            Lview.Font = lbViewMau.Font;
            Lview.ForeColor = lbViewMau.ForeColor;
            Lview.Text = view;
            Lview.Click += (object s, EventArgs e) =>
            {
                //OpenChiTietSanPham(id);
            };
            panel.Controls.Add(Lview);


            panelSP.Controls.Add(panel);



        }
        private void OpenChiTietSanPham(int id)
        {
            cn.ExecuteNonQuery("update sanpham set luotxem = luotxem + 1 where id = " + id);
            btnBack.Visible = true;
            txtSearch.Visible = false;
            lbSearch.Visible = false;
            labelPZ.Visible = false;
            cbPageSize.Visible = false;
            sanpham = panelSP;
            panelMain.Controls.Clear();
            openChildForm(new Detail(id));
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        Panel sanpham = new Panel();
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(sanpham);
            btnBack.Visible = false;
            txtSearch.Visible = true;
            lbSearch.Visible = true;
            labelPZ.Visible = true;
            cbPageSize.Visible = true;
        }

        private void GetLoai()
        {
            var loai = cn.getDataTable("SELECT * from LoaiSanPham");
          
            if (loai.Rows.Count > 0)
            {
                foreach (DataRow item in loai.Rows)
                {
                    int id = Int32.Parse(item[0].ToString());
                    string ten = item[1].ToString();

                    cbLoaiSanPham.Items.Add(id + " -" + ten);


                }
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search = txtSearch.Text;
            GetSanPham();
        }

        private void cbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageSize = Int32.Parse(cbPageSize.SelectedItem.ToString());
            GetSanPham();
        }

        private void cbLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiSanPham.SelectedIndex == 0)
            {
                SLoai = 0;
            }
            else
            {
                SLoai = HamChung.GetIdFromCombobox(cbLoaiSanPham.SelectedItem.ToString());
            }
            GetSanPham();
        }
    }
}
