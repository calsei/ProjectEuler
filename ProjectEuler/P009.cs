using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P009
    {
        public P009() { }

        public void Solve(int sum)
        {
            int b = (int) Math.Ceiling((double) sum / 3), c = b + 1, a = sum - c - b;

            while (a + b + c != sum || a * a + b * b != c * c)
            {
                if (a > b || b == 2)
                {
                    c += 1;
                    b = c - 1;
                }

                b -= 1;
                a = sum - c - b;
            }

            Console.Write($"009. Special Pythagorean triplet: {a * b * c}");
        }
    }
}
