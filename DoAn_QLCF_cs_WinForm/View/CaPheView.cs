using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.View
{
	public partial class CaPheView : Form, ICaPheView
	{
		public CaPheView()
		{
			InitializeComponent();

		}

		private static CaPheView instance;
		public IList<CaPheModel> CaPheList
		{
			get => (IList<CaPheModel>)this.dataGridView1.DataSource;
			set => this.dataGridView1.DataSource = value;
		}
		public int SelectedCaphe
		{
			get => throw new NotImplementedException();
			set => throw new NotImplementedException();
		}
		public string Message { get; set; }
		public string SearchValue
		{
			get => this.searchTxt.Text;
			set => this.searchTxt.Text = value;
		}

		public static CaPheView GetInstance(Form parentContainer)
		{
			if (instance == null || instance.IsDisposed)
			{
				instance = new CaPheView();
				instance.MdiParent = parentContainer;
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
