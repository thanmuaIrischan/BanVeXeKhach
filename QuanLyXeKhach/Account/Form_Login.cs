using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyXeKhach.DBLayer;
using QuanLyXeKhach.Form_UC_DoiTac;
using QuanLyXeKhach.FormKhachHang;
using QuanLyXeKhach.Form_UC_Admin;
using QuanLyXeKhach.BSLayer;

namespace QuanLyXeKhach.Account
{
    public partial class Form_Login : Form
    {
        private Account.Form_DangKi Form_DangKi;
        private string MaDoiTac = "";
        private string MaKhachHang = "";

        FormDT_main fDT = new FormDT_main();
        FormAD_main fAD = new FormAD_main();
        FormKH_main fKH = new FormKH_main();

        Connector db = new Connector();
        public Form_Login()
        {
            InitializeComponent();
            Form_DangKi = new Account.Form_DangKi();
        }
        
        

        private void customButton2_Click(object sender, EventArgs e)
        {
            Hide();
            Form_DangKi.Show();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (RDB_KhachHang.Checked)
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from [ViewPhanQuyen_KhachHang] where TenDangNhap ='" + txtTenDangNhap.Text + "' and MatKhau='" + txtMatKhau.Text + "'", db.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu.");
                    txtMatKhau.ResetText();
                    txtTenDangNhap.ResetText();
                    txtTenDangNhap.Focus();
                }
                else if (dt.Rows.Count > 0)
                {
                    MaKhachHang = dt.Rows[0]["MaKH"].ToString();
                    KhachHang.MaKH = MaKhachHang;
                    this.Close();
                    fKH.Show();
                }

            }
            else if (RDB_DoiTac.Checked)
            {
                
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from [ViewPhanQuyen_DoiTac] where TenDangNhap ='" + txtTenDangNhap.Text + "' and MatKhau='" + txtMatKhau.Text + "'", db.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu.");
                    txtMatKhau.ResetText();
                    txtTenDangNhap.ResetText();
                    txtTenDangNhap.Focus();
                }
                else if (dt.Rows.Count > 0)
                {
                    MaDoiTac = dt.Rows[0]["MaDoiTac"].ToString();
                    DoiTac.MaDT = MaDoiTac;
                    this.Close();
                    fDT.Show();
                }    
            }
            else if (RDB_Admin.Checked)
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from PhanQuyen where TenDangNhap ='" + txtTenDangNhap.Text + "' and MatKhau='" + txtMatKhau.Text + "'", db.GetConnection());
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu.");
                    txtMatKhau.ResetText();
                    txtTenDangNhap.ResetText();
                    txtTenDangNhap.Focus();
                }
                else if (dt.Rows.Count > 0)
                {
                    this.Close();
                    fAD.Show();
                }
            }
            else
            {
                MessageBox.Show("bạn chưa chọn đối tượng để đăng kí !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát chương trình không?");
            this.Close();
        }
    }
}
