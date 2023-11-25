
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
	public partial class KhachHangView : Form, IKhachHangView
	{
		public KhachHangView()
		{
			InitializeComponent();
			SetUpView();
		}

		private static KhachHangView instance;
		public static IKhachHangView GetInstance(Form parentContainer)
		{
			if (instance == null || instance.IsDisposed)
			{
				instance = new KhachHangView();
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

		private void SetUpView()
		{
			tabControl1.Appearance = TabAppearance.FlatButtons;
			tabControl1.ItemSize = new System.Drawing.Size(0, 1);
			tabControl1.SizeMode = TabSizeMode.Fixed;
		}

        public void LoadData(BindingSource list)
        {
            this.dataGridView1.DataSource = list;
        }
    }
}
