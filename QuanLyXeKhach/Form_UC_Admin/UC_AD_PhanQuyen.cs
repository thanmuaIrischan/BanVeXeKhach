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
    public partial class UC_AD_PhanQuyen : UserControl
    {

        BL_Admin tasks = new BL_Admin();    
        public UC_AD_PhanQuyen()
        {
            InitializeComponent();
            this.txt_maPQ.Enabled = false;
        }

        private void btn_hienPQ_KH_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = tasks.GetPhanQuyenTheoLoai("khach hang");
        }

        private void btn_hienPQ_DT_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = tasks.GetPhanQuyenTheoLoai("Doi tac");
        }        

        
        private void LoadPhanQuyen()
        {
            this.dataGridView1.DataSource = tasks.GetPhanQuyen();
        }
        private void reloadPhanQuyen()
        {
            this.txt_maPQ.ResetText();
            this.txt_loaiPQ.ResetText();
            this.txt_tenDangNhap.ResetText();
            this.txt_MK.ResetText();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            reloadPhanQuyen();
            LoadPhanQuyen();
        }

        private void UC_AD_PhanQuyen_Load(object sender, EventArgs e)
        {
            LoadPhanQuyen();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dataGridView1.CurrentCell.RowIndex;
            DisplayInforPhanQuyen(r);

        }

        private void DisplayInforPhanQuyen(int r)
        {
            this.txt_maPQ.Text = this.dataGridView1.Rows[r].Cells[0].Value.ToString();
            this.txt_loaiPQ.Text = this.dataGridView1.Rows[r].Cells[1].Value.ToString();
            this.txt_tenDangNhap.Text = this.dataGridView1.Rows[r].Cells[2].Value.ToString();
            this.txt_MK.Text = this.dataGridView1.Rows[r].Cells[3].Value.ToString();
        }

        private void btn_suaPQ_Click_1(object sender, EventArgs e)
        {
            int maPQ = int.Parse(txt_maPQ.Text);
            string loaiPQ = this.txt_loaiPQ.Text;
            string tenDangNhap = this.txt_tenDangNhap.Text;
            string matKhau = this.txt_MK.Text;
            if (tasks.SuaPhanQuyen(maPQ, loaiPQ, tenDangNhap, matKhau))
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Sửa thất bại!");

            LoadPhanQuyen();
            reloadPhanQuyen();
        }
    }
}
