using System;
using System.IO;
using System.Threading;

namespace pocAWS
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
             using (StreamWriter writer = System.IO.File.AppendText("poc.txt")) {
                writer.WriteLine($"{DateTime.Now}");
             }
             Thread.Sleep(1000 * 60 * 2);
            }
        }
    }
}
