using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
	public class BanHangPresenter
	{
		private IBanHangView view;
		private IBanHangRepository repository;
		private BindingSource cpBindingSource;
		private IEnumerable<CaPheModel> cpList;

		private BindingSource cpnlBindingSource;
		private IEnumerable<CaPheNguyenLieuModel> cpnlList;

		public BanHangPresenter(IBanHangView view, IBanHangRepository repository)
		{
			this.view = view;
			this.repository = repository;
			cpBindingSource = new BindingSource();
			cpnlBindingSource = new BindingSource();
		}
	}
}
