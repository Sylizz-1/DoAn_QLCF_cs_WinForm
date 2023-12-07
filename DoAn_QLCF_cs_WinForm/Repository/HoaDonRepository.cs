using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class HoaDonRepository : BaseRepository, IHoaDonRepository
    {

        public HoaDonRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Update(HoaDonModel obj)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = $"UPDATE HoaDon SET NhanVienId = @{nameof(obj.NhanVienId)}, " +
                                      $"KhachHangId = @{nameof(obj.KhachHangId)}, " +
                                      $"PggId = @{nameof(obj.PggId)}, " +
                                      $"NgayNhap = @{nameof(obj.NgayNhap)}, " +
                                      $"PhiTruocGiamGia = @{nameof(obj.PhiTruocGiamGia)}, " +
                                      $"GiamGia = @{nameof(obj.GiamGia)}, " +
                                      $"PhiSauGiamGia = @{nameof(obj.PhiSauGiamGia)}, " +
                                      $"IsAccepted = @{nameof(obj.IsAccepted)} " +
                                      $"WHERE HoaDonId = @{nameof(obj.HoaDonId)}";

                    cmd.Parameters.AddWithValue($"@{nameof(obj.HoaDonId)}", obj.HoaDonId);
                    cmd.Parameters.AddWithValue($"@{nameof(obj.NhanVienId)}", obj.NhanVienId);
                    cmd.Parameters.AddWithValue($"@{nameof(obj.KhachHangId)}", obj.KhachHangId);
                    cmd.Parameters.AddWithValue($"@{nameof(obj.PggId)}", obj.PggId);
                    cmd.Parameters.AddWithValue($"@{nameof(obj.NgayNhap)}", obj.NgayNhap);
                    cmd.Parameters.AddWithValue($"@{nameof(obj.PhiTruocGiamGia)}", obj.PhiTruocGiamGia);
                    cmd.Parameters.AddWithValue($"@{nameof(obj.GiamGia)}", obj.GiamGia);
                    cmd.Parameters.AddWithValue($"@{nameof(obj.PhiSauGiamGia)}", obj.PhiSauGiamGia);
                    cmd.Parameters.AddWithValue($"@{nameof(obj.IsAccepted)}", obj.IsAccepted);

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

        public IEnumerable<HoaDonModel> GetByValue(int hoaDonId, int nhanVienId, int khachHangId, int pggId, DateTime? ngayNhap, double phiTruocGiamGia, byte giamGia, double phiSauGiamGia, bool? isAccepted)
        {
            List<HoaDonModel> hdList = new List<HoaDonModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                StringBuilder queryBuilder = new StringBuilder("SELECT * FROM HoaDon WHERE 1=1");

                if (hoaDonId > 0)
                {
                    queryBuilder.Append($" AND HoaDonId = @{nameof(hoaDonId)}");
                    cmd.Parameters.AddWithValue($"@{nameof(hoaDonId)}", hoaDonId);
                }
                if (nhanVienId > 0)
                {
                    queryBuilder.Append($" AND NhanVienId = @{nameof(nhanVienId)}");
                    cmd.Parameters.AddWithValue($"@{nameof(nhanVienId)}", nhanVienId);
                }
                if (khachHangId > 0)
                {
                    queryBuilder.Append($" AND KhachHangId = @{nameof(khachHangId)}");
                    cmd.Parameters.AddWithValue($"@{nameof(khachHangId)}", khachHangId);
                }
                if (pggId > 0)
                {
                    queryBuilder.Append($" AND PggId = @{nameof(pggId)}");
                    cmd.Parameters.AddWithValue($"@{nameof(pggId)}", pggId);
                }
                if (ngayNhap.HasValue)
                {
                    queryBuilder.Append($" AND NgayNhap = @{nameof(ngayNhap)}");
                    cmd.Parameters.AddWithValue($"@{nameof(ngayNhap)}", ngayNhap.Value);
                }
                if (phiTruocGiamGia > 0)
                {
                    queryBuilder.Append($" AND PhiTruocGiamGia = @{nameof(phiTruocGiamGia)}");
                    cmd.Parameters.AddWithValue($"@{nameof(phiTruocGiamGia)}", phiTruocGiamGia);
                }
                if (giamGia > 0)
                {
                    queryBuilder.Append($" AND GiamGia = @{nameof(giamGia)}");
                    cmd.Parameters.AddWithValue($"@{nameof(giamGia)}", giamGia);
                }
                if (phiSauGiamGia > 0)
                {
                    queryBuilder.Append($" AND PhiSauGiamGia = @{nameof(phiSauGiamGia)}");
                    cmd.Parameters.AddWithValue($"@{nameof(phiSauGiamGia)}", phiSauGiamGia);
                }
                if (isAccepted.HasValue)
                {
                    queryBuilder.Append($" AND isAccepted = @{nameof(isAccepted)}");
                    cmd.Parameters.AddWithValue($"@{nameof(isAccepted)}", isAccepted);
                }

                cmd.CommandText = queryBuilder.ToString();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var hd = new HoaDonModel
                        {
                            HoaDonId = (int)reader["HoaDonId"],
                            NhanVienId = (int)reader["NhanVienId"],
                            KhachHangId = (int)reader["KhachHangId"],
                            PggId = (int)reader["PggId"],
                            NgayNhap = (DateTime)reader["NgayNhap"],
                            PhiTruocGiamGia = (float)reader["PhiTruocGiamGia"],
                            GiamGia = (byte)reader["GiamGia"],
                            PhiSauGiamGia = (float)reader["PhiSauGiamGia"],
                            IsAccepted = (bool)reader["IsAccepted"]
                        };
                        hdList.Add(hd);
                    }
                }
            }

            return hdList;
        }

        public IEnumerable<HoaDonModel> GetAll()
        {
            var cpList = new List<HoaDonModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "select * from HoaDon";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var hd = new HoaDonModel();
                        hd.HoaDonId = (int)reader["HoaDonId"];
                        hd.NhanVienId = (int)reader["NhanVienId"];
                        hd.KhachHangId = (int)reader["KhachHangId"];
                        hd.PggId = (int)reader["PggId"];
                        hd.NgayNhap = (DateTime)(reader["NgayNhap"]);
                        hd.PhiTruocGiamGia = (double)reader["PhiTruocGiamGia"];
                        hd.GiamGia = (byte)reader["GiamGia"];
                        hd.PhiSauGiamGia = (double)reader["PhiSauGiamGia"];                     
                        hd.IsAccepted = (bool)reader["IsAccepted"];
                        cpList.Add(hd);
                    }
                }

                return cpList;
            }
        }

        public HoaDonModel GetById(int id)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM HoaDon WHERE HoaDonId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                var hd = new HoaDonModel();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        hd.HoaDonId = (int)reader["HoaDonId"];
                        hd.NhanVienId = (int)reader["NhanVienId"];
                        hd.KhachHangId = (int)reader["KhachHangId"];
                        hd.PggId = (int)reader["PggId"];
                        hd.NgayNhap = (DateTime)(reader["NgayNhap"]);
                        hd.PhiTruocGiamGia = (double)reader["PhiTruocGiamGia"];
                        hd.GiamGia = (byte)reader["GiamGia"];
                        hd.PhiSauGiamGia = (double)reader["PhiSauGiamGia"];
                        hd.IsAccepted = (bool)reader["IsAccepted"];
                    }
                }
                return hd;
            }
        }


        public IEnumerable<ChiTietHoaDonModel> GetByValue_CT(int hoaDonId, int caPheId, string? tenCaPhe, int soLuong, double donGia)
        {
            List<ChiTietHoaDonModel> cthdList = new List<ChiTietHoaDonModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                StringBuilder queryBuilder = new StringBuilder("SELECT C.HoaDonId, C.CaPheId, F.TenCaPhe, C.SoLuong, C.DonGia FROM ChiTietHoaDon AS C JOIN CaPhe AS F ON C.CaPheId = F.CaPheId WHERE 1 = 1");

                if (hoaDonId > 0)
                {
                    queryBuilder.Append($" AND C.HoaDonId = @{nameof(hoaDonId)}");
                    cmd.Parameters.AddWithValue($"@{nameof(hoaDonId)}", hoaDonId);
                }
                if (caPheId > 0)
                {
                    queryBuilder.Append($" AND C.CaPheId = @{nameof(caPheId)}");
                    cmd.Parameters.AddWithValue($"@{nameof(caPheId)}", caPheId);
                }
                if (!string.IsNullOrEmpty(tenCaPhe))
                {
                    queryBuilder.Append($" AND F.TenCaPhe LIKE @{nameof(tenCaPhe)}");
                    cmd.Parameters.AddWithValue($"@{nameof(tenCaPhe)}", "%" + tenCaPhe + "%");
                }
                if (soLuong > 0)
                {
                    queryBuilder.Append($" AND C.SoLuong = @{nameof(soLuong)}");
                    cmd.Parameters.AddWithValue($"@{nameof(soLuong)}", soLuong);
                }
                if (donGia > 0)
                {
                    queryBuilder.Append($" AND C.DonGia = @{nameof(donGia)}");
                    cmd.Parameters.AddWithValue($"@{nameof(donGia)}", donGia);
                }

                cmd.CommandText = queryBuilder.ToString();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cthd = new ChiTietHoaDonModel
                        {
                            CT_HoaDonId = (int)reader["HoaDonId"],
                            CT_CaPheId = (int)reader["CaPheId"],
                            CT_TenCaPhe = (string)reader["TenCaPhe"],
                            CT_SoLuong = (int)reader["SoLuong"],
                            CT_DonGia = (float)reader["DonGia"],
                        };
                        cthdList.Add(cthd);
                    }
                }
            }

            return cthdList;
        }


        public IEnumerable<ChiTietHoaDonModel> GetAll_CT()
        {
            var cpList = new List<ChiTietHoaDonModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT C.HoaDonId, C.CaPheId, F.TenCaPhe, C.SoLuong, C.DonGia FROM ChiTietHoaDon AS C JOIN CaPhe AS F ON C.CaPheId = F.CaPheId";

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cthd = new ChiTietHoaDonModel
                        {
                            CT_HoaDonId = (int)reader["HoaDonId"],
                            CT_CaPheId = (int)reader["CaPheId"],
                            CT_TenCaPhe = (string)reader["TenCaPhe"],
                            CT_SoLuong = (int)reader["SoLuong"],
                            CT_DonGia = (double)reader["DonGia"]
                        };
                        cpList.Add(cthd);
                    }
                }
            }

            return cpList;
        }

        public ChiTietHoaDonModel GetById_CT(int id)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT C.HoaDonId, C.CaPheId, F.TenCaPhe, C.SoLuong, C.DonGia FROM ChiTietHoaDon AS C JOIN CaPhe AS F ON C.CaPheId = F.CaPheId WHERE C.HoaDonId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ChiTietHoaDonModel
                        {
                            CT_HoaDonId = (int)reader["HoaDonId"],
                            CT_CaPheId = (int)reader["CaPheId"],
                            CT_TenCaPhe = (string)reader["TenCaPhe"],
                            CT_SoLuong = (int)reader["SoLuong"],
                            CT_DonGia = (float)reader["DonGia"]
                        };
                    }
                }
            }
            return null;
        }



    }
}