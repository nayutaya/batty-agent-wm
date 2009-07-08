
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace nayutaya.batty.agent
{
    class Logger
    {
        private string logdir = null;

        public Logger()
        {
            DirectoryInfo rootdir = new DirectoryInfo(Utility.GetExecutingAssemblyDirectoryPath());
            this.logdir = rootdir.CreateSubdirectory("log").FullName;
        }

        public void Write(DateTime time, byte level)
        {
            string date = time.ToString("yyyyMMdd");
            string filepath = this.logdir + "\\" + date + ".txt";

            using ( StreamWriter writer = File.AppendText(filepath) )
            {
                string datetime = time.ToString("yyyy-MM-dd HH:mm:ss");
                writer.WriteLine("{0},{1}", datetime, level.ToString());
            }
        }
    }
}
