using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp_Exercise3
{
    class Person
    {
        private String FirstName;
        private String Email;
        private DateTime dob;
        DateTime cdate = DateTime.Now;

        public Person(String firstname, String email, DateTime dob)
        {
            this.FirstName = firstname;
            this.Email = email;
            this.dob = dob;
        }

        public void calAge(DateTime dob)
        {
            int age = cdate.Year - dob.Year;
            try
            {
                if(age <= 120 && age >= -1)
                {
                    Console.WriteLine("Person is Adult");
                    Console.WriteLine("--------------------");
                }
                throw new Exception();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void email(String email)
        {
            Email = email;
            try
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(Email);
                if (!match.Success)
                {
                    throw new Exception();
                }
                Console.WriteLine("Valid Emailid");
                Console.WriteLine("--------------------");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
    }
    class mainmethod
    {
        static void Main()
        {
            Console.WriteLine("Enter Your Name :");
            String fname = Console.ReadLine();
            Console.WriteLine("--------------------");

            Console.WriteLine("Enter Your Email :");
            String email = Console.ReadLine();
            Console.WriteLine("--------------------");

            Console.WriteLine("Enter Your BirthDate :");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("--------------------");

            Person p = new Person(fname, email, dob);

            mainmethod m = new mainmethod();
            p.email(email);
            p.calAge(dob);
            Console.ReadKey();
        }
    }
    
}
