using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class PggPresenter
    {
        private IPggView view;
        private IPggRepository repo;

        public PggPresenter(IPggView view, IPggRepository repo)
        {
            this.view = view;
            this.repo = repo;
        }
    }
}
