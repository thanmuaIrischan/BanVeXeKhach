using QuanLyXeKhach.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuanLyXeKhach.Form_UC_Admin
{
    public partial class UC_AD_KhachHang : UserControl
    {
        BL_Admin tasks = new BL_Admin();
        string maKH;
        public UC_AD_KhachHang()
        {
            InitializeComponent();
            this.txt_maKH.Enabled = false;
            this.txt_maPhanQuyen.Enabled = false;   
            this.txt_chuyen.Enabled = false;
            this.txt_maVe.Enabled = false;
            this.txt_gio.Enabled = false;
        }

        private void pl_TimKiemDichVu_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangKyKH_Click(object sender, EventArgs e)
        {
            Form_DangKyKH form = new Form_DangKyKH();
            //this.Hide();
            form.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sdt = this.txtTimDichVuNB.Text;
            this.dgv_khachHang.DataSource = tasks.GetKHTheoSDT(sdt);

        }

        private void LoadHDByMaKH(string maKH)
        {
            this.dgv_hoaDon.DataSource = tasks.GetHDByMaKH(maKH);
        }

        private void dgv_khachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = this.dgv_khachHang.CurrentCell.RowIndex;
            maKH = this.dgv_khachHang.Rows[r].Cells[0].Value.ToString();
            LoadHDByMaKH(maKH);
            DisplayInforKhachHang(r);
        }

        private void dgv_hoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_hoaDon.CurrentCell.RowIndex;
            //string maHD = this.dgv_hoaDon.Rows[r].Cells[0].Value.ToString();
            DisplayInforHD(r);
        }

        private void DisplayInforHD(int r)
        {
            this.txt_maVe.Text = this.dgv_hoaDon.Rows[r].Cells[0].Value.ToString();
            this.txt_chuyen.Text = this.dgv_hoaDon.Rows[r].Cells[1].Value.ToString();
            this.txt_gio.Text = this.dgv_hoaDon.Rows[r].Cells[2].Value.ToString();
        }

        private void btn_huyVe_Click(object sender, EventArgs e)
        {
            int maVe = int.Parse(this.txt_maVe.Text);
            tasks.XoaHoaDon(maVe);
            if(tasks.HuyVe(maVe))
                MessageBox.Show("Hủy vé thành công!");

            else
                MessageBox.Show("Hủy vé thành công!");
           LoadHDByMaKH(maKH);

        }

        private void LoadKhachHang()
        {
            this.dgv_khachHang.DataSource = tasks.GetKhachHang();
        }

        private void UC_AD_KhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void DisplayInforKhachHang(int r)
        {
            this.txt_maKH.Text = this.dgv_khachHang.Rows[r].Cells[0].Value.ToString(); ;
            this.txt_hoTen.Text = this.dgv_khachHang.Rows[r].Cells[1].Value.ToString(); ;
            this.txt_gioiTinh.Text = this.dgv_khachHang.Rows[r].Cells[2].Value.ToString(); ;
            this.txt_SDT.Text = this.dgv_khachHang.Rows[r].Cells[3].Value.ToString(); ;
            this.txt_diaChi.Text = this.dgv_khachHang.Rows[r].Cells[4].Value.ToString(); ;
            this.txt_email.Text = this.dgv_khachHang.Rows[r].Cells[5].Value.ToString(); ;
            this.txt_maPhanQuyen.Text = this.dgv_khachHang.Rows[r].Cells[6].Value.ToString(); ;
        }

        private void btn_suaKH_Click(object sender, EventArgs e)
        {
            string maKhachHang = this.txt_maKH.Text;
            string tenKhachHang = this.txt_hoTen.Text;
            string gioiTinh = this.txt_gioiTinh.Text;
            string SDT = this.txt_SDT.Text;
            string diaChi = this.txt_diaChi.Text;
            string Email = this.txt_email.Text;
            int maPhanQuyen = int.Parse(this.txt_maPhanQuyen.Text);
            if (tasks.SuaKhachHang(maKhachHang, tenKhachHang, gioiTinh, SDT, diaChi, Email, maPhanQuyen))
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Sửa thất bại!");

            LoadKhachHang();
            reloadKhachHang();

        }

        private void btn_xoaKH_Click(object sender, EventArgs e)
        {
            string maKH = this.txt_maKH.Text;
            if (tasks.XoaKhachHang(maKH))
            {
                MessageBox.Show("Xóa thành công!");

            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            LoadKhachHang();
            reloadKhachHang();

        }

        private void reloadKhachHang()
        {
            this.txt_maKH.ResetText();
            this.txt_hoTen.ResetText();
            this.txt_gioiTinh.ResetText();
            this.txt_SDT.ResetText();
            this.txt_diaChi.ResetText();
            this.txt_email.ResetText();
            this.txt_maPhanQuyen.ResetText();
            this.txtTimDichVuNB.ResetText();
        }

        public void reloadVe()
        {
            this.txt_chuyen.ResetText();
            this.txt_gio.ResetText();
            this.txt_maVe.ResetText();
            this.dgv_hoaDon.DataSource = null;
        }
        private void btn_reload_Click(object sender, EventArgs e)
        {
            reloadKhachHang();
            LoadKhachHang();
            this.dgv_hoaDon.DataSource = null;
            reloadVe();
        }
    }
}
