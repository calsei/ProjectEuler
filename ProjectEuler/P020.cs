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

            for (int i = num; i > 0; i--)
                Utility.DigitsArrayMult(digits, i);

            int sum = 0;

            foreach (int digit in digits)
                sum += digit;

            Console.Write($"020. Factorial digit sum: {sum}");
        }
    }
}
