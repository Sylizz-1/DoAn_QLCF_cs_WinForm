using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
	public interface IHoaDonRepository
	{
        public bool Update(HoaDonModel obj);
        public IEnumerable<HoaDonModel> GetAll();
        public IEnumerable<ChiTietHoaDonModel> GetAll_CT();
        public IEnumerable<HoaDonModel> GetByValue(int hoaDonId, int nhanVienId, int khachHangId, int pggId, DateTime? ngayNhap, double phiTruocGiamGia, byte giamGia, double phiSauGiamGia, bool? isAccepted);
        public IEnumerable<ChiTietHoaDonModel> GetByValue_CT(int hoaDonId,  int caPheId, string tenCaPhe, int soLuong, double donGia);
        public HoaDonModel GetById(int id);

        public ChiTietHoaDonModel GetById_CT(int id);
    }
}
