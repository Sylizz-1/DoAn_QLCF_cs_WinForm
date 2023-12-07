using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            SetUpView();
            BindingEvents();
        }


        public string IdPermission
        {
            get
            {
                return this.txt_idPermission.Tag.ToString();
            }
            set
            {
                this.txt_idPermission.Focus();
                this.txt_idPermission.Texts = value;
                this.txt_idPermission.Tag = value;
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
        public DataGridView PermissionEmployeeDataGridView
        {
            get
            {
                return this.dtgrv_nhanVien;
            }
            set
            {

                this.dtgrv_nhanVien = value;
            }
        }
        public DataGridView PermissionDetailDataGridView
        {
            get
            {
                return this.dtgv_permissionDetail;
            }
            set
            {

                this.dtgv_permissionDetail = value;
            }
        }

        public string IdEmployee
        {
            get
            {
                return this.txt_idNhanVien.Tag.ToString();
            }
            set
            {
                this.txt_idNhanVien.Focus();
                this.txt_idNhanVien.Texts = value;
                this.txt_idNhanVien.Tag = value;
            }
        }
        public string NameEmployee
        {
            get
            {
                return this.txt_tenNhanVien.Texts;
            }
            set
            {
                this.txt_tenNhanVien.Focus();
                this.txt_tenNhanVien.Texts = value;
            }
        }
        public int ComboboxIdPermission
        {
            get
            {
                return (int)this.cbb_idPermission.SelectedValue;
            }
            set
            {
                this.cbb_idPermission.SelectedValue = value;
            }
        }

        public string IdPermissionDetail
        {
            get
            {
                return this.txt_idPermissionDetail.Tag.ToString();
            }
            set
            {
                this.txt_idPermissionDetail.Focus();
                this.txt_idPermissionDetail.Texts = value;
                this.txt_idPermissionDetail.Tag = value;
            }
        }
        public string NamePermissionDetail
        {
            get
            {
                return this.txt_namePermissionDetail.Tag.ToString();
            }
            set
            {
                this.txt_namePermissionDetail.Focus();
                this.txt_namePermissionDetail.Texts = value;
                this.txt_namePermissionDetail.Tag = value;
            }
        }
        public string ContentPermissionDetail
        {
            get
            {
                return this.txt_contentPermissionDetail.Tag.ToString();
            }
            set
            {
                this.txt_contentPermissionDetail.Focus();
                this.txt_contentPermissionDetail.Texts = value;
                this.txt_contentPermissionDetail.Tag = value;
            }
        }


        private void SetUpView()
        {
            // ẩn các tab control
            tc_nhanVien.Appearance = TabAppearance.FlatButtons;
            tc_nhanVien.ItemSize = new System.Drawing.Size(0, 1);
            tc_nhanVien.SizeMode = TabSizeMode.Fixed;
            tc_quyen.Appearance = TabAppearance.FlatButtons;
            tc_quyen.ItemSize = new System.Drawing.Size(0, 1);
            tc_quyen.SizeMode = TabSizeMode.Fixed;
        }
        private void BindingEvents()
        {
            btn_addPermission.Click += delegate { AddPermissionBtnEvent?.Invoke(this, EventArgs.Empty); };
            btn_editPermission.Click += delegate { EditPermissionBtnEvent?.Invoke(this, EventArgs.Empty); };
            btn_deletePermission.Click += delegate { DeletePermissionBtnEvent?.Invoke(this, EventArgs.Empty); };
            btn_acceptPermission.Click += delegate { AcceptPermissionBtnEvent?.Invoke(this, EventArgs.Empty); };
            btn_detailPermission.Click += delegate { DetailPermissionBtnEvent?.Invoke(this, EventArgs.Empty); };

            btn_editPermissionEmployee.Click += delegate { EditPermissionEmployeeBtnEvent?.Invoke(this, EventArgs.Empty); };
            btn_deletePermissionEmployee.Click += delegate { DeletePermissionEmployeeBtnEvent?.Invoke(this, EventArgs.Empty); };
            btn_acceptPermissionEmployee.Click += delegate { AcceptPermissionEmployeeBtnEvent?.Invoke(this, EventArgs.Empty); };

        }
        public void LoadChucNangListDetail(BindingSource listMethod)
        {
            this.dtgv_permissionDetail.DataSource = listMethod;
        }
        public void LoadNhanVienList(BindingSource listEmployee)
        {
            this.dtgrv_nhanVien.DataSource = listEmployee;
        }

        public void LoadQuyenCombobox(BindingSource listPermission)
        {
            this.cbb_idPermission.DataSource = listPermission;
            this.cbb_idPermission.DisplayMember = "IdPermission";
            this.cbb_idPermission.ValueMember = "IdPermission";
            this.cbb_namePermission.DataSource = listPermission;
            this.cbb_namePermission.DisplayMember = "NamePermission";
            this.cbb_namePermission.ValueMember = "IdPermission";
        }
        public void LoadQuyenList(BindingSource listPermission)
        {
            this.dtgrv_quyen.DataSource = listPermission;
        }

        public void LoadChucNangListCheckBox(BindingSource listMethod)
        {
            ((ListBox)this.clb_chucNang).DataSource = listMethod;
            ((ListBox)this.clb_chucNang).DisplayMember = "NameMethod";
            ((ListBox)this.clb_chucNang).ValueMember = "IdMethod";
        }

        public void LoadCheckedCheckBox(ArrayList arrMethod)
        {
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
        public ArrayList GetArrayMethodChecked()
        {
            ArrayList arrMethod = new ArrayList();
            for (int i = 0; i < clb_chucNang.Items.Count; i++)
            {
                if (clb_chucNang.GetItemChecked(i))
                {
                    ChucNangModel obj = (ChucNangModel)clb_chucNang.Items[i];
                    arrMethod.Add(obj.IdMethod);
                }
            }
            return arrMethod;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void GoToListTabPage()
        {
            this.tc_quyen.SelectedTab = this.tp_quyenDanhSach;
        }

        public DialogResult ShowYesNoMessage(string message)
        {
            return MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void GoToDetailPermissionTab()
        {
            this.tc_quyen.SelectedTab = this.tp_quyenChiTiet;
        }

        public event EventHandler AddPermissionBtnEvent;
        public event EventHandler EditPermissionBtnEvent;
        public event EventHandler DeletePermissionBtnEvent;
        public event EventHandler DetailPermissionBtnEvent;
        public event EventHandler AcceptPermissionBtnEvent;
        public event EventHandler EditPermissionEmployeeBtnEvent;
        public event EventHandler DeletePermissionEmployeeBtnEvent;
        public event EventHandler AcceptPermissionEmployeeBtnEvent;

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
            
        }

        private void btn_backPermission_Click(object sender, EventArgs e)
        {
            this.tc_quyen.SelectedTab = this.tp_quyenDanhSach;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clb_chucNang.Items.Count; i++)
            {
                clb_chucNang.SetItemChecked(i, false);
            }
            this.tc_quyen.SelectedTab = this.tp_quyenChiTiet;
        }

        private void btn_acceptPermission_Click(object sender, EventArgs e)
        {

        }

        private void btn_detailPermission_Click(object sender, EventArgs e)
        {
            this.tc_quyen.SelectedTab = this.tp_xemChiTiet;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.tc_quyen.SelectedTab = this.tp_quyenDanhSach;
        }
        private void btn_back2_Click(object sender, EventArgs e)
        {
            this.tc_quyen.SelectedTab = this.tp_quyenDanhSach;
        }
        private void btn_backPermissionEmployee_Click(object sender, EventArgs e)
        {
            this.tc_nhanVien.SelectedTab = this.tp_nhanVienDanhSach;
        }

        private void btn_editPermissionEmployee_Click(object sender, EventArgs e)
        {
            this.tc_nhanVien.SelectedTab = this.tp_nhanVienChiTiet;
        }

        private void btn_cancelPermissionEmployee_Click(object sender, EventArgs e)
        {
            this.tc_nhanVien.SelectedTab = this.tp_nhanVienDanhSach;
        }

        private void btn_confirmPermissionEmployee_Click(object sender, EventArgs e)
        {
            this.tc_nhanVien.SelectedTab = this.tp_nhanVienDanhSach;
        }

        private void txt_searchPermission__TextChanged(object sender, EventArgs e)
        {
            string valueSearch = this.txt_searchPermission.Texts;
            IEnumerable<QuyenModel> listQuyen;
            PhanQuyenRepository repo = new PhanQuyenRepository(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            if (string.IsNullOrEmpty(valueSearch) || string.IsNullOrWhiteSpace(valueSearch))
            {

                listQuyen = repo.GetAllPermission();
            }
            else
            {
                listQuyen = repo.GetPermissionByValue(valueSearch);
            }
            this.dtgrv_quyen.DataSource = listQuyen;
        }

        private void txt_searchPermissionEmployee__TextChanged(object sender, EventArgs e)
        {
            string valueSearch = this.txt_searchPermissionEmployee.Texts;
            IEnumerable<QuyenNhanVienModel> list;
            PhanQuyenRepository repo = new PhanQuyenRepository(ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString);
            if (string.IsNullOrEmpty(valueSearch) || string.IsNullOrWhiteSpace(valueSearch))
            {
                list = repo.GetEmployeePermission();
            }
            else
            {
                list = repo.GetEmployeePermissionByValue(valueSearch);
            }
            this.dtgrv_nhanVien.DataSource = list;
        }

        private void cbb_idPermission_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbb_namePermission_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
