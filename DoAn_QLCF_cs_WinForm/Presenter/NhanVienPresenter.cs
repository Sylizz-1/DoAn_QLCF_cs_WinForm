using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
	public class NhanVienPresenter
	{
		private INhanVienView view;
		private INhanVienRepository repo;
		private BindingSource bindingSource;
		private IEnumerable<NhanVienModel> list;
        private BindingSource bindingSourceQuyen;
        private IEnumerable<QuyenModel> listQuyen;

        private bool isAdd = false;

        public NhanVienPresenter(INhanVienView view, INhanVienRepository repo)
		{
            this.view = view;
            this.repo = repo;
            bindingSource = new BindingSource();
            bindingSourceQuyen = new BindingSource();
            LoadNhanVienList();            
            LoadQuyen();
            BindingEvents();
        }

        private void BindingEvents()
        {
            this.view.AddBtnEvent += Add;
            this.view.EditBtnEvent += Edit;
            this.view.DeleteBtnEvent += Delete;
            this.view.AcceptBtnEvent += Accept;
            //this.view.CancelBtnEvent += CancelPermission;
        }

        private void Delete(object? sender, EventArgs e)
        {
            NhanVienModel model = (NhanVienModel)this.view.DataGridView.CurrentRow.DataBoundItem;
            if (this.repo.Delete(model))
            {
                this.view.ShowMessage("Xóa thành công!");
                LoadNhanVienList();
            }
            else
            {
                this.view.ShowMessage("Xóa thất bại!");
            }
            
        }


        private void Edit(object? sender, EventArgs e)
        {
            isAdd = false;
            NhanVienModel model = (NhanVienModel)this.view.DataGridView.CurrentRow.DataBoundItem;
            this.view.IdNhanVien = model.Id.ToString();
            this.view.NameNhanVien = model.Name;
            this.view.Email = model.Email;
            this.view.PhoneNumber = model.Sdt;
            this.view.GioiTinh = model.Gioitinh;
            this.view.NgaySinh = model.Ngaysinh;
            this.view.Username = model.Taikhoan;
            this.view.Password = model.Matkhau;
            this.view.PasswordConfirm = model.Matkhau;
            this.view.IsDeleted = model.isDelete;
            this.view.Permission = model.IdPermission;            
        }
        private bool IsEmailValid(string email)
        {
            // Biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            // Sử dụng Regex.IsMatch để kiểm tra
            return Regex.IsMatch(email, pattern);
        }
        private bool CheckInput()
        {
            if(this.view.Username == "")
            {
                this.view.ShowMessage("Tài khoản không được để trống!");
                return false;
            }
            if (this.view.Password == "")
            {
                this.view.ShowMessage("Mật khẩu không được để trống!");
                return false;
            }
            if (this.view.PasswordConfirm == "")
            {
                this.view.ShowMessage("Nhập lại mật khẩu không được để trống!");
                return false;
            }
            if(this.view.Password != this.view.PasswordConfirm)
            {
                this.view.ShowMessage("Mật khẩu không khớp!");
                return false;
            }
            if (this.view.NameNhanVien == "")
            {
                this.view.ShowMessage("Tên không được để trống!");
                return false;
            }
            if (this.view.PhoneNumber == "")
            {
                this.view.ShowMessage("Số điện thoại không được để trống!");
                return false;
            }
            if (this.view.Email == "")
            {
                this.view.ShowMessage("Email không được để trống!");
                return false;
            }
            if (!IsEmailValid(this.view.Email))
            {
                this.view.ShowMessage("Email không đúng định dạng!");
                return false;
            }
            return true;
        }
        private void Accept(object? sender, EventArgs e)
        {
            if (CheckInput())
            {
                NhanVienModel model = new NhanVienModel();
                model.Id = int.Parse(this.view.IdNhanVien);
                model.Taikhoan = this.view.Username;
                model.Matkhau = this.view.Password;
                model.IdPermission = this.view.Permission;
                model.Name = this.view.NameNhanVien;
                model.Gioitinh = this.view.GioiTinh;
                model.Sdt = this.view.PhoneNumber;
                model.Email = this.view.Email;
                model.Ngaysinh = this.view.NgaySinh;
                model.isDelete = this.view.IsDeleted;
                if (this.isAdd)
                {
                    if (this.repo.Add(model))
                    {
                        this.view.ShowMessage("Thêm nhân viên thành công!");
                        LoadNhanVienList();
                        this.view.GoToListTabPage();
                    }
                    else
                    {
                        this.view.ShowMessage("Thêm nhân viên thất bại!");
                    }
                }
                else
                {
                    if (this.repo.Edit(model))
                    {
                        this.view.ShowMessage("Sửa nhân viên thành công!");
                        LoadNhanVienList();
                        this.view.GoToListTabPage();
                    }
                    else
                    {
                        this.view.ShowMessage("Sửa nhân viên thất bại!");
                    }
                }
            }            
        }

        private void Add(object? sender, EventArgs e)
        {
            isAdd = true;
            int txtId = repo.GetNextId();
            this.view.IdNhanVien = txtId.ToString();
        }

        private void LoadNhanVienList()
        {
            list = repo.GetAll();
            bindingSource.DataSource = list;
            view.LoadData(bindingSource);
        }

        private void LoadQuyen()
        {
            listQuyen = repo.GetAllQuyen();
            bindingSourceQuyen.DataSource = listQuyen;            
            view.LoadQuyen(bindingSourceQuyen);
        }
     
    }
}
