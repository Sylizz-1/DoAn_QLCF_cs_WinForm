using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Presenter;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class NhapHangView : Form, INhapHangView
    {

        private static NhapHangView instance;
        private string idpn = "1";
        private string idngl = "1";
        public event EventHandler btnAddPNClickEvent;
        public event EventHandler btnAddCTPNClickEvent;
        public event EventHandler btnUpdatePNClickEvent;
        public event EventHandler btnUpdateCTPNClickEvent;
        public event EventHandler btnFilterPNClickEvent;
        public event EventHandler btnFilterCTPNClickEvent;
        public event EventHandler AddPNEvent;
        public event EventHandler AddCTPNEvent;
        public event EventHandler UpdatePNEvent;
        public event EventHandler UpdateCTPNEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SortEvent;
        public event EventHandler FilterPNEvent;
        public event EventHandler FilterCTPNEvent;
        public event EventHandler ResetEvent;
        public event EventHandler FindPnEvent;

        public event EventHandler btnAddNglEvent;
        public event EventHandler btnAddNglClickEvent;

        public bool checkIsAddPN = false;
        public bool checkIsfilterPN = false;
        public bool checkIsUpdatePN = false;
        public bool isNeedTurnPN = false;
        public bool checkIsAddCTPN = false;
        public bool checkIsfilterCTPN = false;
        public bool checkIsUpdateCTPN = false;
        public bool isNeedTurnCTPN = false;

        private BindingSource templist = new BindingSource();
        private List<ChiTietPhieuNhapModel> CtpnList;
        public NhapHangView()
        {
            InitializeComponent();
            SetUpView();
            xacNhanBtn.Click += delegate { AddPNEvent?.Invoke(this, EventArgs.Empty); };
            xacNhanBtn.Click += delegate { UpdatePNEvent?.Invoke(this, EventArgs.Empty); };
            xacNhanBtn.Click += delegate { FilterPNEvent?.Invoke(this, EventArgs.Empty); };
            btnXacNhanCTPN.Click += delegate { AddCTPNEvent?.Invoke(this, EventArgs.Empty); };
            btnXacNhanCTPN.Click += delegate { UpdateCTPNEvent?.Invoke(this, EventArgs.Empty); };
            btnXacNhanCTPN.Click += delegate { FilterCTPNEvent?.Invoke(this, EventArgs.Empty); };

            btnAddPN.Click += delegate { btnAddPNClickEvent?.Invoke(this, EventArgs.Empty); };
            btnAddCTPN.Click += delegate { btnAddCTPNClickEvent?.Invoke(this, EventArgs.Empty); };
            btnEditPN.Click += delegate { btnUpdatePNClickEvent?.Invoke(this, EventArgs.Empty); };
            btnEditCTPN.Click += delegate { btnUpdateCTPNClickEvent?.Invoke(this, EventArgs.Empty); };
            btnFilterPN.Click += delegate { btnFilterPNClickEvent?.Invoke(this, EventArgs.Empty); };
            btnFilterCTPN.Click += delegate { btnFilterCTPNClickEvent?.Invoke(this, EventArgs.Empty); };

            delBtn.Click += delegate { DeleteEvent?.Invoke(this, EventArgs.Empty); };
            sortBtn.Click += delegate { SortEvent?.Invoke(this, EventArgs.Empty); };
            resetBtn.Click += delegate { ResetEvent?.Invoke(this, EventArgs.Empty); };

            btnXacNhanAdd.Click += delegate { btnAddNglEvent?.Invoke(this, EventArgs.Empty); };
            btnFindPn.Click += delegate { FindPnEvent?.Invoke(this, EventArgs.Empty); };
            btnXemPN.Click += delegate { btnUpdatePNClickEvent?.Invoke(this, EventArgs.Empty); };

            this.setStatePN(false, false, false, false);
            this.setStateCTPN(false, false, false, false);
        }
        public List<ChiTietPhieuNhapModel> listCTPN
        {
            get => this.CtpnList;
            set
            {
                BindingSource ctpnBindingSource = new BindingSource();
                ctpnBindingSource.DataSource = value;
                LoadDataCTPN(ctpnBindingSource);
            }
        }
        public string PhieuNhapId
        {
            get => this.txtPhieuNhapId.Texts;
            set => this.txtPhieuNhapId.Texts = value;
        }
        public string NhanVienId
        {
            get => this.cbNhanVienId.SelectedItem.ToString();
            set => this.cbNhanVienId.SelectedItem = int.Parse(value);
        }
        public string NhaCungCapId
        {
            get => this.cbNccId.SelectedItem.ToString();
            set => this.cbNccId.SelectedItem = int.Parse(value);
        }
        public string NgayNhap
        {
            get
            {
                if (this.dtpPN.Value == this.dtpPN.MinDate)
                    return null;
                else
                    return this.dtpPN.Value.ToString("yyyy-MM-dd");
            }
            set => this.dtpPN.Value = DateTime.Parse(value);
        }

        public string TongTien
        {
            get => this.txtTongTien.Texts;
            set => this.txtTongTien.Texts = value;
        }
        public string NguyenLieuId
        {
            get => this.cbNglId.SelectedItem.ToString();
            set => this.cbNglId.SelectedItem = value;
        }
        public string KhoiLuong
        {
            get => this.txtCTPNKhoiLuong.Texts;
            set => this.txtCTPNKhoiLuong.Texts = value;
        }
        public string DonGia
        {
            get => this.txtCTPNDonGia.Texts;
            set => this.txtCTPNDonGia.Texts = value;
        }
        public string selectedIdPN
        {
            get => this.idpn;
            set => this.idpn = value;
        }
        public string selectedIdNGL
        {
            get => this.idngl;
            set => this.idngl = value;
        }
        public string PNcount
        {
            get => this.dgvDsNhapHang.RowCount.ToString();
        }
        public bool isAddPN
        {
            get => checkIsAddPN;
            set => checkIsAddPN = value;
        }
        public bool isFilterPN
        {
            get => checkIsfilterPN;
            set => checkIsfilterPN = value;
        }
        public bool isUpdatePN
        {
            get => checkIsUpdatePN;
            set => checkIsUpdatePN = value;
        }
        public bool isAddCTPN
        {
            get => checkIsAddCTPN;
            set => checkIsAddCTPN = value;
        }
        public bool isFilterCTPN
        {
            get => checkIsfilterCTPN;
            set => checkIsfilterCTPN = value;
        }
        public bool isUpdateCTPN
        {
            get => checkIsUpdateCTPN;
            set => checkIsUpdateCTPN = value;
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
        public string KhoiLuongNgl
        {
            get => this.txtNglWeigh.Texts;
            set => this.txtNglWeigh.Texts = value;
        }
        public string GiaTien_Kg
        {
            get => this.txtNglPrice.Texts;
            set => this.txtNglPrice.Texts = value;
        }
        public string HinhAnh
        {
            get
            {
                string fullPath = this.caPhePic.ImageLocation;
                int lastIndexOfSlash = fullPath.LastIndexOf("\\");
                if (lastIndexOfSlash != -1)
                {
                    string croppedPath = fullPath.Substring(lastIndexOfSlash + 1);
                    return croppedPath;
                }
                return fullPath;
            }
            set
            {
                try
                {
                    this.caPhePic.ImageLocation = value;
                    this.caPhePic.Image = Image.FromFile(value);
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("Ảnh quá bộ nhớ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                    HinhAnh = Path.Combine(path, "Resources\\defaultImage3.png");
                }
            }
        }
        public string FindText
        {
            get => searchTxt.Texts;
            set => searchTxt.Texts = value;
        }
        private void SetUpView()
        {
            tcNhapHang.Appearance = TabAppearance.FlatButtons;
            tcNhapHang.ItemSize = new System.Drawing.Size(0, 1);
            tcNhapHang.SizeMode = TabSizeMode.Fixed;
        }

        public static INhapHangView GetInstance(Form parentContainer)
        {
            instance = null;
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
        public void GetIdPNAdd(int id)
        {
            this.txtPhieuNhapId.Enabled = true;
            this.txtPhieuNhapId.Focus();
            this.txtPhieuNhapId.Texts = id.ToString();
            this.txtPhieuNhapId.Enabled = false;
            this.cbNhanVienId.Focus();

            this.txtCTPNId.Enabled = true;
            this.txtCTPNId.Focus();
            this.txtCTPNId.Texts = id.ToString();
            this.txtCTPNId.Enabled = false;
        }
        public void LoadDataPN(BindingSource list)
        {
            this.dgvDsNhapHang.DataSource = list;
            templist = list;
            dgvDsNhapHang.ClearSelection();
            selectedIdPN = "0";
        }

        public void LoadDataCTPN(BindingSource list)
        {
            this.dgvCTPN.DataSource = list;
            if (list != null)
            {
                float tongtien = 0;
                foreach (ChiTietPhieuNhapModel item in list)
                {
                    tongtien += item.DonGia * item.KhoiLuong;
                }
                TongTien = tongtien.ToString();
            }

        }
        public void LoadDataNV(BindingSource list, int index)
        {
            List<string> name = new List<string>();
            List<string> id = new List<string>();
            foreach (NhanVienModel nv in list)
            {
                if(index == -1)
                {
                    if (!nv.isDelete)
                    {
                        name.Add(nv.Name);
                        id.Add(nv.Id.ToString());
                    }
                }
                else if (index == 0)
                {
                    name.Add(nv.Name);
                    id.Add(nv.Id.ToString());
                }
                else
                {
                    if (!nv.isDelete || nv.Id == index)
                    {
                        name.Add(nv.Name);
                        id.Add(nv.Id.ToString());
                    }
                }
            }
            cbNhanVienId.DataSource = id;
            cbNhanVienName.DataSource = name;
        }
        public void LoadDataNCC(BindingSource list, int index)
        {
            List<string> name = new List<string>();
            List<string> id = new List<string>();
            foreach (NccModel ncc in list)
            {
                if (index == -1)
                {
                    if (!ncc.IsDelete)
                    {
                        name.Add(ncc.TenNhaCungCap);
                        id.Add(ncc.NhaCungCapId.ToString());
                    }
                }
                else if (index == 0)
                {
                    name.Add(ncc.TenNhaCungCap);
                    id.Add(ncc.NhaCungCapId.ToString());
                }
                else
                {
                    if (!ncc.IsDelete || ncc.NhaCungCapId == index)
                    {
                        name.Add(ncc.TenNhaCungCap);
                        id.Add(ncc.NhaCungCapId.ToString());
                    }
                }
            }
            cbNccId.DataSource = id;
            cbNccName.DataSource = name;
        }
        public void LoadDataNgl(BindingSource list, int index)
        {

            List<string> name = new List<string>();
            List<string> id = new List<string>();
            foreach (NguyenLieuModel ngl in list)
            {
                if (index == -1)
                {
                    if (!ngl.IsDelete)
                    {
                        id.Add(ngl.NguyenLieuId.ToString());
                        name.Add(ngl.TenNguyenLieu);
                    }
                }
                else if (index == 0)
                {
                    id.Add(ngl.NguyenLieuId.ToString());
                    name.Add(ngl.TenNguyenLieu);
                }
                else
                {
                    if (!ngl.IsDelete || ngl.NguyenLieuId == index)
                    {
                        id.Add(ngl.NguyenLieuId.ToString());
                        name.Add(ngl.TenNguyenLieu);
                    }
                }
            }
            cbNglId.DataSource = id;
            cbNglName.DataSource = name;
        }

        private void cbNhanVienId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbNhanVienId.SelectedIndex;
            cbNhanVienName.SelectedIndex = index;
        }

        private void cbNhanVienName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbNhanVienName.SelectedIndex;
            cbNhanVienId.SelectedIndex = index;
        }

        private void cbNccId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbNccId.SelectedIndex;
            cbNccName.SelectedIndex = index;
        }

        private void cbNccName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbNccName.SelectedIndex;
            cbNccId.SelectedIndex = index;
        }
        public void setStatePN(bool isAddState, bool isUpdateState, bool isFilterState, bool isNeedReturnState)
        {
            checkIsAddPN = isAddState;
            checkIsUpdatePN = isUpdateState;
            checkIsfilterPN = isFilterState;
            isNeedTurnPN = isNeedReturnState;
        }
        public void setStateCTPN(bool isAddState, bool isUpdateState, bool isFilterState, bool isNeedReturnState)
        {
            checkIsAddCTPN = isAddState;
            checkIsUpdateCTPN = isUpdateState;
            checkIsfilterCTPN = isFilterState;
            isNeedTurnCTPN = isNeedReturnState;
        }


        //PN
        public bool CheckInputPN()
        {
            string s = "Vui lòng nhập ";
            if (cbNhanVienId.SelectedIndex < 0)
            {
                s += "nhân viên nhập hàng";
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbNccId.SelectedIndex < 0)
            {
                s += "nhà cung cấp hàng";
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (CtpnList.Count == 0)
            {
                s += "thêm chi tiết phiếu nhập";
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void SetPNNull()
        {
            if (isAddPN)
            {
                lbPN.Visible = false;
                txtPhieuNhapId.Visible = false;
                lbCTPNId.Visible = false;
                txtCTPNId.Visible = false;
            }
            else
            {
                lbPN.Visible = true;
                txtPhieuNhapId.Visible = true;
                lbCTPNId.Visible = true;
                txtCTPNId.Visible = true;
            }
            if (isFilterPN)
            {
                txtPhieuNhapId.Enabled = true;
                txtPhieuNhapId.BackColor = Color.White;
                txtPhieuNhapId.Texts = "";
                txtPhieuNhapId.BorderColor = Color.DarkCyan;
                txtPhieuNhapId.Focus();

                txtTongTien.Enabled = true;
                txtTongTien.BackColor = Color.White;
                txtTongTien.Texts = "";
                txtTongTien.BorderColor = Color.DarkCyan;
                txtTongTien.Focus();

                dtpPN.Value = dtpPN.MinDate;
                gbCTPN.Visible = false;
            }
            else
                gbCTPN.Visible = true;
            dtpPN.Enabled = true;
            cbNhanVienId.Enabled = true;
            cbNhanVienName.Enabled = true;
            cbNccId.Enabled = true;
            cbNccName.Enabled = true;
            txtTongTien.Enabled = true;
            cbNhanVienId.SelectedIndex = -1;
            cbNccId.SelectedIndex = -1;
        }
        private void SortRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tcNhapHang.SelectedTab == listTabPage)
            {
                if (sender is RadioButton radioButton && radioButton.Checked)
                {
                    string sortType = radioButton.Tag.ToString();
                    SortListModels(sortType);
                }
            }
            else if (tcNhapHang.SelectedTab == detailTabPage)
                if (sender is RadioButton radioButtonctpn && radioButtonctpn.Checked)
                {
                    string sortType = radioButtonctpn.Tag.ToString();
                    SortListModelsCTPN(sortType);
                }
        }
        private void SortListModels(string sortType)
        {
            List<PhieuNhapModel> myList = templist.List.OfType<PhieuNhapModel>().ToList();
            switch (sortType)
            {
                case "IDPnInc":
                    myList.Sort((x, y) => x.PhieuNhapId.CompareTo(y.PhieuNhapId));
                    break;
                case "IDPnDec":
                    myList.Sort((x, y) => y.PhieuNhapId.CompareTo(x.PhieuNhapId));
                    break;
                case "IDNvInc":
                    myList.Sort((x, y) => x.NhanVienId.CompareTo(y.NhanVienId));
                    break;
                case "IDNvDec":
                    myList.Sort((x, y) => y.NhanVienId.CompareTo(x.NhanVienId));
                    break;
                case "IDNccInc":
                    myList.Sort((x, y) => x.NhaCungCapId.CompareTo(y.NhaCungCapId));
                    break;
                case "IDNccDec":
                    myList.Sort((x, y) => y.NhaCungCapId.CompareTo(x.NhaCungCapId));
                    break;
                case "NgayNhapInc":
                    myList.Sort((x, y) => x.NgayNhap.CompareTo(y.NgayNhap));
                    break;
                case "NgayNhapDec":
                    myList.Sort((x, y) => y.NgayNhap.CompareTo(x.NgayNhap));
                    break;
                case "TongTienInc":
                    myList.Sort((x, y) => x.TongTien.CompareTo(y.TongTien));
                    break;
                case "TongTienDec":
                    myList.Sort((x, y) => y.TongTien.CompareTo(x.TongTien));
                    break;
            }
            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = myList;
            LoadDataPN(myBindingSource);
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            rbIDPnInc.Checked = false;
            rbIDPnDec.Checked = false;
            rbIDNvInc.Checked = false;
            rbIDNvDec.Checked = false;
            rbIDNccInc.Checked = false;
            rbIDNccDec.Checked = false;
            rbNNInc.Checked = false;
            rbNNDec.Checked = false;
            rbTTInc.Checked = false;
            rbTTDec.Checked = false;

            dgvDsNhapHang.ClearSelection();
            selectedIdPN = "0";
        }
        private void btnAddPN_Click(object sender, EventArgs e)
        {
            CtpnList = new List<ChiTietPhieuNhapModel>();
            LoadDataCTPN(null);
            txtTongTien.Texts = "0";
            tcNhapHang.SelectedTab = detailTabPage;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            tcNhapHang.SelectedTab = listTabPage;
            this.setStatePN(false, false, false, false);
            dgvDsNhapHang.ClearSelection();
            selectedIdPN = "0";
            pnCTPN.Visible = true;
            HuyBtn.Visible = true;
            xacNhanBtn.Visible = true;
        }
        private void btnEditPN_Click(object sender, EventArgs e)
        {
            if (dgvDsNhapHang.RowCount > 0 && selectedIdPN != "0")
            {
                tcNhapHang.SelectedTab = detailTabPage;
                dtpPN.Enabled = true;
                cbNhanVienId.Enabled = true;
                cbNhanVienName.Enabled = true;
                cbNccId.Enabled = true;
                cbNccName.Enabled = true;

                lbPN.Visible = true;
                txtCTPNId.Visible = true;
            }
        }
        private void filterBtn_Click(object sender, EventArgs e)
        {
            tcNhapHang.SelectedTab = detailTabPage;
            lbPN.Visible = true;
            txtCTPNId.Visible = true;
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
            if (isNeedTurnPN)
                tcNhapHang.SelectedTab = listTabPage;
            else
                loadCTPN();
            dgvDsNhapHang.ClearSelection();
            selectedIdPN = "0";
        }
        private void HuyBtn_Click(object sender, EventArgs e)
        {
            this.setStatePN(false, false, false, false);
            tcNhapHang.SelectedTab = listTabPage;
            dgvDsNhapHang.ClearSelection();
            selectedIdPN = "0";
        }
        public void FillDataDetailPage(PhieuNhapModel pn, List<ChiTietPhieuNhapModel> list)
        {
            lbPN.Visible = true;
            txtPhieuNhapId.Visible = true;
            lbCTPNId.Visible = true;
            txtCTPNId.Visible = true;

            this.txtPhieuNhapId.Enabled = true;
            this.txtPhieuNhapId.Focus();
            this.txtPhieuNhapId.Texts = pn.PhieuNhapId.ToString();
            this.txtPhieuNhapId.Enabled = false;

            NgayNhap = pn.NgayNhap.ToString();
            NhaCungCapId = pn.NhaCungCapId.ToString();
            cbNhanVienId.SelectedItem = pn.NhanVienId.ToString();
            gbCTPN.Visible = true;
            CtpnList = list;

            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = list;
            LoadDataCTPN(myBindingSource);
        }
        private void dgvDsNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDsNhapHang.Rows[e.RowIndex];
                string firstCellData = selectedRow.Cells[0].Value.ToString();
                idpn = firstCellData;
                GetIdPNAdd(int.Parse(idpn));
            }
        }

        private void btnXemPN_Click(object sender, EventArgs e)
        {
            if (dgvDsNhapHang.RowCount > 0 && selectedIdPN != "0")
            {
                tcNhapHang.SelectedTab = detailTabPage;
                gbCTPN.Visible = true;
                pnCTPN.Visible = false;
                HuyBtn.Visible = false;
                xacNhanBtn.Visible = false;

                dtpPN.Enabled = false;
                cbNhanVienId.Enabled = false;
                cbNhanVienName.Enabled = false;
                cbNccId.Enabled = false;
                cbNccName.Enabled = false;
                txtTongTien.Enabled = false;
            }
        }
        private void loadCTPN()
        {
            BindingSource temp = new BindingSource();
            temp.DataSource = CtpnList;
            LoadDataCTPN(temp);
        }

        //CTPN
        public void AddTempNgl(ChiTietPhieuNhapModel ctpn)
        {
            for (int i = 0; i < CtpnList.Count; i++)
                if (CtpnList[i].NguyenLieuId == ctpn.NguyenLieuId)
                    CtpnList.Remove(CtpnList[i]);

            CtpnList.Add(ctpn);
            BindingSource temp = new BindingSource();
            temp.DataSource = CtpnList;
            LoadDataCTPN(temp);
        }
        public void SetNull()
        {
            cbNglId.Enabled = true;
            cbNglName.Enabled = true;
            txtCTPNKhoiLuong.Texts = "";
            txtCTPNDonGia.Texts = "";
            cbNglId.SelectedIndex = -1;
            cbNglName.SelectedIndex = -1;
            txtCTPNKhoiLuong.BorderColor = Color.DarkCyan;
            txtCTPNDonGia.BorderColor = Color.DarkCyan;
        }
        private void btn_addCTPN_Click(object sender, EventArgs e)
        {
            btnAddNgl.Visible = true;
            txtCTPNId.BackColor = Color.LightGray;
            txtCTPNId.BorderColor = Color.Silver;
            tcNhapHang.SelectedTab = moreDetailTabPage;
        }
        private void btnEditCTPN_Click(object sender, EventArgs e)
        {
            if (CtpnList.Count > 0)
            {
                btnAddNgl.Visible = true;
                tcNhapHang.SelectedTab = moreDetailTabPage;
                foreach (ChiTietPhieuNhapModel ctpn in CtpnList)
                    if (ctpn.NguyenLieuId.ToString() == idngl)
                    {
                        cbNglId.SelectedItem = idngl;
                        cbNglId.Enabled = false;
                        cbNglName.Enabled = false;
                        this.txtCTPNId.Enabled = true;
                        this.txtCTPNId.Focus();
                        this.txtCTPNId.Texts = ctpn.PhieuNhapId.ToString();
                        this.txtCTPNId.Enabled = false;

                        this.txtCTPNDonGia.Focus();
                        this.txtCTPNDonGia.Texts = ctpn.DonGia.ToString();
                        this.txtCTPNKhoiLuong.Focus();
                        this.txtCTPNKhoiLuong.Texts = ctpn.KhoiLuong.ToString();
                    }
            }
        }
        private void btnDeleteCTPN_Click(object sender, EventArgs e)
        {
            if (CtpnList.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa chi tiết phiếu nhập", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    for (int i = 0; i < CtpnList.Count; i++)
                        if (CtpnList[i].NguyenLieuId.ToString() == idngl)
                            CtpnList.Remove(CtpnList[i]);
                    BindingSource temp = new BindingSource();
                    temp.DataSource = CtpnList;
                    LoadDataCTPN(temp);
                }
            }
            else
                MessageBox.Show("Danh sách rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_back2_Click(object sender, EventArgs e)
        {
            tcNhapHang.SelectedTab = detailTabPage;
            this.setStateCTPN(false, false, false, false);
            loadCTPN();
        }
        private void btnHuyCTPN_Click(object sender, EventArgs e)
        {
            tcNhapHang.SelectedTab = detailTabPage;
            this.setStateCTPN(false, false, false, false);
            loadCTPN();
        }
        public bool CheckInputCTPN()
        {
            string s = "Vui lòng nhập ";
            if (string.IsNullOrEmpty(txtCTPNKhoiLuong.Texts) || !float.TryParse(txtCTPNKhoiLuong.Texts, out _))
            {
                s += "Khối lượng nguyên liệu (số)";
                txtCTPNKhoiLuong.BorderColor = Color.Red;
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                txtCTPNKhoiLuong.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtCTPNDonGia.Texts) || !float.TryParse(txtCTPNDonGia.Texts, out _))
            {
                s += "Giá nguyên liệu (số)";
                txtCTPNDonGia.BorderColor = Color.Red;
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                txtCTPNDonGia.BorderColor = Color.DarkCyan;
            if (cbNglId.SelectedIndex < 0)
            {
                s += "Id Nguyên liệu";
                cbNglId.BackColor = Color.Tomato;
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                cbNglId.BackColor = Color.White;
            if (cbNglName.SelectedIndex < 0)
            {
                s += "Tên Nguyên liệu";
                cbNglName.BackColor = Color.Tomato;
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                cbNglName.BackColor = Color.White;
            return true;
        }

        private void cbNglId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbNglId.SelectedIndex;
            cbNglName.SelectedIndex = index;
            cbNglId.BackColor = Color.White;
            cbNglName.BackColor = Color.White;
            bool check = false;
            if(index > -1)
            {
                foreach (ChiTietPhieuNhapModel ct in CtpnList)
                {
                    if (ct.NguyenLieuId == int.Parse(cbNglId.SelectedValue.ToString()))
                    {
                        this.txtCTPNDonGia.Focus();
                        this.txtCTPNDonGia.Texts = ct.DonGia.ToString();
                        this.txtCTPNKhoiLuong.Focus();
                        this.txtCTPNKhoiLuong.Texts = ct.KhoiLuong.ToString();
                        check = true;
                        break;
                    }
                }
            }    
            if(!check)
            {
                DonGia = "";
                KhoiLuong = "";
            }
        }

        private void cbNglName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbNglName.SelectedIndex;
            cbNglId.SelectedIndex = index;
            cbNglName.BackColor = Color.White;
            cbNglId.BackColor = Color.White;
        }
        private void txtCTPNKhoiLuong__TextChanged(object sender, EventArgs e)
        {
            int result;
            if ((int.TryParse(txtCTPNKhoiLuong.Texts, out result) && txtCTPNKhoiLuong.Texts.Length > 0) && (isFilterCTPN || int.TryParse(txtCTPNKhoiLuong.Texts, out result)))
                txtCTPNKhoiLuong.BorderColor = Color.DarkCyan;
            else
                txtCTPNKhoiLuong.BorderColor = Color.Red;
        }
        private void txtCTPNDonGia__TextChanged(object sender, EventArgs e)
        {
            int result;
            if ((int.TryParse(txtCTPNDonGia.Texts, out result) && txtCTPNDonGia.Texts.Length > 0) && (isFilterCTPN || int.TryParse(txtCTPNDonGia.Texts, out result)))
                txtCTPNDonGia.BorderColor = Color.DarkCyan;
            else
                txtCTPNDonGia.BorderColor = Color.Red;
        }
        private void cbNglId_Click(object sender, EventArgs e)
        {
            cbNglName.BackColor = Color.White;
            cbNglId.BackColor = Color.White;
        }

        private void cbNglName_Click(object sender, EventArgs e)
        {
            cbNglName.BackColor = Color.White;
            cbNglId.BackColor = Color.White;
        }

        private void dgvNgl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCTPN.Rows[e.RowIndex];
                string firstCellData = selectedRow.Cells[1].Value.ToString();
                idngl = firstCellData;
            }
        }

        private void btnXacNhanCTPN_Click(object sender, EventArgs e)
        {
            if (isNeedTurnCTPN)
                tcNhapHang.SelectedTab = detailTabPage;
        }

        private void btnFilterCTPN_Click(object sender, EventArgs e)
        {
            btnAddNgl.Visible = false;
            tcNhapHang.SelectedTab = moreDetailTabPage;

            List<ChiTietPhieuNhapModel> ctpnList = new List<ChiTietPhieuNhapModel>();
            foreach (DataGridViewRow row in dgvCTPN.Rows)
            {
                if (!row.IsNewRow && row.Index != -1)
                {
                    ChiTietPhieuNhapModel ctpn = new ChiTietPhieuNhapModel();
                    int phieuNhapId;
                    if (int.TryParse(row.Cells[0].Value?.ToString(), out phieuNhapId))
                        ctpn.PhieuNhapId = phieuNhapId;
                    int nguyenLieuId;
                    if (int.TryParse(row.Cells[1].Value?.ToString(), out nguyenLieuId))
                        ctpn.NguyenLieuId = nguyenLieuId;
                    float khoiLuong;
                    if (float.TryParse(row.Cells[2].Value?.ToString(), out khoiLuong))
                        ctpn.KhoiLuong = khoiLuong;
                    float donGia;
                    if (float.TryParse(row.Cells[3].Value?.ToString(), out donGia))
                        ctpn.DonGia = donGia;
                    ctpnList.Add(ctpn);
                }
            }
            if (CtpnList.Count <= ctpnList.Count)
            {
                CtpnList.Clear();
                CtpnList = ctpnList;
            }
        }

        private void resetCTPNBtn_Click(object sender, EventArgs e)
        {
            rbIDNglInc.Checked = false;
            rbIDNglDec.Checked = false;
            rbKLNglInc.Checked = false;
            rbKLNglDec.Checked = false;
            rbDGNglInc.Checked = false;
            rbDGNglDec.Checked = false;

            SortListModelsCTPN("IDNglInc");
        }
        private void btnSortCTPN_Click(object sender, EventArgs e)
        {
            if (gbCtpnSort.Visible)
                gbCtpnSort.Visible = false;
            else
                gbCtpnSort.Visible = true;
        }
        private void SortListModelsCTPN(string sortType)
        {
            List<ChiTietPhieuNhapModel> myList = CtpnList;
            switch (sortType)
            {
                case "IDNglInc":
                    myList.Sort((x, y) => x.NguyenLieuId.CompareTo(y.NguyenLieuId));
                    break;
                case "IDNglDec":
                    myList.Sort((x, y) => y.NguyenLieuId.CompareTo(x.NguyenLieuId));
                    break;
                case "KhoiLuongInc":
                    myList.Sort((x, y) => x.KhoiLuong.CompareTo(y.KhoiLuong));
                    break;
                case "KhoiLuongDec":
                    myList.Sort((x, y) => y.KhoiLuong.CompareTo(x.KhoiLuong));
                    break;
                case "DonGiaInc":
                    myList.Sort((x, y) => x.DonGia.CompareTo(y.DonGia));
                    break;
                case "DonGiaDec":
                    myList.Sort((x, y) => y.DonGia.CompareTo(x.DonGia));
                    break;
            }
            BindingSource myBindingSource = new BindingSource();
            myBindingSource.DataSource = myList;
            LoadDataCTPN(myBindingSource);
        }

        //Thêm nguyên liệu
        public bool CheckInputNgl()
        {
            string checkPath = "defaultImage3.png";
            string s = "Vui lòng nhập ";
            if (string.IsNullOrEmpty(txtNglName.Texts))
            {
                s += "Tên nguyên liệu";
                txtNglName.BorderColor = Color.Red;
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                txtNglName.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtNglInfo.Texts))
            {
                s += "Thông tin nguyên liệu";
                txtNglInfo.BorderColor = Color.Red;
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                txtNglInfo.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtNglWeigh.Texts) || !float.TryParse(txtNglWeigh.Texts, out _))
            {
                s += "Khối lượng nguyên liệu (số)";
                txtNglWeigh.BorderColor = Color.Red;
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                txtNglWeigh.BorderColor = Color.DarkCyan;
            if (string.IsNullOrEmpty(txtNglPrice.Texts) || !float.TryParse(txtNglPrice.Texts, out _))
            {
                s += "Giá nguyên liệu (số)";
                txtNglPrice.BorderColor = Color.Red;
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                txtNglPrice.BorderColor = Color.DarkCyan;
            if (HinhAnh == checkPath)
            {
                s += "Hình ảnh";
                MessageBox.Show(s, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void SetNullNgl()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            HinhAnh = Path.Combine(path, "Resources\\defaultImage3.png");
            txtNglName.PlaceholderText = string.Empty;
            txtNglName.Texts = "";
            txtNglInfo.Texts = "";
            txtNglWeigh.Texts = "";
            txtNglPrice.Texts = "";
            txtNglName.BorderColor = Color.DarkCyan;
            txtNglInfo.BorderColor = Color.DarkCyan;
            txtNglWeigh.BorderColor = Color.DarkCyan;
            txtNglPrice.BorderColor = Color.DarkCyan;

        }
        private void btnAddNgl_Click(object sender, EventArgs e)
        {
            tcNhapHang.SelectedTab = addNgl;
            SetNullNgl();
        }

        private void btnBackCTPN_Click(object sender, EventArgs e)
        {
            tcNhapHang.SelectedTab = moreDetailTabPage;
        }

        private void btnXacNhanAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnHuyAdd_Click(object sender, EventArgs e)
        {
            tcNhapHang.SelectedTab = moreDetailTabPage;
        }

        private void caPhePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                HinhAnh = open.FileName;
            }
        }
    }
}
