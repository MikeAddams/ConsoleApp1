using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandProcessor.NoteCommands
{
    class ShowNoteCommands : ICommand
    {
        public void ExecuteCommand()
        {
            Console.WriteLine("\nnew - creates a new note" +
                              "\nedit - edit an existing note" +
                              "\ndelete - deletes a concrete note" +
                              "\nread - read a concrete note" +
                              "\nshowall - show all notes" +
                              "\ndeleteall - delete all notes" +
                              "\n\ncls - cleans the console" +
                              "\nexit - exits program\n");
        }
    }
}
