using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinNotesApp
{
    public class Note
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
