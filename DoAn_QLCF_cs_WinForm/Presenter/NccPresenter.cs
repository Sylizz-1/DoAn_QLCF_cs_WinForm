using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
    public class NccPresenter
    {
        private INccView view;
        private INccRepository repository;
        private BindingSource cpBindingSource;
        private IEnumerable<NccModel> nccList;


#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public NccPresenter(INccView view, INccRepository repository)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            this.view = view;
            this.repository = repository;

#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            this.view.AddEvent += Add;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            this.view.DeleteEvent += Delete;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            this.view.FilterEvent += Filter;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            this.view.UpdateEvent += Update;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            this.view.btnAddClickEvent += AddClickEvent;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            this.view.btnUpdateClickEvent += UpdateClickEvent;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            this.view.btnFilterClickEvent += FilterClickEvent;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            this.view.ResetEvent += LoadNccList;
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).

            cpBindingSource = new BindingSource();
            LoadNccList();
        }
        private void LoadNccList(object sender, EventArgs e)
        {
            nccList = repository.GetAll();
            cpBindingSource.DataSource = nccList;
            view.LoadData(cpBindingSource);
        }
        private void LoadNccList()
        {
            nccList = repository.GetAll();
            cpBindingSource.DataSource = nccList;
            view.LoadData(cpBindingSource);
        }
        private void GetNccId()
        {
            int txtIdNcc = repository.GetNextId();
            view.GetIdNccAdd(txtIdNcc);
        }
        private void AddClickEvent(object sender, EventArgs e)
        {
            this.view.setState(true, false, false, false);
            GetNccId();
            this.view.SetNull();
        }
        public void UpdateClickEvent(object sender, EventArgs e)
        {
            this.view.setState(false, true, false, false);
            if (int.Parse(this.view.selectedId) != 0)
            {
                NccModel ncc = repository.GetById(int.Parse(this.view.selectedId));
                this.view.SetTextBoxFillData(ncc);

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
                    NccModel ncc = new NccModel();
                    ncc.NhaCungCapId = int.Parse(this.view.NhaCungCapId);
                    ncc.TenNhaCungCap = this.view.TenNhaCungCap;
                    ncc.SDT = this.view.SDT;
                    ncc.Email = this.view.Email;
                    ncc.DiaChi = this.view.DiaChi;
                    ncc.IsDelete = bool.Parse(this.view.IsDelete);

                    if (repository.Add(ncc))
                    {
                        MessageBox.Show("Success");
                    }
                    else
                        MessageBox.Show("Fail");

                    GetNccId();
                    LoadNccList();
                    this.view.SetNull();
                }
        }
        private void Filter(object sender, EventArgs e)
        {
            if (this.view.isFilter)
            {
                nccList = repository.GetByValue(this.view.NhaCungCapId, this.view.TenNhaCungCap, this.view.DiaChi, this.view.SDT, this.view.Email, bool.Parse(this.view.IsDelete));
                cpBindingSource.DataSource = nccList;
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

                LoadNccList();
            }
        }
        public void Update(object sender, EventArgs e)
        {
            if (this.view.isUpdate)
                if (this.view.CheckInput())
                {
                    NccModel ncc = new NccModel();
                    ncc.NhaCungCapId = int.Parse(this.view.NhaCungCapId);
                    ncc.TenNhaCungCap = this.view.TenNhaCungCap;
                    ncc.SDT = this.view.SDT;
                    ncc.Email = this.view.Email;
                    ncc.DiaChi = this.view.DiaChi;
                    ncc.IsDelete = bool.Parse(this.view.IsDelete);

                    if (repository.Update(ncc))
                    {
                        MessageBox.Show("Edit Success");
                        this.view.NhaCungCapId = ncc.NhaCungCapId.ToString();
                        this.view.TenNhaCungCap = ncc.TenNhaCungCap.ToString();
                        this.view.SDT = ncc.SDT.ToString();
                        this.view.Email = ncc.Email.ToString();
                        this.view.DiaChi = ncc.DiaChi.ToString();
                        this.view.IsDelete = ncc.IsDelete.ToString();
                    }
                    else
                        MessageBox.Show("Fail");
                    LoadNccList();
                }
        }
    }
}