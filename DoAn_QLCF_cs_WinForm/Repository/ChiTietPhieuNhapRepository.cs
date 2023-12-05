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
        NguyenLieuRepository repoNgl;
        public ChiTietPhieuNhapRepository(string connectionString)
        {
            this.connectionString = connectionString;
            repoNgl = new NguyenLieuRepository(connectionString);
        }

        public bool Add(ChiTietPhieuNhapModel ctpn)
        {
            try
            {
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
                    NguyenLieuModel ngl = repoNgl.GetById(ctpn.NguyenLieuId);
                    float dg_bd = ngl.GiaTien_Kg;
                    if(dg_bd != ctpn.DonGia)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn cập nhật đơn giá mới của "+ ngl.TenNguyenLieu +" không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                            repoNgl.UpdateKL_DG(ctpn.NguyenLieuId, ctpn.KhoiLuong, ctpn.DonGia);
                        else
                            repoNgl.UpdateKL_DG(ctpn.NguyenLieuId, ctpn.KhoiLuong, dg_bd);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool Update(ChiTietPhieuNhapModel obj)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;

                    ChiTietPhieuNhapModel ctpn = GetByValue(obj.PhieuNhapId.ToString(), obj.NguyenLieuId.ToString(), null, null)[0];
                    float klg_bd = ctpn.KhoiLuong;
                    float klg_cn = obj.KhoiLuong;

                    NguyenLieuModel ngl = repoNgl.GetById(ctpn.NguyenLieuId);
                    float dg_bd = ngl.GiaTien_Kg;
                    if (dg_bd != ctpn.DonGia)
                    {
                        DialogResult result = MessageBox.Show("Bạn có muốn cập nhật đơn giá mới của "+ ngl.TenNguyenLieu +" không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                            repoNgl.UpdateKL_DG(ctpn.NguyenLieuId, klg_cn - klg_bd, ctpn.DonGia);
                        else
                            repoNgl.UpdateKL_DG(ctpn.NguyenLieuId, klg_cn - klg_bd, dg_bd);
                    }
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
                    List<ChiTietPhieuNhapModel> Listctpn = GetById(id);
                    foreach(ChiTietPhieuNhapModel ctpn in  Listctpn)
                    {
                        NguyenLieuModel ngl = repoNgl.GetById(ctpn.NguyenLieuId);
                        repoNgl.UpdateKL_DG(ctpn.NguyenLieuId, -ctpn.KhoiLuong, ngl.GiaTien_Kg);
                    }    

                    cmd.CommandText = "DELETE FROM ChiTietPhieuNhap WHERE PhieuNhapId = @Id";
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

        public IEnumerable<ChiTietPhieuNhapModel> GetAll()
        {
            var CTPNList = new List<ChiTietPhieuNhapModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM ChiTietPhieuNhap";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChiTietPhieuNhapModel ctpn = new ChiTietPhieuNhapModel();
                        ctpn.PhieuNhapId = (int)reader["PhieuNhapId"];
                        ctpn.NguyenLieuId = (int)reader["NguyenLieuId"];
                        ctpn.KhoiLuong = Convert.ToSingle(reader["KhoiLuong"]);
                        ctpn.DonGia = Convert.ToSingle(reader["DonGia"]);

                        CTPNList.Add(ctpn);
                    }
                }

                return CTPNList;
            }
        }
        public List<ChiTietPhieuNhapModel> GetById(int id)
        {
            var CTPNList = new List<ChiTietPhieuNhapModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM ChiTietPhieuNhap WHERE PhieuNhapId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChiTietPhieuNhapModel ctpn = new ChiTietPhieuNhapModel();
                        ctpn.PhieuNhapId = (int)reader["PhieuNhapId"];
                        ctpn.NguyenLieuId = (int)reader["NguyenLieuId"];
                        ctpn.KhoiLuong = Convert.ToSingle(reader["KhoiLuong"]);
                        ctpn.DonGia = Convert.ToSingle(reader["DonGia"]);

                        CTPNList.Add(ctpn);
                    }
                }
            }
            return CTPNList;
        }
        public ChiTietPhieuNhapModel GetByIdNgl(int id)
        {
            ChiTietPhieuNhapModel ctpn = new ChiTietPhieuNhapModel();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM ChiTietPhieuNhap WHERE PhieuNhapId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ctpn.PhieuNhapId = (int)reader["PhieuNhapId"];
                        ctpn.NguyenLieuId = (int)reader["NguyenLieuId"];
                        ctpn.KhoiLuong = Convert.ToSingle(reader["KhoiLuong"]);
                        ctpn.DonGia = Convert.ToSingle(reader["DonGia"]);
                    }
                }
            }
            return ctpn;
        }

        public int GetMaxId()
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
                    return (int)result+1;
                }
                return 1;
            }
        }

        public List<ChiTietPhieuNhapModel> GetByValue(string pnId, string nglId, string klg, string dg)
        {
            List<ChiTietPhieuNhapModel> ctpnList = new List<ChiTietPhieuNhapModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM ChiTietPhieuNhap WHERE 1=1");

                if (!string.IsNullOrEmpty(pnId))
                {
                    queryBuilder.Append(" AND PhieuNhapId = @PhieuNhapId");
                    cmd.Parameters.AddWithValue("@PhieuNhapId", pnId);
                }
                if (!string.IsNullOrEmpty(nglId) && nglId != "0")
                {
                    queryBuilder.Append(" AND NguyenLieuId LIKE @NguyenLieuId");
                    cmd.Parameters.AddWithValue("@NguyenLieuId", "%" + nglId + "%");
                }
                if (!string.IsNullOrEmpty(klg))
                {
                    queryBuilder.Append(" AND KhoiLuong LIKE @KhoiLuong");
                    cmd.Parameters.AddWithValue("@KhoiLuong", "%" + klg + "%");
                }
                if (!String.IsNullOrEmpty(dg))
                {
                    queryBuilder.Append(" and DonGia = @DonGia");
                    cmd.Parameters.AddWithValue("@DonGia", dg);
                }

                cmd.CommandText = queryBuilder.ToString();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ctpn = new ChiTietPhieuNhapModel();
                        ctpn.PhieuNhapId = (int)reader["PhieuNhapId"];
                        ctpn.NguyenLieuId = (int)reader["NguyenLieuId"];
                        ctpn.KhoiLuong = Convert.ToSingle(reader["KhoiLuong"]);
                        ctpn.DonGia = Convert.ToSingle(reader["DonGia"]);
                        ctpnList.Add(ctpn);
                    }
                }
            }

            return ctpnList;
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
    }
}
