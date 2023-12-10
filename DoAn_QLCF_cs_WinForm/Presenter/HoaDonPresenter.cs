using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
    public class HoaDonPresenter
    {
        private IHoaDonView view;
        private IHoaDonRepository repository;
        private BindingSource cpBindingSource;
        private IEnumerable<HoaDonModel> hdList;
        private IEnumerable<ChiTietHoaDonModel> cthdList;

        public HoaDonPresenter(IHoaDonView view, IHoaDonRepository repository)
        {
            this.view = view;
            this.repository = repository;

            this.view.UpdateEvent += Update_HD;

            this.view.btnUpdateClickEvent += UpdateClickEvent;

            this.view.XacNhanEvent += XacNhan;

            this.view.ResetEvent += LoadHDList;

            //this.view.ResetEvent += LoadCTHDList;


            cpBindingSource = new BindingSource();

            LoadHDList();

            //LoadCTHDList();
        }

        private void XacNhan(object? sender, EventArgs e)
        {
            HoaDonRepository repo = new HoaDonRepository(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            HoaDonModel model = (HoaDonModel)this.view.DataGridView.CurrentRow.DataBoundItem;
            if (repo.XacNhan(model))
            {
                MessageBox.Show("Xác nhận hóa đơn thành công!");
                LoadHDList();
            }
            else
            {
                MessageBox.Show("Xác nhận hóa đơn thất bại!");
            }
        }

        private void LoadHDList(object sender, EventArgs e)
        {
            hdList = repository.GetAll();
            cpBindingSource.DataSource = hdList;
            view.LoadData(cpBindingSource);
        }
        private void LoadHDList()
        {
            hdList = repository.GetAll();
            cpBindingSource.DataSource = hdList;
            view.LoadData(cpBindingSource);
        }
        private void LoadCTHDList(object sender, EventArgs e)
        {
            cthdList = repository.GetAll_CT();
            cpBindingSource.DataSource = cthdList;
            view.LoadData_CT(cpBindingSource);
        }
        private void LoadCTHDList()
        {
            cthdList = repository.GetAll_CT();
            cpBindingSource.DataSource = cthdList;
            view.LoadData_CT(cpBindingSource);
        }
        public void UpdateClickEvent(object sender, EventArgs e)
        {
            this.view.setState(false, true, false, false);
            if (int.Parse(this.view.selectedId) != 0)
            {
                HoaDonModel Hd = repository.GetById(int.Parse(this.view.selectedId));
                this.view.SetTextBoxFillData(Hd);

            }
        }

        private void Update_HD(object sender, EventArgs e)
        {
            if (this.view.isUpdate)
            {
                HoaDonModel Hd = new HoaDonModel();
                Hd.HoaDonId = int.Parse(this.view.HoaDonId);
                Hd.NhanVienId = int.Parse(this.view.NhanVienId);
                Hd.KhachHangId = int.Parse(this.view.KhachHangId);
                Hd.PggId = int.Parse(this.view.PggId);

                if (!string.IsNullOrEmpty(this.view.NgayNhap))
                    Hd.NgayNhap = DateTime.Parse(this.view.NgayNhap);

                if (!string.IsNullOrEmpty(this.view.PhiTruocGiamGia))
                    Hd.PhiTruocGiamGia = float.Parse(this.view.PhiTruocGiamGia);

                if (!string.IsNullOrEmpty(this.view.GiamGia))
                    Hd.GiamGia = byte.Parse(this.view.GiamGia);

                if (!string.IsNullOrEmpty(this.view.PhiSauGiamGia))
                    Hd.PhiSauGiamGia = float.Parse(this.view.PhiSauGiamGia);

                Hd.IsAccepted = bool.Parse(this.view.IsAccepted);

                if (repository.Update(Hd))
                {
                    MessageBox.Show("Edit Success");
                    this.view.HoaDonId = Hd.HoaDonId.ToString();
                    this.view.NhanVienId = Hd.NhanVienId.ToString();
                    this.view.KhachHangId = Hd.KhachHangId.ToString();
                    this.view.PggId = Hd.PggId.ToString();
                    this.view.NgayNhap = Hd.NgayNhap.ToString();
                    this.view.PhiTruocGiamGia = Hd.PhiTruocGiamGia.ToString();
                    this.view.GiamGia = Hd.GiamGia.ToString();
                    this.view.PhiSauGiamGia = Hd.PhiSauGiamGia.ToString();
                    this.view.IsAccepted = Hd.IsAccepted.ToString();
                }
                else
                    MessageBox.Show("Fail");
                LoadHDList();
            }
        }

        public void XacNhan()
        {
            
        }

       
    }
}
