using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
	public class NhanVienModel
	{
		private int id;
		private string name;
		private int idPermission;
        private ArrayList arrAction = new ArrayList();
        
        public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
        public int IdPermission { get => idPermission; set => idPermission = value; }
        public ArrayList ArrAction { get => arrAction; set => arrAction = value; }
    }
}
