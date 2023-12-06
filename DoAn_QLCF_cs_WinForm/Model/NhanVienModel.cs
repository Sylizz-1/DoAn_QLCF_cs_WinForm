using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
	public class NhanVienModel
	{
        private ArrayList arrAction = new ArrayList();
        public ArrayList ArrAction { get => arrAction; set => arrAction = value; }
        
       
        [DisplayName("IDNV")]
        public int Id { get; set; }

        [DisplayName("Tài Khoản")]
        public string Taikhoan { get; set; }

        [DisplayName("Mật khẩu")]
        public string Matkhau { get; set; }

        [DisplayName("ID Quyền")]
        public int IdPermission { get; set; }

        [DisplayName("Họ Tên")]
        public string Name { get; set; }

        [DisplayName("Giới Tính")]
        public string Gioitinh { get; set; }

        [DisplayName("Số Điện Thoại")]
        public string Sdt { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Ngày Sinh")]
        public string Ngaysinh { get; set; }

        [DisplayName("IsDelete")]
        public bool isDelete { get; set; }

    }
}
