using QuanLyXeKhach.DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeKhach.BSLayer
{
    public static class DoiTac
    {
        public static string MaDT;
    }
    internal class BL_DoiTac
    {
        Connector db = new Connector();
        public BL_DoiTac() { }
        
        public DataTable GetDichVu()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewDichVu where MaDoiTac='" + DoiTac.MaDT+"'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetQuangCao()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewQuangCao where MaDoiTac='" + DoiTac.MaDT+ "'", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public bool ThemDichVu(string maDoiTac, string tenDichVu, float giaDichVu, string ghiChu)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_ThemDichVu", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = maDoiTac;
            cmd.Parameters.Add("@TenDichVu", SqlDbType.NVarChar).Value = tenDichVu;
            cmd.Parameters.Add("@GiaDichVu", SqlDbType.Float).Value = giaDichVu;
            cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ghiChu;
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

        public bool XoaDichVu(string maDichVu)
        {
            SqlCommand command = new SqlCommand("proc_XoaDichVu", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaDichVu", SqlDbType.NChar).Value = maDichVu;
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

        public bool SuaDichVu(string maDichVu, string maDoiTac, string tenDichVu, float giaDichVu, string ghiChu)
        {
            SqlCommand command = new SqlCommand("proc_SuaDichVu", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaDichVu", SqlDbType.NVarChar).Value = maDichVu;
            command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = maDoiTac;
            command.Parameters.Add("@TenDichVu", SqlDbType.NVarChar).Value = tenDichVu;
            command.Parameters.Add("@GiaDichVu", SqlDbType.VarChar).Value = giaDichVu;
            command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = ghiChu;
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
        public DataTable TimKiemDichVu(string thuoctinhtimkiem, string noidungtimkiem)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = db.GetConnection();
                string query = string.Empty;
                if (thuoctinhtimkiem == "Mã dịch vụ")
                {
                    query = "EXEC proc_TimKiemDichVu_MaDichVu @MaDichVu, @MaDoiTac";
                    command.Parameters.Add("@MaDichVu", SqlDbType.NVarChar).Value = noidungtimkiem;
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = DoiTac.MaDT;

                }

                else if (thuoctinhtimkiem == "Mã đối tác")
                {
                    query = "EXEC proc_TimKiemDichVu_MaDoiTac @MaDoiTac";
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = noidungtimkiem;
                }
                else if (thuoctinhtimkiem == "Tên dịch vụ")
                {
                    query = "EXEC proc_TimKiemDichVu_TenDichVu @TenDichVu, @MaDoiTac";
                    command.Parameters.Add("@TenDichVu", SqlDbType.NVarChar).Value = noidungtimkiem;
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = DoiTac.MaDT;
                }
                else if (thuoctinhtimkiem == "Giá dịch vụ")
                {
                    query = "EXEC proc_TimKiemDichVu_GiaDichVu @GiaDichVu, @MaDoiTac";
                    command.Parameters.Add("@GiaDichVu", SqlDbType.Float).Value = float.Parse(noidungtimkiem);
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = DoiTac.MaDT;
                }
                else if (thuoctinhtimkiem == "Ghi chú")
                {
                    query = "EXEC proc_TimKiemDichVu_GhiChu @GhiChu, @MaDoiTac";
                    command.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = noidungtimkiem;
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = DoiTac.MaDT;
                }
                command.CommandText = query;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt;
            }
            catch
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm !");
                return null;
            }
        }
        

        public bool ThemQuangCao(string maDoiTac, string tenQuangCao, string moTa, DateTime ngayBatDau, DateTime ngayKetThuc, string viTriHienThi, int trangThaiQuangCao, int giaQuangCao)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_ThemQuangCao", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = maDoiTac;
            cmd.Parameters.Add("@TenQuangCao", SqlDbType.NVarChar).Value = tenQuangCao;
            cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = moTa;
            cmd.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = ngayBatDau;
            cmd.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = ngayKetThuc;
            cmd.Parameters.Add("@ViTriHienThi", SqlDbType.NVarChar).Value = viTriHienThi;
            cmd.Parameters.Add("@TrangThaiQuangCao", SqlDbType.Int).Value = trangThaiQuangCao;
            cmd.Parameters.Add("@GiaQuangCao", SqlDbType.Int).Value = giaQuangCao;

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

        public bool XoaQuangCao(string maQuangCao)
        {
            SqlCommand command = new SqlCommand("proc_XoaQuangCao", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaQuangCao", SqlDbType.NChar).Value = maQuangCao;
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

        public bool SuaQuangCao(string maQuangCao, string maDoiTac, string tenQuangCao, string moTa, DateTime ngayBatDau, DateTime ngayKetThuc, string viTriHienThi, int trangThaiQuangCao, int giaQuangCao)
        {
            SqlCommand cmd = new SqlCommand("proc_SuaQuangCao", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaQuangCao", SqlDbType.NVarChar).Value = maQuangCao;
            cmd.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = maDoiTac;
            cmd.Parameters.Add("@TenQuangCao", SqlDbType.NVarChar).Value = tenQuangCao;
            cmd.Parameters.Add("@MoTa", SqlDbType.NVarChar).Value = moTa;
            cmd.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = ngayBatDau;
            cmd.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = ngayKetThuc;
            cmd.Parameters.Add("@ViTriHienThi", SqlDbType.NVarChar).Value = viTriHienThi;
            cmd.Parameters.Add("@TrangThaiQuangCao", SqlDbType.Int).Value = trangThaiQuangCao;
            cmd.Parameters.Add("@GiaQuangCao", SqlDbType.Int).Value = giaQuangCao;
            db.OpenConnection();
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

        public DataTable TimKiemQuangCao(string thuoctinhtimkiem, string noidungtimkiem)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = db.GetConnection();
                string query = string.Empty;
                if (thuoctinhtimkiem == "Mã quảng cáo")
                {
                    query = "EXEC proc_TimKiemQuangCao_MaQuangCao @MaQuangCao, @MaDoiTac";
                    command.Parameters.Add("@MaQuangCao", SqlDbType.NVarChar).Value = noidungtimkiem;
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = DoiTac.MaDT;
                }

                else if (thuoctinhtimkiem == "Mã đối tác")
                {
                    query = "EXEC proc_TimKiemQuangCao_MaDoiTac @MaDoiTac";
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = noidungtimkiem;
                }
                else if (thuoctinhtimkiem == "Tên quảng cáo")
                {
                    query = "EXEC proc_TimKiemQuangCao_TenQuangCao @TenQuangCao, @MaDoiTac";
                    command.Parameters.Add("@TenQuangCao", SqlDbType.NVarChar).Value = noidungtimkiem;
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = DoiTac.MaDT;
                }
                else if (thuoctinhtimkiem == "Ngày bắt đầu")
                {
                    query = "EXEC proc_TimKiemQuangCao_NgayBatDau @NgayBatDau, @MaDoiTac";
                    command.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = DateTime.ParseExact(noidungtimkiem, "dd/MM/yyyy", null);
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = DoiTac.MaDT;
                }
                else if (thuoctinhtimkiem == "Ngày ngày kết thúc")
                {
                    query = "EXEC proc_TimKiemQuangCao_NgayKetThuc @NgayKetThuc, @MaDoiTac";
                    command.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = DateTime.ParseExact(noidungtimkiem, "dd/MM/yyyy", null);
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = DoiTac.MaDT;
                }
                else if (thuoctinhtimkiem == "Vị trí hiển thị")
                {
                    query = "EXEC proc_TimKiemQuangCao_ViTriHienThi @ViTriHienThi, @MaDoiTac";
                    command.Parameters.Add("@ViTriHienThi", SqlDbType.NVarChar).Value = noidungtimkiem;
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = DoiTac.MaDT;
                }
                else if (thuoctinhtimkiem == "Trạng thái quảng cáo")
                {
                    query = "EXEC proc_TimKiemQuangCao_TrangThaiQuangCao @TrangThaiQuangCao, @MaDoiTac";
                    command.Parameters.Add("@TrangThaiQuangCao", SqlDbType.Int).Value = int.Parse(noidungtimkiem);
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = DoiTac.MaDT;
                }
                else if (thuoctinhtimkiem == "Giá quảng cáo")
                {
                    query = "EXEC proc_TimKiemQuangCao_GiaQuangCao @GiaQuangCao, @MaDoiTac";
                    command.Parameters.Add("@GiaQuangCao", SqlDbType.Int).Value = int.Parse(noidungtimkiem);
                    command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = DoiTac.MaDT;
                }
                command.CommandText = query;
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa nhập thông tin tìm kiếm !");
                throw ex;
            }
        }
    }
}
