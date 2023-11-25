using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
    public interface INguyenLieuView
    {
        NguyenLieuPresenter Presenter { get; set; }
        string Message { get; set; }
        string SearchValue { get; set; }
        string NguyenLieuId { get; set; }
        int selectedId { get; set; }
        void LoadData(BindingSource list);
        void GetIdNguyenLieuAdd(int id);
        NguyenLieuModel AddNguyenLieu();
    }
}
