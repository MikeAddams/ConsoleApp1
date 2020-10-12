using ConsoleApp1.CommandProcessor;

namespace ConsoleApp1.CommandProcessor
{
    interface ICommandProcessor
    {
        ICommand ProcessCommand();
        void ReadCommand();
    }
}