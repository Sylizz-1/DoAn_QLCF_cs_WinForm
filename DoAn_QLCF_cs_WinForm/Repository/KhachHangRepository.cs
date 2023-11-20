using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class KhachHangRepository : BaseRepository, IKhachHangRepository
    {
        public KhachHangRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}