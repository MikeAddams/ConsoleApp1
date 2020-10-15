using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandProcessor.ConsoleCommands
{
    class Clear : ICommand
    {
        public void ExecuteCommand()
        {
            Console.Clear();
        }
    }
}
