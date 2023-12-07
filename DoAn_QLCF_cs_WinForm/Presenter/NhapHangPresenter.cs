using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
    public class NhapHangPresenter
    {
        private INhapHangView view;
        private IPhieuNhapRepository repositoryPN;
        private IChiTietPhieuNhapRepository repositoryCTPN;
        private INhanVienRepository repositoryNV;
        private INccRepository repositoryNcc;
        private INguyenLieuRepository repositoryNgl;
        private BindingSource pnBindingSource;
        private BindingSource ctpnBindingSource;
        private BindingSource nvBindingSource;
        private BindingSource nccBindingSource;
        private BindingSource nglBindingSource;

        private IEnumerable<PhieuNhapModel> PhieuNhapList;
        private IEnumerable<ChiTietPhieuNhapModel> CTPNList;
        private IEnumerable<NhanVienModel> NhanVienList;
        private IEnumerable<NccModel> NccList;
        private IEnumerable<NguyenLieuModel> NglList;


        public NhapHangPresenter(INhapHangView view, IPhieuNhapRepository repoPN, IChiTietPhieuNhapRepository repoCTPN
            , INhanVienRepository repoNV, INccRepository repoNcc, INguyenLieuRepository repoNgl)
        {
            this.view = view;
            this.repositoryPN = repoPN;
            this.repositoryCTPN = repoCTPN;
            this.repositoryNV = repoNV;
            this.repositoryNcc = repoNcc;
            this.repositoryNgl = repoNgl;

            this.view.AddPNEvent += AddPN;
            this.view.AddCTPNEvent += AddCTPN;
            this.view.btnAddPNClickEvent += AddPNClickEvent;
            this.view.btnAddCTPNClickEvent += AddCTPNClickEvent;

            this.view.UpdatePNEvent += UpdatePN;
            this.view.UpdateCTPNEvent += UpdateCTPN;
            this.view.btnUpdatePNClickEvent += UpdatePNClickEvent;
            this.view.btnUpdateCTPNClickEvent += UpdateCTPNClickEvent;


            this.view.FilterPNEvent += FilterPN;
            this.view.btnFilterPNClickEvent += FilterPNClickEvent;
            this.view.FilterCTPNEvent += FilterCTPN;
            this.view.btnFilterCTPNClickEvent += FilterCTPNClickEvent;

            this.view.DeleteEvent += Delete;
            this.view.ResetEvent += LoadPhieuNhapList;

            this.view.btnAddNglEvent += AddNgl;
            this.view.FindPnEvent += FindPn;

            pnBindingSource = new BindingSource();
            ctpnBindingSource = new BindingSource();
            nvBindingSource = new BindingSource();
            nccBindingSource = new BindingSource();
            nglBindingSource = new BindingSource();
            LoadCTPNList();
            LoadNhanVienList(-1);
            LoadNccList(-1);
            LoadNglList(-1);
            LoadPhieuNhapList();
        }
        private void GetPNId()
        {
            int txtIdPN = repositoryPN.GetNextId();
            this.view.selectedIdPN = txtIdPN.ToString();
            view.GetIdPNAdd(txtIdPN);
        }
        private void GetCTPNId()
        {
            view.GetIdPNAdd(int.Parse(this.view.selectedIdPN));
        }
        private void LoadPhieuNhapList()
        {
            PhieuNhapList = repositoryPN.GetAll();
            pnBindingSource.DataSource = PhieuNhapList;
            view.LoadDataPN(pnBindingSource);
        }
        private void LoadPhieuNhapList(object sender, EventArgs e)
        {
            PhieuNhapList = repositoryPN.GetAll();
            pnBindingSource.DataSource = PhieuNhapList;
            view.LoadDataPN(pnBindingSource);
        }
        private void AddPNClickEvent(object sender, EventArgs e)
        {
            this.view.setStatePN(true, false, false, false);
            GetPNId();
            LoadNhanVienList(-1);
            LoadNccList(-1);
            LoadNglList(-1);
            this.view.SetPNNull();
        }
        private void AddCTPNClickEvent(object sender, EventArgs e)
        {
            this.view.setStateCTPN(true, false, false, false);
            GetCTPNId();
            this.view.SetNull();
        }
        private void AddPN(object sender, EventArgs e)
        {
            if (this.view.isAddPN)
                if (this.view.CheckInputPN())
                {
                    PhieuNhapModel pn = new PhieuNhapModel();
                    pn.PhieuNhapId = int.Parse(this.view.PhieuNhapId);
                    pn.NhanVienId = int.Parse(this.view.NhanVienId);
                    pn.NhaCungCapId = int.Parse(this.view.NhaCungCapId);
                    pn.NgayNhap = DateTime.Parse(this.view.NgayNhap);
                    pn.TongTien = float.Parse(this.view.TongTien);
                    bool check = true;
                    if (!repositoryPN.Add(pn))
                        check = false;

                    foreach (ChiTietPhieuNhapModel ct in this.view.listCTPN)
                    {
                        ct.PhieuNhapId = repositoryPN.GetNextId() - 1;
                        if (!repositoryCTPN.Add(ct))
                            check = false;
                    }
                    if (check)
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        repositoryPN.Delete(pn.PhieuNhapId);
                        repositoryCTPN.Delete(pn.PhieuNhapId);
                    }
                    LoadPhieuNhapList();
                }
        }
        private void AddCTPN(object sender, EventArgs e)
        {
            if (this.view.isAddCTPN)
                if (this.view.CheckInputCTPN())
                {
                    ChiTietPhieuNhapModel ctpn = new ChiTietPhieuNhapModel();
                    ctpn.PhieuNhapId = int.Parse(this.view.PhieuNhapId);
                    ctpn.NguyenLieuId = int.Parse(this.view.NguyenLieuId);
                    ctpn.KhoiLuong = float.Parse(this.view.KhoiLuong);
                    ctpn.DonGia = float.Parse(this.view.DonGia);

                    this.view.AddTempNgl(ctpn);

                    GetCTPNId();
                    this.view.SetNull();
                }
        }
        private void UpdatePNClickEvent(object sender, EventArgs e)
        {
            this.view.setStatePN(false, true, false, false);
            if (int.Parse(this.view.PNcount) > 0)
            {
                if (this.view.selectedIdPN != "0")
                {
                    PhieuNhapModel ngl = repositoryPN.GetById(int.Parse(this.view.selectedIdPN));
                    List<ChiTietPhieuNhapModel> list = repositoryCTPN.GetById(int.Parse(this.view.selectedIdPN));
                    LoadNhanVienList(ngl.NhanVienId);
                    LoadNccList(ngl.NhaCungCapId);
                    LoadNglList(-1);
                    this.view.FillDataDetailPage(ngl, list);
                }
                else
                    MessageBox.Show("Vui lòng chọn phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Danh sách rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdateCTPNClickEvent(object sender, EventArgs e)
        {
            this.view.setStateCTPN(false, true, false, false);
            if (int.Parse(this.view.selectedIdNGL) != 0)
            {
            }
        }
        private void UpdatePN(object sender, EventArgs e)
        {
            if (this.view.isUpdatePN)
                if (this.view.CheckInputPN())
                {
                    PhieuNhapModel pn = new PhieuNhapModel();
                    pn.PhieuNhapId = int.Parse(this.view.PhieuNhapId);
                    pn.NhanVienId = int.Parse(this.view.NhanVienId);
                    pn.NhaCungCapId = int.Parse(this.view.NhaCungCapId);
                    pn.NgayNhap = DateTime.Parse(this.view.NgayNhap);
                    pn.TongTien = float.Parse(this.view.TongTien);

                    repositoryCTPN.Delete(int.Parse(this.view.PhieuNhapId));
                    foreach (ChiTietPhieuNhapModel ct in this.view.listCTPN)
                        repositoryCTPN.Add(ct);
                    if (repositoryPN.Update(pn))
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadPhieuNhapList();
                }
        }
        private void UpdateCTPN(object sender, EventArgs e)
        {
            if (this.view.isUpdateCTPN)
                if (this.view.CheckInputCTPN())
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa phiếu nhập", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        ChiTietPhieuNhapModel ctpn = new ChiTietPhieuNhapModel();
                        ctpn.PhieuNhapId = int.Parse(this.view.PhieuNhapId);
                        ctpn.NguyenLieuId = int.Parse(this.view.NguyenLieuId);
                        ctpn.KhoiLuong = float.Parse(this.view.KhoiLuong);
                        ctpn.DonGia = float.Parse(this.view.DonGia);

                        this.view.AddTempNgl(ctpn);
                    }
                }
        }
        private void FilterPNClickEvent(object sender, EventArgs e)
        {
            this.view.setStatePN(false, false, true, true);
            LoadNhanVienList(0);
            LoadNccList(0);
            this.view.SetPNNull();
        }
        private void FilterPN(object sender, EventArgs e)
        {
            if (this.view.isFilterPN)
            {
                PhieuNhapList = repositoryPN.GetByValue(this.view.PhieuNhapId, this.view.NhanVienId, this.view.NhaCungCapId, this.view.NgayNhap, this.view.TongTien);
                pnBindingSource.DataSource = PhieuNhapList;
                view.LoadDataPN(pnBindingSource);
            }
            this.view.isFilterPN = false;
        }
        private void FilterCTPNClickEvent(object sender, EventArgs e)
        {
            this.view.setStateCTPN(false, false, true, true);
            LoadNglList(0);
            this.view.SetNull();
        }
        private void FilterCTPN(object sender, EventArgs e)
        {
            if (this.view.isFilterCTPN)
            {
                CTPNList = repositoryCTPN.GetByValue(this.view.PhieuNhapId, this.view.NguyenLieuId, this.view.KhoiLuong, this.view.DonGia);
                ctpnBindingSource.DataSource = CTPNList;
                view.LoadDataCTPN(ctpnBindingSource);
            }
            this.view.isFilterPN = false;
        }
        public void Delete(object sender, EventArgs e)
        {
            if (int.Parse(this.view.PNcount) > 0)
            {
                if (this.view.selectedIdPN != "0")
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu nhập", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        if (repositoryCTPN.Delete(int.Parse(this.view.selectedIdPN)) && repositoryPN.Delete(int.Parse(this.view.selectedIdPN)))
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadPhieuNhapList();
                    }
                }
                else
                    MessageBox.Show("Vui lòng chọn phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Danh sách rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadCTPNList()
        {
            CTPNList = repositoryCTPN.GetById(int.Parse(this.view.selectedIdPN));
            ctpnBindingSource.DataSource = CTPNList;
            view.LoadDataCTPN(ctpnBindingSource);
        }

        private void LoadNhanVienList(int index)
        {
            NhanVienList = repositoryNV.GetAll();
            nvBindingSource.DataSource = NhanVienList;
            view.LoadDataNV(nvBindingSource, index);
        }
        private void LoadNccList(int index)
        {
            NccList = repositoryNcc.GetAll();
            nccBindingSource.DataSource = NccList;
            view.LoadDataNCC(nccBindingSource, index);
        }
        private void LoadNglList(int index)
        {
            NglList = repositoryNgl.GetAll();
            nglBindingSource.DataSource = NglList;
            view.LoadDataNgl(nglBindingSource, index);
        }
        private void AddNgl(object sender, EventArgs e)
        {
            if (this.view.CheckInputNgl())
            {
                NguyenLieuModel ngl = new NguyenLieuModel();
                ngl.NguyenLieuId = 1;
                ngl.TenNguyenLieu = this.view.TenNguyenLieu;
                ngl.KhoiLuong = float.Parse(this.view.KhoiLuongNgl);
                ngl.GiaTien_Kg = float.Parse(this.view.GiaTien_Kg);
                ngl.ThongTin = this.view.ThongTin;
                ngl.HinhAnh = this.view.HinhAnh;
                ngl.IsDelete = false;

                if (repositoryNgl.Add(ngl))
                {
                    this.view.SetNullNgl();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LoadNglList(-1);
            }
        }
        private void FindPn(object sender, EventArgs e)
        {
            PhieuNhapList = repositoryPN.GetByValue(this.view.FindText, null, null, null, null);
            pnBindingSource.DataSource = PhieuNhapList;
            view.LoadDataPN(pnBindingSource);
            this.view.FindText = "";
        }
    }
}