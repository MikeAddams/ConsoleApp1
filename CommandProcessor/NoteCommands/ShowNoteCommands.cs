using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandProcessor.NoteCommands
{
    class ShowNoteCommands : ICommand
    {
        public void ExecuteCommand()
        {
            Console.WriteLine("List of all commands the note has\n");
        }
    }
}
