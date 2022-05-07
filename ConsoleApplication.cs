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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace CshConsoleAPI
{
	class Program
	{
        private const int ERROR_SUCCESS = 0;


        private static Task<string> GetInputAsync()
        {
            return Task.Run(() => Console.ReadLine());
        }

        private delegate string GuiCommandEnvoke(Commands Commands_list, string command_line);
        public static void ThreadProc(ApplicationGUI gui)
        {
            // Indicates whther to continue reading input.
            bool running = true;

            DialogCommands.GUI(gui);

            // Initialize the commands object.
            Commands pCommands = CommandsApi.CommandsInit();

            // Assign the general commands to the commands list.
            CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_ECHO, AppCommands.CommandEcho);
            CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_EXIT, AppCommands.CommandExit);

            // Assign the aplication GUI commands to the commands list.
            CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_SHOW, DialogCommands.CommandGuiShow);
            CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_HIDE, DialogCommands.CommandGuiHide);
            CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_MULT, DialogCommands.CommandGuiMult);
            CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_ADD, DialogCommands.CommandGuiAdd);
            CommandsApi.CommandAdd(ref pCommands, DialogCommands.GUI_CLOSE, DialogCommands.CommandGuiClose);



            // Continues loop.
            while (running)
            {
                // Print command promped '>'
                Console.Write(AppCommands.CMD_PROMPED);

                // Get console command text"
                string command_line = GetInputAsync().Result;

                // Call for command execution by the GUI thread (enables accessing the GUI controls from a user thread).
                IAsyncResult invoke_result = gui.BeginInvoke(new GuiCommandEnvoke(CommandsApi.CommandExec), pCommands, command_line);

                //  Read the command result from the user thread.
                string result = (string)gui.EndInvoke(invoke_result);

                // Wite the result to the console.
                Console.Out.WriteLine(result);
                running = (AppCommands.CMD_EXIT != result);
            }

            //  Exit command was issued.
            gui.Invoke(new Action(() => { gui.Close(); }));

            return;
        }




        static int Main(string[] args)
		{
            //  Set the environment Exit code.
            Environment.ExitCode = ERROR_SUCCESS;

            //  Create the application GUI
            Application.EnableVisualStyles();
            ApplicationGUI gui = new ApplicationGUI();
            gui.Hide();

            //  Start the console interface on a new Thread.
            Thread t = new Thread(()=>ThreadProc(gui));
            t.Start();

            //  Run the application.
            Application.Run(gui);

            //  Waite for the console thread to termiante.
            t.Join();

            //  Return with success.
            return ERROR_SUCCESS;
        }
	}
}
