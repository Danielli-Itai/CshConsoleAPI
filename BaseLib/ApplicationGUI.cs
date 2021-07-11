using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CshConsoleAPI
{
	public partial class ApplicationGUI : Form
	{
		public ApplicationGUI()
		{
			InitializeComponent();
		}

		private void Multiply_Click(object sender, EventArgs e)
		{
			int num1 = Int32.Parse(Number2Text.Text);
			int num2 = Int32.Parse(Number1Text.Text);
			ResultText.Text = (num1 * num2).ToString();
		}

		public string CmdMultiply(string num1, string num2)
		{
			Number2Text.Text = num1;
			Number1Text.Text = num2;

			Multiply_Click(null, null);

			return ResultText.Text;
		}
	}
}
