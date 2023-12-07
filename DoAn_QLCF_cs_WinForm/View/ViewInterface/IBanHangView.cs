using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
	public interface IBanHangView
	{
		KhachHangModel KhModel { get; set; }
		public FlowLayoutPanel GioHangPanel { get; set; }
		public FlowLayoutPanel SanPhamPanel { get; set ; }
		public int GiamGiaLoaiKh {  get; set; }
		public DataGridView PggDg { get; set ; }

		public float GiaGocTxt { get; set; }

		event EventHandler DatHangBtnEvent;

		// method
		void UpdateGia();
		
	}
}
