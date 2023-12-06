using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
    public class ChiTietHoaDonModel
    {

        [DisplayName("ID Hoá đơn")]
        public int CT_HoaDonId { get; set; }

        [DisplayName("ID Cà phê")]
        public int CT_CaPheId { get; set; }

        [DisplayName("Tên cà phê")]
        public string CT_TenCaPhe { get; set; }

        [DisplayName("Số lượng")]
        public int CT_SoLuong { get; set; }

        [DisplayName("Đơn giá")]
        public float CT_DonGia { get; set; }
    }
}
