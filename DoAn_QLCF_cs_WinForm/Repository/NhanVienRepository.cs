using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class NhanVienRepository : BaseRepository, INhanVienRepository
    {

        public NhanVienRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<NhanVienModel> GetAll()
        {
            var List = new List<NhanVienModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "select * from NhanVien order by NhanVienId asc";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var nhanVienModel = new NhanVienModel();
                        nhanVienModel.Id = (int)reader["NhanVienId"];
#pragma warning disable CS8601 // Possible null reference assignment.
                        nhanVienModel.Name = reader["Ten"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
                        nhanVienModel.Gioitinh = reader["GioiTinh"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
                        nhanVienModel.Email = reader["Email"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
                        nhanVienModel.Sdt = reader["SDT"].ToString();
                        nhanVienModel.Ngaysinh = (DateTime)reader["NamSinh"];
                        nhanVienModel.Taikhoan = reader["TaiKhoan"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
                        nhanVienModel.Matkhau = reader["MatKhau"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
                        nhanVienModel.Quyen = reader["QuyenId"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
                        nhanVienModel.isDelete = (bool)reader["IsDelete"];

                        List.Add(nhanVienModel);
                    }
                }

                return List;
            }

        }
        public NhanVienModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NhanVienModel> GetByValue(string value)
        {
                List<NhanVienModel> List = new List<NhanVienModel>();

                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM NhanVien WHERE Ten LIKE @Value";
                    cmd.Parameters.AddWithValue("@Value", "%" + value + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
                            var nhanVienModel = new NhanVienModel
                            {
                                Id = (int)reader["NhanVienId"],
                                Name = reader["Ten"].ToString(),
                                Gioitinh = reader["GioiTinh"].ToString(),
                                Email = reader["Email"].ToString(),
                                Sdt = reader["SDT"].ToString(),
                                Ngaysinh = (DateTime)reader["NamSinh"],
                                Taikhoan = reader["TaiKhoan"].ToString(),
                                Matkhau = reader["MatKhau"].ToString(),
                                Quyen = reader["QuyenId"].ToString(),
                                isDelete = (bool)reader["IsDelete"]
                            };
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8601 // Possible null reference assignment.
                        List.Add(nhanVienModel);
                    }
                }
             }
                return List;
         }
        

        public bool IsExit(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(NhanVienModel obj)
        {
            throw new NotImplementedException();
        }
        public int GetNextId()
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT MAX(NhanVienId) FROM NhanVien";

                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    return (int)result + 1;
                }
                return 1;
            }
        }

        public List<string> getQuyen()
        {
            List<string> quyenList = new List<string>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM Quyen";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                        string tenQuyen = reader["TenQuyen"].ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
                        quyenList.Add(tenQuyen);
#pragma warning restore CS8604 // Possible null reference argument.

                    }
                }
                return quyenList;
            }
        }
    }
}