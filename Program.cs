using System;
using System.IO;

namespace pocAWS
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = System.IO.File.AppendText("poc.txt")) {
                writer.WriteLine($"{DateTime.Now}");
            }
        }
    }
}
