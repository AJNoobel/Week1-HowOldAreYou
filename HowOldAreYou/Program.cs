using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("What is your name?");
            //ReadLine() to read the user input from the console
            string UserName = Console.ReadLine();
            //Console.WriteLine("Hello, " + UserName + "!");
            //string interpolation
            Console.WriteLine($"Hello,{UserName}");

            Console.WriteLine("How Old Are You? Enter Digits Only:");

            int Age = Int32.Parse(Console.ReadLine());
            int YearOfBirth = 2021 - Age;

            Console.WriteLine($"You Were Born In {YearOfBirth}");


            Console.Read();
        }
    }
}
