using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Q6
{
    class Program6
    {
        public static int Two7sNextToEachOther(int[] digits)
        {
            int count = 0;

            for (int i = 0; i < digits.Length - 1; i++)
            {
                if (digits[i] == 7 && digits[i + 1] == 7)
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            int[] digits = { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 };
            int count = Two7sNextToEachOther(digits);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
