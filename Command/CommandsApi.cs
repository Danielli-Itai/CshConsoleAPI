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
using System;





namespace CshConsoleAPI
{
	public class CommandsApi
	{
		/***
		* Command special characters.
		*/
		const char PARAMS_START = '(';
		const char PARAMS_SEP = ',';
		const char PARAMS_END = ')';

	



		/***
		* Parsing the command name from the command string.
		*/
		public static string CommandName(string command_line)
		{
			int cnd_end = command_line.IndexOf(PARAMS_START);
			string command = command_line.Substring(0, cnd_end);
			return (CStrTrim.trim(command));
		}

		/**
		* Parsing the command parameters from the command string
		*/
		public static string[] CommandParams(string command_line)
		{
			int prm_strt = command_line.IndexOf(PARAMS_START) + 1;
			int prm_end = command_line.IndexOf(PARAMS_END);
			string params_str = command_line.Substring(prm_strt, prm_end - prm_strt);

			string[] parameters = params_str.Split(PARAMS_SEP);

			return parameters;
		}




		/***
		* Creating a new commands list.
		*/
		public static Commands CommandsInit()
		{
			return new Commands();
		}

		/***
		* Add new command name and function to the commands list.
		*/
		public static bool CommandAdd(ref Commands Commands_list, string name, CommandCb pCallback)
		{
			return (Commands_list.Add(name, pCallback));
		}


		/***
		* Call for command execution providing a parameters list.
		*/
		public static String CommandExec(Commands Commands_list, string command_line)
		{
			string name = CommandName(command_line);
			string[] parameters = CommandParams(command_line);

			string result = Commands_list.Exec(name, parameters);
			return result;
		}
	}
}
