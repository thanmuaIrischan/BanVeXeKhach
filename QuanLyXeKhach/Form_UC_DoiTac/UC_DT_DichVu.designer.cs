namespace QuanLyXeKhach.Form_UC_DoiTac
{
    partial class UC_DT_DichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_DT_DichVu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DichVuNoiBo = new System.Windows.Forms.DataGridView();
            this.tbMaDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbGhiChu = new System.Windows.Forms.TextBox();
            this.tbGiaDV = new System.Windows.Forms.TextBox();
            this.tbTenDV = new System.Windows.Forms.TextBox();
            this.tbMaDT = new System.Windows.Forms.TextBox();
            this.pl_TimKiemDichVu = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnTimDichVuNB = new QuanLyXeKhach.CustomButton();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbTimKiemDichVu = new System.Windows.Forms.ComboBox();
            this.btnReloadDV = new QuanLyXeKhach.CustomButton();
            this.btnChinhSuaDichVu = new QuanLyXeKhach.CustomButton();
            this.btnThemDichVu = new QuanLyXeKhach.CustomButton();
            this.btnXoaDichVu = new QuanLyXeKhach.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVuNoiBo)).BeginInit();
            this.pl_TimKiemDichVu.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(287, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DỊCH VỤ NỘI BỘ";
            // 
            // dgv_DichVuNoiBo
            // 
            this.dgv_DichVuNoiBo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DichVuNoiBo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DichVuNoiBo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DichVuNoiBo.Location = new System.Drawing.Point(24, 241);
            this.dgv_DichVuNoiBo.Name = "dgv_DichVuNoiBo";
            this.dgv_DichVuNoiBo.RowHeadersWidth = 51;
            this.dgv_DichVuNoiBo.RowTemplate.Height = 24;
            this.dgv_DichVuNoiBo.Size = new System.Drawing.Size(1084, 399);
            this.dgv_DichVuNoiBo.TabIndex = 1;
            this.dgv_DichVuNoiBo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DichVuNoiBo_CellContentClick);
            // 
            // tbMaDV
            // 
            this.tbMaDV.Location = new System.Drawing.Point(741, 90);
            this.tbMaDV.Name = "tbMaDV";
            this.tbMaDV.Size = new System.Drawing.Size(100, 30);
            this.tbMaDV.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(622, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mã đối tác";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(885, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Giá dịch vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tên dịch vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(885, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ghi chú";
            // 
            // TbGhiChu
            // 
            this.TbGhiChu.Location = new System.Drawing.Point(1008, 147);
            this.TbGhiChu.Name = "TbGhiChu";
            this.TbGhiChu.Size = new System.Drawing.Size(100, 30);
            this.TbGhiChu.TabIndex = 28;
            // 
            // tbGiaDV
            // 
            this.tbGiaDV.Location = new System.Drawing.Point(1008, 90);
            this.tbGiaDV.Name = "tbGiaDV";
            this.tbGiaDV.Size = new System.Drawing.Size(100, 30);
            this.tbGiaDV.TabIndex = 29;
            // 
            // tbTenDV
            // 
            this.tbTenDV.Location = new System.Drawing.Point(741, 200);
            this.tbTenDV.Name = "tbTenDV";
            this.tbTenDV.Size = new System.Drawing.Size(367, 30);
            this.tbTenDV.TabIndex = 30;
            // 
            // tbMaDT
            // 
            this.tbMaDT.Location = new System.Drawing.Point(741, 147);
            this.tbMaDT.Name = "tbMaDT";
            this.tbMaDT.Size = new System.Drawing.Size(100, 30);
            this.tbMaDT.TabIndex = 31;
            // 
            // pl_TimKiemDichVu
            // 
            this.pl_TimKiemDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pl_TimKiemDichVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_TimKiemDichVu.BackgroundImage")));
            this.pl_TimKiemDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_TimKiemDichVu.BorderColor = System.Drawing.Color.Black;
            this.pl_TimKiemDichVu.BorderRadius = 35;
            this.pl_TimKiemDichVu.BorderThickness = 1;
            this.pl_TimKiemDichVu.Controls.Add(this.btnTimDichVuNB);
            this.pl_TimKiemDichVu.Controls.Add(this.tbTimKiem);
            this.pl_TimKiemDichVu.Controls.Add(this.bunifuLabel1);
            this.pl_TimKiemDichVu.Controls.Add(this.cbTimKiemDichVu);
            this.pl_TimKiemDichVu.Location = new System.Drawing.Point(24, 93);
            this.pl_TimKiemDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.pl_TimKiemDichVu.Name = "pl_TimKiemDichVu";
            this.pl_TimKiemDichVu.ShowBorders = true;
            this.pl_TimKiemDichVu.Size = new System.Drawing.Size(550, 131);
            this.pl_TimKiemDichVu.TabIndex = 11;
            // 
            // btnTimDichVuNB
            // 
            this.btnTimDichVuNB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimDichVuNB.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimDichVuNB.BorderRadius = 45;
            this.btnTimDichVuNB.BorderSize = 0;
            this.btnTimDichVuNB.FlatAppearance.BorderSize = 0;
            this.btnTimDichVuNB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimDichVuNB.ForeColor = System.Drawing.Color.Black;
            this.btnTimDichVuNB.Location = new System.Drawing.Point(392, 45);
            this.btnTimDichVuNB.Name = "btnTimDichVuNB";
            this.btnTimDichVuNB.Size = new System.Drawing.Size(130, 49);
            this.btnTimDichVuNB.TabIndex = 3;
            this.btnTimDichVuNB.Text = "Tìm kiếm";
            this.btnTimDichVuNB.TextColor = System.Drawing.Color.Black;
            this.btnTimDichVuNB.UseVisualStyleBackColor = false;
            this.btnTimDichVuNB.Click += new System.EventHandler(this.btnTimDichVuNB_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(22, 82);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(348, 30);
            this.tbTimKiem.TabIndex = 2;
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
            this.bunifuLabel1.Size = new System.Drawing.Size(147, 24);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Tìm kiếm theo :";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cbTimKiemDichVu
            // 
            this.cbTimKiemDichVu.FormattingEnabled = true;
            this.cbTimKiemDichVu.Location = new System.Drawing.Point(188, 29);
            this.cbTimKiemDichVu.Name = "cbTimKiemDichVu";
            this.cbTimKiemDichVu.Size = new System.Drawing.Size(182, 32);
            this.cbTimKiemDichVu.TabIndex = 0;
            // 
            // btnReloadDV
            // 
            this.btnReloadDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReloadDV.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReloadDV.BorderRadius = 50;
            this.btnReloadDV.BorderSize = 0;
            this.btnReloadDV.FlatAppearance.BorderSize = 0;
            this.btnReloadDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReloadDV.ForeColor = System.Drawing.Color.White;
            this.btnReloadDV.Location = new System.Drawing.Point(925, 17);
            this.btnReloadDV.Name = "btnReloadDV";
            this.btnReloadDV.Size = new System.Drawing.Size(183, 56);
            this.btnReloadDV.TabIndex = 17;
            this.btnReloadDV.Text = "Reload";
            this.btnReloadDV.TextColor = System.Drawing.Color.White;
            this.btnReloadDV.UseVisualStyleBackColor = false;
            this.btnReloadDV.Click += new System.EventHandler(this.btnReloadDV_Click);
            // 
            // btnChinhSuaDichVu
            // 
            this.btnChinhSuaDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnChinhSuaDichVu.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnChinhSuaDichVu.BorderRadius = 50;
            this.btnChinhSuaDichVu.BorderSize = 0;
            this.btnChinhSuaDichVu.FlatAppearance.BorderSize = 0;
            this.btnChinhSuaDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSuaDichVu.ForeColor = System.Drawing.Color.White;
            this.btnChinhSuaDichVu.Location = new System.Drawing.Point(528, 655);
            this.btnChinhSuaDichVu.Name = "btnChinhSuaDichVu";
            this.btnChinhSuaDichVu.Size = new System.Drawing.Size(183, 56);
            this.btnChinhSuaDichVu.TabIndex = 15;
            this.btnChinhSuaDichVu.Text = "Chỉnh sửa ";
            this.btnChinhSuaDichVu.TextColor = System.Drawing.Color.White;
            this.btnChinhSuaDichVu.UseVisualStyleBackColor = false;
            this.btnChinhSuaDichVu.Click += new System.EventHandler(this.btnChinhSuaDichVu_Click);
            // 
            // btnThemDichVu
            // 
            this.btnThemDichVu.BackColor = System.Drawing.Color.Gold;
            this.btnThemDichVu.BackgoroundColor = System.Drawing.Color.Gold;
            this.btnThemDichVu.BorderRadius = 50;
            this.btnThemDichVu.BorderSize = 0;
            this.btnThemDichVu.FlatAppearance.BorderSize = 0;
            this.btnThemDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDichVu.ForeColor = System.Drawing.Color.White;
            this.btnThemDichVu.Location = new System.Drawing.Point(24, 655);
            this.btnThemDichVu.Name = "btnThemDichVu";
            this.btnThemDichVu.Size = new System.Drawing.Size(249, 56);
            this.btnThemDichVu.TabIndex = 14;
            this.btnThemDichVu.Text = "Đăng kí thêm dịch vụ";
            this.btnThemDichVu.TextColor = System.Drawing.Color.White;
            this.btnThemDichVu.UseVisualStyleBackColor = false;
            this.btnThemDichVu.Click += new System.EventHandler(this.btnThemDichVu_Click);
            // 
            // btnXoaDichVu
            // 
            this.btnXoaDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoaDichVu.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoaDichVu.BorderRadius = 50;
            this.btnXoaDichVu.BorderSize = 0;
            this.btnXoaDichVu.FlatAppearance.BorderSize = 0;
            this.btnXoaDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDichVu.ForeColor = System.Drawing.Color.White;
            this.btnXoaDichVu.Location = new System.Drawing.Point(925, 655);
            this.btnXoaDichVu.Name = "btnXoaDichVu";
            this.btnXoaDichVu.Size = new System.Drawing.Size(183, 56);
            this.btnXoaDichVu.TabIndex = 13;
            this.btnXoaDichVu.Text = "Hủy dịch vụ";
            this.btnXoaDichVu.TextColor = System.Drawing.Color.White;
            this.btnXoaDichVu.UseVisualStyleBackColor = false;
            this.btnXoaDichVu.Click += new System.EventHandler(this.btnXoaDichVu_Click);
            // 
            // UC_DT_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbMaDT);
            this.Controls.Add(this.tbTenDV);
            this.Controls.Add(this.tbGiaDV);
            this.Controls.Add(this.TbGhiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaDV);
            this.Controls.Add(this.btnReloadDV);
            this.Controls.Add(this.btnChinhSuaDichVu);
            this.Controls.Add(this.btnThemDichVu);
            this.Controls.Add(this.btnXoaDichVu);
            this.Controls.Add(this.pl_TimKiemDichVu);
            this.Controls.Add(this.dgv_DichVuNoiBo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_DT_DichVu";
            this.Size = new System.Drawing.Size(1142, 749);
            this.Load += new System.EventHandler(this.UC_DT_DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVuNoiBo)).EndInit();
            this.pl_TimKiemDichVu.ResumeLayout(false);
            this.pl_TimKiemDichVu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DichVuNoiBo;
        private Bunifu.UI.WinForms.BunifuPanel pl_TimKiemDichVu;
        private System.Windows.Forms.TextBox tbTimKiem;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.ComboBox cbTimKiemDichVu;
        private CustomButton btnXoaDichVu;
        private CustomButton btnThemDichVu;
        private CustomButton btnChinhSuaDichVu;
        private CustomButton btnReloadDV;
        private System.Windows.Forms.TextBox tbMaDV;
        private System.Windows.Forms.TextBox tbMaDT;
        private System.Windows.Forms.TextBox tbTenDV;
        private System.Windows.Forms.TextBox tbGiaDV;
        private System.Windows.Forms.TextBox TbGhiChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomButton btnTimDichVuNB;
    }
}
