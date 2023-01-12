using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Q9
{
    class Program9
    {
        public bool LettersBalance(string s)
        {
            // Get the length of the string
            int n = s.Length;

            // Check if the string is empty or has an odd number of characters
            if (n == 0 || n % 2 != 0)
            {
                return false;
            }

            // Get the first half of the string
            string firstHalf = s.Substring(0, n / 2);

            // Get the second half of the string
            string secondHalf = s.Substring(n / 2, n / 2);

            // Sort the first and second halves
            char[] firstHalfSorted = firstHalf.ToCharArray();
            Array.Sort(firstHalfSorted);
            char[] secondHalfSorted = secondHalf.ToCharArray();
            Array.Sort(secondHalfSorted);

            // Check if the sorted first and second halves are equal
            return firstHalfSorted.SequenceEqual(secondHalfSorted);
        }

        static void Main(string[] args)
        {
            Program9 p = new Program9();
            Console.WriteLine(p.LettersBalance("fgvgvf"));
            Console.WriteLine(p.LettersBalance("lampsmpser"));
            Console.ReadKey();
            

        }
    }
}
