using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository
{
	public class BanHangRepository: BaseRepository, IBanHangRepository
	{
		private string caPheImagePath;
		private string nguyenLieuImagePath;

		public BanHangRepository(string connectionString)
		{
			this.connectionString = connectionString;
			string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			caPheImagePath = Path.Combine(path, "image\\caPhe");
			nguyenLieuImagePath = Path.Combine(path, "image\\nguyenLieu");
		}
	}
}
