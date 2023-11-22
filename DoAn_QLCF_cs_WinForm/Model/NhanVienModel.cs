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
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Họ Tên")]
        public string Ten { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Số Điện Thoại")]
        public string Sdt { get; set; }
        [DisplayName("Ngày Sinh")]
        public DateTime Ngaysinh { get; set; }
        [DisplayName("Giới Tính")]
        public string Gioitinh { get; set; }
        [DisplayName("Tài Khoản")]
        public string Taikhoan { get; set; }
        [DisplayName("Mật khẩu")]
        public string Matkhau { get; set; }
        [DisplayName("Quyền")]
        public string Quyen {  get; set; }
        [DisplayName("IsDelete")]
        public bool isDelete { get; set; }

    }
}
