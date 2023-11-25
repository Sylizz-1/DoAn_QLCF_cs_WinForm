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


        public NccPresenter(INccView view, INccRepository repository)
        {
            this.view = view;
            this.repository = repository;

            this.view.AddEvent += Add;
            this.view.DeleteEvent += Delete;
            this.view.btnUpdateClickEvent += UpdateClickEvent;
            this.view.UpdateEvent += Update;
            this.view.btnAddClickEvent += AddClickEvent;

            cpBindingSource = new BindingSource();
            LoadNccList();
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
            GetNccId();
            this.view.SetNull();
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
        public void UpdateClickEvent(object sender, EventArgs e)
        {
            if (int.Parse(this.view.selectedId) != 0)
            {
                NccModel ncc = repository.GetById(int.Parse(this.view.selectedId));
                this.view.NhaCungCapId = this.view.selectedId;
                this.view.TenNhaCungCap = ncc.TenNhaCungCap.ToString();
                this.view.SDT = ncc.SDT.ToString();
                this.view.Email = ncc.Email.ToString();
                this.view.DiaChi = ncc.DiaChi.ToString();
                this.view.IsDelete = ncc.IsDelete.ToString();
            }
        }
        public void Update(object sender, EventArgs e)
        {
            if (!this.view.isAdd)
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
                        this.view.NhaCungCapId = this.view.selectedId;
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