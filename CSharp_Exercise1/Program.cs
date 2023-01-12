using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Exercise1
{
    class Program
    {
        public void calAge(DateTime dob)
        {
            DateTime CDate = DateTime.Now;
            int age = CDate.Year - dob.Year;
            if(dob.Year <= CDate.Year)
            {
                if(age <= 120 && age > -1)
                {
                    Console.WriteLine("Age :" + age);
                }
            }
            else
            {
                Console.WriteLine("User not acceptable");
            }
            if(CDate.DayOfYear == dob.DayOfYear)
            {
                Console.WriteLine("Happy Birthday!!!");
            }
        }

        public void AstrologyWestern(DateTime dob)
        {
            String astrological_sign = " ";
            int month = dob.Month;
            int day = dob.Day;
            if(month == 12)
            {
                if (day < 22)
                    astrological_sign = "Sagittarius";
                else
                    astrological_sign = "Capricorn";
            }
            else if(month == 01)
            {
                if (day < 20)
                    astrological_sign = "Capricorn";
                else
                    astrological_sign = "Aquarius";
            }
            else if (month == 02)
            {
                if (day < 19)
                    astrological_sign = "Aquarius";
                else
                    astrological_sign = "Pisces";
            }
            else if (month == 03)
            {
                if (day < 21)
                    astrological_sign = "Pisces";
                else
                    astrological_sign = "Aries";
            }
            else if (month == 04)
            {
                if (day < 20)
                    astrological_sign = "Aries";
                else
                    astrological_sign = "Taurus";
            }
            else if (month == 05)
            {
                if (day < 21)
                    astrological_sign = "Taurus";
                else
                    astrological_sign = "Gemini";
            }
            else if (month == 06)
            {
                if (day < 21)
                    astrological_sign = "Gemini";
                else
                    astrological_sign = "Cancer";
            }
            else if (month == 07)
            {
                if (day < 23)
                    astrological_sign = "Cancer";
                else
                    astrological_sign = "Leo";
            }
            else if (month == 08)
            {
                if (day < 23)
                    astrological_sign = "Leo";
                else
                    astrological_sign = "Virgo";
            }
            else if (month == 09)
            {
                if (day < 23)
                    astrological_sign = "Virgo";
                else
                    astrological_sign = "Libra";
            }
            else if (month == 10)
            {
                if (day < 23)
                    astrological_sign = "Libra";
                else
                    astrological_sign = "Scorpio";
            }
            else if (month == 11)
            {
                if (day < 22)
                    astrological_sign = "Scorpio";
                else
                    astrological_sign = "Sagittarius";
            }
            Console.WriteLine("Astrological Sign :" + astrological_sign);
        }

        public void AstrologyChinese(DateTime dob)
        {
            int year = dob.Year;
            if (year % 12 == 0)
                Console.WriteLine("Chinese Astrological Sign:" + "MONKEY");
            else if(year % 12 == 1)
                Console.WriteLine("Chinese Astrological Sign:" + "ROOSTER");
            else if (year % 12 == 2)
                Console.WriteLine("Chinese Astrological Sign:" + "DOG");
            else if (year % 12 == 3)
                Console.WriteLine("Chinese Astrological Sign:" + "PIG");
            else if (year % 12 == 4)
                Console.WriteLine("Chinese Astrological Sign:" + "RAT");
            else if (year % 12 == 5)
                Console.WriteLine("Chinese Astrological Sign:" + "OX");
            else if (year % 12 == 6)
                Console.WriteLine("Chinese Astrological Sign:" + "TIGER");
            else if (year % 12 == 7)
                Console.WriteLine("Chinese Astrological Sign:" + "RABBIT");
            else if (year % 12 == 8)
                Console.WriteLine("Chinese Astrological Sign:" + "DRAGON");
            else if (year % 12 == 9)
                Console.WriteLine("Chinese Astrological Sign:" + "SNAKE");
            else if (year % 12 == 10)
                Console.WriteLine("Chinese Astrological Sign:" + "HORSE");
            else
                Console.WriteLine("Chinese Astrological Sign:" + "SHEEP");
        }
        static void Main()
        {
            Console.WriteLine("Enter Your Birthdate :");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            Program p = new Program();
            if(dob.Year > DateTime.Now.Year)
            {
                Console.WriteLine("Please Enter Correct Date");
            }
            p.calAge(dob);
            p.AstrologyWestern(dob);
            p.AstrologyChinese(dob);
            Console.ReadLine();
        }
    }
}
