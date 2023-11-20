using DoAn_QLCF_cs_WinForm.View.ViewInterface;

namespace DoAn_QLCF_cs_WinForm.View
{
	public partial class HoaDonView : Form, IHoaDonView
	{
		public HoaDonView()
		{
			InitializeComponent();
		}

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
	}
}
