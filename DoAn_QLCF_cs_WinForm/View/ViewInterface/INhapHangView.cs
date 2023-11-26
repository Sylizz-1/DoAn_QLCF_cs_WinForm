using DoAn_QLCF_cs_WinForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
    public interface INhapHangView
    {
        NhapHangPresenter Presenter { get; set; }
        void LoadDataPN(BindingSource list);
        void LoadDataCTPN(BindingSource list);
        void LoadDataNV(BindingSource list);
        void LoadDataNCC(BindingSource list);
        void GetIdPNAdd(int id);
    }
}
