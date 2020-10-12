using ConsoleApp1.NoteModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandProcessor.NoteCommands
{
    class NewNoteCommand : ICommand
    {
        private IAddNote newNote;

        public NewNoteCommand(IAddNote _newNote)
        {
            newNote = _newNote;
        }

        public void ExecuteCommand()
        {
            newNote.Add();
        }
    }
}
