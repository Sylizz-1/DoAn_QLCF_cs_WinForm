using DoAn_QLCF_cs_WinForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
	public interface INhanVienView
	{
        event EventHandler AddBtnEvent;
        event EventHandler EditBtnEvent;
        event EventHandler DeleteBtnEvent;
        event EventHandler AcceptBtnEvent;
        event EventHandler CancelBtnEvent;

        string IdNhanVien{ get; set; }
        string NameNhanVien { get; set; }
        string Email { get; set; }

        string PhoneNumber { get; set; }
        string GioiTinh { get; set; }
        string NgaySinh { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string PasswordConfirm { get; set; }
        bool IsDeleted { get; set; }
        int Permission { get; set; }

        DataGridView DataGridView { get; set; }

        void LoadData(BindingSource list);
        void LoadQuyen(BindingSource listQuyen);        
        void ShowMessage(string message);
    }
}
