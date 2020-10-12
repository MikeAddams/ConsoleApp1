using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.CommandProcessor;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller(new CommandProc());

            controller.Logic();
        }
    }
}