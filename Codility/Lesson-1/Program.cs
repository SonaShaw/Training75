using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Solution(n));
            Console.WriteLine(BinaryGap(n));
        }


        private static int BinaryGap(int n)
        {
            var binary = Convert.ToString(n, 2);



            //Console.WriteLine(binary);
            var regex = new Regex("(?<=1)(0+)(?=1)");
            int result = regex.Matches(binary)
                .Cast<Match>()
                .Select(x => x.Length)
                .DefaultIfEmpty(0)
                .Max();
            return result;
        }
        private static int Solution(int n)
        {
            List<int> list = new List<int>();
            int initial = -1;
            int final = -1;

            for (int i = 0; n > 0; i++)
            {
                int rem = n % 2;
                if (rem == 1 && initial == -1)
                    initial = i;

                list.Add(rem);
                n = n / 2;
            }

            int max = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 1)
                {
                    final = i;
                    int len = (final - initial - 1);
                    if (len > max)
                        max = len;
                    initial = i;

                }
            }
            return max;

        }

    }

   
}
