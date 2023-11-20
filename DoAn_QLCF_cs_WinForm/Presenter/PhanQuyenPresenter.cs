using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
	public class PhanQuyenPresenter
	{
		private IPhanQuyenView view;
		private IPhanQuyenRepository repo;

		public PhanQuyenPresenter(IPhanQuyenView view, IPhanQuyenRepository repo)
		{
			this.view = view;
			this.repo = repo;
		}
	}
}
