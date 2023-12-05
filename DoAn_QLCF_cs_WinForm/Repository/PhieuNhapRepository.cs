using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class PhieuNhapRepository : BaseRepository, IPhieuNhapRepository
    {
        public PhieuNhapRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PhieuNhapModel PhieuNhap)
        {
            MessageBox.Show("Success");
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;

                cmd.CommandText = "INSERT INTO PhieuNhap (NhanVienId, NhaCungCapId, NgayNhap, TongTien) " +
                                  "VALUES (@NhanVienId, @NhaCungCapId, @NgayNhap, @TongTien)";

                cmd.Parameters.AddWithValue("@NhanVienId", PhieuNhap.NhanVienId);
                cmd.Parameters.AddWithValue("@NhaCungCapId", PhieuNhap.NhaCungCapId);
                cmd.Parameters.AddWithValue("@NgayNhap", PhieuNhap.NgayNhap);
                cmd.Parameters.AddWithValue("@TongTien", PhieuNhap.TongTien);

                cmd.ExecuteNonQuery();
            }
        }



        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PhieuNhapModel> GetAll()
        {
            var phieuNhapList = new List<PhieuNhapModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM PhieuNhap";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var phieuNhap = new PhieuNhapModel();
                        phieuNhap.PhieuNhapId = (int)reader["PhieuNhapId"];
                        phieuNhap.NhanVienId = (int)reader["NhanVienId"];
                        phieuNhap.NhaCungCapId = (int)reader["NhaCungCapId"];
                        phieuNhap.NgayNhap = (DateTime)reader["NgayNhap"];
                        phieuNhap.TongTien = Convert.ToSingle(reader["TongTien"]);
                        phieuNhapList.Add(phieuNhap);
                    }
                }

                return phieuNhapList;
            }
        }


        public PhieuNhapModel GetById(int id)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM PhieuNhap WHERE PhieuNhapId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                var PhieuNhap = new PhieuNhapModel();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        PhieuNhap.PhieuNhapId = (int)reader["PhieuNhapId"];
                        PhieuNhap.NhanVienId = (int)reader["NhanVienId"];
                        PhieuNhap.NhaCungCapId = (int)reader["NhaCungCapId"];
                        PhieuNhap.NgayNhap = (DateTime)reader["NgayNhap"];
                        PhieuNhap.TongTien = (float)reader["TongTien"];
                    }
                }

                return PhieuNhap;
            }
        }

        public int GetNextId()
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT MAX(PhieuNhapId) FROM PhieuNhap";

                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    return (int)result + 1;
                }
                return 1;
            }
        }

        public IEnumerable<PhieuNhapModel> GetByValue(string value)
        {
            List<PhieuNhapModel> PhieuNhapList = new List<PhieuNhapModel>();

            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM PhieuNhap WHERE PhieuNhapId LIKE @Value";
                cmd.Parameters.AddWithValue("@Value", "%" + value + "%");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var PhieuNhap = new PhieuNhapModel();
                        PhieuNhap.PhieuNhapId = (int)reader["PhieuNhapId"];
                        PhieuNhap.NhanVienId = (int)reader["NhanVienId"];
                        PhieuNhap.NhaCungCapId = (int)reader["NhaCungCapId"];
                        PhieuNhap.NgayNhap = (DateTime)reader["NgayNhap"];
                        PhieuNhap.TongTien = (float)reader["TongTien"];
                        PhieuNhapList.Add(PhieuNhap);
                    }
                }
            }

            return PhieuNhapList;
        }

        public bool IsExit(int id)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT COUNT(*) FROM PhieuNhap WHERE PhieuNhapId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public void Update(PhieuNhapModel obj)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "UPDATE PhieuNhap SET PhieuNhapId = @PhieuNhapId, NhanVienId = @NhanVienId, NhaCungCapId = @NhaCungCapId, NgayNhap = @NgayNhap, TongTien = @TongTien WHERE PhieuNhapId = @Id";

                cmd.Parameters.AddWithValue("@Id", obj.PhieuNhapId);
                cmd.Parameters.AddWithValue("@PhieuNhapId", obj.PhieuNhapId);
                cmd.Parameters.AddWithValue("@NhanVienId", obj.NhanVienId);
                cmd.Parameters.AddWithValue("@NhaCungCapId", obj.NhaCungCapId);
                cmd.Parameters.AddWithValue("@NgayNhap", obj.NgayNhap);
                cmd.Parameters.AddWithValue("@TongTien", obj.TongTien);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
