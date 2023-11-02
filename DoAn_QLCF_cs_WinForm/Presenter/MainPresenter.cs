using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
	public class MainPresenter
	{
		private IMainView mainView;
		private readonly string sqlConnectionString;

		public MainPresenter(IMainView mainView, string sqlConnectionString)
		{
			this.mainView = mainView;
			this.sqlConnectionString = sqlConnectionString;
		}
	}
}
