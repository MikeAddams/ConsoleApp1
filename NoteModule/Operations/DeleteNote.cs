using ConsoleApp1.NoteModule.Reader;
using System;
using System.Xml.Linq;

namespace ConsoleApp1.NoteModule.Operations
{
    class DeleteNote : IDeleteNote
    {
        private NoteConfig noteParams;

        public DeleteNote(NoteConfig _note)
        {
            noteParams = _note;
        }

        public void Delete()
        {
            string NoteName = NoteReader.GetNoteName("you want to delete");
            bool found = false;

            try
            {
                XElement notes = XElement.Load(noteParams.NotePath);

                foreach (var note in notes.Descendants(noteParams.NoteTag))
                {
                    if (note.Attribute("name").Value == NoteName)
                    {
                        note.Remove();
                        
                        found = true;
                        notes.Save(noteParams.NotePath);

                        break;
                    }
                }

                if (!found)
                {
                    NoteReader.NothingFound();
                }
                else
                {
                    NoteReader.CompletedSuccssfully();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nexception: {e.Message}");
            }
        }
    }
}
