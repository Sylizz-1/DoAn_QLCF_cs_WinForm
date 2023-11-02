using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_QLCF_cs_WinForm.Presenter;
using DoAn_QLCF_cs_WinForm.Repository;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;

namespace DoAn_QLCF_cs_WinForm.View
{
	public partial class MainView : Form, IMainView
	{
		private bool isSideBarExpand = true;
		private readonly string connectionString;
		// override
		public MainPresenter presenter
		{
			private get; set;
		}

		// UI code
		public MainView(string connectionString)
		{
			InitializeComponent();
			this.connectionString = connectionString;
		}

		private void sideMinimizeTimer_Tick(object sender, EventArgs e)
		{
			if (sideBar.Width == sideBar.MinimumSize.Width)
			{
				sideMinimizeTimer.Stop();
				isSideBarExpand = false;
			}
			sideBar.Width -= 10;
		}


		private void sideExpandTimer_Tick(object sender, EventArgs e)
		{
			if (sideBar.Width == sideBar.MaximumSize.Width)
			{
				sideExpandTimer.Stop();
				isSideBarExpand = true;
			}
			sideBar.Width += 10;
		}

		private void btnMenuSideBar_Click(object sender, EventArgs e)
		{
			if (isSideBarExpand)
			{
				sideMinimizeTimer.Start();
			}
			else
			{
				sideExpandTimer.Start();
			}
		}

		private void MainView_SizeChanged(object sender, EventArgs e)
		{
			if (isSideBarExpand && this.Width <= 700)
			{
				sideMinimizeTimer.Start();
			}
		}

		private void btnNhanVien_Click(object sender, EventArgs e)
		{
			ICaPheView view = CaPheView.GetInstance(this);
			ICaPheRepository repo = new CaPheRepository(this.connectionString);
			new CaPhePresenter(view, repo);
		}
	}
}
