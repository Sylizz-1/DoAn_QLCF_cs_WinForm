using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
    public interface IPhieuNhapRepository
    {
        bool Add(PhieuNhapModel obj);
        bool Update(PhieuNhapModel obj);
        bool Delete(int id);
        int GetNextId();
        IEnumerable<PhieuNhapModel> GetAll();

        IEnumerable<PhieuNhapModel> GetByValue(string pnId, string nvId, string nccId, string nn, string tt);

        PhieuNhapModel GetById(int id);
        bool IsExit(int id);
    }
}
