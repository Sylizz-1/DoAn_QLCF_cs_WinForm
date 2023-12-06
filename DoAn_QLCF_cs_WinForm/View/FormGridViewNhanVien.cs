using DoAn_QLCF_cs_WinForm.Presenter;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class FormGridViewNhanVien : Form, INhanVienView
    {
        public FormGridViewNhanVien()
        {
            InitializeComponent();
        }

        public string IdNhanVien { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NameNhanVien { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PhoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string GioiTinh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NgaySinh { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Username { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PasswordConfirm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Permission { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DataGridView DataGridView { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler AddBtnEvent;
        public event EventHandler EditBtnEvent;
        public event EventHandler DeleteBtnEvent;
        public event EventHandler AcceptBtnEvent;
        public event EventHandler CancelBtnEvent;

        public void GetIdNhanVien(int id)
        {
            throw new NotImplementedException();
        }

        public void GetQuyenNhanVien(List<string> quyenList)
        {
            throw new NotImplementedException();
        }

        public void LoadData(BindingSource list)
        {
            this.dataGridView1.DataSource = list;
        }

        public void LoadQuyen(BindingSource listQuyen)
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
