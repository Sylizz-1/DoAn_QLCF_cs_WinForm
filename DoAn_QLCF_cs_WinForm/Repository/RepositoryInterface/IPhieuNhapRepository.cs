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
        void Add(PhieuNhapModel obj);
        void Update(PhieuNhapModel obj);
        void Delete(int id);
        int GetNextId();
        IEnumerable<PhieuNhapModel> GetAll();

        IEnumerable<PhieuNhapModel> GetByValue(string value);

        PhieuNhapModel GetById(int id);
        bool IsExit(int id);
    }
}
