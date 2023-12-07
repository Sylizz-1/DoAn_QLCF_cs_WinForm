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
	public partial class ChiTietHoaDonUC : UserControl
	{
		public IBanHangView parent {  get; set; }
		public CaPheModel cpModel { get; set; }
		public int soLuong { get => int.Parse(this.soLuongLbl.Text); set => this.soLuongLbl.Text = value.ToString(); }
		public float donGia
		{
			get
			{
				return this.cpModel.Gia * this.soLuong;
			}
		}

		public ChiTietHoaDonUC()
		{
			InitializeComponent();
			this.Width = 475;
		}

		public void SetData(CaPheModel cpModel)
		{
			this.cpModel = cpModel;
			this.hinhAnhPbx.Image = cpModel.HinhAnh;
			this.tenLbl.Text = cpModel.Ten;
			this.giaTienLbl.Text = cpModel.Gia.ToString();
		}

		public void SetParentView(IBanHangView parent)
		{
			this.parent = parent;
		}

		private void xoaBtn_Click(object sender, EventArgs e)
		{
			this.Parent?.Controls.Remove(this);
			parent.UpdateGia();
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			int num = int.Parse(this.soLuongLbl.Text);
			++num;
			this.soLuongLbl.Text = num.ToString();
			parent.UpdateGia();
		}

		private void soLuongLbl_TextChanged(object sender, EventArgs e)
		{

		}

		private void minusBtn_Click(object sender, EventArgs e)
		{
			int num = int.Parse(this.soLuongLbl.Text);
			if (num == 1)
				return;
			--num;
			this.soLuongLbl.Text = num.ToString();
			parent.UpdateGia();
		}
	}
}
