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

        event EventHandler EditPermissionEmployeeBtnEvent;
        event EventHandler DeletePermissionEmployeeBtnEvent;
        event EventHandler AcceptPermissionEmployeeBtnEvent;


        string IdPermission { get; set; }
        string NamePermission { get; set; }
        string ContentPermission { get; set; }
        string IdEmployee { get; set; }
        string NameEmployee { get; set; }
        int ComboboxIdPermission { get; set; }
        DataGridView PermissionDataGridView { get; set; }
        DataGridView PermissionEmployeeDataGridView { get; set; }

        DialogResult ShowYesNoMessage(string message);
        void ShowMessage(string message);
        ArrayList GetArrayMethodChecked();
        void LoadNhanVienList(BindingSource listEmployee);
        void LoadQuyenList(BindingSource listPermission);
        void LoadQuyenCombobox(BindingSource listPermission);
        void LoadChucNangListCheckBox(BindingSource listMethod);
        void LoadCheckedCheckBox(ArrayList arrMethod);
    }
}
