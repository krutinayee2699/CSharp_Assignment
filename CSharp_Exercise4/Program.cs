using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exercise4
{
    class Person
    {
        public string name; 
    }

    class Employee : Person, IPayable
    {
        public double salary;
        public string MailAddress;
        public double amountdue;

        public void Addtoamountdue()
        {
            Console.WriteLine("Enter Your Name :");
            string name = Console.ReadLine();
            Console.WriteLine("--------------------");

            Console.WriteLine("Enter Your Email Address :");
            MailAddress = Console.ReadLine();
            Console.WriteLine("--------------------");


            Console.WriteLine("Enter Your Salary :");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------");

            Console.WriteLine("Enter Add Amount :");
            double Addtoamountdue = Convert.ToDouble(Console.ReadLine());
            amountdue = salary - Addtoamountdue;
        }

        public void Retrieveamountdue()
        {
            Console.WriteLine("Your Retrieve Amount Is :" + amountdue);
        }

        public void Paymentaddress()
        {
            Console.WriteLine("Your Mail Address Is :" + MailAddress);
        }
    }

    class Amount
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            IPayable i = new Employee();

            i.Addtoamountdue();
            i.Retrieveamountdue();
            i.Paymentaddress();
            
        }
    }
        
}

