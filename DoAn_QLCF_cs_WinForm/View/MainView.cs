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
		// Properties
		private bool isSideBarExpand = true;
		private readonly string connectionString;
		private List<Button> buttonNavList;

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
			LoadButtonNav();
		}

		private void sideMinimizeTimer_Tick(object sender, EventArgs e)
		{
			if (sideBar.Width == sideBar.MinimumSize.Width)
			{
				sideMinimizeTimer.Stop();
				isSideBarExpand = false;
			}
			sideBar.Width -= 40;
		}


		private void sideExpandTimer_Tick(object sender, EventArgs e)
		{
			if (sideBar.Width == sideBar.MaximumSize.Width)
			{
				sideExpandTimer.Stop();
				isSideBarExpand = true;
			}
			sideBar.Width += 40;
		}


		private void btnMenuSideNav_Click(object sender, EventArgs e)
		{
			if (isSideBarExpand)
			{
				sideMinimizeTimer.Start();
				this.sideNavBtn.Image = (Properties.Resources.navOpenflat);
				HideButtonText();
			}
			else
			{
				sideExpandTimer.Start();
				this.sideNavBtn.Image = (Properties.Resources.navCloseflat);
				ShowButtonText();
			}
		}

		private void MainView_SizeChanged(object sender, EventArgs e)
		{
			if (isSideBarExpand && this.Width <= 700)
			{
				this.sideBar.Width = this.sideBar.MinimumSize.Width;
				isSideBarExpand = false;
				this.sideNavBtn.Image = (Properties.Resources.navOpenflat);
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

		private void LoadButtonNav()
		{
			this.buttonNavList = GetButtonsFromPanels(sideBar.Controls.Cast<Control>().ToList());
		}
		// Phương thức đệ quy để lấy danh sách các nút từ các panel
		private List<Button> GetButtonsFromPanels(List<Control> controls)
		{
			List<Button> buttons = new List<Button>();

			foreach (Control control in controls)
			{
				// Nếu control là một Button, thêm nó vào danh sách
				if (control is Button)
				{
					buttons.Add((Button)control);
				}
				// Nếu control là một Panel hoặc một control chứa các control khác, gọi đệ quy
				else if (control.HasChildren)
				{
					buttons.AddRange(GetButtonsFromPanels(control.Controls.Cast<Control>().ToList()));
				}
			}

			return buttons;
		}

		private void HideButtonText()
		{
			foreach (Button btn in buttonNavList)
			{
				btn.Text = "";
			}
		}
		private void ShowButtonText()
		{
			foreach (Button btn in buttonNavList)
			{
				btn.Text = (string)btn.Tag;
			}
		}

		private void ButtonNavClick(object sender, EventArgs e)
		{
			foreach (Button btn in buttonNavList)
			{
				btn.BackColor = Color.Transparent;
			}

			((Button)sender).BackColor = Color.LightSeaGreen;
		}
	}
}
