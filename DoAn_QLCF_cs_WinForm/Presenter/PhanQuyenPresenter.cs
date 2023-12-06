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
        private bool isAdd = false;

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
            ArrayList arrMethod = new ArrayList();
            QuyenModel model = new QuyenModel();            
            model.IdPermission = int.Parse(this.view.IdPermission);
            model.NamePermission = this.view.NamePermission;
            model.ContentPermission = this.view.ContentPermission;
            arrMethod = this.view.GetArrayMethodChecked();
            if (this.isAdd)
            {
                if (this.repo.Add(model, arrMethod))
                {
                    this.view.ShowMessage("Thêm quyền thành công!");
                    LoadPhanQuyenList();
                }
                else
                {
                    this.view.ShowMessage("Thêm quyền thất bại!");
                }
            }
            else
            {
                if (this.repo.Edit(model, arrMethod))
                {
                    this.view.ShowMessage("Sửa quyền thành công!");
                    LoadPhanQuyenList();
                }
                else
                {
                    this.view.ShowMessage("Sửa quyền thất bại!");
                }
            }
        }

        private void DetailPermission(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeletePermission(object? sender, EventArgs e)
        {
            if (this.view.ShowYesNoMessage("Xác nhận xóa!") == DialogResult.Yes)
            {
                QuyenModel quyenModel = (QuyenModel)this.view.PermissionDataGridView.CurrentRow.DataBoundItem;
                if (this.repo.IsPermissionOwnByEmployee(quyenModel.IdPermission))
                {
                    this.view.ShowMessage("Quyền đã được gán cho Nhân Viên!\nKhông thể Xóa!");
                    return;
                }
                if (this.repo.DeletePermissionById(quyenModel.IdPermission))
                {
                    this.view.ShowMessage("Xóa quyền thành công!");
                    LoadPhanQuyenList();
                }
                else
                {
                    this.view.ShowMessage("Xóa quyền thất bại!");
                }
            }           
        }

        private void EditPermission(object? sender, EventArgs e)
        {
            this.isAdd = false;
            QuyenModel quyenModel = (QuyenModel)this.view.PermissionDataGridView.CurrentRow.DataBoundItem;
            this.view.IdPermission = quyenModel.IdPermission.ToString();
            this.view.NamePermission = quyenModel.NamePermission;
            this.view.ContentPermission = quyenModel.ContentPermission;
            this.view.LoadCheckedCheckBox(this.repo.GetArrMethodByIdPermission(quyenModel.IdPermission));           
        }

        private void AddPermission(object? sender, EventArgs e)
        {
            this.isAdd = true;
            this.view.IdPermission = repo.GetNextIdPermission().ToString();
            this.view.NamePermission = String.Empty;
            this.view.ContentPermission = String.Empty;
        }

        private void LoadPhanQuyenList()
        {
            permissionList = repo.GetAllPermission();
            methodList = repo.GetAllMethod();
            permissionBindingSource.DataSource = permissionList;
            methodBindingSource.DataSource = methodList;
            this.view.LoadData(permissionBindingSource, methodBindingSource);
            this.view.LoadChucNangListCheckBox(methodBindingSource);
        }
    }
}
