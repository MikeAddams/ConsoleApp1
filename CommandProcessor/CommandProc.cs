using ConsoleApp1.CommandProcessor.ConsoleCommands;
using ConsoleApp1.CommandProcessor.NoteCommands;
using ConsoleApp1.NoteModule;
using ConsoleApp1.NoteModule.Operations;
using System;

namespace ConsoleApp1.CommandProcessor
{
    class CommandProc : ICommandProcessor
    {
        private string Commnad { get; set; }

        public ICommand ProcessCommand()
        {
            switch (Commnad.ToLower())
            {
                case "new":
                    return new NewNoteCommand(new AddNote(new NoteConfig()));
                case "edit":
                    return new EditNoteCommand(new EditNote(new NoteConfig()));
                case "read":
                    return new ReadNoteCommand();
                case "delete":
                    return new DeleteNoteCommand();
                case "exit":
                    return new Exit();
                default:
                    Console.WriteLine("Incorrect command\n");
                    break;
            }

            return new ShowNoteCommands();
        }

        public void ReadCommand()
        {
            Console.WriteLine("Enter a command: ");
            Commnad = Console.ReadLine();
        }
    }
}
