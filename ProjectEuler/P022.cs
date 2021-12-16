using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P022
    {
        public P022() { }

        public void Solve()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\charl\source\repos\ProjectEuler\p022_names.txt");
            text = text.Substring(1, text.Length - 2);
            string[] names = text.Split("\",\"");

            names = Utility.QuickSort(names, 0, names.Length - 1);

            int total = 0;

            for (int i = 0; i < names.Length; i++)
            {
                foreach (char letter in names[i])
                {
                    total += (i + 1) * ((int) letter - 64);
                }
            }

            Console.Write($"022. Names scores: {total}");
        }
    }
}
