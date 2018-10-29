using System;
using System.Collections.Generic;
using System.Diagnostics;
using static DataStructure._11_sorts.FindKth;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            //SortsTime.Time();

            //FindsTime.Time();

            int[] list = { 1, 2, 3, 4, 5, 5, 6, 7, 8, 8, 8, 9 };
            int res = BinarySearch.BsearchFirst(list, 8);
            Console.WriteLine(res);

            
            Console.Read();
        }
    }
}
