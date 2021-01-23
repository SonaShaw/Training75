using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class PermMissingElement
    {
        

        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 3, 1, 5 };
            int res = Solution(a);
            Console.WriteLine(res);
        }

        private static int Solution(int[] a)
        {
            int[] temp = new int[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                int index = a[i]-1;
                temp[index]++;
            }
            int res=Int32.MinValue;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == 0)
                {
                    res = i + 1;
                    break;
                }
            }
            return res;
        }
    }
}
