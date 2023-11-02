using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
	public interface ICaPheView
	{
		IList<CaPheModel> CaPheList { get; set; }
		int SelectedCaphe { get; set; }
		string Message { get; set; }
		string SearchValue { get; set; }


	}
}
