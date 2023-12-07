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
		// events
		event EventHandler AddBtnEvent;
		event EventHandler EditBtnEvent;
		event EventHandler AcceptBtnEvent;
		event EventHandler SearchTxtEvent;
		event EventHandler DeleteBtnEvent;
		event EventHandler AddNlBtnEvent;
		event EventHandler EditNlBtnEvent;
		event EventHandler DeleteNlBtnEvent;

		// properties
	
		string CapheId { get; set; }
		string MieuTaTxt { get; set; }
		string GiaTienTxt { get; set; }
		string TenTxt { get; set; }
		string XuatXuTxt { get; set; }
		bool IsDeleted { get; set; }
		string SearchValue { get; set; }
		DataGridView CaPheDg { get; set; }
		Image CaPheImage { get; set; }
		ComboBox NguyenLieuCbx { get; set; }
		string KhoiLuongTxt { get; set; }
		DataGridView CpnlList2 { get; set; }



		bool IsEdited { get; set; }

		// methods
		void LoadData(BindingSource list);
		void LoadNguyenLieuCbx(BindingSource list);
		void LoadCpnlList(BindingSource list);
	}
}
