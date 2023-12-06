using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
	public class HoaDonModel
	{
        [DisplayName("ID Hoá đơn")]
        public int HoaDonId { get; set; }

        [DisplayName("ID Nhân viên")]
        public int NhanVienId { get; set; }

        [DisplayName("ID Khách hàng")]
        public int KhachHangId { get; set; }

        [DisplayName("ID Phiếu giảm giá")]

        public int PggId { get; set; }


        [DisplayName("Ngày bán")]

        public DateTime NgayNhap { get; set; }


        [DisplayName("Đơn giá")]

        public float PhiTruocGiamGia { get; set; }


        [DisplayName("Phần trăm giảm giá")]

        public byte GiamGia { get; set; }

        [DisplayName("Thành tiền")]

        public float PhiSauGiamGia { get; set; }

        [DisplayName("Đã thanh toán")]
        public bool IsAccepted { get; set; }

    }
}
