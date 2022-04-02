using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





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
