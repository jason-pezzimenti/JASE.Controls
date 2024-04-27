using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JASE.Controls
{
	public partial class Separator : Control
	{
		[Browsable(true), DisplayName("Using Gradient"), Category("Behavior"), Description("Gets or sets whether to use a Gradient.")]
		public bool UsingGradient { get; set; }
		[Browsable(true), DisplayName("Is Enabled"), Category("Behavior"), Description("Gets or sets whether the Separator is Enabled.")]
		public bool IsEnabled { get; set; } = true;
		[Browsable(true), DisplayName("Is Dashed"), Category("Behavior"), Description("Gets or sets whether the Line is dashed.")]
		public bool IsDashed { get; set; }
		[Browsable(true), DisplayName("Dash Style"), Category("Appearance"), Description("Gets or sets the Dash Style for this Control.")]
		public DashStyle Style { get; set; }
		[Browsable(true), DisplayName("Dash Pattern"), Category("Appearance"), Description("Gets or sets the Dash Pattern for this Dashed Line.")]
		public float[] DashPattern { get; set; }

		public enum Directions
		{
			Horizontal = 0,
			Vertical
		}

		[Browsable(true), DisplayName("Direction"), Category("Behavior"), Description("Gets or sets the Direction for this Line.")]
		public Directions Direction { get; set; }
		[Browsable(true), DisplayName("Start Color"), Category("Appearance"), Description("Gets or sets the Starting Color for this Gradient Line.")]
		
		public Color StartColor { get; set; }

		[Browsable(true), DisplayName("End Color"), Category("Appearance"), Description("Gets or sets the Ending Color for this Gradient Line.")]
		public Color EndColor { get; set; }

		[Browsable(true), DisplayName("Line Thickness"), Category("Appearance"), Description("Gets or sets the Thickness for this Line.")]
		public int Thickness { get; set; } = 1;

		[Browsable(true), DisplayName("Color"), Category("Appearance"), Description("Gets or sets the Color for this Line.")]
		public Color Color { get; set; }

		public Separator()
		{
			Thickness = 1;

			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

			switch (Direction)
			{
				case Directions.Horizontal:
					if(IsEnabled)
					{
						if (UsingGradient)
						{
							LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
								new Point(
									0,
									0
									),
								new Point(
									this.Width,
									0
									),
								StartColor,
								EndColor
								);

							using (Pen pen = new Pen(
								linearGradientBrush,
								(float)Thickness
								))
							{
								if(IsDashed)
								{
									pen.DashStyle = Style;
									pen.DashPattern = DashPattern;
								}

								e.Graphics.DrawLine(
									pen,
									0,
									0,
									this.Width,
									0
									);
							}
						}
						else
						{
							using (Pen pen = new Pen(
							Color,
							Thickness
							)
							)
							{
								if (IsDashed)
								{
									pen.DashStyle = Style;
									pen.DashPattern = DashPattern;
								}

								e.Graphics.DrawLine(
									pen,
									new Point(
										0,
										0
										),
									new Point(
										this.Width,
										0
										)
									);
							}
						}
					}
					else
					{
						using (Pen pen = new Pen(
							Brushes.DimGray,
							Thickness
							)
							)
						{
							if (IsDashed)
							{
								pen.DashStyle = Style;
								pen.DashPattern = DashPattern;
							}

							e.Graphics.DrawLine(
								pen,
								new Point(
									0,
									0
									),
								new Point(
									0,
									this.Height
									)
								);
						}
					}
					break;
				case Directions.Vertical:
					if (IsEnabled)
					{
						if (UsingGradient)
						{
							LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
								new Point(
									0,
									0
									),
								new Point(
									0,
									this.Height
									),
								StartColor,
								EndColor
								);

							using (Pen pen = new Pen(
								linearGradientBrush,
								(float)Thickness
								))
							{
								if (IsDashed)
								{
									pen.DashStyle = Style;
									pen.DashPattern = DashPattern;
								}

								e.Graphics.DrawLine(
									pen,
									0,
									0,
									0,
									this.Height
									);
							}
						}
						else
						{
							using (Pen pen = new Pen(
							Color,
							Thickness
							)
							)
							{
								if (IsDashed)
								{
									pen.DashStyle = Style;
									pen.DashPattern = DashPattern;
								}

								e.Graphics.DrawLine(
									pen,
									new Point(
										0,
										0
										),
									new Point(
										0,
										this.Height
										)
									);
							}
						}
					}
					else
					{
						using (Pen pen = new Pen(
							Brushes.DimGray,
							Thickness
							)
							)
						{
							if (IsDashed)
							{
								pen.DashStyle = Style;
								pen.DashPattern = DashPattern;
							}

							e.Graphics.DrawLine(
								pen,
								new Point(
									0,
									0
									),
								new Point(
									0,
									this.Height
									)
								);
						}
					}
					break;
			}

			base.OnPaint(e);
		}

		private void Separator_SizeChanged(object sender, EventArgs e)
		{
			this.Refresh();
		}
	}
}
