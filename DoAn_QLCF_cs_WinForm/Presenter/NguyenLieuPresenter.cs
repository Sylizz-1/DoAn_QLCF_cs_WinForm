using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
	internal class NguyenLieuPresenter
	{
		private INguyenLieuView view;
		private INguyenLieuRepository repo;

		public NguyenLieuPresenter(INguyenLieuView view, INguyenLieuRepository repo)
		{
			this.view = view;
			this.repo = repo;
		}
	}
}
