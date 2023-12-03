using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System.Data.SqlClient;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class PhanQuyenRepository : BaseRepository, IPhanQuyenRepository
    {
        public PhanQuyenRepository(string connectionString)
        {
            this.connectionString = connectionString;
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
    }
}