using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
	public class CaPheNguyenLieuModel
	{
		[DisplayName("ID Cà Phê")]
		public int CaPheId { get; set; }

		[DisplayName("ID Nguyên Liệu")]
		public int NguyenLieuId { get; set; }

		[DisplayName("Hình Ảnh")]
		public Image HinhAnh { get; set; }

		[DisplayName("Tên Nguyên Liệu")]
		public string TenNguyenLieu { get; set; }

		[DisplayName("Khối Lượng")]
		public float KhoiLuong { get; set; }

	}
}
