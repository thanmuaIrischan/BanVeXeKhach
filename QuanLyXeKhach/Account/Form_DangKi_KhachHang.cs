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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuanLyXeKhach.Account
{
    public partial class Form_DangKi_KhachHang : Form
    {
        public Form_DangKi_KhachHang()
        {
            InitializeComponent();
        }
        BL_Admin tasks = new BL_Admin();
        private void CBT_dangkikhachhang_Click(object sender, EventArgs e)
        {
            string tendn = txtTenDangNhap_kh.Text;
            string matkhau = txtMatKhau_KH.Text;
            string ten = txtHotenKhachHang.Text;
            string phai = txtGioiTinh.Text;
            string dt = txtSDT_KH.Text;
            string dc = txtDiaChi_KH.Text;
            string mail = txtEmail_KH.Text;

            tasks.ThemPhanQuyen(tendn, matkhau);
            if (tasks.ThemKhachHang(ten, phai, dt, dc, mail))
            {
                MessageBox.Show("Đăng ký thành công");
                this.Close();
                Form_Login login = new Form_Login();
                login.Show();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại");
            }

            reset();
        }
        public void reset()
        {
            this.txtTenDangNhap_kh.ResetText();
            this.txtMatKhau_KH.ResetText();
            this.txtHotenKhachHang.ResetText();
            this.txtGioiTinh.ResetText();
            this.txtSDT_KH.ResetText();
            this.txtDiaChi_KH.ResetText();
            this.txtEmail_KH.ResetText();
        }
    }
}
