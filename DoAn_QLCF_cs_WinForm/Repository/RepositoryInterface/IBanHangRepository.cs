﻿using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
	public interface IBanHangRepository
	{
		IEnumerable<CaPheModel> GetAllCaPhe();
		int GetGiamGiaLoaiKh(int id);
		IEnumerable<PggModel> GetAllPgg();
		int GetLastId();

		bool AddHoaDon(HoaDonModel obj);
		bool AddCthd(IEnumerable<ChiTietHoaDonModel>  objs);
		 IEnumerable<HoaDonModel> GetAllHoaDon(int idKhachHang);
	}
}
