using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
    public interface INguyenLieuRepository
    {
        bool Add(NguyenLieuModel obj);
        bool Update(NguyenLieuModel obj);
        bool Delete(int id);
        int GetNextId();
        IEnumerable<NguyenLieuModel> GetAll();

        IEnumerable<NguyenLieuModel> GetByValue(string NguyenLieuId, string TenNguyenLieu, string ThongTin, string KhoiLuong, string GiaTien_Kg, string HinhAnh, bool? isDelete);

        NguyenLieuModel GetById(int id);
        bool IsExit(int id);
    }
}
