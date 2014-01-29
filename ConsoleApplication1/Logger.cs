using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SeLogerExtractor.DataAccess
{
    public class Logger
    {
        private static object locker = new object();
        public static void Log(String lines)
        {
            lock (locker)
            {
                // Write the string to a file.append mode is enabled so that the log
                // lines get appended to  test.txt than wiping content and writing the log

                System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(Environment.CurrentDirectory, "trace.txt"), true);
                file.WriteLine(lines);
                Console.WriteLine(lines);
                file.Close();
            }
        }
    }
}
