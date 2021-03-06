using System;
using System.Diagnostics.Tracing;
using System.IO;

namespace TekManager.Code.Connection
{
    public static class Logger
    {
        private const string PathLive = "D:\\home\\LogFiles\\logs.txt";
        private const string PathDev = "C:\\Users\\Joel\\Documents\\fyp\\logs.txt";


        public static void Log(EventLevel level, string message)
        {
#if DEBUG
            using (StreamWriter sw = File.AppendText(PathDev))
            {
                sw.WriteLine($"{DateTime.Now:MM/dd/yyyy HH:mm:ss}{Environment.NewLine}{level}{Environment.NewLine}{message}{Environment.NewLine}{Environment.NewLine}");
            }
#else
            using (StreamWriter sw = File.AppendText(PathLive))
            {
                sw.WriteLine($"{DateTime.Now:MM/dd/yyyy HH:mm:ss}{Environment.NewLine}{level}{Environment.NewLine}{message}{Environment.NewLine}{Environment.NewLine}");
            }
#endif



        }
    }
}
