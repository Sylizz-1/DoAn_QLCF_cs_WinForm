using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
    public interface INhapHangView
    {
        event EventHandler btnAddPNClickEvent;
        event EventHandler btnAddCTPNClickEvent;
        event EventHandler btnUpdatePNClickEvent;
        event EventHandler btnUpdateCTPNClickEvent;
        event EventHandler btnFilterPNClickEvent;
        event EventHandler btnFilterCTPNClickEvent;
        event EventHandler AddPNEvent;
        event EventHandler AddCTPNEvent;
        event EventHandler DeleteEvent;
        event EventHandler UpdatePNEvent;
        event EventHandler UpdateCTPNEvent;
        event EventHandler SortEvent;
        event EventHandler FilterPNEvent;
        event EventHandler FilterCTPNEvent;
        event EventHandler ResetEvent;
        event EventHandler FindPnEvent;


        event EventHandler btnAddNglEvent;
        List<ChiTietPhieuNhapModel> listCTPN { get; set; }
        bool isAddPN { get; set; }
        bool isFilterPN { get; set; }
        bool isUpdatePN { get; set; }
        bool isAddCTPN { get; set; }
        bool isFilterCTPN { get; set; }
        bool isUpdateCTPN { get; set; }
        string PhieuNhapId { get; set; }
        string NhanVienId { get; set; }
        string NhaCungCapId { get; set; }
        string NgayNhap { get; set; }
        string TongTien { get; set; }
        string NguyenLieuId { get; set; }
        string KhoiLuong { get; set; }
        string DonGia { get; set; }
        string selectedIdPN { get; set; }
        string selectedIdNGL { get; set; }
        string PNcount { get; }
        string TenNguyenLieu { get; set; }
        string ThongTin { get; set; }
        string KhoiLuongNgl { get; set; }
        string GiaTien_Kg { get; set; }
        string HinhAnh { get; set; }
        string FindText { get; set; }
        void LoadDataPN(BindingSource list);
        void LoadDataCTPN(BindingSource list);
        void LoadDataNV(BindingSource list, int index);
        void LoadDataNCC(BindingSource list, int index);
        void LoadDataNgl(BindingSource list, int index);
        void AddTempNgl(ChiTietPhieuNhapModel ctpn);
        void GetIdPNAdd(int id);
        bool CheckInputPN();
        bool CheckInputCTPN();
        bool CheckInputNgl();
        void SetPNNull();
        void SetNull();
        void SetNullNgl();
        void setStatePN(bool isAddPNState, bool isUpdatePNState, bool isFilterPNState, bool isNeedReturnPNState);
        void setStateCTPN(bool isAddCTPNState, bool isUpdateCTPNState, bool isFilterCTPNState, bool isNeedReturnCTPNState);
        void FillDataDetailPage(PhieuNhapModel pn, List<ChiTietPhieuNhapModel> list);
    }
}
