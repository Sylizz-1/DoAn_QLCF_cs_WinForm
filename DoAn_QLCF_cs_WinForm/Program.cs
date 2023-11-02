using DoAn_QLCF_cs_WinForm.View;
using System.Configuration;

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
			Application.Run(new MainView());
		}
	}
}