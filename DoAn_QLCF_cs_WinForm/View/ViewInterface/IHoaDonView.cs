using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.View.ViewInterface
{
	public interface IHoaDonView
	{
        event EventHandler DataUpdatedEvent;
        event EventHandler btnLocClickEvent;
        event EventHandler btnUpdateClickEvent;
        event EventHandler UpdateEvent;
        event EventHandler SortEvent;
        event EventHandler FilterEvent;
        event EventHandler ResetEvent;
        bool isUpdate { get; set; }
        public string HoaDonId { get; set; }
        public string NhanVienId { get; set; }
        public string KhachHangId { get; set; }
        public string PggId { get; set; }
        public string NgayNhap { get; set; }
        public string PhiTruocGiamGia { get; set; }
        public string GiamGia { get; set; }
        public string PhiSauGiamGia { get; set; }
        public string IsAccepted { get; set; }
        string selectedId { get; set; }
        void LoadData(BindingSource list);
        void LoadData_CT(BindingSource list);
        void setState(bool isAddState, bool isUpdateState, bool isFilterState, bool isNeedReturnState);
        void SetTextBoxFillData(HoaDonModel hd);

    }
}
