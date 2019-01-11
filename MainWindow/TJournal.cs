using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWindow
{
    class TJournal
    {
        private List<TJournalEntry> messages;
        public void AddMessage(TJournalEntry msg)
        {
            messages.Add(msg);
        }
        public TJournal()
        {
            messages = new List<TJournalEntry>();
        }
        public override string ToString()
        {
            string log = "";
            foreach (var cur in messages)
            {
                log += cur + "\n\n";
            }
            return log;
        }
        public void OnPersonCharacteristicsChanged(object source, PersonHandlerEventArgs e)
        {
            TJournalEntry je = new TJournalEntry(e.Source, e.MessageType, e.TimeArrived, e.MessageInfo);
            AddMessage(je);
        }
        public void OnPersonActionMade(object source, PersonHandlerEventArgs e)
        {
            TJournalEntry je = new TJournalEntry(e.Source, e.MessageType, e.TimeArrived, e.MessageInfo);
            AddMessage(je);
        }
    }
}
