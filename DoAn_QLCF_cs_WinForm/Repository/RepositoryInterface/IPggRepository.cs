using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
	public interface IPggRepository
	{
        public bool Add(PggModel obj);
        public bool Update(PggModel obj);
        public bool Delete(int id);
        public int GetNextId();
        public IEnumerable<PggModel> GetAll();

        public IEnumerable<PggModel> GetByValue(int pggId, DateTime? tgBatDau, DateTime? tgKetThuc, float giaHoaDon, byte phanTramGiamGia, bool? isDelete);

        public PggModel GetById(int id);
        public bool IsExit(int id);
    }
}
