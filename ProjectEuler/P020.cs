using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P020
    {
        public P020() {}

        public void Solve(int num)
        {
            ArrayList digits = new ArrayList() { 1 };
            int remaining = 0;

            for (int i = num; i > 0; i--)
            {
                for (int j = 0; j < digits.Count; j++)
                {
                    digits[j] = (int) digits[j] * i + remaining;
                    remaining = 0;

                    if ((int) digits[j] / 10 != 0)
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

            Console.Write($"020. Factorial digit sum: {sum}");
        }
    }
}
