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
        string RegisterUserName { get; set; }
        string RegisterPassword { get; set; }

        //Events
        event EventHandler LoginEvent;
        event EventHandler RegisterEvent;

        //method
        void IsSuccess();
        void IsFailure();
        void RegisterSuccess();
        void RegisterFailure();
    }
}
