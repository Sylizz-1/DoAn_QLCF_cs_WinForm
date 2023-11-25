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
    public class NguyenLieuPresenter
    {
        private INguyenLieuView view;
        private INguyenLieuRepository repository;
        private BindingSource cpBindingSource;
        private IEnumerable<NguyenLieuModel> NguyenLieuList;


        public NguyenLieuPresenter(INguyenLieuView view, INguyenLieuRepository repository)
        {
            this.view = view;
            this.repository = repository;
            cpBindingSource = new BindingSource();
            LoadNguyenLieuList();
            GetNguyenLieuId();
        }

        private void LoadNguyenLieuList()
        {
            NguyenLieuList = repository.GetAll();
            cpBindingSource.DataSource = NguyenLieuList;
            view.LoadData(cpBindingSource);
        }
        private void GetNguyenLieuId()
        {
            int txtIdNguyenLieu = repository.GetNextId();
            view.GetIdNguyenLieuAdd(txtIdNguyenLieu);
        }

        public void Add()
        {
            NguyenLieuModel NguyenLieu = view.AddNguyenLieu();
            repository.Add(NguyenLieu);
        }
        public void Delete()
        {

        }
        public void Update()
        {

        }
        public void SearchChange()
        {

        }
    }
}
