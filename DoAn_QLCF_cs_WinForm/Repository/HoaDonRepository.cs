using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;

namespace DoAn_QLCF_cs_WinForm.Repository
{
    public class HoaDonRepository : BaseRepository, IHoaDonRepository
    {

        public HoaDonRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}