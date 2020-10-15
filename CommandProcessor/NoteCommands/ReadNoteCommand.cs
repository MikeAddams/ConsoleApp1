using ConsoleApp1.NoteModule.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandProcessor.NoteCommands
{
    class ReadNoteCommand : ICommand
    {
        private IReadNote note;

        public ReadNoteCommand(IReadNote _note)
        {
            note = _note;
        }

        public void ExecuteCommand()
        {
            note.Read();
        }
    }
}
