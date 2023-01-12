using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Q8
{
    class Program8
    {
        public static string ExtractString(string input)
        {
            // Find the first occurrence of ##
            int startIndex = input.IndexOf("##");
            if (startIndex == -1)
            {
                // There is no ## in the input string
                return string.Empty;
            }

            // Find the second occurrence of ##
            int endIndex = input.IndexOf("##", startIndex + 2);
            if (endIndex == -1)
            {
                // There is only one occurrence of ## in the input string
                return string.Empty;
            }

            // Get the substring between the two occurrences of ##
            return input.Substring(startIndex + 2, endIndex - startIndex - 2);
        }

        static void Main(string[] args)
        {
            string result1 = ExtractString("##abc##def");
            string result2 = ExtractString("12####78");
            string result3 = ExtractString("gar##d#en");
            string result4 = ExtractString("++##--##++");
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.ReadKey();

        }
    }
}
