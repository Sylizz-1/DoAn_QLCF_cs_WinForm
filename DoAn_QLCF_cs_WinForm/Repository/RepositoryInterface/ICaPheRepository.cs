using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
	public interface ICaPheRepository
	{
		void Add(CaPheModel obj);
		void Update(CaPheModel obj);
		void Delete(int id);
		List<CaPheModel> GetAll();

		List<CaPheModel> GetByValue(string value);

		CaPheModel GetById(int id);
		bool IsExit(int id);
	}
}
