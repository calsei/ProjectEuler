using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal static class Utility
    {
        public static bool IsPrime(int n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                return false;

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        public static bool IsPalindrome(int n)
        {
            ArrayList digits = new ArrayList();

            while (n > 0)
            {
                digits.Add(n % 10);
                n /= 10;
            }

            for (int i = 0; i < digits.Count / 2; i++)
            {
                if (!digits[i].Equals(digits[digits.Count - 1 - i]))
                    return false;
            }

            return true;
        }

        public static int Max(ArrayList list)
        {
            int max = (int) list[0];

            foreach (int val in list)
            {
                max = Math.Max(max, val);
            }

            return max;
        }

        public static string[] QuickSort(string[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(arr, pivot + 1, right);
            }

            return arr;
        }

        private static int Partition(string[] arr, int left, int right)
        {
            string pivot = arr[left];
            while (true)
            {
                while (String.Compare(arr[left], pivot) < 0)
                    left++;

                while (String.Compare(arr[right], pivot) > 0)
                    right--;

                if (left < right)
                {
                    if (arr[left] == arr[right]) 
                        return right;

                    string temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                    return right;
            }
        }
    }
}
