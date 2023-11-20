using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class NccViewRepository : BaseRepository, INccViewRepository
    {
        public NccViewRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}