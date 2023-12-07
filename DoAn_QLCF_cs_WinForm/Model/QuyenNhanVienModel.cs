using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
    public class QuyenNhanVienModel
    {
        [DisplayName("ID Nhân Viên")]
        public int IdEmployee{ get; set; }

        [DisplayName("Tên Nhân Viên")]
        public string NameEmployee { get; set; }

        [DisplayName("ID Quyền")]
        public int IdPermission { get; set; }

        [DisplayName("Tên Quyền")]
        public string NamePermission { get; set; }
    }
}
