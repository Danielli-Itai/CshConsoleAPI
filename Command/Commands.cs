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
using System.Collections.Generic;





namespace CshConsoleAPI
{
	public delegate String CommandCb(string[] parameters);


	public class Commands
	{
		public const string CMD_PROMPED = "\n>";
		public const string CMD_ECHO = "echo";
		public const string PARAMS_START = "(";
		public const string PARAMS_SEP = ",";
		public const string PARAMS_END = ")";



		Dictionary<string, CommandCb> commands_dic = new Dictionary<string, CommandCb>();

		public bool Add(string name, CommandCb command)
		{
			bool result = true;
			try
			{
				commands_dic.Add(name, command);
			}
			catch (Exception e)
			{
				result = false;
			}
			return result;
		}

		public CommandCb Find(string name)
		{
			CommandCb command = null;
			try{
				command = commands_dic[name];
			}catch(Exception e){	}
			return command;
		}

		public String Exec(string name, string[] parameters)
		{
			String result = "";
			CommandCb command = Find(name);
			if(null != command){
				result = command(parameters);
			}
			return (result);
		}
	}
}
