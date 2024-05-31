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
    public partial class Form_Begin : Form
    {
        private Account.Form_Begin2 begin2;
        public Form_Begin()
        {
            InitializeComponent();
            begin2 = new Account.Form_Begin2();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Hide();
            begin2.Show();
        }
    }
}
