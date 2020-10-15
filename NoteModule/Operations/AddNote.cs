using ConsoleApp1.NoteModule.Reader;
using System;
using System.IO;
using System.Xml.Linq;

namespace ConsoleApp1.NoteModule
{
    class AddNote : IAddNote
    {
        private NoteConfig noteParams;

        public AddNote(NoteConfig _note)
        {
            noteParams = _note;
        }

        public void Add()
        {
            XDocument xdoc;

            XElement composedXml = new XElement(noteParams.NoteTag,
                            new XAttribute(noteParams.NoteTagAttribute, NoteReader.GetNoteName()),
                            new XElement(noteParams.NoteTitleTag, NoteReader.GetNoteTitle()),
                            new XElement(noteParams.NoteTextTag, NoteReader.GetNoteText()));
            Console.WriteLine();

            if (File.Exists(noteParams.NotePath))
            {
                XElement root;

                xdoc = XDocument.Load(noteParams.NotePath);
                root = xdoc.Element(noteParams.RootTag);

                root.Add(composedXml);
            }
            else
            {
                xdoc = new XDocument(new XElement(noteParams.RootTag, composedXml));
            }

            xdoc.Save(noteParams.NotePath);
        }
    }
}
