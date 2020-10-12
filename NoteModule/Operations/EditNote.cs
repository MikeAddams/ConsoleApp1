using ConsoleApp1.NoteModule.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1.NoteModule.Operations
{
    class EditNote : IEditNote
    {
        private NoteConfig note;

        public EditNote(NoteConfig _note)
        {
            note = _note;
        }

        public void Edit()
        {
            string NoteName = NoteReader.GetNoteName();
            string NoteTitle = NoteReader.GetNoteTitle();
            string NoteText = NoteReader.GetNoteText();

            try
            {
                /*
                XDocument xdoc = XDocument.Load(note.NotePath);
                XElement root = xdoc.Element(note.RootTag);

                foreach (XElement xe in root.Elements(note.NoteTag).ToList())
                {
                    if (xe.Attribute(note.NoteTagAttribute).Value == "Samsung Galaxy S5")
                    {
                        xe.Attribute("name").Value = "Samsung Galaxy Note 4";
                        xe.Element("price").Value = "31000";
                    }
                    //если iphone - удаляем его
                    else if (xe.Attribute("name").Value == "iPhone 6")
                    {
                        xe.Remove();
                    }
                }
                */
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
