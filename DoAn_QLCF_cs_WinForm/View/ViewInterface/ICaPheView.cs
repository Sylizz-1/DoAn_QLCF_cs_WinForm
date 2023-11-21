using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
	public interface ICaPheView
	{
		CaPhePresenter Presenter { get; set; }
		string Message { get; set; }
		string SearchValue { get; set; }

		string CapheId { get; set; }

		void LoadData(BindingSource list);
	}
}
