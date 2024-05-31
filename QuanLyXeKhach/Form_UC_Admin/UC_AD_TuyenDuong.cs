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
    public partial class UC_AD_TuyenDuong : UserControl
    {
        BL_Admin tasks = new BL_Admin();
        public UC_AD_TuyenDuong()
        {
            InitializeComponent();
            this.txt_maTuyen.Enabled = false;
        }
        public void LoadTuyenDuong()
        {
            this.dgv_tuyenDuong.DataSource = tasks.GetTuyenDuong();
        }

        private void UC_AD_TuyenDuong_Load(object sender, EventArgs e)
        {
            LoadTuyenDuong();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadTuyenDuong();
            ResetTextBox();
        }

        private void dgv_tuyenDuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_tuyenDuong.CurrentCell.RowIndex;
            DisplayInforTuyenDuong(r);
        }

        public void ResetTextBox()
        {
            this.txt_maTuyen.ResetText();
            this.txt_tenTuyen.ResetText();
            this.txt_tuyenDau.ResetText();
            this.txt_tuyenCuoi.ResetText();
            this.txt_khoangCach.ResetText();
        }
        private void DisplayInforTuyenDuong(int r)
        {
            this.txt_maTuyen.Text = this.dgv_tuyenDuong.Rows[r].Cells[0].Value.ToString();
            this.txt_tenTuyen.Text = this.dgv_tuyenDuong.Rows[r].Cells[1].Value.ToString();
            this.txt_tuyenDau.Text = this.dgv_tuyenDuong.Rows[r].Cells[2].Value.ToString();
            this.txt_tuyenCuoi.Text = this.dgv_tuyenDuong.Rows[r].Cells[3].Value.ToString();
            this.txt_khoangCach.Text = this.dgv_tuyenDuong.Rows[r].Cells[4].Value.ToString();

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string tenTuyen = this.txt_tenTuyen.Text;
            string tuyenDau = this.txt_tuyenDau.Text;
            string tuyenCuoi = this.txt_tuyenCuoi.Text;
            string khoangCach = txt_khoangCach.Text;

            if (tasks.ThemTuyenDuong(tenTuyen, tuyenDau, tuyenCuoi, khoangCach))
            {
                MessageBox.Show("Thêm tuyến đường thành công!");
            }
            else
            {
                MessageBox.Show("Thêm tuyến đường thất bại");
            }
            LoadTuyenDuong();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maTuyen = this.txt_maTuyen.Text;
            string tenTuyen = this.txt_tenTuyen.Text;
            string tuyenDau = this.txt_tuyenDau.Text;
            string tuyenCuoi = this.txt_tuyenCuoi.Text;
            string khoangCach = txt_khoangCach.Text;

            if (tasks.SuaTuyenDuong(maTuyen, tenTuyen, tuyenDau, tuyenCuoi, khoangCach))
            {
                MessageBox.Show("Sửa tuyến đường thành công!");
            }
            else
            {
                MessageBox.Show("Sửa tuyến đường thất bại");
            }
            LoadTuyenDuong();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maTuyen = this.txt_maTuyen.Text;
            if (tasks.XoaTuyenDuong(maTuyen))
            {
                MessageBox.Show("Xóa tuyến đường thành công!");
            }
            else
            {
                MessageBox.Show("Xóa tuyến đường thất bại");
            }
            LoadTuyenDuong();
        }
    }
}
