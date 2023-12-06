using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System.Data.SqlClient;
using System.Text;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class PggView : Form, IPggView
    {

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
        private string id = "1";
        public event EventHandler btnAddClickEvent;
        public event EventHandler btnUpdateClickEvent;
        public event EventHandler AddEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SortEvent;
        public event EventHandler FilterEvent;
        public event EventHandler ResetEvent;
        public event EventHandler btnFilterClickEvent;

        public bool checkIsAdd = false;
        public bool checkIsfilter = false;
        public bool checkIsUpdate = false;
        public bool isNeedTurn = false;
        private BindingSource templist = new BindingSource();
        public PggView()
        {
            InitializeComponent();
            SetUpView();

            xacNhanBtn.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
            xacNhanBtn.Click += delegate { UpdateEvent?.Invoke(this, EventArgs.Empty); };
            xacNhanBtn.Click += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };

            addBtn.Click += delegate { btnAddClickEvent?.Invoke(this, EventArgs.Empty); };
            editBtn.Click += delegate { btnUpdateClickEvent?.Invoke(this, EventArgs.Empty); };
            //filterBtn.Click += delegate { btnFilterClickEvent?.Invoke(this, EventArgs.Empty); };

            delBtn.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            sortBtn.Click += delegate { SortEvent?.Invoke(this, EventArgs.Empty); };
            resetBtn.Click += delegate { ResetEvent?.Invoke(this, EventArgs.Empty); };


            rbIDDec.CheckedChanged += SortRadioButton_CheckedChanged;


            rbIDInc.CheckedChanged += SortRadioButton_CheckedChanged;


            rbTgBatDauDec.CheckedChanged += SortRadioButton_CheckedChanged;


            rbTgBatDauInc.CheckedChanged += SortRadioButton_CheckedChanged;


            rbTgKetThucDec.CheckedChanged += SortRadioButton_CheckedChanged;


            rbTgKetThucInc.CheckedChanged += SortRadioButton_CheckedChanged;


            rbGiaHoaDonDec.CheckedChanged += SortRadioButton_CheckedChanged;


            rbGiaHoaDonInc.CheckedChanged += SortRadioButton_CheckedChanged;


            rbPhanTramGiamGiaDec.CheckedChanged += SortRadioButton_CheckedChanged;


            rbPhanTramGiamGiaInc.CheckedChanged += SortRadioButton_CheckedChanged;


            rbIsDeleteDec.CheckedChanged += SortRadioButton_CheckedChanged;


            rbIsDeleteInc.CheckedChanged += SortRadioButton_CheckedChanged;
        }

        public string PggId
        {
            get => this.txtIdPgg.Texts;
            set => this.txtIdPgg.Texts = value;
        }
        public string TgBatDau
        {
            get => this.dtpTgBatDauPgg.Text;
            set => this.dtpTgBatDauPgg.Text = value;
        }

        public string TgKetThuc
        {
            get => this.dtpTgKetThucPgg.Text;
            set => this.dtpTgKetThucPgg.Text = value;
        }
        public string GiaHoaDon
        {
            get => this.txtGiaHoaDonPgg.Texts;
            set => this.txtGiaHoaDonPgg.Texts = value;
        }
        public string PhanTramGiamGia
        {
            get => this.txtPhanTramGiamGiaPgg.Texts;
            set => this.txtPhanTramGiamGiaPgg.Texts = value;
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

        public void LoadData(BindingSource list)
        {
            this.dgvPgg.DataSource = list;
            templist = list;
        }
        public void GetIdPggAdd(int id)
        {
            this.txtIdPgg.Enabled = true;
            this.txtIdPgg.Focus();
            this.txtIdPgg.Texts = id.ToString();
            this.dtpTgBatDauPgg.Focus();
        }
        private void SetUpView()
        {
            tcPgg.Appearance = TabAppearance.FlatButtons;
            tcPgg.ItemSize = new System.Drawing.Size(0, 1);
            tcPgg.SizeMode = TabSizeMode.Fixed;
        }
        public void SetTextBoxFillData(PggModel pgg)
        {
            this.txtIdPgg.Enabled = true;
            this.txtIdPgg.Focus();
            this.txtIdPgg.Texts = pgg.PggId.ToString();
            this.txtIdPgg.Enabled = false;

            this.dtpTgBatDauPgg.Focus();
            this.dtpTgBatDauPgg.Value = pgg.TgBatDau ?? DateTime.Now;

            this.dtpTgKetThucPgg.Focus();
            this.dtpTgKetThucPgg.Value = pgg.TgKetThuc ?? DateTime.Now;

            this.txtGiaHoaDonPgg.Focus();
            this.txtGiaHoaDonPgg.Texts = pgg.GiaHoaDon.ToString() ?? string.Empty;

            this.txtPhanTramGiamGiaPgg.Focus();
            this.txtPhanTramGiamGiaPgg.Texts = pgg.PhanTramGiamGia.ToString() ?? string.Empty;
        }




        public bool CheckInput()
        {
            string s = "Vui lòng nhập ";
            if (dtpTgBatDauPgg.Value.ToString("yyyy-MM-dd HH:mm:ss") == null)
            {
                s += "\n + Ngày bắt đầu";
                dtpTgBatDauPgg.BackColor = Color.Red;
            }
            else
                dtpTgBatDauPgg.BackColor = Color.DarkCyan;
            if (dtpTgKetThucPgg.Value.ToString("yyyy-MM-dd HH:mm:ss") == null)
            {
                s += "\n + Ngày kết thúc";
                dtpTgKetThucPgg.BackColor = Color.Red;
            }
            else
                dtpTgKetThucPgg.BackColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtGiaHoaDonPgg.Texts) || !float.TryParse(txtGiaHoaDonPgg.Texts, out _))
            {
                s += "\n + Số giá tiền tối thiểu của hoá đơn (số)";
                txtGiaHoaDonPgg.BorderColor = Color.Red;
            }
            else
                txtGiaHoaDonPgg.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtPhanTramGiamGiaPgg.Texts) || !float.TryParse(txtPhanTramGiamGiaPgg.Texts, out _))
            {
                s += "\n + Phần trăm giảm giá (số)";
                txtPhanTramGiamGiaPgg.BorderColor = Color.Red;
            }
            else
                txtPhanTramGiamGiaPgg.BorderColor = Color.DarkCyan;
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
                txtIdPgg.Enabled = true;
                txtIdPgg.BackColor = Color.White;
                txtIdPgg.Texts = "";
                txtIdPgg.BorderColor = Color.DarkCyan;
                txtIdPgg.Focus();
            }
            txtGiaHoaDonPgg.Texts = "";
            txtPhanTramGiamGiaPgg.Texts = "";
            checkboxIsDelete.Checked = false;
            txtGiaHoaDonPgg.BorderColor = Color.DarkCyan;
            txtPhanTramGiamGiaPgg.BorderColor = Color.DarkCyan;
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
            List<PggModel> myList = templist.List.OfType<PggModel>().ToList();

            switch (sortType)
            {
                case "IDInc":
                    myList = myList.OrderBy(x => x.PggId).ToList();
                    break;
                case "IDDec":
                    myList = myList.OrderByDescending(x => x.PggId).ToList();
                    break;
                case "TgBatDauInc":
                    myList = myList.OrderBy(x => x.TgBatDau).ToList();
                    break;
                case "TgBatDauDec":
                    myList = myList.OrderByDescending(x => x.TgBatDau).ToList();
                    break;
                case "TgKetThucInc":
                    myList = myList.OrderBy(x => x.TgKetThuc).ToList();
                    break;
                case "TgKetThucDec":
                    myList = myList.OrderByDescending(x => x.TgKetThuc).ToList();
                    break;
                case "GiaHoaDonInc":
                    myList = myList.OrderBy(x => x.GiaHoaDon).ToList();
                    break;
                case "GiaHoaDonDec":
                    myList = myList.OrderByDescending(x => x.GiaHoaDon).ToList();
                    break;
                case "PhanTramGiamGiaInc":
                    myList = myList.OrderBy(x => x.PhanTramGiamGia).ToList();
                    break;
                case "PhanTramGiamGiaDec":
                    myList = myList.OrderByDescending(x => x.PhanTramGiamGia).ToList();
                    break;
                case "IsDeleteInc":
                    myList = myList.OrderBy(x => x.IsDelete).ToList();
                    break;
                case "IsDeleteDec":
                    myList = myList.OrderByDescending(x => x.IsDelete).ToList();
                    break;
            }

            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = myList;
            LoadData(myBindingSource);
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            isFilter = true;
            tcPgg.SelectedTab = detailTabPage;
            SetNull();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (gbSort.Visible)
                gbSort.Visible = false;
            else
                gbSort.Visible = true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            txtIdPgg.Enabled = false;
            txtIdPgg.BackColor = Color.LightGray;
            txtIdPgg.BorderColor = Color.Silver;
            tcPgg.SelectedTab = detailTabPage;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            tcPgg.SelectedTab = detailTabPage;
        }

        private void delBtn_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            rbIDDec.Checked = false;
            rbIDInc.Checked = false;
            rbTgBatDauDec.Checked = false;
            rbTgBatDauInc.Checked = false;
            rbTgKetThucDec.Checked = false;
            rbTgKetThucInc.Checked = false;
            rbGiaHoaDonDec.Checked = false;
            rbGiaHoaDonInc.Checked = false;
            rbPhanTramGiamGiaDec.Checked = false;
            rbPhanTramGiamGiaInc.Checked = false;
            rbIsDeleteDec.Checked = false;
            rbIsDeleteInc.Checked = false;
        }

        private void searchTxt__TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpTgKetThucPgg_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaHoaDonPgg__TextChanged(object sender, EventArgs e)
        {
            if (txtGiaHoaDonPgg.Texts.Length > 0 || isFilter)
                txtGiaHoaDonPgg.BorderColor = Color.DarkCyan;
            else
                txtGiaHoaDonPgg.BorderColor = Color.Red;
        }

        private void txtPhanTramGiamGiaPgg__TextChanged(object sender, EventArgs e)
        {
            if (txtPhanTramGiamGiaPgg.Texts.Length > 0 || isFilter)
                txtPhanTramGiamGiaPgg.BorderColor = Color.DarkCyan;
            else
                txtPhanTramGiamGiaPgg.BorderColor = Color.Red;
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            if (isNeedTurn)
                tcPgg.SelectedTab = listTabPage;
        }

        private void HuyBtn_Click(object sender, EventArgs e)
        {
            if (isFilter)
            {
                txtIdPgg.Text = "";
                txtIdPgg.Enabled = false;
                txtIdPgg.BackColor = Color.LightGray;
                txtIdPgg.BorderColor = Color.Silver;
            }
            setState(false, false, false, false);
            tcPgg.SelectedTab = listTabPage;
            SetNull();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (isFilter)
            {
                txtIdPgg.Text = "";
                txtIdPgg.Enabled = false;
                txtIdPgg.BackColor = Color.LightGray;
                txtIdPgg.BorderColor = Color.Silver;
            }
            setState(false, false, false, false);
            tcPgg.SelectedTab = listTabPage;
            SetNull();
        }

        private void dtpTgBatDauPgg_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dgvPgg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPgg.Rows[e.RowIndex];
                string firstCellData = selectedRow.Cells[0].Value.ToString();
                id = firstCellData;

                // Lấy giá trị từ DataGridView và đặt vào các control
                PggModel selectedPgg = GetSelectedPggModel(id);
                SetTextBoxFillData(selectedPgg);

                // Thông báo cho các thành phần khác rằng đã chọn một giá trị và cần cập nhật
                UpdateEvent?.Invoke(this, EventArgs.Empty);
            }
        }
        private PggModel GetSelectedPggModel(string id)
        {
            int selectedId = int.Parse(id);
            PggModel selectedPgg = templist.List.OfType<PggModel>().FirstOrDefault(pgg => pgg.PggId == selectedId);

            return selectedPgg;
        }

    }
}
