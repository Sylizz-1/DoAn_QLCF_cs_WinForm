using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections;
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
        private static PhanQuyenView instance;
        public PhanQuyenView()
        {
            InitializeComponent();
            //SetUpView();   
            BindingEvents();            
        }
        public DataGridView PermissionDataGridView
        {
            get
            {
                return this.dtgrv_quyen;
            }
            set
            {

                this.dtgrv_quyen = value;
            }
        }

        public string IdPermission
        {
            get
            {
                return this.txt_idPermission.Texts;
            }
            set
            {
                this.txt_idPermission.Focus();
                this.txt_idPermission.Texts = value;
            }
        }
        public string NamePermission
        {
            get
            {
                return this.txt_namePermission.Texts;
            }
            set
            {
                this.txt_namePermission.Focus();
                this.txt_namePermission.Texts = value;
            }
        }
        public string ContentPermission
        {
            get
            {
                return this.txt_contentPermission.Texts;
            }
            set
            {
                this.txt_contentPermission.Focus();
                this.txt_contentPermission.Texts = value;
            }
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
        private void BindingEvents()
        {
            btn_editPermission.Click += delegate { EditPermissionBtnEvent?.Invoke(this, EventArgs.Empty); };

        }     
        public void LoadData(BindingSource listPermission, BindingSource listMethod)
        {
            this.dtgrv_quyen.DataSource = listPermission;
            this.dtgrv_chucNang.DataSource = listMethod;
        }

        public void LoadChucNangListCheckBox(BindingSource listMethod, ArrayList arrMethod)
        {
            ((ListBox)this.clb_chucNang).DataSource = listMethod;
            ((ListBox)this.clb_chucNang).DisplayMember = "NameMethod";
            ((ListBox)this.clb_chucNang).ValueMember = "IdMethod";

            for (int i = 0; i < clb_chucNang.Items.Count; i++)
            {
                ChucNangModel obj = (ChucNangModel)clb_chucNang.Items[i];
                if (arrMethod.Contains(obj.IdMethod))
                {
                    clb_chucNang.SetItemChecked(i, true);
                }
                else
                {
                    clb_chucNang.SetItemChecked(i, false);
                }                    
            }
        }

        public event EventHandler AddPermissionBtnEvent;
        public event EventHandler EditPermissionBtnEvent;
        public event EventHandler DeletePermissionBtnEvent;
        public event EventHandler DetailPermissionBtnEvent;
        public event EventHandler AcceptPermissionBtnEvent;
        public event EventHandler CancelPermissionBtnEvent;

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

        private void btn_editPermission_Click(object sender, EventArgs e)
        {
            this.tc_quyen.SelectedTab = this.tp_quyenChiTiet;
        }

        private void btn_backPermission_Click(object sender, EventArgs e)
        {
            this.tc_quyen.SelectedTab = this.tp_quyenDanhSach;
        }
    }
}
