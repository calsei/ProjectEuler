using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P002
    {
        public P002() { }

        public void Solve(int max)
        {
            int num1 = 1, num2 = 2, sum = 2;

            while (num2 <= max)
            {
                int temp = num1 + num2;
                num1 = num2;
                num2 = temp;

                if (num2 % 2 == 0)
                    sum += num2;
            }

            Console.Write($"002. Even Fibonacci numbers: {sum}");
        }
    }
}
