using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    internal class P018
    {
        int[][] tree = new int[15][];
        int max = 0, curr = 0;
        Dictionary<string, int> total = new Dictionary<string, int>();
        
        public P018() {
            Init();
        }

        private void Init()
        {
            tree[0]  = new int[] { 75 };
            tree[1]  = new int[] { 95, 64 };
            tree[2]  = new int[] { 17, 47, 82 };
            tree[3]  = new int[] { 18, 35, 87, 10 };
            tree[4]  = new int[] { 20, 04, 82, 47, 65 };
            tree[5]  = new int[] { 19, 01, 23, 75, 03, 34 };
            tree[6]  = new int[] { 88, 02, 77, 73, 07, 63, 67 };
            tree[7]  = new int[] { 99, 65, 04, 28, 06, 16, 70, 92 };
            tree[8]  = new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 };
            tree[9]  = new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 };
            tree[10] = new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 };
            tree[11] = new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 };
            tree[12] = new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 };
            tree[13] = new int[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 };
            tree[14] = new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 };
        }

        public void Solve()
        {
            for (int i = tree.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < tree[i].Length - 1; j++)
                    tree[i - 1][j] += Math.Max(tree[i][j], tree[i][j + 1]);
            }

            Console.Write($"018. Maximum path sum I: {tree[0][0]}");
        }
    }
}