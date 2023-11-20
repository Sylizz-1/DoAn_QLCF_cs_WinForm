using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
    public interface ILoginView
    {
        string UserName { get; set; }
        string Password { get; set; }

        //Events
        event EventHandler LoginEvent;

        void IsSuccess();
        void IsFailure();
    }
}
