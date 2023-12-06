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
                        nhanVienModel.Name = reader["Ten"].ToString();
                        nhanVienModel.Gioitinh = reader["GioiTinh"].ToString();
                        nhanVienModel.Email = reader["Email"].ToString();
                        nhanVienModel.Sdt = reader["SDT"].ToString();
                        nhanVienModel.Ngaysinh = reader["NgaySinh"].ToString();
                        nhanVienModel.Taikhoan = reader["TaiKhoan"].ToString();
                        nhanVienModel.Matkhau = reader["MatKhau"].ToString();
                        nhanVienModel.IdPermission = (int)reader["QuyenId"];
                        nhanVienModel.isDelete = (bool)reader["IsDelete"];

                        List.Add(nhanVienModel);
                    }
                }

                return List;
            }

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

        public IEnumerable<QuyenModel> GetAllQuyen()
        {
            var permissionList = new List<QuyenModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "select * from Quyen order by QuyenId;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var permissionModel = new QuyenModel();
                        permissionModel.IdPermission = (int)reader["QuyenId"];
                        permissionModel.NamePermission = reader["TenQuyen"].ToString();
                        permissionModel.ContentPermission = reader["NoiDungQuyen"].ToString();
                        permissionList.Add(permissionModel);
                    }
                }
                return permissionList;
            }
        }

        public bool Add(NhanVienModel nhanVienModel)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "SET IDENTITY_INSERT NhanVien ON " +
                        "insert into NhanVien ([NhanVienId],[TaiKhoan],[MatKhau], [QuyenId], [Ten], [GioiTinh], [SDT], [Email], [NgaySinh], [IsDelete])" +
                                      "VALUES (@NhanVienId,@TaiKhoan,@MatKhau, @QuyenId, @Ten, @GioiTinh, @SDT,@Email, @NgaySinh,@IsDelete)" +
                                      "SET IDENTITY_INSERT NhanVien OFF";
                    cmd.Parameters.AddWithValue("@NhanVienId", nhanVienModel.Id);
                    cmd.Parameters.AddWithValue("@TaiKhoan", nhanVienModel.Taikhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", nhanVienModel.Matkhau);
                    cmd.Parameters.AddWithValue("@QuyenId", nhanVienModel.IdPermission);
                    cmd.Parameters.AddWithValue("@Ten", nhanVienModel.Name);
                    cmd.Parameters.AddWithValue("@GioiTinh", nhanVienModel.Gioitinh);
                    cmd.Parameters.AddWithValue("@SDT", nhanVienModel.Sdt);
                    cmd.Parameters.AddWithValue("@Email", nhanVienModel.Email);
                    cmd.Parameters.AddWithValue("@NgaySinh", nhanVienModel.Ngaysinh);
                    cmd.Parameters.AddWithValue("@IsDelete", nhanVienModel.isDelete ? 1 : 0);

                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool Edit(NhanVienModel nhanVienModel)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;

                    cmd.CommandText = "UPDATE NhanVien SET [TaiKhoan] = @TaiKhoan, [MatKhau] = @MatKhau, [QuyenId] = @QuyenId," +
                        " [Ten] = @Ten, [GioiTinh] = @GioiTinh,[SDT] = @SDT, [Email] = @Email, [NgaySinh] = @NgaySinh, [IsDelete] = @IsDelete WHERE [NhanVienId] = @Id";
                    cmd.Parameters.AddWithValue("@Id", nhanVienModel.Id);
                    cmd.Parameters.AddWithValue("@TaiKhoan", nhanVienModel.Taikhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", nhanVienModel.Matkhau);
                    cmd.Parameters.AddWithValue("@QuyenId", nhanVienModel.IdPermission);
                    cmd.Parameters.AddWithValue("@Ten", nhanVienModel.Name);
                    cmd.Parameters.AddWithValue("@GioiTinh", nhanVienModel.Gioitinh);
                    cmd.Parameters.AddWithValue("@SDT", nhanVienModel.Sdt);
                    cmd.Parameters.AddWithValue("@Email", nhanVienModel.Email);
                    cmd.Parameters.AddWithValue("@NgaySinh", nhanVienModel.Ngaysinh);
                    cmd.Parameters.AddWithValue("@IsDelete", nhanVienModel.isDelete ? 1 : 0);


                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }


    }
}