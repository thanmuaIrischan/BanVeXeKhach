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

namespace QuanLyXeKhach.Form_UC_DoiTac
{
    public partial class UC_DT_QuangCao : UserControl
    {
        BL_DoiTac tasks = new BL_DoiTac();
        public UC_DT_QuangCao()
        {
            InitializeComponent();
            this.tbMaQC.Enabled = false;
            this.tbTrangThaiQC.Enabled = false;
            this.tbMaDT.Text = DoiTac.MaDT;
            this.tbMaDT.Enabled = false;
        }
        public void LoadQuangCao()
        {
            this.dgv_QuangCaoNoiBo.DataSource = tasks.GetQuangCao();
        }
        public void LoadTimKiem()
        {
            cbTimKiemQC.Items.Add("Mã quảng cáo");
            cbTimKiemQC.Items.Add("Tên quảng cáo");
            cbTimKiemQC.Items.Add("Ngày bắt đầu");
            cbTimKiemQC.Items.Add("Ngày ngày kết thúc");
            cbTimKiemQC.Items.Add("Vị trí hiển thị");
            cbTimKiemQC.Items.Add("Trạng thái quảng cáo");
            cbTimKiemQC.Items.Add("Giá quảng cáo");
        }
        private void UC_DT_QuangCao_Load(object sender, EventArgs e)
        {
            LoadQuangCao();
            LoadTimKiem();
            dgv_QuangCaoNoiBo.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv_QuangCaoNoiBo.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void dgv_QuangCaoNoiBo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = this.dgv_QuangCaoNoiBo.CurrentCell.RowIndex;
            DisplayInforQuangCao(r);
        }

        private void DisplayInforQuangCao(int r)
        {
            this.tbMaQC.Text = this.dgv_QuangCaoNoiBo.Rows[r].Cells[0].Value.ToString();
            this.tbMaDT.Text = this.dgv_QuangCaoNoiBo.Rows[r].Cells[1].Value.ToString();
            this.tbTenQC.Text = this.dgv_QuangCaoNoiBo.Rows[r].Cells[2].Value.ToString();
            this.tbMoTa.Text = this.dgv_QuangCaoNoiBo.Rows[r].Cells[3].Value.ToString();
            this.dtpNgayBatDau.Text = this.dgv_QuangCaoNoiBo.Rows[r].Cells[4].Value.ToString();
            this.dtpNgayKetThuc.Text = this.dgv_QuangCaoNoiBo.Rows[r].Cells[5].Value.ToString();
            this.tbViTri.Text = this.dgv_QuangCaoNoiBo.Rows[r].Cells[6].Value.ToString();
            this.tbTrangThaiQC.Text = this.dgv_QuangCaoNoiBo.Rows[r].Cells[7].Value.ToString();
            this.tbGia.Text = this.dgv_QuangCaoNoiBo.Rows[r].Cells[8].Value.ToString();

        }
        public void ResetTextBox()
        {
            this.tbMaQC.ResetText();
            this.tbTenQC.ResetText();
            this.tbMoTa.ResetText();
            this.dtpNgayBatDau.ResetText();
            this.dtpNgayKetThuc.ResetText();
            this.tbViTri.ResetText();
            this.tbTrangThaiQC.ResetText();
            this.tbGia.ResetText();
        }

        private void btnReloadDV_Click(object sender, EventArgs e)
        {
            LoadQuangCao();
            ResetTextBox();
        }


        private void btnDangKiQuangCao_Click(object sender, EventArgs e)
        {
            string maDoiTac = tbMaDT.Text;
            string tenQuangCao = tbTenQC.Text;
            string moTa = tbMoTa.Text;
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;
            string viTri = tbViTri.Text;
            int trangThaiQC = 0;
            int giaQuangCao = int.Parse(tbGia.Text);
            if (tasks.ThemQuangCao(maDoiTac, tenQuangCao, moTa, ngayBatDau, ngayKetThuc, viTri, trangThaiQC, giaQuangCao))
            {
                MessageBox.Show("Thêm thành công!");

            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            LoadQuangCao();
            ResetTextBox();
        }

        private void btnYC_HuyQuangCao_Click(object sender, EventArgs e)
        {
            string maQuangCao = this.tbMaQC.Text;
            if (tasks.XoaQuangCao(maQuangCao))
            {
                MessageBox.Show("Xóa thành công!");

            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
            LoadQuangCao();
            ResetTextBox();
        }

        private void btnChinhSuaQuangCao_Click(object sender, EventArgs e)
        {
            string maQuangCao = this.tbMaQC.Text;
            string maDoiTac = tbMaDT.Text;
            string tenQuangCao = tbTenQC.Text;
            string moTa = tbMoTa.Text;
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;
            string viTri = tbViTri.Text;
            int trangThaiQC = int.Parse(tbTrangThaiQC.Text);
            int giaQuangCao = int.Parse(tbGia.Text);
            if (tasks.SuaQuangCao(maQuangCao, maDoiTac, tenQuangCao, moTa, ngayBatDau, ngayKetThuc, viTri, trangThaiQC, giaQuangCao))
                MessageBox.Show("Sửa thành công!");
            else
                MessageBox.Show("Sửa thất bại!");
            LoadQuangCao();
            ResetTextBox();
        }

        private void btnTimKiemQC_Click(object sender, EventArgs e)
        {
            string thuoctinhtimkiem = cbTimKiemQC.Text;
            string noidungtimkiem = tbTimKiemQC.Text;
            dgv_QuangCaoNoiBo.DataSource = tasks.TimKiemQuangCao(thuoctinhtimkiem, noidungtimkiem);
        }
    }
}
