using DoAn_QLCF_cs_WinForm.Model;
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
	public class PhanQuyenPresenter
	{
		private IPhanQuyenView view;
		private IPhanQuyenRepository repo;
        private BindingSource permissionBindingSource;
        private BindingSource methodBindingSource;
        private IEnumerable<QuyenModel> permissionList;
        private IEnumerable<ChucNangModel> methodList;

        public PhanQuyenPresenter(IPhanQuyenView view, IPhanQuyenRepository repo)
		{
			this.view = view;
			this.repo = repo;
            permissionBindingSource = new BindingSource();
            methodBindingSource = new BindingSource();
            LoadPhanQuyenList();

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
