using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Numerics;




namespace CshConsoleAPI
{
	class Program
	{
      private const int ERROR_SUCCESS = 0;


      private static Task<string> GetInputAsync()
      {
         return Task.Run(() => Console.ReadLine());
      }

      static int Main(string[] args)
		{
         // Indicates whther to continue reading input.
         bool running = true;

         // Initialize the commands object.
         Commands pCommands = CommandsApi.CommandsInit();

         // Assign the echo command function to the command list.
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_ECHO, AppCommands.CommandEcho);
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_EXIT, AppCommands.CommandExit);

         CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_SHOW, DialogCommands.CommandGuiShow);
         CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_MULT, DialogCommands.CommandGuiMult);
         CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_CLOSE, DialogCommands.CommandGuiClose);

         // Store user input text.
         string command_line;

         // Continues loop.
         while (running)
         {
            // Print command promped '>'
            Console.Write(AppCommands.CMD_PROMPED);

            // Get console command text"
            //command_line = Console.ReadLine();
            command_line = GetInputAsync().Result;

            // Call for command execution.
            String result = CommandsApi.CommandExec(ref pCommands, command_line);
            Console.Out.WriteLine(result);
            running = (AppCommands.CMD_EXIT != result);
         }

         Environment.ExitCode = ERROR_SUCCESS;
         return ERROR_SUCCESS;
      }
	}
}
