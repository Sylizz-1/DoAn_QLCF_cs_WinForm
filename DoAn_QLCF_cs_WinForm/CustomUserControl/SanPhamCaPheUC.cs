using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.View;
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

namespace DoAn_QLCF_cs_WinForm.CustomUserControl
{
	public partial class SanPhamCaPheUC : UserControl
	{
		public IBanHangView parent { get; set; }
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

		public void SetParentView(IBanHangView parent)
		{
			this.parent = parent;
		}

		private void addToCartBtn_Click(object sender, EventArgs e)
		{
			foreach(ChiTietHoaDonUC cthdUcTemp in this.parent.GioHangPanel.Controls)
			{
				if (cthdUcTemp.cpModel.Id == this.cpModel.Id)
				{
					MessageBox.Show("Sản phẩm đã thêm vào giỏ hàng!!!");
					return;
				}
			}

			ChiTietHoaDonUC cthdUc = new ChiTietHoaDonUC();
			cthdUc.SetData(this.cpModel);
			cthdUc.SetParentView(this.parent);
			this.parent.GioHangPanel.Controls.Add(cthdUc);
			parent.UpdateGia();
		}
	}
}
