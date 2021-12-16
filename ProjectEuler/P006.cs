using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P006
    {
        public P006() { }

        public void Solve(int max)
        {
            int sumOfSquares = 0;
            int squareOfSums = 0;

            for (int i = 1; i <= max; i++)
            {
                sumOfSquares += i * i;
                squareOfSums += i;
            }

            squareOfSums *= squareOfSums;

            Console.Write($"006. Sum square difference: {squareOfSums - sumOfSquares}");
        }
    }
}
