using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyXeKhach.BSLayer;
using QuanLyXeKhach.DBLayer;
using QuanLyXeKhach.Form_UC_KhachHang;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QuanLyXeKhach.Form_UC_KhachHang
{
    public partial class UC_KH_DichVu : UserControl
    {
        Connector db = new Connector();
        public UC_KH_DichVu()
        {
            InitializeComponent();
        }
        BL_KhachHang kh = new BL_KhachHang();

        private void btnTimDichVu_Click(object sender, EventArgs e)
        {
            DTGV_DanhSachDichVu.DataSource = kh.TimKiemDichVu(CCBTimDichVu.Text, txtTimKiemDichVu.Text);
        }

        private void UC_KH_DichVu_Load(object sender, EventArgs e)
        {

            DataTable dtDichVu = kh.LayDichVu();
            DTGV_DanhSachDichVu.DataSource = dtDichVu;


            CCBTimDichVu.Items.Add("MaDichVu");
            CCBTimDichVu.Items.Add("MaDoiTac");
            CCBTimDichVu.Items.Add("TenDichVu");
        }

        private void DTGV_DanhSachDichVu_DoubleClick(object sender, EventArgs e)
        {
            txtMaDV.Text = DTGV_DanhSachDichVu.CurrentRow.Cells[0].Value.ToString();
            txtDoiTac.Text = DTGV_DanhSachDichVu.CurrentRow.Cells[1].Value.ToString();
            txtTenDV.Text = DTGV_DanhSachDichVu.CurrentRow.Cells[2].Value.ToString();
            txtGiaDV.Text = DTGV_DanhSachDichVu.CurrentRow.Cells[3].Value.ToString();
            txtGhiChu.Text = DTGV_DanhSachDichVu.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DataTable dtDichVu = kh.LayDichVu();
            DTGV_DanhSachDichVu.DataSource = dtDichVu;
        }
    }
}
