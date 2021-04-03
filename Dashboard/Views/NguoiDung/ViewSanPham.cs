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
            GetSanPham();
        }

        private void GetSanPham()
        {
            var data = cn.getDataTable("select top 10 id,ten,dongia,luotxem,anh  from sanpham");
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
            string gia = row[2].ToString();
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
            
            Lgia.Location = lbGiaMau.Location;
            Lgia.Font = lbGiaMau.Font;
            Lgia.AutoSize = true;
            Lgia.ForeColor = lbGiaMau.ForeColor;
            Lgia.Text = String.Format("{0:#,##0.##}", gia) + " đ";
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
        }


    }
}
