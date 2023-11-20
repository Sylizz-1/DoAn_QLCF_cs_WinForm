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
		private Image anh;
		private int id;
		private string name;

		[DisplayName("ID cà phê")]
		public int Id 
		{ get => id;
			set => id = value; }


		[DisplayName("Tên cà phê")]
		public string Name { get => name; 
			set  {
				name = value;

			}
		}

		[DisplayName("ảnh")]
		public Image Anh { get => anh; set => anh = value; }
	}
}
