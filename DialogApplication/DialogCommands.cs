/****************************************************************\
* This code written by Itai Danielly                             *
* This program is free software: you can redistribute it and/or  *
* modify it under the terms of the GNU General Public License    *
* as published by the Free Software Foundation, either version 3 *
* of the License, or (at your option) any later version.         *
* This program is distributed in the hope that it will be useful *
* but WITHOUT ANY WARRANTY; without even the implied warranty of *
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.           *
* See the GNU General Public License for more details.           *
\****************************************************************/
using CshApplication;
using System;





namespace CshConsoleAPI
{
	public class DialogCommands
	{
		public const string GUI_SHOW = "GuiShow";
		public const string GUI_HIDE = "GuiHide";
		public const string GUI_MULT = "GuiMult";
		public const string GUI_ADD = "GuiAdd";
		public const string GUI_CLOSE = "GuiClose";



		private static ApplicationGUI gui = null;
		public static void GUI(ApplicationGUI gui)
        {
			DialogCommands.gui = gui;
		}

		/***
		* GuiShow opens the application graphical user interface.
		*/
		public static String CommandGuiShow(string[] parameters)
		{
			gui.Show();
			return AppCommands.CMD_OK;
		}
		public static String CommandGuiHide(string[] parameters)
		{
			gui.Hide();
			return AppCommands.CMD_OK;
		}

		public static String CommandGuiMult(string[] parameters){
			String result = gui.CmdMultiply(parameters[0], parameters[1]);
			return result;

		}

		public static String CommandGuiAdd(string[] parameters)
		{
			String result = gui.CmdAdd(parameters[0], parameters[1]);
			return result;

		}

		public static String CommandGuiClose(string[] parameters)
		{
			gui.Close();
			return AppCommands.CMD_OK;
		}

	}
}
