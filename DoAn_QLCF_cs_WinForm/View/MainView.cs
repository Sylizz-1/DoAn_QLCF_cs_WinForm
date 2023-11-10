using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
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
		

		// Interact with Presenter
		public MainPresenter presenter
		{
			private get; set;
		}

		private void btnNhanVien_Click(object sender, EventArgs e)
		{
			ICaPheView view = CaPheView.GetInstance(this);
			ICaPheRepository repo = new CaPheRepository(this.connectionString);
			new CaPhePresenter(view, repo);
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
			sideBar.Width -= 50;
		}


		private void sideExpandTimer_Tick(object sender, EventArgs e)
		{
			if (sideBar.Width == sideBar.MaximumSize.Width)
			{
				sideExpandTimer.Stop();
				isSideBarExpand = true;
			}
			sideBar.Width += 50;
		}

		private void btnMenuSideNav_Click(object sender, EventArgs e)
		{
			if (isSideBarExpand)
			{
				sideMinimizeTimer.Start();
				this.sideNavBtn.Image = (Properties.Resources.navOpenflat);
			}
			else
			{
				sideExpandTimer.Start();
				this.sideNavBtn.Image = (Properties.Resources.navCloseflat);
			}




		}

		private void MainView_SizeChanged(object sender, EventArgs e)
		{
			if (isSideBarExpand && this.Width <= 700)
			{
				sideMinimizeTimer.Start();
			}
		}


		private void navLogOut_MouseEnter(object sender, EventArgs e)
		{
			(sender as Button).Image = (Image)(Properties.Resources.logoutflatwhite);
		}

		private void navLogOut_MouseLeave(object sender, EventArgs e)
		{
			(sender as Button).Image = (Image)(Properties.Resources.logoutflatred2);
		}
	}
}
