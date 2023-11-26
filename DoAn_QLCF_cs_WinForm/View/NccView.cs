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
using static System.Net.Mime.MediaTypeNames;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class NccView : Form, INccView
    {
        private static NccView instance;
        private string id = "1";
        public event EventHandler btnAddClickEvent;
        public event EventHandler btnUpdateClickEvent;
        public event EventHandler btnFilterClickEvent;
        public event EventHandler AddEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SortEvent;
        public event EventHandler FilterEvent;
        public event EventHandler ResetEvent;
        public bool checkIsAdd = false;
        public bool checkIsfilter = false;
        public bool checkIsUpdate = false;
        public bool isNeedTurn = false;
        private BindingSource templist = new BindingSource();
        public NccView()
        {
            InitializeComponent();
            SetUpView();

            xacNhanBtn.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
            xacNhanBtn.Click += delegate { UpdateEvent?.Invoke(this, EventArgs.Empty); };
            xacNhanBtn.Click += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };

            addBtn.Click += delegate { btnAddClickEvent?.Invoke(this, EventArgs.Empty); };
            editBtn.Click += delegate { btnUpdateClickEvent?.Invoke(this, EventArgs.Empty); };
            filterBtn.Click += delegate { btnFilterClickEvent?.Invoke(this, EventArgs.Empty); };

            delBtn.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            sortBtn.Click += delegate { SortEvent?.Invoke(this, EventArgs.Empty); };
            resetBtn.Click += delegate { ResetEvent?.Invoke(this, EventArgs.Empty); };

            rbIDDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbIIDnc.CheckedChanged += SortRadioButton_CheckedChanged;
            rbNameDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbNameInc.CheckedChanged += SortRadioButton_CheckedChanged;
            rbSdtDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbSdtInc.CheckedChanged += SortRadioButton_CheckedChanged;
            rbDcDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbDcInc.CheckedChanged += SortRadioButton_CheckedChanged;
            rbEmailDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbEmailInc.CheckedChanged += SortRadioButton_CheckedChanged;
            rbIsDeleteDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbIsDeleteInc.CheckedChanged += SortRadioButton_CheckedChanged;
        }
        public string NhaCungCapId
        {
            get => this.txtIdNcc.Texts;
            set => this.txtIdNcc.Texts = value;
        }
        public string TenNhaCungCap
        {
            get => this.txtTenNcc.Texts;
            set => this.txtTenNcc.Texts = value;
        }
        public string DiaChi
        {
            get => this.txtDiaChiNcc.Texts;
            set => this.txtDiaChiNcc.Texts = value;
        }
        public string SDT
        {
            get => this.txtSDTNcc.Texts;
            set => this.txtSDTNcc.Texts = value;
        }
        public string Email
        {
            get => this.txtEmailNcc.Texts;
            set => this.txtEmailNcc.Texts = value;
        }
        public string IsDelete
        {
            get => (this.checkboxIsDelete.Checked).ToString();
            set => this.checkboxIsDelete.Checked = bool.Parse(value);
        }
        public bool isAdd
        {
            get => checkIsAdd;
            set => checkIsAdd = value;
        }
        public bool isFilter
        {
            get => checkIsfilter;
            set => checkIsfilter = value;
        }
        public bool isUpdate
        {
            get => checkIsUpdate;
            set => checkIsUpdate = value;
        }
        public string selectedId { get => this.id; set => this.id = value; }


        public static INccView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new NccView();
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

        public void LoadData(BindingSource list)
        {
            this.dgvNcc.DataSource = list;
            templist = list;
        }
        public void GetIdNccAdd(int id)
        {
            this.txtIdNcc.Enabled = true;
            this.txtIdNcc.Focus();
            this.txtIdNcc.Texts = id.ToString();
            this.txtTenNcc.Focus();
        }
        private void SetUpView()
        {
            tcNCC.Appearance = TabAppearance.FlatButtons;
            tcNCC.ItemSize = new System.Drawing.Size(0, 1);
            tcNCC.SizeMode = TabSizeMode.Fixed;
        }
        public void SetTextBoxFillData(NccModel ncc)
        {
            this.txtIdNcc.Enabled = true;
            this.txtIdNcc.Focus();
            this.txtIdNcc.Texts = ncc.NhaCungCapId.ToString();
            this.txtIdNcc.Enabled = false;
            this.txtTenNcc.Focus();
            this.txtTenNcc.Texts = ncc.TenNhaCungCap;
            this.txtDiaChiNcc.Focus();
            this.txtDiaChiNcc.Texts = ncc.DiaChi;
            this.txtSDTNcc.Focus();
            this.txtSDTNcc.Texts = ncc.SDT;
            this.txtEmailNcc.Focus();
            this.txtEmailNcc.Texts = ncc.Email;
        }

        public bool CheckInput()
        {
            string s = "Vui lòng nhập ";
            if (string.IsNullOrEmpty(txtTenNcc.Texts))
            {
                s += "\n + Tên nhà cung cấp";
                txtTenNcc.BorderColor = Color.Red;
            }
            else
                txtTenNcc.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtDiaChiNcc.Texts))
            {
                s += "\n + Địa chỉ nhà cung cấp";
                txtDiaChiNcc.BorderColor = Color.Red;
            }
            else
                txtDiaChiNcc.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtSDTNcc.Texts) || !float.TryParse(txtSDTNcc.Texts, out _))
            {
                s += "\n + Số điện thoại nhà cung cấp (số)";
                txtSDTNcc.BorderColor = Color.Red;
            }
            else
                txtSDTNcc.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtEmailNcc.Texts))
            {
                s += "\n + Email nhà cung cấp";
                txtEmailNcc.BorderColor = Color.Red;
            }
            else
                txtEmailNcc.BorderColor = Color.DarkCyan;
            if (s != "Vui lòng nhập ")
            {
                MessageBox.Show(s);
                return false;
            }
            return true;
        }
        public void setState(bool isAddState, bool isUpdateState, bool isFilterState, bool isNeedReturnState)
        {
            checkIsAdd = isAddState;
            checkIsUpdate = isUpdateState;
            checkIsfilter = isFilterState;
            isNeedTurn = isNeedReturnState;
        }
        public void SetNull()
        {
            if (isFilter)
            {
                txtIdNcc.Enabled = true;
                txtIdNcc.BackColor = Color.White;
                txtIdNcc.Texts = "";
                txtIdNcc.BorderColor = Color.DarkCyan;
                txtIdNcc.Focus();
            }

            txtTenNcc.Texts = "";
            txtSDTNcc.Texts = "";
            txtEmailNcc.Texts = "";
            txtDiaChiNcc.Texts = "";
            checkboxIsDelete.Checked = false;
            txtTenNcc.BorderColor = Color.DarkCyan;
            txtDiaChiNcc.BorderColor = Color.DarkCyan;
            txtEmailNcc.BorderColor = Color.DarkCyan;
            txtSDTNcc.BorderColor = Color.DarkCyan;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            txtIdNcc.Enabled = false;
            txtIdNcc.BackColor = Color.LightGray;
            txtIdNcc.BorderColor = Color.Silver;
            tcNCC.SelectedTab = detailTabPage;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            tcNCC.SelectedTab = detailTabPage;
        }
        private void filterBtn_Click(object sender, EventArgs e)
        {
            isFilter = true;
            tcNCC.SelectedTab = detailTabPage;
            SetNull();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (isFilter)
            {
                txtIdNcc.Text = "";
                txtIdNcc.Enabled = false;
                txtIdNcc.BackColor = Color.LightGray;
                txtIdNcc.BorderColor = Color.Silver;
            }
            setState(false, false, false, false);
            tcNCC.SelectedTab = listTabPage;
            SetNull();
        }

        private void HuyBtn_Click(object sender, EventArgs e)
        {
            if (isFilter)
            {
                txtIdNcc.Text = "";
                txtIdNcc.Enabled = false;
                txtIdNcc.BackColor = Color.LightGray;
                txtIdNcc.BorderColor = Color.Silver;
            }
            setState(false, false, false, false);
            tcNCC.SelectedTab = listTabPage;
            SetNull();
        }
        private void dgvNcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNcc.Rows[e.RowIndex];
                string firstCellData = selectedRow.Cells[0].Value.ToString();
                id = firstCellData;
            }
        }

        private void txtTenNcc__TextChanged(object sender, EventArgs e)
        {
            if (txtTenNcc.Texts.Length > 0 || isFilter)
                txtTenNcc.BorderColor = Color.DarkCyan;
            else
                txtTenNcc.BorderColor = Color.Red;
        }

        private void txtDiaChiNcc__TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChiNcc.Texts.Length > 0 || isFilter)
                txtDiaChiNcc.BorderColor = Color.DarkCyan;
            else
                txtDiaChiNcc.BorderColor = Color.Red;
        }

        private void txtEmailNcc__TextChanged(object sender, EventArgs e)
        {
            if (txtEmailNcc.Texts.Length > 0 || isFilter)
                txtEmailNcc.BorderColor = Color.DarkCyan;
            else
                txtEmailNcc.BorderColor = Color.Red;
        }

        private void txtSDTNcc__TextChanged(object sender, EventArgs e)
        {
            int result;
            if ((int.TryParse(txtSDTNcc.Texts, out result) && txtSDTNcc.Texts.Length > 0) && (isFilter || int.TryParse(txtSDTNcc.Texts, out result)))
                txtSDTNcc.BorderColor = Color.DarkCyan;
            else
                txtSDTNcc.BorderColor = Color.Red;
        }


        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (gbSort.Visible)
                gbSort.Visible = false;
            else
                gbSort.Visible = true;
        }
        private void SortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                string sortType = radioButton.Tag.ToString();
                SortListModels(sortType);
            }
        }
        private void SortListModels(string sortType)
        {
            List<NccModel> myList = templist.List.OfType<NccModel>().ToList();
            switch (sortType)
            {
                case "IDInc":
                    myList.Sort((x, y) => x.NhaCungCapId.CompareTo(y.NhaCungCapId));
                    break;
                case "IDDec":
                    myList.Sort((x, y) => y.NhaCungCapId.CompareTo(x.NhaCungCapId));
                    break;
                case "NameInc":
                    myList.Sort((x, y) => x.TenNhaCungCap.CompareTo(y.TenNhaCungCap));
                    break;
                case "NameDec":
                    myList.Sort((x, y) => y.TenNhaCungCap.CompareTo(x.TenNhaCungCap));
                    break;
                case "DcInc":
                    myList.Sort((x, y) => x.DiaChi.CompareTo(y.DiaChi));
                    break;
                case "DcDec":
                    myList.Sort((x, y) => y.DiaChi.CompareTo(x.DiaChi));
                    break;
                case "SdtInc":
                    myList.Sort((x, y) => x.SDT.CompareTo(y.SDT));
                    break;
                case "SdtDec":
                    myList.Sort((x, y) => y.SDT.CompareTo(x.SDT));
                    break;
                case "EmailInc":
                    myList.Sort((x, y) => x.Email.CompareTo(y.Email));
                    break;
                case "EmailDec":
                    myList.Sort((x, y) => y.Email.CompareTo(x.Email));
                    break;
                case "IsDeleteInc":
                    myList.Sort((x, y) => x.Email.CompareTo(y.Email));
                    break;
                case "IsDeleteDec":
                    myList.Sort((x, y) => y.Email.CompareTo(x.Email));
                    break;
            }
            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = myList;
            LoadData(myBindingSource);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            rbIDDec.Checked = false;
            rbIIDnc.Checked = false;
            rbNameDec.Checked = false;
            rbNameInc.Checked = false;
            rbSdtDec.Checked = false;
            rbSdtInc.Checked = false;
            rbDcDec.Checked = false;
            rbDcInc.Checked = false;
            rbEmailDec.Checked = false;
            rbEmailInc.Checked = false;
            rbIsDeleteDec.Checked = false;
            rbIsDeleteInc.Checked = false;
        }
        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            if (isNeedTurn)
                tcNCC.SelectedTab = listTabPage;
        }
    }
}