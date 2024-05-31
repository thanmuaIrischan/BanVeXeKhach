using QuanLyXeKhach.Form_UC_Admin;
using QuanLyXeKhach.FormKhachHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeKhach
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form_UC_DoiTac.FormDT_main());
            //Application.Run(new FormKhachHang.FormKH_main());
            //Application.Run(new Form_UC_Admin.FormAD_main());
            Application.Run(new Account.Form_Begin());
        }
    }
}
