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
    public partial class NhapHangView : Form, INhapHangView
    {
        public NhapHangView()
        {
            InitializeComponent();
            tcNhapHang.Appearance = TabAppearance.FlatButtons;
            tcNhapHang.ItemSize = new System.Drawing.Size(0, 1);
            tcNhapHang.SizeMode = TabSizeMode.Fixed;
        }

        private static NhapHangView instance;

        NhapHangPresenter INhapHangView.Presenter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static INhapHangView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new NhapHangView();
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            tcNhapHang.SelectedTab = listTabPage;
        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            tcNhapHang.SelectedTab = moreDetailTabPage;
        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            tcNhapHang.SelectedTab = detailTabPage;
        }

        public void LoadData(BindingSource list)
        {
            this.dgvDsNhapHang.DataSource = list;
        }

        public void GetIdNccAdd(int id)
        {
            this.txtPhieuNhapId.Texts = id.ToString();
        }

        private void btnAddPN_Click(object sender, EventArgs e)
        {
            tcNhapHang.SelectedTab = detailTabPage;
        }
    }
}
