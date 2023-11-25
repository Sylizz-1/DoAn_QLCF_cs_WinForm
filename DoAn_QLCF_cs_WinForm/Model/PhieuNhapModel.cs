using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
    public class PhieuNhapModel
    {

        [DisplayName("Phiếu Nhập ID")]
        public int PhieuNhapId { get; set; }

        [DisplayName("Nhân Viên ID")]
        public int NhanVienId { get; set; }

        [DisplayName("Nhà Cung Cấp ID")]
        public int NhaCungCapId { get; set; }

        [DisplayName("Ngày Nhập")]
        public DateTime NgayNhap { get; set; }

        [DisplayName("Tổng Tiền")]
        public float TongTien { get; set; }
    }
}
