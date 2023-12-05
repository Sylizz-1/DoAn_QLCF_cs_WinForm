using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
	public interface IPhanQuyenView
	{
        event EventHandler AddPermissionBtnEvent;
        event EventHandler EditPermissionBtnEvent;
        event EventHandler DeletePermissionBtnEvent;
        event EventHandler DetailPermissionBtnEvent;
        event EventHandler AcceptPermissionBtnEvent;
        event EventHandler CancelPermissionBtnEvent;

        string IdPermission { get; set; }
        string NamePermission { get; set; }
        string ContentPermission { get; set; }
        DataGridView PermissionDataGridView { get; set; }


        void LoadData(BindingSource listPermission, BindingSource listMethod);
        void LoadChucNangListCheckBox(BindingSource listMethod, ArrayList arrMethod);
    }
}
