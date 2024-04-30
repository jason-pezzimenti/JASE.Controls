using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Project
{
	public partial class Window : Form
	{
		public Window()
		{
			InitializeComponent();
		}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
			if (checkBox1.Checked)
			{
				separator1.CanBlink = true;
			}
			else
			{
				separator1.CanBlink = false;
			}
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
			separator1.IsEnabled = checkBox2.Checked;
        }
    }
}
