using System;

class Program
{
    static void Main(string[] args)
    {    
        //Console.Write("What is the magic number? ");
        // userNumber = Console.ReadLine(); 
        //int magicNumber = int.Parse(userNumber);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
        
        
        int userGuess = -1;
        while (number != userGuess)
        {
            Console.Write("What is Your guess? ");
            string guess = Console.ReadLine();
            userGuess = int.Parse(guess);
            
            if (number > userGuess)
            {
                Console.WriteLine("Higer");
            }
            else if (number < userGuess)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You have guessed it ");
            }
        }
    }
}