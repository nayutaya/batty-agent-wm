
using System;
using System.Collections.Generic;
using System.Text;

namespace nayutaya.batty.agent
{
    class RecordManager
    {
        private const int MaxOfRecords = 100;
        private List<Record> records = null;

        public RecordManager()
        {
            this.records = new List<Record>();
        }

        public void Add(Record record)
        {
            this.records.Add(record);

            while ( this.records.Count > MaxOfRecords )
            {
                this.records.RemoveAt(0);
            }
        }

        /*
        using ( System.IO.StreamWriter writer = System.IO.File.CreateText(@"\Program Files\batty_agent\test.txt") )
        {
            RecordStorage.Save(writer, records);
        }
         */
        /*
        using ( System.IO.StreamReader reader = System.IO.File.OpenText(@"\Program Files\batty_agent\test.txt") )
        {
            List<Record> records2 = RecordStorage.Load(reader);
        }
         */
    }
}
