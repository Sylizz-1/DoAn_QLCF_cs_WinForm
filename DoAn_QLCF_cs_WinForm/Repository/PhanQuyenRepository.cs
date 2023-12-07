using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class PhanQuyenRepository : BaseRepository, IPhanQuyenRepository
    {
        public PhanQuyenRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public int GetNextIdPermission()
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT MAX([QuyenId]) FROM [Quyen]";

                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    return (int)result + 1;
                }
                return 1;
            }
        }

        public ArrayList GetArrMethodByIdPermission(int idPermission)
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
        public IEnumerable<ChucNangModel> GetAllMethod()
        {
            var methodList = new List<ChucNangModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "select * from ChucNang order by ChucNangId;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var methodModel = new ChucNangModel();
                        methodModel.IdMethod = (int)reader["ChucNangId"];
                        methodModel.NameMethod = reader["TenChucNang"].ToString();
                        methodList.Add(methodModel);
                    }
                }
                return methodList;
            }
        }

        public IEnumerable<QuyenModel> GetAllPermission()
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

        public bool Add(QuyenModel quyenModel, ArrayList arrMethod)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "SET IDENTITY_INSERT Quyen ON " +
                        "insert into Quyen ([QuyenId],[TenQuyen],[NoiDungQuyen])" +
                                      "VALUES (@QuyenId,@TenQuyen,@NoiDungQuyen)" +
                                      "SET IDENTITY_INSERT Quyen OFF";
                    cmd.Parameters.AddWithValue("@QuyenId", quyenModel.IdPermission);
                    cmd.Parameters.AddWithValue("@TenQuyen", quyenModel.NamePermission);
                    cmd.Parameters.AddWithValue("@NoiDungQuyen", quyenModel.ContentPermission);
                    cmd.ExecuteNonQuery();
                }
                if (arrMethod.Count > 0)
                {
                    using (var connection = new SqlConnection(this.connectionString))
                    using (var cmd = connection.CreateCommand())
                    {
                        connection.Open();
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO Quyen_ChucNang ([QuyenId], [ChucNangId]) VALUES ";
                        for (int i = 0; i < arrMethod.Count; i++)
                        {
                            cmd.CommandText += $"({quyenModel.IdPermission}, @ChucNangId{i})";
                            if (i < arrMethod.Count - 1)
                            {
                                cmd.CommandText += ", ";
                            }
                            cmd.Parameters.AddWithValue($"@ChucNangId{i}", arrMethod[i]);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public bool Edit(QuyenModel quyenModel, ArrayList arrMethod)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE Quyen SET [TenQuyen] = @TenQuyen, [NoiDungQuyen] = @NoiDungQuyen" +
                                        " WHERE [QuyenId] = @QuyenId";
                    cmd.Parameters.AddWithValue("@QuyenId", quyenModel.IdPermission);
                    cmd.Parameters.AddWithValue("@TenQuyen", quyenModel.NamePermission);
                    cmd.Parameters.AddWithValue("@NoiDungQuyen", quyenModel.ContentPermission);
                    cmd.ExecuteNonQuery();
                }
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM Quyen_ChucNang WHERE [QuyenId] = @QuyenId;";
                    cmd.Parameters.AddWithValue("@QuyenId", quyenModel.IdPermission);
                    cmd.ExecuteNonQuery();
                }
                if (arrMethod.Count > 0)
                {
                    using (var connection = new SqlConnection(this.connectionString))
                    using (var cmd = connection.CreateCommand())
                    {
                        connection.Open();
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO Quyen_ChucNang ([QuyenId], [ChucNangId]) VALUES ";
                        for (int i = 0; i < arrMethod.Count; i++)
                        {
                            cmd.CommandText += $"({quyenModel.IdPermission}, @ChucNangId{i})";
                            if (i < arrMethod.Count - 1)
                            {
                                cmd.CommandText += ", ";
                            }
                            cmd.Parameters.AddWithValue($"@ChucNangId{i}", arrMethod[i]);
                        }
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool IsPermissionOwnByEmployee(int idPermission)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "select * from NhanVien WHERE [QuyenId] = " + idPermission + ";";
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool DeletePermissionById(int idPermission)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "DELETE FROM Quyen_ChucNang WHERE [QuyenId] = @QuyenId;";
                    cmd.Parameters.AddWithValue("@QuyenId", idPermission);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "DELETE FROM Quyen WHERE [QuyenId] = @QuyenId;";
                    cmd.ExecuteNonQuery();                    
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }


        }

        public IEnumerable<QuyenNhanVienModel> GetEmployeePermission()
        {
            var list = new List<QuyenNhanVienModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT NhanVien.[NhanVienId], NhanVien.[Ten], NhanVien.QuyenId, Quyen.[TenQuyen]" +
                                    " FROM NhanVien, Quyen" +
                                    " WHERE NhanVien.QuyenId = Quyen.QuyenId AND NhanVien.IsDelete = 0" +
                                    " order by NhanVien.[NhanVienId]";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var model = new QuyenNhanVienModel();
                        model.IdEmployee = (int)reader["NhanVienId"];
                        model.NameEmployee = reader["Ten"].ToString();
                        model.IdPermission = (int)reader["QuyenId"];
                        model.NamePermission = reader["TenQuyen"].ToString();
                        list.Add(model);
                    }
                }
                return list;
            }
        }

        public bool EditPermissionEmployee(QuyenNhanVienModel model)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE NhanVien SET [QuyenId] = @QuyenId" +
                                        " WHERE [NhanVienId] = @NhanVienId";
                    cmd.Parameters.AddWithValue("@QuyenId", model.IdPermission);
                    cmd.Parameters.AddWithValue("@NhanVienId", model.IdEmployee);                    
                    if(cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool DeletePermissionEmployee(int idEmployee)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE NhanVien SET [QuyenId] = 0" +
                                        " WHERE [NhanVienId] = @NhanVienId";
                    cmd.Parameters.AddWithValue("@NhanVienId", idEmployee);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
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
