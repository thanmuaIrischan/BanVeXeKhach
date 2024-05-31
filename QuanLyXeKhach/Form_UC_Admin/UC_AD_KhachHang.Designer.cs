namespace QuanLyXeKhach.Form_UC_Admin
{
    partial class UC_AD_KhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AD_KhachHang));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_khachHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maPhanQuyen = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_gioiTinh = new System.Windows.Forms.TextBox();
            this.txt_hoTen = new System.Windows.Forms.TextBox();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.dgv_hoaDon = new System.Windows.Forms.DataGridView();
            this.pl_TimKiemDichVu = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtTimDichVuNB = new System.Windows.Forms.TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_gio = new System.Windows.Forms.TextBox();
            this.txt_chuyen = new System.Windows.Forms.TextBox();
            this.txt_maVe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_reload = new QuanLyXeKhach.CustomButton();
            this.btn_dangKyKH = new QuanLyXeKhach.CustomButton();
            this.btn_huyVe = new QuanLyXeKhach.CustomButton();
            this.btnTimKiem = new QuanLyXeKhach.CustomButton();
            this.btn_xoaKH = new QuanLyXeKhach.CustomButton();
            this.btn_suaKH = new QuanLyXeKhach.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoaDon)).BeginInit();
            this.pl_TimKiemDichVu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(382, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 46);
            this.label1.TabIndex = 17;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // dgv_khachHang
            // 
            this.dgv_khachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_khachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_khachHang.Location = new System.Drawing.Point(26, 178);
            this.dgv_khachHang.Name = "dgv_khachHang";
            this.dgv_khachHang.RowHeadersWidth = 51;
            this.dgv_khachHang.RowTemplate.Height = 24;
            this.dgv_khachHang.Size = new System.Drawing.Size(766, 271);
            this.dgv_khachHang.TabIndex = 18;
            this.dgv_khachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_khachHang_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoaKH);
            this.groupBox1.Controls.Add(this.btn_suaKH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_maPhanQuyen);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_diaChi);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.txt_gioiTinh);
            this.groupBox1.Controls.Add(this.txt_hoTen);
            this.groupBox1.Controls.Add(this.txt_maKH);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(27, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 261);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mã phân quyền";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Địa chỉ";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "SĐT";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Giới tính";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Họ tên";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã KH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_maPhanQuyen
            // 
            this.txt_maPhanQuyen.Location = new System.Drawing.Point(525, 149);
            this.txt_maPhanQuyen.Name = "txt_maPhanQuyen";
            this.txt_maPhanQuyen.Size = new System.Drawing.Size(196, 27);
            this.txt_maPhanQuyen.TabIndex = 21;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(525, 94);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(196, 27);
            this.txt_email.TabIndex = 21;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(525, 43);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(196, 27);
            this.txt_diaChi.TabIndex = 21;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(110, 200);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(196, 27);
            this.txt_SDT.TabIndex = 21;
            // 
            // txt_gioiTinh
            // 
            this.txt_gioiTinh.Location = new System.Drawing.Point(110, 149);
            this.txt_gioiTinh.Name = "txt_gioiTinh";
            this.txt_gioiTinh.Size = new System.Drawing.Size(196, 27);
            this.txt_gioiTinh.TabIndex = 21;
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Location = new System.Drawing.Point(110, 94);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.Size = new System.Drawing.Size(196, 27);
            this.txt_hoTen.TabIndex = 21;
            // 
            // txt_maKH
            // 
            this.txt_maKH.Location = new System.Drawing.Point(110, 43);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(196, 27);
            this.txt_maKH.TabIndex = 21;
            // 
            // dgv_hoaDon
            // 
            this.dgv_hoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoaDon.Location = new System.Drawing.Point(798, 178);
            this.dgv_hoaDon.Name = "dgv_hoaDon";
            this.dgv_hoaDon.RowHeadersWidth = 51;
            this.dgv_hoaDon.RowTemplate.Height = 24;
            this.dgv_hoaDon.Size = new System.Drawing.Size(316, 271);
            this.dgv_hoaDon.TabIndex = 20;
            this.dgv_hoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoaDon_CellClick);
            // 
            // pl_TimKiemDichVu
            // 
            this.pl_TimKiemDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pl_TimKiemDichVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_TimKiemDichVu.BackgroundImage")));
            this.pl_TimKiemDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_TimKiemDichVu.BorderColor = System.Drawing.Color.Black;
            this.pl_TimKiemDichVu.BorderRadius = 35;
            this.pl_TimKiemDichVu.BorderThickness = 1;
            this.pl_TimKiemDichVu.Controls.Add(this.btnTimKiem);
            this.pl_TimKiemDichVu.Controls.Add(this.txtTimDichVuNB);
            this.pl_TimKiemDichVu.Controls.Add(this.bunifuLabel1);
            this.pl_TimKiemDichVu.Location = new System.Drawing.Point(27, 81);
            this.pl_TimKiemDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.pl_TimKiemDichVu.Name = "pl_TimKiemDichVu";
            this.pl_TimKiemDichVu.ShowBorders = true;
            this.pl_TimKiemDichVu.Size = new System.Drawing.Size(765, 78);
            this.pl_TimKiemDichVu.TabIndex = 21;
            // 
            // txtTimDichVuNB
            // 
            this.txtTimDichVuNB.Location = new System.Drawing.Point(234, 31);
            this.txtTimDichVuNB.Name = "txtTimDichVuNB";
            this.txtTimDichVuNB.Size = new System.Drawing.Size(297, 22);
            this.txtTimDichVuNB.TabIndex = 2;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(22, 29);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(187, 24);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Tìm kiếm theo SĐT:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_gio);
            this.groupBox2.Controls.Add(this.btn_huyVe);
            this.groupBox2.Controls.Add(this.txt_chuyen);
            this.groupBox2.Controls.Add(this.txt_maVe);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(798, 469);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 261);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin vé";
            // 
            // txt_gio
            // 
            this.txt_gio.Location = new System.Drawing.Point(133, 149);
            this.txt_gio.Name = "txt_gio";
            this.txt_gio.Size = new System.Drawing.Size(176, 27);
            this.txt_gio.TabIndex = 21;
            // 
            // txt_chuyen
            // 
            this.txt_chuyen.Location = new System.Drawing.Point(133, 94);
            this.txt_chuyen.Name = "txt_chuyen";
            this.txt_chuyen.Size = new System.Drawing.Size(176, 27);
            this.txt_chuyen.TabIndex = 21;
            // 
            // txt_maVe
            // 
            this.txt_maVe.Location = new System.Drawing.Point(133, 43);
            this.txt_maVe.Name = "txt_maVe";
            this.txt_maVe.Size = new System.Drawing.Size(176, 27);
            this.txt_maVe.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Giờ";
            this.label11.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Chuyến";
            this.label10.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Mã vé";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_reload
            // 
            this.btn_reload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_reload.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_reload.BorderRadius = 45;
            this.btn_reload.BorderSize = 0;
            this.btn_reload.FlatAppearance.BorderSize = 0;
            this.btn_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_reload.ForeColor = System.Drawing.Color.Black;
            this.btn_reload.Image = global::QuanLyXeKhach.Properties.Resources.reload5;
            this.btn_reload.Location = new System.Drawing.Point(1065, 99);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(49, 49);
            this.btn_reload.TabIndex = 4;
            this.btn_reload.TextColor = System.Drawing.Color.Black;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_dangKyKH
            // 
            this.btn_dangKyKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_dangKyKH.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_dangKyKH.BorderRadius = 45;
            this.btn_dangKyKH.BorderSize = 0;
            this.btn_dangKyKH.FlatAppearance.BorderSize = 0;
            this.btn_dangKyKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangKyKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dangKyKH.ForeColor = System.Drawing.Color.Black;
            this.btn_dangKyKH.Location = new System.Drawing.Point(814, 98);
            this.btn_dangKyKH.Name = "btn_dangKyKH";
            this.btn_dangKyKH.Size = new System.Drawing.Size(229, 49);
            this.btn_dangKyKH.TabIndex = 4;
            this.btn_dangKyKH.Text = "Đăng ký khách hàng mới";
            this.btn_dangKyKH.TextColor = System.Drawing.Color.Black;
            this.btn_dangKyKH.UseVisualStyleBackColor = false;
            this.btn_dangKyKH.Click += new System.EventHandler(this.btn_dangKyKH_Click);
            // 
            // btn_huyVe
            // 
            this.btn_huyVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_huyVe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_huyVe.BorderRadius = 38;
            this.btn_huyVe.BorderSize = 0;
            this.btn_huyVe.FlatAppearance.BorderSize = 0;
            this.btn_huyVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_huyVe.ForeColor = System.Drawing.Color.Black;
            this.btn_huyVe.Location = new System.Drawing.Point(94, 198);
            this.btn_huyVe.Name = "btn_huyVe";
            this.btn_huyVe.Size = new System.Drawing.Size(151, 38);
            this.btn_huyVe.TabIndex = 4;
            this.btn_huyVe.Text = "Hủy vé";
            this.btn_huyVe.TextColor = System.Drawing.Color.Black;
            this.btn_huyVe.UseVisualStyleBackColor = false;
            this.btn_huyVe.Click += new System.EventHandler(this.btn_huyVe_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BorderRadius = 45;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(570, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(130, 49);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextColor = System.Drawing.Color.Black;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btn_xoaKH
            // 
            this.btn_xoaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_xoaKH.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_xoaKH.BorderRadius = 38;
            this.btn_xoaKH.BorderSize = 0;
            this.btn_xoaKH.FlatAppearance.BorderSize = 0;
            this.btn_xoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaKH.ForeColor = System.Drawing.Color.Black;
            this.btn_xoaKH.Location = new System.Drawing.Point(570, 198);
            this.btn_xoaKH.Name = "btn_xoaKH";
            this.btn_xoaKH.Size = new System.Drawing.Size(151, 38);
            this.btn_xoaKH.TabIndex = 4;
            this.btn_xoaKH.Text = "Xóa khách hàng";
            this.btn_xoaKH.TextColor = System.Drawing.Color.Black;
            this.btn_xoaKH.UseVisualStyleBackColor = false;
            this.btn_xoaKH.Click += new System.EventHandler(this.btn_xoaKH_Click);
            // 
            // btn_suaKH
            // 
            this.btn_suaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_suaKH.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_suaKH.BorderRadius = 38;
            this.btn_suaKH.BorderSize = 0;
            this.btn_suaKH.FlatAppearance.BorderSize = 0;
            this.btn_suaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaKH.ForeColor = System.Drawing.Color.Black;
            this.btn_suaKH.Location = new System.Drawing.Point(388, 200);
            this.btn_suaKH.Name = "btn_suaKH";
            this.btn_suaKH.Size = new System.Drawing.Size(151, 38);
            this.btn_suaKH.TabIndex = 4;
            this.btn_suaKH.Text = "Sửa thông tin";
            this.btn_suaKH.TextColor = System.Drawing.Color.Black;
            this.btn_suaKH.UseVisualStyleBackColor = false;
            this.btn_suaKH.Click += new System.EventHandler(this.btn_suaKH_Click);
            // 
            // UC_AD_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.btn_dangKyKH);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pl_TimKiemDichVu);
            this.Controls.Add(this.dgv_hoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_khachHang);
            this.Controls.Add(this.label1);
            this.Name = "UC_AD_KhachHang";
            this.Size = new System.Drawing.Size(1142, 749);
            this.Load += new System.EventHandler(this.UC_AD_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_khachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoaDon)).EndInit();
            this.pl_TimKiemDichVu.ResumeLayout(false);
            this.pl_TimKiemDichVu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_khachHang;
        private System.Windows.Forms.DataGridView dgv_hoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_maKH;
        private Bunifu.UI.WinForms.BunifuPanel pl_TimKiemDichVu;
        private System.Windows.Forms.TextBox txtTimDichVuNB;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private CustomButton btnTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maPhanQuyen;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_gioiTinh;
        private System.Windows.Forms.TextBox txt_hoTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomButton btn_xoaKH;
        private CustomButton btn_suaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maVe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_gio;
        private CustomButton btn_huyVe;
        private System.Windows.Forms.TextBox txt_chuyen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private CustomButton btn_dangKyKH;
        private CustomButton btn_reload;
    }
}
