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
    public partial class UC_AD_VeXe : UserControl
    {
        BL_Admin tasks = new BL_Admin();
        int maVe;
        string maChuyen;
        public UC_AD_VeXe()
        {
            InitializeComponent();
            this.txt_maVe.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void loadChuyenXe()
        {
            this.dgv_ChuyenXe.DataSource = tasks.GetChuyenXe();
        }

        private void UC_AD_VeXe_Load(object sender, EventArgs e)
        {
            loadChuyenXe();
        }

        public void loadVeByMaChuyen(string maChuyen)
        {
            this.dgv_Ve.DataSource = tasks.GetVeByMaChuyen(maChuyen);
        }

        private void dgv_ChuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_ChuyenXe.CurrentCell.RowIndex;
            maChuyen = this.dgv_ChuyenXe.Rows[r].Cells[0].Value.ToString();
            loadVeByMaChuyen(maChuyen);
        }

        public void loadKHByVe(int maVe)
        {
            this.dgv_khachHang.DataSource = tasks.GetKHByVe(maVe);
        }

        private void dgv_Ve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_Ve.CurrentCell.RowIndex;
            maVe = int.Parse(this.dgv_Ve.Rows[r].Cells[0].Value.ToString());
            loadKHByVe(maVe);
            DisplayInforVe(r);
        }

        private void btn_veDaDat_Click(object sender, EventArgs e)
        {
            this.dgv_Ve.DataSource = tasks.GetVeDaDat(maChuyen);
        }

        private void DisplayInforVe(int r)
        {
            this.txt_maVe.Text = this.dgv_Ve.Rows[r].Cells[0].Value.ToString();
            this.txt_maChuyen.Text = this.dgv_Ve.Rows[r].Cells[1].Value.ToString();
            this.txt_maGhe.Text = this.dgv_Ve.Rows[r].Cells[2].Value.ToString();
            this.txt_hinhThucThanhToan.Text = this.dgv_Ve.Rows[r].Cells[3].Value.ToString();
            this.txt_trangThaiThanhToan.Text = this.dgv_Ve.Rows[r].Cells[4].Value.ToString();
            this.txt_giaVe.Text = this.dgv_Ve.Rows[r].Cells[5].Value.ToString();
            this.txt_thanhTien.Text = this.dgv_Ve.Rows[r].Cells[6].Value.ToString();
            this.txt_ngayKhoiHanh.Text = this.dgv_Ve.Rows[r].Cells[7].Value.ToString();
            this.txt_gioKhoiHanh.Text = this.dgv_Ve.Rows[r].Cells[8].Value.ToString();
            this.txt_maDichVu.Text = this.dgv_Ve.Rows[r].Cells[9].Value.ToString();

            if (this.txt_trangThaiThanhToan.Text == "0")
                this.txt_trangThaiThanhToan.Text = "Chưa đặt";
            else
                this.txt_trangThaiThanhToan.Text = "Đã đặt";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txt_gioKhoiHanh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SoDoXe_Click(object sender, EventArgs e)
        {
            Form_VeXe form = new Form_VeXe(maChuyen);
            form.ShowDialog();
        }
    }
}
