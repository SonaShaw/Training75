using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class CyclicRotaion
    {

        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 8, 9, 7, 6 };
            int[] res = Solution(a, 3);
            foreach(int x in res)
                Console.Write(x + " ");
        }
        private static int[] Solution(int[] a, int k)
        {
            int[] res = new int[a.Length];
            if (a.Length == 0)
                return a;
            if (k > a.Length)
                k = k % a.Length;
            for(int i=0; i<a.Length; i++)
            {
                res[i] = a[(a.Length - k + i) % a.Length];
            }
            return res;
        }

    }

    
}
