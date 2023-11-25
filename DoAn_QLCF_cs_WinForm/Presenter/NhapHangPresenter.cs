using DoAn_QLCF_cs_WinForm.Model;
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
        private BindingSource cpBindingSource;

        private IEnumerable<PhieuNhapModel> PhieuNhapList;
        private IEnumerable<NhanVienModel> NhanVienList;


        public NhapHangPresenter(INhapHangView view, IPhieuNhapRepository repoPN, IChiTietPhieuNhapRepository repositoryCTPN
            , INhanVienRepository repoNV, INccRepository repoNcc)
        {
            this.view = view;
            this.repositoryPN = repoPN;
            this.repositoryCTPN = repositoryCTPN;
            this.repositoryNV = repoNV;
            this.repositoryNcc = repoNcc;
            cpBindingSource = new BindingSource();
            LoadPhieuNhapList();
        }

        private void LoadPhieuNhapList()
        {
            PhieuNhapList = repositoryPN.GetAll();
            cpBindingSource.DataSource = PhieuNhapList;
            view.LoadData(cpBindingSource);
        }

        private void LoadNhanVienList()
        {
            NhanVienList = repositoryNV.GetAll();
            cpBindingSource.DataSource = NhanVienList;
            view.LoadData(cpBindingSource);
        }
    }
}
