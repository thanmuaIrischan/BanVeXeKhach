using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeKhach.Account
{
    public partial class Form_DangKi : Form
    {
        public Form_DangKi()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if(RDB_KhachHangDK.Checked)
            {
                Account.Form_DangKi_KhachHang form_DangKi_KhachHang = new Account.Form_DangKi_KhachHang();
                form_DangKi_KhachHang.ShowDialog();
                this.Hide();
            }
            else if( RDB_DKdoitac.Checked)
            {
                Account.Form_DangKi_DoiTac form_DangKi_DoiTac = new Account.Form_DangKi_DoiTac();
                form_DangKi_DoiTac.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("bạn chưa chọn đối tượng để đăng kí !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
