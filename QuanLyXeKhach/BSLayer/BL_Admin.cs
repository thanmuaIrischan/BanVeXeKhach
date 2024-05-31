using QuanLyXeKhach.DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design.Serialization;
using Microsoft.SqlServer.Server;
using QuanLyXeKhach.Form_UC_Admin;

namespace QuanLyXeKhach.BSLayer
{
    internal class BL_Admin
    {
        Connector db = new Connector();
        public BL_Admin() { }

        public DataTable GetXe()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewXe", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetLoaiXe()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewLoaiXe", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetTuyenDuong()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewTuyenDuong", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable GetTaiXe()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewTaiXe", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public bool ThemLoaiXe(string tenLoaiXe, int soHangGhe, int soGhe1Hang)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_ThemLoaiXe", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenLoaiXe", SqlDbType.NVarChar).Value = tenLoaiXe;
            cmd.Parameters.Add("@SoHangGhe", SqlDbType.NVarChar).Value = soHangGhe;
            cmd.Parameters.Add("@SoGheMotHang", SqlDbType.NVarChar).Value = soGhe1Hang;
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

        public bool XoaLoaiXe(string maLoaiXe)
        {
            SqlCommand command = new SqlCommand("proc_XoaLoaiXe", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiXe", SqlDbType.NChar).Value = maLoaiXe;
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

        public bool SuaLoaiXe(string maLoaiXe, string tenLoaiXe, int soHangGhe, int soGheMotHang)
        {
            SqlCommand command = new SqlCommand("Pro_SuaLoaiXe", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLoaiXe", SqlDbType.NVarChar).Value = maLoaiXe;
            command.Parameters.Add("@TenLoaiXe", SqlDbType.NVarChar).Value = tenLoaiXe;
            command.Parameters.Add("@SoHangGhe", SqlDbType.VarChar).Value = soHangGhe;
            command.Parameters.Add("@SoGheMotHang", SqlDbType.NVarChar).Value = soGheMotHang;
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

        public bool SuaChuyenXe(string maChuyenXe, string bienSoXe, string maTaiXe, string diemDon, string diemTra, DateTime ngayKhoiHanh, TimeSpan gioKhoiHanh, string maTuyenDuong, int gia)
        {
            SqlCommand command = new SqlCommand("proc_SuaChuyenXe", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaChuyenXe", SqlDbType.NVarChar).Value = maChuyenXe;
            command.Parameters.Add("@BienSoXe", SqlDbType.NVarChar).Value = bienSoXe;
            command.Parameters.Add("@MaTaiXe", SqlDbType.NVarChar).Value = maTaiXe;
            command.Parameters.Add("@DiemDon", SqlDbType.NVarChar).Value = diemDon;
            command.Parameters.Add("@DiemTra", SqlDbType.NVarChar).Value = diemTra;
            command.Parameters.Add("@NgayKhoiHanh", SqlDbType.Date).Value = ngayKhoiHanh;
            command.Parameters.Add("@GioKhoiHanh", SqlDbType.Time).Value = gioKhoiHanh;
            command.Parameters.Add("@MaTuyenDuong", SqlDbType.NVarChar).Value = maTuyenDuong;
            command.Parameters.Add("@Gia", SqlDbType.Int).Value = gia;
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


        public bool XoaChuyenXe(string maChuyenXe)
        {
            SqlCommand command = new SqlCommand("proc_XoaChuyenXe", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaChuyenXe", SqlDbType.NChar).Value = maChuyenXe;
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

        public bool ThemTuyenDuong(string tenTuyen, string tuyenDau, string tuyenCuoi, string khoangCach)
        {
            db.OpenConnection();
            SqlCommand command = new SqlCommand("proc_ThemTuyenDuong", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TenTuyen", SqlDbType.NVarChar).Value = tenTuyen;
            command.Parameters.Add("@TuyenDau", SqlDbType.NVarChar).Value = tuyenDau;
            command.Parameters.Add("@TuyenCuoi", SqlDbType.NVarChar).Value = tuyenCuoi;
            command.Parameters.Add("@KhoangCach", SqlDbType.NVarChar).Value = khoangCach;
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
        public bool SuaTuyenDuong(string maTuyenDuong, string tenTuyen, string tuyenDau, string tuyenCuoi, string khoangCach)
        {
            db.OpenConnection();
            SqlCommand command = new SqlCommand("proc_SuaTuyenDuong", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTuyenDuong", SqlDbType.NVarChar).Value = maTuyenDuong;
            command.Parameters.Add("@TenTuyen", SqlDbType.NVarChar).Value = tenTuyen;
            command.Parameters.Add("@TuyenDau", SqlDbType.NVarChar).Value = tuyenDau;
            command.Parameters.Add("@TuyenCuoi", SqlDbType.NVarChar).Value = tuyenCuoi;
            command.Parameters.Add("@KhoangCach", SqlDbType.NVarChar).Value = khoangCach;
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
        public bool XoaTuyenDuong(string maTuyenDuong)
        {
            SqlCommand command = new SqlCommand("proc_XoaTuyenDuong", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTuyenDuong", SqlDbType.NChar).Value = maTuyenDuong;
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


        public bool ThemTaiXe(string hoTen, string gioiTinh, int tuoi, string cccd, string sDT, string diachi, int namKinhNghiem)
        {
            db.OpenConnection();
            SqlCommand command = new SqlCommand("proc_ThemTaiXe", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = hoTen;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gioiTinh;
            command.Parameters.Add("@Tuoi", SqlDbType.Int).Value = tuoi;
            command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = cccd;
            command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = sDT;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@NamKinhNghiem", SqlDbType.Int).Value = namKinhNghiem;

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
        public bool SuaTaiXe(string maTaiXe, string hoTen, string gioiTinh, int tuoi, string cccd, string sDT, string diachi, int namKinhNghiem)
        {
            db.OpenConnection();
            SqlCommand command = new SqlCommand("proc_SuaTaiXe", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTaiXe", SqlDbType.NVarChar).Value = maTaiXe;
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = hoTen;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gioiTinh;
            command.Parameters.Add("@Tuoi", SqlDbType.Int).Value = tuoi;
            command.Parameters.Add("@CCCD", SqlDbType.NVarChar).Value = cccd;
            command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = sDT;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diachi;
            command.Parameters.Add("@NamKinhNghiem", SqlDbType.Int).Value = namKinhNghiem;
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
        public bool XoaTaiXe(string maTaiXe)
        {
            SqlCommand command = new SqlCommand("proc_XoaTaiXe", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaTaiXe", SqlDbType.NChar).Value = maTaiXe;
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

        public DataTable GetPhanQuyenTheoLoai(string loai)
        {
            DataTable dt = new DataTable();
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("Select * from ViewPhanQuyen WHERE LoaiPhanQuyen = @LoaiPhanQuyen", db.GetConnection());
            cmd.Parameters.AddWithValue("@LoaiPhanQuyen", loai);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        public DataTable GetKHTheoSDT(string sdt)
        {
            DataTable dt = new DataTable();
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("Select * from ViewKhachHang WHERE SDT = @sdt", db.GetConnection());
            cmd.Parameters.AddWithValue("@sdt", sdt);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        public DataTable GetHDByMaKH(string makh)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select * from GetInfoByMaKhachHang (@string)", db.GetConnection());
            cmd.Parameters.Add("@string", SqlDbType.VarChar).Value = makh;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public bool XoaHoaDon(int maVe)
        {
            SqlCommand command = new SqlCommand("proc_XoaHoaDon", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaVe", SqlDbType.NVarChar).Value = maVe;
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

        public bool HuyVe(int maVe)
        {
            SqlCommand command = new SqlCommand("HuyVe", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaVe", SqlDbType.NVarChar).Value = maVe;
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


        public bool ThemPhanQuyen(string tenDangNhap, string matKhau)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_ThemPhanQuyen", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = tenDangNhap;
            cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = matKhau;

            try
            {
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi (ví dụ: log lỗi, thông báo lỗi)
                Console.WriteLine(ex.Message);
                db.CloseConnection();
                return false;
            }
        }

        public bool ThemPhanQuyenDT(string tenDangNhap, string matKhau)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_ThemPQDoiTac", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = tenDangNhap;
            cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = matKhau;

            try
            {
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi (ví dụ: log lỗi, thông báo lỗi)
                Console.WriteLine(ex.Message);
                db.CloseConnection();
                return false;
            }
        }


        public bool ThemKhachHang(string hoTen, string gioiTinh, string sdt, string diaChi, string email)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_ThemKH", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = hoTen;
            cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gioiTinh;
            cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = sdt;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;

            try
            {
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi (ví dụ: log lỗi, thông báo lỗi)
                Console.WriteLine(ex.Message);
                db.CloseConnection();
                return false;
            }
        }

        public bool ThemDoiTac(string ten, string hinhthuc, string tenNguoiDaiDien, string email, string sdt, string diaChi)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_ThemDoiTac", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDoiTac", SqlDbType.VarChar).Value = ten;
            cmd.Parameters.Add("@HinhThucDoiTac", SqlDbType.VarChar).Value = hinhthuc;
            cmd.Parameters.Add("@TenNguoiDaiDien", SqlDbType.VarChar).Value = tenNguoiDaiDien;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@SoDienThoai", SqlDbType.VarChar).Value = sdt;
            cmd.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = diaChi;
            try
            {
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi (ví dụ: log lỗi, thông báo lỗi)
                Console.WriteLine(ex.Message);
                db.CloseConnection();
                return false;
            }
        }

        public DataTable GetQCChuaDuyet(int trangThai)
        {
            DataTable dt = new DataTable();
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("Select * from ViewQuangCao WHERE TrangThaiQuangCao = @string", db.GetConnection());
            cmd.Parameters.AddWithValue("@string", trangThai);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        public bool DuyetQuangCao(string maQuangCao)
        {
            SqlCommand command = new SqlCommand("Pro_DuyetQuangCao", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaQuangCao", SqlDbType.NVarChar).Value = maQuangCao;
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

        public DataTable GetQCByDT(string maDoiTac)
        {
            DataTable dt = new DataTable();
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("Select * from ViewQuangCao WHERE MaDoiTac = @string", db.GetConnection());
            cmd.Parameters.AddWithValue("@string", maDoiTac);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        public DataTable GetDVByDT(string maDoiTac)
        {
            DataTable dt = new DataTable();
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("Select * from ViewDichVu WHERE MaDoiTac = @string", db.GetConnection());
            cmd.Parameters.AddWithValue("@string", maDoiTac);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }


        public DataTable GetChuyenXe()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewChuyenXe", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetQC()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewQuangCao", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetDV()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewDichVu", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetVeByMaChuyen(string maChuyen)
        {
            DataTable dt = new DataTable();
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("Select * from ViewVe WHERE MaChuyenXe = @string", db.GetConnection());
            cmd.Parameters.AddWithValue("@string", maChuyen);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }

        public DataTable GetKHByVe(int maVe)
        {
            DataTable dt = new DataTable();
            db.OpenConnection();

            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetKhachHangByMaVe(@MaVe)", db.GetConnection());
            cmd.Parameters.AddWithValue("@MaVe", maVe);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            db.CloseConnection();
            return dt;
        }

        public DataTable GetVeDaDat(string maChuyen)
        {
            DataTable dt = new DataTable();
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("Select * from ViewVe WHERE TrangThaiThanhToan = 1 and MaChuyenXe = @string", db.GetConnection());
            cmd.Parameters.AddWithValue("@string", maChuyen);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            db.CloseConnection();
            return dt;
        }



        public DataTable GetPhanQuyen()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewPhanQuyen", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable GetDoiTac()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewDoiTac", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public DataTable GetKhachHang()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select * from ViewKhachHang", db.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        ////// Loại Xe



        ///////Phân QUyền




        public bool SuaPhanQuyen(int maPhanQuyen, string loaiPhanQuyen, string tenDangNhap, string matKhau)
        {
            SqlCommand command = new SqlCommand("Pro_SuaPhanQuyen", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaPhanQuyen", SqlDbType.NVarChar).Value = maPhanQuyen;
            command.Parameters.Add("@LoaiPhanQuyen", SqlDbType.NVarChar).Value = loaiPhanQuyen;
            command.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = tenDangNhap;
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = matKhau;
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
        ///////Đối Tác
        public bool ThemDoiTac(string maDoiTac, string tenDoiTac, string hinhThucDoitac, string tenNguoiDaiDien, string email, string SDT, string diaChi, int maPhanQuyen)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_ThemDoiTac", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenDoiTac", SqlDbType.NVarChar).Value = tenDoiTac;
            cmd.Parameters.Add("@HinhThucDoiTac", SqlDbType.NVarChar).Value = hinhThucDoitac;
            cmd.Parameters.Add("@TenNguoiDaiDien", SqlDbType.NVarChar).Value = tenNguoiDaiDien;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = SDT;
            cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
            cmd.Parameters.Add("@MaPhanQuyen", SqlDbType.NVarChar).Value = maPhanQuyen;
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

        public bool XoaDoiTac(string maDoiTac)
        {
            SqlCommand command = new SqlCommand("proc_XoaDoiTac", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@maDT", SqlDbType.NChar).Value = maDoiTac;
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

        public bool SuaDoiTac(string maDoiTac, string tenDoiTac, string hinhThucDoitac, string tenNguoiDaiDien, string email, string SDT, string diaChi, int maPhanQuyen)
        {
            SqlCommand command = new SqlCommand("Pro_SuaDoiTac", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaDoiTac", SqlDbType.NVarChar).Value = maDoiTac;
            command.Parameters.Add("@TenDoiTac", SqlDbType.NVarChar).Value = tenDoiTac;
            command.Parameters.Add("@HinhThucDoiTac", SqlDbType.NVarChar).Value = hinhThucDoitac;
            command.Parameters.Add("@TenNguoiDaiDien", SqlDbType.NVarChar).Value = tenNguoiDaiDien;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@SoDienThoai", SqlDbType.NVarChar).Value = SDT;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
            command.Parameters.Add("@MaPhanQuyen", SqlDbType.NVarChar).Value = maPhanQuyen;
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
        /////// Xe
        public bool ThemXe(string bienSoXe, string maLoai, string mauXe)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("proc_ThemXe", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BienSoXe", SqlDbType.NVarChar).Value = bienSoXe;
            cmd.Parameters.Add("@MaLoaiXe", SqlDbType.NVarChar).Value = maLoai;
            cmd.Parameters.Add("@MauXe", SqlDbType.NVarChar).Value = mauXe;
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

        public bool XoaXe(string bienSo)
        {
            SqlCommand command = new SqlCommand("proc_XoaXe", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@BienSo", SqlDbType.NChar).Value = bienSo;
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

        public bool SuaXe(string bienSoXe, string maLoai, string mauXe)
        {
            SqlCommand command = new SqlCommand("Pro_SuaXe", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@BienSoXe", SqlDbType.NVarChar).Value = bienSoXe;
            command.Parameters.Add("@MaLoaiXe", SqlDbType.NVarChar).Value = maLoai;
            command.Parameters.Add("@MauXe", SqlDbType.NVarChar).Value = mauXe;
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
        /////// Khách Hàng
        public bool SuaKhachHang(string maKH, string hoTen, string gioiTinh, string SDT, string diaChi, string email, int maPhanQuyen)
        {
            SqlCommand command = new SqlCommand("Pro_SuaKhachHang", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = maKH;
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = hoTen;
            command.Parameters.Add("@GioiTinh", SqlDbType.VarChar).Value = gioiTinh;
            command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = SDT;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@MaPhanQuyen", SqlDbType.NVarChar).Value = maPhanQuyen;
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

        public bool XoaKhachHang(string maKH)
        {
            SqlCommand command = new SqlCommand("proc_XoaKhachHang", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKH", SqlDbType.NChar).Value = maKH;
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

        public DataTable FindChuyenXe(string diemDon, string diemTra)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_TimChuyenXe1(@DiemDon, @DiemTra)", db.GetConnection());
            cmd.Parameters.AddWithValue("@diemDon", diemDon);
            cmd.Parameters.AddWithValue("@diemTra", diemTra);
            //cmd.Parameters.AddWithValue("@ngayKhoiHanh", ngayKhoiHanh);
            //cmd.Parameters.AddWithValue("@gioKhoiHanh", gioKhoiHanh);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable TimChuyenXe(string diemDon, string diemTra, DateTime ngayKhoiHanh)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM func_TimChuyenXe(@diemDon, @diemTra, @ngayKhoiHanh)", db.GetConnection());
            cmd.Parameters.AddWithValue("@diemDon", diemDon);
            cmd.Parameters.AddWithValue("@diemTra", diemTra);
            cmd.Parameters.AddWithValue("@ngayKhoiHanh", ngayKhoiHanh);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }


        public bool ThemChuyenXe(string bienSoXe, string maTaiXe, string diemDon, string diemTra, DateTime ngayKhoiHanh, TimeSpan gioKhoiHanh,string maTuyenDuong, int gia)
        {
            db.OpenConnection();
            SqlCommand cmd = new SqlCommand("ThemChuyenXe", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@BienSoXe", SqlDbType.VarChar).Value = bienSoXe;
            cmd.Parameters.Add("@MaTaiXe", SqlDbType.VarChar).Value = maTaiXe;
            cmd.Parameters.Add("@DiemDon", SqlDbType.NVarChar).Value = diemDon;
            cmd.Parameters.Add("@DiemTra", SqlDbType.NVarChar).Value = diemTra;
            cmd.Parameters.Add("@NgayKhoiHanh", SqlDbType.Date).Value = ngayKhoiHanh;
            cmd.Parameters.Add("@GioKhoiHanh", SqlDbType.Time).Value = gioKhoiHanh;
            cmd.Parameters.Add("@MaTuyenDuong", SqlDbType.VarChar).Value = maTuyenDuong;
            cmd.Parameters.Add("@Gia", SqlDbType.Int).Value = gia;

            try
            {
                cmd.ExecuteNonQuery();
                db.CloseConnection();
                return true;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần thiết
                Console.WriteLine("Lỗi: " + ex.Message);
                db.CloseConnection();
                return false;
            }
        }

        public DataTable DoanhThuTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("EXEC layDoanhThuTheoNgay @fromDate , @toDate", db.GetConnection());
            cmd.Parameters.AddWithValue("@fromDate", tuNgay);
            cmd.Parameters.AddWithValue("@toDate", denNgay);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public DataTable DoanhThuQCTheoNgay(DateTime tuNgay, DateTime denNgay)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("EXEC layDoanhThuQCTheoNgay @fromDate , @toDate", db.GetConnection());
            cmd.Parameters.AddWithValue("@fromDate", tuNgay);
            cmd.Parameters.AddWithValue("@toDate", denNgay);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public int TongDoanhThu()
        {
            int totalTongTien = 0;
            string connectionString = db.connStr;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo đối tượng SqlCommand cho việc gọi hàm
                using (SqlCommand command = new SqlCommand("dbo.GetTotalTongTien", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu ra
                    SqlParameter outputParameter = new SqlParameter("@ReturnValue", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.ReturnValue
                    };
                    command.Parameters.Add(outputParameter);

                    // Thực hiện lệnh
                    command.ExecuteNonQuery();

                    // Đọc giá trị đầu ra từ tham số
                    totalTongTien = (int)outputParameter.Value;

                    Console.WriteLine("Tổng số tiền: " + totalTongTien);
                }
            }
            return totalTongTien;
        }

        public List<Ve> GetSoDoVe(string maChuyen)
        {
            List<Ve> listTicket = new List<Ve>();
            SqlCommand cmd = new SqlCommand("select * from func_Ve (@string)", db.GetConnection());
            cmd.Parameters.Add("@string", SqlDbType.VarChar).Value = maChuyen;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Ve ticket = new Ve(row);
                listTicket.Add(ticket);
            }
            return listTicket;
        }

        public int DemSoVeTheoChuyenXe(string maChuyenXe)
        {
            int soVe = 0;

            using (SqlConnection connection = new SqlConnection(db.connStr))
            {
                try
                {
                    connection.Open();

                    // Tạo và thực hiện câu truy vấn để đếm số vé
                    string query = "SELECT COUNT(*) FROM VeXe WHERE MaChuyenXe = @MaChuyenXe";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaChuyenXe", maChuyenXe);
                        soVe = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return soVe;
        }

       


    }
}