using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P024
    {
        ArrayList digits = new ArrayList() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        ArrayList currNum = new ArrayList() { };
        int i = 0;
        public P024() { }

        public void Solve(int max)
        {
            if (currNum.Count == 10)
            {
                i++;

                if (i == max)
                {
                    Console.Write("024. Lexicographic permutations: ");

                    foreach (int digit in currNum)
                        Console.Write(digit);
                }

            } 
            else if (i != max)
            {
                foreach (int digit in digits)
                {
                    if (i == max)
                        break;

                    if (!currNum.Contains(digit))
                    {
                        currNum.Add(digit);
                        Solve(max);
                        currNum.Remove(digit);
                    }
                        
                }
            }
        }
    }
}
