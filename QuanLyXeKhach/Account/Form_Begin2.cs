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
    public partial class Form_Begin2 : Form
    {
        private Account.Form_Login login;
        public Form_Begin2()
        {
            InitializeComponent();
             login = new Account.Form_Login();

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Hide();
            login.Show();
        }
    }
}
