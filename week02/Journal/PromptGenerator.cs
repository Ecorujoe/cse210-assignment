public class PromptGenerator
{
    public List<string> _prompt;
    public PromptGenerator()
    {
        _prompt = new List<string>()
        {
            "Who was the most interesting person you interacted with today?",
            "What was the best part of my day?",
            "How did you see the hand of the Lord in my life today?",
            "Count you many blessings",
            "What made today interesting"
        };
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }
}