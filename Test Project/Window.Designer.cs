namespace Test_Project
{
	partial class Window
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.separator1 = new JASE.Controls.Separator();
			this.SuspendLayout();
			// 
			// separator1
			// 
			this.separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.separator1.Color = System.Drawing.Color.LightGray;
			this.separator1.DashPattern = new float[] {
        1F,
        5F};
			this.separator1.Direction = JASE.Controls.Separator.Directions.Horizontal;
			this.separator1.DrawType = JASE.Controls.Separator.DrawTypes.Line;
			this.separator1.EndColor = System.Drawing.Color.Gray;
			this.separator1.IsDashed = false;
			this.separator1.IsEnabled = true;
			this.separator1.Location = new System.Drawing.Point(13, 13);
			this.separator1.Name = "separator1";
			this.separator1.Size = new System.Drawing.Size(225, 1);
			this.separator1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.separator1.Style = System.Drawing.Drawing2D.DashStyle.Dot;
			this.separator1.TabIndex = 0;
			this.separator1.Text = "separator1";
			this.separator1.Thickness = 1;
			this.separator1.UsingGradient = false;
			// 
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(250, 351);
			this.Controls.Add(this.separator1);
			this.Name = "Window";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private JASE.Controls.Separator separator1;
	}
}

