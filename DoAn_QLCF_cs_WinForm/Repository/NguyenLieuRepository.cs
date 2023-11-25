using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class NguyenLieuRepository : BaseRepository, INguyenLieuRepository
    {
        private string nguyenLieuImagePath;

        public NguyenLieuRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}