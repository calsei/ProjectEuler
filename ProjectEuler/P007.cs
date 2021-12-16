using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P007
    {
        public P007() { }

        public void Solve(int num)
        {
            int count = 0, n = 1;

            while (count < num)
            {
                n++;
                if (Utility.IsPrime(n))
                    count++;
            }

            Console.Write($"007. 10001st prime: {n}");
        }
    }
}
