using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository
{
	public class CaPheRepository : BaseRepository, ICaPheRepository
	{
		public CaPheRepository(string connectionString) {
			this.connectionString = connectionString;
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
			List<CaPheModel> danhSachCaphe = new List<CaPheModel>
			{
				// Thêm các đối tượng vào danh sách
				new CaPheModel { Id = 1, Name = "Cà phê đen" },
				new CaPheModel { Id = 2, Name = "Cappuccino" },
				new CaPheModel { Id = 3, Name = "Espresso" }
			};

			return danhSachCaphe;
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
