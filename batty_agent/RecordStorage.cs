
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace nayutaya.batty.agent
{
    class RecordStorage
    {
        public static void Save(StreamWriter writer, List<Record> records)
        {
            foreach ( Record record in records )
            {
                string time = record.Time.ToString("yyyyMMddHHmmss");
                string level = record.Level.ToString("D3");
                string sent = (record.Sent ? "1" : "0");
                writer.WriteLine("{0}{1}{2}", time, level, sent);
            }
        }
    }
}
