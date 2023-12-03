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
		private IEnumerable<CaPheModel> caPheList;


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public CaPhePresenter(ICaPheView view, ICaPheRepository repository)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		{
			this.view = view;
			this.repository = repository;
			cpBindingSource = new BindingSource();
			LoadCaPheList();
		}

		private void LoadCaPheList ()
		{
			caPheList = repository.GetAll();
			cpBindingSource.DataSource = caPheList;
			view.LoadData(cpBindingSource);
		}

		public void Add ()
		{

		}
		public void Delete()
		{

		}
		public void Update()
		{

		}
		public void SearchChange()
		{

		}
	
	}
}
