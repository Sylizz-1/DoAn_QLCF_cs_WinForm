using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
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
                cmd.CommandText = "select * from Nhanvien order by NhanVienId asc";
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
                        nhanVienModel.Ngaysinh = (DateTime)reader["NamSinh"];
                        nhanVienModel.Taikhoan = reader["TaiKhoan"].ToString();
                        nhanVienModel.Matkhau = reader["MatKhau"].ToString();
                        nhanVienModel.Quyen = reader["QuyenId"].ToString();
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
            throw new NotImplementedException();
        }

        public bool IsExit(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(NhanVienModel obj)
        {
            throw new NotImplementedException();
        }
    }
}