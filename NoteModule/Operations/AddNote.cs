using ConsoleApp1.NoteModule.Reader;
using System;
using System.IO;
using System.Xml.Linq;

namespace ConsoleApp1.NoteModule
{
    class AddNote : IAddNote
    {
        private NoteConfig note;

        public AddNote(NoteConfig _note)
        {
            note = _note;
        }

        public void Add()
        {
            XDocument xdoc;

            XElement composedXml = new XElement(note.NoteTag,
                            new XAttribute(note.NoteTagAttribute, NoteReader.GetNoteName()),
                            new XElement(note.NoteTitleTag, NoteReader.GetNoteTitle()),
                            new XElement(note.NoteTextTag, NoteReader.GetNoteText()));

            if (File.Exists(note.NotePath))
            {
                XElement root;

                xdoc = XDocument.Load(note.NotePath);
                root = xdoc.Element(note.RootTag);

                root.Add(composedXml);
            }
            else
            {
                xdoc = new XDocument(new XElement(note.RootTag, composedXml));
            }

            xdoc.Save(note.NotePath);
        }
    }

}
