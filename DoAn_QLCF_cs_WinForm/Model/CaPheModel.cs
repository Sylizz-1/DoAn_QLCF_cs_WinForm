using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
	public class CaPheModel
	{

		[DisplayName("ID")]
		public int Id { get ; set ; }

		[DisplayName("Hình Ảnh")]
		public Image HinhAnh { get; set; }

		[DisplayName("Tên")]
		public string Ten { get; set; }

		[DisplayName("Giá")]
		public float Gia { get; set; }

		[DisplayName("Miêu Tả")]
		public string MieuTa { get; set; }

		[DisplayName("Xuất Xứ")]
		public string XuatXu { get; set; }

		

		[DisplayName("IsDelete")]
		public bool IsDelete { get; set; }
	}
}
