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
        private string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;

        public LoginPresenter(ILoginView view, ILoginRepository repository)
        {
            this.view = view;
            this.repository = repository;

            this.view.LoginEvent += Login;
            this.view.RegisterEvent += Register;
            this.view.CheckInputInformation += CheckInputInformation;
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
                this.view.ShowMessage("Vui lòng chọn vai trò!");
                return false;
            }
            return true;
        }

        private void Login(object sender, EventArgs e)
        {
            if (validateInputLogin())
            {
                if (this.view.Role == "employee")
                {
                    NhanVienModel nhanVien = repository.LoginEmployee(this.view.UserName, this.view.Password);
                    if (nhanVien != null)
                    {
                        IMainView mainView = new MainView(connectionString, nhanVien);
                        mainView.Show();
                        this.view.ShowMessage("Đăng nhập nhân viên thành công!");
                    }
                    else
                    {
                        this.view.LoginFailure();
                    }
                }
                else if (this.view.Role == "customer")
                {
                    KhachHangModel khachHang = repository.LoginCustomer(this.view.UserName, this.view.Password);
                    if (khachHang != null)
                    {
                        this.view.ShowMessage("Đăng nhập khách hàng thành công!");
                    }
                    else
                    {
                        this.view.LoginFailure();
                    }
                }
            }

        }

        private void CheckInputInformation(object sender, EventArgs e)
        {
            
        }

        private void Register(object sender, EventArgs e)
        {
            if (repository.Register(this.view.RegisterUserName, this.view.RegisterPassword))
            {
                this.view.ShowMessage("Đăng kí thành công!");
            }
            else
            {
                this.view.ShowMessage("Đăng kí thất bại!");
            }
        }
    }
}
