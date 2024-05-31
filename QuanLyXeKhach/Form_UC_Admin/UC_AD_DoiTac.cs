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

namespace QuanLyXeKhach.Form_UC_Admin
{
    public partial class UC_AD_DoiTac : UserControl
    {
        BL_Admin tasks = new BL_Admin();
        string maQC;
        public UC_AD_DoiTac()
        {
            InitializeComponent();
            this.txt_maDoiTac.Enabled = false;
            this.txt_maPQ.Enabled = false;
        }

        private void pl_TimKiemDichVu_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_timQC_Click(object sender, EventArgs e)
        {
            this.dgv_QuangCao.DataSource = tasks.GetQCChuaDuyet(0);
        }

        private void btn_DuyetQC_Click(object sender, EventArgs e)
        {
            //string maQuangCao = this.txt.Text;
            if (tasks.DuyetQuangCao(maQC)) 
                MessageBox.Show("Duyệt thành công!");
            else
                MessageBox.Show("Duyệt thất bại!");
            reloadQC();
        }

        public void reloadQC()
        {
            this.dgv_QuangCao.DataSource = tasks.GetQCChuaDuyet(0);
        }

        private void dgv_QuangCao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_QuangCao.CurrentCell.RowIndex;
            maQC = this.dgv_QuangCao.Rows[r].Cells[0].Value.ToString();
        }

        private void btn_tuChoiQC_Click(object sender, EventArgs e)
        {
            this.dgv_QuangCao.DataSource = tasks.GetQCChuaDuyet(1);
        }

        public void LoadQCByMaDT(string maDT)
        {
            this.dgv_QuangCao.DataSource = tasks.GetQCByDT(maDT);
        }

        public void LoadDVByMaDT(string maDT)
        {
            this.dgv_DichVu.DataSource = tasks.GetDVByDT(maDT);
        }

        private void dgv_doiTac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_doiTac.CurrentCell.RowIndex;
            string maDT = this.dgv_doiTac.Rows[r].Cells[0].Value.ToString();
            LoadQCByMaDT(maDT);
            LoadDVByMaDT(maDT);
            DisplayInforDoiTac(r);
        }

               
        private void reloadDoiTac()
        {
            this.txt_maDoiTac.ResetText();
            this.txt_TenDoiTac.ResetText();
            this.txt_HinhThuc.ResetText();
            this.txt_daiDien.ResetText();
            this.txt_email.ResetText();
            this.txt_sdt.ResetText();
            this.txt_diaChi.ResetText();
            this.txt_maPQ.ResetText();
        }
        private void LoadDoiTac()
        {
            this.dgv_doiTac.DataSource = tasks.GetDoiTac();
        }

        private void LoadQuangCao()
        {
            this.dgv_QuangCao.DataSource = tasks.GetQC();
        }

        private void LoadDichVu()
        {
            this.dgv_DichVu.DataSource = tasks.GetDV();
        }
        private void reloadDichVu()
        {

        }
        private void reloadQuangCao()
        {

        }
        private void dgv_doiTac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_doiTac.CurrentCell.RowIndex;
            DisplayInforDoiTac(r);
        }

        private void dgv_QuangCao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_QuangCao.CurrentCell.RowIndex;
            DisplayInforDichVu(r);
        }

        private void dgv_DichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_DichVu.CurrentCell.RowIndex;
            DisplayInforQuangCao(r);
        }
        

        private void DisplayInforDoiTac(int r)
        {
            this.txt_maDoiTac.Text = this.dgv_doiTac.Rows[r].Cells[0].Value.ToString();
            this.txt_TenDoiTac.Text = this.dgv_doiTac.Rows[r].Cells[1].Value.ToString();
            this.txt_HinhThuc.Text = this.dgv_doiTac.Rows[r].Cells[2].Value.ToString();
            this.txt_daiDien.Text = this.dgv_doiTac.Rows[r].Cells[3].Value.ToString();
            this.txt_email.Text = this.dgv_doiTac.Rows[r].Cells[4].Value.ToString();
            this.txt_sdt.Text = this.dgv_doiTac.Rows[r].Cells[5].Value.ToString();
            this.txt_diaChi.Text = this.dgv_doiTac.Rows[r].Cells[6].Value.ToString();
            this.txt_maPQ.Text = this.dgv_doiTac.Rows[r].Cells[7].Value.ToString();
        }
        private void DisplayInforDichVu(int r)
        {

        }
        private void DisplayInforQuangCao(int r)
        {

        }

        private void UC_AD_DoiTac_Load(object sender, EventArgs e)
        {
            LoadDoiTac();
            LoadDichVu();
            LoadQuangCao();
        }

        private void btn_suaĐT_Click_1(object sender, EventArgs e)
        {
            string maDT = this.txt_maDoiTac.Text;
            string tenDoiTac = this.txt_TenDoiTac.Text;
            string hinhThuc = this.txt_HinhThuc.Text;
            string daiDien = this.txt_daiDien.Text;
            string email = this.txt_email.Text;
            string SDT = this.txt_sdt.Text;
            string diaChi = this.txt_diaChi.Text;
            int maPQ = int.Parse(txt_maPQ.Text);
            if (tasks.SuaDoiTac(maDT, tenDoiTac, hinhThuc, daiDien, email, SDT, diaChi, maPQ))
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Sửa thất bại!");

            LoadDoiTac();
            reloadDoiTac();
        }

        private void btn_xoaDT_Click_1(object sender, EventArgs e)
        {
            string maDT = this.txt_maDoiTac.Text;
            if (tasks.XoaDoiTac(maDT))
            {
                MessageBox.Show("Xóa thành công!");

            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            LoadDoiTac();
            reloadDoiTac();
        }

        private void btn_reload_Click_1(object sender, EventArgs e)
        {
            reloadDoiTac();
            LoadDoiTac();
            reloadDichVu();
            LoadDichVu();
            reloadQuangCao();
            LoadQuangCao();
        }

        private void btn_themĐT_Click(object sender, EventArgs e)
        {
            Form_DangKyDT form = new Form_DangKyDT();
            //this.Hide();
            form.ShowDialog();
        }
    }
}
