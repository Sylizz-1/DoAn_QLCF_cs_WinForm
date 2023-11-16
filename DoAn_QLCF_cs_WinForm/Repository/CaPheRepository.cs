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
			throw new NotImplementedException();
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
