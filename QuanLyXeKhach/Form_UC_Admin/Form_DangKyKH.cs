using QuanLyXeKhach.Account;
using QuanLyXeKhach.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuanLyXeKhach.Form_UC_Admin
{
    public partial class Form_DangKyKH : Form
    {
        BL_Admin tasks = new BL_Admin();
        public Form_DangKyKH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_dangKyKH_Click(object sender, EventArgs e)
        {
            string tendn = tendangnhap.Text;
            string matkhau = mk.Text;
            string ten = hoten.Text;
            string phai = gioitinh.Text;
            string dt = sdt.Text;
            string dc = diachi.Text;
            string mail = email.Text;

            tasks.ThemPhanQuyen(tendn, matkhau);
            if (tasks.ThemKhachHang(ten, phai, dt, dc, mail))
            {
                MessageBox.Show("Đăng ký thành công");
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }

            reset();
        }

        public void reset()
        {
            this.tendangnhap.ResetText();
            this.mk.ResetText();
            this.hoten.ResetText();
            this.gioitinh.ResetText();
            this.sdt.ResetText();  
            this.diachi.ResetText();
            this.email.ResetText();
        }
    }

    
}
