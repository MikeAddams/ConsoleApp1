using ConsoleApp1.CommandProcessor;

namespace ConsoleApp1.CommandProcessor
{
    interface ICommandProc
    {
        ICommand ProcessCommand();
        void ReadCommand();
    }
}