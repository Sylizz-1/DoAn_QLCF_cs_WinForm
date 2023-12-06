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

        event EventHandler btnUpdateClickEvent;
        event EventHandler UpdateEvent;
        event EventHandler SortEvent;
        event EventHandler FilterEvent;
        event EventHandler ResetEvent;
        bool isUpdate { get; set; }
        public int HoaDonId { get; set; }
        public int NhanVienId { get; set; }
        public int KhachHangId { get; set; }
        public int PggId { get; set; }
        public DateTime NgayNhap { get; set; }
        public float PhiTruocGiamGia { get; set; }
        public byte GiamGia { get; set; }
        public float PhiSauGiamGia { get; set; }
        public bool IsAccepted { get; set; }
        public int CT_HoaDonId { get; set; }
        public int CT_CaPheId { get; set; }
        public string CT_TenCaPhe { get; set; }
        public int CT_SoLuong { get; set; }
        public float CT_DonGia { get; set; }
        string selectedId { get; set; }
        void LoadData(BindingSource list);
        void LoadData_CT(BindingSource list);
        bool CheckInput();
        void SetNull();
        void setState(bool isAddState, bool isUpdateState, bool isFilterState, bool isNeedReturnState);
        void SetTextBoxFillData(HoaDonModel hd);
        void SetTextBoxFillData_CT(ChiTietHoaDonModel cthd);

    }
}
