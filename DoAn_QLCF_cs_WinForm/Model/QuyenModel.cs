using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
    public class QuyenModel
    {
        public QuyenModel() { }
        public QuyenModel(int idPermission, string namePermission, string contentPermission)
        {
            IdPermission = idPermission;
            NamePermission = namePermission;
            ContentPermission = contentPermission;
        }

        [DisplayName("ID Quyền")]
        public int IdPermission { get; set; }

        [DisplayName("Tên Quyền")]
        public string NamePermission { get; set; }

        [DisplayName("Nội Dung Quyền")]
        public string ContentPermission { get; set; }
    }
}
