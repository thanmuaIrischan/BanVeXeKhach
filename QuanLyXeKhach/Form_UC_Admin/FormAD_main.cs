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

namespace QuanLyXeKhach.Form_UC_Admin
{
    public partial class FormAD_main : Form
    {
        public FormAD_main()
        {
            InitializeComponent();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            pl_AD_show.Controls.Clear();
            UC_KH_Main uC_KH_Main = new UC_KH_Main();
            uC_KH_Main.Dock = DockStyle.Fill;
            pl_AD_show.Controls.Add(uC_KH_Main);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            pl_AD_show.Controls.Clear();

            // Hiển thị UserControl1
            UC_AD_KhachHang uc_khachhang = new UC_AD_KhachHang();
            uc_khachhang.Dock = DockStyle.Fill;
            pl_AD_show.Controls.Add(uc_khachhang);
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            pl_AD_show.Controls.Clear();

            // Hiển thị UserControl1
            UC_AD_Xe uc_xe = new UC_AD_Xe();
            uc_xe.Dock = DockStyle.Fill;
            pl_AD_show.Controls.Add(uc_xe);
        }

        private void d_Click(object sender, EventArgs e)    //Btn_phanQuyen
        {
            pl_AD_show.Controls.Clear();

            // Hiển thị UserControl1
            UC_AD_PhanQuyen uc_PQ = new UC_AD_PhanQuyen();
            uc_PQ.Dock = DockStyle.Fill;
            pl_AD_show.Controls.Add(uc_PQ);
        }

        private void btnDoiTac_Click(object sender, EventArgs e)
        {
            pl_AD_show.Controls.Clear();

            // Hiển thị UserControl1
            UC_AD_DoiTac uc_ĐT = new UC_AD_DoiTac();
            uc_ĐT.Dock = DockStyle.Fill;
            pl_AD_show.Controls.Add(uc_ĐT);
        }

        private void btnVeXe_Click(object sender, EventArgs e)
        {
            pl_AD_show.Controls.Clear();

            // Hiển thị UserControl1
            UC_AD_VeXe uc_VeXe = new UC_AD_VeXe();
            uc_VeXe.Dock = DockStyle.Fill;
            pl_AD_show.Controls.Add(uc_VeXe);
        }

        private void btnChuyenXe_Click(object sender, EventArgs e)
        {
            pl_AD_show.Controls.Clear();

            // Hiển thị UserControl1
            UC_AD_ChuyenXe uc_ChuyenXe = new UC_AD_ChuyenXe();
            uc_ChuyenXe.Dock = DockStyle.Fill;
            pl_AD_show.Controls.Add(uc_ChuyenXe);
        }

        private void btnTuyen_Click(object sender, EventArgs e)
        {
            pl_AD_show.Controls.Clear();

            // Hiển thị UserControl1
            UC_AD_TuyenDuong uc_TuyenDuong = new UC_AD_TuyenDuong();
            uc_TuyenDuong.Dock = DockStyle.Fill;
            pl_AD_show.Controls.Add(uc_TuyenDuong);
        }

        private void btnTaiXe_Click(object sender, EventArgs e)
        {
            pl_AD_show.Controls.Clear();

            // Hiển thị UserControl1
            UC_AD_TaiXe uc_TaiXe = new UC_AD_TaiXe();
            uc_TaiXe.Dock = DockStyle.Fill;
            pl_AD_show.Controls.Add(uc_TaiXe);
        }

        private void btn_doanhThu_Click(object sender, EventArgs e)
        {
            pl_AD_show.Controls.Clear();

            // Hiển thị UserControl1
            UC_AD_ThongKe uc_ThongKe = new UC_AD_ThongKe();
            uc_ThongKe.Dock = DockStyle.Fill;
            pl_AD_show.Controls.Add(uc_ThongKe);
        }

        private void FormAD_main_Load(object sender, EventArgs e)
        {
            pl_AD_show.Controls.Clear();
            UC_KH_Main uC_KH_Main = new UC_KH_Main();
            uC_KH_Main.Dock = DockStyle.Fill;
            pl_AD_show.Controls.Add(uC_KH_Main);
        }
    }
}
