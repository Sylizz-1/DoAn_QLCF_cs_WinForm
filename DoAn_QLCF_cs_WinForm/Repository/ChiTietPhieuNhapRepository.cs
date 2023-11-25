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
    public class ChiTietPhieuNhapRepository : BaseRepository, IChiTietPhieuNhapRepository
    {
        public ChiTietPhieuNhapRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(ChiTietPhieuNhapModel ctpn)
        {
            MessageBox.Show("Success");
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;

                cmd.CommandText = "INSERT INTO ChiTietPhieuNhap (PhieuNhapId, NguyenLieuId, KhoiLuong, DonGia) " +
                                  "VALUES (@PhieuNhapId, @NguyenLieuId, @KhoiLuong, @DonGia)";

                cmd.Parameters.AddWithValue("@PhieuNhapId", ctpn.PhieuNhapId);
                cmd.Parameters.AddWithValue("@NguyenLieuId", ctpn.NguyenLieuId);
                cmd.Parameters.AddWithValue("@KhoiLuong", ctpn.KhoiLuong);
                cmd.Parameters.AddWithValue("@DonGia", ctpn.DonGia);

                cmd.ExecuteNonQuery();
            }
        }



        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChiTietPhieuNhapModel> GetAll()
        {
            var CTPNList = new List<ChiTietPhieuNhapModel>();
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
                        ChiTietPhieuNhapModel ctpn = new ChiTietPhieuNhapModel();
                        ctpn.PhieuNhapId = (int)reader["PhieuNhapId"];
                        ctpn.NguyenLieuId = (int)reader["NguyenLieuId"];
                        ctpn.KhoiLuong = (float)reader["KhoiLuong"];
                        ctpn.DonGia = Convert.ToSingle(reader["DonGia"]);

                        CTPNList.Add(ctpn);
                    }
                }

                return CTPNList;
            }
        }


        public ChiTietPhieuNhapModel GetById(int id)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM ChiTietPhieuNhap WHERE PhieuNhapId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                ChiTietPhieuNhapModel ctpn = new ChiTietPhieuNhapModel();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ctpn.PhieuNhapId = (int)reader["PhieuNhapId"];
                        ctpn.NguyenLieuId = (int)reader["NguyenLieuId"];
                        ctpn.KhoiLuong = (float)reader["KhoiLuong"];
                        ctpn.DonGia = (float)reader["DonGia"];
                    }
                }

                return ctpn;
            }
        }

        public int GetNextId()
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT MAX(PhieuNhapId) FROM ChiTietPhieuNhap";

                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    return (int)result + 1;
                }
                return 1;
            }
        }

        public IEnumerable<ChiTietPhieuNhapModel> GetByValue(string value)
        {
            List<ChiTietPhieuNhapModel> ChiTietPhieuNhapList = new List<ChiTietPhieuNhapModel>();

            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM ChiTietPhieuNhap WHERE PhieuNhapId LIKE @Value";
                cmd.Parameters.AddWithValue("@Value", "%" + value + "%");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChiTietPhieuNhapModel ctpn = new ChiTietPhieuNhapModel();
                        ctpn.PhieuNhapId = (int)reader["PhieuNhapId"];
                        ctpn.NguyenLieuId = (int)reader["NguyenLieuId"];
                        ctpn.KhoiLuong = (float)reader["KhoiLuong"];
                        ctpn.DonGia = (float)reader["DonGia"];
                        ChiTietPhieuNhapList.Add(ctpn);
                    }
                }
            }

            return ChiTietPhieuNhapList;
        }

        public bool IsExit(int id)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT COUNT(*) FROM ChiTietPhieuNhap WHERE PhieuNhapId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public void Update(ChiTietPhieuNhapModel obj)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "UPDATE ChiTietPhieuNhap SET PhieuNhapId = @PhieuNhapId, NguyenLieuId = @NguyenLieuId, KhoiLuong = @KhoiLuong, DonGia = @DonGia WHERE PhieuNhapId = @Id";

                cmd.Parameters.AddWithValue("@Id", obj.PhieuNhapId);
                cmd.Parameters.AddWithValue("@PhieuNhapId", obj.PhieuNhapId);
                cmd.Parameters.AddWithValue("@NguyenLieuId", obj.NguyenLieuId);
                cmd.Parameters.AddWithValue("@KhoiLuong", obj.KhoiLuong);
                cmd.Parameters.AddWithValue("@DonGia", obj.DonGia);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
