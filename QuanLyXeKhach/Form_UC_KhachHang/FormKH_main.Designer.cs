namespace QuanLyXeKhach.FormKhachHang
{
    partial class FormKH_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKH_main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pl_KH_main = new System.Windows.Forms.Panel();
            this.pl_KH_chucnang = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnNhapMaKH = new System.Windows.Forms.Button();
            this.tbNhapMaKH = new System.Windows.Forms.TextBox();
            this.btnDichVu = new QuanLyXeKhach.CustomButton();
            this.customButton1 = new QuanLyXeKhach.CustomButton();
            this.btnTitleUser = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnGioHang = new QuanLyXeKhach.CustomButton();
            this.btn_trangchu = new QuanLyXeKhach.CustomButton();
            this.btn_ChuyenXe = new QuanLyXeKhach.CustomButton();
            this.pl_KH_chucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pl_KH_main
            // 
            this.pl_KH_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(163)))), ((int)(((byte)(186)))));
            this.pl_KH_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_KH_main.Location = new System.Drawing.Point(276, 10);
            this.pl_KH_main.Name = "pl_KH_main";
            this.pl_KH_main.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pl_KH_main.Size = new System.Drawing.Size(1084, 728);
            this.pl_KH_main.TabIndex = 2;
            // 
            // pl_KH_chucnang
            // 
            this.pl_KH_chucnang.BackgroundColor = System.Drawing.Color.White;
            this.pl_KH_chucnang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_KH_chucnang.BackgroundImage")));
            this.pl_KH_chucnang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_KH_chucnang.BorderColor = System.Drawing.Color.Transparent;
            this.pl_KH_chucnang.BorderRadius = 35;
            this.pl_KH_chucnang.BorderThickness = 1;
            this.pl_KH_chucnang.Controls.Add(this.btnNhapMaKH);
            this.pl_KH_chucnang.Controls.Add(this.tbNhapMaKH);
            this.pl_KH_chucnang.Controls.Add(this.btnDichVu);
            this.pl_KH_chucnang.Controls.Add(this.customButton1);
            this.pl_KH_chucnang.Controls.Add(this.btnTitleUser);
            this.pl_KH_chucnang.Controls.Add(this.btnGioHang);
            this.pl_KH_chucnang.Controls.Add(this.btn_trangchu);
            this.pl_KH_chucnang.Controls.Add(this.btn_ChuyenXe);
            this.pl_KH_chucnang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_KH_chucnang.Location = new System.Drawing.Point(10, 10);
            this.pl_KH_chucnang.Name = "pl_KH_chucnang";
            this.pl_KH_chucnang.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pl_KH_chucnang.ShowBorders = true;
            this.pl_KH_chucnang.Size = new System.Drawing.Size(266, 728);
            this.pl_KH_chucnang.TabIndex = 1;
            // 
            // btnNhapMaKH
            // 
            this.btnNhapMaKH.Location = new System.Drawing.Point(44, 203);
            this.btnNhapMaKH.Name = "btnNhapMaKH";
            this.btnNhapMaKH.Size = new System.Drawing.Size(154, 30);
            this.btnNhapMaKH.TabIndex = 14;
            this.btnNhapMaKH.Text = "Xác nhận mã";
            this.btnNhapMaKH.UseVisualStyleBackColor = true;
            this.btnNhapMaKH.Click += new System.EventHandler(this.btnNhapMaDT_Click);
            // 
            // tbNhapMaKH
            // 
            this.tbNhapMaKH.Location = new System.Drawing.Point(52, 170);
            this.tbNhapMaKH.Name = "tbNhapMaKH";
            this.tbNhapMaKH.ReadOnly = true;
            this.tbNhapMaKH.Size = new System.Drawing.Size(146, 27);
            this.tbNhapMaKH.TabIndex = 13;
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.btnDichVu.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(190)))));
            this.btnDichVu.BorderRadius = 67;
            this.btnDichVu.BorderSize = 0;
            this.btnDichVu.FlatAppearance.BorderSize = 0;
            this.btnDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDichVu.ForeColor = System.Drawing.Color.Black;
            this.btnDichVu.Location = new System.Drawing.Point(-75, 443);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(303, 67);
            this.btnDichVu.TabIndex = 6;
            this.btnDichVu.Text = "Dịch vụ";
            this.btnDichVu.TextColor = System.Drawing.Color.Black;
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(222)))), ((int)(((byte)(252)))));
            this.customButton1.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(222)))), ((int)(((byte)(252)))));
            this.customButton1.BorderRadius = 67;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(-75, 625);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(303, 67);
            this.customButton1.TabIndex = 5;
            this.customButton1.Text = "     Đăng xuất";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click_1);
            // 
            // btnTitleUser
            // 
            this.btnTitleUser.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTitleUser.color = System.Drawing.Color.SeaGreen;
            this.btnTitleUser.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnTitleUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTitleUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitleUser.ForeColor = System.Drawing.Color.White;
            this.btnTitleUser.Image = ((System.Drawing.Image)(resources.GetObject("btnTitleUser.Image")));
            this.btnTitleUser.ImagePosition = 14;
            this.btnTitleUser.ImageZoom = 50;
            this.btnTitleUser.LabelPosition = 29;
            this.btnTitleUser.LabelText = "Username";
            this.btnTitleUser.Location = new System.Drawing.Point(78, 32);
            this.btnTitleUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnTitleUser.Name = "btnTitleUser";
            this.btnTitleUser.Size = new System.Drawing.Size(110, 118);
            this.btnTitleUser.TabIndex = 0;
            // 
            // btnGioHang
            // 
            this.btnGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(243)))));
            this.btnGioHang.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(207)))), ((int)(((byte)(243)))));
            this.btnGioHang.BorderRadius = 67;
            this.btnGioHang.BorderSize = 0;
            this.btnGioHang.FlatAppearance.BorderSize = 0;
            this.btnGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGioHang.ForeColor = System.Drawing.Color.Black;
            this.btnGioHang.Location = new System.Drawing.Point(-75, 529);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(303, 67);
            this.btnGioHang.TabIndex = 4;
            this.btnGioHang.Text = "    Giỏ hàng";
            this.btnGioHang.TextColor = System.Drawing.Color.Black;
            this.btnGioHang.UseVisualStyleBackColor = false;
            this.btnGioHang.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // btn_trangchu
            // 
            this.btn_trangchu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.btn_trangchu.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(117)))), ((int)(((byte)(170)))));
            this.btn_trangchu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_trangchu.BorderRadius = 67;
            this.btn_trangchu.BorderSize = 0;
            this.btn_trangchu.FlatAppearance.BorderSize = 0;
            this.btn_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trangchu.ForeColor = System.Drawing.Color.Black;
            this.btn_trangchu.Location = new System.Drawing.Point(-75, 254);
            this.btn_trangchu.Name = "btn_trangchu";
            this.btn_trangchu.Size = new System.Drawing.Size(303, 67);
            this.btn_trangchu.TabIndex = 1;
            this.btn_trangchu.Text = "    Trang chủ";
            this.btn_trangchu.TextColor = System.Drawing.Color.Black;
            this.btn_trangchu.UseVisualStyleBackColor = false;
            this.btn_trangchu.Click += new System.EventHandler(this.btn_trangchu_Click);
            // 
            // btn_ChuyenXe
            // 
            this.btn_ChuyenXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btn_ChuyenXe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.btn_ChuyenXe.BorderRadius = 67;
            this.btn_ChuyenXe.BorderSize = 0;
            this.btn_ChuyenXe.FlatAppearance.BorderSize = 0;
            this.btn_ChuyenXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChuyenXe.ForeColor = System.Drawing.Color.Black;
            this.btn_ChuyenXe.Location = new System.Drawing.Point(-75, 353);
            this.btn_ChuyenXe.Name = "btn_ChuyenXe";
            this.btn_ChuyenXe.Size = new System.Drawing.Size(303, 67);
            this.btn_ChuyenXe.TabIndex = 2;
            this.btn_ChuyenXe.Text = "     Chuyến xe";
            this.btn_ChuyenXe.TextColor = System.Drawing.Color.Black;
            this.btn_ChuyenXe.UseVisualStyleBackColor = false;
            this.btn_ChuyenXe.Click += new System.EventHandler(this.btn_ChuyenXe_Click);
            // 
            // FormKH_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(163)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1370, 748);
            this.Controls.Add(this.pl_KH_main);
            this.Controls.Add(this.pl_KH_chucnang);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKH_main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FormKH_main";
            this.Load += new System.EventHandler(this.FormKH_main_Load);
            this.pl_KH_chucnang.ResumeLayout(false);
            this.pl_KH_chucnang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private CustomButton btnGioHang;
        private CustomButton btn_ChuyenXe;
        private CustomButton btn_trangchu;
        private Bunifu.Framework.UI.BunifuTileButton btnTitleUser;
        private CustomButton customButton1;
        private Bunifu.UI.WinForms.BunifuPanel pl_KH_chucnang;
        private System.Windows.Forms.Panel pl_KH_main;
        private CustomButton btnDichVu;
        private System.Windows.Forms.Button btnNhapMaKH;
        private System.Windows.Forms.TextBox tbNhapMaKH;
    }
}