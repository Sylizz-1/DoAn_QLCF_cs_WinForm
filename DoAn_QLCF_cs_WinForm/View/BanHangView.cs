using DoAn_QLCF_cs_WinForm.Model;
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
	public partial class BanHangView : Form, IBanHangView
	{
		public BanHangView()
		{
			InitializeComponent();
			SetUpView();
		}

		public KhachHangModel KhModel { get; set; }


		private void SetUpView()
		{
			// setup Tabcontrol
			tabControl1.Appearance = TabAppearance.FlatButtons;
			tabControl1.ItemSize = new System.Drawing.Size(0, 1);
			tabControl1.SizeMode = TabSizeMode.Fixed;
		}
	}
}
