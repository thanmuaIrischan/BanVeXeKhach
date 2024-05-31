using QuanLyXeKhach.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuanLyXeKhach.Form_UC_Admin
{
    public partial class UC_AD_ThongKe : UserControl
    {
        BL_Admin tasks = new BL_Admin();
        public UC_AD_ThongKe()
        {
            InitializeComponent();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            this.dataGridView1.DataSource = tasks.DoanhThuTheoNgay(dtpTuNgay.Value,dtpDenNgay.Value);
            this.dgv_QC.DataSource = tasks.DoanhThuQCTheoNgay(dtpTuNgay.Value, dtpDenNgay.Value);
            this.txtDoanhThuVe.Text = GetSumRevenue().ToString("c", culture);
            this.txt_doanhThuQC.Text = GetSumRevenueQC().ToString("c", culture);
            this.txt_Tong.Text = GetSumRevenueTong().ToString("c", culture);
        }

        decimal GetSumRevenue()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Tổng tiền"].Value);
            }
            return sum;
        }

        decimal GetSumRevenueQC()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgv_QC.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Giá quảng cáo"].Value);
            }
            return sum;
        }

        decimal GetSumRevenueTong()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dgv_QC.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Giá quảng cáo"].Value);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Tổng tiền"].Value);
            }
            return sum;
        }


    }
}
