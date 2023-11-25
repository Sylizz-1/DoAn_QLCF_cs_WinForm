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
        void LoadData(BindingSource list);
        void GetIdNccAdd(int id);
    }
}
