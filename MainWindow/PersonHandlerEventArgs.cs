using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWindow
{
    class PersonHandlerEventArgs:EventArgs
    {
        public string Source { get; set; }
        public TMessage MessageType { get; set; }
        public DateTime TimeArrived { get; set; }
        public string MessageInfo { get; set; }
        public PersonHandlerEventArgs(string _source, TMessage _msgType, DateTime _timeArrived, string _msgInfo)
        {
            Source = _source;
            MessageType = _msgType;
            TimeArrived = _timeArrived;
            MessageInfo = _msgInfo;
        }
    }
}
