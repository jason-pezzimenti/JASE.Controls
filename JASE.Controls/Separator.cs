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
		[Browsable(true), DisplayName("Supports Multiple Colors"), Category("Behavior"), Description("Gets or sets whether this Control supports multiple colors.")]
		public bool SupportsMultipleColors { get; set; }

		[Browsable(true), DisplayName("Colors"), Category("Appearance"), Description("Gets or sets the Colors to use for this Control.")]
		public List<Color> Colors { get; set; } = new List<Color>();

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

		[Browsable(true), DisplayName("Blink On Color"), Category("Appearance"), Description("Gets or sets the Blink On Color for this Control.")]
		public Color BlinkOnColor { get; set; } = Color.White;

		[Browsable(true), DisplayName("Blink Off Color"), Category("Appearance"), Description("Gets or sets the Blink Off Color for this Control.")]
		public Color BlinkOffColor { get; set; } = Color.Black;

		private bool canBlink = false;

		[Browsable(true), DisplayName("Blinking Interval"), Category("Behavior"), Description("Gets or sets the Blinking Interval for this Control.")]
		public int BlinkingInterval { get; set; } = 1500;

        [Browsable(true), DisplayName("Can Blink"), Category("Behavior"), Description("Gets or sets whether this Control can blink.")]

		// Custom getter/setter by Microsoft Co-Pilot.
        public bool CanBlink
        {
			get
			{
				return canBlink;
			}
			set
			{
				canBlink = value;

				if (canBlink)
				{
					blinkingTimer.Start();
				}
				else
				{
					blinkingTimer.Stop();
				}

				this.Refresh();
			}
		}

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

        private Timer blinkingTimer;

		public enum BlinkingStates
		{
			Off = 0,
			On
		}

		[Browsable(true), DisplayName("Blinking State"), Category("Behavior"), Description("Gets or sets the Blinking State for this Control.")]
		public BlinkingStates BlinkingState { get; set; }

        public enum DrawTypes
		{
			Line = 0,
			DashedLine,
			GradientLine,
			GradientAndDashedLine
		}

		public DrawTypes DrawType { get; set; }

		public Separator()
		{
			Thickness = 1;

			this.DoubleBuffered = true;

			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			this.SetStyle(ControlStyles.ResizeRedraw, true);
			this.SetStyle(ControlStyles.Selectable, true);

			blinkingTimer = new Timer();

			blinkingTimer.Interval = BlinkingInterval;
            blinkingTimer.Tick += BlinkingTimer_Tick;

			InitializeComponent();
		}

        private void BlinkingTimer_Tick(object sender, EventArgs e)
        {
			if (this.CanBlink)
			{
				if (BlinkingState == BlinkingStates.On)
				{
					BlinkingState = BlinkingStates.Off;
				}
				else
				{
					BlinkingState = BlinkingStates.On;
				}
			}

			this.Refresh();
        }

        private void Draw(DrawTypes drawType, PaintEventArgs e)
		{
			if (IsEnabled)
			{
				switch (drawType)
				{
					case DrawTypes.Line:
						if (SupportsMultipleColors && Colors != null && Colors.Count > 0)
						{
							int lines = Colors.Count;
							int lineWidth = this.Width / lines; // Attribution: Windows 10 Co-Pilot (preview).

							for(int index = 0; index < lines; index++)
							{
								using (Pen pen = new Pen(
									Colors[index],
									Thickness
									)
									)
								{
									if(Direction == Directions.Horizontal)
									{
										int xLocation = (lineWidth * index) == 0 ? 0 : (lineWidth * index);

										e.Graphics.DrawLine(
											pen,
											xLocation,
											0,
											xLocation + lineWidth, // Attribution: Windows 10 Co-Pilot (preview).
											0
											);
									}
									else
									{
										lineWidth = this.Height / lines;
										int yLocation = (lineWidth * index) == 0 ? 0 : (lineWidth * index);

										e.Graphics.DrawLine(
											pen,
											0,
											yLocation,
											0,
											yLocation + lineWidth
											);
									}
								}
							}
						}
						else
						{
							Color color = this.BlinkOffColor;

							if (this.CanBlink)
							{
								if (BlinkingState == BlinkingStates.On)
								{
									color = BlinkOnColor;
								}
								else
								{
									color = BlinkOffColor;
								}
							}
							else
							{
								color = Color;
							}

							using (Pen pen = new Pen(
									color,
									Thickness
									)
									)
							{
								if (Direction == Directions.Horizontal)
								{
									e.Graphics.DrawLine(
										pen,
										0,
										0,
										this.Width,
										0
										);
								}
								else
								{
									e.Graphics.DrawLine(
										pen,
										0,
										0,
										0,
										this.Height
										);
								}
							}
						}
						break;
					case DrawTypes.DashedLine:
						using (Pen pen = new Pen(
								Color,
								Thickness
								)
								)
						{
							if (Direction == Directions.Horizontal)
							{
								pen.DashStyle = Style;
								pen.DashPattern = DashPattern;

								e.Graphics.DrawLine(
									pen,
									0,
									0,
									this.Width,
									0
									);
							}
							else
							{
								pen.DashStyle = Style;
								pen.DashPattern = DashPattern;

								e.Graphics.DrawLine(
									pen,
									0,
									0,
									0,
									this.Height
									);
							}
						}
						break;
					case DrawTypes.GradientLine:
						LinearGradientBrush linearGradientBrush = CreateNewLinearGradientBrush();

						using (Pen pen = new Pen(
							linearGradientBrush,
							(float)Thickness
							))
						{
							if (Direction == Directions.Horizontal)
							{
								e.Graphics.DrawLine(
									pen,
									0,
									0,
									this.Width,
									0
									);
							}
							else
							{
								e.Graphics.DrawLine(
									pen,
									0,
									0,
									0,
									this.Height
									);
							}
						}
						break;
					case DrawTypes.GradientAndDashedLine:
						LinearGradientBrush gradientAndDashedLineLinearGradientBrush = CreateNewLinearGradientBrush();

						using (Pen pen = new Pen(
							gradientAndDashedLineLinearGradientBrush,
							(float)Thickness
							))
						{
							pen.DashStyle = Style;
							pen.DashPattern = DashPattern;

							if (Direction == Directions.Horizontal)
							{
								e.Graphics.DrawLine(
									pen,
									0,
									0,
									this.Width,
									0
									);
							}
							else
							{
								e.Graphics.DrawLine(
									pen,
									0,
									0,
									0,
									this.Height
									);
							}
						}
						break;
				}
			}
			else
			{
				using (Pen pen = new Pen(
					Color.DimGray,
					Thickness
					)
					)
				{
					if (Direction == Directions.Horizontal)
					{
						e.Graphics.DrawLine(
							pen,
							0,
							0,
							this.Width,
							0
							);
					}
					else
					{
						e.Graphics.DrawLine(
							pen,
							0,
							0,
							0,
							this.Height
							);
					}
				}
			}
		}

		private LinearGradientBrush CreateNewLinearGradientBrush()
		{
			return new LinearGradientBrush(
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
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

			if (UsingGradient)
			{
				if (IsDashed)
				{
					Draw(DrawTypes.GradientAndDashedLine, e);
				}
				else
				{
					Draw(DrawTypes.GradientLine, e);
				}
			}
			else
			{
				if (IsDashed)
				{
					Draw(DrawTypes.DashedLine, e);
				}
				else
				{
					Draw(DrawTypes.Line, e);
				}
			}

			base.OnPaint(e);
		}

		private void Separator_SizeChanged(object sender, EventArgs e)
		{
			this.Refresh();
		}
	}
}
