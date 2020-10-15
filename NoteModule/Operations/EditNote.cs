using ConsoleApp1.NoteModule.Reader;
using System;
using System.Xml.Linq;

namespace ConsoleApp1.NoteModule.Operations
{
    class EditNote : IEditNote
    {
        private NoteConfig noteParams;

        public EditNote(NoteConfig _note)
        {
            noteParams = _note;
        }

        public void Edit()
        {
            string NoteName = NoteReader.GetNoteName("you want to change");
            bool found = false;

            try
            {
                XElement notes = XElement.Load(noteParams.NotePath);

                foreach (var note in notes.Descendants(noteParams.NoteTag))
                {
                    if (note.Attribute("name").Value == NoteName)
                    {
                        Console.WriteLine($"\nNote NAME: {note.Attribute(noteParams.NoteTagAttribute).Value}");
                        if (NoteReader.AskTo("change"))
                        {
                            note.Attribute("name").Value = NoteReader.GetNoteName();
                        }

                        Console.WriteLine($"\nNote TITLE: {note.Element(noteParams.NoteTitleTag).Value}");
                        if (NoteReader.AskTo("change"))
                        {
                            note.Element("title").Value = NoteReader.GetNoteTitle();
                        }

                        Console.WriteLine($"\nNote TEXT: {note.Element(noteParams.NoteTextTag).Value}");
                        if (NoteReader.AskTo("change"))
                        {
                            note.Element("text").Value = NoteReader.GetNoteText();
                        }

                        found = true;
                        notes.Save(noteParams.NotePath);
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
            catch(Exception e)
            {
                Console.WriteLine($"\n{e.Message}");
            }
        }
    }
}
