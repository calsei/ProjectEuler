using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P012
    {
        public P012() { }

        public void Solve(int qty)
        {
            int divisors = 0, triangle = 1, num = 2;

            while (divisors <= qty)
            {
                divisors = 0;
                triangle += num;

                for (int i = 1; i <= Math.Sqrt(triangle); i++)
                {
                    if (triangle % i == 0 && i != Math.Sqrt(triangle))
                        divisors += 2;
                    else if (triangle % i == 0 && i == Math.Sqrt(triangle))
                        divisors++;
                }

                num++;
            }

            Console.Write($"012. Highly divisible triangular number: {triangle}");
        }
    }
}
