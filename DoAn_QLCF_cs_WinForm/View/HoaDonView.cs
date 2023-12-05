using DoAn_QLCF_cs_WinForm.View.ViewInterface;

namespace DoAn_QLCF_cs_WinForm.View
{
	public partial class HoaDonView : Form, IHoaDonView
	{
		public HoaDonView()
		{
			InitializeComponent();
            SetUpView();
        }

        private void SetUpView()
        {
            // setup Tabcontrol
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private static HoaDonView instance;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
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
	}
}
