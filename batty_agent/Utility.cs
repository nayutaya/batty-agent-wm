
using System;
using System.Collections.Generic;
using System.Text;

namespace nayutaya.batty.agent
{
    class Utility
    {
        public static string GetExecutingAssemblyFilePath()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.FullyQualifiedName;
        }

        public static string GetExecutingAssemblyDirectoryPath()
        {
            return System.IO.Path.GetDirectoryName(GetExecutingAssemblyFilePath());
        }
    }
}
