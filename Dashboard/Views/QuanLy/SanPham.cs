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
    public partial class SanPham : Form
    {
        private Connect cn;
        private string ma;
        private string search = "";
        private int KhoId = 0;
        private int NccId = 0;
        private int LoaiId = 0;
        public SanPham()
        {
            InitializeComponent();
            cn = new Connect();
        }



        private void SanPham_Load(object sender, EventArgs e)
        {
            setDataCombo();
            cbKho.SelectedIndex = 0;
            cbNCC.SelectedIndex = 0;
            cbLoaiSanPham.SelectedIndex = 0;
            checkActive.Checked = true;
            GetSanPham();
            
        }

        private void GetSanPham()
        {
            var data = cn.getDataTable("SELECT s.id as 'Mã',s.ten as 'Tên',s.soluong as 'Số lượng'" +
                ",s.dongia as 'Đơn giá',s.ngaynhap as 'Ngày nhập',k.ten as 'Kho',ncc.ten as 'NCC' ,l.ten as 'Loại' " +
                ",s.active as 'Hoạt động' FROM SanPham s left join kho k on s.khoId = k.id  " +
                "left join nhacungcap ncc on ncc.id = s.nccId left join LoaiSanPham l on s.LoaiSanPhamId = l.id " +
                "where ('"+search+"' = '' or s.ten = N'"+search+"') and (" + KhoId + " = 0 or k.id = " + KhoId + ") " +
                "and ("+ NccId + " = 0 or ncc.id = " + NccId + ") and (" + LoaiId + " = 0 or l.id = " + LoaiId + ")");
            dataGridView1.DataSource = data;
        }
        private void InsertOrUpdate()
        {
            //try
            //{
                string ten, mota, anh;
                int id, soluong, dongia, khoId, nccId, loaiId;
                DateTime ngaynhap;
                bool active;
                id = String.IsNullOrEmpty(txtMa.Text) ? 0 : int.Parse(txtMa.Text);
                ten = txtTen.Text;
                mota = txtMoTa.Text;
                anh = !String.IsNullOrEmpty(ptbAnh.Image.ToString()) ? HamChung.GetStringFromImage(ptbAnh.Image) : "";
                soluong = Int32.Parse(txtSoLuong.Text);
                dongia = Int32.Parse(txtDonGia.Text);

                ngaynhap = DateTime.Now;
                khoId = HamChung.GetIdFromCombobox(cbKho.SelectedItem.ToString());
                nccId = HamChung.GetIdFromCombobox(cbNCC.SelectedItem.ToString());
                loaiId = HamChung.GetIdFromCombobox(cbLoaiSanPham.SelectedItem.ToString());
                active = checkActive.Checked;

                if (id == 0)
                {
                    // thêm
                    cn.ExecuteNonQuery("INSERT INTO SANPHAM VALUES(N'" + ten + "',0," + dongia + ",'"
                    + ngaynhap + "',N'" + mota + "'," + khoId + "," + nccId + "," + loaiId + ",1,0,'" + anh + "')");
                    MessageBox.Show("Thêm sản phẩm thành công");
                    
                }
                else
                {
                    string sql = "UPDATE [dbo].[SanPham] SET [ten] = N'" + ten +
                        "'  ,[soluong] =" + soluong + " ,[dongia] = " + dongia +
                        "  ,[ngaynhap] = '" + ngaynhap + "' ,[mota] = N'" + mota +
                        "' ,[khoId] = " + khoId + "  ,[nccId] = " + nccId +
                        "   ,[LoaiSanPhamId] = " + loaiId + "  ,[active] = '" + active
                        + "'  ,[luotxem] =luotxem ,[anh] = '" + anh + "' WHERE id = " + id;
                    cn.ExecuteNonQuery(sql);
                    MessageBox.Show("Sửa sản phẩm thành công");
                }
                GetSanPham();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Cách trường dữ liệu không đúng!", "Thông báo");
            //}
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                ma = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else if (e.RowIndex != -1)
            {
                ma = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string kho, ncc, nxb, loai;
                string anh = null;
                kho = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                ncc = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                loai = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                var dt = cn.getDataTable("select anh from sanpham where id = " + ma);
                if (dt.Rows.Count > 0)
                {
                    anh = dt.Rows[0][0].ToString();
                }

                //AUTO KHO
                if (String.IsNullOrEmpty(kho))
                {
                    cbKho.SelectedIndex = 0;
                }
                else
                {
                    cbKho.SelectedItem = kho;
                }

                //AUTO NCC
                if (String.IsNullOrEmpty(ncc))
                {
                    cbNCC.SelectedIndex = 0;
                }
                else
                {
                    cbNCC.SelectedItem = ncc;
                }

                //AUTO LOAI
                if (String.IsNullOrEmpty(loai))
                {
                    cbLoaiSanPham.SelectedIndex = 0;
                }
                else
                {
                    cbLoaiSanPham.SelectedItem = loai;
                }

                //AUTO anh
                if (String.IsNullOrEmpty(anh))
                {
                    ptbAnh.Image = null;

                }
                else
                {
                    ptbAnh.Image = HamChung.GetImageFromString(anh);
                }
                GetAllRow();
            }
        }
        private void GetAllRow()
        {
            DataTable read = cn.getDataTable("select id,ten,soluong,dongia,mota,active from sanpham where id =" + ma);
            if (read.Rows.Count > 0)
            {

                txtMa.Text = read.Rows[0][0].ToString();
                txtTen.Text = read.Rows[0][1].ToString();
                txtSoLuong.Text = read.Rows[0][2].ToString();
                txtDonGia.Text = read.Rows[0][3].ToString();

                txtMoTa.Text = read.Rows[0][4].ToString();
                checkActive.Text = read.Rows[0][5].ToString() == "True" ? "Hoạt động" : "Ngừng";
                checkActive.Checked = read.Rows[0][5].ToString() == "True" ? true : false;


            }
        }
        private void setDataCombo()
        {
            DataTable tbKho = cn.getDataTable("select * from kho");
            if (tbKho.Rows.Count > 0)
            {
                foreach (DataRow item in tbKho.Rows)
                {
                    cbKho.Items.Add(item[0].ToString() + "- " + item[1].ToString());
                    cbSKho.Items.Add(item[0].ToString() + "- " + item[1].ToString());
                }
            }
            DataTable tbNcc = cn.getDataTable("select * from nhacungcap");
            if (tbNcc.Rows.Count > 0)
            {
                foreach (DataRow item in tbNcc.Rows)
                {
                    cbNCC.Items.Add(item[0].ToString() + "- " + item[1].ToString());
                    cbSNcc.Items.Add(item[0].ToString() + "- " + item[1].ToString());
                }
            }

            DataTable tbLoai = cn.getDataTable("select * from loaisanpham");
            if (tbLoai.Rows.Count > 0)
            {
                foreach (DataRow item in tbLoai.Rows)
                {
                    cbLoaiSanPham.Items.Add(item[0].ToString() + "- " + item[1].ToString());
                    cbSLoai.Items.Add(item[0].ToString() + "- " + item[1].ToString());
                }
            }
            cbSKho.SelectedIndex = 0;
            cbSNcc.SelectedIndex = 0;
            cbSLoai.SelectedIndex = 0;
        }
        private void cbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            InsertOrUpdate();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            InsertOrUpdate();

        }

        private void cbSLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSLoai.SelectedIndex == 0)
            {
                LoaiId = 0;
            }
            else
                LoaiId = HamChung.GetIdFromCombobox(cbSLoai.SelectedItem.ToString());
            GetSanPham();
        }

        private void cbSKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSKho.SelectedIndex == 0)
            {
                KhoId = 0;
            }
            else
                KhoId = HamChung.GetIdFromCombobox(cbSKho.SelectedItem.ToString());
            GetSanPham();
        }

        private void cbSNcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSNcc.SelectedIndex == 0)
            {
                NccId = 0;
            }
            else
            NccId = HamChung.GetIdFromCombobox(cbSNcc.SelectedItem.ToString());
            GetSanPham();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search = txtSearch.Text;
            GetSanPham();
        }

        private void ptbAnh_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    PictureBox1.Image = new Bitmap(dlg.FileName);
                    ptbAnh.Image = new Bitmap(dlg.FileName);

                }
            }
        }
    }
}
