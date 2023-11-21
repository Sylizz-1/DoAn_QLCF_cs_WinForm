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
	public class CaPheRepository : BaseRepository, ICaPheRepository
	{
		private string caPheImagePath;
		public CaPheRepository(string connectionString) {
			this.connectionString = connectionString;
			string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			var logoimage = Path.Combine(path, "image\\caPhe");
			caPheImagePath = logoimage;
		}

		public void Add(CaPheModel obj)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
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
				cmd.CommandText = "select * from CaPhe order by CaPheId desc";
				using(var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						var cpModel = new CaPheModel();
						cpModel.Id = (int)reader["CaPheId"];
						cpModel.Ten = reader["TenCaPhe"].ToString();
						cpModel.Gia = Convert.ToSingle(reader["Gia"]) ;
						cpModel.MieuTa = reader["MieuTa"].ToString();
						cpModel.XuatXu = reader["XuatXu"].ToString();
						string imgPath = Path.Combine(this.caPheImagePath, reader["HinhAnh"].ToString());
						cpModel.HinhAnh = Image.FromFile(imgPath) ?? null;
						cpModel.IsDelete = (bool)reader["IsDeleted"];

						cpList.Add(cpModel);
					}
				}

				return cpList;
			}
		}

		public CaPheModel GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<CaPheModel> GetByValue(string value)
		{
			throw new NotImplementedException();
		}

		public bool IsExit(int id)
		{
			throw new NotImplementedException();
		}

		public void Update(CaPheModel obj)
		{
			throw new NotImplementedException();
		}
	}
}
