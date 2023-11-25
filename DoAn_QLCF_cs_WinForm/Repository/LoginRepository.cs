using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {
        public LoginRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private ArrayList getArrAction(int idPermission)
        {
            ArrayList array = new ArrayList();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT ChucNangId FROM Quyen_ChucNang WHERE QuyenId = @id;";
                command.Parameters.Add("@id", SqlDbType.VarChar).Value = idPermission;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        array.Add(reader.GetInt32(0));
                    }
                }
            }
            return array;
        }
        public NhanVienModel LoginEmployee(String username, String password)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM NhanVien WHERE TaiKhoan = @username AND MatKhau = @password AND IsDelete = 0;";
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        NhanVienModel nhanVienModel = new NhanVienModel();
                        nhanVienModel.Id = reader.GetInt32("NhanVienId");
                        nhanVienModel.Name = reader.GetString("Ten");
                        nhanVienModel.IdPermission = reader.GetInt32("QuyenId");
                        nhanVienModel.ArrAction = getArrAction(nhanVienModel.IdPermission);
                        return nhanVienModel;
                    }
                    return null;
                }
            }
        }

        public KhachHangModel LoginCustomer(string username, string password)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM KhachHang WHERE TaiKhoan = @username AND MatKhau = @password AND IsDelete = 0;";
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        KhachHangModel khachHangModel = new KhachHangModel();
                        khachHangModel.Id = reader.GetInt32("KhachHangId");
                        khachHangModel.Name = reader.GetString("TenKhachHang");
                        khachHangModel.Address = reader.GetString("DiaChi");
                        khachHangModel.PhoneNumber = reader.GetString("SDT");
                        khachHangModel.Email = reader.GetString("Email");
                        khachHangModel.IdTypeOfCustomer = reader.GetInt32("LoaiKhachHangId");
                        khachHangModel.TimeCreateAccount = Convert.ToDateTime(reader["ThoiGianTaoTk"]);
                        khachHangModel.Birthday = Convert.ToDateTime(reader["NgaySinh"]);
                        return khachHangModel;
                    }
                    return null;
                }
            }                    
        }

        public bool Register(string username, string password)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO NhanVien (TaiKhoan, MatKhau) VALUES (@username, @password);";
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                command.ExecuteNonQuery();
                return true;
            }
        }
    }
}
