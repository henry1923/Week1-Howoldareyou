using System;

namespace Howoldareyou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?!");
            string UserName = Console.ReadLine();
            //Console.WriteLine("Hello," + UserName + "!");
            //String interpolation
            Console.WriteLine($"Hello, {UserName}");

            Console.WriteLine("How old are you? Enter digits only;");

            int Age = Int32.Parse(Console.ReadLine());

            int YearOfBirth = 2021 - Age;
            //Console.WriteLine("You were born in ");
            Console.WriteLine($"You were born in {YearOfBirth}");



        }
    }
}