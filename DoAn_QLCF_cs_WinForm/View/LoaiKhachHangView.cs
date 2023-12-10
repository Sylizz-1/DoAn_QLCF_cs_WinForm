using DoAn_QLCF_cs_WinForm.Presenter;
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
	public partial class LoaiKhachHangView : Form
	{
		LoaiKhachHangPresenter presenter;
		public BindingSource loaiKhBinding {  get; set; }


		public LoaiKhachHangView()
		{
			InitializeComponent();
		}

		private void addBtn_Click(object sender, EventArgs e)
		{

		}
	}
}
