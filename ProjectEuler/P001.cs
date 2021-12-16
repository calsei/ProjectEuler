using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P001
    {
        public P001() { }

        public void Solve(int max)
        {
            int sum = 0;

            for (int i = 0; i < max; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            Console.Write($"001. Multiples of 3 or 5: {sum}");
        }
    }
}
