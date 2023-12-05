using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
    public interface IChiTietPhieuNhapRepository
    {
        bool Add(ChiTietPhieuNhapModel obj);
        bool Update(ChiTietPhieuNhapModel obj);
        bool Delete(int id);
        int GetMaxId();
        IEnumerable<ChiTietPhieuNhapModel> GetAll();

        List<ChiTietPhieuNhapModel> GetByValue(string pnId, string nglId, string klg, string dg);

        List<ChiTietPhieuNhapModel> GetById(int id);
        ChiTietPhieuNhapModel GetByIdNgl(int id);
        bool IsExit(int id);
    }
}
