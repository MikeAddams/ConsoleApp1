using Autofac;
using ConsoleApp1.CommandProcessor.ConsoleCommands;
using ConsoleApp1.CommandProcessor.NoteCommands;
using ConsoleApp1.NoteModule;
using ConsoleApp1.NoteModule.Operations;
using System;

namespace ConsoleApp1.CommandProcessor
{
    class CommandProc : ICommandProc
    {
        private string Commnad { get; set; }

        public ICommand ProcessCommand()
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                switch (Commnad.ToLower())
                {
                    case "new":
                        return scope.Resolve<NewNoteCommand>(); 
                    case "edit":
                        return scope.Resolve<EditNoteCommand>();
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
        }

        public void ReadCommand()
        {
            Console.WriteLine("Enter a command: ");
            Commnad = Console.ReadLine();
        }
    }
}
