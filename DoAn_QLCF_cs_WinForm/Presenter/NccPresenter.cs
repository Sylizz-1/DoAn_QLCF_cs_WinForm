using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
    public class NccPresenter
    {
        private INccView view;
        private INccRepository repository;
        private BindingSource cpBindingSource;
        private IEnumerable<NccModel> nccList;

		public NccPresenter(INccView view, INccViewRepository repo)
		{
			this.view = view;
			this.repo = repo;
		}
	}
}
