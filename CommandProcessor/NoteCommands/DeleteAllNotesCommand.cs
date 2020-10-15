using ConsoleApp1.NoteModule.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandProcessor.NoteCommands
{
    class DeleteNoteCommand : ICommand
    {
        private IDeleteNote note;

        public DeleteNoteCommand(IDeleteNote _note)
        {
            note = _note;
        }

        public void ExecuteCommand()
        {
            note.Delete();
        }
    }
}
