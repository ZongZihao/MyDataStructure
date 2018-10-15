using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            var stack = new ArrayStack<int>(5);
            var res = stack.Pop();

            Console.WriteLine("Hello World!");
        }
    }
}
