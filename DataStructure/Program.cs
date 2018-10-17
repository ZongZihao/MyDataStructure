using System;
using System.Diagnostics;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();

            sw.Start();
            ulong n = Recursive.Fib3(8000);
            sw.Stop();
            string t1 = sw.Elapsed.ToString();
            Console.WriteLine(n + "   " + t1);


            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
