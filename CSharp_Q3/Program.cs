using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Q3
{
    class Program3
    {
        public bool IfConsistsOfUppercaseLetters(string str)
        {
            if (str.Length != 3)
            {
                return false;
            }

            // Check if each character in the string is uppercase
            foreach (char c in str)
            {
                if (!char.IsUpper(c))
                {
                    return false;
                }
            }

            return true;
            
        }
        static void Main(string[] args)
        {
            Program3 p = new Program3();
            Console.WriteLine(p.IfConsistsOfUppercaseLetters("xyz"));
            Console.WriteLine(p.IfConsistsOfUppercaseLetters("DOG"));
            Console.WriteLine(p.IfConsistsOfUppercaseLetters("L9#"));
            Console.ReadKey();
        }
    }
}
