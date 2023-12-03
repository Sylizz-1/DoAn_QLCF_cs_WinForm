using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
	public interface ICaPheRepository
	{
		bool Add(CaPheModel obj);
		bool Update(CaPheModel obj);
		bool Delete(int id);
		IEnumerable<CaPheModel> GetAll();

		IEnumerable<CaPheModel> GetByValue(string value);

		CaPheModel GetById(int id);
		bool IsExit(int id);

		int GetLastId();

		IEnumerable<CaPheNguyenLieuModel> GetNguyenLieuOfCaPhe(int caPheId);

		bool UpdateChiTietNguyenLieu(int caPheId, IEnumerable<CaPheNguyenLieuModel> cpnlList);

		public IEnumerable<NguyenLieuModel> GetAllNguyenLieu();
	}
}
