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
        public override string ToString()
        {
            string log = "";
            foreach (var cur in messages)
            {
                log += cur + "\n\n";
            }
            return log;
        }
    }
}
