using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your frst name ? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name ? ");
        string LastName = Console.ReadLine();

        Console.WriteLine($"Your name is {LastName}, {firstName} {LastName}.");
    }
}