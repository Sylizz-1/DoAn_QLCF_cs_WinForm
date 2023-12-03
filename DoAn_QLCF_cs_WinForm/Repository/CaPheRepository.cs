using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository
{
	public class CaPheRepository : BaseRepository, ICaPheRepository
	{
		private string caPheImagePath;
		private string nguyenLieuImagePath;

		public CaPheRepository(string connectionString) {
			this.connectionString = connectionString;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
			string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			caPheImagePath = Path.Combine(path, "image\\caPhe");
			nguyenLieuImagePath = Path.Combine(path, "image\\nguyenLieu");
		}

		public bool Add(CaPheModel obj)
		{
			try
			{
				using (var connection = new SqlConnection(this.connectionString))
				using (var cmd = connection.CreateCommand())
				{
					connection.Open();
					cmd.Connection = connection;

					cmd.CommandText = "SET IDENTITY_INSERT CaPhe ON " +
						"insert into CaPhe ( CaPheId,TenCaPhe, Gia, MieuTa, XuatXu, HinhAnh, IsDeleted)" +
									  "VALUES (@CaPheId,@Ten, @Gia, @MieuTa, @XuatXu, @HinhAnh,@IsDeleted) " +
									  "SET IDENTITY_INSERT CaPhe OFF";

					cmd.Parameters.AddWithValue("@CaPheId", obj.Id);
					cmd.Parameters.AddWithValue("@Ten", obj.Ten);
					cmd.Parameters.AddWithValue("@Gia", obj.Gia);
					cmd.Parameters.AddWithValue("@MieuTa", obj.MieuTa);
					cmd.Parameters.AddWithValue("@XuatXu", obj.XuatXu);

					// save image to project
					SaveImage(obj.HinhAnh);
					cmd.Parameters.AddWithValue("@HinhAnh", obj.HinhAnh.Tag.ToString());
					cmd.Parameters.AddWithValue("@IsDeleted", obj.IsDeleted);

					if (cmd.ExecuteNonQuery() > 0)
						return true;
					return false;
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
					cmd.CommandText = "UPDATE CaPhe SET IsDeleted = @IsDeleted WHERE CaPheId = @Id";

					cmd.Parameters.AddWithValue("@Id", id);
					cmd.Parameters.AddWithValue("@IsDeleted", true);

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

		public IEnumerable<CaPheModel> GetAll()
		{
			// Tạo một danh sách Caphemodel
			var cpList = new List<CaPheModel>();
			using(var connection = new SqlConnection(this.connectionString))
			using(var cmd = connection.CreateCommand())
			{
				connection.Open();
				cmd.Connection = connection;
				cmd.CommandText = "select * from CaPhe order by CaPheId asc";
				using(var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						var cpModel = new CaPheModel();
						cpModel.Id = (int)reader["CaPheId"];
#pragma warning disable CS8601 // Possible null reference assignment.
						cpModel.Ten = reader["TenCaPhe"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
						cpModel.Gia = Convert.ToSingle(reader["Gia"]) ;
#pragma warning disable CS8601 // Possible null reference assignment.
						cpModel.MieuTa = reader["MieuTa"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8601 // Possible null reference assignment.
						cpModel.XuatXu = reader["XuatXu"].ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning disable CS8604 // Possible null reference argument.
						string imgPath = Path.Combine(this.caPheImagePath, reader["HinhAnh"].ToString());
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning disable CS8601 // Possible null reference assignment.
						cpModel.HinhAnh = Image.FromFile(imgPath) ?? null;
						cpModel.HinhAnh.Tag = reader["HinhAnh"].ToString();
						cpModel.IsDeleted = (bool)reader["IsDeleted"];

						cpList.Add(cpModel);
					}
				}

				return cpList;
			}
		}

		public IEnumerable<NguyenLieuModel> GetAllNguyenLieu()
		{
			NguyenLieuRepository nlRepo = new NguyenLieuRepository(this.connectionString);
			return nlRepo.GetAll();
		}

		public CaPheModel GetById(int id)
		{
			var cpModel = new CaPheModel();
			using (var connection = new SqlConnection(this.connectionString))
			using (var cmd = connection.CreateCommand())
			{
				connection.Open();
				cmd.Connection = connection;
				cmd.CommandText = "SELECT * FROM CaPhe WHERE CaPheId = @Id";
				cmd.Parameters.AddWithValue("@Id", id);

				
				using (var reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						cpModel.Id = (int)reader["CaPheId"];
						cpModel.Ten = reader["TenCaPhe"].ToString();
						cpModel.Gia = Convert.ToSingle(reader["Gia"]);
						cpModel.MieuTa = reader["MieuTa"].ToString();
						cpModel.XuatXu = reader["XuatXu"].ToString();
						string imgPath = Path.Combine(this.caPheImagePath, reader["HinhAnh"].ToString());
						cpModel.HinhAnh = Image.FromFile(imgPath) ?? null;
						cpModel.HinhAnh.Tag = reader["HinhAnh"].ToString();
						cpModel.IsDeleted = (bool)reader["IsDeleted"];
					}
				}

				return cpModel;
			}
		}

		public IEnumerable<CaPheModel> GetByValue(string value)
		{
			throw new NotImplementedException();
		}

		public int GetLastId()
		{
			using (var connection = new SqlConnection(this.connectionString))
			using (var cmd = connection.CreateCommand())
			{
				connection.Open();
				cmd.Connection = connection;
				cmd.CommandText = "SELECT MAX(CaPheId) FROM CaPhe";

				var result = cmd.ExecuteScalar();

				if (result != DBNull.Value)
				{
					return (int)result;
				}
				return 1;
			}
		}

		public IEnumerable<CaPheNguyenLieuModel> GetNguyenLieuOfCaPhe(int caPheId)
		{
			// Tạo một danh sách Caphemodel
			var cpnlList = new List<CaPheNguyenLieuModel>();
			using (var connection = new SqlConnection(this.connectionString))
			using (var cmd = connection.CreateCommand())
			{
				connection.Open();
				cmd.Connection = connection;
				cmd.CommandText = "select NL.NguyenLieuId, NL.HinhAnh,NL.TenNguyenLieu, CaPhe_NguyenLieu.KhoiLuong from CaPhe_NguyenLieu\r\n" +
					"inner join dbo.NguyenLieu NL on NL.NguyenLieuId = CaPhe_NguyenLieu.NguyenLieuId and NL.IsDelete = 0\r\n" +
					"where CaPheId = @Id";
				cmd.Parameters.AddWithValue("@Id", caPheId);
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						var cpnlModel = new CaPheNguyenLieuModel();

						cpnlModel.CaPheId = caPheId;
						cpnlModel.NguyenLieuId = (int)reader["NguyenLieuId"];
						cpnlModel.TenNguyenLieu = reader["TenNguyenLieu"].ToString();
						string imgPath = Path.Combine(this.nguyenLieuImagePath, reader["HinhAnh"].ToString());
						cpnlModel.HinhAnh = Image.FromFile(imgPath) ?? null;
						cpnlModel.HinhAnh.Tag = reader["HinhAnh"].ToString();
						cpnlModel.KhoiLuong = Convert.ToSingle(reader["KhoiLuong"].ToString());

						cpnlList.Add(cpnlModel);
					}
				}
				return cpnlList;
			}
		}

		public bool IsExit(int id)
		{
			using (var connection = new SqlConnection(this.connectionString))
			using (var cmd = connection.CreateCommand())
			{
				connection.Open();
				cmd.Connection = connection;
				cmd.CommandText = "SELECT COUNT(*) FROM CaPhe WHERE CaPheId = @Id";
				cmd.Parameters.AddWithValue("@Id", id);

				int count = (int)cmd.ExecuteScalar();

				return count > 0;
			}
		}

		public bool Update(CaPheModel obj)
		{
			try
			{
				using (var connection = new SqlConnection(this.connectionString))
				using (var cmd = connection.CreateCommand())
				{
					connection.Open();
					cmd.Connection = connection;

					cmd.CommandText = "UPDATE CaPhe SET TenCaPhe = @Ten, Gia = @Gia, MieuTa = @MieuTa," +
						" XuatXu = @XuatXu, HinhAnh = @HinhAnh,IsDeleted = @IsDelete WHERE CaPheId = @Id";
					cmd.Parameters.AddWithValue("@Id", obj.Id);
					cmd.Parameters.AddWithValue("@Ten", obj.Ten);
					cmd.Parameters.AddWithValue("@Gia", obj.Gia);
					cmd.Parameters.AddWithValue("@MieuTa", obj.MieuTa);
					cmd.Parameters.AddWithValue("@XuatXu", obj.XuatXu);

					// save image to project
					SaveImage(obj.HinhAnh);
					cmd.Parameters.AddWithValue("@HinhAnh", obj.HinhAnh.Tag.ToString());
					cmd.Parameters.AddWithValue("@IsDelete", obj.IsDeleted);

					if (cmd.ExecuteNonQuery() > 0)
						return true;
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		public bool UpdateChiTietNguyenLieu(int caPheId, IEnumerable<CaPheNguyenLieuModel> cpnlList)
		{
			try
			{
				using (var connection = new SqlConnection(this.connectionString))
				using (var cmd = connection.CreateCommand())
				{
					connection.Open();
					cmd.Connection = connection;
					cmd.CommandText = "DELETE FROM CaPhe_NguyenLieu WHERE CaPheId = @Id";
					cmd.Parameters.AddWithValue("@Id", caPheId);
					cmd.ExecuteNonQuery();


					cmd.CommandText = "insert into CaPhe_NguyenLieu (CaPheId, NguyenLieuId, KhoiLuong)" +
						"VALUES (@CaPheId, @NguyenLieuId, @KhoiLuong)";

					foreach (CaPheNguyenLieuModel cpnlModel in cpnlList)
					{
						/*cmd.Parameters.Clear();*/
						cmd.Parameters.AddWithValue("@CaPheId", caPheId);
						cmd.Parameters.AddWithValue("@NguyenLieuId", cpnlModel.NguyenLieuId);
						cmd.Parameters.AddWithValue("@KhoiLuong", cpnlModel.KhoiLuong);

						cmd.ExecuteNonQuery();
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

		private void SaveImage(Image img)
		{
			string filePath = Path.Combine(this.caPheImagePath, img.Tag.ToString());
/*			if (File.Exists(filePath))
			{
				File.Delete(filePath);
			}*/

			using (Image imgCopy = img)
			{
				imgCopy.Save(filePath);
			}
		}
			
	}
}
