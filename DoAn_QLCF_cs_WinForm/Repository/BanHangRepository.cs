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
	public class BanHangRepository: BaseRepository, IBanHangRepository
	{
		private string caPheImagePath;
		private string nguyenLieuImagePath;

		public BanHangRepository(string connectionString)
		{
			this.connectionString = connectionString;
			string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			caPheImagePath = Path.Combine(path, "image\\caPhe");
			nguyenLieuImagePath = Path.Combine(path, "image\\nguyenLieu");
		}



		public IEnumerable<CaPheModel> GetAllCaPhe()
		{
			// Tạo một danh sách Caphemodel
			var cpList = new List<CaPheModel>();
			using (var connection = new SqlConnection(this.connectionString))
			using (var cmd = connection.CreateCommand())
			{
				connection.Open();
				cmd.Connection = connection;
				cmd.CommandText = "select * from CaPhe where IsDeleted = 0 order by CaPheId asc";
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						var cpModel = new CaPheModel();
						cpModel.Id = (int)reader["CaPheId"];

						cpModel.Ten = reader["TenCaPhe"].ToString();

						cpModel.Gia = Convert.ToSingle(reader["Gia"]);

						cpModel.MieuTa = reader["MieuTa"].ToString();

						cpModel.XuatXu = reader["XuatXu"].ToString();

						string imgPath = Path.Combine(this.caPheImagePath, reader["HinhAnh"].ToString());

						cpModel.HinhAnh = Image.FromFile(imgPath) ?? null;
						cpModel.HinhAnh.Tag = reader["HinhAnh"].ToString();
						cpModel.IsDeleted = (bool)reader["IsDeleted"];

						cpList.Add(cpModel);
					}
				}

				return cpList;
			}
		}

		public IEnumerable<PggModel> GetAllPgg()
		{
			var cpList = new List<PggModel>();
			using (var connection = new SqlConnection(this.connectionString))
			using (var cmd = connection.CreateCommand())
			{
				connection.Open();
				cmd.Connection = connection;
				cmd.CommandText = "select * from PhieuGiamGia " +
					"where getdate() >= TgBatDau and getdate() < TgKetThuc and IsDelete = 0";
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
						cpList.Add(pgg);
					}
				}

				return cpList;
			}
		}

		public int GetGiamGiaLoaiKh(int id)
		{
			
			int giamGia = 0;
			using (var connection = new SqlConnection(this.connectionString))
			using (var cmd = connection.CreateCommand())
			{
				connection.Open();
				cmd.Connection = connection;
				cmd.CommandText = "select GiamGia from LoaiKhachHang where LoaiKhachHangId = @Id";
				cmd.Parameters.AddWithValue("@Id", id);
				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						giamGia = Convert.ToInt32(reader["GiamGia"]);
					}
				}	
			}

			return giamGia;
		}

		public int GetLastId()
		{
			using (var connection = new SqlConnection(this.connectionString))
			using (var cmd = connection.CreateCommand())
			{
				connection.Open();
				cmd.Connection = connection;
				cmd.CommandText = "SELECT MAX(HoaDonId) FROM HoaDon";

				var result = cmd.ExecuteScalar();

				if (result != DBNull.Value)
				{
					return (int)result;
				}
				return 1;
			}
		}

		public bool AddHoaDon(HoaDonModel obj)
		{
			try
			{
				using (var connection = new SqlConnection(this.connectionString))
				using (var cmd = connection.CreateCommand())
				{
					connection.Open();
					cmd.Connection = connection;

					cmd.CommandText = "SET IDENTITY_INSERT HoaDon ON " +
						"insert into HoaDon (HoaDonId, NhanVienId, KhachHangId, PggId, NgayNhap, PhiTruocGiamGia, GiamGia, PhiSauGiamGia) " +
									  "VALUES (@HoaDonId,@NhanVienId, @KhachHangId, @PggId, @NgayNhap, @PhiTruocGiamGia,@GiamGia, @PhiSauGiamGia) " +
									  "SET IDENTITY_INSERT HoaDon OFF";

					cmd.Parameters.AddWithValue("@HoaDonId", obj.HoaDonId);
					cmd.Parameters.AddWithValue("@NhanVienId", obj.NhanVienId);
					cmd.Parameters.AddWithValue("@KhachHangId", obj.KhachHangId);
					cmd.Parameters.AddWithValue("@PggId", (obj.PggId ==0) ? DBNull.Value : obj.PggId);
					cmd.Parameters.AddWithValue("@NgayNhap", obj.NgayNhap.ToString("yyyy-MM-dd"));
					cmd.Parameters.AddWithValue("@PhiTruocGiamGia", obj.PhiTruocGiamGia);
					cmd.Parameters.AddWithValue("@GiamGia", obj.GiamGia);
					cmd.Parameters.AddWithValue("@PhiSauGiamGia", obj.PhiSauGiamGia);

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

		public bool AddCthd(IEnumerable<ChiTietHoaDonModel> objs)
		{
			try
			{
				using (var connection = new SqlConnection(this.connectionString))
				using (var cmd = connection.CreateCommand())
				{
					connection.Open();
					cmd.Connection = connection;

					cmd.CommandText = "insert into ChiTietHoaDon (HoaDonId, CaPheId, SoLuong, DonGia)" +
						"VALUES (@HoaDonId, @CaPheId, @SoLuong,@DonGia)";

					foreach (ChiTietHoaDonModel cthdModelTemp in objs)
					{
						cmd.Parameters.Clear();
						cmd.Parameters.AddWithValue("@HoaDonId", cthdModelTemp.CT_HoaDonId);
						cmd.Parameters.AddWithValue("@CaPheId", cthdModelTemp.CT_CaPheId);
						cmd.Parameters.AddWithValue("@SoLuong", cthdModelTemp.CT_SoLuong);
						cmd.Parameters.AddWithValue("@DonGia", cthdModelTemp.CT_DonGia);


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

		public IEnumerable<HoaDonModel> GetAllHoaDon(int idKhachHang)
		{
			var cpList = new List<HoaDonModel>();
			using (var connection = new SqlConnection(this.connectionString))
			using (var cmd = connection.CreateCommand())
			{
				connection.Open();
				cmd.Connection = connection;
				cmd.CommandText = "select * from HoaDon where KhachHangId = @Id";
				cmd.Parameters.AddWithValue("@Id", idKhachHang);
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
	}
}
