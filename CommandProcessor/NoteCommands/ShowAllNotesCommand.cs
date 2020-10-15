using ConsoleApp1.NoteModule.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandProcessor.NoteCommands
{
    class ShowAllNotesCommand : ICommand
    {
        private IShowAllNotes note;

        public ShowAllNotesCommand(IShowAllNotes _note)
        {
            note = _note;
        }

        public void ExecuteCommand()
        {
            note.Show();
        }
    }
}
