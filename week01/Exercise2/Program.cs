using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage ?");
        string grade = Console.ReadLine();

        int firstGrade = int.Parse(grade);
        string letter = "";

        if (firstGrade >= 90 )
    {
            letter = "A"; 
    }
        else if (firstGrade >= 80)
        {
            letter = "B";
        }
        else if (firstGrade>=70)
        {
            letter = "C";
        }
        else if (firstGrade>=60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"your grade is {letter}");
        
// write a seperate if statement to check if user excceds avarage garde of 70.
        if (firstGrade >=70)
        {
            Console.Write("Congartulation you passed !!");
        }
        else
        {
            Console.Write("Did not excced avarage Better luck next term.");
        }
            
        }
}