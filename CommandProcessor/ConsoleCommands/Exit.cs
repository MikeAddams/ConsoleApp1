using System;

namespace ConsoleApp1.CommandProcessor.ConsoleCommands
{
    class Exit : ICommand
    {
        public void ExecuteCommand()
        {
            Console.WriteLine("\nExiting program...");
            Environment.Exit(0);
        }
    }
}
