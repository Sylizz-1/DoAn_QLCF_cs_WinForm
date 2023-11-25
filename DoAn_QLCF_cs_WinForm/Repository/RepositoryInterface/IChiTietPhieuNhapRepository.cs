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
        void Add(ChiTietPhieuNhapModel obj);
        void Update(ChiTietPhieuNhapModel obj);
        void Delete(int id);
        int GetNextId();
        IEnumerable<ChiTietPhieuNhapModel> GetAll();

        IEnumerable<ChiTietPhieuNhapModel> GetByValue(string value);

        ChiTietPhieuNhapModel GetById(int id);
        bool IsExit(int id);
    }
}
