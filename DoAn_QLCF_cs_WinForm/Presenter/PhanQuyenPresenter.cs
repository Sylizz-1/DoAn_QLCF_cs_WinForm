using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
	public class PhanQuyenPresenter
	{
		private IPhanQuyenView view;
		private IPhanQuyenRepository repo;
        private BindingSource permissionBindingSource;
        private IEnumerable<QuyenModel> permissionList;
        private BindingSource methodBindingSource;        
        private IEnumerable<ChucNangModel> methodList;

        public PhanQuyenPresenter(IPhanQuyenView view, IPhanQuyenRepository repo)
		{
			this.view = view;
			this.repo = repo;

            permissionBindingSource = new BindingSource();
            methodBindingSource = new BindingSource();
            LoadPhanQuyenList();
            BindingEvents();
        }
        private void BindingEvents()
        {
            this.view.AddPermissionBtnEvent += AddPermission;
            this.view.EditPermissionBtnEvent += EditPermission;            
            this.view.DeletePermissionBtnEvent += DeletePermission;
            this.view.DetailPermissionBtnEvent += DetailPermission;
            this.view.AcceptPermissionBtnEvent += AcceptPermission;
            this.view.CancelPermissionBtnEvent += CancelPermission;
        }

        private void CancelPermission(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AcceptPermission(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DetailPermission(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeletePermission(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditPermission(object? sender, EventArgs e)
        {
            QuyenModel quyenModel = (QuyenModel)this.view.PermissionDataGridView.CurrentRow.DataBoundItem;
            this.view.IdPermission = quyenModel.IdPermission.ToString();
            this.view.NamePermission = quyenModel.NamePermission;
            this.view.ContentPermission = quyenModel.ContentPermission;
            this.view.LoadChucNangListCheckBox(methodBindingSource, repo.GetArrMethodByIdPermission(quyenModel.IdPermission));
        }

        private void AddPermission(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadPhanQuyenList()
        {
            permissionList = repo.GetAllPermission();
            methodList = repo.GetAllMethod();
            permissionBindingSource.DataSource = permissionList;
            methodBindingSource.DataSource = methodList;
            this.view.LoadData(permissionBindingSource, methodBindingSource);            
        }
    }
}
