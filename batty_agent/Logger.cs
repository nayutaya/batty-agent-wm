
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace nayutaya.batty.agent
{
    class Logger
    {
        private DirectoryInfo logdir = null;

        public Logger()
        {
            DirectoryInfo rootdir = new DirectoryInfo(this.GetExecutingAssemblyDirectoryPath());
            this.logdir = rootdir.CreateSubdirectory("log");

            this.Write(DateTime.Now, 0);
        }

        public void Write(DateTime time, byte level)
        {
            string timestr = time.ToString("yyyyMMdd");
            string filepath = this.logdir.FullName + "\\" + timestr + ".txt";

            using ( StreamWriter writer = File.AppendText(filepath) )
            {
                writer.WriteLine("hoge");
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
