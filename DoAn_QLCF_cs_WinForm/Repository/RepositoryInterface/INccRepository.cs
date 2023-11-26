using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
    public interface INccRepository
    {
        bool Add(NccModel obj);
        bool Update(NccModel obj);
        bool Delete(int id);
        int GetNextId();
        IEnumerable<NccModel> GetAll();

        IEnumerable<NccModel> GetByValue(string nhaCungCapId, string tenNhaCungCap, string diaChi, string sdt, string email, bool? isDelete);

        NccModel GetById(int id);
        bool IsExit(int id);
    }
}
