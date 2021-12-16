using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P014
    {
        public P014() { }

        public void Solve( int maxStart)
        {
            Int64 max = 0;
            int maxIndex = 0;

            for (int i = 2; i < maxStart; i++)
            {
                Int64 num = i;
                Int64 current = 1;
                while (num != 1)
                {
                    if (num % 2 == 0)
                        num /= 2;
                    else
                        num = 3 * num + 1;
                    current++;
                }

                max = Math.Max(max, current);
                if (max == current)
                    maxIndex = i;
            }

            Console.Write($"014. Longest Collatz sequence: {maxIndex}");
        }
    }
}
