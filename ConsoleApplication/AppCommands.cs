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
	public class AppCommands
	{
		public const string CMD_PROMPED = ">";
		public const string CMD_ECHO = "echo";
		public const string CMD_EXIT = "exit";

		public const string CMD_OK = "ok";
		public const string CMD_FAILE = "faile";




		/***
		* Echo demonstrates a command execution function.
		* the command prints the parameters it receives.
		*/
		public static String CommandEcho(string[] parameters)
		{
			String result = "";
			foreach (string param in parameters){
				result += param + " ";
			}
			return (result.TrimEnd());
		}


		/***
		* Exit terminates the application.
		* the command prints the exit messsage.
		*/
		public static String CommandExit(string[] parameters)
		{
			Console.WriteLine(CMD_EXIT);
			return(CMD_EXIT);
		}
	}
}
