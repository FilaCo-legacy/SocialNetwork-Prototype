﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainWindow
{
    enum TMessage { FULLNAME_CHANGED, DATEOFBIRTH_CHANGED, STATUS_CHANGED, FRIEND_ADDED, NEWS_ADDED, PICTURE_ADDED,
    FRIEND_DELETED, NEWS_DELETED, PICTURE_DELETED }
    class TJournalEntry
    {
        public object Source { get; set; }
        public TMessage MessageType { get; set; }
        public DateTime TimeArrived { get; set; }
        public string MessageInfo { get; set; }
        public override string ToString()
        {
            return string.Format($"Источник сообщения: {Source};\nКатегория сообщения: {MessageType};\nВремя: {TimeArrived}\n" +
                $"Сведения о сообщении: {MessageInfo}");
        }
    }
}