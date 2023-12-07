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
        private BindingSource employeeBindingSource;
        private IEnumerable<QuyenNhanVienModel> employeeList;
        private BindingSource methodDetailBindingSource;
        private IEnumerable<ChucNangModel> methodDetailList;

        public PhanQuyenPresenter(IPhanQuyenView view, IPhanQuyenRepository repo)
		{
			this.view = view;
			this.repo = repo;
            permissionBindingSource = new BindingSource();
            methodBindingSource = new BindingSource();
            employeeBindingSource = new BindingSource();
            methodDetailBindingSource = new BindingSource();
            LoadQuyenList();
            LoadChucNangList();
            LoadNhanVienList();
            BindingEvents();
        }


        private void LoadQuyenList()
        {
            permissionList = repo.GetAllPermission();
            permissionBindingSource.DataSource = permissionList;
            this.view.LoadQuyenList(permissionBindingSource);
            this.view.LoadQuyenCombobox(permissionBindingSource);
        }

        private void LoadNhanVienList()
        {
            employeeList = repo.GetEmployeePermission();
            employeeBindingSource.DataSource = employeeList;
            this.view.LoadNhanVienList(employeeBindingSource);
        }
        private void LoadChucNangList()
        {
            methodList = repo.GetAllMethod();
            methodBindingSource.DataSource = methodList;
            this.view.LoadChucNangListCheckBox(methodBindingSource);
        }
        private void DetailPermission(object? sender, EventArgs e)
        {
            QuyenModel quyenModel = (QuyenModel)this.view.PermissionDataGridView.CurrentRow.DataBoundItem;
            this.view.IdPermissionDetail = quyenModel.IdPermission.ToString();
            this.view.NamePermissionDetail = quyenModel.NamePermission;
            this.view.ContentPermissionDetail = quyenModel.ContentPermission;

            methodDetailList = repo.GetMethodByIdPermission(quyenModel.IdPermission);
            methodDetailBindingSource.DataSource = methodDetailList;
            this.view.LoadChucNangListDetail(methodDetailBindingSource);
        }

        private void BindingEvents()
        {
            this.view.AddPermissionBtnEvent += AddPermission;
            this.view.EditPermissionBtnEvent += EditPermission;            
            this.view.DeletePermissionBtnEvent += DeletePermission;
            this.view.DetailPermissionBtnEvent += DetailPermission;
            this.view.AcceptPermissionBtnEvent += AcceptPermission;

            this.view.EditPermissionEmployeeBtnEvent += EditPermissionEmployeeBtnEvent;
            this.view.DeletePermissionEmployeeBtnEvent += DeletePermissionEmployeeBtnEvent;
            this.view.AcceptPermissionEmployeeBtnEvent += AcceptPermissionEmployeeBtnEvent;
        }

        private void DeletePermissionEmployeeBtnEvent(object? sender, EventArgs e)
        {
            if (this.view.ShowYesNoMessage("Xác nhận xóa!") == DialogResult.Yes)
            {
                QuyenNhanVienModel model = (QuyenNhanVienModel)this.view.PermissionEmployeeDataGridView.CurrentRow.DataBoundItem;
                if (this.repo.DeletePermissionEmployee(model.IdEmployee))
                {
                    this.view.ShowMessage("Xóa quyền nhân viên thành công!");
                    LoadNhanVienList();
                }
                else
                {
                    this.view.ShowMessage("Xóa quyền nhân viên thất bại!");
                }
            }
        }

        
        private void AcceptPermissionEmployeeBtnEvent(object? sender, EventArgs e)
        {
            QuyenNhanVienModel model = new QuyenNhanVienModel();
            model.IdEmployee = int.Parse(this.view.IdEmployee);
            model.NameEmployee = this.view.NameEmployee;
            model.IdPermission = this.view.ComboboxIdPermission;
            if (this.repo.EditPermissionEmployee(model))
            {
                this.view.ShowMessage("Sửa quyền nhân viên thành công!");
                LoadNhanVienList();
            }
            else
            {
                this.view.ShowMessage("Sửa quyền nhân viên thất bại!");
            }                        
        }

        private void EditPermissionEmployeeBtnEvent(object? sender, EventArgs e)
        {
            QuyenNhanVienModel model = (QuyenNhanVienModel)this.view.PermissionEmployeeDataGridView.CurrentRow.DataBoundItem;
            this.view.IdEmployee = model.IdEmployee.ToString();
            this.view.NameEmployee = model.NameEmployee;
            this.view.ComboboxIdPermission = model.IdPermission;
        }

        private bool CheckInput()
        {
            if (this.view.NamePermission == "")
            {
                this.view.ShowMessage("Tên quyền không được để trống!");
                return false;
            }
            if(this.view.ContentPermission == "")
            {
                this.view.ShowMessage("Nội dung quyền không được để trống!");
                return false;
            }
            return true;
        }
        private void AcceptPermission(object? sender, EventArgs e)
        {
            if (CheckInput())
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
                        LoadQuyenList();
                        this.view.GoToListTabPage();
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
                        LoadQuyenList();
                        this.view.GoToListTabPage();
                    }
                    else
                    {
                        this.view.ShowMessage("Sửa quyền thất bại!");
                    }
                }
            }
            
        }        

        private void DeletePermission(object? sender, EventArgs e)
        {
            if (this.view.ShowYesNoMessage("Xác nhận xóa!") == DialogResult.Yes)
            {
                QuyenModel quyenModel = (QuyenModel)this.view.PermissionDataGridView.CurrentRow.DataBoundItem;
                if(quyenModel.IdPermission == 0)
                {
                    this.view.ShowMessage("Không thể Xóa quyền này!");
                    return;
                }
                if (this.repo.IsPermissionOwnByEmployee(quyenModel.IdPermission))
                {
                    this.view.ShowMessage("Quyền đã được gán cho Nhân Viên!\nKhông thể Xóa!");
                    return;
                }
                if (this.repo.DeletePermissionById(quyenModel.IdPermission))
                {
                    this.view.ShowMessage("Xóa quyền thành công!");
                    LoadQuyenList();
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
            if( quyenModel.IdPermission == 0)
            {
                this.view.ShowMessage("Không thể Sửa quyền này!");
            }
            else
            {
                this.view.IdPermission = quyenModel.IdPermission.ToString();
                this.view.NamePermission = quyenModel.NamePermission;
                this.view.ContentPermission = quyenModel.ContentPermission;
                this.view.LoadCheckedCheckBox(this.repo.GetArrMethodByIdPermission(quyenModel.IdPermission));
                this.view.GoToDetailPermissionTab();
            }
            
        }

        private void AddPermission(object? sender, EventArgs e)
        {
            this.isAdd = true;
            this.view.IdPermission = repo.GetNextIdPermission().ToString();
            this.view.NamePermission = String.Empty;
            this.view.ContentPermission = String.Empty;
        }
    }
}
