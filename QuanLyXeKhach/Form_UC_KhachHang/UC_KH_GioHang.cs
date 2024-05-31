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
using QuanLyXeKhach.DBLayer;
using QuanLyXeKhach.Control_Ads;
using QuanLyXeKhach.FormKhachHang;

namespace QuanLyXeKhach.Form_UC_KhachHang
{
    public partial class UC_KH_GioHang : UserControl
    {
        public UC_KH_GioHang()
        {
            InitializeComponent();
        }
        BL_KhachHang kh = new BL_KhachHang();
        
        BL_Admin tasks = new BL_Admin();


        private void UC_KH_GioHang_Load(object sender, EventArgs e)
        {
            DTGV_danhsachvedat.DataSource = kh.LayVeXe();
        }

        private void DTGV_danhsachvedat_Click(object sender, EventArgs e)
        {
            string MaDichVu = DTGV_danhsachvedat.CurrentRow.Cells[9].Value.ToString();
            DTGV_dichvudat.DataSource = kh.LoadDichVuTrongVeXe(MaDichVu);
        }

        private void btnHuyDichVu_Click(object sender, EventArgs e)
        {
            string Mavx = DTGV_danhsachvedat.CurrentRow.Cells[0].Value.ToString();
            kh.XoaDichVu(Mavx);
            DTGV_danhsachvedat.DataSource = kh.LayVeXe();
            string MaDichVu = DTGV_danhsachvedat.CurrentRow.Cells[9].Value.ToString();
            DTGV_dichvudat.DataSource = kh.LoadDichVuTrongVeXe(MaDichVu);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            //pl_KH_main.Controls.Clear();
            //UC_KH_Main uC_KH_Main = new UC_KH_Main();
            //uC_KH_Main.Dock = DockStyle.Fill;
            //pl_KH_main.Controls.Add(uC_KH_Main);
        }

        private void btnXemChiTietVe_Click(object sender, EventArgs e)
        {
            txtMaVe.Text = DTGV_danhsachvedat.CurrentRow.Cells[0].Value.ToString();
            txtMaChuyenXe.Text = DTGV_danhsachvedat.CurrentRow.Cells[1].Value.ToString();
            txtMaGhe.Text = DTGV_danhsachvedat.CurrentRow.Cells[2].Value.ToString();
            txtHinhThucThanhToan.Text = DTGV_danhsachvedat.CurrentRow.Cells[3].Value.ToString();
            txtTrangThaiThanhToan.Text = DTGV_danhsachvedat.CurrentRow.Cells[4].Value.ToString();
            txtGiaVe.Text = DTGV_danhsachvedat.CurrentRow.Cells[5].Value.ToString();
            txtThanhTien.Text = DTGV_danhsachvedat.CurrentRow.Cells[6].Value.ToString();
            txtNgayKhoiHanh.Text = DTGV_danhsachvedat.CurrentRow.Cells[7].Value.ToString();
            txtGioKhoiHanh.Text = DTGV_danhsachvedat.CurrentRow.Cells[8].Value.ToString();
            txtMaDichVu.Text = DTGV_danhsachvedat.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            string mave = DTGV_danhsachvedat.CurrentRow.Cells[0].Value.ToString();
            int maVe = int.Parse(mave);
            tasks.XoaHoaDon(maVe);
            if (tasks.HuyVe(maVe))
                MessageBox.Show("Hủy vé thành công!");

            else
                MessageBox.Show("Hủy vé thành công!");
            DTGV_danhsachvedat.DataSource = kh.LayVeXe();
        }
    }
}
