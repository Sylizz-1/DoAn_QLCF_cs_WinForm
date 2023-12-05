using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class NguyenLieuRepository : BaseRepository, INguyenLieuRepository
    {
        private string nguyenLieuImagePath;

        public NguyenLieuRepository(string connectionString)
        {
            this.connectionString = connectionString;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            var logoimage = Path.Combine(path, "image\\nguyenLieu");
            nguyenLieuImagePath = logoimage;
        }

        public IEnumerable<NguyenLieuModel> GetAll()
        {
            var cpList = new List<NguyenLieuModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "select * from NguyenLieu";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var NguyenLieu = new NguyenLieuModel();
                        NguyenLieu.NguyenLieuId = (int)reader["NguyenLieuId"];
#pragma warning disable CS8601 // Possible null reference assignment.
                        NguyenLieu.TenNguyenLieu = reader["TenNguyenLieu"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
                        NguyenLieu.ThongTin = reader["ThongTin"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8604 // Possible null reference argument.
                        NguyenLieu.KhoiLuong = float.Parse(reader["KhoiLuong"].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8604 // Possible null reference argument.
                        NguyenLieu.GiaTien_Kg = float.Parse(reader["GiaTien_Kg"].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8604 // Possible null reference argument.
                        string imgPath = Path.Combine(this.nguyenLieuImagePath, reader["HinhAnh"].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
                        try
                        {
                            NguyenLieu.HinhAnh = Image.FromFile(imgPath);
                        }
                        catch (OutOfMemoryException ex)
                        {
                            ex.ToString();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                            NguyenLieu.HinhAnh = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
                        }
                        NguyenLieu.IsDelete = (bool)reader["IsDelete"];

                        cpList.Add(NguyenLieu);
                    }
                }
                return cpList;
            }
        }
        public bool Add(NguyenLieuModel nguyenLieu)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO NguyenLieu (TenNguyenLieu, ThongTin, KhoiLuong, GiaTien_Kg, HinhAnh, IsDelete) " +
                                      "VALUES (@TenNguyenLieu, @ThongTin, @KhoiLuong, @GiaTien_Kg, @HinhAnh, @IsDelete)";

                    // Đặt giá trị cho các tham số
                    cmd.Parameters.AddWithValue("@TenNguyenLieu", nguyenLieu.TenNguyenLieu);
                    cmd.Parameters.AddWithValue("@ThongTin", nguyenLieu.ThongTin);
                    cmd.Parameters.AddWithValue("@KhoiLuong", nguyenLieu.KhoiLuong);
                    cmd.Parameters.AddWithValue("@GiaTien_Kg", nguyenLieu.GiaTien_Kg);

                    if (nguyenLieu.HinhAnh != null)
                    {
                        string imgPath = nguyenLieu.HinhAnh.ToString();
                        cmd.Parameters.AddWithValue("@HinhAnh", imgPath);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@HinhAnh", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@IsDelete", nguyenLieu.IsDelete);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    cmd.CommandText = "Update NguyenLieu Set IsDelete = @IsDelete Where NguyenLieuId = @Id";

                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@IsDelete", true);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }


        public NguyenLieuModel GetById(int id)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM NguyenLieu WHERE NguyenLieuId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                var NguyenLieu = new NguyenLieuModel();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        NguyenLieu.NguyenLieuId = (int)reader["NguyenLieuId"];
#pragma warning disable CS8601 // Possible null reference assignment.
                        NguyenLieu.TenNguyenLieu = reader["TenNguyenLieu"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
                        NguyenLieu.ThongTin = reader["ThongTin"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8604 // Possible null reference argument.
                        NguyenLieu.KhoiLuong = float.Parse(reader["KhoiLuong"].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8604 // Possible null reference argument.
                        NguyenLieu.GiaTien_Kg = float.Parse(reader["GiaTien_Kg"].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8604 // Possible null reference argument.
                        string imgPath = Path.Combine(this.nguyenLieuImagePath, reader["HinhAnh"].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
                        try
                        {
                            NguyenLieu.HinhAnh = Image.FromFile(imgPath);
                        }
                        catch (OutOfMemoryException ex)
                        {
                            ex.ToString();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                            NguyenLieu.HinhAnh = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
                        }
                        NguyenLieu.IsDelete = (bool)reader["IsDelete"];
                    }
                }

                return NguyenLieu;
            }
        }

        public int GetNextId()
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT MAX(NguyenLieuId) FROM NguyenLieu";

                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    return (int)result + 1;
                }
                return 1;
            }
        }

        public IEnumerable<NguyenLieuModel> GetByValue(string NguyenLieuId, string TenNguyenLieu, string ThongTin, string KhoiLuong, string GiaTien_Kg, string HinhAnh, bool? isDelete)
        {
            List<NguyenLieuModel> nguyenLieuList = new List<NguyenLieuModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                StringBuilder queryBuilder = new StringBuilder("Select * from NguyenLieu where 1=1");
                    
                if(!String.IsNullOrEmpty(NguyenLieuId))
                {
                    queryBuilder.Append(" and NguyenLieuId = @NguyenLieuId");
                    cmd.Parameters.AddWithValue("@NguyenLieuId", NguyenLieuId);
                }
                if (!String.IsNullOrEmpty(TenNguyenLieu))
                {
                    queryBuilder.Append(" and TenNguyenLieu = @TenNguyenLieu");
                    cmd.Parameters.AddWithValue("@TenNguyenLieu", TenNguyenLieu);
                }
                if (!String.IsNullOrEmpty(ThongTin))
                {
                    queryBuilder.Append(" and ThongTin = @ThongTin");
                    cmd.Parameters.AddWithValue("@ThongTin", ThongTin);
                }
                if (!String.IsNullOrEmpty(KhoiLuong))
                {
                    queryBuilder.Append(" and KhoiLuong = @KhoiLuong");
                    cmd.Parameters.AddWithValue("@KhoiLuong", KhoiLuong);
                }
                if (!String.IsNullOrEmpty(GiaTien_Kg))
                {
                    queryBuilder.Append(" and GiaTien_Kg = @GiaTien_Kg");
                    cmd.Parameters.AddWithValue("@GiaTien_Kg", GiaTien_Kg);
                }
                if (!String.IsNullOrEmpty(HinhAnh.ToString()))
                {
                    queryBuilder.Append(" AND HinhAnh = @HinhAnh");
                    cmd.Parameters.AddWithValue("@HinhAnh", HinhAnh);
                }
                if (isDelete.HasValue)
                {
                    queryBuilder.Append(" and isDelete = @isDelete");
                    cmd.Parameters.AddWithValue("@isDelete", isDelete);
                }
                cmd.CommandText = queryBuilder.ToString();
                using(var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var NguyenLieu = new NguyenLieuModel();
                        NguyenLieu.NguyenLieuId = (int)reader["NguyenLieuId"];
#pragma warning disable CS8601 // Possible null reference assignment.
                        NguyenLieu.TenNguyenLieu = reader["TenNguyenLieu"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
                        NguyenLieu.ThongTin = reader["ThongTin"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8604 // Possible null reference argument.
                        NguyenLieu.KhoiLuong = float.Parse(reader["KhoiLuong"].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8604 // Possible null reference argument.
                        NguyenLieu.GiaTien_Kg = float.Parse(reader["GiaTien_Kg"].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8604 // Possible null reference argument.
                        string imgPath = Path.Combine(this.nguyenLieuImagePath, reader["HinhAnh"].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
                        try
                        {
                            NguyenLieu.HinhAnh = Image.FromFile(imgPath);
                        }
                        catch (OutOfMemoryException ex)
                        {
                            ex.ToString();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                            NguyenLieu.HinhAnh = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
                        }
                        NguyenLieu.IsDelete = (bool)reader["IsDelete"];

                        nguyenLieuList.Add(NguyenLieu);
                    }
                }
            }
            return nguyenLieuList;
        }


        public bool IsExit(int id)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT COUNT(*) FROM NguyenLieu WHERE NguyenLieuId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public bool Update(NguyenLieuModel obj)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE NguyenLieu SET TenNguyenLieu = @Ten, ThongTin = @ThongTin, KhoiLuong = @KhoiLuong, GiaTien_Kg = @GiaTien_Kg, HinhAnh = @HinhAnh, IsDelete = @IsDelete WHERE NguyenLieuId = @Id";

                    cmd.Parameters.AddWithValue("@Id", obj.NguyenLieuId);
                    cmd.Parameters.AddWithValue("@Ten", obj.TenNguyenLieu);
                    cmd.Parameters.AddWithValue("@ThongTin", obj.ThongTin);
                    cmd.Parameters.AddWithValue("@KhoiLuong", obj.KhoiLuong);
                    cmd.Parameters.AddWithValue("@GiaTien_Kg", obj.GiaTien_Kg);
                    cmd.Parameters.AddWithValue("@HinhAnh", obj.HinhAnh);
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