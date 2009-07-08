
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace nayutaya.batty.agent
{
    class RecordManager
    {
        private const int MaxOfRecords = 100;
        private readonly string filepath = null;
        private List<Record> records = null;

        public RecordManager()
        {
            this.filepath = Utility.GetExecutingAssemblyDirectoryPath() +  @"\records.txt";
            this.records = new List<Record>();
        }

        public int Count
        {
            get { return this.records.Count; }
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
            using ( StreamWriter writer = File.CreateText(this.filepath) )
            {
                RecordStorage.Save(writer, records);
            }
        }

        public void Load()
        {
            try
            {
                using ( StreamReader reader = File.OpenText(this.filepath) )
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
