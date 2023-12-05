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

        public NhanVienPresenter Presenter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
    }
}
