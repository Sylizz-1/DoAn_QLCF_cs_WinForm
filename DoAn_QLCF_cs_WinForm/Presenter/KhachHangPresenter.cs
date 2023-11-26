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
	public class KhachHangPresenter
	{
        private IKhachHangView view;
        private IKhachHangRepository repo;
        private BindingSource bindingSource;
        private IEnumerable<KhachHangModel> List;

        public KhachHangPresenter(IKhachHangView view, IKhachHangRepository repo)
		{
			this.view = view;
			this.repo = repo;
            bindingSource = new BindingSource();
            LoadKhachHangList();
        }

        private void LoadKhachHangList()
        {
            List = repo.GetAll();
            bindingSource.DataSource = List;
            view.LoadData(bindingSource);
        }
    }
}
