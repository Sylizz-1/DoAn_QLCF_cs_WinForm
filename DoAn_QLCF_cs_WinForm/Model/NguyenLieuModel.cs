using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
    public class NguyenLieuModel
    {
        [DisplayName("ID")]
        public int NguyenLieuId { get; set; }

        [DisplayName("Tên")]
        public string TenNguyenLieu { get; set; }

        [DisplayName("Thông tin")]
        public string ThongTin { get; set; }

        [DisplayName("Khối lượng")]
        public float KhoiLuong { get; set; }

        [DisplayName("Giá tiền")]
        public float GiaTien_Kg { get; set; }

        [DisplayName("Hình ảnh")]
        public string HinhAnh { get; set; }

        [DisplayName("IsDelete")]
        public bool IsDelete { get; set; }
    }
}
