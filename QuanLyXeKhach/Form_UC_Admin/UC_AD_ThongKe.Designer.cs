namespace QuanLyXeKhach.Form_UC_Admin
{
    partial class UC_AD_ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AD_ThongKe));
            this.label1 = new System.Windows.Forms.Label();
            this.pl_TimKiemDichVu = new Bunifu.UI.WinForms.BunifuPanel();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new QuanLyXeKhach.CustomButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.txtDoanhThuVe = new System.Windows.Forms.TextBox();
            this.dgv_QC = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_doanhThuQC = new System.Windows.Forms.TextBox();
            this.txt_Tong = new System.Windows.Forms.TextBox();
            this.pl_TimKiemDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(347, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 46);
            this.label1.TabIndex = 43;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // pl_TimKiemDichVu
            // 
            this.pl_TimKiemDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pl_TimKiemDichVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_TimKiemDichVu.BackgroundImage")));
            this.pl_TimKiemDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pl_TimKiemDichVu.BorderColor = System.Drawing.Color.Black;
            this.pl_TimKiemDichVu.BorderRadius = 35;
            this.pl_TimKiemDichVu.BorderThickness = 1;
            this.pl_TimKiemDichVu.Controls.Add(this.dtpDenNgay);
            this.pl_TimKiemDichVu.Controls.Add(this.dtpTuNgay);
            this.pl_TimKiemDichVu.Controls.Add(this.btnThongKe);
            this.pl_TimKiemDichVu.Controls.Add(this.bunifuLabel1);
            this.pl_TimKiemDichVu.Controls.Add(this.bunifuLabel2);
            this.pl_TimKiemDichVu.Location = new System.Drawing.Point(131, 118);
            this.pl_TimKiemDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.pl_TimKiemDichVu.Name = "pl_TimKiemDichVu";
            this.pl_TimKiemDichVu.ShowBorders = true;
            this.pl_TimKiemDichVu.Size = new System.Drawing.Size(882, 78);
            this.pl_TimKiemDichVu.TabIndex = 44;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(496, 30);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpDenNgay.TabIndex = 6;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(130, 30);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 22);
            this.dtpTuNgay.TabIndex = 5;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThongKe.BackgoroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThongKe.BorderRadius = 45;
            this.btnThongKe.BorderSize = 0;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Location = new System.Drawing.Point(736, 18);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(130, 49);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.TextColor = System.Drawing.Color.Black;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(379, 30);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(96, 24);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Đến ngày:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel2_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(27, 28);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(86, 24);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "Từ ngày:";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel2.Click += new System.EventHandler(this.bunifuLabel2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(492, 374);
            this.dataGridView1.TabIndex = 45;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(137, 692);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(147, 23);
            this.lblTongDoanhThu.TabIndex = 46;
            this.lblTongDoanhThu.Text = "Tổng doanh thu:";
            // 
            // txtDoanhThuVe
            // 
            this.txtDoanhThuVe.Enabled = false;
            this.txtDoanhThuVe.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhThuVe.Location = new System.Drawing.Point(292, 611);
            this.txtDoanhThuVe.Name = "txtDoanhThuVe";
            this.txtDoanhThuVe.Size = new System.Drawing.Size(189, 35);
            this.txtDoanhThuVe.TabIndex = 47;
            this.txtDoanhThuVe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgv_QC
            // 
            this.dgv_QC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QC.BackgroundColor = System.Drawing.Color.White;
            this.dgv_QC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QC.Location = new System.Drawing.Point(639, 218);
            this.dgv_QC.Name = "dgv_QC";
            this.dgv_QC.RowHeadersWidth = 51;
            this.dgv_QC.RowTemplate.Height = 24;
            this.dgv_QC.Size = new System.Drawing.Size(372, 374);
            this.dgv_QC.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 46;
            this.label2.Text = "Doanh thu Vé:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(637, 623);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "Doanh thu Quảng cáo:";
            // 
            // txt_doanhThuQC
            // 
            this.txt_doanhThuQC.Enabled = false;
            this.txt_doanhThuQC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_doanhThuQC.Location = new System.Drawing.Point(841, 611);
            this.txt_doanhThuQC.Name = "txt_doanhThuQC";
            this.txt_doanhThuQC.Size = new System.Drawing.Size(170, 35);
            this.txt_doanhThuQC.TabIndex = 47;
            this.txt_doanhThuQC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_Tong
            // 
            this.txt_Tong.Enabled = false;
            this.txt_Tong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tong.Location = new System.Drawing.Point(292, 686);
            this.txt_Tong.Name = "txt_Tong";
            this.txt_Tong.Size = new System.Drawing.Size(719, 35);
            this.txt_Tong.TabIndex = 47;
            this.txt_Tong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UC_AD_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_QC);
            this.Controls.Add(this.txt_Tong);
            this.Controls.Add(this.txt_doanhThuQC);
            this.Controls.Add(this.txtDoanhThuVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pl_TimKiemDichVu);
            this.Controls.Add(this.label1);
            this.Name = "UC_AD_ThongKe";
            this.Size = new System.Drawing.Size(1142, 749);
            this.pl_TimKiemDichVu.ResumeLayout(false);
            this.pl_TimKiemDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel pl_TimKiemDichVu;
        private CustomButton btnThongKe;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.TextBox txtDoanhThuVe;
        private System.Windows.Forms.DataGridView dgv_QC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_doanhThuQC;
        private System.Windows.Forms.TextBox txt_Tong;
    }
}
