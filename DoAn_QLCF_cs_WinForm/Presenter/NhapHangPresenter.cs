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
#pragma warning disable CS0169 // The field 'NhapHangPresenter.repositoryNgl' is never used
        private INguyenLieuRepository repositoryNgl;
#pragma warning restore CS0169 // The field 'NhapHangPresenter.repositoryNgl' is never used
        private BindingSource pnBindingSource;
        private BindingSource ctpnBindingSource;
        private BindingSource nvBindingSource;
        private BindingSource nccBindingSource;

        private IEnumerable<PhieuNhapModel> PhieuNhapList;
        private IEnumerable<ChiTietPhieuNhapModel> CTPNList;
        private IEnumerable<NhanVienModel> NhanVienList;
        private IEnumerable<NccModel> NccList;


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public NhapHangPresenter(INhapHangView view, IPhieuNhapRepository repoPN, IChiTietPhieuNhapRepository repositoryCTPN
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            , INhanVienRepository repoNV, INccRepository repoNcc, INguyenLieuRepository repoNgl)
        {
            this.view = view;
            this.repositoryPN = repoPN;
            this.repositoryCTPN = repositoryCTPN;
            this.repositoryNV = repoNV;
            this.repositoryNcc = repoNcc;
            pnBindingSource = new BindingSource();
            ctpnBindingSource = new BindingSource();
            nvBindingSource = new BindingSource();
            nccBindingSource = new BindingSource();
            LoadPhieuNhapList();
            LoadCTPNList();
            LoadNhanVienList();
            LoadNccList();
        }

        private void LoadPhieuNhapList()
        {
            PhieuNhapList = repositoryPN.GetAll();
            pnBindingSource.DataSource = PhieuNhapList;
            view.LoadDataPN(pnBindingSource);
        }
        private void LoadCTPNList()
        {
            CTPNList = repositoryCTPN.GetAll();
            ctpnBindingSource.DataSource = CTPNList;
            view.LoadDataCTPN(ctpnBindingSource);
        }

        private void LoadNhanVienList()
        {
            NhanVienList = repositoryNV.GetAll();
            nvBindingSource.DataSource = NhanVienList;
            view.LoadDataNV(nvBindingSource);
        }
        private void LoadNccList()
        {
            NccList = repositoryNcc.GetAll();
            nccBindingSource.DataSource = NccList;
            view.LoadDataNCC(nccBindingSource);
        }
    }
}
