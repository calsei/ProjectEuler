using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P019
    {
        public P019() { }

        public void Solve(DateTime firstSunday, int lastYear)
        {
            int sundays = 0;
            DateTime date = firstSunday;

            while (date.Year <= lastYear)
            {
                date = date.AddDays(1);
                if (date.DayOfWeek == DayOfWeek.Sunday && date.Day == 1)
                    sundays++;
            }

            Console.Write($"019. Counting sundays: {sundays}");
        }
    }
}
