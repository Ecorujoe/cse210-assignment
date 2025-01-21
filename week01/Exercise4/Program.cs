using System;
using System. Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        //int number;
        Console.WriteLine("Enter a number[enter 0 to quit]: ");
        int userResponse = 0;
        do
        {
            Console.Write("Enter number: ");
            userResponse = int.Parse(Console.ReadLine());
            if (userResponse!= 0)
            {
                numbers.Add(userResponse);
            }
        } while (userResponse != 0);
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");


        float average = ((float) sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");



        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }

        Console.WriteLine($"The max is: {max}");


    }   
    
}