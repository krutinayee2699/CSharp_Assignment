using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Q10
{
    class Program10
    {
        public static string RevertWordsOrder(string input)
        {
            // Split the input string into an array of words
            string[] words = input.Split(' ');

            // Reverse the array of words
            Array.Reverse(words);

            // Join the reversed words back into a single string
            string output = string.Join(" ", words);

            // Return the reversed string
            return output;
        }


        static void Main(string[] args)
        {
            string input1 = "John Doe";
            string output1 = RevertWordsOrder(input1);
            Console.WriteLine(output1); 

            string input2 = "A, B. C";
            string output2 = RevertWordsOrder(input2);
            Console.WriteLine(output2); 

            Console.ReadKey();

        }
    }
}
