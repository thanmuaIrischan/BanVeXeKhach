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

namespace QuanLyXeKhach
{
    public partial class FormMain_KhachHang : Form
    {
        public FormMain_KhachHang()
        {
            InitializeComponent();
            UC_Main myUC_Ads = new UC_Main();
            plMain_Show.Controls.Add(myUC_Ads);
        }
        

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void plMain_show_Paint(object sender, PaintEventArgs e)
        {

        }

        private void csbtn_Home_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {

        }

        private void customButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
