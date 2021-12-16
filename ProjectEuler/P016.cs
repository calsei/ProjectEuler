using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P016
    {
        public P016() { }

        public void Solve(int power)
        {
            ArrayList digits = new ArrayList(); digits.Add(2);
            int remaining = 0;

            for (int i = 0; i < power - 1; i++)
            {
                for (int j = 0; j < digits.Count; j++)
                {
                    digits[j] = 2 * (int) digits[j] + remaining;
                    remaining = 0;

                    if ((int) digits[j] / 10 > 0)
                    {
                        remaining = (int) digits[j] / 10;
                        digits[j] = (int) digits[j] % 10;
                    }
                }

                while (remaining > 0)
                {
                    digits.Add(remaining % 10);
                    remaining /= 10;
                }
            }

            int sum = 0;

            foreach (int digit in digits)
                sum += digit;

            Console.Write($"016. Power digit sum: {sum}");
        }
    }
}
