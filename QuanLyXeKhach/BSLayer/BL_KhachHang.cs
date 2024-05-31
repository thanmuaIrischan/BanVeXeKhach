using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyXeKhach.DBLayer;

namespace QuanLyXeKhach.BSLayer
{
    public static class KhachHang
    {
        public static string MaKH;
    }
    internal class BL_KhachHang
    {
        Connector db = new Connector();
        public BL_KhachHang() { }
        public DataTable GetViewDichVu()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from View_DichVuWithDoiTacInfo", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public bool DatVe(int maVe, string maChuyenXe, string maKH, int thanhTien)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("[Proc_DatVe]", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaVe", SqlDbType.NVarChar).Value = maVe;
            cmd.Parameters.Add("@MaChuyenXe", SqlDbType.NVarChar).Value = maChuyenXe;
            cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = maKH;
            cmd.Parameters.Add("@TongTien", SqlDbType.NVarChar).Value = thanhTien;
            if (cmd.ExecuteNonQuery() > 0)
            {
                db.CloseConnection();
                return true;
            }
            else
            {
                db.CloseConnection();
                return false;
            }
        }

        public bool UpateVeThanhToan(int maVe, string hinhThuc, int thanhTien, string maDichVu)
        {
            SqlCommand command = new SqlCommand("Pro_UpdateVeThanhToan", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaVe", SqlDbType.Int).Value = maVe;
            command.Parameters.Add("@HinhThucThanhToan", SqlDbType.NVarChar).Value = hinhThuc;
            command.Parameters.Add("@ThanhTien", SqlDbType.Int).Value = thanhTien;
            command.Parameters.Add("@MaDichVu", SqlDbType.NVarChar).Value = maDichVu;
            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                db.CloseConnection();
                return true;
            }
            else
            {
                db.CloseConnection();
                return false;
            }
        }

        public bool UpateChuyenXeDatVe(string maChuyen)
        {
            SqlCommand command = new SqlCommand("Pro_UpdateChuyenXe", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaChuyen", SqlDbType.VarChar).Value = maChuyen;

            db.OpenConnection();
            if (command.ExecuteNonQuery() > 0)
            {
                db.CloseConnection();
                return true;
            }
            else
            {
                db.CloseConnection();
                return false;
            }
        }

        public DataTable LayDichVu()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewDichVu", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable TimKiemDichVu(string ThuocTinh, string NoiDung)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from TimKiemDichVu(@ThuocTinh,@NoiDung)", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@ThuocTinh", SqlDbType.NVarChar).Value = ThuocTinh;
            cmd.Parameters.Add("@NoiDung", SqlDbType.NVarChar).Value = NoiDung;
            adapter.Fill(dt);
            return dt;
        }
        public DataTable LayVeXe()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from [ViewVeXeKhachHang] where MaKH='" + KhachHang.MaKH + "'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable LoadDichVuTrongVeXe(string MaDV)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from LayDichVuVoiMaDV(@MaDichVu)", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            cmd.Parameters.Add("@MaDichVu", SqlDbType.NVarChar).Value = MaDV;
            adapter.Fill(dt);
            return dt;
        }

        public void XoaDichVu(string MaVe)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("HuyDichVu", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaVe", MaVe);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }

        public void XoaVeXe(string MaVe)
        {
            using (SqlConnection connection = new SqlConnection(db.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("proc_XoaVeXe", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaVe", MaVe);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }
        public DataTable LayChuyenXe()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewChuyenXe", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
    }
}
