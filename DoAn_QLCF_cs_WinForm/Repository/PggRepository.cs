using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class PggRepository : BaseRepository, IPggRepository
    {
        public PggRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}