using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class PhieuNhapRepository : BaseRepository, IPhieuNhapRepository
    {
        public PhieuNhapRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Add(PhieuNhapModel PhieuNhap)
        {
            try
            {
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
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public bool Update(PhieuNhapModel obj)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE PhieuNhap SET NhanVienId = @NhanVienId, NhaCungCapId = @NhaCungCapId, NgayNhap = @NgayNhap, TongTien = @TongTien WHERE PhieuNhapId = @Id";

                    cmd.Parameters.AddWithValue("@Id", obj.PhieuNhapId);
                    cmd.Parameters.AddWithValue("@NhanVienId", obj.NhanVienId);
                    cmd.Parameters.AddWithValue("@NhaCungCapId", obj.NhaCungCapId);
                    cmd.Parameters.AddWithValue("@NgayNhap", obj.NgayNhap);
                    cmd.Parameters.AddWithValue("@TongTien", obj.TongTien);

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
                    cmd.CommandText = "DELETE FROM PhieuNhap WHERE PhieuNhapId = @Id";

                    cmd.Parameters.AddWithValue("@Id", id);

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

        public IEnumerable<PhieuNhapModel> GetByValue(string pnId, string nvId, string nccId, string nn, string tt)
        {
            List<PhieuNhapModel> phieuNhapList = new List<PhieuNhapModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM PhieuNhap WHERE 1=1");

                if (!string.IsNullOrEmpty(pnId))
                {
                    queryBuilder.Append(" AND PhieuNhapId = @PhieuNhapId");
                    cmd.Parameters.AddWithValue("@PhieuNhapId", pnId);
                }
                if (!string.IsNullOrEmpty(nvId) && nvId != "0")
                {
                    queryBuilder.Append(" AND NhanVienId LIKE @NhanVienId");
                    cmd.Parameters.AddWithValue("@NhanVienId", "%" + nvId + "%");
                }
                if (!string.IsNullOrEmpty(nccId) && nccId != "0")
                {
                    queryBuilder.Append(" AND NhaCungCapId LIKE @NhaCungCapId");
                    cmd.Parameters.AddWithValue("@NhaCungCapId", "%" + nccId + "%");
                }
                if (!string.IsNullOrEmpty(nn))
                {
                    string[] parts = DateTime.Parse(nn).ToString().Split(' ');
                    string dateString = parts[0];
                    queryBuilder.Append(" AND NgayNhap = @NgayNhap");
                    cmd.Parameters.AddWithValue("@NgayNhap", dateString);
                }
                if (!String.IsNullOrEmpty(tt) && tt != "0")
                {
                    queryBuilder.Append(" and TongTien = @TongTien");
                    cmd.Parameters.AddWithValue("@TongTien", tt);
                }

                cmd.CommandText = queryBuilder.ToString();
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
            }

            return phieuNhapList;
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
                        PhieuNhap.TongTien = Convert.ToSingle(reader["TongTien"]);
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

    }
}
