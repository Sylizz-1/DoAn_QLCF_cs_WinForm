﻿using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
	public class NhanVienPresenter
	{
		private INhanVienView view;
		private INhanVienRepository repo;
		private BindingSource bindingSource;
		private IEnumerable<NhanVienModel> List;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public NhanVienPresenter(INhanVienView view, INhanVienRepository repo)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		{
            this.view = view;
            this.repo = repo;
            bindingSource = new BindingSource();
            LoadNhanVienList();
            GetNhanVienId();
            GetNhanVienQuyen();
        }
        private void LoadNhanVienList()
        {
            List = repo.GetAll();
            bindingSource.DataSource = List;
            view.LoadData(bindingSource);
        }

        private void GetNhanVienId()
        {
            int txtId = repo.GetNextId();
            view.GetIdNhanVien(txtId);

        }
        private void GetNhanVienQuyen()
        {
            List<string> quyenList = repo.getQuyen();
            view.GetQuyenNhanVien(quyenList);
        }

        public void Add()
        {

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
