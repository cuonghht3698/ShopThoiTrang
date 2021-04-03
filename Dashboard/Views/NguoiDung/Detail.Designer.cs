
namespace Dashboard.Views.NguoiDung
{
    partial class Detail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail));
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.lbLoaiSP = new System.Windows.Forms.Label();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbChiTiet = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // picAnh
            // 
            this.picAnh.Image = ((System.Drawing.Image)(resources.GetObject("picAnh.Image")));
            this.picAnh.Location = new System.Drawing.Point(71, 56);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(362, 479);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 0;
            this.picAnh.TabStop = false;
            // 
            // lbLoaiSP
            // 
            this.lbLoaiSP.AutoSize = true;
            this.lbLoaiSP.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiSP.ForeColor = System.Drawing.Color.White;
            this.lbLoaiSP.Location = new System.Drawing.Point(495, 22);
            this.lbLoaiSP.Name = "lbLoaiSP";
            this.lbLoaiSP.Size = new System.Drawing.Size(167, 24);
            this.lbLoaiSP.TabIndex = 1;
            this.lbLoaiSP.Text = "Loại sản phẩm";
            // 
            // lbTenSP
            // 
            this.lbTenSP.Font = new System.Drawing.Font("Lucida Bright", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.ForeColor = System.Drawing.Color.White;
            this.lbTenSP.Location = new System.Drawing.Point(492, 56);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(597, 102);
            this.lbTenSP.TabIndex = 1;
            this.lbTenSP.Text = "ĐẦM NHUNG ĐEN CỔ LƯỚI";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.ForeColor = System.Drawing.Color.White;
            this.lbGia.Location = new System.Drawing.Point(495, 186);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(83, 24);
            this.lbGia.TabIndex = 1;
            this.lbGia.Text = "label1";
            // 
            // cbSize
            // 
            this.cbSize.BackColor = System.Drawing.Color.White;
            this.cbSize.DropDownHeight = 300;
            this.cbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSize.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.ForeColor = System.Drawing.Color.Black;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.IntegralHeight = false;
            this.cbSize.ItemHeight = 27;
            this.cbSize.Items.AddRange(new object[] {
            "SM",
            "L",
            "XL",
            "XXL"});
            this.cbSize.Location = new System.Drawing.Point(499, 260);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(125, 35);
            this.cbSize.TabIndex = 35;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoLuong.Font = new System.Drawing.Font("Rockwell Extra Bold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.Location = new System.Drawing.Point(499, 321);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSoLuong.Size = new System.Drawing.Size(125, 40);
            this.txtSoLuong.TabIndex = 36;
            this.txtSoLuong.Text = "1";
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(495, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chi tiết sản phẩm";
            // 
            // lbChiTiet
            // 
            this.lbChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbChiTiet.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTiet.ForeColor = System.Drawing.Color.White;
            this.lbChiTiet.Location = new System.Drawing.Point(495, 431);
            this.lbChiTiet.Name = "lbChiTiet";
            this.lbChiTiet.Size = new System.Drawing.Size(594, 182);
            this.lbChiTiet.TabIndex = 1;
            this.lbChiTiet.Text = "label1";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuu.Image = global::Dashboard.Properties.Resources.home;
            this.btnLuu.Location = new System.Drawing.Point(627, 321);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(126, 40);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "Add to cart";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Location = new System.Drawing.Point(454, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 10);
            this.panel1.TabIndex = 38;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Location = new System.Drawing.Point(454, 615);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 10);
            this.panel2.TabIndex = 38;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1157, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.lbChiTiet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbTenSP);
            this.Controls.Add(this.lbLoaiSP);
            this.Controls.Add(this.picAnh);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Detail";
            this.Text = "1";
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label lbLoaiSP;
        private System.Windows.Forms.Label lbTenSP;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbChiTiet;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
    }
}