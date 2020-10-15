using ConsoleApp1.NoteModule.Reader;
using System;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp1.NoteModule.Operations
{
    class ShowAllNotes : IShowAllNotes
    {
        private NoteConfig noteParams;

        public ShowAllNotes(NoteConfig _note)
        {
            noteParams = _note;
        }

        public void Show()
        {
            try
            {
                XElement notes = XElement.Load(noteParams.NotePath);

                var query = notes.Descendants(noteParams.NoteTag)
                    .Select(x => new
                    {
                        name = x.Attribute("name").Value,
                        title = x.Element("title").Value,
                        text = x.Element("text").Value
                    });

                if (query.Any())
                {
                    foreach (var note in query)
                    {
                        NoteReader.ShowNote(note.name, note.title, note.text);
                    }
                }
                else
                {
                    NoteReader.NothingFound();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nexception: {e.Message}");
            }
        }
    }
}
