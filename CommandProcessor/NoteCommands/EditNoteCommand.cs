using ConsoleApp1.NoteModule.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandProcessor.NoteCommands
{
    class EditNoteCommand : ICommand
    {
        private IEditNote note;

        public EditNoteCommand(IEditNote _note)
        {
            note = _note;
        }

        public void ExecuteCommand()
        {
            note.Edit();
        }
    }
}
