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
        int n = 1;
        int level = 0;
        public P024() { }

        public void Solve()
        {
            Permute(new int[] { 0, 1, 2 }, 0);
        }

        public void Permute(int[] arr, int index)
        {
            if (index == arr.Length - 1)
                n++;

            if (n == 4)
            {
                Console.Write($"024. Lexicographic permutations: ");

                foreach (int a in arr)
                    Console.Write(a);
            }

            for (int i = index; i < arr.Length; i++)
            {
                int[] newArr = arr;
                int temp = newArr[index];

                for (int j = index; j < i; j++)
                    newArr[j] = newArr[j + 1];

                newArr[i] = temp;

                Permute(newArr, index + 1);
            }
        }
    }
}
