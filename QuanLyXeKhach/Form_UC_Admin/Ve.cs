using QuanLyXeKhach.DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeKhach.Form_UC_Admin
{
    internal class Ve
    {
        private int id;
        private string maGhe;
        private int trangThai;
        Connector db = new Connector();
        private string maChuyen;
        private string hinhThuc;
        private int giaVe;
        private int thanhTien;
        //private DateTime ngayKhoiHanh;
        //private TimeSpan gioKhoiHanh;

        public int Id { get => id; set => id = value; }
        public string MaGhe { get => maGhe; set => maGhe = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string MaChuyen { get => maChuyen; set => maChuyen = value; }
        public string HinhThuc { get => hinhThuc; set => hinhThuc = value; }

        public int GiaVe { get => giaVe; set => giaVe = value; }

        public int ThanhTien { get => thanhTien; set => thanhTien = value; }

        //public DateTime NgayKhoiHanh { get => ngayKhoiHanh; set => ngayKhoiHanh = value; }

        //public TimeSpan GioKhoiHanh { get => gioKhoiHanh; set => gioKhoiHanh = value; }




        public Ve() { }

        public Ve(DataRow row)
        {
            Id = (int)row["MaVe"];
            MaGhe = row["MaGhe"].ToString();
            TrangThai = (int)row["TrangThaiThanhToan"];
            MaChuyen = row["MaChuyenXe"].ToString();
            HinhThuc = row["HinhThucThanhToan"].ToString();
            GiaVe = (int)row["GiaVe"];
            thanhTien.ToString();
        }

        public DataTable GetHoaDon(string maGhe)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from func_InfoHoaDon (@string)", db.GetConnection());
            cmd.Parameters.Add("@string", SqlDbType.VarChar).Value = maGhe;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
