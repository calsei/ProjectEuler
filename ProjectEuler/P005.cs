using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P005
    {
        public P005() { }

        public void Solve(int num)
        {
            bool done = false;
            int smallest = num - 1;

            while (!done)
            {
                smallest++;
                done = true;

                for (int i = 2; i <= num; i++)
                {
                    done = done && smallest % i == 0;
                    if (!done)
                        break;
                }
            }

            Console.Write($"005. Smallest multiple: {smallest}");
        }
    }
}
