namespace QuanLyXeKhach.Form_UC_Admin
{
    partial class UC_AD_PhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AD_PhanQuyen));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_suaPQ = new QuanLyXeKhach.CustomButton();
            this.txt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.txt_loaiPQ = new System.Windows.Forms.TextBox();
            this.txt_tenDangNhap = new System.Windows.Forms.TextBox();
            this.txt_maPQ = new System.Windows.Forms.TextBox();
            this.pl_TimKiemDichVu = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_hienPQ_DT = new QuanLyXeKhach.CustomButton();
            this.btn_hienPQ_KH = new QuanLyXeKhach.CustomButton();
            this.btn_reload = new QuanLyXeKhach.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pl_TimKiemDichVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(340, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ PHÂN QUYỀN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 235);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_suaPQ);
            this.groupBox1.Controls.Add(this.txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_MK);
            this.groupBox1.Controls.Add(this.txt_loaiPQ);
            this.groupBox1.Controls.Add(this.txt_tenDangNhap);
            this.groupBox1.Controls.Add(this.txt_maPQ);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(229, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 261);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết phân quyền tài khoản";
            // 
            // btn_suaPQ
            // 
            this.btn_suaPQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_suaPQ.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_suaPQ.BorderRadius = 38;
            this.btn_suaPQ.BorderSize = 0;
            this.btn_suaPQ.FlatAppearance.BorderSize = 0;
            this.btn_suaPQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaPQ.ForeColor = System.Drawing.Color.Black;
            this.btn_suaPQ.Location = new System.Drawing.Point(243, 197);
            this.btn_suaPQ.Name = "btn_suaPQ";
            this.btn_suaPQ.Size = new System.Drawing.Size(238, 38);
            this.btn_suaPQ.TabIndex = 4;
            this.btn_suaPQ.Text = "Sửa thông tin phân quyền";
            this.btn_suaPQ.TextColor = System.Drawing.Color.Black;
            this.btn_suaPQ.UseVisualStyleBackColor = false;
            this.btn_suaPQ.Click += new System.EventHandler(this.btn_suaPQ_Click_1);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(367, 145);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(85, 20);
            this.txt.TabIndex = 22;
            this.txt.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Loại phân quyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã phân quyền";
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(519, 138);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(160, 27);
            this.txt_MK.TabIndex = 21;
            // 
            // txt_loaiPQ
            // 
            this.txt_loaiPQ.Location = new System.Drawing.Point(519, 43);
            this.txt_loaiPQ.Name = "txt_loaiPQ";
            this.txt_loaiPQ.Size = new System.Drawing.Size(160, 27);
            this.txt_loaiPQ.TabIndex = 21;
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.Location = new System.Drawing.Point(159, 142);
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Size = new System.Drawing.Size(179, 27);
            this.txt_tenDangNhap.TabIndex = 21;
            // 
            // txt_maPQ
            // 
            this.txt_maPQ.Location = new System.Drawing.Point(159, 47);
            this.txt_maPQ.Name = "txt_maPQ";
            this.txt_maPQ.Size = new System.Drawing.Size(179, 27);
            this.txt_maPQ.TabIndex = 21;
            // 
            // pl_TimKiemDichVu
            // 
            this.pl_TimKiemDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pl_TimKiemDichVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_TimKiemDichVu.BackgroundImage")));
            this.pl_TimKiemDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_TimKiemDichVu.BorderColor = System.Drawing.Color.Black;
            this.pl_TimKiemDichVu.BorderRadius = 35;
            this.pl_TimKiemDichVu.BorderThickness = 1;
            this.pl_TimKiemDichVu.Controls.Add(this.btn_hienPQ_DT);
            this.pl_TimKiemDichVu.Controls.Add(this.btn_hienPQ_KH);
            this.pl_TimKiemDichVu.Location = new System.Drawing.Point(251, 91);
            this.pl_TimKiemDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.pl_TimKiemDichVu.Name = "pl_TimKiemDichVu";
            this.pl_TimKiemDichVu.ShowBorders = true;
            this.pl_TimKiemDichVu.Size = new System.Drawing.Size(657, 78);
            this.pl_TimKiemDichVu.TabIndex = 22;
            // 
            // btn_hienPQ_DT
            // 
            this.btn_hienPQ_DT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_hienPQ_DT.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_hienPQ_DT.BorderRadius = 45;
            this.btn_hienPQ_DT.BorderSize = 0;
            this.btn_hienPQ_DT.FlatAppearance.BorderSize = 0;
            this.btn_hienPQ_DT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hienPQ_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_hienPQ_DT.ForeColor = System.Drawing.Color.Black;
            this.btn_hienPQ_DT.Location = new System.Drawing.Point(361, 15);
            this.btn_hienPQ_DT.Name = "btn_hienPQ_DT";
            this.btn_hienPQ_DT.Size = new System.Drawing.Size(204, 49);
            this.btn_hienPQ_DT.TabIndex = 4;
            this.btn_hienPQ_DT.Text = "Hiển thị phân quyền đối tác";
            this.btn_hienPQ_DT.TextColor = System.Drawing.Color.Black;
            this.btn_hienPQ_DT.UseVisualStyleBackColor = false;
            this.btn_hienPQ_DT.Click += new System.EventHandler(this.btn_hienPQ_DT_Click);
            // 
            // btn_hienPQ_KH
            // 
            this.btn_hienPQ_KH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_hienPQ_KH.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_hienPQ_KH.BorderRadius = 45;
            this.btn_hienPQ_KH.BorderSize = 0;
            this.btn_hienPQ_KH.FlatAppearance.BorderSize = 0;
            this.btn_hienPQ_KH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hienPQ_KH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_hienPQ_KH.ForeColor = System.Drawing.Color.Black;
            this.btn_hienPQ_KH.Location = new System.Drawing.Point(123, 15);
            this.btn_hienPQ_KH.Name = "btn_hienPQ_KH";
            this.btn_hienPQ_KH.Size = new System.Drawing.Size(201, 49);
            this.btn_hienPQ_KH.TabIndex = 4;
            this.btn_hienPQ_KH.Text = "Hiển thị phân quyền khách hàng";
            this.btn_hienPQ_KH.TextColor = System.Drawing.Color.Black;
            this.btn_hienPQ_KH.UseVisualStyleBackColor = false;
            this.btn_hienPQ_KH.Click += new System.EventHandler(this.btn_hienPQ_KH_Click);
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
            this.btn_reload.Location = new System.Drawing.Point(859, 27);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(49, 49);
            this.btn_reload.TabIndex = 28;
            this.btn_reload.TextColor = System.Drawing.Color.Black;
            this.btn_reload.UseVisualStyleBackColor = false;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // UC_AD_PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pl_TimKiemDichVu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UC_AD_PhanQuyen";
            this.Size = new System.Drawing.Size(1142, 749);
            this.Load += new System.EventHandler(this.UC_AD_PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pl_TimKiemDichVu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.UI.WinForms.BunifuPanel pl_TimKiemDichVu;
        private CustomButton btn_hienPQ_KH;
        private CustomButton btn_hienPQ_DT;
        private System.Windows.Forms.GroupBox groupBox1;
        private CustomButton btn_suaPQ;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.TextBox txt_loaiPQ;
        private System.Windows.Forms.TextBox txt_tenDangNhap;
        private System.Windows.Forms.TextBox txt_maPQ;
        private CustomButton btn_reload;
    }
}
