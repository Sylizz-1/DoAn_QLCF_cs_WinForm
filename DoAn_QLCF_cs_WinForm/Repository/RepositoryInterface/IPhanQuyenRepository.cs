using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
	public interface IPhanQuyenRepository
	{
        bool DeletePermissionEmployee(int idEmployee);
        bool EditPermissionEmployee(QuyenNhanVienModel model);
        bool DeletePermissionById(int idPermission);
        bool IsPermissionOwnByEmployee(int idPermission);
        bool Edit(QuyenModel quyenModel, ArrayList arrMethod);
        bool Add(QuyenModel quyenModel, ArrayList arrMethod);
        int GetNextIdPermission();
        ArrayList GetArrMethodByIdPermission(int idPermission);
        IEnumerable<ChucNangModel> GetMethodByIdPermission(int idPermission);
        IEnumerable<QuyenModel> GetAllPermission();
        IEnumerable<ChucNangModel> GetAllMethod();
        IEnumerable<QuyenNhanVienModel> GetEmployeePermission();
    }
}
