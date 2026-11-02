using System;

class Program
{
    static void Main(string[] args)
    {
        displayWelcomeMessage();

        string username = promptUsername();
        int userNumber = promptUserNumber();

        int squareNumber = squaredNumber(userNumber);

        displayResult(username, squareNumber);
    }

    static void displayWelcomeMessage()
    {

        Console.WriteLine("Welcome to the Program");
    }
    static string promptUsername()
    {
        Console.Write("Plesae enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int promptUserNumber()
    {
        Console.Write("please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int squaredNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static  void displayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
    }