using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_QLCF_cs_WinForm.CustomControl;
using DoAn_QLCF_cs_WinForm.Model;
using DoAn_QLCF_cs_WinForm.Presenter;
using DoAn_QLCF_cs_WinForm.Repository;
using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;

namespace DoAn_QLCF_cs_WinForm.View
{
    public partial class MainView : Form, IMainView
    {
        // Properties
        private bool isSideBarExpand = true;
        private readonly string connectionString;
        private List<Button> buttonNavList;
        private Form mainFormContainer;
        private NhanVienModel employeeInfor;

        // Interact with Presenter
        public MainPresenter presenter
        {
            private get; set;
        }
        public Form MainFormContainer { get => mainFormContainer; set => mainFormContainer = value; }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ICaPheView view = CaPheView.GetInstance(this);
            ICaPheRepository repo = new CaPheRepository(this.connectionString);
            new CaPhePresenter(view, repo);
        }

        // UI code
        public MainView(string connectionString, NhanVienModel employeeInfor)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.employeeInfor = employeeInfor;
            LoadButtonNav();
            timerLblTitle.Start();
            LoadFormContainer();

            RemoveControlByPermission();
        }

        // hàm xóa những phần không thuộc quyền của user
        private void RemoveControlByPermission()
        {
            // nếu IdPermission = 1 thì là quyền admin, hiển thị tất cả, không cần xóa phần nào
            if (this.employeeInfor.IdPermission == 1)
            {
                return;
            }
            ArrayList arrAction = this.employeeInfor.ArrAction;
            //duyệt qua 10 item menu trong design, item nào ko có trong arrAction thì remove
            for (int i = 1; i <= 10; i++)
            {
                if (!arrAction.Contains(i))
                {
                    switch (i)
                    {
                        case 1:
                            removeControlByName("pn_nhanVien");
                            break;
                        case 2:
                            removeControlByName("pn_khachHang");
                            break;
                        case 3:
                            removeControlByName("pn_caPhe");
                            break;
                        case 4:
                            removeControlByName("pn_nguyenLieu");
                            break;
                        case 5:
                            removeControlByName("pn_nhapHang");
                            break;
                        case 6:
                            removeControlByName("pn_hoaDon");
                            break;
                        case 7:
                            removeControlByName("pn_file");
                            break;
                        case 8:
                            removeControlByName("pn_thongKe");
                            break;
                        case 9:
                            removeControlByName("pn_nhaCungCap");
                            break;
                        case 10:
                            removeControlByName("pn_phanQuyen");
                            break;
                    }
                }
            }
        }

        private void removeControlByName(String name)
        {
            foreach (Control control in sideBar.Controls)
            {
                // Kiểm tra loại của control nếu bạn chỉ quan tâm đến một loại cụ thể
                if (control.Name == name)
                {
                    sideBar.Controls.Remove(control);
                    return;
                }
            }
        }
        private void MainView_Load(object sender, EventArgs e)
        {
            SetDoubleBuffering(backgroundMainView, true);
        }

        private void sideMinimizeTimer_Tick(object sender, EventArgs e)
        {
            if (sideBar.Width == sideBar.MinimumSize.Width)
            {
                sideMinimizeTimer.Stop();
                isSideBarExpand = false;
            }
            sideBar.Width -= 50;
        }


        private void sideExpandTimer_Tick(object sender, EventArgs e)
        {
            if (sideBar.Width == sideBar.MaximumSize.Width)
            {
                sideExpandTimer.Stop();
                isSideBarExpand = true;
            }
            sideBar.Width += 50;
        }


        private void btnMenuSideNav_Click(object sender, EventArgs e)
        {
            if (isSideBarExpand)
            {
                sideMinimizeTimer.Start();
                this.sideNavBtn.Image = (Properties.Resources.navOpenflat);
                HideButtonText();
            }
            else
            {
                sideExpandTimer.Start();
                this.sideNavBtn.Image = (Properties.Resources.navCloseflat);
                ShowButtonText();
            }
        }

        private void MainView_SizeChanged(object sender, EventArgs e)
        {
            if (isSideBarExpand && this.Width <= 820)
            {
                sideMinimizeTimer.Start();
                this.sideNavBtn.Image = (Properties.Resources.navOpenflat);
                HideButtonText();
            }
        }


        private void navLogOut_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).Image = (Image)(Properties.Resources.logoutflatwhite);
        }

        private void navLogOut_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).Image = (Image)(Properties.Resources.logoutflatred2);
        }

        private void LoadButtonNav()
        {
            this.buttonNavList = GetButtonsFromPanels(sideBar.Controls.Cast<Control>().ToList());
        }
        // Phương thức đệ quy để lấy danh sách các nút từ các panel
        private List<Button> GetButtonsFromPanels(List<Control> controls)
        {
            List<Button> buttons = new List<Button>();

            foreach (Control control in controls)
            {
                // Nếu control là một Button, thêm nó vào danh sách
                if (control is Button)
                {
                    buttons.Add((Button)control);
                }
                // Nếu control là một Panel hoặc một control chứa các control khác, gọi đệ quy
                else if (control.HasChildren)
                {
                    buttons.AddRange(GetButtonsFromPanels(control.Controls.Cast<Control>().ToList()));
                }
            }

            return buttons;
        }

        private void HideButtonText()
        {
            foreach (Button btn in buttonNavList)
            {
                btn.Text = "";
            }
        }
        private void ShowButtonText()
        {
            foreach (Button btn in buttonNavList)
            {
                btn.Text = (string)btn.Tag;
            }
        }

        private void ButtonNavClick(object sender, EventArgs e)
        {
            foreach (Button btn in buttonNavList)
            {
                btn.BackColor = Color.Transparent;
            }
            Button button = ((Button)sender);
            button.BackColor = Color.LightSeaGreen;
            imageLblTitle.Image = button.Image;
            textLblTitle.Text = (string)button.Tag;
        }

        public static void SetDoubleBuffering(System.Windows.Forms.Control control, bool value)
        {
            System.Reflection.PropertyInfo controlProperty = typeof(System.Windows.Forms.Control)
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            controlProperty.SetValue(control, value, null);
        }

        private void timerLblTitle_Tick(object sender, EventArgs e)
        {
            timeLblTitle.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void accountIcon_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip1.Show(ptLowerLeft);
        }

        private void LoadFormContainer()
        {
            mainFormContainer = new Form();
            mainFormContainer.TopLevel = false;
            mainPanelContainer.Controls.Add(mainFormContainer);
            mainFormContainer.FormBorderStyle = FormBorderStyle.None;
            mainFormContainer.Dock = DockStyle.Fill;
            mainFormContainer.Padding = new Padding(5);
            mainFormContainer.Show();
        }

        private void navCafe_MouseDown(object sender, MouseEventArgs e)
        {
            ICaPheView view = CaPheView.GetInstance(this.mainFormContainer);
            ICaPheRepository repo = new CaPheRepository(this.connectionString);
            new CaPhePresenter(view, repo);
        }
    }
}
