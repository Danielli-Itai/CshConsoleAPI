using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





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
