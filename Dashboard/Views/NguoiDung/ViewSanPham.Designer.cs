
namespace Dashboard.Views.NguoiDung
{
    partial class ViewSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSanPham));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSP = new System.Windows.Forms.Panel();
            this.panelMau = new System.Windows.Forms.Panel();
            this.lbGiaMau = new System.Windows.Forms.Label();
            this.lbViewMau = new System.Windows.Forms.Label();
            this.lbTenMau = new System.Windows.Forms.Label();
            this.picMau = new System.Windows.Forms.PictureBox();
            this.cbPageSize = new System.Windows.Forms.ComboBox();
            this.labelPZ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelSP.SuspendLayout();
            this.panelMau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMau)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSearch.Location = new System.Drawing.Point(117, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(291, 53);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.White;
            this.lbSearch.Location = new System.Drawing.Point(4, 27);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(99, 25);
            this.lbSearch.TabIndex = 15;
            this.lbSearch.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.cbLoaiSanPham);
            this.panel1.Controls.Add(this.cbPageSize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelPZ);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lbSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1691, 79);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBack.Image = global::Dashboard.Properties.Resources.home;
            this.btnBack.Location = new System.Drawing.Point(1518, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(173, 79);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Trở về";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnDashbord_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelSP);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 79);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1691, 801);
            this.panelMain.TabIndex = 1;
            // 
            // panelSP
            // 
            this.panelSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelSP.Controls.Add(this.panelMau);
            this.panelSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSP.Location = new System.Drawing.Point(0, 0);
            this.panelSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(1691, 801);
            this.panelSP.TabIndex = 2;
            // 
            // panelMau
            // 
            this.panelMau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMau.Controls.Add(this.lbGiaMau);
            this.panelMau.Controls.Add(this.lbViewMau);
            this.panelMau.Controls.Add(this.lbTenMau);
            this.panelMau.Controls.Add(this.picMau);
            this.panelMau.Location = new System.Drawing.Point(21, 22);
            this.panelMau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMau.Name = "panelMau";
            this.panelMau.Size = new System.Drawing.Size(386, 291);
            this.panelMau.TabIndex = 0;
            this.panelMau.Visible = false;
            this.panelMau.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // lbGiaMau
            // 
            this.lbGiaMau.AutoSize = true;
            this.lbGiaMau.Font = new System.Drawing.Font("Sitka Subheading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaMau.Location = new System.Drawing.Point(196, 30);
            this.lbGiaMau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGiaMau.Name = "lbGiaMau";
            this.lbGiaMau.Size = new System.Drawing.Size(146, 49);
            this.lbGiaMau.TabIndex = 1;
            this.lbGiaMau.Text = "300000";
            // 
            // lbViewMau
            // 
            this.lbViewMau.AutoSize = true;
            this.lbViewMau.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewMau.Location = new System.Drawing.Point(5, -1);
            this.lbViewMau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbViewMau.Name = "lbViewMau";
            this.lbViewMau.Size = new System.Drawing.Size(63, 28);
            this.lbViewMau.TabIndex = 1;
            this.lbViewMau.Text = "label1";
            // 
            // lbTenMau
            // 
            this.lbTenMau.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMau.Location = new System.Drawing.Point(16, 214);
            this.lbTenMau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenMau.Name = "lbTenMau";
            this.lbTenMau.Size = new System.Drawing.Size(369, 60);
            this.lbTenMau.TabIndex = 1;
            this.lbTenMau.Text = "label1";
            // 
            // picMau
            // 
            this.picMau.Image = ((System.Drawing.Image)(resources.GetObject("picMau.Image")));
            this.picMau.Location = new System.Drawing.Point(21, 30);
            this.picMau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picMau.Name = "picMau";
            this.picMau.Size = new System.Drawing.Size(167, 165);
            this.picMau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMau.TabIndex = 0;
            this.picMau.TabStop = false;
            this.picMau.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbPageSize
            // 
            this.cbPageSize.BackColor = System.Drawing.Color.White;
            this.cbPageSize.DropDownHeight = 300;
            this.cbPageSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPageSize.ForeColor = System.Drawing.Color.Black;
            this.cbPageSize.FormattingEnabled = true;
            this.cbPageSize.IntegralHeight = false;
            this.cbPageSize.ItemHeight = 25;
            this.cbPageSize.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.cbPageSize.Location = new System.Drawing.Point(1401, 23);
            this.cbPageSize.Margin = new System.Windows.Forms.Padding(4);
            this.cbPageSize.Name = "cbPageSize";
            this.cbPageSize.Size = new System.Drawing.Size(101, 33);
            this.cbPageSize.TabIndex = 36;
            this.cbPageSize.SelectedIndexChanged += new System.EventHandler(this.cbPageSize_SelectedIndexChanged);
            // 
            // labelPZ
            // 
            this.labelPZ.AutoSize = true;
            this.labelPZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPZ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPZ.Location = new System.Drawing.Point(1289, 26);
            this.labelPZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPZ.Name = "labelPZ";
            this.labelPZ.Size = new System.Drawing.Size(105, 25);
            this.labelPZ.TabIndex = 35;
            this.labelPZ.Text = "PageSize";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(507, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Loại sản phẩm";
            // 
            // cbLoaiSanPham
            // 
            this.cbLoaiSanPham.BackColor = System.Drawing.Color.White;
            this.cbLoaiSanPham.DropDownHeight = 300;
            this.cbLoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiSanPham.ForeColor = System.Drawing.Color.Black;
            this.cbLoaiSanPham.FormattingEnabled = true;
            this.cbLoaiSanPham.IntegralHeight = false;
            this.cbLoaiSanPham.ItemHeight = 25;
            this.cbLoaiSanPham.Items.AddRange(new object[] {
            "Loại sản phẩm"});
            this.cbLoaiSanPham.Location = new System.Drawing.Point(664, 20);
            this.cbLoaiSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiSanPham.Name = "cbLoaiSanPham";
            this.cbLoaiSanPham.Size = new System.Drawing.Size(306, 33);
            this.cbLoaiSanPham.TabIndex = 36;
            this.cbLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSanPham_SelectedIndexChanged);
            // 
            // ViewSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 880);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewSanPham";
            this.Text = "ViewSanPham";
            this.Load += new System.EventHandler(this.ViewSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelSP.ResumeLayout(false);
            this.panelMau.ResumeLayout(false);
            this.panelMau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSP;
        private System.Windows.Forms.Panel panelMau;
        private System.Windows.Forms.Label lbGiaMau;
        private System.Windows.Forms.Label lbViewMau;
        private System.Windows.Forms.Label lbTenMau;
        private System.Windows.Forms.PictureBox picMau;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbPageSize;
        private System.Windows.Forms.Label labelPZ;
        private System.Windows.Forms.ComboBox cbLoaiSanPham;
        private System.Windows.Forms.Label label1;
    }
}