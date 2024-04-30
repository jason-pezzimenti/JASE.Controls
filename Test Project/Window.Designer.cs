﻿namespace Test_Project
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.separator1 = new JASE.Controls.Separator();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 118);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Blink Line";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // separator1
            // 
            this.separator1.BlinkingInterval = 1500;
            this.separator1.BlinkingState = JASE.Controls.Separator.BlinkingStates.On;
            this.separator1.BlinkOffColor = System.Drawing.Color.Gainsboro;
            this.separator1.BlinkOnColor = System.Drawing.Color.Silver;
            this.separator1.CanBlink = true;
            this.separator1.Color = System.Drawing.Color.Silver;
            this.separator1.Colors = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("separator1.Colors")));
            this.separator1.DashPattern = new float[] {
        10F,
        5F};
            this.separator1.Direction = JASE.Controls.Separator.Directions.Horizontal;
            this.separator1.DisabledColor = System.Drawing.Color.Gainsboro;
            this.separator1.EndColor = System.Drawing.Color.Empty;
            this.separator1.IsDashed = true;
            this.separator1.IsEnabled = false;
            this.separator1.Location = new System.Drawing.Point(12, 102);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(226, 10);
            this.separator1.StartColor = System.Drawing.Color.Empty;
            this.separator1.Style = System.Drawing.Drawing2D.DashStyle.Dash;
            this.separator1.SupportsMultipleColors = false;
            this.separator1.TabIndex = 3;
            this.separator1.Text = "separator1";
            this.separator1.Thickness = 1;
            this.separator1.UsingGradient = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(90, 118);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Is Enabled";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 351);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Window";
            this.Text = "Test Window";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
        private JASE.Controls.Separator separator1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

