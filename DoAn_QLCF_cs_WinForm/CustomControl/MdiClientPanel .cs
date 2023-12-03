using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.CustomControl
{
	public class MdiClientPanel: Panel
	{
		private Form mdiForm;
		private MdiClient ctlClient = new MdiClient();

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		public MdiClientPanel()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
		{
			base.Controls.Add(this.ctlClient);
		}

		public Form MdiForm
		{
			get
			{
				if (this.mdiForm == null)
				{
					this.mdiForm = new Form();
					/// set the hidden ctlClient field which is used to determine if the form is an MDI form
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
					System.Reflection.FieldInfo field = typeof(Form).GetField("ctlClient", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
					field.SetValue(this.mdiForm, this.ctlClient);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
				}
				return this.mdiForm;
			}
		}
		private int borderRadius = 10;
		private float gradientAngle = 90F;
		private Color gradientTopColor = Color.Teal;
		private Color gradientBottomColor = Color.FromArgb(255, 51, 153);
		private bool enabledGradient;

		[Category("Custom")]
		public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }
		[Category("Custom")]
		public float GradientAngle { get => gradientAngle; set { gradientAngle = value; this.Invalidate(); } }

		[Category("Custom")]
		public Color GradientTopColor { get => gradientTopColor; set { gradientTopColor = value; this.Invalidate(); } }
		[Category("Custom")]
		public Color GradientBottomColor { get => gradientBottomColor; set { gradientBottomColor = value; this.Invalidate(); } }

		[Category("Custom")]
		public bool EnabledGradient { get => enabledGradient; set { enabledGradient = value; this.Invalidate(); } }

		// Private Methods
		private GraphicsPath GetFigurePath(RectangleF rec, float radius)
		{
			float diameter = radius * 2F;
			GraphicsPath path = new GraphicsPath();
			path.StartFigure();
			path.AddArc(rec.X, rec.Y, diameter, diameter, 180, 90);
			path.AddArc(rec.Right - diameter, rec.Y, diameter, diameter, 270, 90);
			path.AddArc(rec.Right - diameter, rec.Bottom - diameter, diameter, diameter, 0, 90);
			path.AddArc(rec.X, rec.Bottom - diameter, diameter, diameter, 90, 90);

			path.CloseFigure();
			return path;
		}

		// Override Methods
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			RectangleF rectSurfaceF = new RectangleF(0, 0, this.Width, this.Height);
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

			// Gradient
			if (this.EnabledGradient)
			{
				LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, GradientTopColor, GradientBottomColor, GradientAngle);
				e.Graphics.FillRectangle(brush, this.ClientRectangle);
			}


			// BorderRadius
			if (borderRadius > 2)
			{
				using (GraphicsPath pathSurface = GetFigurePath(rectSurfaceF, borderRadius))
				using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
				{
					this.Region = new Region(pathSurface);
					e.Graphics.DrawPath(penSurface, pathSurface);

				}
			}
			else this.Region = new Region(rectSurfaceF);
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			this.Invalidate();
		}

		protected override void OnResize(EventArgs eventargs)
		{
			base.OnResize(eventargs);
			this.Invalidate();
		}

	}
}
