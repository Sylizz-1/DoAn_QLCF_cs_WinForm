using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System.Data.SqlClient;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class KhachHangRepository : BaseRepository, IKhachHangRepository
    {
        public KhachHangRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<KhachHangModel> GetAll()
        {
            var List = new List<KhachHangModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "select * from KhachHang order by KhachHangId asc";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var khachhangModel = new KhachHangModel();

                        khachhangModel.Id = (int)reader["KhachHangId"];
                        khachhangModel.Name = reader["TenKhachHang"].ToString();
                        khachhangModel.Address = reader["DiaChi"].ToString();
                        khachhangModel.PhoneNumber = reader["SDT"].ToString();
                        khachhangModel.Email = reader["Email"].ToString();
                        khachhangModel.IsDelete = (bool)reader["IsDelete"];
                        khachhangModel.IdTypeOfCustomer = (int)reader["LoaiKhachHangId"];
                        khachhangModel.TimeCreateAccount = (DateTime)reader["ThoiGianTaoTk"];
                        khachhangModel.Account = reader["TaiKhoan"].ToString();
                        khachhangModel.Password = reader["MatKhau"].ToString();
                        List.Add(khachhangModel);
                    }
                }

                return List;
            }
        }

    }
}