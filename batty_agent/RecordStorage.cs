
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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

        public static List<Record> Load(StreamReader reader)
        {
            List<Record> records = new List<Record>();

            while ( !reader.EndOfStream )
            {
                string line = reader.ReadLine();

                Regex pattern = new Regex(@"^(?<time>\d{14})(?<level>\d{3})(?<sent>\d)$");
                Match match = pattern.Match(line);
                if ( match.Success )
                {
                    DateTime time = DateTime.ParseExact(match.Groups["time"].Value, "yyyyMMddHHmmss", null);
                    byte level = Byte.Parse(match.Groups["level"].Value);
                    bool sent = (match.Groups["sent"].Value == "0" ? false : true);

                    records.Add(new Record(time, level, sent));
                }
            }

            return records;
        }
    }
}
