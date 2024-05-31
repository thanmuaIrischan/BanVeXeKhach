namespace QuanLyXeKhach.Form_UC_Admin
{
    partial class Form_DangKyKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.tendangnhap = new System.Windows.Forms.TextBox();
            this.mk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.TextBox();
            this.gioitinh = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_dangKyKH = new QuanLyXeKhach.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(35, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tendangnhap
            // 
            this.tendangnhap.Location = new System.Drawing.Point(198, 432);
            this.tendangnhap.Multiline = true;
            this.tendangnhap.Name = "tendangnhap";
            this.tendangnhap.Size = new System.Drawing.Size(229, 26);
            this.tendangnhap.TabIndex = 1;
            this.tendangnhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mk
            // 
            this.mk.Location = new System.Drawing.Point(198, 473);
            this.mk.Multiline = true;
            this.mk.Name = "mk";
            this.mk.Size = new System.Drawing.Size(229, 30);
            this.mk.TabIndex = 1;
            this.mk.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(35, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(150, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông tin tài khoản";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(50, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(50, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(50, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(50, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(50, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Email:";
            this.label8.Click += new System.EventHandler(this.label7_Click);
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(213, 110);
            this.hoten.Multiline = true;
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(229, 30);
            this.hoten.TabIndex = 1;
            this.hoten.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // gioitinh
            // 
            this.gioitinh.Location = new System.Drawing.Point(213, 151);
            this.gioitinh.Multiline = true;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Size = new System.Drawing.Size(229, 30);
            this.gioitinh.TabIndex = 1;
            this.gioitinh.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(213, 196);
            this.sdt.Multiline = true;
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(229, 30);
            this.sdt.TabIndex = 1;
            this.sdt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(213, 241);
            this.diachi.Multiline = true;
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(229, 30);
            this.diachi.TabIndex = 1;
            this.diachi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(213, 285);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(229, 30);
            this.email.TabIndex = 1;
            this.email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(139, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thông tin khách hàng";
            this.label9.Click += new System.EventHandler(this.label1_Click);
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
            this.btn_dangKyKH.Location = new System.Drawing.Point(297, 555);
            this.btn_dangKyKH.Name = "btn_dangKyKH";
            this.btn_dangKyKH.Size = new System.Drawing.Size(130, 49);
            this.btn_dangKyKH.TabIndex = 5;
            this.btn_dangKyKH.Text = "Đăng ký";
            this.btn_dangKyKH.TextColor = System.Drawing.Color.Black;
            this.btn_dangKyKH.UseVisualStyleBackColor = false;
            this.btn_dangKyKH.Click += new System.EventHandler(this.btn_dangKyKH_Click);
            // 
            // Form_DangKyKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 642);
            this.Controls.Add(this.btn_dangKyKH);
            this.Controls.Add(this.email);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.sdt);
            this.Controls.Add(this.gioitinh);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.mk);
            this.Controls.Add(this.tendangnhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form_DangKyKH";
            this.Text = "Form_DangKyKH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tendangnhap;
        private System.Windows.Forms.TextBox mk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.TextBox gioitinh;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label9;
        private CustomButton btn_dangKyKH;
    }
}