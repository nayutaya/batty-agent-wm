
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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

        public void Save()
        {
            using ( System.IO.StreamWriter writer = System.IO.File.CreateText(@"\Program Files\batty_agent\records.txt") )
            {
                RecordStorage.Save(writer, records);
            }
        }

        public void Load()
        {
            try
            {
                using ( StreamReader reader = File.OpenText(@"\Program Files\batty_agent\records.txt") )
                {
                    this.records = RecordStorage.Load(reader);
                }
            }
            catch ( FileNotFoundException )
            {
                this.records = new List<Record>();
            }
        }
    }
}
