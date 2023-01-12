using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Q5
{
    class Program5
    {
        public bool IfNumberContains3(int num)
        {
            while (num > 0)
            {
                if (num % 10 == 3)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Program5 p = new Program5();
            Console.WriteLine(p.IfNumberContains3(7201432));
            Console.WriteLine(p.IfNumberContains3(87501));
            Console.ReadKey();
        }
    }
}
