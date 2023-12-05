using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System.Data.SqlClient;
using System.Text;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class PggRepository : BaseRepository, IPggRepository
    {
        public PggRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public bool Add(PggModel pgg)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;

                    cmd.CommandText = "INSERT INTO PhieuGiamGia (PggId, TgBatDau, TgKetThuc, GiaHoaDon, PhanTramGiamGia, IsDelete) " +
                                      "VALUES (@PggId, @TgBatDau, @TgKetThuc, @GiaHoaDon, @PhanTramGiamGia, @IsDelete)";

                    cmd.Parameters.AddWithValue("@PggId", pgg.PggId);
                    cmd.Parameters.AddWithValue("@TgBatDau", pgg.TgBatDau);
                    cmd.Parameters.AddWithValue("@TgKetThuc", pgg.TgKetThuc);
                    cmd.Parameters.AddWithValue("@GiaHoaDon", pgg.GiaHoaDon);
                    cmd.Parameters.AddWithValue("@PhanTramGiamGia", pgg.PhanTramGiamGia);
                    cmd.Parameters.AddWithValue("@IsDelete", pgg.IsDelete);

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


        public bool Delete(int id)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE PhieuGiamGia SET IsDelete = @IsDelete WHERE PggId = @Id";

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@IsDelete", true);

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

        public IEnumerable<PggModel> GetByValue(int pggId, DateTime? tgBatDau, DateTime? tgKetThuc, float giaHoaDon, byte phanTramGiamGia, bool? isDelete)
        {
            List<PggModel> pggList = new List<PggModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM PhieuGiamGia WHERE 1=1");

                if (pggId > 0)
                {
                    queryBuilder.Append(" AND PggId = @PggId");
                    cmd.Parameters.AddWithValue("@PggId", pggId);
                }
                if (tgBatDau.HasValue)
                {
                    queryBuilder.Append(" AND TgBatDau = @TgBatDau");
                    cmd.Parameters.AddWithValue("@TgBatDau", tgBatDau.Value);
                }
                if (tgKetThuc.HasValue)
                {
                    queryBuilder.Append(" AND TgKetThuc = @TgKetThuc");
                    cmd.Parameters.AddWithValue("@TgKetThuc", tgKetThuc.Value);
                }
                if (giaHoaDon > 0)
                {
                    queryBuilder.Append(" AND GiaHoaDon = @GiaHoaDon");
                    cmd.Parameters.AddWithValue("@GiaHoaDon", giaHoaDon);
                }
                if (phanTramGiamGia > 0)
                {
                    queryBuilder.Append(" AND PhanTramGiamGia = @PhanTramGiamGia");
                    cmd.Parameters.AddWithValue("@PhanTramGiamGia", phanTramGiamGia);
                }
                if (isDelete.HasValue)
                {
                    queryBuilder.Append(" AND IsDelete = @IsDelete");
                    cmd.Parameters.AddWithValue("@IsDelete", isDelete.Value);
                }

                cmd.CommandText = queryBuilder.ToString();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pgg = new PggModel
                        {
                            PggId = (int)reader["PggId"],
                            TgBatDau = (DateTime?)reader["TgBatDau"],
                            TgKetThuc = (DateTime?)reader["TgKetThuc"],
                            GiaHoaDon = (double)reader["GiaHoaDon"],
                            PhanTramGiamGia = (byte)reader["PhanTramGiamGia"],
                            IsDelete = (bool)reader["IsDelete"]
                        };
                        pggList.Add(pgg);
                    }
                }
            }

            return pggList;
        }


        public IEnumerable<PggModel> GetAll()
        {
            var cpList = new List<PggModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "select * from PhieuGiamGia";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pgg = new PggModel();
                        pgg.PggId = (int)reader["PggId"];
                        pgg.TgBatDau = reader["TgBatDau"] as DateTime?;
                        pgg.TgKetThuc = reader["TgKetThuc"] as DateTime?;
                        pgg.GiaHoaDon = (double)reader["GiaHoaDon"];
                        pgg.PhanTramGiamGia = (byte)reader["PhanTramGiamGia"];
                        pgg.IsDelete = (bool)reader["IsDelete"];
                        cpList.Add(pgg);
                    }
                }

                return cpList;
            }
        }

        public PggModel GetById(int id)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM PhieuGiamGia WHERE PggId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                var pgg = new PggModel();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        pgg.PggId = (int)reader["PggId"];
                        pgg.TgBatDau = reader["TgBatDau"] as DateTime?;
                        pgg.TgKetThuc = reader["TgKetThuc"] as DateTime?;
                        pgg.GiaHoaDon = (double)reader["GiaHoaDon"];
                        pgg.PhanTramGiamGia = (byte)reader["PhanTramGiamGia"];
                        pgg.IsDelete = (bool)reader["IsDelete"];
                    }
                }
                return pgg;
            }
        }

        public int GetNextId()
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT MAX(PggId) FROM PhieuGiamGia";
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    return (int)result + 1;
                }
                return 1;
            }
        }



        public bool IsExit(int id)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT COUNT(*) FROM PhieuGiamGia WHERE PggId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public bool Update(PggModel obj)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE PhieuGiamGia SET TgBatDau = @TgBatDau, TgKetThuc = @TgKetThuc, GiaHoaDon = @GiaHoaDon, PhanTramGiamGia = @PhanTramGiamGia, IsDelete = @IsDelete WHERE PggId = @Id";

                    cmd.Parameters.AddWithValue("@Id", obj.PggId); 
                    cmd.Parameters.AddWithValue("@TgBatDau", obj.TgBatDau);
                    cmd.Parameters.AddWithValue("@TgKetThuc", obj.TgKetThuc);
                    cmd.Parameters.AddWithValue("@GiaHoaDon", obj.GiaHoaDon);
                    cmd.Parameters.AddWithValue("@PhanTramGiamGia", obj.PhanTramGiamGia);
                    cmd.Parameters.AddWithValue("@IsDelete", obj.IsDelete);

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
    }
}