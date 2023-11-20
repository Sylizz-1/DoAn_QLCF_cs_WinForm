using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class ThongKeRepository : BaseRepository, IThongKeRepository
    {

        public ThongKeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}