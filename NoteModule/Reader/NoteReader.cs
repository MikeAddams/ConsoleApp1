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
    }
}
