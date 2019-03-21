using MathsNotes.Models.Notepad;
using System.Collections.Generic;

namespace Notes.Web.Models.Notepad
{
    public class NotepadVM
    {
        public string InputText { get; set; }
        public string OutputText { get; set; }
        public List<SymbolSetsVM> SymbolSets { get; set; }
    }
}