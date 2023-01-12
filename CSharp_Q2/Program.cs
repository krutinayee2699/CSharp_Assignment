using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Q2
{
    class Program2
    {
        public int ModuloOperations(int a , int b , int c)
        {
            return ((a % b) % c);
        }
        static void Main(string[] args)
        {
            Program2 p = new Program2();
            Console.WriteLine(p.ModuloOperations(8, 5, 2));
            Console.ReadKey();
        }
    }
}
