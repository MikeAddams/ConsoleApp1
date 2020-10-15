using Autofac;
using ConsoleApp1.CommandProcessor;
using ConsoleApp1.CommandProcessor.NoteCommands;
using ConsoleApp1.NoteModule;
using ConsoleApp1.NoteModule.Operations;

namespace ConsoleApp1
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Controller>().As<IController>();
            builder.RegisterType<CommandProc>().As<ICommandProc>();

            builder.RegisterType<NoteConfig>().AsSelf().SingleInstance();

            builder.RegisterType<AddNote>().As<IAddNote>();
            builder.RegisterType<EditNote>().As<IEditNote>();
            builder.RegisterType<DeleteNote>().As<IDeleteNote>();
            builder.RegisterType<ReadNote>().As<IReadNote>();
            builder.RegisterType<ShowAllNotes>().As<IShowAllNotes>();
            builder.RegisterType<DeleteAllNotes>().As<IDeleteAllNotes>();

            builder.RegisterType<NewNoteCommand>().AsSelf();
            builder.RegisterType<EditNoteCommand>().AsSelf();
            builder.RegisterType<DeleteNoteCommand>().AsSelf();
            builder.RegisterType<ReadNoteCommand>().AsSelf();
            builder.RegisterType<ShowAllNotesCommand>().AsSelf();
            builder.RegisterType<DeleteAllNotesCommand>().AsSelf();

            return builder.Build();
        }
    }
}
