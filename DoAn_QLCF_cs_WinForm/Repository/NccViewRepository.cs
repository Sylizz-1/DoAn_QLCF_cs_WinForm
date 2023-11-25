﻿using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System.Data.SqlClient;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class NccRepository : BaseRepository, INccRepository
    {
        public NccRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Add(NccModel ncc)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;

                    cmd.CommandText = "INSERT INTO NhaCungCap (TenNhaCungCap, DiaChi, SDT, Email, IsDelete) " +
                                      "VALUES (@Ten, @DiaChi, @SDT, @Email, @IsDelete)";

                    cmd.Parameters.AddWithValue("@Ten", ncc.TenNhaCungCap);
                    cmd.Parameters.AddWithValue("@DiaChi", ncc.DiaChi);
                    cmd.Parameters.AddWithValue("@SDT", ncc.SDT);
                    cmd.Parameters.AddWithValue("@Email", ncc.Email);
                    cmd.Parameters.AddWithValue("@IsDelete", ncc.IsDelete);

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
                    cmd.CommandText = "UPDATE NhaCungCap SET IsDelete = @IsDelete WHERE NhaCungCapId = @Id";

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

        public IEnumerable<NccModel> GetAll()
        {
            var cpList = new List<NccModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "select * from NhaCungCap";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ncc = new NccModel();
                        ncc.NhaCungCapId = (int)reader["NhaCungCapId"];
                        ncc.TenNhaCungCap = reader["TenNhaCungCap"].ToString();
                        ncc.DiaChi = reader["DiaChi"].ToString();
                        ncc.SDT = reader["SDT"].ToString();
                        ncc.Email = reader["Email"].ToString();
                        ncc.IsDelete = (bool)reader["IsDelete"];

                        cpList.Add(ncc);
                    }
                }

                return cpList;
            }
        }

        public NccModel GetById(int id)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM NhaCungCap WHERE NhaCungCapId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                var ncc = new NccModel();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ncc.NhaCungCapId = (int)reader["NhaCungCapId"];
                        ncc.TenNhaCungCap = reader["TenNhaCungCap"].ToString();
                        ncc.DiaChi = reader["DiaChi"].ToString();
                        ncc.SDT = reader["SDT"].ToString();
                        ncc.Email = reader["Email"].ToString();
                        ncc.IsDelete = (bool)reader["IsDelete"];
                    }
                }

                return ncc;
            }
        }

        public int GetNextId()
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT MAX(NhaCungCapId) FROM NhaCungCap";

                var result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    return (int)result + 1;
                }
                return 1;
            }
        }

        public IEnumerable<NccModel> GetByValue(string value)
        {
            List<NccModel> nccList = new List<NccModel>();

            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM NhaCungCap WHERE TenNhaCungCap LIKE @Value";
                cmd.Parameters.AddWithValue("@Value", "%" + value + "%");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ncc = new NccModel
                        {
                            NhaCungCapId = (int)reader["NhaCungCapId"],
                            TenNhaCungCap = reader["TenNhaCungCap"].ToString(),
                            DiaChi = reader["DiaChi"].ToString(),
                            SDT = reader["SDT"].ToString(),
                            Email = reader["Email"].ToString(),
                            IsDelete = (bool)reader["IsDelete"]
                        };
                        nccList.Add(ncc);
                    }
                }
            }

            return nccList;
        }

        public bool IsExit(int id)
        {
            using (var connection = new SqlConnection(this.connectionString))
            using (var cmd = connection.CreateCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT COUNT(*) FROM NhaCungCap WHERE NhaCungCapId = @Id";
                cmd.Parameters.AddWithValue("@Id", id);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }

        public bool Update(NccModel obj)
        {
            try
            {
                using (var connection = new SqlConnection(this.connectionString))
                using (var cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE NhaCungCap SET TenNhaCungCap = @Ten, DiaChi = @DiaChi, SDT = @SDT, Email = @Email, IsDelete = @IsDelete WHERE NhaCungCapId = @Id";

                    cmd.Parameters.AddWithValue("@Id", obj.NhaCungCapId);
                    cmd.Parameters.AddWithValue("@Ten", obj.TenNhaCungCap);
                    cmd.Parameters.AddWithValue("@DiaChi", obj.DiaChi);
                    cmd.Parameters.AddWithValue("@SDT", obj.SDT);
                    cmd.Parameters.AddWithValue("@Email", obj.Email);
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