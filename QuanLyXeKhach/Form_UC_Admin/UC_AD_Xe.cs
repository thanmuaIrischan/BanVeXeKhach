using QuanLyXeKhach.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeKhach.Form_UC_Admin
{
    public partial class UC_AD_Xe : UserControl
    {
        BL_Admin tasks = new BL_Admin();
        public UC_AD_Xe()
        {
            InitializeComponent();
            this.txt_maLoaiXe.Enabled = false;
        }

        public void LoadXe()
        {
            this.dgv_xe.DataSource = tasks.GetXe();         //Hiện xe lên dgv
        }

        public void LoadLoaiXe()
        {
            this.dgv_loaiXe.DataSource = tasks.GetLoaiXe();

        }


        private void dgv_xe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int r = this.dgv_loaiXe.CurrentCell.RowIndex;
            //DisplayInforLoaiXe(r);
        }

        private void DisplayInforLoaiXe(int r)
        {
            this.txt_maLoaiXe.Text = this.dgv_loaiXe.Rows[r].Cells[0].Value.ToString();
            this.txt_tenLoaiXe.Text = this.dgv_loaiXe.Rows[r].Cells[1].Value.ToString();
            this.txt_soHangGhe.Text = this.dgv_loaiXe.Rows[r].Cells[2].Value.ToString();
            this.txt_soGhe1Hang.Text = this.dgv_loaiXe.Rows[r].Cells[3].Value.ToString();
        }

        private void UC_AD_Xe_Load(object sender, EventArgs e)
        {
            LoadXe();
            LoadLoaiXe();
        }

        private void btn_themLoaiXe_Click(object sender, EventArgs e)
        {
            string tenLoaiXe = txt_tenLoaiXe.Text;
            int soHangGhe = int.Parse(txt_soHangGhe.Text);
            int soGhe1Hang = int.Parse(txt_soGhe1Hang.Text);
            if (tasks.ThemLoaiXe(tenLoaiXe, soHangGhe, soGhe1Hang))
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadLoaiXe();
            reloadLoaiXe();
        }

        private void btn_xoaLoaiXe_Click(object sender, EventArgs e)
        {
            string maLoaiXe = this.txt_maLoaiXe.Text;
            if (tasks.XoaLoaiXe(maLoaiXe))
            {
                MessageBox.Show("Xóa thành công!");

            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            LoadLoaiXe();
            reloadLoaiXe();
        }

        private void btn_suaLoaiXe_Click(object sender, EventArgs e)
        {
            string maLoaiXe = this.txt_maLoaiXe.Text;
            string tenLoaiXe = this.txt_tenLoaiXe.Text;
            int soHangGhe = int.Parse(this.txt_soHangGhe.Text);
            int soGheMotHang = int.Parse(this.txt_soGhe1Hang.Text);
            if (tasks.SuaLoaiXe(maLoaiXe, tenLoaiXe, soHangGhe, soGheMotHang))
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Sửa thất bại!");

            LoadLoaiXe();
            reloadLoaiXe();
        }

        public void reloadLoaiXe()
        {
            this.txt_maLoaiXe.ResetText();
            this.txt_tenLoaiXe.ResetText();
            this.txt_soHangGhe.ResetText();
            this.txt_soGhe1Hang.ResetText();
        }

        public void reloadXe()
        {
            this.txt_bienSo.ResetText();
            this.txt_MaLoai.ResetText();
            this.txt_MauXe.ResetText();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadLoaiXe();
            LoadXe();
            reloadLoaiXe();
            reloadXe();
        }

        private void DisplayInforXe(int r)
        {
            this.txt_bienSo.Text = this.dgv_xe.Rows[r].Cells[0].Value.ToString();
            this.txt_MaLoai.Text = this.dgv_xe.Rows[r].Cells[1].Value.ToString();
            this.txt_MauXe.Text = this.dgv_xe.Rows[r].Cells[2].Value.ToString();
        }
        

        private void dgv_xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_xe.CurrentCell.RowIndex;
            DisplayInforXe(r);
        }

        private void btn_themXe_Click_1(object sender, EventArgs e)
        {
            string maLoai = this.txt_MaLoai.Text;
            string bienSo = this.txt_bienSo.Text;
            string mauXe = this.txt_MauXe.Text;
            if (tasks.ThemXe(bienSo, maLoai, mauXe))
            {
                MessageBox.Show("Thêm thành công!");

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadXe();
            reloadXe();
        }

        private void btn_suaXe_Click(object sender, EventArgs e)
        {
            string maLoai = this.txt_MaLoai.Text;
            string bienSo = this.txt_bienSo.Text;
            string mauXe = this.txt_MauXe.Text;
            if (tasks.SuaXe(bienSo, maLoai, mauXe))
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Sửa thất bại!");

            LoadXe();
            reloadXe();
        }

        private void btn_xoaXe_Click_1(object sender, EventArgs e)
        {
            string bienSo = this.txt_bienSo.Text;
            if (tasks.XoaXe(bienSo))
            {
                MessageBox.Show("Xóa thành công!");

            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            LoadXe();
            reloadXe();
        }


        private void dgv_loaiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_loaiXe.CurrentCell.RowIndex;
            DisplayInforLoaiXe(r);
        }
    }
}
