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

        public NguyenLieuPresenter(INguyenLieuView view, INguyenLieuRepository repository)
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
            this.view.ResetEvent += LoadNguyenLieuList;
            this.view.FindNglEvent += FindNgl;

            nglBindingSource = new BindingSource();
            LoadNguyenLieuList();
            GetNguyenLieuId();

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
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
            if (int.Parse(this.view.Nglcount) > 0)
            {
                if (this.view.selectedId != "0")
                {
                    NguyenLieuModel ngl = repository.GetById(int.Parse(this.view.selectedId));
                    this.view.SetTextBoxFillData(ngl);
                }
                else
                    MessageBox.Show("Vui lòng chọn nguyên liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Danh sách rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ngl.HinhAnh = this.view.HinhAnh;
                    ngl.IsDelete = bool.Parse(this.view.IsDelete);

                    if (repository.Add(ngl))
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    GetNguyenLieuId();
                    LoadNguyenLieuList();
                    this.view.SetNull();
                }
        }
        private void Filter(object sender, EventArgs e)
        {
            if (this.view.isFilter)
            {
                NguyenLieuList = repository.GetByValue(this.view.NguyenLieuId, this.view.TenNguyenLieu, this.view.ThongTin, this.view.KhoiLuong, this.view.GiaTien_Kg, this.view.HinhAnh, bool.Parse(this.view.IsDelete));
                nglBindingSource.DataSource = NguyenLieuList;
                view.LoadData(nglBindingSource);
            }
            this.view.isFilter = false;
        }
        public void Delete(object sender, EventArgs e)
        {
            if (int.Parse(this.view.Nglcount) > 0)
            {
                if (this.view.selectedId != "0")
                {
                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa nguyên liệu", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        if (repository.Delete(int.Parse(this.view.selectedId)))
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        LoadNguyenLieuList();
                    }
                }
                else
                    MessageBox.Show("Vui lòng chọn nguyên liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Danh sách rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    ngl.HinhAnh = this.view.HinhAnh;
                    ngl.IsDelete = bool.Parse(this.view.IsDelete);

                    DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa nguyên liệu", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        if (repository.Update(ngl))
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.view.NguyenLieuId = ngl.NguyenLieuId.ToString();
                            this.view.TenNguyenLieu = ngl.TenNguyenLieu.ToString();
                            this.view.KhoiLuong = ngl.KhoiLuong.ToString();
                            this.view.GiaTien_Kg = ngl.GiaTien_Kg.ToString();
                            this.view.ThongTin = ngl.ThongTin.ToString();
                            this.view.IsDelete = ngl.IsDelete.ToString();
                            this.view.HinhAnh = Path.Combine(this.nguyenLieuImagePath, ngl.HinhAnh.ToString());
                        }
                        else
                            MessageBox.Show("Sửa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadNguyenLieuList();
                }
        }
        private void FindNgl(object sender, EventArgs e)
        {
            NguyenLieuList = repository.FindNglByNameOrId(this.view.FindText);
            nglBindingSource.DataSource = NguyenLieuList;
            view.LoadData(nglBindingSource);
            this.view.FindText = "";
        }
    }
}
