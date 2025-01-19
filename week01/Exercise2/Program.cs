using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage? ");
        string userGrade = Console.ReadLine();

        // using the letter g as user grade
        int g = int.Parse(userGrade);
        string letter = "";

        if (g >= 90)
        {
            letter = "A";
            
        }
        else if (g >= 80)
        {
            letter = "B";
        
        }
        else if (g >= 70)
        {
            letter = "C";
        }
        else if (g >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        if (g > 70)
        {
            Console.WriteLine("Congratulations you passed ");
        }
        else
        {
            Console.WriteLine("Faliure is a stepping stone to success. Try again next time.");
        }
    }
}