using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P016
    {
        public P016() { }

        public void Solve(int power)
        {
            ArrayList digits = new ArrayList(); digits.Add(2);

            for (int i = 0; i < power - 1; i++)
                Utility.DigitsArrayMult(digits, 2);

            int sum = 0;

            foreach (int digit in digits)
                sum += digit;

            Console.Write($"016. Power digit sum: {sum}");
        }
    }
}
