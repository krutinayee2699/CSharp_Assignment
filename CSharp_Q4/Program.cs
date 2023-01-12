using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Q4
{
    class Program4
    {
        public bool IfSortedAscending(int a , int b , int c)
        {
            if(a <= b && b <= c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Program4 p = new Program4();
            Console.WriteLine(p.IfSortedAscending(3, 7, 10));
            Console.WriteLine(p.IfSortedAscending(74, 62, 99));
            Console.ReadKey();
        }
    }
}
