using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
    public class NccModel
    {

        [DisplayName("ID")]
        public int NhaCungCapId { get; set; }

        [DisplayName("Tên")]
        public string TenNhaCungCap { get; set; }

        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }

        [DisplayName("Số điện thoại")]
        public string SDT { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("IsDelete")]
        public bool IsDelete { get; set; }
    }
}
