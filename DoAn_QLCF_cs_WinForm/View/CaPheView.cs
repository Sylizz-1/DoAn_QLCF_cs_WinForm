using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Presenter;
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
		private CaPhePresenter presenter;

		public CaPheView()
		{
			InitializeComponent();
			/*this.tabControl1.TabPages.Remove(DetailsTabPage);*/
		}

		private static CaPheView instance;
		public string Message { get; set; }
		public string SearchValue
		{
			get => this.searchTxt.Text;
			set => this.searchTxt.Text = value;
		}
		public CaPhePresenter Presenter { set => this.presenter = value; }
		public string CapheId { get => this.idTxt.Texts; set => this.idTxt.Texts = value; }


		// UI Code
		public void LoadData(BindingSource list)
		{
			this.dataGridView1.DataSource = list;
		}

		public static CaPheView GetInstance(Form parentContainer)
		{
			if (instance == null || instance.IsDisposed)
			{
				instance = new CaPheView();
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

		private void caPhePic_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "image files|*.jpg;*.png;*.gif";
			DialogResult dr = ofd.ShowDialog();

			if (dr == DialogResult.Cancel)
				return;

			caPhePic.Image = Image.FromFile(ofd.FileName);
			caPhePic.Text = ofd.FileName;
		}


		// Presenter


		private void addBtn_Click(object sender, EventArgs e)
		{
			presenter.Add();
		}

		
	}
}
