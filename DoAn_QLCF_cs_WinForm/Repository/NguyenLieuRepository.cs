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
    public class NguyenLieuRepository : BaseRepository, INguyenLieuRepository
    {
        private string nguyenLieuImagePath;

        public NguyenLieuRepository(string connectionString)
        {
            this.connectionString = connectionString;
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            var logoimage = Path.Combine(path, "image\\nguyenLieu");
            nguyenLieuImagePath = logoimage;
        }

        public void Add(NguyenLieuModel NguyenLieu)
        {
            MessageBox.Show("Success");
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;

                cmd.CommandText = "INSERT INTO NguyenLieu (TenNguyenLieu, ThongTin, KhoiLuong, GiaTien_Kg, HinhAnh, IsDelete) " +
                                  "VALUES (@Ten, @ThongTin, @KhoiLuong, @GiaTien_Kg. @HinhAnh, @IsDelete)";

                cmd.Parameters.AddWithValue("@Ten", NguyenLieu.TenNguyenLieu);
                cmd.Parameters.AddWithValue("@ThongTin", NguyenLieu.ThongTin);
                cmd.Parameters.AddWithValue("@KhoiLuong", NguyenLieu.KhoiLuong);
                cmd.Parameters.AddWithValue("@GiaTien_Kg", NguyenLieu.GiaTien_Kg);
                cmd.Parameters.AddWithValue("@HinhAnh", NguyenLieu.HinhAnh);
                cmd.Parameters.AddWithValue("@IsDelete", NguyenLieu.IsDelete);
                cmd.ExecuteNonQuery();
            }
        }



        public void Delete(int id)
        {
            throw new NotImplementedException();
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
                        NguyenLieu.TenNguyenLieu = reader["TenNguyenLieu"].ToString();
                        NguyenLieu.ThongTin = reader["ThongTin"].ToString();
                        NguyenLieu.KhoiLuong = float.Parse(reader["KhoiLuong"].ToString());
                        NguyenLieu.GiaTien_Kg = float.Parse(reader["GiaTien_Kg"].ToString());
                        string imgPath = Path.Combine(this.nguyenLieuImagePath, reader["HinhAnh"].ToString());
                        try
                        {
                            NguyenLieu.HinhAnh = Image.FromFile(imgPath);
                        }
                        catch (OutOfMemoryException ex)
                        {
                            ex.ToString();
                            NguyenLieu.HinhAnh = null;
                        }
                        NguyenLieu.IsDelete = (bool)reader["IsDelete"];

                        cpList.Add(NguyenLieu);
                    }
                }
                return cpList;
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
                        NguyenLieu.TenNguyenLieu = reader["TenNguyenLieu"].ToString();
                        NguyenLieu.ThongTin = reader["ThongTin"].ToString();
                        NguyenLieu.KhoiLuong = float.Parse(reader["KhoiLuong"].ToString());
                        NguyenLieu.GiaTien_Kg = float.Parse(reader["GiaTien_Kg"].ToString());
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

        public IEnumerable<NguyenLieuModel> GetByValue(string value)
        {
            var nguyenLieuList = new List<NguyenLieuModel>();

            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT * FROM NguyenLieu WHERE TenNguyenLieu LIKE @Value";
                    cmd.Parameters.AddWithValue("@Value", "%" + value + "%");

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var nguyenLieu = new NguyenLieuModel();

                            nguyenLieu.NguyenLieuId = (int)reader["NguyenLieuId"];
                            nguyenLieu.TenNguyenLieu = reader["TenNguyenLieu"].ToString();
                            nguyenLieu.ThongTin = reader["ThongTin"].ToString();

                            if (int.TryParse(reader["KhoiLuong"].ToString(), out int khoiLuong))
                                nguyenLieu.KhoiLuong = khoiLuong;

                            if (int.TryParse(reader["GiaTien_Kg"].ToString(), out int giaTienKg))
                                nguyenLieu.GiaTien_Kg = giaTienKg;

                            string imgPath = Path.Combine(this.nguyenLieuImagePath, reader["HinhAnh"].ToString());
                            nguyenLieu.HinhAnh = Image.FromFile(imgPath) ?? null;

                            nguyenLieu.IsDelete = (bool)reader["IsDelete"];

                            nguyenLieuList.Add(nguyenLieu);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
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

        public void Update(NguyenLieuModel obj)
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
            }
        }
    }
}