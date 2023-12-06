using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System.Reflection.Metadata;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class HoaDonView : Form, IHoaDonView
    {
        private static HoaDonView instance;
        public static IHoaDonView GetInstance(Form parentContainer)
        {

            if (instance == null || instance.IsDisposed)
            {
                instance = new HoaDonView();
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
        public HoaDonView()
        {
            InitializeComponent();
            SetUpView();

            xacNhanBtn.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
            xacNhanBtn.Click += delegate { UpdateEvent?.Invoke(this, EventArgs.Empty); };
            xacNhanBtn.Click += delegate { FilterEvent?.Invoke(this, EventArgs.Empty); };
            btnCT.Click += delegate { btnUpdateClickEvent?.Invoke(this, EventArgs.Empty); };
            btnLoc.Click += delegate { btnFilterClickEvent?.Invoke(this, EventArgs.Empty); };
            btnSort.Click += delegate { SortEvent?.Invoke(this, EventArgs.Empty); };

            rbIDKHDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbIDKHInc.CheckedChanged += SortRadioButton_CheckedChanged;

            rbIDNVDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbIDNVInc.CheckedChanged += SortRadioButton_CheckedChanged;

            rbIDHDDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbIDHDInc.CheckedChanged += SortRadioButton_CheckedChanged;

            rbIDPggDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbIDPggInc.CheckedChanged += SortRadioButton_CheckedChanged;

            rbNgayBanDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbNgayBanInc.CheckedChanged += SortRadioButton_CheckedChanged;

            rbDonGiaDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbDonGiaInc.CheckedChanged += SortRadioButton_CheckedChanged;

            rbThanhTienDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbThanhTienInc.CheckedChanged += SortRadioButton_CheckedChanged;

            rbGiamGiaDec.CheckedChanged += SortRadioButton_CheckedChanged;
            rbGiamGiaInc.CheckedChanged += SortRadioButton_CheckedChanged;
        }

        public string HoaDonId
        {
            get => this.txtIDHoaDon.Texts;
            set => this.txtIDHoaDon.Texts = value;
        }
        public string NhanVienId
        {
            get => this.txtIDNhanVien.Texts;
            set => this.txtIDNhanVien.Texts = value;
        }
        public string KhachHangId
        {
            get => this.txtIDKhachHang.Texts;
            set => this.txtIDKhachHang.Texts = value;
        }
        public string PggId
        {
            get => this.txtIDPgg.Texts;
            set => this.txtIDPgg.Texts = value;
        }
        public string NgayBan
        {
            get => this.dtpNgayBan.Text;
            set => this.dtpNgayBan.Text = value;
        }

        public string DonGia
        {
            get => this.txtDonGia.Text;
            set => this.txtDonGia.Text = value;
        }
        public string GiamGia
        {
            get => this.txtGiamGia.Texts;
            set => this.txtGiamGia.Texts = value;
        }
        public string ThanhTien
        {
            get => this.txtThanhTien.Texts;
            set => this.txtThanhTien.Texts = value;
        }
        public string IsAccepted
        {
            get => (this.checkboxIsAccepted.Checked).ToString();
            set => this.checkboxIsAccepted.Checked = bool.Parse(value);
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
            this.dgvHD.DataSource = list;
            templist = list;
        }
        public void LoadData_CT(BindingSource list)
        {
            this.dgvCTHD.DataSource = list;
            templist = list;
        }
        private void SetUpView()
        {
            tcDanhSach.Appearance = TabAppearance.FlatButtons;
            tcDanhSach.ItemSize = new System.Drawing.Size(0, 1);
            tcDanhSach.SizeMode = TabSizeMode.Fixed;
        }
        public void SetTextBoxFillData(HoaDonModel hd)
        {
            this.txtIDHoaDon.Enabled = true;
            this.txtIDHoaDon.Focus();
            this.txtIDHoaDon.Texts = hd.HoaDonId.ToString();
            this.txtIDHoaDon.Enabled = false;

            this.txtIDNhanVien.Enabled = true;
            this.txtIDNhanVien.Focus();
            this.txtIDNhanVien.Texts = hd.NhanVienId.ToString();
            this.txtIDNhanVien.Enabled = false;

            this.dtpNgayBan.Enabled = true;
            this.dtpNgayBan.Focus();
            this.dtpNgayBan.Value = hd.NgayNhap;
            this.dtpNgayBan.Enabled = false;

            this.txtIDKhachHang.Enabled = true;
            this.txtIDKhachHang.Focus();
            this.txtIDKhachHang.Texts = hd.KhachHangId.ToString();
            this.txtIDKhachHang.Enabled = false;

            this.txtIDPgg.Enabled = true;
            this.txtIDPgg.Focus();
            this.txtIDPgg.Texts = hd.PggId.ToString();
            this.txtIDPgg.Enabled = false;

            this.txtDonGia.Enabled = true;
            this.txtDonGia.Focus();
            this.txtDonGia.Texts = hd.PhiTruocGiamGia.ToString();
            this.txtDonGia.Enabled = false;

            this.txtGiamGia.Enabled = true;
            this.txtGiamGia.Focus();
            this.txtGiamGia.Texts = hd.GiamGia.ToString();
            this.txtGiamGia.Enabled = false;

            this.txtThanhTien.Enabled = true;
            this.txtThanhTien.Focus();
            this.txtThanhTien.Texts = hd.PhiSauGiamGia.ToString();
            this.txtThanhTien.Enabled = false;

            this.checkboxIsAccepted.Checked = hd.IsAccepted;
        }

        public void setState(bool isAddState, bool isUpdateState, bool isFilterState, bool isNeedReturnState)
        {
            checkIsAdd = isAddState;
            checkIsUpdate = isUpdateState;
            checkIsfilter = isFilterState;
            isNeedTurn = isNeedReturnState;
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
            List<HoaDonModel> myList = templist.List.OfType<HoaDonModel>().ToList();

            switch (sortType)
            {
                case "IDHDInc":
                    myList = myList.OrderBy(x => x.HoaDonId).ToList();
                    break;
                case "IDHDDec":
                    myList = myList.OrderByDescending(x => x.HoaDonId).ToList();
                    break;
                case "IDNVInc":
                    myList = myList.OrderBy(x => x.NhanVienId).ToList();
                    break;
                case "IDNVDec":
                    myList = myList.OrderByDescending(x => x.NhanVienId).ToList();
                    break;
                case "IDKHInc":
                    myList = myList.OrderBy(x => x.KhachHangId).ToList();
                    break;
                case "IDKHDec":
                    myList = myList.OrderByDescending(x => x.KhachHangId).ToList();
                    break;
                case "IDPggInc":
                    myList = myList.OrderBy(x => x.PggId).ToList();
                    break;
                case "IDPggDec":
                    myList = myList.OrderByDescending(x => x.PggId).ToList();
                    break;
                case "NgayBanInc":
                    myList = myList.OrderBy(x => x.NgayNhap).ToList();
                    break;
                case "NgayBanDec":
                    myList = myList.OrderByDescending(x => x.NgayNhap).ToList();
                    break;
                case "DonGiaInc":
                    myList = myList.OrderBy(x => x.PhiTruocGiamGia).ToList();
                    break;
                case "DonGiaDec":
                    myList = myList.OrderByDescending(x => x.PhiTruocGiamGia).ToList();
                    break;
                case "ThanhTienInc":
                    myList = myList.OrderBy(x => x.PhiSauGiamGia).ToList();
                    break;
                case "ThanhTienDec":
                    myList = myList.OrderByDescending(x => x.PhiSauGiamGia).ToList();
                    break;
                case "GiamGiaInc":
                    myList = myList.OrderBy(x => x.GiamGia).ToList();
                    break;
                case "GiamGiaDec":
                    myList = myList.OrderByDescending(x => x.GiamGia).ToList();
                    break;
                case "True":
                    myList = myList.Where(x => x.IsAccepted).ToList();
                    break;
                case "False":
                    myList = myList.Where(x => !x.IsAccepted).ToList();
                    break;
            }

            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = myList;
            LoadData(myBindingSource);
        }

        private HoaDonModel GetSelectedHoaDonModel(string id)
        {
            int selectedId = int.Parse(id);
            HoaDonModel selectedHd = templist.List.OfType<HoaDonModel>().FirstOrDefault(hd => hd.HoaDonId == selectedId);

            return selectedHd;
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvHD.Rows[e.RowIndex];
                string firstCellData = selectedRow.Cells[0].Value.ToString();
                id = firstCellData;

                // Lấy giá trị từ DataGridView và đặt vào các control
                HoaDonModel selectedPgg = GetSelectedHoaDonModel(id);
                SetTextBoxFillData(selectedPgg);

                // Thông báo cho các thành phần khác rằng đã chọn một giá trị và cần cập nhật
                UpdateEvent?.Invoke(this, EventArgs.Empty);
            }
        }

        private void xacNhanBtn_Click(object sender, EventArgs e)
        {
            if (isNeedTurn)
                tcDanhSach.SelectedTab = tbDanhSach;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (isFilter)
            {
                txtIDHoaDon.Text = "";
                txtIDHoaDon.Enabled = false;
                txtIDHoaDon.BackColor = Color.LightGray;
                txtIDHoaDon.BorderColor = Color.Silver;
            }
            setState(false, false, false, false);
            tcDanhSach.SelectedTab = tbDanhSach;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (gbLoc.Visible)
                gbLoc.Visible = false;
            else
                gbLoc.Visible = true;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (gbSort.Visible)
                gbSort.Visible = false;
            else
                gbSort.Visible = true;
        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            tcDanhSach.SelectedTab = tbChiTiet;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            rbDonGiaDec.Checked = false;
            rbDonGiaInc.Checked = false;
            rbFalse.Checked = false;
            rbGiamGiaDec.Checked = false;
            rbGiamGiaInc.Checked = false;
            rbIDHDDec.Checked = false;
            rbIDHDInc.Checked = false;
            rbIDKHDec.Checked = false;
            rbIDKHInc.Checked = false;
            rbIDNVDec.Checked = false;
            rbIDNVInc.Checked = false;
            rbIDPggDec.Checked = false;
            rbIDPggInc.Checked = false;
            rbNgayBanDec.Checked = false;
            rbNgayBanInc.Checked = false;
            rbThanhTienDec.Checked = false;
            rbTrue.Checked = false;
            rbThanhTienInc.Checked = false;
        }
    }
}
