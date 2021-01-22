using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class OddOccurencesInArray
    {

        static void Main(string[] args)
        {

            int[] a = new int[] {9,3,9,3,9,7,9 };
            int res = Solution(a);
            Console.WriteLine(res);
        }

        private static int Solution(int[] a)
        {
            HashSet<int> hs = new HashSet<int>();
            for(int i=0; i<a.Length; i++)
            {
                if (hs.Contains(a[i]))
                {
                    hs.Remove(a[i]);
                }
                else
                {
                    hs.Add(a[i]);
                }
            }
            int res = Int32.MinValue;
            foreach (int x in hs)
                res = x;
            return res;
            //int[] res = hs.ToArray();
         
            
            //return res[0];
        }
    }
}