
namespace Dashboard.Views
{
    partial class Login
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
            this.cbNhoMatKhau = new System.Windows.Forms.CheckBox();
            this.LinkTaoTaiKhoan = new System.Windows.Forms.LinkLabel();
            this.linkQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLoginFailed = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbNhoMatKhau
            // 
            this.cbNhoMatKhau.AutoSize = true;
            this.cbNhoMatKhau.Location = new System.Drawing.Point(120, 284);
            this.cbNhoMatKhau.Name = "cbNhoMatKhau";
            this.cbNhoMatKhau.Size = new System.Drawing.Size(93, 17);
            this.cbNhoMatKhau.TabIndex = 108;
            this.cbNhoMatKhau.Text = "Nhớ mật khẩu";
            this.cbNhoMatKhau.UseVisualStyleBackColor = true;
            // 
            // LinkTaoTaiKhoan
            // 
            this.LinkTaoTaiKhoan.AutoSize = true;
            this.LinkTaoTaiKhoan.Location = new System.Drawing.Point(229, 312);
            this.LinkTaoTaiKhoan.Name = "LinkTaoTaiKhoan";
            this.LinkTaoTaiKhoan.Size = new System.Drawing.Size(79, 13);
            this.LinkTaoTaiKhoan.TabIndex = 106;
            this.LinkTaoTaiKhoan.TabStop = true;
            this.LinkTaoTaiKhoan.Text = "Tạo tài khoản?";
            this.LinkTaoTaiKhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkTaoTaiKhoan_LinkClicked);
            // 
            // linkQuenMatKhau
            // 
            this.linkQuenMatKhau.AutoSize = true;
            this.linkQuenMatKhau.Location = new System.Drawing.Point(124, 312);
            this.linkQuenMatKhau.Name = "linkQuenMatKhau";
            this.linkQuenMatKhau.Size = new System.Drawing.Size(80, 13);
            this.linkQuenMatKhau.TabIndex = 107;
            this.linkQuenMatKhau.TabStop = true;
            this.linkQuenMatKhau.Text = "Quên mật khẩu";
            this.linkQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkQuenMatKhau_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(120, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(202, 29);
            this.txtPassword.TabIndex = 105;
            this.txtPassword.Text = "admin";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(120, 132);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(202, 29);
            this.txtUser.TabIndex = 104;
            this.txtUser.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 103;
            this.label1.Text = "Tài khoản";
            // 
            // lbLoginFailed
            // 
            this.lbLoginFailed.AutoSize = true;
            this.lbLoginFailed.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginFailed.ForeColor = System.Drawing.Color.Red;
            this.lbLoginFailed.Location = new System.Drawing.Point(105, 83);
            this.lbLoginFailed.Name = "lbLoginFailed";
            this.lbLoginFailed.Size = new System.Drawing.Size(0, 26);
            this.lbLoginFailed.TabIndex = 110;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 41);
            this.button1.TabIndex = 112;
            this.button1.Text = "admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 41);
            this.button2.TabIndex = 112;
            this.button2.Text = "KH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(160)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuu.Image = global::Dashboard.Properties.Resources.home;
            this.btnLuu.Location = new System.Drawing.Point(120, 222);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(202, 42);
            this.btnLuu.TabIndex = 111;
            this.btnLuu.Text = "Đăng nhập";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbLoginFailed);
            this.Controls.Add(this.cbNhoMatKhau);
            this.Controls.Add(this.LinkTaoTaiKhoan);
            this.Controls.Add(this.linkQuenMatKhau);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbNhoMatKhau;
        private System.Windows.Forms.LinkLabel LinkTaoTaiKhoan;
        private System.Windows.Forms.LinkLabel linkQuenMatKhau;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbLoginFailed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}