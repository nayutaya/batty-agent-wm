
using System;
using System.Collections.Generic;
using System.Text;

namespace nayutaya.batty.agent
{
    class Record
    {
        /// <summary>記録日時</summary>
        private DateTime time;
        /// <summary>バッテリレベル</summary>
        private byte level;
        /// <summary>送信済み</summary>
        private bool sent;

        public Record(DateTime time, byte level, bool sent)
        {
            this.time = time;
            this.level = level;
            this.sent = sent;
        }

        public Record(DateTime time, byte level)
            : this(time, level, false)
        {
            // nop
        }

        public DateTime Time
        {
            get { return time; }
        }

        public byte Level
        {
            get { return level; }
        }

        public bool Sent
        {
            get { return sent; }
        }
    }
}
