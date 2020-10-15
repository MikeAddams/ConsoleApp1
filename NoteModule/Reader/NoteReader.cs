using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.NoteModule.Reader
{
    class NoteReader
    {
        public static string GetNoteName()
        {
            Console.WriteLine("\nEnter note name: ");
            return Console.ReadLine();
        }

        public static string GetNoteName(string msg)
        {
            Console.WriteLine($"\nEnter note name {msg}:");
            return Console.ReadLine();
        }

        public static string GetNoteTitle()
        {
            Console.WriteLine("\nEnter note title: ");
            return Console.ReadLine();
        }

        public static string GetNoteText()
        {
            Console.WriteLine("\nEnter note text: ");
            return Console.ReadLine();
        }

        public static bool AskTo(string st)
        {
            string input;

            Console.WriteLine($"Do you want to {st}? Y/N");
            input = Console.ReadLine().ToLower();

            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }

            return NoteReader.AskTo(st);
        }

        public static void NothingFound()
        {
            Console.WriteLine("\nNthing was found\n");
        }

        public static void CompletedSuccssfully()
        {
            Console.WriteLine("\nCompleted successfully\n");
        }

        public static void ShowNote(string title, string text)
        {
            Console.WriteLine($"\nTitle: {title}\nText: {text}\n");
        }

        public static void ShowNote(string name, string title, string text)
        {
            Console.WriteLine($"\nName: {name}\nTitle: {title}\nText: {text}\n");
        }
    }
}
