using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
    public class NguyenLieuPresenter
    {
        private INguyenLieuView view;
        private INguyenLieuRepository repository;
        private BindingSource nglBindingSource;
        private IEnumerable<NguyenLieuModel> NguyenLieuList;
        private string nguyenLieuImagePath;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public NguyenLieuPresenter(INguyenLieuView view, INguyenLieuRepository repository)
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
            this.view.ResetEvent += LoadNguyenLieuList;

            nglBindingSource = new BindingSource();
            LoadNguyenLieuList();
            GetNguyenLieuId();

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            var logoimage = Path.Combine(path, "image\\nguyenLieu");
            nguyenLieuImagePath = logoimage;
        }

        private void LoadNguyenLieuList()
        {
            NguyenLieuList = repository.GetAll();
            nglBindingSource.DataSource = NguyenLieuList;
            view.LoadData(nglBindingSource);
        }
        private void GetNguyenLieuId()
        {
            int txtIdNguyenLieu = repository.GetNextId();
            this.view.GetIdNguyenLieuAdd(txtIdNguyenLieu);
        }
        private void LoadNguyenLieuList(object sender, EventArgs e)
        {
            NguyenLieuList = repository.GetAll();
            nglBindingSource.DataSource = NguyenLieuList;
            view.LoadData(nglBindingSource);
        }
        private void AddClickEvent(object sender, EventArgs e)
        {
            this.view.setState(true, false, false, false);
            GetNguyenLieuId();
            this.view.SetNull();
        }
        public void UpdateClickEvent(object sender, EventArgs e)
        {
            this.view.setState(false, true, false, false);
            if (int.Parse(this.view.selectedId) != 0)
            {
                NguyenLieuModel ngl = repository.GetById(int.Parse(this.view.selectedId));
                this.view.SetTextBoxFillData(ngl);

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
                    NguyenLieuModel ngl = new NguyenLieuModel();
                    ngl.NguyenLieuId = int.Parse(this.view.NguyenLieuId);
                    ngl.TenNguyenLieu = this.view.TenNguyenLieu;
                    ngl.KhoiLuong = float.Parse(this.view.KhoiLuong);
                    ngl.GiaTien_Kg = float.Parse(this.view.GiaTien_Kg);
                    ngl.ThongTin = this.view.ThongTin;
                    ngl.HinhAnh = Image.FromFile(this.view.HinhAnh);
                    ngl.IsDelete = bool.Parse(this.view.IsDelete);

                    if (repository.Add(ngl))
                    {
                        MessageBox.Show("Success");
                    }
                    else
                        MessageBox.Show("Fail");

                    GetNguyenLieuId();
                    LoadNguyenLieuList();
                    this.view.SetNull();
                }
        }
        private void Filter(object sender, EventArgs e)
        {
            if (this.view.isFilter)
            {
                MessageBox.Show(this.view.HinhAnh);
                NguyenLieuList = repository.GetByValue(this.view.NguyenLieuId, this.view.TenNguyenLieu, this.view.ThongTin, this.view.KhoiLuong, this.view.GiaTien_Kg, this.view.HinhAnh, bool.Parse(this.view.IsDelete));
                nglBindingSource.DataSource = NguyenLieuList;
                view.LoadData(nglBindingSource);
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

                LoadNguyenLieuList();
            }
        }
        public void Update(object sender, EventArgs e)
        {
            if (this.view.isUpdate)
                if (this.view.CheckInput())
                {
                    NguyenLieuModel ngl = new NguyenLieuModel();
                    ngl.NguyenLieuId = int.Parse(this.view.NguyenLieuId);
                    ngl.TenNguyenLieu = this.view.TenNguyenLieu;
                    ngl.KhoiLuong = float.Parse(this.view.KhoiLuong);
                    ngl.GiaTien_Kg = float.Parse(this.view.GiaTien_Kg);
                    ngl.ThongTin = this.view.ThongTin;
                    ngl.IsDelete = bool.Parse(this.view.IsDelete);

                    if (repository.Update(ngl))
                    {
                        MessageBox.Show("Edit Success");
                        this.view.NguyenLieuId = ngl.NguyenLieuId.ToString();
                        this.view.TenNguyenLieu = ngl.TenNguyenLieu.ToString();
                        this.view.KhoiLuong = ngl.KhoiLuong.ToString();
                        this.view.GiaTien_Kg = ngl.GiaTien_Kg.ToString();
                        this.view.ThongTin = ngl.ThongTin.ToString();
                        this.view.IsDelete = ngl.IsDelete.ToString();
                    }
                    else
                        MessageBox.Show("Fail");
                    LoadNguyenLieuList();
                }
        }
    }
}
