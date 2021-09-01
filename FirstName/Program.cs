using System;

namespace FirstName
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello, what is your first name?");
             string Firstname = Console.ReadLine();
             Console.WriteLine("What is your surname?");
             string Surname = Console.ReadLine();
             Console.WriteLine($"Hello {Firstname} {Surname}");


        }
    }
}
