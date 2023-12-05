using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
    public interface INguyenLieuView
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
        string NguyenLieuId { get; set; }
        string TenNguyenLieu { get; set; }
        string ThongTin { get; set; }
        string KhoiLuong { get; set; }
        string GiaTien_Kg { get; set; }
        string HinhAnh { get; set; }
        string IsDelete { get; set; }
        string selectedId { get; set; }
        void LoadData(BindingSource list);
        void GetIdNguyenLieuAdd(int id);
        bool CheckInput();
        void SetNull();
        void setState(bool isAddState, bool isUpdateState, bool isFilterState, bool isNeedReturnState);
        void SetTextBoxFillData(NguyenLieuModel ngl);
    }
}