using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Q1
{
    class Program1
    {
        public void IsResultTheSame(int a , int b)
        {
            if(a == b)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static void Main(string[] args)
        {
            Program1 p = new Program1();
            p.IsResultTheSame(2 + 2, 2 * 2);
            p.IsResultTheSame(9 / 3, 16 - 1);

            Console.ReadKey();
        }
    }
}
