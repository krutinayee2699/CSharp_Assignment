using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Q7
{
    class Program7
    {
        public  bool ThreeIncreasingAdjacent(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] == arr[i] + 1 && (arr[i + 2] == arr[i] + 2))
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Program7 p = new Program7();
            Console.WriteLine(p.ThreeIncreasingAdjacent(new[] { 45, 23, 44, 68, 65, 70, 80, 81, 82 }));
            Console.WriteLine(p.ThreeIncreasingAdjacent(new[] { 7, 3, 5, 8, 9, 3, 1, 4 }));
            Console.ReadKey();

        }
    }
}
