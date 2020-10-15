using Autofac;
using ConsoleApp1.CommandProcessor.ConsoleCommands;
using ConsoleApp1.CommandProcessor.NoteCommands;
using System;

namespace ConsoleApp1.CommandProcessor
{
    class CommandProc : ICommandProc
    {
        private string Commnad { get; set; }

        public ICommand ProcessCommand()
        {
            //var container = ContainerConfig.Configure();

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                switch (Commnad.ToLower())
                {
                    case "new":
                        return scope.Resolve<NewNoteCommand>(); 
                    case "edit":
                        return scope.Resolve<EditNoteCommand>();
                    case "read":
                        return scope.Resolve<ReadNoteCommand>();
                    case "delete":
                        return scope.Resolve<DeleteNoteCommand>();
                    case "showall":
                        return scope.Resolve<ShowAllNotesCommand>();
                    case "deleteall":
                        return scope.Resolve<DeleteAllNotesCommand>();
                    case "exit":
                        return new Exit();
                    case "cls":
                        return new Clear();
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