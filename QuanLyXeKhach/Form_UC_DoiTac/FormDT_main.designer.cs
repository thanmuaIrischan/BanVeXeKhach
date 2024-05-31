namespace QuanLyXeKhach.Form_UC_DoiTac
{
    partial class FormDT_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDT_main));
            this.pl_DT_show = new System.Windows.Forms.Panel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnNhapMaDT = new System.Windows.Forms.Button();
            this.btnDT_DangXuat = new QuanLyXeKhach.CustomButton();
            this.tbNhapMaDT = new System.Windows.Forms.TextBox();
            this.btnTitleUser = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnDt_QuangCao = new QuanLyXeKhach.CustomButton();
            this.btnDT_trangchu = new QuanLyXeKhach.CustomButton();
            this.btnDT_DichVu = new QuanLyXeKhach.CustomButton();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_DT_show
            // 
            this.pl_DT_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_DT_show.Location = new System.Drawing.Point(276, 10);
            this.pl_DT_show.Name = "pl_DT_show";
            this.pl_DT_show.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.pl_DT_show.Size = new System.Drawing.Size(1084, 728);
            this.pl_DT_show.TabIndex = 1;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 35;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnNhapMaDT);
            this.bunifuPanel1.Controls.Add(this.btnDT_DangXuat);
            this.bunifuPanel1.Controls.Add(this.tbNhapMaDT);
            this.bunifuPanel1.Controls.Add(this.btnTitleUser);
            this.bunifuPanel1.Controls.Add(this.btnDt_QuangCao);
            this.bunifuPanel1.Controls.Add(this.btnDT_trangchu);
            this.bunifuPanel1.Controls.Add(this.btnDT_DichVu);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(10, 10);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(266, 728);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // btnNhapMaDT
            // 
            this.btnNhapMaDT.Location = new System.Drawing.Point(34, 210);
            this.btnNhapMaDT.Name = "btnNhapMaDT";
            this.btnNhapMaDT.Size = new System.Drawing.Size(194, 23);
            this.btnNhapMaDT.TabIndex = 12;
            this.btnNhapMaDT.Text = "Xac Nhan Ma Doi Tac";
            this.btnNhapMaDT.UseVisualStyleBackColor = true;
            this.btnNhapMaDT.Click += new System.EventHandler(this.btnNhapMaDT_Click);
            // 
            // btnDT_DangXuat
            // 
            this.btnDT_DangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
            this.btnDT_DangXuat.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(148)))), ((int)(((byte)(23)))));
            this.btnDT_DangXuat.BorderRadius = 67;
            this.btnDT_DangXuat.BorderSize = 0;
            this.btnDT_DangXuat.FlatAppearance.BorderSize = 0;
            this.btnDT_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDT_DangXuat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDT_DangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDT_DangXuat.Location = new System.Drawing.Point(-75, 616);
            this.btnDT_DangXuat.Name = "btnDT_DangXuat";
            this.btnDT_DangXuat.Size = new System.Drawing.Size(303, 67);
            this.btnDT_DangXuat.TabIndex = 11;
            this.btnDT_DangXuat.Text = "     Đăng xuất";
            this.btnDT_DangXuat.TextColor = System.Drawing.Color.Black;
            this.btnDT_DangXuat.UseVisualStyleBackColor = false;
            this.btnDT_DangXuat.Click += new System.EventHandler(this.btnDT_DangXuat_Click);
            // 
            // tbNhapMaDT
            // 
            this.tbNhapMaDT.Location = new System.Drawing.Point(53, 182);
            this.tbNhapMaDT.Name = "tbNhapMaDT";
            this.tbNhapMaDT.ReadOnly = true;
            this.tbNhapMaDT.Size = new System.Drawing.Size(146, 20);
            this.tbNhapMaDT.TabIndex = 11;
            this.tbNhapMaDT.TextChanged += new System.EventHandler(this.tbNhapMaDT_TextChanged);
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
            this.btnTitleUser.Location = new System.Drawing.Point(71, 57);
            this.btnTitleUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnTitleUser.Name = "btnTitleUser";
            this.btnTitleUser.Size = new System.Drawing.Size(110, 118);
            this.btnTitleUser.TabIndex = 6;
            // 
            // btnDt_QuangCao
            // 
            this.btnDt_QuangCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(143)))));
            this.btnDt_QuangCao.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(143)))));
            this.btnDt_QuangCao.BorderRadius = 67;
            this.btnDt_QuangCao.BorderSize = 0;
            this.btnDt_QuangCao.FlatAppearance.BorderSize = 0;
            this.btnDt_QuangCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDt_QuangCao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDt_QuangCao.ForeColor = System.Drawing.Color.Black;
            this.btnDt_QuangCao.Location = new System.Drawing.Point(-75, 516);
            this.btnDt_QuangCao.Name = "btnDt_QuangCao";
            this.btnDt_QuangCao.Size = new System.Drawing.Size(303, 67);
            this.btnDt_QuangCao.TabIndex = 10;
            this.btnDt_QuangCao.Text = "      Quảng cáo";
            this.btnDt_QuangCao.TextColor = System.Drawing.Color.Black;
            this.btnDt_QuangCao.UseVisualStyleBackColor = false;
            this.btnDt_QuangCao.Click += new System.EventHandler(this.btnDt_QuangCao_Click);
            // 
            // btnDT_trangchu
            // 
            this.btnDT_trangchu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnDT_trangchu.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.btnDT_trangchu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDT_trangchu.BorderRadius = 67;
            this.btnDT_trangchu.BorderSize = 0;
            this.btnDT_trangchu.FlatAppearance.BorderSize = 0;
            this.btnDT_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDT_trangchu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDT_trangchu.ForeColor = System.Drawing.Color.Black;
            this.btnDT_trangchu.Location = new System.Drawing.Point(-75, 287);
            this.btnDT_trangchu.Name = "btnDT_trangchu";
            this.btnDT_trangchu.Size = new System.Drawing.Size(303, 67);
            this.btnDT_trangchu.TabIndex = 7;
            this.btnDT_trangchu.Text = "   Trang chủ";
            this.btnDT_trangchu.TextColor = System.Drawing.Color.Black;
            this.btnDT_trangchu.UseVisualStyleBackColor = false;
            this.btnDT_trangchu.Click += new System.EventHandler(this.btn_trangchu_Click);
            // 
            // btnDT_DichVu
            // 
            this.btnDT_DichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnDT_DichVu.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.btnDT_DichVu.BorderRadius = 67;
            this.btnDT_DichVu.BorderSize = 0;
            this.btnDT_DichVu.FlatAppearance.BorderSize = 0;
            this.btnDT_DichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDT_DichVu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDT_DichVu.ForeColor = System.Drawing.Color.Black;
            this.btnDT_DichVu.Location = new System.Drawing.Point(-75, 395);
            this.btnDT_DichVu.Name = "btnDT_DichVu";
            this.btnDT_DichVu.Size = new System.Drawing.Size(303, 67);
            this.btnDT_DichVu.TabIndex = 8;
            this.btnDT_DichVu.Text = "Dịch vụ";
            this.btnDT_DichVu.TextColor = System.Drawing.Color.Black;
            this.btnDT_DichVu.UseVisualStyleBackColor = false;
            this.btnDT_DichVu.Click += new System.EventHandler(this.btnDT_DichVu_Click);
            // 
            // FormDT_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(162)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1370, 748);
            this.Controls.Add(this.pl_DT_show);
            this.Controls.Add(this.bunifuPanel1);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDT_main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FormDT_main";
            this.Load += new System.EventHandler(this.FormDT_main_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Panel pl_DT_show;
        private CustomButton btnDT_DangXuat;
        private Bunifu.Framework.UI.BunifuTileButton btnTitleUser;
        private CustomButton btnDt_QuangCao;
        private CustomButton btnDT_trangchu;
        private CustomButton btnDT_DichVu;
        private System.Windows.Forms.Button btnNhapMaDT;
        private System.Windows.Forms.TextBox tbNhapMaDT;
    }
}