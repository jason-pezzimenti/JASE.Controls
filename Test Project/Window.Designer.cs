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
			this.separator2 = new JASE.Controls.Separator();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
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
			this.separator1.Location = new System.Drawing.Point(12, 101);
			this.separator1.Name = "separator1";
			this.separator1.Size = new System.Drawing.Size(226, 1);
			this.separator1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.separator1.Style = System.Drawing.Drawing2D.DashStyle.Dot;
			this.separator1.TabIndex = 0;
			this.separator1.Text = "separator1";
			this.separator1.Thickness = 1;
			this.separator1.UsingGradient = false;
			// 
			// separator2
			// 
			this.separator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.separator2.BackColor = System.Drawing.Color.LightGray;
			this.separator2.Color = System.Drawing.Color.Empty;
			this.separator2.DashPattern = null;
			this.separator2.Direction = JASE.Controls.Separator.Directions.Horizontal;
			this.separator2.DrawType = JASE.Controls.Separator.DrawTypes.Line;
			this.separator2.EndColor = System.Drawing.Color.Empty;
			this.separator2.IsDashed = false;
			this.separator2.IsEnabled = true;
			this.separator2.Location = new System.Drawing.Point(125, 108);
			this.separator2.Name = "separator2";
			this.separator2.Size = new System.Drawing.Size(1, 231);
			this.separator2.StartColor = System.Drawing.Color.Empty;
			this.separator2.Style = System.Drawing.Drawing2D.DashStyle.Solid;
			this.separator2.TabIndex = 1;
			this.separator2.Text = "separator2";
			this.separator2.Thickness = 1;
			this.separator2.UsingGradient = false;
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
			// Window
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(250, 351);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.separator2);
			this.Controls.Add(this.separator1);
			this.Name = "Window";
			this.Text = "Test Window";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private JASE.Controls.Separator separator1;
		private JASE.Controls.Separator separator2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
	}
}

