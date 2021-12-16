using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P021
    {
        Dictionary<int, int> sums = new Dictionary<int, int>();
        public P021() { }

        public void Solve(int max)
        {
            int sumOfAmicables = 0;

            for (int i = 1; i < max; i++)
            {
                int sum = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }

                sums.Add(i, sum);

                if (sums.ContainsKey(sum) && sums[sum] == i && sum != i)
                {
                    sumOfAmicables += sums[i] + sums[sum];
                }
            }

            Console.Write($"021. Amicable numbers: {sumOfAmicables}");
        }
    }
}
