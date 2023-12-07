using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.CustomUserControl
{
	public partial class SanPhamCaPheUC : UserControl
	{
		public CaPheModel cpModel { get; set; }
		public SanPhamCaPheUC()
		{
			InitializeComponent();
		}

		public void SetData(CaPheModel cpModel)
		{
			this.cpModel = cpModel;
			this.cpModel = cpModel;
			this.hinhAnhPbx.Image = cpModel.HinhAnh;
			this.tenLbl.Text = cpModel.Ten;
			this.giaTienLbl.Text = cpModel.Gia.ToString();
		}

	}
}
