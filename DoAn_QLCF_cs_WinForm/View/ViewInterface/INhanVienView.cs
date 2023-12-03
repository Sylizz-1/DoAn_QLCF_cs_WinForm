using DoAn_QLCF_cs_WinForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
	public interface INhanVienView
	{
        NhanVienPresenter Presenter { get; set; }
        void LoadData(BindingSource list);
        void GetIdNhanVien(int id);
        void GetQuyenNhanVien(List<string> quyenList);
    }
}
