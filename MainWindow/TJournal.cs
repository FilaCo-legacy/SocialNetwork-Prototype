using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    internal delegate void JournalHandler(object sender, TJournalEntry je);
    class TJournal
    {
        private List<TJournalEntry> messages;
        public event JournalHandler JournalChanged;
        public void AddMessage(TJournalEntry msg)
        {
            messages.Add(msg);
            OnJournalChanged(this, msg);
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
        public void OnPersonChanged(object source, PersonHandlerEventArgs e)
        {
            TJournalEntry je = new TJournalEntry(e.Source, e.MessageType, e.TimeArrived, e.MessageInfo);
            AddMessage(je);
        }
        public void OnJournalChanged(object source, TJournalEntry je)
        {
            JournalChanged?.Invoke(source, je);
        }
    }
}
