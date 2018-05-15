using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class History
    {
        public int HistoryId { get; set; }
        public string SearchedText { get; set; }
        public int? PostId { get; set; }
        public string MarkingNotes { get; set; }
        public DateTime DateTime { get; set; }


    }
}
