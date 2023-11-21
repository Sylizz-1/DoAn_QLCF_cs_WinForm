using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
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
    public partial class PggView : Form, IPggView
    {
        public PggView()
        {
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private static PggView instance;
        public static IPggView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new PggView();
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
    }
}
