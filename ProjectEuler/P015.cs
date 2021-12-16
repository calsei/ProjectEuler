using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P015
    {
        Int64 qty = 0;
        Dictionary<string, Int64> paths = new Dictionary<string, Int64>();
        public P015() { }

        public void Solve(int size)
        {
            Move(0, 0, size);
            Console.Write($"015. Lattice paths: {qty}");
        }

        public Int64 Move(int x, int y, int size)
        {
            qty = 0;

            if (x == size || y == size)
                return 1;

            bool containsReverse = !paths.ContainsKey($"{x},{y}") && paths.ContainsKey($"{y},{x}");

            if (!(paths.ContainsKey($"{x},{y}") || paths.ContainsKey($"{y},{x}"))) {
                qty += Move(x + 1, y, size);
                qty += Move(x, y + 1, size);

                paths.Add($"{x},{y}", qty);
            }

            if (containsReverse)
                return paths[$"{y},{x}"];

            return paths[$"{x},{y}"];
        }
    }
}
