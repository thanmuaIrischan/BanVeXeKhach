using QuanLyXeKhach.Account;
using QuanLyXeKhach.BSLayer;
using QuanLyXeKhach.Control_Ads;
using QuanLyXeKhach.Form_UC_KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeKhach.FormKhachHang
{
    public partial class FormKH_main : Form
    {
        public FormKH_main()
        {
            InitializeComponent();
            UC_KH_Main uC_KH_Main = new UC_KH_Main();
            uC_KH_Main.Dock = DockStyle.Fill;
            pl_KH_main.Controls.Add(uC_KH_Main);
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            // Ẩn tất cả các UserControl khác (nếu có)
            pl_KH_main.Controls.Clear();
            UC_KH_Main uC_KH_Main = new UC_KH_Main();
            uC_KH_Main.Dock = DockStyle.Fill;
            pl_KH_main.Controls.Add(uC_KH_Main);
        }

        private void btn_ChuyenXe_Click(object sender, EventArgs e)
        {
            
            // Ẩn tất cả các UserControl khác (nếu có)
            pl_KH_main.Controls.Clear();
            
            // Hiển thị UserControl1
            UC_KH_Chuyenxe uc_chuyenxe = new UC_KH_Chuyenxe();
            uc_chuyenxe.Dock = DockStyle.Fill;
            pl_KH_main.Controls.Add(uc_chuyenxe);

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            //// Ẩn tất cả các UserControl khác (nếu có)
            //pl_KH_main.Controls.Clear();

            //// Hiển thị UserControl1
            //UC_KH_UuDai uc_uudai = new UC_KH_UuDai();
            //uc_uudai.Dock = DockStyle.Fill;
            //pl_KH_main.Controls.Add(uc_uudai);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            // Ẩn tất cả các UserControl khác (nếu có)
            pl_KH_main.Controls.Clear();

            // Hiển thị UserControl1
            UC_KH_GioHang uc_giohang = new UC_KH_GioHang();
            uc_giohang.Dock = DockStyle.Fill;
            pl_KH_main.Controls.Add(uc_giohang);
        }

        private void pl_KH_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            pl_KH_main.Controls.Clear();

            // Hiển thị UserControl1
            UC_KH_DichVu uc_dichvu = new UC_KH_DichVu();
            uc_dichvu.Dock = DockStyle.Fill;
            pl_KH_main.Controls.Add(uc_dichvu);

        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form_Login lg = new Form_Login();
            lg.ShowDialog();
        }

        private void btnNhapMaDT_Click(object sender, EventArgs e)
        {
            //KhachHang.MaKH = tbNhapMaKH.Text;
            btnNhapMaKH.Enabled = false;
        }

        private void FormKH_main_Load(object sender, EventArgs e)
        {
            tbNhapMaKH.Text = KhachHang.MaKH;
        }
    }
}
