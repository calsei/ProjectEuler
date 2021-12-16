using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P003
    {
        public P003() { }

        public void Solve(long num)
        {
            int largest = 0;

            for (int i = 1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0 && Utility.IsPrime(i))
                    largest = i;
            }

            Console.Write($"003. Largest prime factor: {largest}");
        }
    }
}
