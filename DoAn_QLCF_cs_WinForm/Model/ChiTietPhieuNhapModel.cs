using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
    public class ChiTietPhieuNhapModel
    {
        [DisplayName("Phiếu Nhập ID")]
        public int PhieuNhapId { get; set; }

        [DisplayName("Nguyên Liệu ID")]
        public int NguyenLieuId { get; set; }

        [DisplayName("Khối Lượng")]
        public float KhoiLuong { get; set; }

        [DisplayName("Đơn Giá")]
        public float DonGia { get; set; }
    }
}
