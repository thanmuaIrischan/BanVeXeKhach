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
    public partial class UC_AD_ChuyenXe : UserControl
    {
        BL_Admin tasks = new BL_Admin();
        private string diemDon = "%";
        private string diemTra = "%";

        public UC_AD_ChuyenXe()
        {
            InitializeComponent();
            this.txt_maChuyen.Enabled = false;
            this.txt_SoGheTrong.Enabled = false;
        }

        public void LoadForm()
        {
            this.txt_diemDon.Text = String.Empty;
            this.txt_diemTra.Text = String.Empty;
            //this.dtp_TimNgayKH.Value == DateTime.MinValue;
        }

        private void pl_TimKiemDichVu_Click(object sender, EventArgs e)
        {

        }

        public void ResetVariable()
        {
            diemDon = (this.txt_timDiemDau.Text == String.Empty) ? "%" : this.txt_timDiemDau.Text;
            diemTra = (this.txt_timDiemCuoi.Text == String.Empty) ? "%" : this.txt_timDiemCuoi.Text;
            DateTime? ngayKhoiHanhDateTime = (this.dtp_TimNgayKH.Value == DateTime.MinValue) ? (DateTime?)null : this.dtp_TimNgayKH.Value;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
            diemDon = (this.txt_timDiemDau.Text == String.Empty) ? "%" : this.txt_timDiemDau.Text;
            diemTra = (this.txt_timDiemCuoi.Text == String.Empty) ? "%" : this.txt_timDiemCuoi.Text;
            DateTime? ngayKhoiHanhDateTime = (this.dtp_TimNgayKH.Value == DateTime.MinValue) ? (DateTime?)null : this.dtp_TimNgayKH.Value;


            DateTime ngayKhoiHanh = ngayKhoiHanhDateTime.GetValueOrDefault();

            this.dgv_doiTac.DataSource = tasks.TimChuyenXe(this.diemDon, this.diemTra, ngayKhoiHanh);


        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string bienSoXe = this.txt_maLoaiXe.Text; 
            string maTaiXe = this.txt_daiDien.Text; 
            string diemDon = this.txt_diemDon.Text;
            string diemTra = this.txt_diemTra.Text;

            //DateTime ngayKhoiHanh = DateTime.Parse(this.txt_ngayKhoiHanh.Text);
            DateTime ngayKhoiHanh = dtp_ngayKhoiHanh.Value.Date;
            TimeSpan gioKhoiHanh = TimeSpan.Parse(this.txt_gioKhoiHanh.Text);
            string maTuyenDuong = this.txt_maTuyenDuong.Text;
            int gia = int.Parse(this.txt_GiaVe.Text);

            if (tasks.ThemChuyenXe(bienSoXe, maTaiXe, diemDon, diemTra, ngayKhoiHanh, gioKhoiHanh,maTuyenDuong, gia))
            {
                MessageBox.Show("Thêm chuyến xe thành công!");
            }
            else
            {
                MessageBox.Show("Thêm chuyến xe thất bại");
            }

            // Cập nhật lại danh sách chuyến xe sau khi thêm
            //LoadChuyenXe();
        }

        private void dgv_doiTac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_doiTac.CurrentCell.RowIndex;
            DisplayInforChuyen(r);
        }
        public void LoadChuyenXe()
        {
            this.dgv_doiTac.DataSource = tasks.GetChuyenXe();
        }

        private void DisplayInforChuyen(int r)
        {
            this.txt_maChuyen.Text = this.dgv_doiTac.Rows[r].Cells[0].Value.ToString();
            this.txt_maLoaiXe.Text = this.dgv_doiTac.Rows[r].Cells[1].Value.ToString();
            this.txt_daiDien.Text = this.dgv_doiTac.Rows[r].Cells[2].Value.ToString();
            this.txt_diemDon.Text = this.dgv_doiTac.Rows[r].Cells[3].Value.ToString();
            this.txt_diemTra.Text = this.dgv_doiTac.Rows[r].Cells[4].Value.ToString();
            //this.dtp_ngayKhoiHanh.Test = DateTime.Parse(this.dgv_doiTac.Rows[r].Cells[5].Value.ToString());
            this.txt_gioKhoiHanh.Text = this.dgv_doiTac.Rows[r].Cells[6].Value.ToString();
            this.txt_GiaVe.Text = this.dgv_doiTac.Rows[r].Cells[7].Value.ToString();
            this.txt_maTuyenDuong.Text = this.dgv_doiTac.Rows[r].Cells[8].Value.ToString();
            this.txt_SoGheTrong.Text = this.dgv_doiTac.Rows[r].Cells[9].Value.ToString();
        }

        private void UC_AD_ChuyenXe_Load(object sender, EventArgs e)
        {
            LoadChuyenXe();
        }

        public void ResetTextBox()
        {
            this.txt_maLoaiXe.ResetText();
            this.txt_diemDon.ResetText();
            this.txt_diemTra.ResetText();
            this.txt_GiaVe.ResetText();
            this.txt_gioKhoiHanh.ResetText();
            this.txt_maChuyen.ResetText();
            this.txt_daiDien.ResetText();
            this.txt_maTuyenDuong.ResetText();
            this.txt_SoGheTrong.ResetText();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maChuyenXe = this.txt_maChuyen.Text;
            string bienSoXe = this.txt_maLoaiXe.Text;
            string maTaiXe = this.txt_daiDien.Text;
            string diemDon = this.txt_diemDon.Text;
            string diemTra = this.txt_diemTra.Text;
            DateTime ngayKhoiHanh = dtp_ngayKhoiHanh.Value.Date;
            TimeSpan gioKhoiHanh = TimeSpan.Parse(this.txt_gioKhoiHanh.Text);
            string maTuyenDuong = this.txt_maTuyenDuong.Text;
            int gia = int.Parse(this.txt_GiaVe.Text);

            if (tasks.SuaChuyenXe(maChuyenXe, bienSoXe, maTaiXe, diemDon, diemTra, ngayKhoiHanh, gioKhoiHanh, maTuyenDuong, gia))
            {
                MessageBox.Show("Sửa chuyến xe thành công!");
            }
            else
            {
                MessageBox.Show("Sửa chuyến xe thất bại");
            }
            LoadChuyenXe();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maChuyenXe = this.txt_maChuyen.Text;
            if (tasks.XoaChuyenXe(maChuyenXe))
            {
                MessageBox.Show("Xóa chuyến xe thành công!");
            }
            else
            {
                MessageBox.Show("Xóa chuyến xe thất bại");
            }
            LoadChuyenXe();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadChuyenXe();
            reset();
        }

        public void reset()
        {
            this.txt_maChuyen.ResetText();
            this.txt_maLoaiXe.ResetText();
            this.txt_daiDien.ResetText();
            this.txt_diemDon.ResetText();
            this.txt_diemTra.ResetText();
            this.dtp_ngayKhoiHanh.ResetText();
            this.txt_gioKhoiHanh.ResetText();
            this.txt_GiaVe.ResetText();
            this.txt_maTuyenDuong.ResetText();
            this.txt_SoGheTrong.ResetText();
            this.txt_timDiemDau.ResetText();
            this.txt_timDiemCuoi.ResetText();
            this.dtp_TimNgayKH.ResetText();
        }
    }
}
