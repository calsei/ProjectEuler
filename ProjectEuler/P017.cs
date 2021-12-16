using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P017
    {
        Dictionary<int, string> words = new Dictionary<int, string>() { { 0, "" }, { 1, "one" }, { 2, "two" }, { 3, "three" },{ 4, "four" }, { 5, "five" }, { 6, "six" }, { 7, "seven" }, { 8, "eight" }, { 9, "nine" }, { 10, "ten" }, { 11, "eleven" }, { 12, "twelve" }, { 13, "thirteen" }, { 14, "fourteen" }, { 15, "fifteen" }, { 16, "sixteen" }, { 17, "seventeen" }, { 18, "eighteen" }, { 19, "nineteen" }, { 20, "twenty" }, { 30, "thirty" }, { 40, "forty" }, { 50, "fifty" }, { 60, "sixty" }, { 70, "seventy" }, { 80, "eighty" }, { 90, "ninety" }, { 100, "hundred" }, { 1000, "thousand" }, { -1, "and" } };
        public P017() { }

        public void Solve(int max)
        {
            int sum = 0;

            for (int i = 0; i <= max; i++)
            {
                int thousands = i / 1000;
                int hundreds = i % 1000 / 100;
                int rest = i % 100;
                int tens = i % 100 / 10;
                int units = i % 10;

                if (thousands > 0)
                {
                    sum += words[thousands].Length + words[1000].Length;

                    if (hundreds == 0 && rest > 0)
                        sum += words[-1].Length;
                }

                if (hundreds > 0)
                {
                    sum += words[hundreds].Length + words[100].Length;
                    
                    if (rest > 0)
                        sum += words[-1].Length;
                }
                    
                if (rest < 20)
                    sum += words[rest].Length;
                else
                    sum += words[tens * 10].Length + words[units].Length;
            }

            Console.Write($"017. Number letter counts: {sum}");
        }
    }
}
