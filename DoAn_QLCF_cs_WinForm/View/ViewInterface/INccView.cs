using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
    public interface INccView
    {
        event EventHandler btnAddClickEvent;
        event EventHandler btnUpdateClickEvent;
        event EventHandler btnFilterClickEvent;
        event EventHandler AddEvent;
        event EventHandler DeleteEvent;
        event EventHandler UpdateEvent;
        event EventHandler SortEvent;
        event EventHandler FilterEvent;
        event EventHandler ResetEvent;
        bool isAdd { get; set; }
        bool isFilter { get; set; }
        bool isUpdate { get; set; }
        string NhaCungCapId { get; set; }
        string TenNhaCungCap { get; set; }
        string DiaChi { get; set; }
        string SDT { get; set; }
        string Email { get; set ; }
        string IsDelete { get; set; }
        string selectedId { get; set; }
        void LoadData(BindingSource list);
        void GetIdNccAdd(int id);
        bool CheckInput();
        void SetNull();
        void setState(bool isAddState, bool isUpdateState, bool isFilterState, bool isNeedReturnState);
        void SetTextBoxFillData(NccModel ncc);
    }
}