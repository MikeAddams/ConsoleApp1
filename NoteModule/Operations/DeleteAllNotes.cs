using ConsoleApp1.NoteModule.Reader;
using System;
using System.Xml.Linq;

namespace ConsoleApp1.NoteModule.Operations
{
    class DeleteAllNotes : IDeleteAllNotes
    {
        private NoteConfig noteParams;

        public DeleteAllNotes(NoteConfig _note)
        {
            noteParams = _note;
        }

        public void DeleteAll()
        {
            try
            {
                XElement notes = XElement.Load(noteParams.NotePath);

                if (NoteReader.AskTo("delete them all"))
                {
                    notes.Descendants("note").Remove();
                    notes.Save(noteParams.NotePath);

                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nexception: {e.Message}");
            }
        }
    }
}
