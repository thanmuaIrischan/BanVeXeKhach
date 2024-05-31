using QuanLyXeKhach.Control_Ads;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyXeKhach.BSLayer;
using QuanLyXeKhach.Account;
namespace QuanLyXeKhach.Form_UC_DoiTac
{
    public partial class FormDT_main : Form
    {
        public FormDT_main()
        {
            InitializeComponent();
            UC_KH_Main uC_KH_Main = new UC_KH_Main();
            uC_KH_Main.Dock = DockStyle.Fill;
            pl_DT_show.Controls.Add(uC_KH_Main);
        }


        private void pl_DT_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            pl_DT_show.Controls.Clear();
            UC_KH_Main uC_KH_Main = new UC_KH_Main();
            uC_KH_Main.Dock = DockStyle.Fill;
            pl_DT_show.Controls.Add(uC_KH_Main);
        }

        private void btnDT_DichVu_Click(object sender, EventArgs e)
        {
            pl_DT_show.Controls.Clear();
            UC_DT_DichVu uC_DT_dichvu = new UC_DT_DichVu();
            uC_DT_dichvu.Dock = DockStyle.Fill;
            pl_DT_show.Controls.Add(uC_DT_dichvu);
        }


        private void btnDt_QuangCao_Click(object sender, EventArgs e)
        {
            pl_DT_show.Controls.Clear();
            UC_DT_QuangCao uC_DT_quangcao = new UC_DT_QuangCao();
            uC_DT_quangcao.Dock = DockStyle.Fill;
            pl_DT_show.Controls.Add(uC_DT_quangcao);
        }

        private void btnNhapMaDT_Click(object sender, EventArgs e)
        {
            //tbNhapMaDT.Text = DoiTac.MaDT;
            tbNhapMaDT.Enabled = false;
        }

        private void btnDT_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login lg = new Form_Login();
            lg.ShowDialog();
        }

        private void tbNhapMaDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDT_main_Load(object sender, EventArgs e)
        {
            tbNhapMaDT.Text = DoiTac.MaDT;
        }
    }
}
