using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.CustomControl
{
	public class CustomButton: Button
	{
		public CustomButton() {
			this.FlatStyle = FlatStyle.Flat;
			this.FlatAppearance.BorderSize = 0;
			this.Size = new Size(150, 40);
			this.BackColor = Color.MediumSlateBlue;
			this.ForeColor = Color.White;
			/*this.Resize += new EventHandler(Button_Resize);*/
			this.textHover = this.ForeColor;
		}

		private void Button_Resize(object? sender, EventArgs e)
		{
			if (borderRadius > this.Height)
				borderRadius = this.Height;
		}

		//Fields
		private int borderSize = 0;
		private int borderRadius = 20;
		private Color borderColor = Color.PaleVioletRed;
		private Color textHover;
		private Color textHoverTemp;
		private bool enabledTextHover;
		//Properties
		[Category("Custom")]
		public int BorderSize
		{
			get { return borderSize; }
			set
			{
				borderSize = value;
				this.Invalidate();
			}
		}
		[Category("Custom")]
		public int BorderRadius
		{
			get { return borderRadius; }
			set
			{
				borderRadius = value;
				this.Invalidate();
			}
		}
		[Category("Custom")]
		public Color BorderColor
		{
			get { return borderColor; }
			set
			{
				borderColor = value;
				this.Invalidate();
			}
		}
		[Category("Custom")]
		public Color BackgroundColor
		{
			get { return this.BackColor; }
			set { this.BackColor = value; }
		}
		[Category("Custom")]
		public Color TextColor
		{
			get { return this.ForeColor; }
			set { this.ForeColor = value; }
		}

		[Category("Custom")]
		public Color TextHover { get => textHover; set { textHover = value; this.Invalidate(); }  }

		[Category("Custom")]
		public bool EnabledTextHover { get => enabledTextHover; set { enabledTextHover = value; } }


		//Methods
		private GraphicsPath GetFigurePath(Rectangle rect, float radius)
		{
			GraphicsPath path = new GraphicsPath();
			float curveSize = radius * 2F;

			path.StartFigure();
			path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
			path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
			path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
			path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
			path.CloseFigure();
			return path;
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);

			Rectangle rectSurface = this.ClientRectangle;
			Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
			int smoothSize = 2;
			if (borderSize > 0)
				smoothSize = borderSize;

			if (borderRadius > 2) //Rounded button
			{
				using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
				using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
				using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
				using (Pen penBorder = new Pen(borderColor, borderSize))
				{
					pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
					//Button surface
					this.Region = new Region(pathSurface);
					//Draw surface border for HD result
					pevent.Graphics.DrawPath(penSurface, pathSurface);

					//Button border                    
					if (borderSize >= 1)
						//Draw control border
						pevent.Graphics.DrawPath(penBorder, pathBorder);
				}
			}
			else //Normal button
			{
				pevent.Graphics.SmoothingMode = SmoothingMode.None;
				//Button surface
				this.Region = new Region(rectSurface);
				//Button border
				if (borderSize >= 1)
				{
					using (Pen penBorder = new Pen(borderColor, borderSize))
					{
						penBorder.Alignment = PenAlignment.Inset;
						pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
					}
				}
			}
		}


		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
		}

		private void Container_BackColorChanged(object sender, EventArgs e)
		{
			this.Invalidate();
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			if (this.EnabledTextHover)
			{
				this.textHoverTemp = this.ForeColor;
				this.ForeColor = this.TextHover;
			}
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			if (this.EnabledTextHover)
				this.ForeColor = this.textHoverTemp;
		}

	}
}
