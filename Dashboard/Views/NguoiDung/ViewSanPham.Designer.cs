
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSP = new System.Windows.Forms.Panel();
            this.panelMau = new System.Windows.Forms.Panel();
            this.lbGiaMau = new System.Windows.Forms.Label();
            this.lbViewMau = new System.Windows.Forms.Label();
            this.lbTenMau = new System.Windows.Forms.Label();
            this.picMau = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
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
            this.txtSearch.Location = new System.Drawing.Point(88, 8);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(218, 43);
            this.txtSearch.TabIndex = 14;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.White;
            this.lbSearch.Location = new System.Drawing.Point(3, 22);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(79, 20);
            this.lbSearch.TabIndex = 15;
            this.lbSearch.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lbSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 64);
            this.panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelSP);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 64);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1268, 651);
            this.panelMain.TabIndex = 1;
            // 
            // panelSP
            // 
            this.panelSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelSP.Controls.Add(this.panelMau);
            this.panelSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSP.Location = new System.Drawing.Point(0, 0);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(1268, 651);
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
            this.panelMau.Location = new System.Drawing.Point(16, 18);
            this.panelMau.Name = "panelMau";
            this.panelMau.Size = new System.Drawing.Size(290, 237);
            this.panelMau.TabIndex = 0;
            this.panelMau.Visible = false;
            this.panelMau.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // lbGiaMau
            // 
            this.lbGiaMau.AutoSize = true;
            this.lbGiaMau.Font = new System.Drawing.Font("Sitka Subheading", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGiaMau.Location = new System.Drawing.Point(147, 24);
            this.lbGiaMau.Name = "lbGiaMau";
            this.lbGiaMau.Size = new System.Drawing.Size(112, 39);
            this.lbGiaMau.TabIndex = 1;
            this.lbGiaMau.Text = "300000";
            // 
            // lbViewMau
            // 
            this.lbViewMau.AutoSize = true;
            this.lbViewMau.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewMau.Location = new System.Drawing.Point(4, -1);
            this.lbViewMau.Name = "lbViewMau";
            this.lbViewMau.Size = new System.Drawing.Size(51, 21);
            this.lbViewMau.TabIndex = 1;
            this.lbViewMau.Text = "label1";
            // 
            // lbTenMau
            // 
            this.lbTenMau.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMau.Location = new System.Drawing.Point(12, 174);
            this.lbTenMau.Name = "lbTenMau";
            this.lbTenMau.Size = new System.Drawing.Size(277, 49);
            this.lbTenMau.TabIndex = 1;
            this.lbTenMau.Text = "label1";
            // 
            // picMau
            // 
            this.picMau.Image = ((System.Drawing.Image)(resources.GetObject("picMau.Image")));
            this.picMau.Location = new System.Drawing.Point(16, 24);
            this.picMau.Name = "picMau";
            this.picMau.Size = new System.Drawing.Size(125, 134);
            this.picMau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMau.TabIndex = 0;
            this.picMau.TabStop = false;
            this.picMau.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBack.Image = global::Dashboard.Properties.Resources.home;
            this.btnBack.Location = new System.Drawing.Point(1138, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 64);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Trở về";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnDashbord_Click);
            // 
            // ViewSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 715);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
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
    }
}