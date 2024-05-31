using QuanLyXeKhach.BSLayer;
using QuanLyXeKhach.Form_UC_Admin;
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

namespace QuanLyXeKhach.Form_UC_KhachHang
{
    public partial class UC_KH_Chuyenxe : UserControl
    {
        BL_Admin ad = new BL_Admin();
        BL_KhachHang kh = new BL_KhachHang();
        string maChuyen;
        public UC_KH_Chuyenxe()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            string diemDon = (this.txtNoiXuatPhat.Text == String.Empty) ? "%" : this.txtNoiXuatPhat.Text;
            string diemTra = (this.txtNoiDen.Text == String.Empty) ? "%" : this.txtNoiDen.Text;
            DateTime? ngayKhoiHanhDateTime = (this.bunifuDatePicker1.Value == DateTime.MinValue) ? (DateTime?)null : this.bunifuDatePicker1.Value;
            DateTime ngayKhoiHanh = ngayKhoiHanhDateTime.GetValueOrDefault();

            this.dataGridView1.DataSource = ad.TimChuyenXe(diemDon, diemTra, ngayKhoiHanh);
        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            Form_DatVeKH form = new Form_DatVeKH(maChuyen);                    
            form.ShowDialog();
            this.dataGridView1.DataSource = null;
            reset();
        }

        public void reset()
        {
            this.txtNoiDen.ResetText();
            this.txtNoiXuatPhat.ResetText();
            this.lbl_giaVe.Text = "Giá vé";
            this.lbl_gioDen.Text = "Giờ đến";
            this.lbl_gioDi.Text = "Giờ đi";
            this.lbl_noiDen.Text = "Nơi đến";
            this.lbl_noiDi.Text = "Nơi đi";
            this.lbl_soGheTrong.Text = "0";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dataGridView1.CurrentCell.RowIndex;
            maChuyen = this.dataGridView1.Rows[r].Cells[0].Value.ToString();
            DisplayInforVe(r);
        }

        private void DisplayInforVe(int r)
        {
            this.lbl_noiDi.Text = this.dataGridView1.Rows[r].Cells[3].Value.ToString();
            this.lbl_noiDen.Text = this.dataGridView1.Rows[r].Cells[4].Value.ToString();
            this.lbl_gioDi.Text = this.dataGridView1.Rows[r].Cells[6].Value.ToString();
            this.lbl_gioDen.Text = "19:00:00";
            this.lbl_giaVe.Text = this.dataGridView1.Rows[r].Cells[7].Value.ToString();
            this.lbl_soGheTrong.Text = this.dataGridView1.Rows[r].Cells[9].Value.ToString();

        }

        private void UC_KH_Chuyenxe_Load(object sender, EventArgs e)
        {
            DataTable dtChuyenXe = kh.LayChuyenXe();
            dataGridView1.DataSource = dtChuyenXe;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataTable dtChuyenXe = kh.LayChuyenXe();
            dataGridView1.DataSource = dtChuyenXe;
        }
    }
}
