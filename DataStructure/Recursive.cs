using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Recursive
    {
        private static Dictionary<int, ulong> hasSovledList = new Dictionary<int, ulong>();
        public static ulong Fib(int n)
        {
            if (n == 1 || n == 2) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        public static ulong Fib2(int n)
        {
            if (n == 1 || n == 2) return 1;

            if (hasSovledList.ContainsKey(n))
                return hasSovledList[n];

            ulong res = Fib2(n - 1) + Fib2(n - 2);
            hasSovledList.Add(n, res);
            return res;
        }

        public static ulong Fib3(int n)
        {
            if (hasSovledList.ContainsKey(n))
                return hasSovledList[n];
            if (n == 1 || n == 2) return 1;

            ulong res = Fib3(n - 1) + Fib3(n - 2);
            hasSovledList.Add(n, res);
            return res;
        }

    }
}
