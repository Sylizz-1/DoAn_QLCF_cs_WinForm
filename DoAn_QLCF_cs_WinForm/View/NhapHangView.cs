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
    public partial class NhapHangView : Form, INhapHangView
    {
        public NhapHangView()
        {
            InitializeComponent();
            tcNhapHang.Appearance = TabAppearance.FlatButtons;
            tcNhapHang.ItemSize = new System.Drawing.Size(0, 1);
            tcNhapHang.SizeMode = TabSizeMode.Fixed;
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private static NhapHangView instance;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

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

        public void LoadDataPN(BindingSource list)
        {
            this.dgvDsNhapHang.DataSource = list;
        }
        public void LoadDataCTPN(BindingSource list)
        {
            this.dgvCTPN.DataSource = list;
        }
        public void LoadDataNV(BindingSource list)
        {
            List<string> name = new List<string> ();
            List<string> id = new List<string>();
            foreach (NhanVienModel nv in list)
            {
                name.Add(nv.Name);
                id.Add(nv.Id.ToString());
            }    
        }
        public void LoadDataNCC(BindingSource list)
        {
            this.dgvCTPN.DataSource = list;
        }

        public void GetIdPNAdd(int id)
        {
            this.txtPhieuNhapId.Texts = id.ToString();
        }

        private void btnAddPN_Click(object sender, EventArgs e)
        {
            tcNhapHang.SelectedTab = detailTabPage;
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
    }
}
