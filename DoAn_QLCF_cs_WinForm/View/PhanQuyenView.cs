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
    public partial class PhanQuyenView : Form, IPhanQuyenView
    {
        public PhanQuyenView()
        {
            InitializeComponent();
            //SetUpView();

            CheckBox t = new CheckBox();            
            clb_chucNang.Items.Add("abc");


        }

        private void SetUpView()
        {
            // ẩn các tab control
            tc_chucNang.Appearance = TabAppearance.FlatButtons;
            tc_chucNang.ItemSize = new System.Drawing.Size(0, 1);
            tc_chucNang.SizeMode = TabSizeMode.Fixed;
            tc_quyen.Appearance = TabAppearance.FlatButtons;
            tc_quyen.ItemSize = new System.Drawing.Size(0, 1);
            tc_quyen.SizeMode = TabSizeMode.Fixed;
        }

        public void LoadData(BindingSource listPermission, BindingSource listMethod)
        {
            this.dtgrv_quyen.DataSource = listPermission;
            this.dtgrv_chucNang.DataSource = listMethod;
        }



        private static PhanQuyenView instance;
        public static IPhanQuyenView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new PhanQuyenView();
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
    }
}
