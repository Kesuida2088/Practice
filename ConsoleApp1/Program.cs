using System;
using System.IO;
using System.Text;
using System.Threading;

namespace Sample
{
    class Sample
    {
        static void Main()
        {
            StreamReader sr = new StreamReader(@"D:\C#\ConsoleApp1\bin\Debug\net8.0\Data\test.24o", Encoding.GetEncoding("UTF-8"));
            while (sr.EndOfStream == false)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                Thread.Sleep(1000);
            }

        }
    }
}