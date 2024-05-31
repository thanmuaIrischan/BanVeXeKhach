using QuanLyXeKhach.BSLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuanLyXeKhach.Form_UC_Admin
{
    public partial class Form_VeXe : Form
    {

        public Form_VeXe(string maChuyenXe)
        {
            InitializeComponent();
            this.maChuyenXe = maChuyenXe;
            hienVeTheoChuyenXe(maChuyenXe);
            //int maVe = int.Parse(this.txt_maVe.Text);
            //DataTable information = tasks.GetKHByVe(maVe);
            //DisplayInfo(information);
        }
        BL_Admin tasks = new BL_Admin();
        private string maChuyenXe;
        //private static List<Ve> maVe = new List<Ve>();
        private Button selectedButton = null;
     

        public void hienVeTheoChuyenXe(string maChuyen)
        {
            int count = 0;
            List<Ve> danhSachVe = tasks.GetSoDoVe(maChuyen);
            int soVe = tasks.DemSoVeTheoChuyenXe(maChuyen);

            if (danhSachVe != null)
            {
                foreach (Ve ve in danhSachVe)
                {
                    if (count < soVe / 2)
                    {
                        int col = count % 10 + 1;
                        int row = count / 10 + 65;
                        Button btn = new Button() { Width = 100, Height = 40 };
                        btn.Text = ve.MaGhe;
                        btn.Font = new Font("Arial", (float)10.5);
                        btn.Click += btn_Click;
                        btn.Tag = ve;

                        if (ve.TrangThai == 0)
                        {
                            
                            btn.BackColor = Color.Gray;
                            btn.ForeColor = Color.White;
                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.BackColor = Color.LightGoldenrodYellow;
                        }

                        flp_veXe.Controls.Add(btn);
                    }

                    if (count >= soVe / 2)
                    {
                        int col = count % 10 + 1;
                        int row = count / 10 + 65;
                        Button btn = new Button() { Width = 100, Height = 40 };
                        btn.Text = ve.MaGhe;
                        btn.Font = new Font("Arial", (float)10.5);
                        btn.Click += btn_Click;
                        btn.Tag = ve;

                        if (ve.TrangThai == 0)
                        {
                            btn.BackColor = Color.Gray;
                            btn.ForeColor = Color.White;                          
                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.BackColor = Color.LightGoldenrodYellow;
                        }

                        flp_veXe2.Controls.Add(btn);
                    }
                    count++;
                }

                
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            Ve ve = (btn.Tag as Ve);
            txt_maVe.Text = ve.Id.ToString();
            selectedButton = btn;
            int maVe = int.Parse(this.txt_maVe.Text);
            DataTable information = tasks.GetKHByVe(maVe);
            DisplayInfo(information);
        }

        private void DisplayInfo(DataTable source)
        {
            this.txt_hoTen.Text = source.Rows[0][1].ToString();
            this.txt_sdt.Text = source.Rows[0][3].ToString();
            this.txt_diaChi.Text = source.Rows[0][4].ToString();
            this.txt_email.Text = source.Rows[0][5].ToString();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
