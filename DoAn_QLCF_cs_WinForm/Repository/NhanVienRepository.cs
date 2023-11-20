using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class NhanVienRepository : BaseRepository, INhanVienRepository
    {

        public NhanVienRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}