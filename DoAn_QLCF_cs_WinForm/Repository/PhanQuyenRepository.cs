using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class PhanQuyenRepository : BaseRepository, IPhanQuyenRepository
    {
        public PhanQuyenRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}