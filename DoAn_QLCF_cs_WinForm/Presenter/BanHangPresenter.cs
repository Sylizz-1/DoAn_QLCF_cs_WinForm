using DoAn_QLCF_cs_WinForm.CustomUserControl;
using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
	public class BanHangPresenter
	{
		private IBanHangView view;
		private IBanHangRepository repository;
		private BindingSource cpBindingSource;
		private IEnumerable<CaPheModel> cpList;

		private BindingSource pggBindingSource;
		private IEnumerable<PggModel> pggList;

		public BanHangPresenter(IBanHangView view, IBanHangRepository repository)
		{
			this.view = view;
			this.repository = repository;
			cpBindingSource = new BindingSource();
			pggBindingSource = new BindingSource();
			LoadCaPheList();
			LoadGiamGiaLoaiKh();
			LoadPgg();
			this.view.DatHangBtnEvent += DatHang;
		}

	

		public void LoadCaPheList()
		{
			IEnumerable<CaPheModel> cpModels = repository.GetAllCaPhe();
			foreach(CaPheModel cpModel in cpModels)
			{
				SanPhamCaPheUC spcpUc = new SanPhamCaPheUC();
				spcpUc.SetData(cpModel);
				spcpUc.SetParentView(view);
				view.SanPhamPanel.Controls.Add(spcpUc);
			}
		}

		public void LoadGiamGiaLoaiKh()
		{
			int ggLoaiKh = repository.GetGiamGiaLoaiKh(view.KhModel.Id);
			view.GiamGiaLoaiKh = ggLoaiKh;
		}

		public void LoadPgg()
		{
			pggList = repository.GetAllPgg();
			pggBindingSource.DataSource = pggList;
			view.PggDg.DataSource = pggBindingSource;
			view.PggDg.Columns["IsDelete"].Visible = false;
		}

		private void DatHang(object? sender, EventArgs e)
		{
			float max = 0;
			if (this.view.GioHangPanel.Controls.Count == 0)
			{
				MessageBox.Show("Giỏ xin hãy thêm sản phẩm vào giỏ hàng!!!");
				return;
			}

			float giaGoc = view.GiaGocTxt;
			int idKhachHang = view.KhModel.Id, giamGiaLoaiKh = view.GiamGiaLoaiKh;
			int idHoaDon = repository.GetLastId();
			++idHoaDon;
			PggModel pgg = new PggModel()
			{
				PggId = 0,
				PhanTramGiamGia = 0
			};

			List<ChiTietHoaDonModel> cthdList = new List<ChiTietHoaDonModel>();

			foreach (PggModel pggTemp in pggList)
			{
				if (giaGoc >= pggTemp.GiaHoaDon && pggTemp.GiaHoaDon > max)
				{
					max = Convert.ToSingle(pggTemp.GiaHoaDon);
					pgg = pggTemp;
				}
			}

			foreach (ChiTietHoaDonUC cthdUcTemp in view.GioHangPanel.Controls)
			{
				ChiTietHoaDonModel cthdModel = new ChiTietHoaDonModel()
				{
					CT_HoaDonId = idHoaDon,
					CT_CaPheId = cthdUcTemp.cpModel.Id,
					CT_DonGia = cthdUcTemp.donGia,
					CT_SoLuong = cthdUcTemp.soLuong
				};
				cthdList.Add(cthdModel);
			}

			float giamGiaFinal = pgg.PhanTramGiamGia + giamGiaLoaiKh;
			HoaDonModel hdModel = new HoaDonModel()
			{
				HoaDonId = idHoaDon,
				NhanVienId = 1,
				KhachHangId = idKhachHang,
				PggId = pgg.PggId,
				NgayNhap = DateTime.Now,
				PhiTruocGiamGia = giaGoc,
				GiamGia = (byte)(giamGiaFinal),
				PhiSauGiamGia =  giaGoc - (giaGoc * (giamGiaFinal / 100)),
			};


			DialogResult dialogResult = MessageBox.Show($"Giá gốc: {giaGoc}\n" +
				$"Phiếu giảm giá được áp dụng: {pgg.PhanTramGiamGia}% (Giá gốc > {pgg.GiaHoaDon})\n" +
				$"Loại khách hàng: {giamGiaLoaiKh}%\n" +
				$"Giá cuối cùng: {hdModel.PhiSauGiamGia}", "Xác nhận đặt cà phê", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				bool resultHd = repository.AddHoaDon(hdModel);
				bool resulCthd = repository.AddCthd(cthdList);

				if (!resultHd)
				{
					MessageBox.Show("Thêm hóa đơn thất bại!!!");
					return;
				}
				if (!resulCthd)
				{
					MessageBox.Show("Thêm chi tiết hóa đơn thất bại!!!");
				}

				if (resultHd && resulCthd)
				{
					MessageBox.Show("Đặt hàng thành công!!!");
					view.GioHangPanel.Controls.Clear();
				}
			}
			else if (dialogResult == DialogResult.No)
			{
				return;
			}

			
		}


		public IEnumerable<HoaDonModel> GetAllHoaDon(int idKhachHang)
		{
			return repository.GetAllHoaDon(idKhachHang);
		}
	}
}
