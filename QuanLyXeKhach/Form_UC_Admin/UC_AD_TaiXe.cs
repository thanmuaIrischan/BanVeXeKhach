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
    public partial class UC_AD_TaiXe : UserControl
    {
        BL_Admin tasks = new BL_Admin();
        public UC_AD_TaiXe()
        {
            InitializeComponent();
            this.txt_maTaiXe.Enabled = false;
        }

        public void LoadTaiXe()
        {
            this.dgv_taiXe.DataSource = tasks.GetTaiXe();
        }

        private void UC_AD_TaiXe_Load(object sender, EventArgs e)
        {
            LoadTaiXe();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadTaiXe();
            ResetTextBox();
        }

        private void dgv_taiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_taiXe.CurrentCell.RowIndex;
            DisplayInforTaiXe(r);
        }

        public void ResetTextBox()
        {
            this.txt_CCCD.ResetText();
            this.txt_diaChi.ResetText();
            this.txt_gioiTinh.ResetText();
            this.txt_hoTen.ResetText();
            this.txt_maTaiXe.ResetText();
            this.txt_namKinhNghiem.ResetText();
            this.txt_sdt.ResetText();
            this.txt_tuoi.ResetText();
        }
        private void DisplayInforTaiXe(int r)
        {
            this.txt_maTaiXe.Text = this.dgv_taiXe.Rows[r].Cells[0].Value.ToString();
            this.txt_hoTen.Text = this.dgv_taiXe.Rows[r].Cells[1].Value.ToString();
            this.txt_gioiTinh.Text = this.dgv_taiXe.Rows[r].Cells[2].Value.ToString();
            this.txt_tuoi.Text = this.dgv_taiXe.Rows[r].Cells[3].Value.ToString();
            this.txt_CCCD.Text = this.dgv_taiXe.Rows[r].Cells[4].Value.ToString();
            this.txt_sdt.Text = this.dgv_taiXe.Rows[r].Cells[5].Value.ToString();
            this.txt_diaChi.Text = this.dgv_taiXe.Rows[r].Cells[6].Value.ToString();
            this.txt_namKinhNghiem.Text = this.dgv_taiXe.Rows[r].Cells[7].Value.ToString();

        }

        private void btn_themTaiXe_Click(object sender, EventArgs e)
        {
            string hoTen = this.txt_hoTen.Text;
            string gioiTinh = this.txt_gioiTinh.Text;
            int tuoi = int.Parse(this.txt_tuoi.Text);
            string cccd = this.txt_CCCD.Text;
            string sdt = txt_sdt.Text;
            string diaChi = txt_diaChi.Text;
            int namKinhNghiem = int.Parse(txt_namKinhNghiem.Text);


            if (tasks.ThemTaiXe(hoTen, gioiTinh, tuoi, cccd, sdt, diaChi, namKinhNghiem))
            {
                MessageBox.Show("Thêm tài xế thành công!");
            }
            else
            {
                MessageBox.Show("Thêm tài xế thất bại");
            }
            LoadTaiXe();
        }

        private void btn_suaTaiXe_Click(object sender, EventArgs e)
        {
            string maTaiXe = this.txt_maTaiXe.Text;
            string hoTen = this.txt_hoTen.Text;
            string gioiTinh = this.txt_gioiTinh.Text;
            int tuoi = int.Parse(this.txt_tuoi.Text);
            string cccd = this.txt_CCCD.Text;
            string sdt = txt_sdt.Text;
            string diaChi = txt_diaChi.Text;
            int namKinhNghiem = int.Parse(txt_namKinhNghiem.Text);


            if (tasks.SuaTaiXe(maTaiXe, hoTen, gioiTinh, tuoi, cccd, sdt, diaChi, namKinhNghiem))
            {
                MessageBox.Show("Sửa tài xế thành công!");
            }
            else
            {
                MessageBox.Show("Sửa tài xế thất bại");
            }
            LoadTaiXe();
        }

        private void btn_xoaTaiXe_Click(object sender, EventArgs e)
        {
            string maTaiXe = this.txt_maTaiXe.Text;
            if (tasks.XoaTaiXe(maTaiXe))
            {
                MessageBox.Show("Xóa tài xế thành công!");
            }
            else
            {
                MessageBox.Show("Xóa tài xế thất bại");
            }
            LoadTaiXe();
        }
    }
}
