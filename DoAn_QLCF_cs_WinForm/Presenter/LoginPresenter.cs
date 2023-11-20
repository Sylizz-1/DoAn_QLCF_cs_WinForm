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
        }

        private void Login(object sender, EventArgs e)
        {
            NhanVienModel nhanVien = repository.Login(this.view.UserName, this.view.Password);            
            if(nhanVien != null)
            {
                this.view.IsSuccess();
                string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
                IMainView mainView = new MainView(connectionString, nhanVien);                                
                mainView.Show();                
            }
            else
            {
                this.view.IsFailure();
            }
        }
    }
}
