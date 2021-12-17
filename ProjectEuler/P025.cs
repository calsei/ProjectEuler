using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P025
    {
        public P025() { }

        public void Solve(int max)
        {
            ArrayList n1 = new ArrayList() { 1 }, n2 = new ArrayList() { 1 };
            int index = 2;

            while (n2.Count < max)
            {
                ArrayList next = new ArrayList();
                int remaining = 0;
                index++;

                for (int i = 0; i < n2.Count; i++)
                {
                    if (i >= n1.Count)
                    {
                        next.Add((int)n2[i] + remaining);
                        remaining = 0;
                    }
                    else
                    {
                        next.Add((int)n1[i] + (int)n2[i] + remaining);
                        remaining = 0;

                        if ((int) next[i] / 10 > 0)
                        {
                            remaining = (int) next[i] / 10;
                            next[i] = (int) next[i] % 10;
                        }
                    }
                }

                while (remaining > 0)
                {
                    next.Add(remaining % 10);
                    remaining /= 10;
                }

                n1 = n2;
                n2 = next;
            }

            Console.Write($"025. 1000-digit Fibonacci number: {index}");
        }
    }
}
