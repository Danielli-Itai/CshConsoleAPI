using CshApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace CshConsoleAPI
{
	public class DialogCommands
	{
		public const string GUI_SHOW = "GuiShow";
		public const string GUI_MULT = "GuiMult";
		public const string GUI_CLOSE = "GuiClose";



		private static ApplicationGUI gui = new ApplicationGUI();

		/***
		* GuiShow opens the application graphical user interface.
		*/
		public static String CommandGuiShow(string[] parameters)
		{
			gui.Show();
			return AppCommands.CMD_OK;
		}

		public static String CommandGuiMult(string[] parameters){
			String result = gui.CmdMultiply(parameters[0], parameters[1]);
			return result;

		}

		public static String CommandGuiClose(string[] parameters)
		{
			gui.Close();
			return AppCommands.CMD_OK;
		}

	}
}
