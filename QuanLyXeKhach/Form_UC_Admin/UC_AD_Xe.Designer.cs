namespace QuanLyXeKhach.Form_UC_Admin
{
    partial class UC_AD_Xe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AD_Xe));
            this.txt_MauXe = new System.Windows.Forms.TextBox();
            this.txt_MaLoai = new System.Windows.Forms.TextBox();
            this.txt_bienSo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgv_xe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_soGhe1Hang = new System.Windows.Forms.TextBox();
            this.txt_tenLoaiXe = new System.Windows.Forms.TextBox();
            this.txt_soHangGhe = new System.Windows.Forms.TextBox();
            this.txt_maLoaiXe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pl_TimKiemDichVu = new Bunifu.UI.WinForms.BunifuPanel();
            this.dgv_loaiXe = new System.Windows.Forms.DataGridView();
            this.btn_reload = new QuanLyXeKhach.CustomButton();
            this.btn_xoaXe = new QuanLyXeKhach.CustomButton();
            this.btn_suaXe = new QuanLyXeKhach.CustomButton();
            this.btn_themXe = new QuanLyXeKhach.CustomButton();
            this.btn_xoaLoaiXe = new QuanLyXeKhach.CustomButton();
            this.btn_themLoaiXe = new QuanLyXeKhach.CustomButton();
            this.btn_suaLoaiXe = new QuanLyXeKhach.CustomButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xe)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiXe)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MauXe
            // 
            this.txt_MauXe.Location = new System.Drawing.Point(133, 149);
            this.txt_MauXe.Name = "txt_MauXe";
            this.txt_MauXe.Size = new System.Drawing.Size(200, 27);
            this.txt_MauXe.TabIndex = 21;
            // 
            // txt_MaLoai
            // 
            this.txt_MaLoai.Location = new System.Drawing.Point(133, 94);
            this.txt_MaLoai.Name = "txt_MaLoai";
            this.txt_MaLoai.Size = new System.Drawing.Size(200, 27);
            this.txt_MaLoai.TabIndex = 21;
            // 
            // txt_bienSo
            // 
            this.txt_bienSo.Location = new System.Drawing.Point(133, 43);
            this.txt_bienSo.Name = "txt_bienSo";
            this.txt_bienSo.Size = new System.Drawing.Size(200, 27);
            this.txt_bienSo.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Màu xe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Mã loại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Biển số xe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_MauXe);
            this.groupBox2.Controls.Add(this.btn_xoaXe);
            this.groupBox2.Controls.Add(this.btn_suaXe);
            this.groupBox2.Controls.Add(this.btn_themXe);
            this.groupBox2.Controls.Add(this.txt_MaLoai);
            this.groupBox2.Controls.Add(this.txt_bienSo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(742, 470);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 261);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin xe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Số ghế 1 hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tên loại xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Số hàng ghế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã loại xe";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgv_xe
            // 
            this.dgv_xe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_xe.BackgroundColor = System.Drawing.Color.White;
            this.dgv_xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_xe.Location = new System.Drawing.Point(742, 129);
            this.dgv_xe.Name = "dgv_xe";
            this.dgv_xe.RowHeadersWidth = 51;
            this.dgv_xe.RowTemplate.Height = 24;
            this.dgv_xe.Size = new System.Drawing.Size(372, 321);
            this.dgv_xe.TabIndex = 27;
            this.dgv_xe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_xe_CellClick);
            this.dgv_xe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_xe_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoaLoaiXe);
            this.groupBox1.Controls.Add(this.btn_themLoaiXe);
            this.groupBox1.Controls.Add(this.btn_suaLoaiXe);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_soGhe1Hang);
            this.groupBox1.Controls.Add(this.txt_tenLoaiXe);
            this.groupBox1.Controls.Add(this.txt_soHangGhe);
            this.groupBox1.Controls.Add(this.txt_maLoaiXe);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(28, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 261);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết loại xe";
            // 
            // txt_soGhe1Hang
            // 
            this.txt_soGhe1Hang.Location = new System.Drawing.Point(483, 138);
            this.txt_soGhe1Hang.Name = "txt_soGhe1Hang";
            this.txt_soGhe1Hang.Size = new System.Drawing.Size(196, 27);
            this.txt_soGhe1Hang.TabIndex = 21;
            // 
            // txt_tenLoaiXe
            // 
            this.txt_tenLoaiXe.Location = new System.Drawing.Point(483, 43);
            this.txt_tenLoaiXe.Name = "txt_tenLoaiXe";
            this.txt_tenLoaiXe.Size = new System.Drawing.Size(196, 27);
            this.txt_tenLoaiXe.TabIndex = 21;
            // 
            // txt_soHangGhe
            // 
            this.txt_soHangGhe.Location = new System.Drawing.Point(137, 138);
            this.txt_soHangGhe.Name = "txt_soHangGhe";
            this.txt_soHangGhe.Size = new System.Drawing.Size(196, 27);
            this.txt_soHangGhe.TabIndex = 21;
            // 
            // txt_maLoaiXe
            // 
            this.txt_maLoaiXe.Location = new System.Drawing.Point(137, 43);
            this.txt_maLoaiXe.Name = "txt_maLoaiXe";
            this.txt_maLoaiXe.Size = new System.Drawing.Size(196, 27);
            this.txt_maLoaiXe.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(463, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 46);
            this.label1.TabIndex = 24;
            this.label1.Text = "QUẢN LÝ XE";
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
            // pl_TimKiemDichVu
            // 
            this.pl_TimKiemDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pl_TimKiemDichVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_TimKiemDichVu.BackgroundImage")));
            this.pl_TimKiemDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_TimKiemDichVu.BorderColor = System.Drawing.Color.Black;
            this.pl_TimKiemDichVu.BorderRadius = 35;
            this.pl_TimKiemDichVu.BorderThickness = 1;
            this.pl_TimKiemDichVu.Location = new System.Drawing.Point(28, 82);
            this.pl_TimKiemDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.pl_TimKiemDichVu.Name = "pl_TimKiemDichVu";
            this.pl_TimKiemDichVu.ShowBorders = true;
            this.pl_TimKiemDichVu.Size = new System.Drawing.Size(1086, 28);
            this.pl_TimKiemDichVu.TabIndex = 28;
            // 
            // dgv_loaiXe
            // 
            this.dgv_loaiXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_loaiXe.BackgroundColor = System.Drawing.Color.White;
            this.dgv_loaiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaiXe.Location = new System.Drawing.Point(28, 129);
            this.dgv_loaiXe.Name = "dgv_loaiXe";
            this.dgv_loaiXe.RowHeadersWidth = 51;
            this.dgv_loaiXe.RowTemplate.Height = 24;
            this.dgv_loaiXe.Size = new System.Drawing.Size(698, 321);
            this.dgv_loaiXe.TabIndex = 31;
            this.dgv_loaiXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaiXe_CellClick);
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
            this.btn_reload.Location = new System.Drawing.Point(1065, 16);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(49, 49);
            this.btn_reload.TabIndex = 30;
            this.btn_reload.TextColor = System.Drawing.Color.Black;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_xoaXe
            // 
            this.btn_xoaXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_xoaXe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_xoaXe.BorderRadius = 38;
            this.btn_xoaXe.BorderSize = 0;
            this.btn_xoaXe.FlatAppearance.BorderSize = 0;
            this.btn_xoaXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaXe.ForeColor = System.Drawing.Color.Black;
            this.btn_xoaXe.Location = new System.Drawing.Point(249, 198);
            this.btn_xoaXe.Name = "btn_xoaXe";
            this.btn_xoaXe.Size = new System.Drawing.Size(84, 38);
            this.btn_xoaXe.TabIndex = 4;
            this.btn_xoaXe.Text = "Xóa";
            this.btn_xoaXe.TextColor = System.Drawing.Color.Black;
            this.btn_xoaXe.UseVisualStyleBackColor = false;
            this.btn_xoaXe.Click += new System.EventHandler(this.btn_xoaXe_Click_1);
            // 
            // btn_suaXe
            // 
            this.btn_suaXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_suaXe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_suaXe.BorderRadius = 38;
            this.btn_suaXe.BorderSize = 0;
            this.btn_suaXe.FlatAppearance.BorderSize = 0;
            this.btn_suaXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaXe.ForeColor = System.Drawing.Color.Black;
            this.btn_suaXe.Location = new System.Drawing.Point(143, 198);
            this.btn_suaXe.Name = "btn_suaXe";
            this.btn_suaXe.Size = new System.Drawing.Size(84, 38);
            this.btn_suaXe.TabIndex = 4;
            this.btn_suaXe.Text = "Sửa";
            this.btn_suaXe.TextColor = System.Drawing.Color.Black;
            this.btn_suaXe.UseVisualStyleBackColor = false;
            this.btn_suaXe.Click += new System.EventHandler(this.btn_suaXe_Click);
            // 
            // btn_themXe
            // 
            this.btn_themXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_themXe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_themXe.BorderRadius = 38;
            this.btn_themXe.BorderSize = 0;
            this.btn_themXe.FlatAppearance.BorderSize = 0;
            this.btn_themXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themXe.ForeColor = System.Drawing.Color.Black;
            this.btn_themXe.Location = new System.Drawing.Point(27, 198);
            this.btn_themXe.Name = "btn_themXe";
            this.btn_themXe.Size = new System.Drawing.Size(84, 38);
            this.btn_themXe.TabIndex = 4;
            this.btn_themXe.Text = "Thêm ";
            this.btn_themXe.TextColor = System.Drawing.Color.Black;
            this.btn_themXe.UseVisualStyleBackColor = false;
            this.btn_themXe.Click += new System.EventHandler(this.btn_themXe_Click_1);
            // 
            // btn_xoaLoaiXe
            // 
            this.btn_xoaLoaiXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_xoaLoaiXe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_xoaLoaiXe.BorderRadius = 38;
            this.btn_xoaLoaiXe.BorderSize = 0;
            this.btn_xoaLoaiXe.FlatAppearance.BorderSize = 0;
            this.btn_xoaLoaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaLoaiXe.ForeColor = System.Drawing.Color.Black;
            this.btn_xoaLoaiXe.Location = new System.Drawing.Point(467, 198);
            this.btn_xoaLoaiXe.Name = "btn_xoaLoaiXe";
            this.btn_xoaLoaiXe.Size = new System.Drawing.Size(151, 38);
            this.btn_xoaLoaiXe.TabIndex = 4;
            this.btn_xoaLoaiXe.Text = "Xóa loại xe";
            this.btn_xoaLoaiXe.TextColor = System.Drawing.Color.Black;
            this.btn_xoaLoaiXe.UseVisualStyleBackColor = false;
            this.btn_xoaLoaiXe.Click += new System.EventHandler(this.btn_xoaLoaiXe_Click);
            // 
            // btn_themLoaiXe
            // 
            this.btn_themLoaiXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_themLoaiXe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_themLoaiXe.BorderRadius = 38;
            this.btn_themLoaiXe.BorderSize = 0;
            this.btn_themLoaiXe.FlatAppearance.BorderSize = 0;
            this.btn_themLoaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themLoaiXe.ForeColor = System.Drawing.Color.Black;
            this.btn_themLoaiXe.Location = new System.Drawing.Point(78, 198);
            this.btn_themLoaiXe.Name = "btn_themLoaiXe";
            this.btn_themLoaiXe.Size = new System.Drawing.Size(151, 38);
            this.btn_themLoaiXe.TabIndex = 4;
            this.btn_themLoaiXe.Text = "Thêm loại xe";
            this.btn_themLoaiXe.TextColor = System.Drawing.Color.Black;
            this.btn_themLoaiXe.UseVisualStyleBackColor = false;
            this.btn_themLoaiXe.Click += new System.EventHandler(this.btn_themLoaiXe_Click);
            // 
            // btn_suaLoaiXe
            // 
            this.btn_suaLoaiXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_suaLoaiXe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_suaLoaiXe.BorderRadius = 38;
            this.btn_suaLoaiXe.BorderSize = 0;
            this.btn_suaLoaiXe.FlatAppearance.BorderSize = 0;
            this.btn_suaLoaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaLoaiXe.ForeColor = System.Drawing.Color.Black;
            this.btn_suaLoaiXe.Location = new System.Drawing.Point(274, 198);
            this.btn_suaLoaiXe.Name = "btn_suaLoaiXe";
            this.btn_suaLoaiXe.Size = new System.Drawing.Size(151, 38);
            this.btn_suaLoaiXe.TabIndex = 4;
            this.btn_suaLoaiXe.Text = "Sửa thông tin";
            this.btn_suaLoaiXe.TextColor = System.Drawing.Color.Black;
            this.btn_suaLoaiXe.UseVisualStyleBackColor = false;
            this.btn_suaLoaiXe.Click += new System.EventHandler(this.btn_suaLoaiXe_Click);
            // 
            // UC_AD_Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_loaiXe);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgv_xe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pl_TimKiemDichVu);
            this.Name = "UC_AD_Xe";
            this.Size = new System.Drawing.Size(1142, 749);
            this.Load += new System.EventHandler(this.UC_AD_Xe_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_xe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MauXe;
        private System.Windows.Forms.TextBox txt_MaLoai;
        private System.Windows.Forms.TextBox txt_bienSo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomButton btn_xoaLoaiXe;
        private CustomButton btn_suaLoaiXe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dgv_xe;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomButton btn_themLoaiXe;
        private System.Windows.Forms.TextBox txt_soGhe1Hang;
        private System.Windows.Forms.TextBox txt_tenLoaiXe;
        private System.Windows.Forms.TextBox txt_soHangGhe;
        private System.Windows.Forms.TextBox txt_maLoaiXe;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel pl_TimKiemDichVu;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private CustomButton btn_xoaXe;
        private CustomButton btn_suaXe;
        private CustomButton btn_themXe;
        private CustomButton btn_reload;
        private System.Windows.Forms.DataGridView dgv_loaiXe;
    }
}
