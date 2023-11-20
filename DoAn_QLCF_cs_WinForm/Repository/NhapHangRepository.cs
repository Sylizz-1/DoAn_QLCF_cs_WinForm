using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class NhapHangRepository : BaseRepository, INhapHangRepository
    {
        public NhapHangRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}