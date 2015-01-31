/*
 * Problem 15.* Age after 10 Years• 
 * This is a program that reads your birthday from the console and print how old you are now and how old you will be after 10 years.
*/
using System;

    class AfterTenYears
    {
        static void Main()
        {
                      
            DateTime now = DateTime.Now;
            DateTime birthDay;
            
            Console.WriteLine("The current date is {0} ", now);
            Console.WriteLine("Please, enter your birthday date in the following format DD.MM.YYYY: ");

            
            birthDay = Convert.ToDateTime(Console.ReadLine());
            // Calculate the difference in days between current date and birth date.
            TimeSpan diffDays = now.Subtract(birthDay);

            Console.WriteLine("Your age is " + diffDays.Days + " days");

            // Add 10 more years converted in days
            Console.WriteLine("After 10 years you'll be {0} days old", (int)diffDays.TotalDays + 3650);
            

        }
    }
