
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
            DirectoryInfo rootdir = new DirectoryInfo(this.GetExecutingAssemblyDirectoryPath());
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

        // TODO: ユーティリティクラスに移動する
        private string GetExecutingAssemblyFilePath()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.FullyQualifiedName;
        }

        // TODO: ユーティリティクラスに移動する
        private string GetExecutingAssemblyDirectoryPath()
        {
            return System.IO.Path.GetDirectoryName(this.GetExecutingAssemblyFilePath());
        }
    }
}
