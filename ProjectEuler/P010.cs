using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P010
    {
        public P010() { }

        public void Solve(int max)
        {
            int sum = 0;

            for (int i = 0; i < max; i++)
            {
                if (Utility.IsPrime(i))
                sum += i;
            }

            Console.Write($"010. Summation of primes: {sum}");
        }
    }
}
