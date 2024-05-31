using QuanLyXeKhach.BSLayer;
using QuanLyXeKhach.Form_UC_Admin;
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

namespace QuanLyXeKhach.Form_UC_KhachHang
{
    public partial class Form_DatVeKH : Form
    {
        BL_Admin tasks = new BL_Admin();
        BL_KhachHang task = new BL_KhachHang();
        private string maChuyenXe;
        private static List<Ve> maVe = new List<Ve>();
        private Button selectedButton = null;
        int tong = 0;
        int giaVe = 0;
        CultureInfo culture = new CultureInfo("vi-VN");
        public Form_DatVeKH(string maChuyenXe)
        {
            InitializeComponent();
            this.maChuyenXe = maChuyenXe;
            hienVeTheoChuyenXe(maChuyenXe);
            this.lbl_maKH.Text = KhachHang.MaKH;     //Truyền mã khách hàng vô đây
            this.txt_maDichVu.Text = "DV1";
            this.txt_giaDichVu.Text = "0";
        }

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
                            btn.BackColor = Color.LightGoldenrodYellow;
                        }
                        else
                        {
                            btn.BackColor = Color.LightGoldenrodYellow;
                            btn.BackColor = Color.Gray;
                            btn.ForeColor = Color.White;
                            btn.Enabled = false;
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
                            btn.BackColor = Color.LightGoldenrodYellow;
                        }
                        else
                        {
                            btn.BackColor = Color.LightGoldenrodYellow;
                            btn.BackColor = Color.Gray;
                            btn.ForeColor = Color.White;
                            btn.Enabled = false;
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

            if (selectedButton != null)
            {
                // Nếu đã có nút được chọn trước đó, chuyển màu về vàng nhạt
                selectedButton.BackColor = Color.LightGoldenrodYellow;
            }

            if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.LightGoldenrodYellow;
                resetText();
                selectedButton = null; 
            }
            else
            {
                CultureInfo culture = new CultureInfo("vi-VN");
                btn.BackColor = Color.Yellow;
                txt_tongTien.Text = ve.MaGhe;
                txt_maVe.Text = ve.Id.ToString();
                txt_maGhe.Text = ve.MaGhe;
                txt_maChuyen.Text = ve.MaChuyen;
                txt_tongTien.Text = ve.GiaVe.ToString("c", culture);
                giaVe = ve.GiaVe;
                selectedButton = btn; 
            }
        }

        public void resetText()
        {
            this.txt_maVe.ResetText();
            this.txt_maChuyen.ResetText();
            this.txt_tongTien.ResetText();
            this.txt_maGhe.ResetText();
            this.txt_maDichVu.Text = "DV1";
            this.txt_giaDichVu.Text = "0";
            this.cbb_hinhThuc.ResetText();
            //this.txt_giaDichVu.ResetText();
        }


        public void loadDichVu()
        {
            this.dgv_dichVu.DataSource = task.GetViewDichVu();
        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form_DatVeKH_Load(object sender, EventArgs e)
        {
            loadDichVu();
        }

        public void tinhTong()
        {

        }

        private void dgv_dichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = this.dgv_dichVu.CurrentCell.RowIndex;
            this.txt_maDichVu.Text = this.dgv_dichVu.Rows[r].Cells[0].Value.ToString();
            this.txt_giaDichVu.Text = this.dgv_dichVu.Rows[r].Cells[3].Value.ToString();
            int giaDichVu = int.Parse(this.txt_giaDichVu.Text);
            tong = giaDichVu + giaVe;
            this.txt_tongTien.Text = tong.ToString("c", culture);
        }

        private void btn_huyDichVu_Click(object sender, EventArgs e)
        {
            //CultureInfo culture = new CultureInfo("vi-VN");
            this.txt_tongTien.Text = giaVe.ToString("c", culture);
            tong = giaVe;
            this.txt_maDichVu.ResetText();
            this.cbb_hinhThuc.ResetText();
            this.txt_maDichVu.Text = "DV1";
            this.txt_giaDichVu.Text = "0";
            //this.txt_giaDichVu.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int maVe = int.Parse(txt_maVe.Text);
            string maChuyenXe = txt_maChuyen.Text;
            string maKH = lbl_maKH.Text;
            string hinhThuc = cbb_hinhThuc.Text;
            string maDichVu = txt_maDichVu.Text;
            int giaDichVu = int.Parse(this.txt_giaDichVu.Text);
            if(this.txt_giaDichVu.Text == "0")
                tong = giaVe;
            task.DatVe(maVe, maChuyenXe, maKH, tong);
            task.UpateVeThanhToan(maVe, hinhThuc, tong, maDichVu);           
            if (task.UpateChuyenXeDatVe(maChuyenXe))
            {
                MessageBox.Show("Đặt vé thành công!");
            }
            else
            {
                MessageBox.Show("Đặt vé thất bại");
            }
            flp_veXe.Controls.Clear();
            flp_veXe2.Controls.Clear();
            hienVeTheoChuyenXe(maChuyenXe);
            resetText();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
