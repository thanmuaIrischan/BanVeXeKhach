namespace QuanLyXeKhach.Form_UC_KhachHang
{
    partial class UC_KH_GioHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_KH_GioHang));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.DTGV_danhsachvedat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.DTGV_dichvudat = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaChuyenXe = new System.Windows.Forms.TextBox();
            this.txtTrangThaiThanhToan = new System.Windows.Forms.TextBox();
            this.txtHinhThucThanhToan = new System.Windows.Forms.TextBox();
            this.txtMaGhe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaVe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pl_XemChiTietDichVu = new System.Windows.Forms.Panel();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtMaDichVu = new System.Windows.Forms.TextBox();
            this.txtGioKhoiHanh = new System.Windows.Forms.TextBox();
            this.txtNgayKhoiHanh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnHuyDichVu = new QuanLyXeKhach.CustomButton();
            this.btnHuyVe = new QuanLyXeKhach.CustomButton();
            this.btnXemChiTietVe = new QuanLyXeKhach.CustomButton();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_danhsachvedat)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_dichvudat)).BeginInit();
            this.pl_XemChiTietDichVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel1.BorderRadius = 35;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Location = new System.Drawing.Point(23, 99);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1068, 72);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH VÉ CÓ TRONG GIỎ ";
            // 
            // DTGV_danhsachvedat
            // 
            this.DTGV_danhsachvedat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_danhsachvedat.Location = new System.Drawing.Point(34, 191);
            this.DTGV_danhsachvedat.Name = "DTGV_danhsachvedat";
            this.DTGV_danhsachvedat.RowHeadersWidth = 51;
            this.DTGV_danhsachvedat.RowTemplate.Height = 24;
            this.DTGV_danhsachvedat.Size = new System.Drawing.Size(1041, 320);
            this.DTGV_danhsachvedat.TabIndex = 1;
            this.DTGV_danhsachvedat.Click += new System.EventHandler(this.DTGV_danhsachvedat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "DANH SÁCH DỊCH VỤ ĐÃ ĐĂNG KÍ";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Black;
            this.bunifuPanel2.BorderRadius = 35;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.label2);
            this.bunifuPanel2.Location = new System.Drawing.Point(611, 590);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(489, 72);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // DTGV_dichvudat
            // 
            this.DTGV_dichvudat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV_dichvudat.Location = new System.Drawing.Point(611, 694);
            this.DTGV_dichvudat.Name = "DTGV_dichvudat";
            this.DTGV_dichvudat.RowHeadersWidth = 51;
            this.DTGV_dichvudat.RowTemplate.Height = 24;
            this.DTGV_dichvudat.Size = new System.Drawing.Size(480, 196);
            this.DTGV_dichvudat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(469, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "GIỎ HÀNG ";
            // 
            // txtMaChuyenXe
            // 
            this.txtMaChuyenXe.Location = new System.Drawing.Point(204, 129);
            this.txtMaChuyenXe.Name = "txtMaChuyenXe";
            this.txtMaChuyenXe.Size = new System.Drawing.Size(249, 20);
            this.txtMaChuyenXe.TabIndex = 12;
            // 
            // txtTrangThaiThanhToan
            // 
            this.txtTrangThaiThanhToan.Location = new System.Drawing.Point(204, 263);
            this.txtTrangThaiThanhToan.Name = "txtTrangThaiThanhToan";
            this.txtTrangThaiThanhToan.Size = new System.Drawing.Size(249, 20);
            this.txtTrangThaiThanhToan.TabIndex = 11;
            // 
            // txtHinhThucThanhToan
            // 
            this.txtHinhThucThanhToan.Location = new System.Drawing.Point(204, 221);
            this.txtHinhThucThanhToan.Name = "txtHinhThucThanhToan";
            this.txtHinhThucThanhToan.Size = new System.Drawing.Size(249, 20);
            this.txtHinhThucThanhToan.TabIndex = 10;
            // 
            // txtMaGhe
            // 
            this.txtMaGhe.Location = new System.Drawing.Point(204, 175);
            this.txtMaGhe.Name = "txtMaGhe";
            this.txtMaGhe.Size = new System.Drawing.Size(249, 20);
            this.txtMaGhe.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã ghế:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hình thức thanh toán:";
            // 
            // txtMaVe
            // 
            this.txtMaVe.Location = new System.Drawing.Point(204, 79);
            this.txtMaVe.Name = "txtMaVe";
            this.txtMaVe.Size = new System.Drawing.Size(249, 20);
            this.txtMaVe.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã vé:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã chuyến xe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 19);
            this.label8.TabIndex = 4;
            this.label8.Text = "Trạng thái thanh toán:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Chi tiết dịch vụ";
            // 
            // pl_XemChiTietDichVu
            // 
            this.pl_XemChiTietDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pl_XemChiTietDichVu.Controls.Add(this.txtThanhTien);
            this.pl_XemChiTietDichVu.Controls.Add(this.txtMaDichVu);
            this.pl_XemChiTietDichVu.Controls.Add(this.txtGioKhoiHanh);
            this.pl_XemChiTietDichVu.Controls.Add(this.txtNgayKhoiHanh);
            this.pl_XemChiTietDichVu.Controls.Add(this.label10);
            this.pl_XemChiTietDichVu.Controls.Add(this.label11);
            this.pl_XemChiTietDichVu.Controls.Add(this.txtGiaVe);
            this.pl_XemChiTietDichVu.Controls.Add(this.label12);
            this.pl_XemChiTietDichVu.Controls.Add(this.label13);
            this.pl_XemChiTietDichVu.Controls.Add(this.label14);
            this.pl_XemChiTietDichVu.Controls.Add(this.txtMaChuyenXe);
            this.pl_XemChiTietDichVu.Controls.Add(this.txtTrangThaiThanhToan);
            this.pl_XemChiTietDichVu.Controls.Add(this.txtHinhThucThanhToan);
            this.pl_XemChiTietDichVu.Controls.Add(this.txtMaGhe);
            this.pl_XemChiTietDichVu.Controls.Add(this.label7);
            this.pl_XemChiTietDichVu.Controls.Add(this.label6);
            this.pl_XemChiTietDichVu.Controls.Add(this.txtMaVe);
            this.pl_XemChiTietDichVu.Controls.Add(this.label5);
            this.pl_XemChiTietDichVu.Controls.Add(this.label4);
            this.pl_XemChiTietDichVu.Controls.Add(this.label8);
            this.pl_XemChiTietDichVu.Controls.Add(this.label9);
            this.pl_XemChiTietDichVu.Location = new System.Drawing.Point(66, 590);
            this.pl_XemChiTietDichVu.Name = "pl_XemChiTietDichVu";
            this.pl_XemChiTietDichVu.Size = new System.Drawing.Size(498, 555);
            this.pl_XemChiTietDichVu.TabIndex = 13;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(204, 353);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(249, 20);
            this.txtThanhTien.TabIndex = 22;
            // 
            // txtMaDichVu
            // 
            this.txtMaDichVu.Location = new System.Drawing.Point(204, 487);
            this.txtMaDichVu.Name = "txtMaDichVu";
            this.txtMaDichVu.Size = new System.Drawing.Size(249, 20);
            this.txtMaDichVu.TabIndex = 21;
            // 
            // txtGioKhoiHanh
            // 
            this.txtGioKhoiHanh.Location = new System.Drawing.Point(204, 445);
            this.txtGioKhoiHanh.Name = "txtGioKhoiHanh";
            this.txtGioKhoiHanh.Size = new System.Drawing.Size(249, 20);
            this.txtGioKhoiHanh.TabIndex = 20;
            // 
            // txtNgayKhoiHanh
            // 
            this.txtNgayKhoiHanh.Location = new System.Drawing.Point(204, 399);
            this.txtNgayKhoiHanh.Name = "txtNgayKhoiHanh";
            this.txtNgayKhoiHanh.Size = new System.Drawing.Size(249, 20);
            this.txtNgayKhoiHanh.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ngày khởi hành:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "Giờ khởi hành:";
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(204, 303);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(249, 20);
            this.txtGiaVe.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "Giá vé:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 19);
            this.label13.TabIndex = 14;
            this.label13.Text = "Thành tiền:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 486);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "Mã dịch vụ:";
            // 
            // btnHuyDichVu
            // 
            this.btnHuyDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuyDichVu.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuyDichVu.BorderRadius = 46;
            this.btnHuyDichVu.BorderSize = 0;
            this.btnHuyDichVu.FlatAppearance.BorderSize = 0;
            this.btnHuyDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDichVu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDichVu.ForeColor = System.Drawing.Color.Black;
            this.btnHuyDichVu.Location = new System.Drawing.Point(759, 914);
            this.btnHuyDichVu.Name = "btnHuyDichVu";
            this.btnHuyDichVu.Size = new System.Drawing.Size(200, 49);
            this.btnHuyDichVu.TabIndex = 6;
            this.btnHuyDichVu.Text = "Hủy dịch vụ";
            this.btnHuyDichVu.TextColor = System.Drawing.Color.Black;
            this.btnHuyDichVu.UseVisualStyleBackColor = false;
            this.btnHuyDichVu.Click += new System.EventHandler(this.btnHuyDichVu_Click);
            // 
            // btnHuyVe
            // 
            this.btnHuyVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuyVe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuyVe.BorderRadius = 46;
            this.btnHuyVe.BorderSize = 0;
            this.btnHuyVe.FlatAppearance.BorderSize = 0;
            this.btnHuyVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyVe.ForeColor = System.Drawing.Color.Black;
            this.btnHuyVe.Location = new System.Drawing.Point(751, 517);
            this.btnHuyVe.Name = "btnHuyVe";
            this.btnHuyVe.Size = new System.Drawing.Size(208, 49);
            this.btnHuyVe.TabIndex = 3;
            this.btnHuyVe.Text = "Hủy vé";
            this.btnHuyVe.TextColor = System.Drawing.Color.Black;
            this.btnHuyVe.UseVisualStyleBackColor = false;
            this.btnHuyVe.Click += new System.EventHandler(this.btnHuyVe_Click);
            // 
            // btnXemChiTietVe
            // 
            this.btnXemChiTietVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXemChiTietVe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnXemChiTietVe.BorderRadius = 46;
            this.btnXemChiTietVe.BorderSize = 0;
            this.btnXemChiTietVe.FlatAppearance.BorderSize = 0;
            this.btnXemChiTietVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTietVe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTietVe.ForeColor = System.Drawing.Color.Black;
            this.btnXemChiTietVe.Location = new System.Drawing.Point(142, 517);
            this.btnXemChiTietVe.Name = "btnXemChiTietVe";
            this.btnXemChiTietVe.Size = new System.Drawing.Size(200, 49);
            this.btnXemChiTietVe.TabIndex = 2;
            this.btnXemChiTietVe.Text = "Xem chi tiết vé";
            this.btnXemChiTietVe.TextColor = System.Drawing.Color.Black;
            this.btnXemChiTietVe.UseVisualStyleBackColor = false;
            this.btnXemChiTietVe.Click += new System.EventHandler(this.btnXemChiTietVe_Click);
            // 
            // UC_KH_GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pl_XemChiTietDichVu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHuyDichVu);
            this.Controls.Add(this.DTGV_dichvudat);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.btnHuyVe);
            this.Controls.Add(this.btnXemChiTietVe);
            this.Controls.Add(this.DTGV_danhsachvedat);
            this.Controls.Add(this.bunifuPanel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_KH_GioHang";
            this.Size = new System.Drawing.Size(1131, 1180);
            this.Load += new System.EventHandler(this.UC_KH_GioHang_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_danhsachvedat)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV_dichvudat)).EndInit();
            this.pl_XemChiTietDichVu.ResumeLayout(false);
            this.pl_XemChiTietDichVu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private CustomButton btnHuyVe;
        private CustomButton btnXemChiTietVe;
        private System.Windows.Forms.DataGridView DTGV_danhsachvedat;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Label label2;
        private CustomButton btnHuyDichVu;
        private System.Windows.Forms.DataGridView DTGV_dichvudat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pl_XemChiTietDichVu;
        private System.Windows.Forms.TextBox txtMaChuyenXe;
        private System.Windows.Forms.TextBox txtTrangThaiThanhToan;
        private System.Windows.Forms.TextBox txtHinhThucThanhToan;
        private System.Windows.Forms.TextBox txtMaGhe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaVe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtMaDichVu;
        private System.Windows.Forms.TextBox txtGioKhoiHanh;
        private System.Windows.Forms.TextBox txtNgayKhoiHanh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
