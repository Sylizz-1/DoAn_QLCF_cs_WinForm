using DoAn_QLCF_cs_WinForm.CustomUserControl;
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
			datHangBtn.Click += delegate { DatHangBtnEvent?.Invoke(this, EventArgs.Empty); };
		}
		public FlowLayoutPanel GioHangPanel { get => gioHangPanel; set => gioHangPanel = value; }
		public FlowLayoutPanel SanPhamPanel { get => sanPhamPanel; set => sanPhamPanel = value; }

		public KhachHangModel KhModel { get; set; }
		public int GiamGiaLoaiKh
		{
			get
			{
				string gg = this.loaiKhTxt.Text.Split("%")[0];
				return int.Parse(gg);
			}
			set
			{
				int gg = value;
				string ggStr = gg.ToString() + "%";
				this.loaiKhTxt.Text = ggStr;
			}
		}
		public DataGridView PggDg { get => pggDg; set => pggDg = value; }
		public float GiaGocTxt { get => float.Parse(this.giaGocTxt.Text) ; set => this.giaGocTxt.Text = value.ToString(); }

		public event EventHandler DatHangBtnEvent;

		private void SetUpView()
		{
			// setup Tabcontrol
			tabControl1.Appearance = TabAppearance.FlatButtons;
			tabControl1.ItemSize = new System.Drawing.Size(0, 1);
			tabControl1.SizeMode = TabSizeMode.Fixed;
		}

		public void UpdateGia()
		{
			float sum = 0;
			foreach(ChiTietHoaDonUC cthdUc in this.gioHangPanel.Controls)
			{
				sum += cthdUc.donGia;
			} 
			this.giaGocTxt.Text = sum.ToString();
		}

		private void pggBtn_Click(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab = pggTab;
		}

		private void returnBtn_Click(object sender, EventArgs e)
		{
			this.tabControl1.SelectedTab = trangChuTab;
		}
	}
}
