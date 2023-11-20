using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.View
{
	public partial class PhanQuyenView : Form, IPhanQuyenView
	{
		public PhanQuyenView()
		{
			InitializeComponent();
		}

		private static PhanQuyenView instance;
		public static IPhanQuyenView GetInstance(Form parentContainer)
		{

			if (instance == null || instance.IsDisposed)
			{
				instance = new PhanQuyenView();
				instance.TopLevel = false;
				parentContainer.Controls.Add(instance);
				instance.Dock = DockStyle.Fill;
			}
			else
			{
				if (instance.WindowState == FormWindowState.Minimized)
					instance.WindowState = FormWindowState.Normal;

			}
			instance.Show();
			return instance;
		}
	}
}
