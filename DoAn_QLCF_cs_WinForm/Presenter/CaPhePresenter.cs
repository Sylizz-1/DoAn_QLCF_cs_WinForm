using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
	public class CaPhePresenter
	{
		private ICaPheView view;
		private ICaPheRepository repository;
		private BindingSource cpBindingSource;
		private IEnumerable<CaPheModel> caPheList;

		private BindingSource cpnlBindingSource;
		private IEnumerable<CaPheNguyenLieuModel> cpnlList;

		public CaPhePresenter(ICaPheView view, ICaPheRepository repository)
		{
			this.view = view;
			this.repository = repository;
			cpBindingSource = new BindingSource();
			cpnlBindingSource = new BindingSource();
			BindingEvents();
			LoadCaPheList();
			LoadNguyenLieuCbx();
		}

		private void LoadCaPheList ()
		{
			caPheList = repository.GetAll();
			cpBindingSource.DataSource = caPheList;
			view.LoadData(cpBindingSource);
		}

		private void LoadNguyenLieuCbx()
		{
			IEnumerable<NguyenLieuModel> nlList = repository.GetAllNguyenLieu();
			BindingSource bs = new BindingSource();
			bs.DataSource = nlList;
			this.view.LoadNguyenLieuCbx(bs);

		}

		private void GetNguyenLieuOfCaPhe(int caPheId)
		{
			cpnlList = repository.GetNguyenLieuOfCaPhe(caPheId);
			cpnlBindingSource.DataSource = cpnlList;

			this.view.LoadCpnlList(cpnlBindingSource);
		}

		private void BindingEvents()
		{
			
			this.view.AddBtnEvent += Add;
			this.view.EditBtnEvent += Edit;
			this.view.SearchTxtEvent += SearchChange;
			this.view.DeleteBtnEvent += Delete;
			this.view.AcceptBtnEvent += Accept;

			this.view.AddNlBtnEvent += AddNguyenLieu;
			this.view.EditNlBtnEvent += EditNguyenLieu;
			this.view.DeleteNlBtnEvent += DeleteNguyenLieu;
		}

		private void Accept(object? sender, EventArgs e)
		{
			int id  = (repository.GetLastId());
			string ten, mieuTa = this.view.MieuTaTxt, xuatXu = this.view.XuatXuTxt;
			float gia;
			Image hinhAnh;
			bool isDeleted;
			List<CaPheNguyenLieuModel> cpnlList;
			
			if (this.view.TenTxt == "")
			{
				MessageBox.Show("Tên không được để trống!!!");
				return;
			}

			if(!float.TryParse(this.view.GiaTienTxt,out gia) || this.view.GiaTienTxt == "")
			{
				MessageBox.Show("Giá tiền phải là số và không được để trống!!!");
				return;
			}

			if (this.view.CaPheImage.Tag == null)
			{
				MessageBox.Show("Hình ảnh là bắt buộc!!!");
				return;
			}

			ten = this.view.TenTxt;
			hinhAnh = this.view.CaPheImage;
			isDeleted = this.view.IsDeleted;
			cpnlList = (List<CaPheNguyenLieuModel>)cpnlBindingSource.List;

			CaPheModel cpModel = new CaPheModel()
			{
				Id = ++id,
				HinhAnh = hinhAnh,
				Ten = ten,
				Gia = gia,
				MieuTa = mieuTa,
				XuatXu = xuatXu,
				IsDeleted = isDeleted
			};

			if (!this.view.IsEdited)
			{
				bool result = repository.Add(cpModel);
				bool result2 = repository.UpdateChiTietNguyenLieu(id, cpnlList);
				if (!result)
				{
					MessageBox.Show("Thêm thất bại!!!");
				}
				if(!result2)
				{
					MessageBox.Show("Cập nhật chi tiết nguyên liệu cho cà phê thất bại!!!");
				}
				return;
			}
		}
		
		private void Delete(object? sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void SearchChange(object? sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void Edit(object? sender, EventArgs e)
		{
			CaPheModel cpModel = (CaPheModel)this.view.CaPheDg.CurrentRow.DataBoundItem;
			this.view.CapheId = cpModel.Id.ToString();
			this.view.MieuTaTxt = cpModel.MieuTa;
			this.view.GiaTienTxt = cpModel.Gia.ToString();
			this.view.TenTxt = cpModel.Ten;
			this.view.XuatXuTxt = cpModel.XuatXu;
			this.view.IsDeleted = cpModel.IsDeleted;
			this.view.CaPheImage = cpModel.HinhAnh;

			this.GetNguyenLieuOfCaPhe(cpModel.Id);

		}

		private void Add(object? sender, EventArgs e)
		{
			int lastId = repository.GetLastId();
			this.view.CapheId = (++lastId).ToString();
			this.view.MieuTaTxt = "";
			this.view.GiaTienTxt = "";
			this.view.TenTxt = "";
			this.view.XuatXuTxt = "";
			this.view.IsDeleted = false;
			this.view.CaPheImage = Properties.Resources.defaultImage3;
			this.GetNguyenLieuOfCaPhe(++lastId);

		}

		private void AddNguyenLieu(object? sender, EventArgs e)
		{
			NguyenLieuModel nlModel = (NguyenLieuModel)this.view.NguyenLieuCbx.SelectedValue;
			CaPheModel cpModel = (CaPheModel)this.view.CaPheDg.CurrentRow.DataBoundItem;

			foreach(CaPheNguyenLieuModel cpnl in cpnlBindingSource)
			{
				if(cpnl.NguyenLieuId == nlModel.NguyenLieuId)
				{
					MessageBox.Show("Nguyên liệu đã có trong danh sách!!!");
					return;
				}
			}

			float khoiLuong;
			if (!float.TryParse(this.view.KhoiLuongTxt,out khoiLuong))
			{
				MessageBox.Show("Khối lượng phải nhập số!!!");
				return;
			}

			CaPheNguyenLieuModel cpnlModel = new CaPheNguyenLieuModel()
			{
				CaPheId = cpModel.Id,
				NguyenLieuId = nlModel.NguyenLieuId,
				HinhAnh = nlModel.HinhAnh,
				TenNguyenLieu = nlModel.TenNguyenLieu,
				KhoiLuong = khoiLuong
			};

			cpnlBindingSource.Add(cpnlModel);

		}

		private void EditNguyenLieu(object? sender, EventArgs e)
		{
			NguyenLieuModel nlModel = (NguyenLieuModel)this.view.NguyenLieuCbx.SelectedValue;
			float khoiLuong;
			int index = 0;
			if (!float.TryParse(this.view.KhoiLuongTxt, out khoiLuong))
			{
				MessageBox.Show("Khối lượng phải nhập số!!!");
				return;
			}

			foreach (CaPheNguyenLieuModel cpnl in cpnlBindingSource)
			{
				if (cpnl.NguyenLieuId == nlModel.NguyenLieuId)
				{
					cpnl.KhoiLuong = khoiLuong;
					cpnlBindingSource.ResetItem(index);
					return;
				}
				index++;
			}

			MessageBox.Show("Không có nguyên liệu trong danh sách để sửa!!!");
		}

		private void DeleteNguyenLieu(object? sender, EventArgs e)
		{
			CaPheNguyenLieuModel cpnlModel = (CaPheNguyenLieuModel)this.view.CpnlList2.CurrentRow?.DataBoundItem;
			if (cpnlModel != null)
				cpnlBindingSource.Remove(cpnlModel);
		}

	}
}
