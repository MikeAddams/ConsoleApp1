using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using ConsoleApp1.CommandProcessor;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IController>();
                app.Logic();
            }

            /*
            var controller = new Controller(new CommandProc());

            controller.Logic();
            */
        }
    }
}