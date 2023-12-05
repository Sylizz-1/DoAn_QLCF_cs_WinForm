using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
    public class PggPresenter
    {
        private IPggView view;
        private IPggRepository repository;
        private BindingSource cpBindingSource;
        private IEnumerable<PggModel> pggList;

        public PggPresenter(IPggView view, IPggRepository repository)

        {
            this.view = view;
            this.repository = repository;

            this.view.AddEvent += Add;

            this.view.DeleteEvent += Delete;

            this.view.FilterEvent += Filter;

            this.view.UpdateEvent += Update;

            this.view.btnAddClickEvent += AddClickEvent;

            this.view.btnUpdateClickEvent += UpdateClickEvent;

            this.view.btnFilterClickEvent += FilterClickEvent;

            this.view.ResetEvent += LoadPggList;


            cpBindingSource = new BindingSource();
            LoadPggList();
        }
        private void LoadPggList(object sender, EventArgs e)
        {
            pggList = repository.GetAll();
            cpBindingSource.DataSource = pggList;
            view.LoadData(cpBindingSource);
        }
        private void LoadPggList()
        {
            pggList = repository.GetAll();
            cpBindingSource.DataSource = pggList;
            view.LoadData(cpBindingSource);
        }
        private void GetPggId()
        {
            int txtIdPgg = repository.GetNextId();
            view.GetIdPggAdd(txtIdPgg);
        }
        private void AddClickEvent(object sender, EventArgs e)
        {
            this.view.setState(true, false, false, false);
            GetPggId();
            this.view.SetNull();
        }
        public void UpdateClickEvent(object sender, EventArgs e)
        {
            this.view.setState(false, true, false, false);
            if (int.Parse(this.view.selectedId) != 0)
            {
                PggModel Pgg = repository.GetById(int.Parse(this.view.selectedId));
                this.view.SetTextBoxFillData(Pgg);

            }
        }
        private void FilterClickEvent(object sender, EventArgs e)
        {
            this.view.setState(false, false, true, true);
        }
        private void Add(object sender, EventArgs e)
        {
            if (this.view.isAdd)
                if (this.view.CheckInput())
                {
                    PggModel Pgg = new PggModel();
                    Pgg.PggId = int.Parse(this.view.PggId);

                    // Check if TgBatDau is not empty before parsing
                    if (!string.IsNullOrEmpty(this.view.TgBatDau))
                        Pgg.TgBatDau = DateTime.Parse(this.view.TgBatDau);

                    // Check if TgKetThuc is not empty before parsing
                    if (!string.IsNullOrEmpty(this.view.TgKetThuc))
                        Pgg.TgKetThuc = DateTime.Parse(this.view.TgKetThuc);

                    // Check if GiaHoaDon is not empty before parsing
                    if (!string.IsNullOrEmpty(this.view.GiaHoaDon))
                        Pgg.GiaHoaDon = float.Parse(this.view.GiaHoaDon);

                    // Check if PhanTramGiamGia is not empty before parsing
                    if (!string.IsNullOrEmpty(this.view.PhanTramGiamGia))
                        Pgg.PhanTramGiamGia = byte.Parse(this.view.PhanTramGiamGia);

                    Pgg.IsDelete = bool.Parse(this.view.IsDelete);

                    if (repository.Add(Pgg))
                    {
                        MessageBox.Show("Success");
                    }
                    else
                        MessageBox.Show("Fail");

                    GetPggId();
                    LoadPggList();
                    this.view.SetNull();
                }
        }
        private void Filter(object sender, EventArgs e)
        {
            if (this.view.isFilter)
            {
                pggList = repository.GetByValue(int.Parse(this.view.PggId), DateTime.Parse(this.view.TgBatDau), DateTime.Parse(this.view.TgKetThuc), float.Parse(this.view.GiaHoaDon), byte.Parse(this.view.PhanTramGiamGia), bool.Parse(this.view.IsDelete));
                cpBindingSource.DataSource = pggList;
                view.LoadData(cpBindingSource);
            }
            this.view.isFilter = false;
        }
        public void Delete(object sender, EventArgs e)
        {
            if (int.Parse(this.view.selectedId) != 0)
            {
                if (repository.Delete(int.Parse(this.view.selectedId)))
                {
                    MessageBox.Show("Delete Success");
                }
                else
                    MessageBox.Show("Delete Fail");

                LoadPggList();
            }
        }
        private void Update(object sender, EventArgs e)
        {
            if (this.view.isUpdate)
                if (this.view.CheckInput())
                {
                    PggModel Pgg = new PggModel();
                    Pgg.PggId = int.Parse(this.view.PggId);

                    // Check if TgBatDau is not empty before parsing
                    if (!string.IsNullOrEmpty(this.view.TgBatDau))
                        Pgg.TgBatDau = DateTime.Parse(this.view.TgBatDau);

                    // Check if TgKetThuc is not empty before parsing
                    if (!string.IsNullOrEmpty(this.view.TgKetThuc))
                        Pgg.TgKetThuc = DateTime.Parse(this.view.TgKetThuc);

                    // Check if GiaHoaDon is not empty before parsing
                    if (!string.IsNullOrEmpty(this.view.GiaHoaDon))
                        Pgg.GiaHoaDon = float.Parse(this.view.GiaHoaDon);

                    // Check if PhanTramGiamGia is not empty before parsing
                    if (!string.IsNullOrEmpty(this.view.PhanTramGiamGia))
                        Pgg.PhanTramGiamGia = byte.Parse(this.view.PhanTramGiamGia);

                    Pgg.IsDelete = bool.Parse(this.view.IsDelete);

                    if (repository.Update(Pgg))
                    {
                        MessageBox.Show("Edit Success");
                        this.view.PggId = Pgg.PggId.ToString();
                        this.view.TgBatDau = Pgg.TgBatDau.ToString();
                        this.view.TgKetThuc = Pgg.TgKetThuc.ToString();
                        this.view.GiaHoaDon = Pgg.GiaHoaDon.ToString();
                        this.view.PhanTramGiamGia = Pgg.PhanTramGiamGia.ToString();
                        this.view.IsDelete = Pgg.IsDelete.ToString();
                    }
                    else
                        MessageBox.Show("Fail");
                    LoadPggList();
                }
        }
    }
}
