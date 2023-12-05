using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
	public class PggModel
	{
        [DisplayName("ID")]
        public int PggId { get; set; }

        [DisplayName("Thời gian bắt đầu")]

        public DateTime? TgBatDau { get; set; }


        [DisplayName("Thời gian kết thúc")]

        public DateTime? TgKetThuc { get; set; }


        [DisplayName("Giá hoá đơn")]

        public double GiaHoaDon { get; set; }


        [DisplayName("Phần trăm giảm giá")]

        public byte PhanTramGiamGia { get; set; }


        [DisplayName("IsDelete")]
        public bool IsDelete { get; set; }
    }
}
