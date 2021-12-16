using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P004
    {
        public P004() { }

        public void Solve(int max)
        {
            int largest = 0;

            for (int i = 100; i < max; i++)
            {
                for (int j = i; j < max; j++)
                {
                    if (Utility.IsPalindrome(i * j) && i * j > largest)
                        largest = i * j;
                }
            }

            Console.Write($"004. Largest palindrome product: {largest}");
        }
    }
}
