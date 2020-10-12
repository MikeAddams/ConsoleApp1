using ConsoleApp1.CommandProcessor;
using ConsoleApp1.NoteModule;

namespace ConsoleApp1
{
    class Controller : IController
    {
        private readonly ICommandProc CommandProcessor;

        public Controller(ICommandProc commandProcessor)
        {
            CommandProcessor = commandProcessor;
        }

        public void Logic()
        {
            while (true)
            {
                CommandProcessor.ReadCommand();

                CommandProcessor.ProcessCommand().ExecuteCommand();
            }
        }
    }
}
