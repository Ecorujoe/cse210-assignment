using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", "3", "5", "6");
        string example = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture = new Scripture();
        scripture.SetScripture(reference, example);

        string op = "";
        while (op != "quit")
        {
            Console.Clear();
            string response = scripture.getScripture();
            Console.WriteLine(response);
            Console.WriteLine("\nPlease enter to continue or type 'quit' to finish: ");
            op = Console.ReadLine().ToLower();
            Random rnd = new Random();
            int randonNumber = rnd.Next(1, 3);
            for (int i = 0; i < randonNumber; i++)
            {
                scripture.HideRandomWord();
            }
        }


    }
}