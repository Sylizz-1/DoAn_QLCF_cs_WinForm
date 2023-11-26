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

        private static NguyenLieuView instance;
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

        public NguyenLieuView()
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
            rbKlgDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbKlgInc.CheckedChanged += SortRadioButton_CheckedChanged;
            rbInfoDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbInfoInc.CheckedChanged += SortRadioButton_CheckedChanged;
            rbPriceDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbPriceInc.CheckedChanged += SortRadioButton_CheckedChanged;
            rbIsDeleteDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbIsDeleteInc.CheckedChanged += SortRadioButton_CheckedChanged;
        }
        private void SetUpView()
        {
            tcNgl.Appearance = TabAppearance.FlatButtons;
            tcNgl.ItemSize = new System.Drawing.Size(0, 1);
            tcNgl.SizeMode = TabSizeMode.Fixed;
        }
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
        public string NguyenLieuId
        {
            get => this.txtNglId.Texts;
            set => this.txtNglId.Texts = value;
        }
        public string TenNguyenLieu
        {
            get => this.txtNglName.Texts;
            set => this.txtNglName.Texts = value;
        }
        public string ThongTin
        {
            get => this.txtNglInfo.Texts;
            set => this.txtNglInfo.Texts = value;
        }
        public string KhoiLuong
        {
            get => this.txtNglWeigh.Texts;
            set => this.txtNglWeigh.Texts = value;
        }
        public string GiaTien_Kg
        {
            get => this.txtNglPrice.Texts;
            set => this.txtNglPrice.Texts = value;
        }
        public string IsDelete
        {
            get => (this.checkboxIsDelete.Checked).ToString();
            set => this.checkboxIsDelete.Checked = bool.Parse(value);
        }
        public string HinhAnh
        {
            get => this.caPhePic.ImageLocation;
            set => this.caPhePic.Image = Image.FromFile(value);
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

        public void LoadData(BindingSource list)
        {
            this.dgvNgl.DataSource = list;
            templist = list;
        }
        public void GetIdNglAdd(int id)
        {
            this.txtNglId.Enabled = true;
            this.txtNglId.Focus();
            this.txtNglId.Texts = id.ToString();
            this.txtNglName.Focus();
        }
        public void SetTextBoxFillData(NguyenLieuModel ngl)
        {
            this.txtNglId.Enabled = true;
            this.txtNglId.Focus();
            this.txtNglId.Texts = ngl.NguyenLieuId.ToString();
            this.txtNglId.Enabled = false;
            this.txtNglName.Focus();
            this.txtNglName.Texts = ngl.TenNguyenLieu;
            this.txtNglInfo.Focus();
            this.txtNglInfo.Texts = ngl.ThongTin;
            this.txtNglWeigh.Focus();
            this.txtNglWeigh.Texts = ngl.KhoiLuong.ToString();
            this.txtNglPrice.Focus();
            this.txtNglPrice.Texts = ngl.GiaTien_Kg.ToString();
        }

        public bool CheckInput()
        {
            string s = "Vui lòng nhập ";
            if (string.IsNullOrEmpty(txtNglName.Texts))
            {
                s += "\n + Tên nguyên liệu";
                txtNglName.BorderColor = Color.Red;
            }
            else
                txtNglName.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtNglInfo.Texts))
            {
                s += "\n + Thông tin nguyên liệu";
                txtNglInfo.BorderColor = Color.Red;
            }
            else
                txtNglInfo.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtNglWeigh.Texts) || !float.TryParse(txtNglWeigh.Texts, out _))
            {
                s += "\n + Khối lượng nguyên liệu (số)";
                txtNglWeigh.BorderColor = Color.Red;
            }
            else
                txtNglWeigh.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtNglPrice.Texts) || !float.TryParse(txtNglPrice.Texts, out _))
            {
                s += "\n + Giá nguyên liệu (số)";
                txtNglPrice.BorderColor = Color.Red;
            }
            else
                txtNglPrice.BorderColor = Color.DarkCyan;
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
        public void GetIdNguyenLieuAdd(int id)
        {
            this.txtNglId.Texts = id.ToString();
        }
        public void SetNull()
        {
            if (isFilter)
            {
                txtNglId.Enabled = true;
                txtNglId.BackColor = Color.White;
                txtNglId.Texts = "";
                txtNglId.BorderColor = Color.DarkCyan;
                txtNglId.Focus();
            }

            txtNglName.Texts = "";
            txtNglInfo.Texts = "";
            txtNglWeigh.Texts = "";
            txtNglPrice.Texts = "";
            checkboxIsDelete.Checked = false;
            txtNglName.BorderColor = Color.DarkCyan;
            txtNglInfo.BorderColor = Color.DarkCyan;
            txtNglWeigh.BorderColor = Color.DarkCyan;
            txtNglPrice.BorderColor = Color.DarkCyan;
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            txtNglId.Enabled = false;
            txtNglId.BackColor = Color.LightGray;
            txtNglId.BorderColor = Color.Silver;
            tcNgl.SelectedTab = detailTabPage;
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            tcNgl.SelectedTab = detailTabPage;
        }
        private void filterBtn_Click(object sender, EventArgs e)
        {
            isFilter = true;
            tcNgl.SelectedTab = detailTabPage;
            SetNull();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (isFilter)
            {
                txtNglId.Text = "";
                txtNglId.Enabled = false;
                txtNglId.BackColor = Color.LightGray;
                txtNglId.BorderColor = Color.Silver;
            }
            setState(false, false, false, false);
            tcNgl.SelectedTab = listTabPage;
            SetNull();
        }
        private void HuyBtn_Click(object sender, EventArgs e)
        {
            if (isFilter)
            {
                txtNglId.Text = "";
                txtNglId.Enabled = false;
                txtNglId.BackColor = Color.LightGray;
                txtNglId.BorderColor = Color.Silver;
            }
            setState(false, false, false, false);
            tcNgl.SelectedTab = listTabPage;
            SetNull();
        }
        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (gbSort.Visible)
                gbSort.Visible = false;
            else
                gbSort.Visible = true;
        }
        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            if (isNeedTurn)
                tcNgl.SelectedTab = listTabPage;
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
            List<NguyenLieuModel> myList = templist.List.OfType<NguyenLieuModel>().ToList();
            switch (sortType)
            {
                case "IDInc":
                    myList.Sort((x, y) => x.NguyenLieuId.CompareTo(y.NguyenLieuId));
                    break;
                case "IDDec":
                    myList.Sort((x, y) => y.NguyenLieuId.CompareTo(x.NguyenLieuId));
                    break;
                case "NameInc":
                    myList.Sort((x, y) => x.TenNguyenLieu.CompareTo(y.TenNguyenLieu));
                    break;
                case "NameDec":
                    myList.Sort((x, y) => y.TenNguyenLieu.CompareTo(x.TenNguyenLieu));
                    break;
                case "InfoInc":
                    myList.Sort((x, y) => x.ThongTin.CompareTo(y.ThongTin));
                    break;
                case "InfoDec":
                    myList.Sort((x, y) => y.ThongTin.CompareTo(x.ThongTin));
                    break;
                case "KlgInc":
                    myList.Sort((x, y) => x.KhoiLuong.CompareTo(y.KhoiLuong));
                    break;
                case "KlgDec":
                    myList.Sort((x, y) => y.KhoiLuong.CompareTo(x.KhoiLuong));
                    break;
                case "PriceInc":
                    myList.Sort((x, y) => x.GiaTien_Kg.CompareTo(y.GiaTien_Kg));
                    break;
                case "PriceDec":
                    myList.Sort((x, y) => y.GiaTien_Kg.CompareTo(x.GiaTien_Kg));
                    break;
                case "IsDeleteInc":
                    myList.Sort((x, y) => x.IsDelete.CompareTo(y.IsDelete));
                    break;
                case "IsDeleteDec":
                    myList.Sort((x, y) => y.IsDelete.CompareTo(x.IsDelete));
                    break;
            }
            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = myList;
            LoadData(myBindingSource);
        }

        private void dgvNgl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvNgl.Rows[e.RowIndex];
                string firstCellData = selectedRow.Cells[0].Value.ToString();
                id = firstCellData;
            }
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            rbIDDec.Checked = false;
            rbIIDnc.Checked = false;
            rbNameDec.Checked = false;
            rbNameInc.Checked = false;
            rbInfoDec.Checked = false;
            rbInfoInc.Checked = false;
            rbKlgDec.Checked = false;
            rbKlgInc.Checked = false;
            rbPriceDec.Checked = false;
            rbPriceInc.Checked = false;
            rbIsDeleteDec.Checked = false;
            rbIsDeleteInc.Checked = false;
        }

        private void txtNglName__TextChanged(object sender, EventArgs e)
        {
            if (txtNglName.Texts.Length > 0 || isFilter)
                txtNglName.BorderColor = Color.DarkCyan;
            else
                txtNglName.BorderColor = Color.Red;
        }

        private void txtNglInfo__TextChanged(object sender, EventArgs e)
        {
            if (txtNglInfo.Texts.Length > 0 || isFilter)
                txtNglInfo.BorderColor = Color.DarkCyan;
            else
                txtNglInfo.BorderColor = Color.Red;
        }

        private void txtNglWeigh__TextChanged(object sender, EventArgs e)
        {
            int result;
            if ((int.TryParse(txtNglWeigh.Texts, out result) && txtNglWeigh.Texts.Length > 0) && (isFilter || int.TryParse(txtNglWeigh.Texts, out result)))
                txtNglWeigh.BorderColor = Color.DarkCyan;
            else
                txtNglWeigh.BorderColor = Color.Red;
        }
        private void txtNglPrice__TextChanged(object sender, EventArgs e)
        {
            int result;
            if ((int.TryParse(txtNglPrice.Texts, out result) && txtNglPrice.Texts.Length > 0) && (isFilter || int.TryParse(txtNglPrice.Texts, out result)))
                txtNglPrice.BorderColor = Color.DarkCyan;
            else
                txtNglPrice.BorderColor = Color.Red;
        }
    }
}
