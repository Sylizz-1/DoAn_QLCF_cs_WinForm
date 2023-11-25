using DoAn_QLCF_cs_WinForm.Model;
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
    public partial class NguyenLieuView : Form, INguyenLieuView
    {


        public NguyenLieuView()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private static NguyenLieuView instance;

        NguyenLieuPresenter INguyenLieuView.Presenter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string INguyenLieuView.Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string INguyenLieuView.SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string INguyenLieuView.NguyenLieuId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int INguyenLieuView.selectedId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static INguyenLieuView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new NguyenLieuView();
                instance.TopLevel = false;
                parentContainer.Controls.Add(instance);
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;

            }
            instance.Show();
            return instance;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = detailTabPage;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = listTabPage;
        }

        void INguyenLieuView.LoadData(BindingSource list)
        {
            throw new NotImplementedException();
        }

        void INguyenLieuView.GetIdNguyenLieuAdd(int id)
        {
            throw new NotImplementedException();
        }

        NguyenLieuModel INguyenLieuView.AddNguyenLieu()
        {
            throw new NotImplementedException();
        }
    }
}
