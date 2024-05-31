using QuanLyXeKhach.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuanLyXeKhach.Form_UC_DoiTac
{
    public partial class UC_DT_DichVu : UserControl
    {
        BL_DoiTac tasks = new BL_DoiTac();
        public UC_DT_DichVu()
        {
            InitializeComponent();
            this.tbMaDV.Enabled = false;
            this.tbMaDT.Text = DoiTac.MaDT;
            this.tbMaDT.Enabled = false;

        }
        public void LoadDichVu()
        {
            this.dgv_DichVuNoiBo.DataSource = tasks.GetDichVu();

        }
        public void LoadTimKiem()
        {
            cbTimKiemDichVu.Items.Add("Mã dịch vụ");
            cbTimKiemDichVu.Items.Add("Tên dịch vụ");
            cbTimKiemDichVu.Items.Add("Giá dịch vụ");
            cbTimKiemDichVu.Items.Add("Ghi chú");
        }
        private void UC_DT_DichVu_Load(object sender, EventArgs e)
        {
            LoadDichVu();
            LoadTimKiem();
        }
        private void dgv_DichVuNoiBo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_DichVuNoiBo.CurrentCell.RowIndex;
            DisplayInforDichVu(r);
        }

        private void DisplayInforDichVu(int r)
        {
            this.tbMaDV.Text = this.dgv_DichVuNoiBo.Rows[r].Cells[0].Value.ToString();
            this.tbMaDT.Text = this.dgv_DichVuNoiBo.Rows[r].Cells[1].Value.ToString();
            this.tbTenDV.Text = this.dgv_DichVuNoiBo.Rows[r].Cells[2].Value.ToString();
            this.tbGiaDV.Text = this.dgv_DichVuNoiBo.Rows[r].Cells[3].Value.ToString();
            this.TbGhiChu.Text = this.dgv_DichVuNoiBo.Rows[r].Cells[4].Value.ToString();
        }
        public void ResetTextBox()
        {
            this.tbMaDV.ResetText();
            this.tbTenDV.ResetText();
            this.tbGiaDV.ResetText();
            this.TbGhiChu.ResetText();
        }

        private void btnReloadDV_Click(object sender, EventArgs e)
        {
            LoadDichVu();
            ResetTextBox();
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            string maDoiTac = tbMaDT.Text;
            string tenDichVu = tbTenDV.Text;
            float giaDichVu = float.Parse(tbGiaDV.Text);
            string ghiChu = TbGhiChu.Text;
            if (tasks.ThemDichVu(maDoiTac, tenDichVu, giaDichVu, ghiChu))
            {
                MessageBox.Show("Thêm thành công!");

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadDichVu();
            ResetTextBox();
        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            string maDichVu = this.tbMaDV.Text;
            if (tasks.XoaDichVu(maDichVu))
            {
                MessageBox.Show("Xóa thành công!");

            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            LoadDichVu();
            ResetTextBox();
        }

        private void btnChinhSuaDichVu_Click(object sender, EventArgs e)
        {
            string maDichVu = this.tbMaDV.Text;
            string maDoiTac = this.tbMaDT.Text;
            string tenDichVu = tbTenDV.Text;
            float giaDichVu = float.Parse(tbGiaDV.Text);
            string ghiChu = TbGhiChu.Text;
            if (tasks.SuaDichVu(maDichVu, maDoiTac, tenDichVu, giaDichVu, ghiChu))
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Sửa thất bại!");
            LoadDichVu();
            ResetTextBox();
        }

        private void btnTimDichVuNB_Click(object sender, EventArgs e)
        {
            string thuoctinhtimkiem = cbTimKiemDichVu.Text;
            string noidungtimkiem = tbTimKiem.Text;
            dgv_DichVuNoiBo.DataSource = tasks.TimKiemDichVu(thuoctinhtimkiem, noidungtimkiem);
        }
    }
}
