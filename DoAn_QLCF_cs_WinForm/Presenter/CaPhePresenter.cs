using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
	public class CaPhePresenter
	{
		private ICaPheView view;
		private ICaPheRepository repository;
		private BindingSource cpBindingSource;
		private List<CaPheModel> caPheList;


		public CaPhePresenter(ICaPheView view, ICaPheRepository repository)
		{
			this.view = view;
			this.repository = repository;
			cpBindingSource = new BindingSource();
			/*LoadCaPheList();*/
		}

		private void LoadCaPheList ()
		{
			caPheList = repository.GetAll();
			cpBindingSource.DataSource = caPheList;
			view.CaPheList = (IList<CaPheModel>)cpBindingSource;
		}
	}
}
