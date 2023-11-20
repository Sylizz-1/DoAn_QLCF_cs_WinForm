using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
	public class HoaDonPresenter
	{
		private IHoaDonView view;
		private IHoaDonRepository repo;

		public HoaDonPresenter(IHoaDonView view, IHoaDonRepository repo)
		{
			this.view = view;
			this.repo = repo;
		}
	}
}
