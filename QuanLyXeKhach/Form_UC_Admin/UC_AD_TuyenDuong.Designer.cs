namespace QuanLyXeKhach.Form_UC_Admin
{
    partial class UC_AD_TuyenDuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AD_TuyenDuong));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tuyenCuoi = new System.Windows.Forms.TextBox();
            this.txt_khoangCach = new System.Windows.Forms.TextBox();
            this.txt_tuyenDau = new System.Windows.Forms.TextBox();
            this.txt_maTuyen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new QuanLyXeKhach.CustomButton();
            this.btn_sua = new QuanLyXeKhach.CustomButton();
            this.btn_them = new QuanLyXeKhach.CustomButton();
            this.txt_tenTuyen = new System.Windows.Forms.TextBox();
            this.dgv_tuyenDuong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pl_TimKiemDichVu = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_reload = new QuanLyXeKhach.CustomButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tuyenDuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tuyến cuối";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tên tuyến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Khoảng cách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tuyến đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã tuyến";
            // 
            // txt_tuyenCuoi
            // 
            this.txt_tuyenCuoi.Location = new System.Drawing.Point(511, 94);
            this.txt_tuyenCuoi.Name = "txt_tuyenCuoi";
            this.txt_tuyenCuoi.Size = new System.Drawing.Size(169, 27);
            this.txt_tuyenCuoi.TabIndex = 21;
            // 
            // txt_khoangCach
            // 
            this.txt_khoangCach.Location = new System.Drawing.Point(511, 149);
            this.txt_khoangCach.Name = "txt_khoangCach";
            this.txt_khoangCach.Size = new System.Drawing.Size(169, 27);
            this.txt_khoangCach.TabIndex = 21;
            // 
            // txt_tuyenDau
            // 
            this.txt_tuyenDau.Location = new System.Drawing.Point(165, 94);
            this.txt_tuyenDau.Name = "txt_tuyenDau";
            this.txt_tuyenDau.Size = new System.Drawing.Size(157, 27);
            this.txt_tuyenDau.TabIndex = 21;
            // 
            // txt_maTuyen
            // 
            this.txt_maTuyen.Location = new System.Drawing.Point(165, 43);
            this.txt_maTuyen.Name = "txt_maTuyen";
            this.txt_maTuyen.Size = new System.Drawing.Size(157, 27);
            this.txt_maTuyen.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_sua);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_tuyenCuoi);
            this.groupBox1.Controls.Add(this.txt_tenTuyen);
            this.groupBox1.Controls.Add(this.txt_khoangCach);
            this.groupBox1.Controls.Add(this.txt_tuyenDau);
            this.groupBox1.Controls.Add(this.txt_maTuyen);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(227, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 264);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết tuyến đường";
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_xoa.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_xoa.BorderRadius = 38;
            this.btn_xoa.BorderSize = 0;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(511, 206);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(168, 38);
            this.btn_xoa.TabIndex = 4;
            this.btn_xoa.Text = "Xóa tuyến đường";
            this.btn_xoa.TextColor = System.Drawing.Color.Black;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_sua.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_sua.BorderRadius = 38;
            this.btn_sua.BorderSize = 0;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(287, 206);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(171, 38);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa tuyến đường";
            this.btn_sua.TextColor = System.Drawing.Color.Black;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_them.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_them.BorderRadius = 38;
            this.btn_them.BorderSize = 0;
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(60, 206);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(170, 38);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm tuyến đường";
            this.btn_them.TextColor = System.Drawing.Color.Black;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_tenTuyen
            // 
            this.txt_tenTuyen.Location = new System.Drawing.Point(511, 43);
            this.txt_tenTuyen.Name = "txt_tenTuyen";
            this.txt_tenTuyen.Size = new System.Drawing.Size(169, 27);
            this.txt_tenTuyen.TabIndex = 21;
            // 
            // dgv_tuyenDuong
            // 
            this.dgv_tuyenDuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tuyenDuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tuyenDuong.Location = new System.Drawing.Point(227, 131);
            this.dgv_tuyenDuong.Name = "dgv_tuyenDuong";
            this.dgv_tuyenDuong.RowHeadersWidth = 51;
            this.dgv_tuyenDuong.RowTemplate.Height = 24;
            this.dgv_tuyenDuong.Size = new System.Drawing.Size(766, 262);
            this.dgv_tuyenDuong.TabIndex = 35;
            this.dgv_tuyenDuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tuyenDuong_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(371, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 46);
            this.label1.TabIndex = 34;
            this.label1.Text = "QUẢN LÝ TUYẾN ĐƯỜNG";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pl_TimKiemDichVu
            // 
            this.pl_TimKiemDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pl_TimKiemDichVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_TimKiemDichVu.BackgroundImage")));
            this.pl_TimKiemDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_TimKiemDichVu.BorderColor = System.Drawing.Color.Black;
            this.pl_TimKiemDichVu.BorderRadius = 35;
            this.pl_TimKiemDichVu.BorderThickness = 1;
            this.pl_TimKiemDichVu.Location = new System.Drawing.Point(227, 81);
            this.pl_TimKiemDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.pl_TimKiemDichVu.Name = "pl_TimKiemDichVu";
            this.pl_TimKiemDichVu.ShowBorders = true;
            this.pl_TimKiemDichVu.Size = new System.Drawing.Size(766, 28);
            this.pl_TimKiemDichVu.TabIndex = 36;
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
            this.btn_reload.Location = new System.Drawing.Point(944, 12);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(49, 49);
            this.btn_reload.TabIndex = 41;
            this.btn_reload.TextColor = System.Drawing.Color.Black;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // UC_AD_TuyenDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pl_TimKiemDichVu);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_tuyenDuong);
            this.Controls.Add(this.label1);
            this.Name = "UC_AD_TuyenDuong";
            this.Size = new System.Drawing.Size(1142, 749);
            this.Load += new System.EventHandler(this.UC_AD_TuyenDuong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tuyenDuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton btn_xoa;
        private CustomButton btn_sua;
        private CustomButton btn_them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuPanel pl_TimKiemDichVu;
        private System.Windows.Forms.TextBox txt_tuyenCuoi;
        private System.Windows.Forms.TextBox txt_khoangCach;
        private System.Windows.Forms.TextBox txt_tuyenDau;
        private System.Windows.Forms.TextBox txt_maTuyen;
        private CustomButton btn_reload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_tenTuyen;
        private System.Windows.Forms.DataGridView dgv_tuyenDuong;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}
