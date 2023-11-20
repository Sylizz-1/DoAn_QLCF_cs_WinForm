using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class ImExFileRepository : BaseRepository, IImExFileRepository
    {
        public ImExFileRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}