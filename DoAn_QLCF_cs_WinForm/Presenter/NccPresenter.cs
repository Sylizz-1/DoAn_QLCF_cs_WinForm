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

            this.view.AddNccEvent += AddNcc;
            this.view.DeleteNccEvent += DeleteNcc;
            this.view.FilterNccEvent += FilterNcc;
            this.view.UpdateNccEvent += UpdateNcc;
            this.view.btnAddNccClickEvent += AddNccClickEvent;
            this.view.btnUpdateNccClickEvent += UpdateNccClickEvent;
            this.view.btnFilterNccClickEvent += FilterNccClickEvent;
            this.view.ResetEvent += LoadNccList;
            this.view.FindNccEvent += FindNcc;

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
        private void AddNccClickEvent(object sender, EventArgs e)
        {
            this.view.setState(true, false, false, false);
            GetNccId();
            this.view.SetNull();
        }
        public void UpdateNccClickEvent(object sender, EventArgs e)
        {
            this.view.setState(false, true, false, false);
            if (int.Parse(this.view.NCCcount) > 0)
            {
                if (this.view.selectedId != "0")
                {
                    NccModel ncc = repository.GetById(int.Parse(this.view.selectedId));
                    this.view.SetTextBoxFillData(ncc);
                }
                else
                    MessageBox.Show("Vui lòng chọn phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Danh sách rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FilterNccClickEvent(object sender, EventArgs e)
        {
            this.view.setState(false, false, true, true);
        }
        private void AddNcc(object sender, EventArgs e)
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
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    GetNccId();
                    LoadNccList();
                    this.view.SetNull();
                }
        }
        private void FilterNcc(object sender, EventArgs e)
        {
            if (this.view.isFilter)
            {
                nccList = repository.GetByValue(this.view.NhaCungCapId, this.view.TenNhaCungCap, this.view.DiaChi, this.view.SDT, this.view.Email, bool.Parse(this.view.IsDelete));
                cpBindingSource.DataSource = nccList;
                view.LoadData(cpBindingSource);
            }
            this.view.isFilter = false;
        }
        public void DeleteNcc(object sender, EventArgs e)
        {
            MessageBox.Show(this.view.selectedId);
            if (int.Parse(this.view.NCCcount) > 0)
            {
                if(this.view.selectedId != "0")
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cấp", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        if (repository.Delete(int.Parse(this.view.selectedId)))
                        {
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadNccList();
                    }
                }
                else
                    MessageBox.Show("Vui lòng chọn nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Danh sách rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void UpdateNcc(object sender, EventArgs e)
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
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.view.NhaCungCapId = ncc.NhaCungCapId.ToString();
                        this.view.TenNhaCungCap = ncc.TenNhaCungCap.ToString();
                        this.view.SDT = ncc.SDT.ToString();
                        this.view.Email = ncc.Email.ToString();
                        this.view.DiaChi = ncc.DiaChi.ToString();
                        this.view.IsDelete = ncc.IsDelete.ToString();
                    }
                    else
                        MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadNccList();
                }
        }
        private void FindNcc(object sender, EventArgs e)
        {
            nccList = repository.FindNccByNameOrId(this.view.FindText);
            cpBindingSource.DataSource = nccList;
            view.LoadData(cpBindingSource);
            this.view.FindText = "";
        }
    }
}