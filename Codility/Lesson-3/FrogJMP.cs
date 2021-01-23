using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class FrogJMP
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10, 85, 30));
        }
        
        private static int Solution(int x, int y, int d)
        {
            int diff = y - x;
            int jump;
            if(diff % d == 0)
            {
                jump = diff / d;
            }
            else
            {
                jump = diff / d + 1;
            }
            return jump;
        }
    }
}
