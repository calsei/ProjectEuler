using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P026
    {
        public P026() { }

        public void Solve(int max)
        {
            int length = 0;
            int longest = 0;

            for (int i = max - 1; i >= 2; i--)
            {
                if (i <= length)
                    break;

                int value = 1, index = 0;
                int[] remainings = new int[i];

                while (remainings[value] == 0 && value != 0)
                {
                    remainings[value] = index;
                    value *= 10;
                    value %= i;
                    index++;
                }

                if (index - remainings[value] > length)
                {
                    length = index - remainings[value];
                    longest = i;
                }
            }

            Console.Write($"026. Reciprocal cycles: {longest}");
        }
    }
}
