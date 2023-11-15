using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.CustomControl
{
	public class SidePanel: Panel
	{
		private int borderRadius = 10;
		private float gradientAngle = 90F;
		private Color gradientTopColor= Color.Teal;
		private Color gradientBottomColor =Color.FromArgb(255, 51, 153);
		private bool enabledGradient;
		public SidePanel() {
			/*this.BackColor = Color.Teal;*/
		}

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
			RectangleF rectSurfaceF = new RectangleF(0,0,this.Width,this.Height);

			// Gradient
			if (this.EnabledGradient)
			{
				e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
				LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, GradientTopColor, GradientBottomColor, GradientAngle);
				e.Graphics.FillRectangle(brush, this.ClientRectangle);
			}
	

			// BorderRadius
			if (borderRadius > 2)
			{
				using (GraphicsPath pathSurface = GetFigurePath(rectSurfaceF, borderRadius))
				using (Pen penSurface = new Pen(Color.Transparent, 2))
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
