using System;

namespace Part_5_REWORK
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            int Category;
            Console.WriteLine("Please Enter Your Age: ");
            while (!Int32.TryParse(Console.ReadLine(), out Age) || Age <= 0) ;

            if (Age >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else if (Age <= 5)
            {
                Console.WriteLine("You are a toddler");
            }
            else if (Age <= 10)
            {
                Console.WriteLine("You are a child");
            }
            else if (Age >= 12)
            {
                Console.WriteLine("You are a preteen");
            }
            else
            {
                Console.WriteLine("Error");

            }
            Console.WriteLine("");


                Console.WriteLine("Enter a Category of Storm");
                while (!Int32.TryParse(Console.ReadLine(), out Category) || Category <= 0) ;

                if (Category == 1)
                {
                    Console.WriteLine("Wind speeds will range between 119-153 km/hr");
                }
                else if (Category == 2)
                {
                    Console.WriteLine("Wind speeds will range between 154-177 km/hr");
                }
                else if (Category == 3)
                {
                    Console.WriteLine("Wind speeds will range between 178-209 km/hr");
                }
                else if (Category == 4)
                {
                    Console.WriteLine("Wind speeds will range between 210-249 km/hr");
                }
                else if (Category == 5)
                {
                    Console.WriteLine("Wind speeds will be greater than 249km/hr");

                }
                else
                    Console.WriteLine("Error");
            }
        }
    }
