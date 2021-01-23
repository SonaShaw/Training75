using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class TapeEquilibrium
    {
        static void Main(string[] args)
        {
            int[] a= new int[] { 5,6,2,4,1};
            int res = Solution(a);
            Console.WriteLine(res);

        }

        private static int Solution(int[] a)
        {
            int sum = 0;
            foreach (int x in a)
                sum = sum + x;
            int left = a[0];
            int right = sum - a[0];
            int min = Math.Abs(left - right);
            for(int i=1; i<a.Length-1; i++)
            {
                left = left + a[i];
                right = right - a[i];
                int diff = Math.Abs(left - right);
                if (diff < min)
                    min = diff;
            }
            return min;

        }
    }
}
