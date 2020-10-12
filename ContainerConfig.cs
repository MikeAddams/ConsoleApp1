using Autofac;
using ConsoleApp1.CommandProcessor;
using ConsoleApp1.CommandProcessor.NoteCommands;
using ConsoleApp1.NoteModule;
using ConsoleApp1.NoteModule.Operations;
using System;
using System.Collections.Generic;
using System.Text;

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

            builder.RegisterType<NewNoteCommand>().AsSelf();
            builder.RegisterType<EditNoteCommand>().AsSelf();


            return builder.Build();
        }
    }
}
