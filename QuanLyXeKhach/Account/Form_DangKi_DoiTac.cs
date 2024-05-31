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

namespace QuanLyXeKhach.Account
{
    public partial class Form_DangKi_DoiTac : Form
    {
        public Form_DangKi_DoiTac()
        {
            InitializeComponent();
        }
        BL_Admin tasks = new BL_Admin();
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CBT_dangkiDT_Click(object sender, EventArgs e)
        {
            string tendn = tendangNhapDT.Text;
            string matkhau = txtDTmatKhau.Text;
            string ten = txtTenDoiTac.Text;
            string hinhthuc = TxtHinhThucdoitac.Text;
            string daidien = txtHoTenDaiDien.Text;
            string mail = txtEmailDoiTac.Text;
            string sdt = txtSDT.Text;
            string diaChi = txtDiachidoitac.Text;

            tasks.ThemPhanQuyenDT(tendn, matkhau);
            if (tasks.ThemDoiTac(ten, hinhthuc, daidien, mail, sdt, diaChi))
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
            this.tendangNhapDT.ResetText();
            this.txtDTmatKhau.ResetText();
            this.txtTenDoiTac.ResetText();
            this.TxtHinhThucdoitac.ResetText();
            this.txtHoTenDaiDien.ResetText();
            this.txtEmailDoiTac.ResetText();
            this.txtSDT.ResetText();
            this.txtDiachidoitac.ResetText();
        }
    }
}
