using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System.Data.SqlClient;
using System.Text;

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
                    cmd.CommandText = "UPDATE HoaDon SET NhanVienId = @NhanVienId, KhachHangId = @KhachHangId, PggId = @PggId, NgayNhap = @NgayNhap, PhiTruocGiamGia = @PhiTruocGiamGia, GiamGia = @GiamGia, PhiSauGiamGia = @PhiSauGiamGia, IsAccepted = @IsAccepted WHERE HoaDonId = @Id";

                    cmd.Parameters.AddWithValue("@Id", obj.HoaDonId);
                    cmd.Parameters.AddWithValue("@NhanVienId", obj.NhanVienId);
                    cmd.Parameters.AddWithValue("@KhachHangId", obj.KhachHangId);
                    cmd.Parameters.AddWithValue("@PggId", obj.PggId);
                    cmd.Parameters.AddWithValue("@NgayNhap", obj.NgayNhap);
                    cmd.Parameters.AddWithValue("@PhiTruocGiamGia", obj.PhiTruocGiamGia);
                    cmd.Parameters.AddWithValue("@GiamGia", obj.GiamGia);
                    cmd.Parameters.AddWithValue("@PhiSauGiamGia", obj.PhiSauGiamGia);
                    cmd.Parameters.AddWithValue("@IsAccepted", obj.IsAccepted);

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

        public IEnumerable<HoaDonModel> GetByValue(int hoaDonId, int nhanVienId, int khachHangId, int pggId, DateTime? ngayNhap, float phiTruocGiamGia, byte giamGia, float phiSauGiamGia, bool? isAccepted)
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
                    queryBuilder.Append(" AND HoaDonId = @HoaDonId");
                    cmd.Parameters.AddWithValue("@HoaDonId", hoaDonId);
                }
                if (nhanVienId > 0)
                {
                    queryBuilder.Append(" AND NhanVienId = @NhanVienId");
                    cmd.Parameters.AddWithValue("@NhanVienId", nhanVienId);
                }
                if (khachHangId > 0)
                {
                    queryBuilder.Append(" AND KhachHangId = @KhachHangId");
                    cmd.Parameters.AddWithValue("@KhachHangId", pggId);
                }
                if (pggId > 0)
                {
                    queryBuilder.Append(" AND PggId = @PggId");
                    cmd.Parameters.AddWithValue("@PggId", pggId);
                }
                if (ngayNhap.HasValue)
                {
                    queryBuilder.Append(" AND NgayNhap = @NgayNhap");
                    cmd.Parameters.AddWithValue("@NgayNhap", ngayNhap.Value);
                }
                if (phiTruocGiamGia > 0)
                {
                    queryBuilder.Append(" AND PhiTruocGiamGia = @PhiTruocGiamGia");
                    cmd.Parameters.AddWithValue("@PhiTruocGiamGia", phiTruocGiamGia);
                }
                if (giamGia > 0)
                {
                    queryBuilder.Append(" AND GiamGia = @GiamGia");
                    cmd.Parameters.AddWithValue("@GiamGia", giamGia);
                }
                if (phiSauGiamGia > 0)
                {
                    queryBuilder.Append(" AND PhiSauGiamGia = @PhiSauGiamGia");
                    cmd.Parameters.AddWithValue("@PhiSauGiamGia", phiSauGiamGia);
                }
                if (isAccepted.HasValue)
                {
                    queryBuilder.Append(" AND isAccepted = @IsAccepted");
                    cmd.Parameters.AddWithValue("@IsAccepted", isAccepted);
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
                        hd.PhiTruocGiamGia = (float)reader["PhiTruocGiamGia"];
                        hd.GiamGia = (byte)reader["GiamGia"];
                        hd.PhiSauGiamGia = (float)reader["PhiSauGiamGia"];                     
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
                        hd.PhiTruocGiamGia = (float)reader["PhiTruocGiamGia"];
                        hd.GiamGia = (byte)reader["GiamGia"];
                        hd.PhiSauGiamGia = (float)reader["PhiSauGiamGia"];
                        hd.IsAccepted = (bool)reader["IsAccepted"];
                    }
                }
                return hd;
            }
        }
        

        public IEnumerable<ChiTietHoaDonModel> GetByValue_CT(int hoaDonId, int caPheId, string? tenCaPhe, int soLuong, float donGia)
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
                    queryBuilder.Append(" AND C.HoaDonId = @HoaDonId");
                    cmd.Parameters.AddWithValue("@HoaDonId", hoaDonId);
                }
                if (caPheId > 0)
                {
                    queryBuilder.Append(" AND C.CaPheId = @CaPheId");
                    cmd.Parameters.AddWithValue("@CaPheId", caPheId);
                }
                if (!string.IsNullOrEmpty(tenCaPhe))
                {
                    queryBuilder.Append(" AND F.TenCaPhe LIKE @TenCaPhe");
                    cmd.Parameters.AddWithValue("@TenCaPhe", "%" + tenCaPhe + "%");
                }
                if (soLuong > 0)
                {
                    queryBuilder.Append(" AND C.SoLuong = @SoLuong");
                    cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                }
                if (donGia > 0)
                {
                    queryBuilder.Append(" AND C.DonGia = @DonGia");
                    cmd.Parameters.AddWithValue("@DonGia", donGia);
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
                            CT_DonGia = (float)reader["DonGia"]
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