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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.separator1 = new JASE.Controls.Separator();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanks for using JASE.Controls. If you find any bugs, please raise an Issue on Gi" +
    "tHub and I will look into it.";
            // 
            // separator1
            // 
            this.separator1.BlinkOffColor = System.Drawing.Color.Black;
            this.separator1.BlinkOnColor = System.Drawing.Color.White;
            this.separator1.Color = System.Drawing.Color.Empty;
            this.separator1.Colors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("separator1.Colors")));
            this.separator1.DashPattern = null;
            this.separator1.Direction = JASE.Controls.Separator.Directions.Vertical;
            this.separator1.DrawType = JASE.Controls.Separator.DrawTypes.Line;
            this.separator1.EndColor = System.Drawing.Color.Empty;
            this.separator1.IsDashed = false;
            this.separator1.IsEnabled = true;
            this.separator1.Location = new System.Drawing.Point(12, 102);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(75, 237);
            this.separator1.StartColor = System.Drawing.Color.Empty;
            this.separator1.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            this.separator1.SupportsMultipleColors = true;
            this.separator1.TabIndex = 3;
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
            this.Controls.Add(this.groupBox1);
            this.Name = "Window";
            this.Text = "Test Window";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
        private JASE.Controls.Separator separator1;
    }
}

