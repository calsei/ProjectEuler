using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P023
    {
        public P023() { }

        public void Solve(int max)
        {
            ArrayList abundants = FindAbundants(max);
            bool[] isSumOfAbundants = new bool[max];
            
            foreach (int ab1 in abundants)
            {
                foreach (int ab2 in abundants) {
                    if (ab1 + ab2 <= max)
                        isSumOfAbundants[ab1 + ab2 - 1] = true;
                }
            }

            int sum = 0;

            for (int i = 0; i < isSumOfAbundants.Length; i++)
            {
                if (!isSumOfAbundants[i])
                    sum += i + 1;
            }

            Console.Write($"023. Non-abundant sums: {sum}");
        }

        public ArrayList FindAbundants(int max)
        {
            ArrayList list = new ArrayList();
            
            for (int i = 1; i <= max; i++)
            {
                int sum = 0;

                for (int j = 1; j <= Math.Sqrt(i); j++)
                {
                    if ((i % j == 0) && ((j == i / j) || (j == 1)))
                        sum += j;
                    else if ((i % j == 0))
                        sum += j + i / j;
                }

                if (sum > i)
                    list.Add(i);
            }

            return list;
        }
    }
}
