using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
	public class KhachHangModel
	{
		public int Id { get; set; }
		public string Name { get ; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int IdTypeOfCustomer { get; set; }        
        public DateTime TimeCreateAccount { get; set; }
        public string Account {  get; set; }
        public string Password { get; set; }
        public bool IsDelete { get; set; }

    }
}
