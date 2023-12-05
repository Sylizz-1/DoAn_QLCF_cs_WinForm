
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
    public class ChucNangModel
    {
        public ChucNangModel(int idMethod, string nameMethod)
        {
            IdMethod = idMethod;
            NameMethod = nameMethod;
        }

        public ChucNangModel()
        {
        }

        [DisplayName("ID Chức Năng")]
        public int IdMethod { get ; set; }
        [DisplayName("Tên Chức Năng")]
        public string NameMethod { get; set; }
    }
}
