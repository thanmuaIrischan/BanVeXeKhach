namespace QuanLyXeKhach.Form_UC_Admin
{
    partial class UC_AD_DoiTac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AD_DoiTac));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgv_doiTac = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_QuangCao = new System.Windows.Forms.DataGridView();
            this.dgv_DichVu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoaDT = new QuanLyXeKhach.CustomButton();
            this.btn_suaĐT = new QuanLyXeKhach.CustomButton();
            this.btn_themĐT = new QuanLyXeKhach.CustomButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_maPQ = new System.Windows.Forms.TextBox();
            this.txt_diaChi = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_daiDien = new System.Windows.Forms.TextBox();
            this.txt_HinhThuc = new System.Windows.Forms.TextBox();
            this.txt_TenDoiTac = new System.Windows.Forms.TextBox();
            this.txt_maDoiTac = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_tuChoiQC = new QuanLyXeKhach.CustomButton();
            this.btn_DuyetQC = new QuanLyXeKhach.CustomButton();
            this.btn_timQC = new QuanLyXeKhach.CustomButton();
            this.pl_TimKiemDichVu = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_reload = new QuanLyXeKhach.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doiTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuangCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dgv_doiTac
            // 
            this.dgv_doiTac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_doiTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doiTac.Location = new System.Drawing.Point(29, 119);
            this.dgv_doiTac.Name = "dgv_doiTac";
            this.dgv_doiTac.RowHeadersWidth = 51;
            this.dgv_doiTac.RowTemplate.Height = 24;
            this.dgv_doiTac.Size = new System.Drawing.Size(1087, 183);
            this.dgv_doiTac.TabIndex = 26;
            this.dgv_doiTac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_doiTac_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(412, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 46);
            this.label1.TabIndex = 25;
            this.label1.Text = "QUẢN LÝ ĐỐI TÁC";
            // 
            // dgv_QuangCao
            // 
            this.dgv_QuangCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuangCao.Location = new System.Drawing.Point(29, 318);
            this.dgv_QuangCao.Name = "dgv_QuangCao";
            this.dgv_QuangCao.RowHeadersWidth = 51;
            this.dgv_QuangCao.RowTemplate.Height = 24;
            this.dgv_QuangCao.Size = new System.Drawing.Size(687, 156);
            this.dgv_QuangCao.TabIndex = 30;
            this.dgv_QuangCao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QuangCao_CellClick);
            // 
            // dgv_DichVu
            // 
            this.dgv_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DichVu.Location = new System.Drawing.Point(732, 318);
            this.dgv_DichVu.Name = "dgv_DichVu";
            this.dgv_DichVu.RowHeadersWidth = 51;
            this.dgv_DichVu.RowTemplate.Height = 24;
            this.dgv_DichVu.Size = new System.Drawing.Size(384, 156);
            this.dgv_DichVu.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoaDT);
            this.groupBox1.Controls.Add(this.btn_suaĐT);
            this.groupBox1.Controls.Add(this.btn_themĐT);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_maPQ);
            this.groupBox1.Controls.Add(this.txt_diaChi);
            this.groupBox1.Controls.Add(this.txt_sdt);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_daiDien);
            this.groupBox1.Controls.Add(this.txt_HinhThuc);
            this.groupBox1.Controls.Add(this.txt_TenDoiTac);
            this.groupBox1.Controls.Add(this.txt_maDoiTac);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(29, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 248);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết đối tác";
            // 
            // btn_xoaDT
            // 
            this.btn_xoaDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_xoaDT.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_xoaDT.BorderRadius = 38;
            this.btn_xoaDT.BorderSize = 0;
            this.btn_xoaDT.FlatAppearance.BorderSize = 0;
            this.btn_xoaDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoaDT.ForeColor = System.Drawing.Color.Black;
            this.btn_xoaDT.Location = new System.Drawing.Point(604, 175);
            this.btn_xoaDT.Name = "btn_xoaDT";
            this.btn_xoaDT.Size = new System.Drawing.Size(151, 38);
            this.btn_xoaDT.TabIndex = 4;
            this.btn_xoaDT.Text = "Xóa đối tác";
            this.btn_xoaDT.TextColor = System.Drawing.Color.Black;
            this.btn_xoaDT.UseVisualStyleBackColor = false;
            this.btn_xoaDT.Click += new System.EventHandler(this.btn_xoaDT_Click_1);
            // 
            // btn_suaĐT
            // 
            this.btn_suaĐT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_suaĐT.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_suaĐT.BorderRadius = 38;
            this.btn_suaĐT.BorderSize = 0;
            this.btn_suaĐT.FlatAppearance.BorderSize = 0;
            this.btn_suaĐT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaĐT.ForeColor = System.Drawing.Color.Black;
            this.btn_suaĐT.Location = new System.Drawing.Point(604, 121);
            this.btn_suaĐT.Name = "btn_suaĐT";
            this.btn_suaĐT.Size = new System.Drawing.Size(151, 38);
            this.btn_suaĐT.TabIndex = 4;
            this.btn_suaĐT.Text = "Sửa thông tin";
            this.btn_suaĐT.TextColor = System.Drawing.Color.Black;
            this.btn_suaĐT.UseVisualStyleBackColor = false;
            this.btn_suaĐT.Click += new System.EventHandler(this.btn_suaĐT_Click_1);
            // 
            // btn_themĐT
            // 
            this.btn_themĐT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_themĐT.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_themĐT.BorderRadius = 38;
            this.btn_themĐT.BorderSize = 0;
            this.btn_themĐT.FlatAppearance.BorderSize = 0;
            this.btn_themĐT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themĐT.ForeColor = System.Drawing.Color.Black;
            this.btn_themĐT.Location = new System.Drawing.Point(604, 64);
            this.btn_themĐT.Name = "btn_themĐT";
            this.btn_themĐT.Size = new System.Drawing.Size(151, 38);
            this.btn_themĐT.TabIndex = 4;
            this.btn_themĐT.Text = "Thêm đối tác";
            this.btn_themĐT.TextColor = System.Drawing.Color.Black;
            this.btn_themĐT.UseVisualStyleBackColor = false;
            this.btn_themĐT.Click += new System.EventHandler(this.btn_themĐT_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Mã phân quyền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "SĐT";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Đại diện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hình thức";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên đối tác";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã đối tác";
            // 
            // txt_maPQ
            // 
            this.txt_maPQ.Location = new System.Drawing.Point(463, 200);
            this.txt_maPQ.Name = "txt_maPQ";
            this.txt_maPQ.Size = new System.Drawing.Size(124, 27);
            this.txt_maPQ.TabIndex = 21;
            // 
            // txt_diaChi
            // 
            this.txt_diaChi.Location = new System.Drawing.Point(406, 149);
            this.txt_diaChi.Name = "txt_diaChi";
            this.txt_diaChi.Size = new System.Drawing.Size(181, 27);
            this.txt_diaChi.TabIndex = 21;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(406, 94);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(181, 27);
            this.txt_sdt.TabIndex = 21;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(406, 43);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(181, 27);
            this.txt_email.TabIndex = 21;
            // 
            // txt_daiDien
            // 
            this.txt_daiDien.Location = new System.Drawing.Point(127, 200);
            this.txt_daiDien.Name = "txt_daiDien";
            this.txt_daiDien.Size = new System.Drawing.Size(157, 27);
            this.txt_daiDien.TabIndex = 21;
            // 
            // txt_HinhThuc
            // 
            this.txt_HinhThuc.Location = new System.Drawing.Point(127, 149);
            this.txt_HinhThuc.Name = "txt_HinhThuc";
            this.txt_HinhThuc.Size = new System.Drawing.Size(157, 27);
            this.txt_HinhThuc.TabIndex = 21;
            // 
            // txt_TenDoiTac
            // 
            this.txt_TenDoiTac.Location = new System.Drawing.Point(127, 94);
            this.txt_TenDoiTac.Name = "txt_TenDoiTac";
            this.txt_TenDoiTac.Size = new System.Drawing.Size(157, 27);
            this.txt_TenDoiTac.TabIndex = 21;
            // 
            // txt_maDoiTac
            // 
            this.txt_maDoiTac.Location = new System.Drawing.Point(127, 43);
            this.txt_maDoiTac.Name = "txt_maDoiTac";
            this.txt_maDoiTac.Size = new System.Drawing.Size(157, 27);
            this.txt_maDoiTac.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_tuChoiQC);
            this.groupBox2.Controls.Add(this.btn_DuyetQC);
            this.groupBox2.Controls.Add(this.btn_timQC);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(813, 488);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 248);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyệt quảng cáo";
            // 
            // btn_tuChoiQC
            // 
            this.btn_tuChoiQC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_tuChoiQC.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_tuChoiQC.BorderRadius = 38;
            this.btn_tuChoiQC.BorderSize = 0;
            this.btn_tuChoiQC.FlatAppearance.BorderSize = 0;
            this.btn_tuChoiQC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tuChoiQC.ForeColor = System.Drawing.Color.Black;
            this.btn_tuChoiQC.Location = new System.Drawing.Point(52, 64);
            this.btn_tuChoiQC.Name = "btn_tuChoiQC";
            this.btn_tuChoiQC.Size = new System.Drawing.Size(206, 38);
            this.btn_tuChoiQC.TabIndex = 4;
            this.btn_tuChoiQC.Text = "Quảng cáo đã duyệt";
            this.btn_tuChoiQC.TextColor = System.Drawing.Color.Black;
            this.btn_tuChoiQC.UseVisualStyleBackColor = false;
            this.btn_tuChoiQC.Click += new System.EventHandler(this.btn_tuChoiQC_Click);
            // 
            // btn_DuyetQC
            // 
            this.btn_DuyetQC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_DuyetQC.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_DuyetQC.BorderRadius = 38;
            this.btn_DuyetQC.BorderSize = 0;
            this.btn_DuyetQC.FlatAppearance.BorderSize = 0;
            this.btn_DuyetQC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DuyetQC.ForeColor = System.Drawing.Color.Black;
            this.btn_DuyetQC.Location = new System.Drawing.Point(73, 175);
            this.btn_DuyetQC.Name = "btn_DuyetQC";
            this.btn_DuyetQC.Size = new System.Drawing.Size(168, 38);
            this.btn_DuyetQC.TabIndex = 4;
            this.btn_DuyetQC.Text = "Duyệt quảng cáo";
            this.btn_DuyetQC.TextColor = System.Drawing.Color.Black;
            this.btn_DuyetQC.UseVisualStyleBackColor = false;
            this.btn_DuyetQC.Click += new System.EventHandler(this.btn_DuyetQC_Click);
            // 
            // btn_timQC
            // 
            this.btn_timQC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_timQC.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_timQC.BorderRadius = 38;
            this.btn_timQC.BorderSize = 0;
            this.btn_timQC.FlatAppearance.BorderSize = 0;
            this.btn_timQC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timQC.ForeColor = System.Drawing.Color.Black;
            this.btn_timQC.Location = new System.Drawing.Point(28, 121);
            this.btn_timQC.Name = "btn_timQC";
            this.btn_timQC.Size = new System.Drawing.Size(251, 38);
            this.btn_timQC.TabIndex = 4;
            this.btn_timQC.Text = "Quảng cáo đang chờ duyệt";
            this.btn_timQC.TextColor = System.Drawing.Color.Black;
            this.btn_timQC.UseVisualStyleBackColor = false;
            this.btn_timQC.Click += new System.EventHandler(this.btn_timQC_Click);
            // 
            // pl_TimKiemDichVu
            // 
            this.pl_TimKiemDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pl_TimKiemDichVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_TimKiemDichVu.BackgroundImage")));
            this.pl_TimKiemDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_TimKiemDichVu.BorderColor = System.Drawing.Color.Black;
            this.pl_TimKiemDichVu.BorderRadius = 35;
            this.pl_TimKiemDichVu.BorderThickness = 1;
            this.pl_TimKiemDichVu.Location = new System.Drawing.Point(29, 84);
            this.pl_TimKiemDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.pl_TimKiemDichVu.Name = "pl_TimKiemDichVu";
            this.pl_TimKiemDichVu.ShowBorders = true;
            this.pl_TimKiemDichVu.Size = new System.Drawing.Size(1087, 28);
            this.pl_TimKiemDichVu.TabIndex = 29;
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
            this.btn_reload.Location = new System.Drawing.Point(1067, 18);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(49, 49);
            this.btn_reload.TabIndex = 33;
            this.btn_reload.TextColor = System.Drawing.Color.Black;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click_1);
            // 
            // UC_AD_DoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_DichVu);
            this.Controls.Add(this.dgv_QuangCao);
            this.Controls.Add(this.pl_TimKiemDichVu);
            this.Controls.Add(this.dgv_doiTac);
            this.Controls.Add(this.label1);
            this.Name = "UC_AD_DoiTac";
            this.Size = new System.Drawing.Size(1142, 749);
            this.Load += new System.EventHandler(this.UC_AD_DoiTac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doiTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuangCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridView dgv_doiTac;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel pl_TimKiemDichVu;
        private System.Windows.Forms.DataGridView dgv_DichVu;
        private System.Windows.Forms.DataGridView dgv_QuangCao;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomButton btn_xoaDT;
        private CustomButton btn_suaĐT;
        private CustomButton btn_themĐT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maPQ;
        private System.Windows.Forms.TextBox txt_diaChi;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_daiDien;
        private System.Windows.Forms.TextBox txt_HinhThuc;
        private System.Windows.Forms.TextBox txt_TenDoiTac;
        private System.Windows.Forms.TextBox txt_maDoiTac;
        private System.Windows.Forms.GroupBox groupBox2;
        private CustomButton btn_DuyetQC;
        private CustomButton btn_timQC;
        private CustomButton btn_reload;
        private CustomButton btn_tuChoiQC;
    }
}
