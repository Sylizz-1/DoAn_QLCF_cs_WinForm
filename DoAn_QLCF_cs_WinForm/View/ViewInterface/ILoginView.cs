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
        string Role { get; }
        string RegisterUserName { get; set; }
        string RegisterPassword { get; set; }
        string RegisterPasswordConfirm { get; }
        string RegisterName { get; }
        string RegisterPhoneNumber { get; }
        string RegisterEmail { get; }
        string RegisterBirthday { get; }
        string RegisterSex { get; }
        string RegisterRole { get; }


        //Events
        event EventHandler LoginEvent;
        event EventHandler RegisterEvent;

        //method        
        void ShowMessage(string message);
        void LoginFailure();
        void IsEmptyUsername();
        void IsEmptyPassword();
    }
}
