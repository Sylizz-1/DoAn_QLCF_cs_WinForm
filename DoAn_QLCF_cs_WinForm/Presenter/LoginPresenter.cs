using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
    public class LoginPresenter
    {
        private ILoginView view;
        private ILoginRepository repository;

        public LoginPresenter(ILoginView view, ILoginRepository repository)
        {
            this.view = view;
            this.repository = repository;

            this.view.LoginEvent += Login;
            this.view.RegisterEvent += Register;
        }

        private bool validateInputLogin()
        {
            if (this.view.UserName == "")
            {
                this.view.IsEmptyUsername();
                return false;
            }
            else if (this.view.Password == "")
            {
                this.view.IsEmptyPassword();
                return false;
            }
            else if (this.view.Role == null)
            {
                this.view.IsEmptyRole();
                return false;
            }
            return true;
        }

        private void Login(object sender, EventArgs e)
        {
            if (validateInputLogin())
            {
                if(this.view.Role == "employee")
                {
                    NhanVienModel nhanVien = repository.LoginEmployee(this.view.UserName, this.view.Password);
                    if (nhanVien != null)
                    {                        
                        IMainView mainView = new MainView(connectionString, nhanVien);
                        mainView.Show();
                        this.view.IsSuccess();
                    }
                    else
                    {
                        this.view.IsFailure();
                    }
                }
                else if(this.view.Role == "customer")
                {
                    KhachHangModel khachHang = repository.LoginCustomer(this.view.UserName, this.view.Password);
                    if (khachHang != null)
                    {
                        this.view.IsSuccess();
                    }
                    else
                    {
                        this.view.IsFailure();
                    }
                }                                
            }

        }

        private void Register(object sender, EventArgs e)
        {            
            if (repository.Register(this.view.RegisterUserName, this.view.RegisterPassword))
            {
                this.view.RegisterSuccess();
            }
            else
            {
                this.view.RegisterFailure();
            }
        }
    }
}
