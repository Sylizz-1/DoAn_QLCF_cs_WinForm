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
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string TenNguyenLieu { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        [DisplayName("Thông tin")]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string ThongTin { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

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
