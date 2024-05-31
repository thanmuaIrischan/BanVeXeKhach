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

namespace QuanLyXeKhach.Form_UC_Admin
{
    public partial class Form_DangKyDT : Form
    {
        BL_Admin tasks = new BL_Admin();
        public Form_DangKyDT()
        {
            InitializeComponent();
        }

        private void btn_dangKyKH_Click(object sender, EventArgs e)
        {
            string tendn = tendangnhap.Text;
            string matkhau = mk.Text;
            string ten = txt_tenDT.Text;
            string hinhthuc = txt_hinhThuc.Text;
            string daidien = txt_sdt.Text;
            string mail = txt_email.Text;
            string sdt = txt_sdt.Text;
            string diaChi = txt_diaChi.Text;

            tasks.ThemPhanQuyenDT(tendn, matkhau);
            if (tasks.ThemDoiTac(ten,hinhthuc,daidien,mail,sdt,diaChi))
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
            this.txt_tenDT.ResetText();
            this.txt_hinhThuc.ResetText();
            this.txt_nguoiDaiDien.ResetText();
            this.txt_email.ResetText();
            this.txt_sdt.ResetText();
            this.txt_diaChi.ResetText();
        }
    }
}
