using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Presenter;
using DoAn_QLCF_cs_WinForm.Repository;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn_QLCF_cs_WinForm
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;

            ILoginView loginView = new LogInView();
            ILoginRepository loginRepository = new LoginRepository(connectionString);
            new LoginPresenter(loginView, loginRepository);
            Application.Run((Form)loginView);

            //IHoaDonView view = new HoaDonView();
            //IHoaDonRepository repo = new HoaDonRepository(connectionString);
            //new HoaDonPresenter(view, repo);
            //Application.Run((Form)view);

            //INhanVienView view = new NhanVienView();
            //INhanVienRepository repo = new NhanVienRepository(connectionString);
            //new NhanVienPresenter(view, repo);
            //Application.Run((Form)view);

            //IPhanQuyenView view = new PhanQuyenView();
            //IPhanQuyenRepository repo = new PhanQuyenRepository(connectionString);
            //new PhanQuyenPresenter(view, repo);
            //Application.Run((Form)view);

            //IBanHangView banHangView = new BanHangView();
            //IBanHangRepository banHangRepository = new BanHangRepository(connectionString);
            //new BanHangPresenter(banHangView, banHangRepository);
            //Application.Run((Form)banHangView);

        }
    }
}