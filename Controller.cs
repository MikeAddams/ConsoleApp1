using ConsoleApp1.CommandProcessor;
using ConsoleApp1.NoteModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Controller
    {
        private readonly ICommandProcessor CommandProcessor;
        //private readonly

        public Controller(ICommandProcessor commandProcessor)
        {
            CommandProcessor = commandProcessor;
        }

        public void Logic()
        {
            NoteConfig NoteSettings = new NoteConfig();

            while (true)
            {
                CommandProcessor.ReadCommand();

                CommandProcessor.ProcessCommand().ExecuteCommand();
            }
        }
    }
}
